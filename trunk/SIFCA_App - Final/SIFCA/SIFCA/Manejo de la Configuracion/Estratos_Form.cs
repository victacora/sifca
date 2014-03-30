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

        public Estratos_Form()
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
            state="estrato";
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            ESTRATO newStratum =  Program.ContextData.ESTRATO.Create();

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


        private void ListadoDeEstratos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {            
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();
        }

        private void btn_cancelarUpdate_Click(object sender, EventArgs e)
        {
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();
        }

        private void btn_nuevoEstrato_Click(object sender, EventArgs e)
        {
            pn_editar.Hide();
            pn_listado.Hide();
            pn_crear.Show();
            this.Width = pn_crear.Width;
            this.Height = pn_crear.Height;
            this.CenterToScreen();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
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

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
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

        
    }
}
