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
using System.Runtime.Caching;

namespace SIFCA
{
    public partial class Autenticar_Usuario_Form : Form
    {
        private UserBL user;

        public Autenticar_Usuario_Form()
        {
            InitializeComponent();
            user = new UserBL(Program.ContextData);
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            USUARIO newUser = new USUARIO();
            newUser.CONTRASENA = contrasenaTxt.Text;
            newUser.NOMBREUSUARIO = usuarioTxt.Text;
            var result=user.LoginUser(newUser);
            if (result == null)
            {
                user.SaveChanges();
                MessageBox.Show("Los datos ingresados son incorrectos.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //ingresar el usuario a la cache para mantener activa sesion
                this.Close();
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
