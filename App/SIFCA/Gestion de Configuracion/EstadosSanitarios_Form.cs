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
    public partial class EstadosSanitarios_Form : Form
    {
        ESTADOSANITARIO state;
        StateBL stateBL;
        public EstadosSanitarios_Form()
        {
            InitializeComponent();
            state = new ESTADOSANITARIO();
            stateBL = new StateBL(Program.ContextData);
            StateBSource.DataSource = stateBL.GetStates();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();

        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            state= new ESTADOSANITARIO();
            state = new ESTADOSANITARIO();
            if (txt_Nombre.Text != "" && txt_Descripcion.Text != "")
            {
                state.ESTADO = txt_Nombre.Text;
                state.DESCRIPESTADO = txt_Descripcion.Text;
                stateBL.InsertSpecie(state);
                stateBL.SaveChanges();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StateBSource.DataSource = stateBL.GetStates();
                ListadoEstados.Refresh();
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
            if (ListadoEstados.Columns[e.ColumnIndex].Name == "Acciones")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoEstados.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                state = new ESTADOSANITARIO();
                
                state = stateBL.GetState(row.Cells[1].Value.ToString());

                updateNombreTxt.Text = state.ESTADO;
                updateDescripTxt.Text = state.DESCRIPESTADO;
                panel1.Hide();
                panel2.Hide();
                panel3.Show();
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateDescripTxt.Text != "")
            {
                state.ESTADO = updateNombreTxt.Text;
                state.DESCRIPESTADO = updateDescripTxt.Text;
                MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateDescripTxt.Text = "";
                updateNombreTxt.Text = "";
                ListadoEstados.Refresh();
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
                string criteria = criterioCbx.SelectedItem.ToString();
                if (criteria == "Descripcion")
                {
                    ListadoEstados.DataSource = stateBL.SearchStates(busquedaTxt.Text, criteria);
                    ListadoEstados.Refresh();
                }
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
