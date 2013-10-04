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
    public partial class TiposMuestrales_Form : Form
    {
         private TIPODISENOMUESTRAL tipo;
        private TypeSampleDesignBl typeBl;
        public TiposMuestrales_Form()
        {
            InitializeComponent();
            typeBl = new TypeSampleDesignBl(Program.ContextData);
            TypeSampleDesingBSource.DataSource = typeBl.GetTypeSampleDesignList();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            tipo = new TIPODISENOMUESTRAL();
            if (txt_Nombre.Text != "" && txt_Descripcion.Text != "")
            {                
                tipo.NOMTIPODISEMUEST = txt_Nombre.Text;
                tipo.DESCRIPTIPODISEMUEST = txt_Descripcion.Text;
                typeBl.InsertTypeSampleDesign(tipo);
                typeBl.SaveChanges();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TypeSampleDesingBSource.DataSource = typeBl.GetTypeSampleDesignList();
                ListadoTiposMuestrales.Refresh();
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
            if (ListadoTiposMuestrales.Columns[e.ColumnIndex].Name == "Acciones")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoTiposMuestrales.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                tipo= new TIPODISENOMUESTRAL();

                tipo = typeBl.GetTypeSampleDesign(row.Cells[1].Value.ToString());

                updateNombreTxt.Text = tipo.NOMTIPODISEMUEST;
                updateDescripcionTxt.Text = tipo.DESCRIPTIPODISEMUEST;
                panel1.Hide();
                panel2.Hide();
                panel3.Show();
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "" && txt_Descripcion.Text != "")
            {
                tipo.NOMTIPODISEMUEST = txt_Nombre.Text;
                tipo.DESCRIPTIPODISEMUEST = txt_Descripcion.Text;
                MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Nombre.Text = "";
                txt_Descripcion.Text = "";
                TypeSampleDesingBSource.DataSource = typeBl.GetTypeSampleDesignList();
                ListadoTiposMuestrales.Refresh();
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
                    TypeSampleDesingBSource.DataSource = typeBl.SearchType(busquedaTxt.Text, criteria);
                    ListadoTiposMuestrales.Refresh();                    
                }
                else
                {
                    TypeSampleDesingBSource.DataSource = typeBl.GetTypeSampleDesignList();
                    ListadoTiposMuestrales.Refresh();
                }
            }
            else
            {
                TypeSampleDesingBSource.DataSource = typeBl.GetTypeSampleDesignList();
                ListadoTiposMuestrales.Refresh();
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

