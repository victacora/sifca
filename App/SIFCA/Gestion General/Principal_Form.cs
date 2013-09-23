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
        
        private void CreateNewProject(object sender, EventArgs e)
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

        private void ImportProject(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de importacion xml (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void ExportProject(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de exportacion (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listarEstacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Listar_Estaciones_Form childForm = new Listar_Estaciones_Form();
            //childForm.MdiParent = this;
            //childForm.Show();
        }

        private void introducirDatosDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GestDatInv_Form childForm = new GestDatInv_Form();
            //childForm.MdiParent = this;
            //childForm.Show();
        }

        private void regeneracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GestDatRegen_Form childForm = new GestDatRegen_Form();
            //childForm.MdiParent = this;
            //childForm.Show();
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////cambiar el stage activo y cargarlo en la Cache
            //PROYECTO activateProject = project.GetActivateProject();
            //Program.Cache.Set("principalProject", activateProject, new CacheItemPolicy());
        }

        private void listarEspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    Crear_Listado_Especies childForm = new Crear_Listado_Especies();
        //    childForm.MdiParent = this;
        //    childForm.Show();
        }

        private void listarProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Listar_Proyectos_Form childForm = new Listar_Proyectos_Form();
            //childForm.MdiParent = this;
            //childForm.Show();
        }

        private void ingresarEspecieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ingresar_Especie_Form childForm = new Ingresar_Especie_Form();
            //childForm.MdiParent = this;
            //childForm.Show();
        }

        private void crearListadoEspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
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

        private void crearEspecieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ingresar_Especie_Form childForm = new Ingresar_Especie_Form();
            //childForm.MdiParent = this;
            //childForm.Show();
        }

        private void verEspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ver_Especie_Form childForm = new Ver_Especie_Form();
            //childForm.MdiParent = this;
            //childForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Listado_Especies_Form childForm = new Listado_Especies_Form();
            //childForm.MdiParent = this;
            //childForm.Show();

        }

        private void IntroducirDatosUsuario_Click(object sender, EventArgs e)
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

        private void ListarUsuarios_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            if (user != null)
            {
                Listar_Usuarios_Form childForm = new Listar_Usuarios_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else  MessageBox.Show("Usted No se ha Autenticado dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            if (user != null)
            {
                Program.Cache.Remove("user");
                EstadoLbl.Text = "Ningun usuario autenticado";
                Autenticar_Usuario_Form childForm = new Autenticar_Usuario_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void ActualizarDatosUsuario_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            if (user != null)
            {
                Actualizar_Usuario_Form childForm = new Actualizar_Usuario_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else MessageBox.Show("Ningun usuario ha iniciado sesión. Inicie sesión en el sistema para poder realizar esta operación.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void listarProyectosTsm_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            if (user != null)
            {
                Listar_Proyecto_Form childForm = new Listar_Proyecto_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void introducirDatosInventarioTsm_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            if (user != null)
            {
                Crear_Formulario_Form childForm = new Crear_Formulario_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
                Crear_Usuario_Form childForm = new Crear_Usuario_Form();
                childForm.MdiParent = this;
                childForm.Show();
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            Acerca_De_Form childForm = new Acerca_De_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void listarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            if (user != null)
            {
                Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 

        }


    }
}
