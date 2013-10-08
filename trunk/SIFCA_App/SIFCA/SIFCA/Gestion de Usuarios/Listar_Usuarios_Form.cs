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

namespace SIFCA
{
    public partial class Listar_Usuarios_Form : Form
    {
        private UserBL user;
        public Listar_Usuarios_Form()
        {
            InitializeComponent();
            user=new UserBL(Program.ContextData);
            usuarioBS.DataSource=user.GetUsers();
            usuarioDGW.DataSource = usuarioBS;
            criterioCbx.SelectedIndex = 0;
        }


        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            if (busquedaTxt.Text != "")
            {
                string criteria = criterioCbx.SelectedItem.ToString();
                if (criteria != "Cedula")
                {
                    usuarioBS.DataSource = user.SearchUsers(busquedaTxt.Text, criteria);
                    usuarioDGW.DataSource = usuarioBS;
                    usuarioDGW.Refresh();
                }
                else
                {
                    int output = 0;
                    bool result = int.TryParse(busquedaTxt.Text, out output);
                    if (result)
                    {
                        usuarioBS.DataSource = user.SearchUsers(busquedaTxt.Text, criteria);
                        usuarioDGW.DataSource = usuarioBS;
                        usuarioDGW.Refresh();
                    }
                    else MessageBox.Show("Entra invalida para el parametro cedula.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                usuarioBS.DataSource = user.GetUsers();
                usuarioDGW.DataSource = usuarioBS;
                usuarioDGW.Refresh();
            }
        }

        private void usuarioDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == usuarioDGW.Columns["editar"].Index && e.RowIndex >= 0)
            {
                USUARIO result = user.GetUser((Guid)usuarioDGW.Rows[e.RowIndex].Cells[0].Value);
                Actualizar_Usuario_Form childForm = new Actualizar_Usuario_Form(result);
                childForm.MdiParent = ParentForm;
                childForm.Show();
            }
            if (e.ColumnIndex == usuarioDGW.Columns["eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult myResult = MessageBox.Show("¿Esta seguro de querer eliminar esta usuario?", "Mensaje de confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    user.DeleteUser((Guid)usuarioDGW.Rows[e.RowIndex].Cells[0].Value);
                    user.SaveChanges();
                    usuarioBS.DataSource = user.GetUsers();
                    usuarioDGW.DataSource = usuarioBS;
                    usuarioDGW.Refresh();
                }
            }
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            Crear_Usuario_Form childForm = new Crear_Usuario_Form();
            childForm.ShowDialog();
            usuarioBS.DataSource = user.GetUsers();
            usuarioDGW.DataSource = usuarioBS;
            criterioCbx.SelectedIndex = 0;
        }

        
    }
}
