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
            user.InsertUser(newUser);
            user.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
