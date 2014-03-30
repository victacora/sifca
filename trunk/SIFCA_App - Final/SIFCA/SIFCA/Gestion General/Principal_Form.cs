using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Caching;
using SIFCA_DAL;
using SIFCA_BLL;
using SIFCA.Gestion_Configuracion;
using System.Collections;
using SIFCA.Helper;


namespace SIFCA
{
    public partial class Principal_Form : Form
    {
        public  ToolStripStatusLabel EstatusLabel
        { 
          get { return EstadoLbl;}
          set { EstadoLbl = value;}
        }

        public Principal_Form()
        {
            InitializeComponent();
            Autenticar_Usuario_Form childForm = new Autenticar_Usuario_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }
        
        private void nuevoProyectoTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Crear_Proyecto_Form childForm = new Crear_Proyecto_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Usted No se ha Autenticado dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }
        
        private void iniciarSesionTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user == null)
                {
                    Autenticar_Usuario_Form childForm = new Autenticar_Usuario_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Ya existe un usuario Autenticado dentro del sistema, por favor cierre sesion si desea ingresar con su usuario y contraseña.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void listarUsuariosTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Listar_Usuarios_Form childForm = new Listar_Usuarios_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Usted No se ha Autenticado dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        public void changueMenuUser() 
        {
            try
            {
                actualizarDatosUsuarioTsm.Visible = true;
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    if (user.TIPOUSUARIO == "AD")
                    {
                        listarUsuariosTsm.Visible = true;
                        registrarUsuarioTsm.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void cerrarSesionTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Program.Cache.Remove("user");
                    EstadoLbl.Text = "Ningun usuario autenticado";
                    listarUsuariosTsm.Visible = false;
                    actualizarDatosUsuarioTsm.Visible = false;
                    registrarUsuarioTsm.Visible = false;
                    Autenticar_Usuario_Form childForm = new Autenticar_Usuario_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void actualizarDatosUsuarioTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Actualizar_Usuario_Form childForm = new Actualizar_Usuario_Form(null);
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("No se pudo recuperar la informacion del usuario.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void actualizarProyectoTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Actualizar_Proyectos_Form childForm = new Actualizar_Proyectos_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void crearFormularioTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Crear_Editar_Formulario_Form childForm = new Crear_Editar_Formulario_Form(null);
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Crear_Usuario_Form childForm = new Crear_Usuario_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            try
            {
                Acerca_De_Form childForm = new Acerca_De_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void abrirFormulariosTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Abrir_Formulario_Form childForm = new Abrir_Formulario_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        public void changueMenuProject() 
        {
            inventarioMenu.Visible = true;
            cerrarProyectoTsm.Visible = true;
            actualizarProyectoTsm.Visible = true;
            eliminarProyectoTsm.Visible = true;
            abrirProyectosTsm.Visible = false;
            nuevoProyectoTsm.Visible = false;
            exportarDatosAExcelTsm.Visible  = true;
            reporteMenu.Visible = true;
        }
        private void abrirProyectosTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Abrir_Proyecto_Form childForm = new Abrir_Proyecto_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }


        private void cerrarProyectoTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                PROYECTO project = (PROYECTO)Program.Cache.Get("project");
                if (user != null)
                {
                    if (project != null)
                    {
                        Program.Cache.Remove("project");
                        EstadoLbl.Text = "Usuario Autenticado: " + user.NOMBREUSUARIO;
                        cerrarProyectoTsm.Visible = false;
                        abrirProyectosTsm.Visible = true;
                        actualizarProyectoTsm.Visible = false;
                        eliminarProyectoTsm.Visible = false;
                        inventarioMenu.Visible = false;
                        nuevoProyectoTsm.Visible = true;
                        exportarDatosAExcelTsm.Visible = false;
                        this.Text = "SIFCA";
                    }
                    else MessageBox.Show("Ningun proyecto ha sido abierto.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }
        
        private void eliminarProyectoTsm_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectBL project = new ProjectBL(Program.ContextData);
                DialogResult myResult = MessageBox.Show("¿Esta seguro de querer eliminar este proyecto?", "Mensaje de confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    USUARIO user = (USUARIO)Program.Cache.Get("user");
                    PROYECTO p = (PROYECTO)Program.Cache.Get("project");
                    if (user != null)
                    {
                        if (p != null)
                        {
                            project.DeleteProject(((PROYECTO)(Program.Cache.Get("project"))).NROPROY);
                            project.SaveChanges();
                            Program.Cache.Remove("project");
                            EstadoLbl.Text = "Usuario Autenticado: " + user.NOMBREUSUARIO;
                            cerrarProyectoTsm.Visible = false;
                            abrirProyectosTsm.Visible = true;
                            actualizarProyectoTsm.Visible = false;
                            eliminarProyectoTsm.Visible = false;
                            inventarioMenu.Visible = false;
                            nuevoProyectoTsm.Visible = true;
                            exportarDatosAExcelTsm.Visible = false;
                            this.Text = "SIFCA";
                        }
                        else MessageBox.Show("Ningun proyecto ha sido abierto.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (Form childForm in MdiChildren)
                    {
                        childForm.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void importarProyectoTsm_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "Archivos de importacion xml (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }


        private void exportarProyectoTsm_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Archivos de exportacion (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void listarEspeciesTsm_Click(object sender, EventArgs e)
        {
            try
            {
                Especies_Form childForm = new Especies_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void cascadaTsm_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoVerticalTsm_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoHorizontalTsm_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cerrarTodoTsm_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void registrarUsuarioTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Crear_Usuario_Form childForm = new Crear_Usuario_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Usted No se ha Autenticado dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }


        private void realizarCopiaDeSeguridadTsm_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Realizar_Copia_Seguridad_Form childForm = new Realizar_Copia_Seguridad_Form();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else MessageBox.Show("Usted No se ha Autenticado dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void importarDatosDeExcelTsm_Click(object sender, EventArgs e)
        {
            try
            {
                ImporExportExcel impExp = new ImporExportExcel();
                impExp.importarExcel(pBarLoad);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }


        private void exportarDatosAExcelTsm_Click(object sender, EventArgs e)
        {
            try
            {
                ImporExportExcel impExp = new ImporExportExcel();
                impExp.exportarExcel(pBarLoad);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }
        private void estratosTsm_Click(object sender, EventArgs e)
        {
            try
            {
                Estratos_Form childForm = new Estratos_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void gruposComercialesTsm_Click(object sender, EventArgs e)
        {
            try
            {
                GruposComerciales_Form childForm = new GruposComerciales_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void tipoDeDiseñoTsm_Click(object sender, EventArgs e)
        {
            try
            {
                TiposMuestrales_Form childForm = new TiposMuestrales_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void tipoDeUsoTsm_Click(object sender, EventArgs e)
        {
            try
            {
                TiposUso_Form childForm = new TiposUso_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void calidadTsm_Click(object sender, EventArgs e)
        {
            try
            {
                Calidad_Form childForm = new Calidad_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void estadosTsm_Click(object sender, EventArgs e)
        {
            try
            {
                EstadosSanitarios_Form childForm = new EstadosSanitarios_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void estradosTsm_Click(object sender, EventArgs e)
        {
            try
            {
                Estratos_Form childForm = new Estratos_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Program.ContextData.Dispose();
        }

        private void cargarTablaTStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TStudent_Form childForm = new TStudent_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }
        
        private void clasesDiamétricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ClasesDiametricas_Form childForm = new ClasesDiametricas_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }

        private void estadisticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Seleccionar_Estratos_Form childForm = new Seleccionar_Estratos_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this;
                er.Show();
            } 
        }


    }
}
