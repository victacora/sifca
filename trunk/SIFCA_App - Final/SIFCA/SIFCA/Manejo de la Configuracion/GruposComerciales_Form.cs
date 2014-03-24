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
    public partial class GruposComerciales_Form : Form
    {
        GRUPOCOMERCIAL groupCom;
        GroupBL groupComBL;
        public GruposComerciales_Form()
        {
            InitializeComponent();
            groupCom = Program.ContextData.GRUPOCOMERCIAL.Create();
            groupComBL = new GroupBL(Program.ContextData);
            grupoComBSource.DataSource = groupComBL.GetGroups();
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            groupCom = Program.ContextData.GRUPOCOMERCIAL.Create();
            if (abrevTxt.Text != "" && descripcionTxt.Text != "")
            {
                if (groupComBL.GetGroup(abrevTxt.Text) != null) eP_errors.SetError(abrevTxt, "Ingrese una abreviatura diferente, esta ya esta en uso");
                else
                {

                    groupCom.DESCRIPGRUPO = this.descripcionTxt.Text;
                    groupCom.GRUPOCOM = this.abrevTxt.Text;
                    eP_errors.Dispose();
                    groupComBL.InsertGroup(groupCom);
                    string result = groupComBL.SaveChanges();
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
                    
                    grupoComBSource.DataSource = groupComBL.GetGroups();
                    ListadoGruposComerciales.Refresh();
                    descripcionTxt.Text = "";
                    abrevTxt.Text = "";
                    pn_crear.Hide();
                    pn_listado.Show();
                    pn_editar.Hide();
                    this.Width = pn_listado.Width + 10;
                    this.Height = pn_listado.Height + 10;
                    this.CenterToScreen();
                }
            }
            else
            {
                if (abrevTxt.Text == "") eP_errors.SetError(abrevTxt, "Ingrese una abreviatura, este campo es requerido");
                if (descripcionTxt.Text == "") eP_errors.SetError(descripcionTxt, "Ingrese una descripción, este campo es requerido");
            }

        }

        private void ListadoDeEspecies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (ListadoGruposComerciales.Columns[e.ColumnIndex].Name == "Editar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoGruposComerciales.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                groupCom = Program.ContextData.GRUPOCOMERCIAL.Create();

                groupCom = groupComBL.GetGroup(row.Cells[0].Value.ToString());

                updateAbrevTxt.Text = groupCom.GRUPOCOM;
                updateDescripcionTxt.Text = groupCom.DESCRIPGRUPO;
                pn_listado.Hide();
                pn_crear.Hide();
                pn_editar.Show();
                this.Width = pn_editar.Width;
                this.Height = pn_editar.Height;
                this.CenterToScreen();
            }

            if (ListadoGruposComerciales.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoGruposComerciales.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                groupCom = Program.ContextData.GRUPOCOMERCIAL.Create();

                groupCom = groupComBL.GetGroup(row.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro.", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Process message box resultados
                switch (result)
                {
                    case DialogResult.OK:
                        groupComBL.DeleteGroup(groupCom.GRUPOCOM);
                        string resultD = groupComBL.SaveChanges();
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
                        grupoComBSource.DataSource = groupComBL.GetGroups();
                        ListadoGruposComerciales.Refresh();
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
            if (updateDescripcionTxt.Text != "")
            {
                    eP_errors.Dispose();
                    groupCom.GRUPOCOM = updateAbrevTxt.Text;
                    groupCom.DESCRIPGRUPO = updateDescripcionTxt.Text;
                    groupComBL.UpdateGroup(groupCom);
                    string resultUpd = groupComBL.SaveChanges();
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
                    
                    updateAbrevTxt.Text = "";
                    updateDescripcionTxt.Text = "";
                    ListadoGruposComerciales.Refresh();
                    pn_listado.Show();
                    pn_crear.Hide();
                    pn_editar.Hide();
                    this.Width = pn_listado.Width + 15;
                    this.Height = pn_listado.Height + 15;
                    this.CenterToScreen();
                
            }
            else
            {
                if (updateDescripcionTxt.Text == "") eP_errors.SetError(updateDescripcionTxt, "Ingrese una descripción, este campo es requerido");
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
                ListadoGruposComerciales.DataSource = groupComBL.SearchGroup(busquedaTxt.Text);
                ListadoGruposComerciales.Refresh();
            }
            else
            {
                ListadoGruposComerciales.DataSource = groupComBL.GetGroups();
                ListadoGruposComerciales.Refresh();
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
