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
            groupCom = new GRUPOCOMERCIAL();
            groupComBL = new GroupBL(Program.ContextData);
            grupoComBSource.DataSource = groupComBL.GetGroups();
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            groupCom = new GRUPOCOMERCIAL();
            if (abrevTxt.Text != "" && descripcionTxt.Text != "")
            {
                groupCom.DESCRIPGRUPO = this.descripcionTxt.Text;
                groupCom.GRUPOCOM = this.abrevTxt.Text;

                groupComBL.InsertGroup(groupCom);
                groupComBL.SaveChanges();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grupoComBSource.DataSource = groupComBL.GetGroups();
                ListadoGruposComerciales.Refresh();
                descripcionTxt.Text = "";
                abrevTxt.Text = "";
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
            if (ListadoGruposComerciales.Columns[e.ColumnIndex].Name == "Editar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoGruposComerciales.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                groupCom = new GRUPOCOMERCIAL();

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

                groupCom = new GRUPOCOMERCIAL();

                groupCom = groupComBL.GetGroup(row.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Process message box results
                switch (result)
                {
                    case DialogResult.OK:
                        groupComBL.DeleteGroup(groupCom.GRUPOCOM);
                        groupComBL.SaveChanges();
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
                this.Width = pn_listado.Width;
                this.Height = pn_listado.Height;
                this.CenterToScreen();

            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateDescripcionTxt.Text != "")
            {
                groupCom.GRUPOCOM= updateAbrevTxt.Text;
                groupCom.DESCRIPGRUPO= updateDescripcionTxt.Text;
                groupComBL.UpdateGroup(groupCom);
                groupComBL.SaveChanges();
                MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateAbrevTxt.Text = "";
                updateDescripcionTxt.Text = "";
                ListadoGruposComerciales.Refresh();
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
                ListadoGruposComerciales.DataSource = groupComBL.SearchGroup(busquedaTxt.Text);
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
