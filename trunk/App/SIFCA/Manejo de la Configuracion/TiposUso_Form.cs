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
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
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
            if (ListadoTiposUso.Columns[e.ColumnIndex].Name == "Acciones")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoTiposUso.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                typeUse = new TIPODEUSO();

                typeUse = typeUseBl.GetTypeUse(row.Cells[1].Value.ToString());

                updateNombreTxt.Text = typeUse.NOMBRETIPOUSO;
                updateDescripcionTxt.Text = typeUse.DESCRIPCION;
                panel1.Hide();
                panel2.Hide();
                panel3.Show();
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateDescripcionTxt.Text != "")
            {
                typeUse.NOMBRETIPOUSO= updateNombreTxt.Text;
                typeUse.DESCRIPCION= updateDescripcionTxt.Text;
                MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateNombreTxt.Text = "";
                updateDescripcionTxt.Text = "";
                ListadoTiposUso.Refresh();
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
            panel3.Hide();
            panel1.Hide();
            panel2.Show();
        }

    }
    
}
