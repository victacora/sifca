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
using System.Reflection;

namespace SIFCA
{
    public partial class Autenticar_Usuario_Form : Form
    {
        private UserBL user;

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public Autenticar_Usuario_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            versionLbl.Text = "Versión " + AssemblyVersion;
            user = new UserBL(Program.ContextData);
            try
            {
                bool iniciarSesion = (bool)Properties.Settings.Default["IniciarSesion"];
                if (iniciarSesion)
                {
                    usuarioTxt.Text = (string)Properties.Settings.Default["Usuario"];
                    contrasenaTxt.Text = (string)Properties.Settings.Default["Contrasena"];
                    guardarDatosInicioChk.Checked = iniciarSesion;
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(@"Error al cargar el archivo de configuración de la aplicacíon. Ejecute el siguiente comando:%userprofile%\appdata\local  y elimine la carpeta con el nombre de la aplicacíon e intente nuevamente.  " + ex.Message);
                er.Show();
            }
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = false;
                if (usuarioTxt.Text == "")
                {
                    controladorErrores.SetError(usuarioTxt, "El campo usuario es requerido.");
                    error = true;
                }
                if (contrasenaTxt.Text == "")
                {
                    controladorErrores.SetError(contrasenaTxt, "La contraseña es un campo requerido.");
                    error = true;
                }
                if (error) return;

                controladorErrores.Clear();
                USUARIO userData = new USUARIO();
                userData.CONTRASENA = contrasenaTxt.Text;
                userData.NOMBREUSUARIO = usuarioTxt.Text;
                string key = (string)Properties.Settings.Default["Key"];
                USUARIO result = user.LoginUser(userData, key);
                if (result == null)
                {
                    MessageBox.Show("Los datos ingresados son incorrectos.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //ingresar el usuario a la cache para mantener activa sesion 
                    Program.ContextData.usuario = result;
                    Program.Cache.Add("user", result, new CacheItemPolicy());
                    Principal_Form parent = (Principal_Form)this.ParentForm;
                    parent.EstatusLabel.Text = "Usuario Autenticado: " + result.NOMBREUSUARIO;
                    parent.changueMenuUser();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this.MdiParent;
                er.Show();
            } 
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            Program.ContextData.usuario = null;
            this.Close();
        }

        private void Autenticar_Usuario_Form_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    USUARIO userData = new USUARIO();
                    userData.CONTRASENA = contrasenaTxt.Text;
                    userData.NOMBREUSUARIO = usuarioTxt.Text;
                    string key = (string)Properties.Settings.Default["Key"];
                    USUARIO result = user.LoginUser(userData, key);
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
                        parent.changueMenuUser();
                        //modificar barra estado
                        this.Close();
                    }

                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            } 
        }

        private void guardarDatosInicioChk_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatosInicioChk.Checked)
                {
                    if (usuarioTxt.Text != string.Empty && contrasenaTxt.Text != string.Empty)
                    {
                        Properties.Settings.Default["IniciarSesion"] = true;
                        Properties.Settings.Default["Usuario"] = usuarioTxt.Text;
                        Properties.Settings.Default["Contrasena"] = contrasenaTxt.Text;
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña son requeridos.", "Campos requeridos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        guardarDatosInicioChk.Checked = false;
                    }
                }
                else
                {
                    Properties.Settings.Default["IniciarSesion"] = false;
                    Properties.Settings.Default["Usuario"] = string.Empty;
                    Properties.Settings.Default["Contrasena"] = string.Empty;
                }
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            } 
        }
        
    }
}
