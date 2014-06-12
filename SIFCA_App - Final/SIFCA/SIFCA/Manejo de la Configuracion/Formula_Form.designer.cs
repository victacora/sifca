namespace SIFCA.Gestion_Configuracion
{
    partial class Formula_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formula_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.Listado = new System.Windows.Forms.DataGridView();
            this.TipoFormulaBS = new System.Windows.Forms.BindingSource(this.components);
            this.FormulateBS = new System.Windows.Forms.BindingSource(this.components);
            this.paginacionFormula = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.criterioCbx = new System.Windows.Forms.ToolStripComboBox();
            this.pn_crear = new System.Windows.Forms.Panel();
            this.crearGbx = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_editar = new System.Windows.Forms.Panel();
            this.editarGbx = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.updateDescripcionTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updateNombreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.eP_errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.nROFORMULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nROTIPOFORMULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROTIPOFORMULA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eXPRESIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoFormulaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormulateBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionFormula)).BeginInit();
            this.paginacionFormula.SuspendLayout();
            this.pn_crear.SuspendLayout();
            this.crearGbx.SuspendLayout();
            this.pn_editar.SuspendLayout();
            this.editarGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_listado
            // 
            this.pn_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_listado.Controls.Add(this.Listado);
            this.pn_listado.Controls.Add(this.paginacionFormula);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(702, 323);
            this.pn_listado.TabIndex = 0;
            // 
            // Listado
            // 
            this.Listado.AllowUserToAddRows = false;
            this.Listado.AllowUserToDeleteRows = false;
            this.Listado.AutoGenerateColumns = false;
            this.Listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nROFORMULADataGridViewTextBoxColumn,
            this.nROTIPOFORMULADataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.NROTIPOFORMULA,
            this.eXPRESIONDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.Listado.DataSource = this.FormulateBS;
            this.Listado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Listado.Location = new System.Drawing.Point(0, 25);
            this.Listado.Name = "Listado";
            this.Listado.ReadOnly = true;
            this.Listado.Size = new System.Drawing.Size(698, 294);
            this.Listado.TabIndex = 0;
            this.Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listado_CellValueChanged);
            // 
            // TipoFormulaBS
            // 
            this.TipoFormulaBS.DataSource = typeof(SIFCA_DAL.TIPOFORMULA);
            // 
            // FormulateBS
            // 
            this.FormulateBS.DataSource = typeof(SIFCA_DAL.FORMULA);
            // 
            // paginacionFormula
            // 
            this.paginacionFormula.AddNewItem = null;
            this.paginacionFormula.BindingSource = this.FormulateBS;
            this.paginacionFormula.CountItem = this.bindingNavigatorCountItem;
            this.paginacionFormula.DeleteItem = null;
            this.paginacionFormula.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.busquedaTxt,
            this.criterioCbx});
            this.paginacionFormula.Location = new System.Drawing.Point(0, 0);
            this.paginacionFormula.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionFormula.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionFormula.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionFormula.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionFormula.Name = "paginacionFormula";
            this.paginacionFormula.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionFormula.Size = new System.Drawing.Size(698, 25);
            this.paginacionFormula.TabIndex = 4;
            this.paginacionFormula.Text = "bindingNavigator1";
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
            // criterioCbx
            // 
            this.criterioCbx.Items.AddRange(new object[] {
            "Nombre",
            "Descripción"});
            this.criterioCbx.Name = "criterioCbx";
            this.criterioCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // pn_crear
            // 
            this.pn_crear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_crear.Controls.Add(this.crearGbx);
            this.pn_crear.Location = new System.Drawing.Point(0, 0);
            this.pn_crear.Name = "pn_crear";
            this.pn_crear.Size = new System.Drawing.Size(339, 269);
            this.pn_crear.TabIndex = 1;
            // 
            // crearGbx
            // 
            this.crearGbx.Controls.Add(this.textBox1);
            this.crearGbx.Controls.Add(this.label3);
            this.crearGbx.Controls.Add(this.Btn_Cancelar);
            this.crearGbx.Controls.Add(this.Btn_Crear);
            this.crearGbx.Controls.Add(this.txt_Descripcion);
            this.crearGbx.Controls.Add(this.label2);
            this.crearGbx.Location = new System.Drawing.Point(12, 9);
            this.crearGbx.Name = "crearGbx";
            this.crearGbx.Size = new System.Drawing.Size(306, 242);
            this.crearGbx.TabIndex = 2;
            this.crearGbx.TabStop = false;
            this.crearGbx.Text = "Crear Formula";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 19);
            this.textBox1.MaxLength = 150;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(171, 206);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(113, 23);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(12, 206);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(101, 23);
            this.Btn_Crear.TabIndex = 1;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(105, 101);
            this.txt_Descripcion.MaxLength = 500;
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(179, 76);
            this.txt_Descripcion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // pn_editar
            // 
            this.pn_editar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_editar.Controls.Add(this.editarGbx);
            this.pn_editar.Location = new System.Drawing.Point(0, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(318, 185);
            this.pn_editar.TabIndex = 2;
            // 
            // editarGbx
            // 
            this.editarGbx.Controls.Add(this.button1);
            this.editarGbx.Controls.Add(this.updateDescripcionTxt);
            this.editarGbx.Controls.Add(this.label6);
            this.editarGbx.Controls.Add(this.updateNombreTxt);
            this.editarGbx.Controls.Add(this.label1);
            this.editarGbx.Controls.Add(this.Btn_Guardar);
            this.editarGbx.Location = new System.Drawing.Point(12, 0);
            this.editarGbx.Name = "editarGbx";
            this.editarGbx.Size = new System.Drawing.Size(285, 160);
            this.editarGbx.TabIndex = 0;
            this.editarGbx.TabStop = false;
            this.editarGbx.Text = "Editar Calidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_CancelarUpdate_Click);
            // 
            // updateDescripcionTxt
            // 
            this.updateDescripcionTxt.Location = new System.Drawing.Point(86, 47);
            this.updateDescripcionTxt.MaxLength = 500;
            this.updateDescripcionTxt.Multiline = true;
            this.updateDescripcionTxt.Name = "updateDescripcionTxt";
            this.updateDescripcionTxt.ShortcutsEnabled = false;
            this.updateDescripcionTxt.Size = new System.Drawing.Size(179, 72);
            this.updateDescripcionTxt.TabIndex = 1;
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
            // updateNombreTxt
            // 
            this.updateNombreTxt.Location = new System.Drawing.Point(87, 18);
            this.updateNombreTxt.Name = "updateNombreTxt";
            this.updateNombreTxt.ReadOnly = true;
            this.updateNombreTxt.Size = new System.Drawing.Size(178, 20);
            this.updateNombreTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(18, 125);
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
            // nROFORMULADataGridViewTextBoxColumn
            // 
            this.nROFORMULADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nROFORMULADataGridViewTextBoxColumn.DataPropertyName = "NROFORMULA";
            this.nROFORMULADataGridViewTextBoxColumn.HeaderText = "NROFORMULA";
            this.nROFORMULADataGridViewTextBoxColumn.Name = "nROFORMULADataGridViewTextBoxColumn";
            this.nROFORMULADataGridViewTextBoxColumn.ReadOnly = true;
            this.nROFORMULADataGridViewTextBoxColumn.Visible = false;
            this.nROFORMULADataGridViewTextBoxColumn.Width = 108;
            // 
            // nROTIPOFORMULADataGridViewTextBoxColumn
            // 
            this.nROTIPOFORMULADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nROTIPOFORMULADataGridViewTextBoxColumn.DataPropertyName = "NROTIPOFORMULA";
            this.nROTIPOFORMULADataGridViewTextBoxColumn.HeaderText = "NROTIPOFORMULA";
            this.nROTIPOFORMULADataGridViewTextBoxColumn.Name = "nROTIPOFORMULADataGridViewTextBoxColumn";
            this.nROTIPOFORMULADataGridViewTextBoxColumn.ReadOnly = true;
            this.nROTIPOFORMULADataGridViewTextBoxColumn.Visible = false;
            this.nROTIPOFORMULADataGridViewTextBoxColumn.Width = 133;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBREDataGridViewTextBoxColumn.Width = 69;
            // 
            // NROTIPOFORMULA
            // 
            this.NROTIPOFORMULA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NROTIPOFORMULA.DataPropertyName = "NROTIPOFORMULA";
            this.NROTIPOFORMULA.DataSource = this.TipoFormulaBS;
            this.NROTIPOFORMULA.DisplayMember = "NOMBRETIPO";
            this.NROTIPOFORMULA.HeaderText = "Tipo formula";
            this.NROTIPOFORMULA.Name = "NROTIPOFORMULA";
            this.NROTIPOFORMULA.ReadOnly = true;
            this.NROTIPOFORMULA.ValueMember = "NROTIPOFORMULA";
            this.NROTIPOFORMULA.Width = 71;
            // 
            // eXPRESIONDataGridViewTextBoxColumn
            // 
            this.eXPRESIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eXPRESIONDataGridViewTextBoxColumn.DataPropertyName = "EXPRESION";
            this.eXPRESIONDataGridViewTextBoxColumn.HeaderText = "Expresión";
            this.eXPRESIONDataGridViewTextBoxColumn.Name = "eXPRESIONDataGridViewTextBoxColumn";
            this.eXPRESIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXPRESIONDataGridViewTextBoxColumn.Width = 78;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPCIONDataGridViewTextBoxColumn.Width = 88;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 5;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Eliminar.DataPropertyName = "CODCALIDAD";
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 5;
            // 
            // Formula_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(545, 314);
            this.Controls.Add(this.pn_listado);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formula_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulas";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoFormulaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormulateBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionFormula)).EndInit();
            this.paginacionFormula.ResumeLayout(false);
            this.paginacionFormula.PerformLayout();
            this.pn_crear.ResumeLayout(false);
            this.crearGbx.ResumeLayout(false);
            this.crearGbx.PerformLayout();
            this.pn_editar.ResumeLayout(false);
            this.editarGbx.ResumeLayout(false);
            this.editarGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_listado;
        private System.Windows.Forms.DataGridView Listado;
        private System.Windows.Forms.BindingSource FormulateBS;
        private System.Windows.Forms.BindingNavigator paginacionFormula;
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
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_editar;
        private System.Windows.Forms.GroupBox editarGbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox updateDescripcionTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateNombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider eP_errors;
        private System.Windows.Forms.BindingSource TipoFormulaBS;
        private System.Windows.Forms.ToolStripComboBox criterioCbx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROFORMULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROTIPOFORMULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn NROTIPOFORMULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPRESIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}