using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;
using SIFCA_DAL;

namespace SIFCA.Gestion_Configuracion
{
    public partial class Calidad_Form : Form
    {
        private CALIDAD quality;
        private QualityBL qualityBl;

        public Calidad_Form()
        {
            InitializeComponent();
            qualityBl = new QualityBL(Program.ContextData);
            QualityBSource.DataSource = qualityBl.GetQualities();
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            if (txt_Descripcion.Text != "")
            {                
                quality = new CALIDAD();
                quality.DESCRIPCALIDAD = txt_Descripcion.Text;
                qualityBl.InsertQuality(quality);
                qualityBl.SaveChanges();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QualityBSource.DataSource = qualityBl.GetQualities();
                ListadoCalidades.Refresh();
                pn_crear.Hide();
                pn_listado.Show();
                pn_editar.Hide();
                this.Width = pn_listado.Width;
                this.Height = pn_listado.Height;
                this.CenterToScreen();
            }

        }

        private void ListadoDeEspecies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (ListadoCalidades.Columns[e.ColumnIndex].Name == "Editar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoCalidades.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                quality= new CALIDAD();

                quality = qualityBl.GetQuality((Decimal)row.Cells[0].Value);

                updateNombreTxt.Text =  quality.CODCALIDAD.ToString();
                updateDescripcionTxt.Text = quality.DESCRIPCALIDAD;
                pn_listado.Hide();
                pn_crear.Hide();
                pn_editar.Show();
                this.Width = editarGbx.Width;
                this.Height = editarGbx.Height;
                this.CenterToScreen();
            }

            if (ListadoCalidades.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoCalidades.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                quality = new CALIDAD();

                quality = qualityBl.GetQuality((Decimal)row.Cells[0].Value);

                DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Process message box results
                switch (result)
                {
                    case DialogResult.OK:
                        qualityBl.DeleteQuality((Decimal)quality.CODCALIDAD);
                        qualityBl.SaveChanges();
                        QualityBSource.DataSource = qualityBl.GetQualities();
                        ListadoCalidades.Refresh();
                        pn_listado.Show();
                        pn_crear.Hide();
                        pn_editar.Hide();                
                        break;

                    case DialogResult.Cancel:
                        // User pressed Cancel button
                        // ...
                        break;
                }
                this.Width = ListadoCalidades.Width;
                this.Height = ListadoCalidades.Height;
                this.CenterToScreen();
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateDescripcionTxt.Text != "")
            {
                quality.DESCRIPCALIDAD = updateDescripcionTxt.Text;
                qualityBl.UpdateQuality(quality);
                qualityBl.SaveChanges();
                MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateDescripcionTxt.Text = "";
                updateNombreTxt.Text = "";
                QualityBSource.DataSource = qualityBl.GetQualities();
                ListadoCalidades.Refresh();
                pn_listado.Show();
                pn_crear.Hide();
                pn_editar.Hide();
                this.Width = ListadoCalidades.Width;
                this.Height = ListadoCalidades.Height;
                this.CenterToScreen();
            }
        }

        private void Btn_CancelarUpdate_Click(object sender, EventArgs e)
        {
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
            this.Width = ListadoCalidades.Width;
            this.Height = ListadoCalidades.Height;
            this.CenterToScreen();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = ListadoCalidades.Width;
            this.Height = ListadoCalidades.Height;
            this.CenterToScreen();

        }

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            if (busquedaTxt.Text != "")
            {                
                QualityBSource.DataSource = qualityBl.SearchType(busquedaTxt.Text);
                ListadoCalidades.Refresh();                                                    
            }
            else
            {
                QualityBSource.DataSource = qualityBl.GetQualities();
                ListadoCalidades.Refresh();
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            pn_editar.Hide();
            pn_listado.Hide();
            pn_crear.Show();
            this.Width = crearGbx.Width;
            this.Height = crearGbx.Height;
            this.CenterToScreen();

        }
    }

 }