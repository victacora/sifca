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
            state =  Program.ContextData.ESTADOSANITARIO.Create();
            stateBL = new StateBL(Program.ContextData);
            StateBSource.DataSource = stateBL.GetStates();
            criterioCbx.SelectedIndex = 0;
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            state= Program.ContextData.ESTADOSANITARIO.Create();
            if (txt_Nombre.Text != "" && txt_Descripcion.Text != "")
            {
                if (stateBL.GetState(txt_Nombre.Text) != null) eP_errors.SetError(txt_Nombre, "Ingrese una abreviatura diferente, esta ya esta en uso");
                else
                {
                    eP_errors.Dispose();
                    state.ESTADO = txt_Nombre.Text.ToString();
                    state.DESCRIPESTADO = txt_Descripcion.Text.ToString();
                    stateBL = new StateBL(Program.ContextData);
                    stateBL.InsertState(state);
                    string result = stateBL.SaveChanges();
                    if (result == "")
                    {
                        MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(result);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
                    StateBSource.DataSource = stateBL.GetStates();
                    txt_Nombre.Text = "";
                    txt_Descripcion.Text = "";
                    ListadoEstados.Refresh();
                    pn_crear.Hide();
                    pn_listado.Show();
                    pn_editar.Hide();
                    this.Width = pn_listado.Width;
                    this.Height = pn_listado.Height;
                    this.CenterToScreen();
                }
            }
            else
            {
                if (txt_Nombre.Text == "") eP_errors.SetError(txt_Nombre, "Ingrese una abreviatura, este campo es requerido");
                if (txt_Descripcion.Text == "") eP_errors.SetError(txt_Descripcion, "Ingrese una descripción, este campo es requerido");
            }

        }

        private void ListadoDeEspecies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (ListadoEstados.Columns[e.ColumnIndex].Name == "Editar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoEstados.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                state = Program.ContextData.ESTADOSANITARIO.Create();
                
                state = stateBL.GetState(row.Cells[0].Value.ToString());

                updateNombreTxt.Text = state.ESTADO;
                updateDescripTxt.Text = state.DESCRIPESTADO;
                pn_listado.Hide();
                pn_crear.Hide();
                pn_editar.Show();
                this.Width = editarGbx.Width;
                this.Height = editarGbx.Height;
                this.CenterToScreen();
            }

            if (ListadoEstados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoEstados.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                state = Program.ContextData.ESTADOSANITARIO.Create();

                state = stateBL.GetState(row.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Process message box resultados
                switch (result)
                {
                    case DialogResult.OK:
                        stateBL.DeleteState(state.ESTADO);
                        string resultD = stateBL.SaveChanges();
                        if (resultD == "")
                        {
                            MessageBox.Show("Se elimino de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Error_Form errorForm = new Error_Form(resultD);
                            errorForm.MdiParent = ParentForm;
                            errorForm.Show();
                        }
                        StateBSource.DataSource = stateBL.GetStates();
                        ListadoEstados.Refresh();
                        pn_listado.Show();
                        pn_crear.Hide();
                        pn_editar.Hide();
                        break;

                    case DialogResult.Cancel:
                        // User pressed Cancel button
                        // ...
                        break;
                }
            }


        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateDescripTxt.Text != "")
            {
                eP_errors.Dispose();
                state.ESTADO = updateNombreTxt.Text;
                state.DESCRIPESTADO = updateDescripTxt.Text;
                stateBL.UpdateState(state);
                string resultUpd = stateBL.SaveChanges();
                if (resultUpd == "")
                {
                    MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    Error_Form errorForm = new Error_Form(resultUpd);
                    errorForm.MdiParent = ParentForm;
                    errorForm.Show();
                }
                updateDescripTxt.Text = "";
                updateNombreTxt.Text = "";
                ListadoEstados.Refresh();
                pn_listado.Show();
                pn_crear.Hide();
                pn_editar.Hide();
                this.Width = ListadoEstados.Width;
                this.Height = ListadoEstados.Height;
                this.CenterToScreen();
            }
            else
            {
                if (updateDescripTxt.Text == "") eP_errors.SetError(updateDescripTxt, "Ingrese una descripción, este campo es requerido");
            }
        }

        private void Btn_CancelarUpdate_Click(object sender, EventArgs e)
        {
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
            this.Width = ListadoEstados.Width;
            this.Height = ListadoEstados.Height;
            this.CenterToScreen();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = ListadoEstados.Width;
            this.Height = ListadoEstados.Height;
            this.CenterToScreen();

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
            else
            {
                ListadoEstados.DataSource = stateBL.GetStates();
                ListadoEstados.Refresh();             
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
