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
            this.usuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosUsuarioTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuariosTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirProyectosTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.importarProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProyectoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFormularioTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFormulariosTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEspeciesTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoVerticalTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoHorizontalTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.estratosTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposComercialesTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDiseñoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivoInevntarioTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.calidadTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeTsm = new System.Windows.Forms.ToolStripMenuItem();
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
            this.usuarioMenu,
            this.proyectoMenu,
            this.inventarioMenu,
            this.especiesMenu,
            this.ventanasMenu,
            this.configuracionMenu,
            this.ayudaMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.ventanasMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // usuarioMenu
            // 
            this.usuarioMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarDatosUsuarioTsm,
            this.registrarUsuarioTsm,
            this.listarUsuariosTsm,
            this.iniciarSesionTsm,
            this.cerrarSesionTsm});
            this.usuarioMenu.Name = "usuarioMenu";
            this.usuarioMenu.Size = new System.Drawing.Size(64, 20);
            this.usuarioMenu.Text = "&Usuarios";
            // 
            // actualizarDatosUsuarioTsm
            // 
            this.actualizarDatosUsuarioTsm.Name = "actualizarDatosUsuarioTsm";
            this.actualizarDatosUsuarioTsm.Size = new System.Drawing.Size(189, 22);
            this.actualizarDatosUsuarioTsm.Text = "&Actualizar datos";
            this.actualizarDatosUsuarioTsm.Visible = false;
            this.actualizarDatosUsuarioTsm.Click += new System.EventHandler(this.actualizarDatosUsuarioTsm_Click);
            // 
            // registrarUsuarioTsm
            // 
            this.registrarUsuarioTsm.Name = "registrarUsuarioTsm";
            this.registrarUsuarioTsm.Size = new System.Drawing.Size(189, 22);
            this.registrarUsuarioTsm.Text = "Registrar usuario";
            this.registrarUsuarioTsm.Click += new System.EventHandler(this.registrarUsuarioTsm_Click);
            // 
            // listarUsuariosTsm
            // 
            this.listarUsuariosTsm.Name = "listarUsuariosTsm";
            this.listarUsuariosTsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listarUsuariosTsm.Size = new System.Drawing.Size(189, 22);
            this.listarUsuariosTsm.Text = "&Listar usuarios";
            this.listarUsuariosTsm.Visible = false;
            this.listarUsuariosTsm.Click += new System.EventHandler(this.listarUsuariosTsm_Click);
            // 
            // iniciarSesionTsm
            // 
            this.iniciarSesionTsm.Name = "iniciarSesionTsm";
            this.iniciarSesionTsm.Size = new System.Drawing.Size(189, 22);
            this.iniciarSesionTsm.Text = "&Iniciar sesion";
            this.iniciarSesionTsm.Click += new System.EventHandler(this.iniciarSesionTsm_Click);
            // 
            // cerrarSesionTsm
            // 
            this.cerrarSesionTsm.Name = "cerrarSesionTsm";
            this.cerrarSesionTsm.Size = new System.Drawing.Size(189, 22);
            this.cerrarSesionTsm.Text = "&Cerrar sesion";
            this.cerrarSesionTsm.Click += new System.EventHandler(this.cerrarSesionTsm_Click);
            // 
            // proyectoMenu
            // 
            this.proyectoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirProyectosTsm,
            this.nuevoProyectoTsm,
            this.actualizarProyectoTsm,
            this.eliminarProyectoTsm,
            this.importarProyectoTsm,
            this.exportarProyectoTsm,
            this.cerrarProyectoTsm});
            this.proyectoMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.proyectoMenu.Name = "proyectoMenu";
            this.proyectoMenu.Size = new System.Drawing.Size(66, 20);
            this.proyectoMenu.Text = "&Proyecto";
            // 
            // abrirProyectosTsm
            // 
            this.abrirProyectosTsm.Name = "abrirProyectosTsm";
            this.abrirProyectosTsm.Size = new System.Drawing.Size(207, 22);
            this.abrirProyectosTsm.Text = "&Abrir proyecto";
            this.abrirProyectosTsm.Click += new System.EventHandler(this.abrirProyectosTsm_Click);
            // 
            // nuevoProyectoTsm
            // 
            this.nuevoProyectoTsm.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoProyectoTsm.Name = "nuevoProyectoTsm";
            this.nuevoProyectoTsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.nuevoProyectoTsm.Text = "&Nuevo proyecto";
            this.nuevoProyectoTsm.Click += new System.EventHandler(this.nuevoProyectoTsm_Click);
            // 
            // actualizarProyectoTsm
            // 
            this.actualizarProyectoTsm.Name = "actualizarProyectoTsm";
            this.actualizarProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.actualizarProyectoTsm.Text = "Actualizar  proyecto";
            this.actualizarProyectoTsm.Visible = false;
            this.actualizarProyectoTsm.Click += new System.EventHandler(this.actualizarProyectoTsm_Click);
            // 
            // eliminarProyectoTsm
            // 
            this.eliminarProyectoTsm.Name = "eliminarProyectoTsm";
            this.eliminarProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.eliminarProyectoTsm.Text = "Eliminar proyecto";
            this.eliminarProyectoTsm.Visible = false;
            this.eliminarProyectoTsm.Click += new System.EventHandler(this.eliminarProyectoTsm_Click);
            // 
            // importarProyectoTsm
            // 
            this.importarProyectoTsm.Name = "importarProyectoTsm";
            this.importarProyectoTsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importarProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.importarProyectoTsm.Text = "&Importar proyecto";
            this.importarProyectoTsm.Click += new System.EventHandler(this.importarProyectoTsm_Click);
            // 
            // exportarProyectoTsm
            // 
            this.exportarProyectoTsm.Name = "exportarProyectoTsm";
            this.exportarProyectoTsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportarProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.exportarProyectoTsm.Text = "&Exportar proyecto";
            this.exportarProyectoTsm.Click += new System.EventHandler(this.exportarProyectoTsm_Click);
            // 
            // cerrarProyectoTsm
            // 
            this.cerrarProyectoTsm.Name = "cerrarProyectoTsm";
            this.cerrarProyectoTsm.Size = new System.Drawing.Size(207, 22);
            this.cerrarProyectoTsm.Text = "Cerrar proyecto";
            this.cerrarProyectoTsm.Visible = false;
            this.cerrarProyectoTsm.Click += new System.EventHandler(this.cerrarProyectoTsm_Click);
            // 
            // inventarioMenu
            // 
            this.inventarioMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearFormularioTsm,
            this.abrirFormulariosTsm});
            this.inventarioMenu.Name = "inventarioMenu";
            this.inventarioMenu.Size = new System.Drawing.Size(72, 20);
            this.inventarioMenu.Text = "&Inventario";
            this.inventarioMenu.Visible = false;
            // 
            // crearFormularioTsm
            // 
            this.crearFormularioTsm.Name = "crearFormularioTsm";
            this.crearFormularioTsm.Size = new System.Drawing.Size(167, 22);
            this.crearFormularioTsm.Text = "Crear  formulario";
            this.crearFormularioTsm.Click += new System.EventHandler(this.crearFormularioTsm_Click);
            // 
            // abrirFormulariosTsm
            // 
            this.abrirFormulariosTsm.Name = "abrirFormulariosTsm";
            this.abrirFormulariosTsm.Size = new System.Drawing.Size(167, 22);
            this.abrirFormulariosTsm.Text = "Abrir  formularios";
            this.abrirFormulariosTsm.Click += new System.EventHandler(this.abrirFormulariosTsm_Click);
            // 
            // especiesMenu
            // 
            this.especiesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarEspeciesTsm});
            this.especiesMenu.Name = "especiesMenu";
            this.especiesMenu.Size = new System.Drawing.Size(63, 20);
            this.especiesMenu.Text = "&Especies";
            // 
            // listarEspeciesTsm
            // 
            this.listarEspeciesTsm.Name = "listarEspeciesTsm";
            this.listarEspeciesTsm.Size = new System.Drawing.Size(149, 22);
            this.listarEspeciesTsm.Text = "Listar especies";
            this.listarEspeciesTsm.Click += new System.EventHandler(this.listarEspeciesTsm_Click);
            // 
            // ventanasMenu
            // 
            this.ventanasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaTsm,
            this.mosaicoVerticalTsm,
            this.mosaicoHorizontalTsm,
            this.cerrarTodoTsm});
            this.ventanasMenu.Name = "ventanasMenu";
            this.ventanasMenu.Size = new System.Drawing.Size(67, 20);
            this.ventanasMenu.Text = "&Ventanas";
            // 
            // cascadaTsm
            // 
            this.cascadaTsm.Name = "cascadaTsm";
            this.cascadaTsm.Size = new System.Drawing.Size(175, 22);
            this.cascadaTsm.Text = "&Cascada";
            this.cascadaTsm.Click += new System.EventHandler(this.cascadaTsm_Click);
            // 
            // mosaicoVerticalTsm
            // 
            this.mosaicoVerticalTsm.Name = "mosaicoVerticalTsm";
            this.mosaicoVerticalTsm.Size = new System.Drawing.Size(175, 22);
            this.mosaicoVerticalTsm.Text = "Mosaico &vertical";
            this.mosaicoVerticalTsm.Click += new System.EventHandler(this.mosaicoVerticalTsm_Click);
            // 
            // mosaicoHorizontalTsm
            // 
            this.mosaicoHorizontalTsm.Name = "mosaicoHorizontalTsm";
            this.mosaicoHorizontalTsm.Size = new System.Drawing.Size(175, 22);
            this.mosaicoHorizontalTsm.Text = "Mosaico &horizontal";
            this.mosaicoHorizontalTsm.Click += new System.EventHandler(this.mosaicoHorizontalTsm_Click);
            // 
            // cerrarTodoTsm
            // 
            this.cerrarTodoTsm.Name = "cerrarTodoTsm";
            this.cerrarTodoTsm.Size = new System.Drawing.Size(175, 22);
            this.cerrarTodoTsm.Text = "C&errar todo";
            this.cerrarTodoTsm.Click += new System.EventHandler(this.cerrarTodoTsm_Click);
            // 
            // configuracionMenu
            // 
            this.configuracionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estratosTsm,
            this.gruposComercialesTsm,
            this.tipoDeDiseñoTsm,
            this.objetivoInevntarioTsm,
            this.tipoDeUsoTsm,
            this.calidadTsm,
            this.estadosTsm});
            this.configuracionMenu.Name = "configuracionMenu";
            this.configuracionMenu.Size = new System.Drawing.Size(95, 20);
            this.configuracionMenu.Text = "Configuracion";
            // 
            // estratosTsm
            // 
            this.estratosTsm.Name = "estratosTsm";
            this.estratosTsm.Size = new System.Drawing.Size(232, 22);
            this.estratosTsm.Text = "Estratos";
            // 
            // gruposComercialesTsm
            // 
            this.gruposComercialesTsm.Name = "gruposComercialesTsm";
            this.gruposComercialesTsm.Size = new System.Drawing.Size(232, 22);
            this.gruposComercialesTsm.Text = "Grupos comerciales";
            // 
            // tipoDeDiseñoTsm
            // 
            this.tipoDeDiseñoTsm.Name = "tipoDeDiseñoTsm";
            this.tipoDeDiseñoTsm.Size = new System.Drawing.Size(232, 22);
            this.tipoDeDiseñoTsm.Text = "Tipo de diseños";
            // 
            // objetivoInevntarioTsm
            // 
            this.objetivoInevntarioTsm.Name = "objetivoInevntarioTsm";
            this.objetivoInevntarioTsm.Size = new System.Drawing.Size(232, 22);
            this.objetivoInevntarioTsm.Text = "Objetivos inventario";
            // 
            // tipoDeUsoTsm
            // 
            this.tipoDeUsoTsm.Name = "tipoDeUsoTsm";
            this.tipoDeUsoTsm.Size = new System.Drawing.Size(232, 22);
            this.tipoDeUsoTsm.Text = "Tipo de usos (No maderables)";
            // 
            // calidadTsm
            // 
            this.calidadTsm.Name = "calidadTsm";
            this.calidadTsm.Size = new System.Drawing.Size(232, 22);
            this.calidadTsm.Text = "Calidad";
            // 
            // estadosTsm
            // 
            this.estadosTsm.Name = "estadosTsm";
            this.estadosTsm.Size = new System.Drawing.Size(232, 22);
            this.estadosTsm.Text = "Estados";
            // 
            // ayudaMenu
            // 
            this.ayudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contenidoTsm,
            this.toolStripSeparator8,
            this.acercaDeTsm});
            this.ayudaMenu.Name = "ayudaMenu";
            this.ayudaMenu.Size = new System.Drawing.Size(53, 20);
            this.ayudaMenu.Text = "Ay&uda";
            // 
            // contenidoTsm
            // 
            this.contenidoTsm.Name = "contenidoTsm";
            this.contenidoTsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contenidoTsm.Size = new System.Drawing.Size(176, 22);
            this.contenidoTsm.Text = "&Contenido";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // acercaDeTsm
            // 
            this.acercaDeTsm.Name = "acercaDeTsm";
            this.acercaDeTsm.Size = new System.Drawing.Size(176, 22);
            this.acercaDeTsm.Text = "&Acerca de...";
            this.acercaDeTsm.Click += new System.EventHandler(this.AcercaDe_Click);
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
        private System.Windows.Forms.ToolStripMenuItem acercaDeTsm;
        private System.Windows.Forms.ToolStripMenuItem mosaicoHorizontalTsm;
        private System.Windows.Forms.ToolStripMenuItem proyectoMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevoProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem ventanasMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadaTsm;
        private System.Windows.Forms.ToolStripMenuItem mosaicoVerticalTsm;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodoTsm;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenu;
        private System.Windows.Forms.ToolStripMenuItem contenidoTsm;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inventarioMenu;
        private System.Windows.Forms.ToolStripMenuItem especiesMenu;
        private System.Windows.Forms.ToolStripMenuItem usuarioMenu;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionTsm;
        private System.Windows.Forms.ToolStripMenuItem crearFormularioTsm;
        private System.Windows.Forms.ToolStripMenuItem importarProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem exportarProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem listarEspeciesTsm;
        private System.Windows.Forms.ToolStripMenuItem actualizarProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem configuracionMenu;
        private System.Windows.Forms.ToolStripMenuItem estratosTsm;
        private System.Windows.Forms.ToolStripMenuItem gruposComercialesTsm;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDiseñoTsm;
        private System.Windows.Forms.ToolStripMenuItem objetivoInevntarioTsm;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsoTsm;
        private System.Windows.Forms.ToolStripMenuItem calidadTsm;
        private System.Windows.Forms.ToolStripMenuItem estadosTsm;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionTsm;
        private System.Windows.Forms.ToolStripMenuItem abrirFormulariosTsm;
        private System.Windows.Forms.ToolStripMenuItem eliminarProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosUsuarioTsm;
        private System.Windows.Forms.ToolStripMenuItem listarUsuariosTsm;
        private System.Windows.Forms.ToolStripMenuItem abrirProyectosTsm;
        private System.Windows.Forms.ToolStripMenuItem cerrarProyectoTsm;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioTsm;
    }
}



