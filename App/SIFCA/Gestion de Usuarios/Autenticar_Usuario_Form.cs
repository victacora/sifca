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
            this.ControlBox = false;
            user = new UserBL(Program.ContextData);
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            USUARIO userData = new USUARIO();
            userData.CONTRASENA = contrasenaTxt.Text;
            userData.NOMBREUSUARIO = usuarioTxt.Text;
            USUARIO result=user.LoginUser(userData);
            if (result == null)
            {
                MessageBox.Show("Los datos ingresados son incorrectos.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //ingresar el usuario a la cache para mantener activa sesion                
                Program.Cache.Add("user",result, new CacheItemPolicy());
                Principal_Form parent = (Principal_Form)this.ParentForm;
                parent.EstatusLabel.Text = "Usuario Autenticado: "+result.NOMBREUSUARIO;
                parent.changueMenuUser();
                this.Close();
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autenticar_Usuario_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                USUARIO userData = new USUARIO();
                userData.CONTRASENA = contrasenaTxt.Text;
                userData.NOMBREUSUARIO = usuarioTxt.Text;
                USUARIO result = user.LoginUser(userData);
                if (result == null)
                {
                    MessageBox.Show("Los datos ingresados son incorrectos.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //ingresar el usuario a la cache para mantener activa sesion                
                    Program.Cache.Add("user", result, new CacheItemPolicy());
                    Principal_Form parent = (Principal_Form)ParentForm;
                    parent.EstatusLabel.Text = "Usuario Autenticado: " + result.NOMBREUSUARIO;
                    //modificar barra estado
                    this.Close();
                }

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            } 
        }
        
    }
}
