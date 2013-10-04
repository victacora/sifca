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
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            if (user != null)
            {
                Crear_Proyecto_Form childForm = new Crear_Proyecto_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else MessageBox.Show("Usted No se ha Autenticado dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
        
        private void iniciarSesionTsm_Click(object sender, EventArgs e)
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

        private void listarUsuariosTsm_Click(object sender, EventArgs e)
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

        public void changueMenuUser() 
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

        private void cerrarSesionTsm_Click(object sender, EventArgs e)
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

        private void actualizarDatosUsuarioTsm_Click(object sender, EventArgs e)
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

        private void actualizarProyectoTsm_Click(object sender, EventArgs e)
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

        private void crearFormularioTsm_Click(object sender, EventArgs e)
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

        private void abrirFormulariosTsm_Click(object sender, EventArgs e)
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

        public void changueMenuProject() 
        {
            inventarioMenu.Visible = true;
            cerrarProyectoTsm.Visible = true;
            actualizarProyectoTsm.Visible = true;
            eliminarProyectoTsm.Visible = true;
            abrirProyectosTsm.Visible = false;
            nuevoProyectoTsm.Visible = false;
        }
        private void abrirProyectosTsm_Click(object sender, EventArgs e)
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


        private void cerrarProyectoTsm_Click(object sender, EventArgs e)
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
                    this.Text = "SIFCA";
                }
                else MessageBox.Show("Ningun proyecto ha sido abierto.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
        
        private void eliminarProyectoTsm_Click(object sender, EventArgs e)
        {

        }

        private void importarProyectoTsm_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de importacion xml (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }


        private void exportarProyectoTsm_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de exportacion (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void listarEspeciesTsm_Click(object sender, EventArgs e)
        {

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
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            if (user != null)
            {
                Crear_Usuario_Form childForm = new Crear_Usuario_Form();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else MessageBox.Show("Usted No se ha Autenticado dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }


        private void realizarCopiaDeSeguridadTsm_Click(object sender, EventArgs e)
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

        private void exportarDatosAExcelTsm_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog fichero = new SaveFileDialog();
            //PROYECTO py = new PROYECTO();
            //FORMULARIO form = new FORMULARIO();
            //LINEAINVENTARIO lineInv = new LINEAINVENTARIO();

            ProjectBL pyBl = new ProjectBL(Program.ContextData);
            FormBL formBl = new FormBL(Program.ContextData);
            InventoryLineBL lineInvBl = new InventoryLineBL(Program.ContextData);

            var py_List = pyBl.GetProjects();
            var form_List = formBl.GetForms();
            var lineInv_List = lineInvBl.GetInventoryLines();
            
            
            //DataGridView grd = ListadoEspecies;
            
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;                
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                
                foreach (PROYECTO py in py_List)
                {
                    //form = formBl.GetForm((Guid)py.NROPROY);

                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    //hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets[numHoja];
                    //hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.ActiveSheet();
                    //"descripcion"

                    hoja_trabajo.Cells[1, 1] = "Responsable";
                    hoja_trabajo.Cells[1, 2] = "Descripcion";
                    hoja_trabajo.Cells[1, 3] = "Coor X";
                    hoja_trabajo.Cells[1, 4] = "Coor Y";
                    hoja_trabajo.Cells[1, 5] = "Linea";
                    hoja_trabajo.Cells[1, 6] = "Parcela";
                    hoja_trabajo.Cells[1, 7] = "Estrato";
                
                    hoja_trabajo.Cells[1, 8] = "Numero de arbol";
                    hoja_trabajo.Cells[1, 9] = "Especie Nombre Comun";
                    hoja_trabajo.Cells[1, 10] = "Especie Nombre Cientifico";
                    hoja_trabajo.Cells[1, 11] = "Calidad";
                    hoja_trabajo.Cells[1, 12] = "DAP";
                    hoja_trabajo.Cells[1, 13] = "CAP";
                    hoja_trabajo.Cells[1, 14] = "Altura Comercial";
                    hoja_trabajo.Cells[1, 15] = "Altura Total";

                    hoja_trabajo.get_Range("A1", "O1").Font.Bold = true;
                    hoja_trabajo.get_Range("A1", "O1").VerticalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    
                    
                    int i = 2;
                    foreach (FORMULARIO form in py.FORMULARIO)
                    {

                        //de formulario extraer coord x y Y el estrato la linea numero de parcela y el usuario se puede
                        
                        hoja_trabajo.Cells[i, 1] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;
                        hoja_trabajo.Cells[i, 2] = py.DESCRIPCION.ToString();
                        hoja_trabajo.Cells[i, 3] = form.COORDENADAX.ToString();
                        hoja_trabajo.Cells[i, 4] = form.COORDENADAY.ToString();
                        hoja_trabajo.Cells[i, 5] = form.LINEA.ToString();
                        hoja_trabajo.Cells[i, 6] = form.PARCELA.ToString();
                        hoja_trabajo.Cells[i, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();
                        
                        foreach (LINEAINVENTARIO lineInv in form.LINEAINVENTARIO)
                        {
                            hoja_trabajo.Cells[i, 8] = lineInv.NROARB.ToString();
                            hoja_trabajo.Cells[i, 9] = lineInv.ESPECIE.NOMCOMUN.ToString(); 
                            hoja_trabajo.Cells[i, 10] = lineInv.ESPECIE.NOMCIENTIFICO.ToString();
                            hoja_trabajo.Cells[i, 11] = lineInv.CALIDAD.DESCRIPCALIDAD.ToString();
                            hoja_trabajo.Cells[i, 12] = lineInv.DAP.ToString();
                            hoja_trabajo.Cells[i, 13] = lineInv.CAP.ToString();
                            hoja_trabajo.Cells[i, 14] = lineInv.ALTCOMER_M.ToString();
                            hoja_trabajo.Cells[i, 15] = lineInv.ALTTOT_M.ToString();
                        }

                        foreach (LINEANOMADERABLES lineInvNM in form.LINEANOMADERABLES)
                        {

                        }

                        foreach (LINEAREGENERACION lineInvReg in form.LINEAREGENERACION)
                        {

                        }
                        i++;
                    }
                    libros_trabajo.Worksheets.Add(hoja_trabajo);
                }

                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);                
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        
        }

        private void estratosTsm_Click(object sender, EventArgs e)
        {
            Estratos_Form childForm = new Estratos_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void gruposComercialesTsm_Click(object sender, EventArgs e)
        {
            GruposComerciales_Form childForm = new GruposComerciales_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tipoDeDiseñoTsm_Click(object sender, EventArgs e)
        {
            GruposComerciales_Form childForm = new GruposComerciales_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tipoDeUsoTsm_Click(object sender, EventArgs e)
        {
            TiposUso_Form childForm = new TiposUso_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void calidadTsm_Click(object sender, EventArgs e)
        {
            Calidad_Form childForm = new Calidad_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void estadosTsm_Click(object sender, EventArgs e)
        {
            EstadosSanitarios_Form childForm = new EstadosSanitarios_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }


    }
}
