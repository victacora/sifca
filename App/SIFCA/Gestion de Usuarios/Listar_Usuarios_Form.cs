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
            usuarioDGV.DataSource = usuarioBS;
            criterioCbx.SelectedIndex = 0;
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (busquedaTxt.Text != "") 
            {
                usuarioBS.DataSource = user.SearchUsers(busquedaTxt.Text,criterioCbx.SelectedItem.ToString());
                usuarioDGV.DataSource = usuarioBS;
                usuarioDGV.Refresh();
            }
        }

        private void recargarBtn_Click(object sender, EventArgs e)
        {
            usuarioBS.DataSource = user.GetUsers();
            usuarioDGV.DataSource = usuarioBS;
            usuarioDGV.Refresh();
        }

        
    }
}
