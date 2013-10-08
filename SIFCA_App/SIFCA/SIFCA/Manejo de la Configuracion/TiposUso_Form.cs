using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_DAL;
using SIFCA_BLL;

namespace SIFCA.Gestion_Configuracion
{
    public partial class TiposUso_Form : Form
    {
        private TIPODEUSO typeUse;
        private TypeUseBL typeUseBl;

        public TiposUso_Form()
        {
            InitializeComponent();
            typeUseBl = new TypeUseBL(Program.ContextData);
            TypeUseBSource.DataSource = typeUseBl.GetTypeUse();
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
        }

           private void Btn_Crear_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "" && txt_Descripcion.Text != "")
            {
                typeUse = new TIPODEUSO();
                typeUse.NOMBRETIPOUSO = txt_Nombre.Text;
                typeUse.DESCRIPCION = txt_Descripcion.Text;
                typeUseBl.InsertTypeUse(typeUse);
                typeUseBl.SaveChanges();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TypeUseBSource.DataSource = typeUseBl.GetTypeUse();
                ListadoTiposUso.Refresh();
                txt_Nombre.Text = "";
                txt_Descripcion.Text = "";
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
            if (ListadoTiposUso.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoTiposUso.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                typeUse = new TIPODEUSO();

                typeUse = typeUseBl.GetTypeUse(row.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Process message box results
                switch (result)
                {
                    case DialogResult.OK:
                        typeUseBl.DeleteTypeUse(typeUse.NOMBRETIPOUSO);
                        typeUseBl.SaveChanges();
                        TypeUseBSource.DataSource = typeUseBl.GetTypeUse();
                        ListadoTiposUso.Refresh();
                        pn_listado.Show();
                        pn_crear.Hide();
                        pn_editar.Hide();
                        break;

                    case DialogResult.Cancel:
                        // User pressed Cancel button
                        // ...
                        break;
                }
                this.Width = pn_listado.Width;
                this.Height = pn_listado.Height;
                this.CenterToScreen();
            }

            if (ListadoTiposUso.Columns[e.ColumnIndex].Name == "Editar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoTiposUso.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                typeUse = new TIPODEUSO();

                typeUse = typeUseBl.GetTypeUse(row.Cells[0].Value.ToString());

                updateNombreTxt.Text = typeUse.NOMBRETIPOUSO;
                updateDescripcionTxt.Text = typeUse.DESCRIPCION;
                pn_listado.Hide();
                pn_crear.Hide();
                pn_editar.Show();
                this.Width = pn_editar.Width;
                this.Height = pn_editar.Height;
                this.CenterToScreen();
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateDescripcionTxt.Text != "")
            {
                typeUse.NOMBRETIPOUSO= updateNombreTxt.Text;
                typeUse.DESCRIPCION= updateDescripcionTxt.Text;
                typeUseBl.UpdateTypeUse(typeUse);
                typeUseBl.SaveChanges();
                MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateNombreTxt.Text = "";
                updateDescripcionTxt.Text = "";
                ListadoTiposUso.Refresh();
                pn_listado.Show();
                pn_crear.Hide();
                pn_editar.Hide();
                this.Width = pn_listado.Width;
                this.Height = pn_listado.Height;
                this.CenterToScreen();
            }
        }

        private void Btn_CancelarUpdate_Click(object sender, EventArgs e)
        {
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();

        }

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            if (busquedaTxt.Text != "")
            {
                if (criterioCbx.SelectedItem.ToString()!="")
                {
                    string criteria = criterioCbx.SelectedItem.ToString();
                    TypeUseBSource.DataSource = typeUseBl.SearchType(busquedaTxt.Text, criteria);
                    ListadoTiposUso.Refresh();              
                }
                else
                {
                    TypeUseBSource.DataSource = typeUseBl.GetTypeUse();
                    ListadoTiposUso.Refresh(); 
                }
            }
            else
            {
                TypeUseBSource.DataSource = typeUseBl.GetTypeUse();
                ListadoTiposUso.Refresh();            
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            pn_editar.Hide();
            pn_listado.Hide();
            pn_crear.Show();
            this.Width = pn_crear.Width;
            this.Height = pn_crear.Height;
            this.CenterToScreen();
        }

    }
    
}
