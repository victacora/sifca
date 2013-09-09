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
            this.introducirDatosUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introducirDatosDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regeneracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEspecieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEspeciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ListarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDiseñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.introducirDatosUsuarioToolStripMenuItem,
            this.ListarUsuariosToolStripMenuItem,
            this.CerrarSesionMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "&Sistema";
            // 
            // introducirDatosUsuarioToolStripMenuItem
            // 
            this.introducirDatosUsuarioToolStripMenuItem.Name = "introducirDatosUsuarioToolStripMenuItem";
            this.introducirDatosUsuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.introducirDatosUsuarioToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.introducirDatosUsuarioToolStripMenuItem.Text = "&Registrar Usuarios";
            this.introducirDatosUsuarioToolStripMenuItem.Click += new System.EventHandler(this.introducirDatosEstacionToolStripMenuItem_Click);
            // 
            // CerrarSesionMenuItem
            // 
            this.CerrarSesionMenuItem.Name = "CerrarSesionMenuItem";
            this.CerrarSesionMenuItem.Size = new System.Drawing.Size(210, 22);
            this.CerrarSesionMenuItem.Text = "&Cerrar Sesion";
            this.CerrarSesionMenuItem.Click += new System.EventHandler(this.listarEstacionesToolStripMenuItem_Click);
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
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.listarProyectosToolStripMenuItem,
            this.importarProyectoToolStripMenuItem,
            this.exportarProyectoToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(66, 20);
            this.fileMenu.Text = "&Proyecto";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.newToolStripMenuItem.Text = "&Nuevo Proyecto";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.CreateNewProject);
            // 
            // listarProyectosToolStripMenuItem
            // 
            this.listarProyectosToolStripMenuItem.Name = "listarProyectosToolStripMenuItem";
            this.listarProyectosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listarProyectosToolStripMenuItem.Text = "Listar Proyectos";
            this.listarProyectosToolStripMenuItem.Click += new System.EventHandler(this.listarProyectosToolStripMenuItem_Click);
            // 
            // importarProyectoToolStripMenuItem
            // 
            this.importarProyectoToolStripMenuItem.Name = "importarProyectoToolStripMenuItem";
            this.importarProyectoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importarProyectoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.importarProyectoToolStripMenuItem.Text = "&Importar Proyecto";
            this.importarProyectoToolStripMenuItem.Click += new System.EventHandler(this.ImportProject);
            // 
            // exportarProyectoToolStripMenuItem
            // 
            this.exportarProyectoToolStripMenuItem.Name = "exportarProyectoToolStripMenuItem";
            this.exportarProyectoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportarProyectoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.exportarProyectoToolStripMenuItem.Text = "&Exportar Proyecto";
            this.exportarProyectoToolStripMenuItem.Click += new System.EventHandler(this.ExportProject);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducirDatosDeInventarioToolStripMenuItem,
            this.regeneracionToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "&Inventario";
            // 
            // introducirDatosDeInventarioToolStripMenuItem
            // 
            this.introducirDatosDeInventarioToolStripMenuItem.Name = "introducirDatosDeInventarioToolStripMenuItem";
            this.introducirDatosDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.introducirDatosDeInventarioToolStripMenuItem.Text = "Introducir Datos de Inventario";
            this.introducirDatosDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.introducirDatosDeInventarioToolStripMenuItem_Click);
            // 
            // regeneracionToolStripMenuItem
            // 
            this.regeneracionToolStripMenuItem.Name = "regeneracionToolStripMenuItem";
            this.regeneracionToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.regeneracionToolStripMenuItem.Text = "Introduccir Datos de Regeneracion";
            this.regeneracionToolStripMenuItem.Click += new System.EventHandler(this.regeneracionToolStripMenuItem_Click);
            // 
            // especiesToolStripMenuItem
            // 
            this.especiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEspecieToolStripMenuItem,
            this.listarEspeciesToolStripMenuItem});
            this.especiesToolStripMenuItem.Name = "especiesToolStripMenuItem";
            this.especiesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.especiesToolStripMenuItem.Text = "&Especies";
            // 
            // ingresarEspecieToolStripMenuItem
            // 
            this.ingresarEspecieToolStripMenuItem.Name = "ingresarEspecieToolStripMenuItem";
            this.ingresarEspecieToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ingresarEspecieToolStripMenuItem.Text = "Gestionar Especie";
            this.ingresarEspecieToolStripMenuItem.Click += new System.EventHandler(this.ingresarEspecieToolStripMenuItem_Click);
            // 
            // listarEspeciesToolStripMenuItem
            // 
            this.listarEspeciesToolStripMenuItem.Name = "listarEspeciesToolStripMenuItem";
            this.listarEspeciesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listarEspeciesToolStripMenuItem.Text = "Listar Especies";
            this.listarEspeciesToolStripMenuItem.Click += new System.EventHandler(this.listarEspeciesToolStripMenuItem_Click);
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
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.CreateNewProject);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
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
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // ListarUsuariosToolStripMenuItem
            // 
            this.ListarUsuariosToolStripMenuItem.Name = "ListarUsuariosToolStripMenuItem";
            this.ListarUsuariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ListarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.ListarUsuariosToolStripMenuItem.Text = "&Listar Usuarios";
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
            // Principal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Load += new System.EventHandler(this.Principal_Form_Load);
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem introducirDatosUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introducirDatosDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regeneracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarEspecieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEspeciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comercialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDiseñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
    }
}



