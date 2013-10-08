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
    public partial class Crear_Usuario_Form : Form
    {
        private UserBL user;

        public Crear_Usuario_Form()
        {
            InitializeComponent();
            user = new UserBL(Program.ContextData);
            this.ControlBox = false;
            tipoUsuarioCbx.SelectedIndex = 0;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            USUARIO newUser = new USUARIO();
            newUser.NROUSUARIO = Guid.NewGuid();
            newUser.NOMBRES = nombresTxt.Text;
            newUser.APELLIDOS = apellidosTxt.Text;
            newUser.CEDULA = int.Parse(cedulaTxt.Text);
            newUser.CONTRASENA = contrasenaTxt.Text;
            newUser.NOMBREUSUARIO = usuarioTxt.Text;
            newUser.TIPOUSUARIO = (tipoUsuarioCbx.SelectedItem.ToString() == "Administrador" ? "AD" : "NA");
            user.InsertUser(newUser);
            user.SaveChanges();
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
