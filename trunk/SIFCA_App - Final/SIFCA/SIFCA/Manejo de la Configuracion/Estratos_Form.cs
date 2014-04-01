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
    public partial class Estratos_Form : Form
    {
        private StratumBL stratumBl;
        private ESTRATO stratum;
        private string state;

        /// <summary>
        /// Constructor para inicializar atributos y elementos del formulario
        /// </summary>
        public Estratos_Form()
        {
            try
            {
                InitializeComponent();
                stratum = Program.ContextData.ESTRATO.Create();
                stratumBl = new StratumBL(Program.ContextData);
                this.stratumListBSource.DataSource = stratumBl.GetStratums();
                this.ListadoEstratos.DataSource = stratumListBSource;
                this.Width = pn_listado.Width;
                this.Height = pn_listado.Height;
                this.CenterToScreen();
                pn_crear.Hide();
                pn_editar.Hide();
                pn_listado.Show();
                state = "estrato";
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
        /// el nuevo registro y se alerta al usuario con un mensaje de exito, si ocurre un error durante el proceso se notifica al usuario con un mensaje de error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Crear_Click(object sender, EventArgs e)
        {
            try
            {
                ESTRATO newStratum = Program.ContextData.ESTRATO.Create();

                bool band = true;
                if (this.txt_Nombre.Text == "")
                {
                    eP_errors.SetError(txt_Nombre, "La descripción es  un campo requerido");
                    band = false;
                }
                else
                {
                    newStratum.DESCRIPESTRATO = this.txt_Nombre.Text;
                    eP_errors.Dispose();
                }

                if (band)
                {
                    stratumBl.InsertStratum(newStratum);
                    string result = stratumBl.SaveChanges();
                    if (result == "")
                    {
                        MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        stratumListBSource.DataSource = stratumBl.GetStratums();
                        ListadoEstratos.Refresh();
                        txt_Nombre.Text = "";
                        txt_Descripcion.Text = "";

                        if (this.state == "proyecto")
                        {
                            this.Close();
                            return;
                        }
                        this.Width = pn_listado.Width;
                        this.Height = pn_listado.Height;
                        this.CenterToScreen();
                        pn_listado.Show();
                        pn_editar.Hide();
                        pn_crear.Hide();
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(result);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
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

        public void Btn_nuevoEstratoForm_Click(object sender, EventArgs e, string formCall)
        {
            try
            {
                pn_editar.Hide();
                pn_crear.Show();
                pn_listado.Hide();
                btn_Cancelar.Visible = false;
                this.Width = pn_crear.Width;
                this.Height = pn_crear.Height;
                this.CenterToScreen();
                this.state = formCall;
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
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
                if (ListadoEstratos.Columns[e.ColumnIndex].Name == "Editar")
                {
                    //
                    // Se toma la fila seleccionada
                    //
                    DataGridViewRow row = ListadoEstratos.Rows[e.RowIndex];

                    //
                    // Se selecciona la celda del boton
                    //
                    int codigo = Convert.ToInt32(row.Cells[0].Value);

                    stratum = Program.ContextData.ESTRATO.Create();
                    pn_listado.Hide();
                    pn_crear.Hide();
                    pn_editar.Show();
                    stratum = stratumBl.GetStratum(codigo);
                    txt_Descripcion.Text = stratum.DESCRIPESTRATO;
                    this.Width = pn_editar.Width;
                    this.Height = pn_editar.Height;
                    this.CenterToScreen();

                }

                if (ListadoEstratos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    //
                    // Se toma la fila seleccionada
                    //
                    DataGridViewRow row = ListadoEstratos.Rows[e.RowIndex];

                    //
                    // Se selecciona la celda del boton
                    //
                    int codigo = Convert.ToInt32(row.Cells[0].Value);

                    DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro.", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    // Process message box resultados
                    switch (result)
                    {
                        case DialogResult.OK:
                            stratumBl.DeleteStratum(codigo);
                            string resultD = stratumBl.SaveChanges();
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
                            stratumListBSource.DataSource = stratumBl.GetStratums();
                            ListadoEstratos.Refresh();
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
        /// Accion que se invoca y se retorna al listado principal que contienen los datos
        /// </summary>
        /// <param name="sender"></param> contiene los datos del elemento que lanzo el evento
        /// <param name="e"></param> argumentos del evento
        private void btn_cancelarUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                pn_crear.Hide();
                pn_editar.Hide();
                pn_listado.Show();
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
        /// Esta funcion se ejecuta cuando se quiere crear un nuevo registro, se redimensiona la ventana para cargar el formulario de crear 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nuevoEstrato_Click(object sender, EventArgs e)
        {
            try
            {
                pn_editar.Hide();
                pn_listado.Hide();
                pn_crear.Show();
                this.Width = pn_crear.Width;
                this.Height = pn_crear.Height;
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
        /// Esta funcion se invoca desde el formulario de actualizar(editar), en este se validan que los campos sean correctos y se procede
        /// a realizar la actualizacio del registro en la base de datos, si la accion se completa satisfactoriamente se notifica al usuario
        /// por medio de un mensaje de exito, en caso contrario se alerta o notifica del error que se presento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool band = true;
                if (this.txt_Descripcion.Text == "")
                {
                    eP_errors.SetError(txt_Descripcion, "La descripción es  un campo requerido.");
                    band = false;
                }
                else
                {
                    stratum.DESCRIPESTRATO = txt_Descripcion.Text;
                    eP_errors.Dispose();
                }

                if (band)
                {
                    stratumBl.UpdateStratum(stratum);
                    string resultUpd = stratumBl.SaveChanges();
                    if (resultUpd == "")
                    {
                        MessageBox.Show("Se realizo la modificación de manera correcta.", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(resultUpd);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
                    txt_Descripcion.Text = "";
                    stratumListBSource.DataSource = stratumBl.GetStratums();
                    pn_crear.Hide();
                    pn_editar.Hide();
                    pn_listado.Show();
                    this.Width = pn_listado.Width;
                    this.Height = pn_listado.Height;
                    this.CenterToScreen();
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
                    stratumListBSource.DataSource = stratumBl.SearchStratum(busquedaTxt.Text);
                    ListadoEstratos.Refresh();
                }
                else
                {
                    stratumListBSource.DataSource = stratumBl.GetStratums();
                    ListadoEstratos.Refresh();
                }
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
