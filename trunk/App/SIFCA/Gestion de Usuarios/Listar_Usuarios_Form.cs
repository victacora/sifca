using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;

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
        }
    }
}
