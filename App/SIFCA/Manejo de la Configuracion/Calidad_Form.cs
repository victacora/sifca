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
                panel2.Hide();
                panel1.Show();
                panel3.Hide();
            }

        }

        private void ListadoDeEspecies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (ListadoCalidades.Columns[e.ColumnIndex].Name == "Acciones")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoCalidades.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                quality= new CALIDAD();

                quality = qualityBl.GetQuality((Decimal)row.Cells[1].Value);

                updateNombreTxt.Text =  quality.CODCALIDAD.ToString();
                updateDescripcionTxt.Text = quality.DESCRIPCALIDAD;
                panel1.Hide();
                panel2.Hide();
                panel3.Show();
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateNombreTxt.Text != "" && txt_Descripcion.Text != "")
            {
                quality.DESCRIPCALIDAD = txt_Descripcion.Text;
                MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateNombreTxt.Text = "";
                txt_Descripcion.Text = "";
                QualityBSource.DataSource = qualityBl.GetQualities();
                ListadoCalidades.Refresh();
                panel1.Show();
                panel2.Hide();
                panel3.Hide();
            }
        }

        private void Btn_CancelarUpdate_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel1.Show();

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
            panel3.Hide();
            panel1.Hide();
            panel2.Show();
        }
    }

 }