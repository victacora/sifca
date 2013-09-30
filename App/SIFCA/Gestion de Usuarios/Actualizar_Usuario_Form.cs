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
        private bool updateCache;
        public Actualizar_Usuario_Form(USUARIO userUpdate)
        {
            InitializeComponent();
            user = new UserBL(Program.ContextData);
            if (userUpdate != null)
            {
                userData = userUpdate;
                updateCache = false;
            }
            else
            {
                userData = (USUARIO)Program.Cache.Get("user");
                updateCache = true;
            }
            nombresTxt.Text = userData.NOMBRES;
            apellidosTxt.Text = userData.APELLIDOS;
            cedulaTxt.Text = userData.CEDULA.ToString();
            contrasenaTxt.Text = AuthenticatorHelper.Decrypt(userData.CONTRASENA);
            verificarContrasenaTxt.Text = contrasenaTxt.Text;
            usuarioTxt.Text = userData.NOMBREUSUARIO;
            if (userUpdate != null)
            {
                tipoUsuarioCbx.SelectedIndex = (userData.TIPOUSUARIO == "AD" ? 0 : 1);
            }
            else 
            {
                tipoUsuarioCbx.SelectedIndex = (userData.TIPOUSUARIO == "AD" ? 0 : 1);
                tipoUsuarioCbx.Enabled = (userData.TIPOUSUARIO == "AD" ? true : false);
            }
            this.ControlBox = false;
            
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            userData.NOMBRES = nombresTxt.Text;
            userData.APELLIDOS = apellidosTxt.Text;
            userData.CEDULA = int.Parse(cedulaTxt.Text);
            userData.CONTRASENA = contrasenaTxt.Text;
            userData.NOMBREUSUARIO = usuarioTxt.Text;
            userData.TIPOUSUARIO = (tipoUsuarioCbx.SelectedItem.ToString()=="Administrador"?"AD":"NA");
            user.UpdateUser(userData);
            user.SaveChanges();
            if(updateCache)Program.Cache.Set("user",userData, new CacheItemPolicy());
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verificarContrasenaTxt_TextChanged(object sender, EventArgs e)
        {
            if (contrasenaTxt.Text != verificarContrasenaTxt.Text && verificarContrasenaTxt.Text!="")
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

        private void verContrasena_Click(object sender, EventArgs e)
        {
            if (verContrasena.Text == "Ver Contraseña")
            {
                verContrasena.Text = "No Ver Contraseña";
                contrasenaTxt.UseSystemPasswordChar = false;
                verificarContrasenaTxt.UseSystemPasswordChar = false;
            }
            else 
            {
                verContrasena.Text = "Ver Contraseña";
                contrasenaTxt.UseSystemPasswordChar = true;
                verificarContrasenaTxt.UseSystemPasswordChar = true;
            }
        }

    }
}
