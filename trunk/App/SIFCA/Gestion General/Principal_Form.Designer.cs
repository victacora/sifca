namespace SIFCA
{
    partial class Principal_Form
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarDatosUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.IniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProyectosTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.importarProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introducirDatosInventarioTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEspecieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEspecieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEspecieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEspeciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDiseñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.EstadoLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.fileMenu,
            this.inventarioToolStripMenuItem,
            this.especiesToolStripMenuItem,
            this.windowsMenu,
            this.configuracionToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrarUsuario,
            this.ActualizarDatosUsuario,
            this.ListarUsuarios,
            this.IniciarSesion,
            this.CerrarSesion,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "&Sistema";
            // 
            // RegistrarUsuario
            // 
            this.RegistrarUsuario.Name = "RegistrarUsuario";
            this.RegistrarUsuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.RegistrarUsuario.Size = new System.Drawing.Size(210, 22);
            this.RegistrarUsuario.Text = "&Registrar Usuarios";
            this.RegistrarUsuario.Click += new System.EventHandler(this.CrearUsuario_Click);
            // 
            // ActualizarDatosUsuario
            // 
            this.ActualizarDatosUsuario.Name = "ActualizarDatosUsuario";
            this.ActualizarDatosUsuario.Size = new System.Drawing.Size(210, 22);
            this.ActualizarDatosUsuario.Text = "&Actualizar datos";
            this.ActualizarDatosUsuario.Click += new System.EventHandler(this.ActualizarDatosUsuario_Click);
            // 
            // ListarUsuarios
            // 
            this.ListarUsuarios.Name = "ListarUsuarios";
            this.ListarUsuarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ListarUsuarios.Size = new System.Drawing.Size(210, 22);
            this.ListarUsuarios.Text = "&Listar Usuarios";
            this.ListarUsuarios.Click += new System.EventHandler(this.ListarUsuarios_Click);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(210, 22);
            this.IniciarSesion.Text = "&Iniciar Sesion";
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(210, 22);
            this.CerrarSesion.Text = "&Cerrar Sesion";
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProyectoTsm,
            this.listarProyectosTsm,
            this.importarProyectoTsm,
            this.exportarProyectoTsm});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(66, 20);
            this.fileMenu.Text = "&Proyecto";
            // 
            // nuevoProyectoTsm
            // 
            this.nuevoProyectoTsm.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoProyectoTsm.Name = "nuevoProyectoTsm";
            this.nuevoProyectoTsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.nuevoProyectoTsm.Text = "&Nuevo Proyecto";
            this.nuevoProyectoTsm.Click += new System.EventHandler(this.CreateNewProject);
            // 
            // listarProyectosTsm
            // 
            this.listarProyectosTsm.Name = "listarProyectosTsm";
            this.listarProyectosTsm.Size = new System.Drawing.Size(207, 22);
            this.listarProyectosTsm.Text = "Listar Proyectos";
            this.listarProyectosTsm.Click += new System.EventHandler(this.listarProyectosTsm_Click);
            // 
            // importarProyectoTsm
            // 
            this.importarProyectoTsm.Name = "importarProyectoTsm";
            this.importarProyectoTsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importarProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.importarProyectoTsm.Text = "&Importar Proyecto";
            // 
            // exportarProyectoTsm
            // 
            this.exportarProyectoTsm.Name = "exportarProyectoTsm";
            this.exportarProyectoTsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportarProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.exportarProyectoTsm.Text = "&Exportar Proyecto";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducirDatosInventarioTsm,
            this.listarDatosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "&Inventario";
            // 
            // introducirDatosInventarioTsm
            // 
            this.introducirDatosInventarioTsm.Name = "introducirDatosInventarioTsm";
            this.introducirDatosInventarioTsm.Size = new System.Drawing.Size(162, 22);
            this.introducirDatosInventarioTsm.Text = "Introducir Datos ";
            this.introducirDatosInventarioTsm.Click += new System.EventHandler(this.introducirDatosInventarioTsm_Click);
            // 
            // listarDatosToolStripMenuItem
            // 
            this.listarDatosToolStripMenuItem.Name = "listarDatosToolStripMenuItem";
            this.listarDatosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listarDatosToolStripMenuItem.Text = "Listar Datos";
            this.listarDatosToolStripMenuItem.Click += new System.EventHandler(this.listarDatosToolStripMenuItem_Click);
            // 
            // especiesToolStripMenuItem
            // 
            this.especiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEspecieToolStripMenuItem});
            this.especiesToolStripMenuItem.Name = "especiesToolStripMenuItem";
            this.especiesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.especiesToolStripMenuItem.Text = "&Especies";
            // 
            // ingresarEspecieToolStripMenuItem
            // 
            this.ingresarEspecieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEspecieToolStripMenuItem,
            this.modificarEspecieToolStripMenuItem,
            this.verEspeciesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.ingresarEspecieToolStripMenuItem.Name = "ingresarEspecieToolStripMenuItem";
            this.ingresarEspecieToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ingresarEspecieToolStripMenuItem.Text = "Gestionar Especie";
            // 
            // crearEspecieToolStripMenuItem
            // 
            this.crearEspecieToolStripMenuItem.Name = "crearEspecieToolStripMenuItem";
            this.crearEspecieToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.crearEspecieToolStripMenuItem.Text = "Crear Especie";
            // 
            // modificarEspecieToolStripMenuItem
            // 
            this.modificarEspecieToolStripMenuItem.Name = "modificarEspecieToolStripMenuItem";
            this.modificarEspecieToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modificarEspecieToolStripMenuItem.Text = "Modificar Especie";
            // 
            // verEspeciesToolStripMenuItem
            // 
            this.verEspeciesToolStripMenuItem.Name = "verEspeciesToolStripMenuItem";
            this.verEspeciesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.verEspeciesToolStripMenuItem.Text = "Ver Especies";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "Listar Especies";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(67, 20);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estratosToolStripMenuItem,
            this.comercialesToolStripMenuItem,
            this.tipoDeDiseñoToolStripMenuItem,
            this.objetivosToolStripMenuItem,
            this.tipoDeUsoToolStripMenuItem,
            this.calidadToolStripMenuItem,
            this.estadosToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // estratosToolStripMenuItem
            // 
            this.estratosToolStripMenuItem.Name = "estratosToolStripMenuItem";
            this.estratosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.estratosToolStripMenuItem.Text = "Estratos";
            // 
            // comercialesToolStripMenuItem
            // 
            this.comercialesToolStripMenuItem.Name = "comercialesToolStripMenuItem";
            this.comercialesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.comercialesToolStripMenuItem.Text = "Comerciales";
            // 
            // tipoDeDiseñoToolStripMenuItem
            // 
            this.tipoDeDiseñoToolStripMenuItem.Name = "tipoDeDiseñoToolStripMenuItem";
            this.tipoDeDiseñoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tipoDeDiseñoToolStripMenuItem.Text = "Tipo de Diseño";
            // 
            // objetivosToolStripMenuItem
            // 
            this.objetivosToolStripMenuItem.Name = "objetivosToolStripMenuItem";
            this.objetivosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.objetivosToolStripMenuItem.Text = "Objetivos";
            // 
            // tipoDeUsoToolStripMenuItem
            // 
            this.tipoDeUsoToolStripMenuItem.Name = "tipoDeUsoToolStripMenuItem";
            this.tipoDeUsoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tipoDeUsoToolStripMenuItem.Text = "Tipo de Uso";
            // 
            // calidadToolStripMenuItem
            // 
            this.calidadToolStripMenuItem.Name = "calidadToolStripMenuItem";
            this.calidadToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.calidadToolStripMenuItem.Text = "Calidad";
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            this.estadosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.estadosToolStripMenuItem.Text = "Estados";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator8,
            this.AcercaDe});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // AcercaDe
            // 
            this.AcercaDe.Name = "AcercaDe";
            this.AcercaDe.Size = new System.Drawing.Size(176, 22);
            this.AcercaDe.Text = "&Acerca de...";
            this.AcercaDe.Click += new System.EventHandler(this.AcercaDe_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EstadoLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // EstadoLbl
            // 
            this.EstadoLbl.Name = "EstadoLbl";
            this.EstadoLbl.Size = new System.Drawing.Size(155, 17);
            this.EstadoLbl.Text = "Ningun usuario autenticado";
            // 
            // Principal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIFCA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel EstadoLbl;
        private System.Windows.Forms.ToolStripMenuItem AcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevoProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActualizarDatosUsuario;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introducirDatosInventarioTsm;
        private System.Windows.Forms.ToolStripMenuItem importarProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem exportarProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem ingresarEspecieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProyectosTsm;
        private System.Windows.Forms.ToolStripMenuItem ListarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comercialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDiseñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem crearEspecieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEspecieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEspeciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RegistrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem listarDatosToolStripMenuItem;
    }
}



