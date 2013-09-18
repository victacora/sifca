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
    public partial class Actualizar_Usuario_Form : Form
    {
        private UserBL user;
        private USUARIO userData;
        public Actualizar_Usuario_Form()
        {
            InitializeComponent();
            user = new UserBL(Program.ContextData);
            userData = (USUARIO)Program.Cache.Get("user");
            nombresTxt.Text=userData.NOMBRES;
            apellidosTxt.Text=userData.APELLIDOS;
            cedulaTxt.Text= userData.CEDULA.ToString();
            contrasenaTxt.Text=userData.CONTRASENA;
            verificarContrasenaTxt.Text = userData.CONTRASENA;
            usuarioTxt.Text=userData.NOMBREUSUARIO;
            this.ControlBox = false;
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            userData.NOMBRES = nombresTxt.Text;
            userData.APELLIDOS = apellidosTxt.Text;
            userData.CEDULA = int.Parse(cedulaTxt.Text);
            userData.CONTRASENA = contrasenaTxt.Text;
            userData.NOMBREUSUARIO = usuarioTxt.Text;
            user.UpdateUser(userData);
            user.SaveChanges();
            Program.Cache.Set("user",userData, new CacheItemPolicy());
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verificarContrasenaTxt_TextChanged(object sender, EventArgs e)
        {
            if (contrasenaTxt.Text != verificarContrasenaTxt.Text)
            {
                errorLbl.Text = "Las contraseñas no coinciden";
                errorLbl.ForeColor = Color.Red;
            }
            else
            {
                errorLbl.Text = "Las contraseñas coinciden";
                errorLbl.ForeColor = Color.Green;
            }
        }

    }
}
