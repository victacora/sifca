namespace SIFCA.Gestion_Configuracion
{
    partial class Costo_Form
    {
        /// <summary>
        /// Required designer operador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Costo_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.ListadoCostos = new System.Windows.Forms.DataGridView();
            this.paginacionCalidad = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.Btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarLbl = new System.Windows.Forms.ToolStripLabel();
            this.busquedaTxt = new System.Windows.Forms.ToolStripTextBox();
            this.pn_crear = new System.Windows.Forms.Panel();
            this.crearGbx = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_editar = new System.Windows.Forms.Panel();
            this.editarGbx = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoUpdCbx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.descripcionUpdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreUpdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.eP_errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.CostBSource = new System.Windows.Forms.BindingSource(this.components);
            this.nROCOSTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lISTADODECOSTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoCostos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionCalidad)).BeginInit();
            this.paginacionCalidad.SuspendLayout();
            this.pn_crear.SuspendLayout();
            this.crearGbx.SuspendLayout();
            this.pn_editar.SuspendLayout();
            this.editarGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_listado
            // 
            this.pn_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_listado.Controls.Add(this.ListadoCostos);
            this.pn_listado.Controls.Add(this.paginacionCalidad);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(526, 312);
            this.pn_listado.TabIndex = 0;
            // 
            // ListadoCostos
            // 
            this.ListadoCostos.AllowUserToAddRows = false;
            this.ListadoCostos.AllowUserToDeleteRows = false;
            this.ListadoCostos.AutoGenerateColumns = false;
            this.ListadoCostos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoCostos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nROCOSTODataGridViewTextBoxColumn,
            this.NOMBRE,
            this.DESCRIPCION,
            this.TIPO,
            this.lISTADODECOSTOSDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.ListadoCostos.DataSource = this.CostBSource;
            this.ListadoCostos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoCostos.Location = new System.Drawing.Point(0, 25);
            this.ListadoCostos.Name = "ListadoCostos";
            this.ListadoCostos.ReadOnly = true;
            this.ListadoCostos.Size = new System.Drawing.Size(522, 283);
            this.ListadoCostos.TabIndex = 0;
            this.ListadoCostos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listado_CellValueChanged);
            this.ListadoCostos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ListadoCostos_CellFormatting);
            // 
            // paginacionCalidad
            // 
            this.paginacionCalidad.AddNewItem = null;
            this.paginacionCalidad.BindingSource = this.CostBSource;
            this.paginacionCalidad.CountItem = this.bindingNavigatorCountItem;
            this.paginacionCalidad.DeleteItem = null;
            this.paginacionCalidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_nuevo,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.buscarLbl,
            this.busquedaTxt});
            this.paginacionCalidad.Location = new System.Drawing.Point(0, 0);
            this.paginacionCalidad.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionCalidad.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionCalidad.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionCalidad.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionCalidad.Name = "paginacionCalidad";
            this.paginacionCalidad.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionCalidad.Size = new System.Drawing.Size(522, 25);
            this.paginacionCalidad.TabIndex = 4;
            this.paginacionCalidad.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nuevo.Image")));
            this.Btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(46, 22);
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buscarLbl
            // 
            this.buscarLbl.Name = "buscarLbl";
            this.buscarLbl.Size = new System.Drawing.Size(45, 22);
            this.buscarLbl.Text = "Buscar:";
            // 
            // busquedaTxt
            // 
            this.busquedaTxt.Name = "busquedaTxt";
            this.busquedaTxt.Size = new System.Drawing.Size(150, 25);
            this.busquedaTxt.TextChanged += new System.EventHandler(this.busquedaTxt_TextChanged);
            // 
            // pn_crear
            // 
            this.pn_crear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_crear.Controls.Add(this.crearGbx);
            this.pn_crear.Location = new System.Drawing.Point(0, 0);
            this.pn_crear.Name = "pn_crear";
            this.pn_crear.Size = new System.Drawing.Size(339, 229);
            this.pn_crear.TabIndex = 1;
            // 
            // crearGbx
            // 
            this.crearGbx.Controls.Add(this.label5);
            this.crearGbx.Controls.Add(this.tipoCbx);
            this.crearGbx.Controls.Add(this.label4);
            this.crearGbx.Controls.Add(this.nombreTxt);
            this.crearGbx.Controls.Add(this.Btn_Cancelar);
            this.crearGbx.Controls.Add(this.Btn_Crear);
            this.crearGbx.Controls.Add(this.descripcionTxt);
            this.crearGbx.Controls.Add(this.label2);
            this.crearGbx.Location = new System.Drawing.Point(12, 10);
            this.crearGbx.Name = "crearGbx";
            this.crearGbx.Size = new System.Drawing.Size(306, 200);
            this.crearGbx.TabIndex = 2;
            this.crearGbx.TabStop = false;
            this.crearGbx.Text = "Crear Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // tipoCbx
            // 
            this.tipoCbx.FormattingEnabled = true;
            this.tipoCbx.Items.AddRange(new object[] {
            "Fijo",
            "Variable"});
            this.tipoCbx.Location = new System.Drawing.Point(100, 130);
            this.tipoCbx.Name = "tipoCbx";
            this.tipoCbx.Size = new System.Drawing.Size(179, 21);
            this.tipoCbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripcion";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(100, 22);
            this.nombreTxt.MaxLength = 500;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(179, 20);
            this.nombreTxt.TabIndex = 6;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(171, 169);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(113, 23);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(12, 169);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(101, 23);
            this.Btn_Crear.TabIndex = 1;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(100, 48);
            this.descripcionTxt.MaxLength = 500;
            this.descripcionTxt.Multiline = true;
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(179, 76);
            this.descripcionTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // pn_editar
            // 
            this.pn_editar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_editar.Controls.Add(this.editarGbx);
            this.pn_editar.Location = new System.Drawing.Point(0, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(318, 229);
            this.pn_editar.TabIndex = 2;
            // 
            // editarGbx
            // 
            this.editarGbx.Controls.Add(this.label3);
            this.editarGbx.Controls.Add(this.tipoUpdCbx);
            this.editarGbx.Controls.Add(this.button1);
            this.editarGbx.Controls.Add(this.descripcionUpdTxt);
            this.editarGbx.Controls.Add(this.label6);
            this.editarGbx.Controls.Add(this.nombreUpdTxt);
            this.editarGbx.Controls.Add(this.label1);
            this.editarGbx.Controls.Add(this.Btn_Guardar);
            this.editarGbx.Location = new System.Drawing.Point(12, 0);
            this.editarGbx.Name = "editarGbx";
            this.editarGbx.Size = new System.Drawing.Size(285, 210);
            this.editarGbx.TabIndex = 0;
            this.editarGbx.TabStop = false;
            this.editarGbx.Text = "Editar Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tipo";
            // 
            // tipoUpdCbx
            // 
            this.tipoUpdCbx.FormattingEnabled = true;
            this.tipoUpdCbx.Items.AddRange(new object[] {
            "Fijo",
            "Variable"});
            this.tipoUpdCbx.Location = new System.Drawing.Point(87, 130);
            this.tipoUpdCbx.Name = "tipoUpdCbx";
            this.tipoUpdCbx.Size = new System.Drawing.Size(178, 21);
            this.tipoUpdCbx.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_CancelarUpdate_Click);
            // 
            // descripcionUpdTxt
            // 
            this.descripcionUpdTxt.Location = new System.Drawing.Point(86, 47);
            this.descripcionUpdTxt.MaxLength = 500;
            this.descripcionUpdTxt.Multiline = true;
            this.descripcionUpdTxt.Name = "descripcionUpdTxt";
            this.descripcionUpdTxt.ShortcutsEnabled = false;
            this.descripcionUpdTxt.Size = new System.Drawing.Size(179, 72);
            this.descripcionUpdTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción";
            // 
            // nombreUpdTxt
            // 
            this.nombreUpdTxt.Location = new System.Drawing.Point(87, 18);
            this.nombreUpdTxt.Name = "nombreUpdTxt";
            this.nombreUpdTxt.Size = new System.Drawing.Size(178, 20);
            this.nombreUpdTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(18, 178);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // eP_errors
            // 
            this.eP_errors.ContainerControl = this;
            // 
            // CostBSource
            // 
            this.CostBSource.DataSource = typeof(SIFCA_DAL.COSTO);
            // 
            // nROCOSTODataGridViewTextBoxColumn
            // 
            this.nROCOSTODataGridViewTextBoxColumn.DataPropertyName = "NROCOSTO";
            this.nROCOSTODataGridViewTextBoxColumn.HeaderText = "NROCOSTO";
            this.nROCOSTODataGridViewTextBoxColumn.Name = "nROCOSTODataGridViewTextBoxColumn";
            this.nROCOSTODataGridViewTextBoxColumn.ReadOnly = true;
            this.nROCOSTODataGridViewTextBoxColumn.Visible = false;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "Descripción";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "Tipo";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // lISTADODECOSTOSDataGridViewTextBoxColumn
            // 
            this.lISTADODECOSTOSDataGridViewTextBoxColumn.DataPropertyName = "LISTADODECOSTOS";
            this.lISTADODECOSTOSDataGridViewTextBoxColumn.HeaderText = "LISTADODECOSTOS";
            this.lISTADODECOSTOSDataGridViewTextBoxColumn.Name = "lISTADODECOSTOSDataGridViewTextBoxColumn";
            this.lISTADODECOSTOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.lISTADODECOSTOSDataGridViewTextBoxColumn.Visible = false;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 5;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Eliminar.DataPropertyName = "CODCALIDAD";
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 5;
            // 
            // Costo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(545, 314);
            this.Controls.Add(this.pn_editar);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Costo_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costo";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoCostos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionCalidad)).EndInit();
            this.paginacionCalidad.ResumeLayout(false);
            this.paginacionCalidad.PerformLayout();
            this.pn_crear.ResumeLayout(false);
            this.crearGbx.ResumeLayout(false);
            this.crearGbx.PerformLayout();
            this.pn_editar.ResumeLayout(false);
            this.editarGbx.ResumeLayout(false);
            this.editarGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostBSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_listado;
        private System.Windows.Forms.DataGridView ListadoCostos;
        private System.Windows.Forms.BindingSource CostBSource;
        private System.Windows.Forms.BindingNavigator paginacionCalidad;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel buscarLbl;
        private System.Windows.Forms.ToolStripTextBox busquedaTxt;
        private System.Windows.Forms.ToolStripButton Btn_nuevo;
        private System.Windows.Forms.Panel pn_crear;
        private System.Windows.Forms.GroupBox crearGbx;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_editar;
        private System.Windows.Forms.GroupBox editarGbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox descripcionUpdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreUpdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider eP_errors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipoUpdCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoCbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROCOSTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn lISTADODECOSTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}