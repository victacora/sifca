﻿using System;
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


        /// <summary>
        /// Constructor para inicializar atributos y elementos del formulario
        /// </summary>
        public EstadosSanitarios_Form()
        {
            try
            {
                InitializeComponent();
                state = new ESTADOSANITARIO();
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
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        /// <summary>
        /// Funcion que valida que los campos del formulario crear no esten vacios si pasa las validaciones entonces se inserta 
        /// el nuevo registro y se alerta al usuario con un mensaje de exito, si ocurre un mensaje durante el proceso se notifica al usuario con un mensaje de mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            try
            {
                state = new ESTADOSANITARIO();
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
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        /// <summary>
        /// Capturamos el click que se de en el alguna de las opciones editar o eliminar y se procede con la accion
        /// si es modificar se redimensiona la ventana para cargar el panel de editar, si se va a eliminar se pide la 
        /// confirmacion del usuario y se procede a eliminar el registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Listado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
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

                    state = new ESTADOSANITARIO();

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

                    state =new ESTADOSANITARIO();

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
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        /// <summary>
        /// Esta funcion se invoca desde el formulario de actualizar(editar), en este se validan que los campos sean correctos y se procede
        /// a realizar la actualizacio del registro en la base de datos, si la accion se completa satisfactoriamente se notifica al usuario
        /// por medio de un mensaje de exito, en caso contrario se alerta o notifica del mensaje que se presento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        /// <summary>
        /// Accion que se invoca y se retorna al listado principal que contienen los datos
        /// </summary>
        /// <param name="sender"></param> contiene los datos del elemento que lanzo el evento
        /// <param name="e"></param> argumentos del evento
        private void Btn_CancelarUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                pn_listado.Show();
                pn_crear.Hide();
                pn_editar.Hide();
                this.Width = ListadoEstados.Width;
                this.Height = ListadoEstados.Height;
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        /// <summary>
        /// Accion que se invoca y se retorna al listado principal que contienen los datos
        /// </summary>
        /// <param name="sender"></param> contiene los datos del elemento que lanzo el evento
        /// <param name="e"></param> argumentos del evento
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                pn_crear.Hide();
                pn_editar.Hide();
                pn_listado.Show();
                this.Width = ListadoEstados.Width;
                this.Height = ListadoEstados.Height;
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }

        }

        /// <summary>
        /// Funcion que sirve para buscar un registro de acuerdo a lo que el usuario digito y a el criterio de su busqueda, si se
        /// encuentra alguna coincidencia en la base de datos se retorna en caso contrario se retorna null.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        /// <summary>
        /// Esta funcion se ejecuta cuando se quiere crear un nuevo registro, se redimensiona la ventana para cargar el formulario de crear 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                pn_editar.Hide();
                pn_listado.Hide();
                pn_crear.Show();
                this.Width = crearGbx.Width;
                this.Height = crearGbx.Height;
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }
    }
}
