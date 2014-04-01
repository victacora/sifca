namespace SIFCA.Gestion_Configuracion
{
    partial class TStudent_Form
    {
        /// <summary>
        /// Required designer variable.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TStudent_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.pBarLoad = new System.Windows.Forms.ProgressBar();
            this.ListadoTStudent = new System.Windows.Forms.DataGridView();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLPHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TStudentBSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginacionTStudent = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.Btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Criterio_tSCB = new System.Windows.Forms.ToolStripComboBox();
            this.pn_crear = new System.Windows.Forms.Panel();
            this.crearGbx = new System.Windows.Forms.GroupBox();
            this.crearValor_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.crearAlpha_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.crearN_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_editar = new System.Windows.Forms.Panel();
            this.editarGbx = new System.Windows.Forms.GroupBox();
            this.updateValor_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.updateAlpha_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updateN_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.eP_errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TStudentBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTStudent)).BeginInit();
            this.paginacionTStudent.SuspendLayout();
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
            this.pn_listado.Controls.Add(this.pBarLoad);
            this.pn_listado.Controls.Add(this.ListadoTStudent);
            this.pn_listado.Controls.Add(this.paginacionTStudent);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(664, 312);
            this.pn_listado.TabIndex = 0;
            // 
            // pBarLoad
            // 
            this.pBarLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBarLoad.Location = new System.Drawing.Point(0, 285);
            this.pBarLoad.Name = "pBarLoad";
            this.pBarLoad.Size = new System.Drawing.Size(660, 23);
            this.pBarLoad.TabIndex = 5;
            // 
            // ListadoTStudent
            // 
            this.ListadoTStudent.AllowUserToAddRows = false;
            this.ListadoTStudent.AllowUserToDeleteRows = false;
            this.ListadoTStudent.AutoGenerateColumns = false;
            this.ListadoTStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoTStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoTStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nDataGridViewTextBoxColumn,
            this.aLPHADataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.ListadoTStudent.DataSource = this.TStudentBSource;
            this.ListadoTStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoTStudent.Location = new System.Drawing.Point(0, 25);
            this.ListadoTStudent.Name = "ListadoTStudent";
            this.ListadoTStudent.ReadOnly = true;
            this.ListadoTStudent.Size = new System.Drawing.Size(660, 283);
            this.ListadoTStudent.TabIndex = 0;
            this.ListadoTStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listado_CellValueChanged);
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLPHADataGridViewTextBoxColumn
            // 
            this.aLPHADataGridViewTextBoxColumn.DataPropertyName = "ALPHA";
            this.aLPHADataGridViewTextBoxColumn.HeaderText = "ALPHA";
            this.aLPHADataGridViewTextBoxColumn.Name = "aLPHADataGridViewTextBoxColumn";
            this.aLPHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Eliminar.DataPropertyName = "N";
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 5;
            // 
            // TStudentBSource
            // 
            this.TStudentBSource.DataSource = typeof(SIFCA_DAL.TSTUDENT);
            // 
            // paginacionTStudent
            // 
            this.paginacionTStudent.AddNewItem = null;
            this.paginacionTStudent.BindingSource = this.TStudentBSource;
            this.paginacionTStudent.CountItem = this.bindingNavigatorCountItem;
            this.paginacionTStudent.DeleteItem = null;
            this.paginacionTStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_nuevo,
            this.toolStripLabel2,
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
            this.toolStripLabel1,
            this.Criterio_tSCB});
            this.paginacionTStudent.Location = new System.Drawing.Point(0, 0);
            this.paginacionTStudent.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionTStudent.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionTStudent.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionTStudent.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionTStudent.Name = "paginacionTStudent";
            this.paginacionTStudent.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionTStudent.Size = new System.Drawing.Size(660, 25);
            this.paginacionTStudent.TabIndex = 4;
            this.paginacionTStudent.Text = "bindingNavigator1";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel2.Text = "Cargar tabla";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // Criterio_tSCB
            // 
            this.Criterio_tSCB.Items.AddRange(new object[] {
            "N",
            "ALPHA",
            "VALOR"});
            this.Criterio_tSCB.Name = "Criterio_tSCB";
            this.Criterio_tSCB.Size = new System.Drawing.Size(121, 25);
            // 
            // pn_crear
            // 
            this.pn_crear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_crear.Controls.Add(this.crearGbx);
            this.pn_crear.Location = new System.Drawing.Point(0, 0);
            this.pn_crear.Name = "pn_crear";
            this.pn_crear.Size = new System.Drawing.Size(279, 185);
            this.pn_crear.TabIndex = 1;
            // 
            // crearGbx
            // 
            this.crearGbx.Controls.Add(this.crearValor_txt);
            this.crearGbx.Controls.Add(this.label4);
            this.crearGbx.Controls.Add(this.crearAlpha_txt);
            this.crearGbx.Controls.Add(this.label3);
            this.crearGbx.Controls.Add(this.Btn_Cancelar);
            this.crearGbx.Controls.Add(this.Btn_Crear);
            this.crearGbx.Controls.Add(this.crearN_txt);
            this.crearGbx.Controls.Add(this.label2);
            this.crearGbx.Location = new System.Drawing.Point(12, 11);
            this.crearGbx.Name = "crearGbx";
            this.crearGbx.Size = new System.Drawing.Size(246, 154);
            this.crearGbx.TabIndex = 2;
            this.crearGbx.TabStop = false;
            this.crearGbx.Text = "Crear TStudent";
            // 
            // crearValor_txt
            // 
            this.crearValor_txt.Location = new System.Drawing.Point(105, 68);
            this.crearValor_txt.MaxLength = 22;
            this.crearValor_txt.Name = "crearValor_txt";
            this.crearValor_txt.Size = new System.Drawing.Size(103, 20);
            this.crearValor_txt.TabIndex = 2;
            this.crearValor_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatedNumericValues);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // crearAlpha_txt
            // 
            this.crearAlpha_txt.Location = new System.Drawing.Point(105, 42);
            this.crearAlpha_txt.MaxLength = 22;
            this.crearAlpha_txt.Name = "crearAlpha_txt";
            this.crearAlpha_txt.Size = new System.Drawing.Size(103, 20);
            this.crearAlpha_txt.TabIndex = 1;
            this.crearAlpha_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatedNumericValues);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alpha";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(139, 104);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(70, 23);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(41, 104);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(67, 23);
            this.Btn_Crear.TabIndex = 3;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // crearN_txt
            // 
            this.crearN_txt.Location = new System.Drawing.Point(105, 16);
            this.crearN_txt.MaxLength = 18;
            this.crearN_txt.Name = "crearN_txt";
            this.crearN_txt.Size = new System.Drawing.Size(103, 20);
            this.crearN_txt.TabIndex = 0;
            this.crearN_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatedNumericValues);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N";
            // 
            // pn_editar
            // 
            this.pn_editar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_editar.Controls.Add(this.editarGbx);
            this.pn_editar.Location = new System.Drawing.Point(0, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(279, 185);
            this.pn_editar.TabIndex = 2;
            // 
            // editarGbx
            // 
            this.editarGbx.Controls.Add(this.updateValor_txt);
            this.editarGbx.Controls.Add(this.label5);
            this.editarGbx.Controls.Add(this.button1);
            this.editarGbx.Controls.Add(this.updateAlpha_txt);
            this.editarGbx.Controls.Add(this.label6);
            this.editarGbx.Controls.Add(this.updateN_txt);
            this.editarGbx.Controls.Add(this.label1);
            this.editarGbx.Controls.Add(this.Btn_Guardar);
            this.editarGbx.Location = new System.Drawing.Point(20, 2);
            this.editarGbx.Name = "editarGbx";
            this.editarGbx.Size = new System.Drawing.Size(224, 160);
            this.editarGbx.TabIndex = 0;
            this.editarGbx.TabStop = false;
            this.editarGbx.Text = "Editar TStudent";
            // 
            // updateValor_txt
            // 
            this.updateValor_txt.Location = new System.Drawing.Point(86, 79);
            this.updateValor_txt.MaxLength = 22;
            this.updateValor_txt.Name = "updateValor_txt";
            this.updateValor_txt.ShortcutsEnabled = false;
            this.updateValor_txt.Size = new System.Drawing.Size(103, 20);
            this.updateValor_txt.TabIndex = 2;
            this.updateValor_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatedNumericValues);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Valor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_CancelarUpdate_Click);
            // 
            // updateAlpha_txt
            // 
            this.updateAlpha_txt.Location = new System.Drawing.Point(86, 47);
            this.updateAlpha_txt.MaxLength = 22;
            this.updateAlpha_txt.Name = "updateAlpha_txt";
            this.updateAlpha_txt.ShortcutsEnabled = false;
            this.updateAlpha_txt.Size = new System.Drawing.Size(103, 20);
            this.updateAlpha_txt.TabIndex = 1;
            this.updateAlpha_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatedNumericValues);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alpha";
            // 
            // updateN_txt
            // 
            this.updateN_txt.Location = new System.Drawing.Point(87, 18);
            this.updateN_txt.MaxLength = 18;
            this.updateN_txt.Name = "updateN_txt";
            this.updateN_txt.ReadOnly = true;
            this.updateN_txt.Size = new System.Drawing.Size(102, 20);
            this.updateN_txt.TabIndex = 0;
            this.updateN_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatedNumericValues);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(29, 115);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(62, 23);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // eP_errors
            // 
            this.eP_errors.ContainerControl = this;
            // 
            // TStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(690, 324);
            this.Controls.Add(this.pn_listado);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TStudent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla TStudent";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TStudentBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTStudent)).EndInit();
            this.paginacionTStudent.ResumeLayout(false);
            this.paginacionTStudent.PerformLayout();
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
        private System.Windows.Forms.DataGridView ListadoTStudent;
        private System.Windows.Forms.BindingSource TStudentBSource;
        private System.Windows.Forms.BindingNavigator paginacionTStudent;
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
        private System.Windows.Forms.TextBox crearN_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_editar;
        private System.Windows.Forms.GroupBox editarGbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox updateAlpha_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateN_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider eP_errors;
        private System.Windows.Forms.TextBox crearValor_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox crearAlpha_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateValor_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox Criterio_tSCB;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ProgressBar pBarLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLPHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}