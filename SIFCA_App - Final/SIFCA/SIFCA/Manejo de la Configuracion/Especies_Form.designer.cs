namespace SIFCA.Gestion_Configuracion
{
    partial class Especies_Form
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
            System.Windows.Forms.Label dESCRIPCIONLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label label40;
            System.Windows.Forms.Label label41;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especies_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.ListadoEspecies = new System.Windows.Forms.DataGridView();
            this.nOMCOMUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODESPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCIENTIFICODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPOCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grupoComercialBSource = new System.Windows.Forms.BindingSource(this.components);
            this.GRUPOECOLOGICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMILIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zONAGEOGRAFICADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zONADEVIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIAMMINCORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.specieBSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginacionEspecie = new System.Windows.Forms.BindingNavigator(this.components);
            this.Btn_nuevaEspecie = new System.Windows.Forms.ToolStripButton();
            this.buscarLbl = new System.Windows.Forms.ToolStripLabel();
            this.busquedaTxt = new System.Windows.Forms.ToolStripTextBox();
            this.filtrarLbl = new System.Windows.Forms.ToolStripLabel();
            this.criterioCbx = new System.Windows.Forms.ToolStripComboBox();
            this.GroupComBSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_GroupCom = new System.Windows.Forms.ComboBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.txt_DimCorte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ZonaGeo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_NomCient = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_NomCom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pn_crear = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grupoEcoCbx = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.btn_crearImg = new System.Windows.Forms.Button();
            this.cbox_GrupoComercial = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_DMC = new System.Windows.Forms.TextBox();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.txt_ZonaVida = new System.Windows.Forms.TextBox();
            this.txt_ZonaGeografica = new System.Windows.Forms.TextBox();
            this.txt_Familia = new System.Windows.Forms.TextBox();
            this.txt_NombreCientifico = new System.Windows.Forms.TextBox();
            this.txt_NombreComun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pn_editar = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.UpdateImageBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.imagenesBS = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.updImgUbic = new System.Windows.Forms.TextBox();
            this.pB_imgUpdate = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.updImgDesc = new System.Windows.Forms.TextBox();
            this.updImgName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updGrupoEcoCbx = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.Btn_CancelarUpdate = new System.Windows.Forms.Button();
            this.grupoComercialCbx = new System.Windows.Forms.ComboBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.txt_DimCor = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_ZonaVid = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_ZonaGeogra = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_Fam = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_NomCientifico = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_NomComun = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.eP_errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.imagenTxt = new System.Windows.Forms.TextBox();
            this.txt_descripcionImg = new System.Windows.Forms.TextBox();
            this.txt_nombreImg = new System.Windows.Forms.TextBox();
            this.imgFichero = new System.Windows.Forms.OpenFileDialog();
            this.btn_cargarImg = new System.Windows.Forms.Button();
            this.pB_imgCrear = new System.Windows.Forms.PictureBox();
            this.pn_detalle = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pB_imgDetalle = new System.Windows.Forms.PictureBox();
            this.label39 = new System.Windows.Forms.Label();
            this.rutatxt = new System.Windows.Forms.TextBox();
            this.imagenesBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.ver_detalle = new System.Windows.Forms.GroupBox();
            this.detailGrupoEcoTxt = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbxGrupoComercial_det = new System.Windows.Forms.ComboBox();
            this.txt_DimCor_det = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ZonaVid_det = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_ZonaGeogra_det = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_Fam_det = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_NomCientifico_det = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_NomComun_det = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pn_cargarImg = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btn_ImgCancelar = new System.Windows.Forms.Button();
            this.btn_ImgAceptar = new System.Windows.Forms.Button();
            this.cargarArchivo = new System.Windows.Forms.ToolStripButton();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            label40 = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoComercialBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specieBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEspecie)).BeginInit();
            this.paginacionEspecie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupComBSource)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pn_crear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pn_editar.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateImageBN)).BeginInit();
            this.UpdateImageBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_imgUpdate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_imgCrear)).BeginInit();
            this.pn_detalle.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_imgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesBN)).BeginInit();
            this.imagenesBN.SuspendLayout();
            this.ver_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pn_cargarImg.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Location = new System.Drawing.Point(12, 288);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(63, 13);
            dESCRIPCIONLabel.TabIndex = 75;
            dESCRIPCIONLabel.Text = "Descripcion";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(12, 257);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(47, 13);
            nOMBRELabel.TabIndex = 73;
            nOMBRELabel.Text = "Nombre:";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new System.Drawing.Point(12, 288);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(63, 13);
            label40.TabIndex = 75;
            label40.Text = "Descripcion";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new System.Drawing.Point(12, 257);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(47, 13);
            label41.TabIndex = 73;
            label41.Text = "Nombre:";
            // 
            // pn_listado
            // 
            this.pn_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_listado.Controls.Add(this.ListadoEspecies);
            this.pn_listado.Controls.Add(this.paginacionEspecie);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(890, 486);
            this.pn_listado.TabIndex = 0;
            // 
            // ListadoEspecies
            // 
            this.ListadoEspecies.AllowUserToAddRows = false;
            this.ListadoEspecies.AllowUserToDeleteRows = false;
            this.ListadoEspecies.AutoGenerateColumns = false;
            this.ListadoEspecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMCOMUNDataGridViewTextBoxColumn,
            this.cODESPDataGridViewTextBoxColumn,
            this.nOMCIENTIFICODataGridViewTextBoxColumn,
            this.gRUPOCOMDataGridViewTextBoxColumn,
            this.GRUPOECOLOGICO,
            this.fAMILIADataGridViewTextBoxColumn,
            this.zONAGEOGRAFICADataGridViewTextBoxColumn,
            this.zONADEVIDADataGridViewTextBoxColumn,
            this.dIAMMINCORTEDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar,
            this.Detalle});
            this.ListadoEspecies.DataSource = this.specieBSource;
            this.ListadoEspecies.Location = new System.Drawing.Point(0, 25);
            this.ListadoEspecies.Name = "ListadoEspecies";
            this.ListadoEspecies.ReadOnly = true;
            this.ListadoEspecies.Size = new System.Drawing.Size(871, 457);
            this.ListadoEspecies.TabIndex = 3;
            this.ListadoEspecies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDeEspecies_CellValueChanged);
            this.ListadoEspecies.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ListadoEspecies_CellFormatting);
            // 
            // nOMCOMUNDataGridViewTextBoxColumn
            // 
            this.nOMCOMUNDataGridViewTextBoxColumn.DataPropertyName = "NOMCOMUN";
            this.nOMCOMUNDataGridViewTextBoxColumn.HeaderText = "Nombre Común";
            this.nOMCOMUNDataGridViewTextBoxColumn.Name = "nOMCOMUNDataGridViewTextBoxColumn";
            this.nOMCOMUNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODESPDataGridViewTextBoxColumn
            // 
            this.cODESPDataGridViewTextBoxColumn.DataPropertyName = "CODESP";
            this.cODESPDataGridViewTextBoxColumn.HeaderText = "CODESP";
            this.cODESPDataGridViewTextBoxColumn.Name = "cODESPDataGridViewTextBoxColumn";
            this.cODESPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODESPDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMCIENTIFICODataGridViewTextBoxColumn
            // 
            this.nOMCIENTIFICODataGridViewTextBoxColumn.DataPropertyName = "NOMCIENTIFICO";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.HeaderText = "Nombre Cientifico";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.Name = "nOMCIENTIFICODataGridViewTextBoxColumn";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gRUPOCOMDataGridViewTextBoxColumn
            // 
            this.gRUPOCOMDataGridViewTextBoxColumn.DataPropertyName = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn.DataSource = this.grupoComercialBSource;
            this.gRUPOCOMDataGridViewTextBoxColumn.DisplayMember = "DESCRIPGRUPO";
            this.gRUPOCOMDataGridViewTextBoxColumn.HeaderText = "Grupo Comercial";
            this.gRUPOCOMDataGridViewTextBoxColumn.Name = "gRUPOCOMDataGridViewTextBoxColumn";
            this.gRUPOCOMDataGridViewTextBoxColumn.ReadOnly = true;
            this.gRUPOCOMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gRUPOCOMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gRUPOCOMDataGridViewTextBoxColumn.ValueMember = "GRUPOCOM";
            // 
            // grupoComercialBSource
            // 
            this.grupoComercialBSource.DataSource = typeof(SIFCA_DAL.GRUPOCOMERCIAL);
            // 
            // GRUPOECOLOGICO
            // 
            this.GRUPOECOLOGICO.DataPropertyName = "GRUPOECOLOGICO";
            this.GRUPOECOLOGICO.HeaderText = "Grupo eco";
            this.GRUPOECOLOGICO.Name = "GRUPOECOLOGICO";
            this.GRUPOECOLOGICO.ReadOnly = true;
            this.GRUPOECOLOGICO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GRUPOECOLOGICO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fAMILIADataGridViewTextBoxColumn
            // 
            this.fAMILIADataGridViewTextBoxColumn.DataPropertyName = "FAMILIA";
            this.fAMILIADataGridViewTextBoxColumn.HeaderText = "Familia";
            this.fAMILIADataGridViewTextBoxColumn.Name = "fAMILIADataGridViewTextBoxColumn";
            this.fAMILIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zONAGEOGRAFICADataGridViewTextBoxColumn
            // 
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.DataPropertyName = "ZONAGEOGRAFICA";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.HeaderText = "Zona Geografica";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.Name = "zONAGEOGRAFICADataGridViewTextBoxColumn";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zONADEVIDADataGridViewTextBoxColumn
            // 
            this.zONADEVIDADataGridViewTextBoxColumn.DataPropertyName = "ZONADEVIDA";
            this.zONADEVIDADataGridViewTextBoxColumn.HeaderText = "Zona De Vida";
            this.zONADEVIDADataGridViewTextBoxColumn.Name = "zONADEVIDADataGridViewTextBoxColumn";
            this.zONADEVIDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIAMMINCORTEDataGridViewTextBoxColumn
            // 
            this.dIAMMINCORTEDataGridViewTextBoxColumn.DataPropertyName = "DIAMMINCORTE";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.HeaderText = "Diametro De Corte";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.Name = "dIAMMINCORTEDataGridViewTextBoxColumn";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 40;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 49;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Ver detalle";
            this.Detalle.UseColumnTextForButtonValue = true;
            // 
            // specieBSource
            // 
            this.specieBSource.DataSource = typeof(SIFCA_DAL.ESPECIE);
            // 
            // paginacionEspecie
            // 
            this.paginacionEspecie.AddNewItem = null;
            this.paginacionEspecie.CountItem = null;
            this.paginacionEspecie.DeleteItem = null;
            this.paginacionEspecie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarArchivo,
            this.Btn_nuevaEspecie,
            this.buscarLbl,
            this.busquedaTxt,
            this.filtrarLbl,
            this.criterioCbx});
            this.paginacionEspecie.Location = new System.Drawing.Point(0, 0);
            this.paginacionEspecie.MoveFirstItem = null;
            this.paginacionEspecie.MoveLastItem = null;
            this.paginacionEspecie.MoveNextItem = null;
            this.paginacionEspecie.MovePreviousItem = null;
            this.paginacionEspecie.Name = "paginacionEspecie";
            this.paginacionEspecie.PositionItem = null;
            this.paginacionEspecie.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.paginacionEspecie.Size = new System.Drawing.Size(886, 25);
            this.paginacionEspecie.TabIndex = 2;
            this.paginacionEspecie.Text = "bindingNavigator1";
            // 
            // Btn_nuevaEspecie
            // 
            this.Btn_nuevaEspecie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_nuevaEspecie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_nuevaEspecie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_nuevaEspecie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_nuevaEspecie.Name = "Btn_nuevaEspecie";
            this.Btn_nuevaEspecie.Size = new System.Drawing.Size(87, 22);
            this.Btn_nuevaEspecie.Text = "Nueva Especie";
            this.Btn_nuevaEspecie.Click += new System.EventHandler(this.Btn_nuevaEspecie_Click);
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
            // filtrarLbl
            // 
            this.filtrarLbl.Name = "filtrarLbl";
            this.filtrarLbl.Size = new System.Drawing.Size(92, 22);
            this.filtrarLbl.Text = "Filtrar busqueda";
            // 
            // criterioCbx
            // 
            this.criterioCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterioCbx.Items.AddRange(new object[] {
            "Grupo Comercial",
            "Nombre Comun",
            "Nombre Cientifico",
            "Familia",
            "Zona Geografica",
            "Zona Vida"});
            this.criterioCbx.Name = "criterioCbx";
            this.criterioCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // GroupComBSource
            // 
            this.GroupComBSource.DataSource = typeof(SIFCA_DAL.GRUPOCOMERCIAL);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.cbx_GroupCom);
            this.groupBox.Controls.Add(this.Btn_Guardar);
            this.groupBox.Controls.Add(this.txt_DimCorte);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.textBox1);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.txt_ZonaGeo);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.textBox2);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.txt_NomCient);
            this.groupBox.Controls.Add(this.label14);
            this.groupBox.Controls.Add(this.txt_NomCom);
            this.groupBox.Controls.Add(this.label15);
            this.groupBox.Location = new System.Drawing.Point(8, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(319, 283);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Editar Especie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbx_GroupCom
            // 
            this.cbx_GroupCom.DisplayMember = "GRUPOCOM";
            this.cbx_GroupCom.FormattingEnabled = true;
            this.cbx_GroupCom.Location = new System.Drawing.Point(144, 84);
            this.cbx_GroupCom.Name = "cbx_GroupCom";
            this.cbx_GroupCom.Size = new System.Drawing.Size(152, 21);
            this.cbx_GroupCom.TabIndex = 18;
            this.cbx_GroupCom.ValueMember = "GRUPOCOM";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(38, 241);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // txt_DimCorte
            // 
            this.txt_DimCorte.Location = new System.Drawing.Point(144, 203);
            this.txt_DimCorte.Name = "txt_DimCorte";
            this.txt_DimCorte.Size = new System.Drawing.Size(61, 20);
            this.txt_DimCorte.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Diametro Corte";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Zona De Vida";
            // 
            // txt_ZonaGeo
            // 
            this.txt_ZonaGeo.Location = new System.Drawing.Point(143, 143);
            this.txt_ZonaGeo.Name = "txt_ZonaGeo";
            this.txt_ZonaGeo.Size = new System.Drawing.Size(153, 20);
            this.txt_ZonaGeo.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Zona Geografica";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Familia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Grupo Comercial";
            // 
            // txt_NomCient
            // 
            this.txt_NomCient.Location = new System.Drawing.Point(143, 54);
            this.txt_NomCient.Name = "txt_NomCient";
            this.txt_NomCient.Size = new System.Drawing.Size(153, 20);
            this.txt_NomCient.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nombre Cientifico";
            // 
            // txt_NomCom
            // 
            this.txt_NomCom.Location = new System.Drawing.Point(143, 25);
            this.txt_NomCom.Name = "txt_NomCom";
            this.txt_NomCom.Size = new System.Drawing.Size(153, 20);
            this.txt_NomCom.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nombre Comun";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(-43, -22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 288);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Especie";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.GroupComBSource;
            this.comboBox1.DisplayMember = "DESCRIPGRUPO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "GRUPOCOM";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Diametro Corte";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 182);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Zona De Vida";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Zona Geografica";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(156, 122);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(153, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Familia";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(35, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Grupo Comercial";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(156, 63);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(153, 20);
            this.textBox7.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(36, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Nombre Cientifico";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(156, 34);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(153, 20);
            this.textBox8.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(35, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Nombre Comun";
            // 
            // pn_crear
            // 
            this.pn_crear.Controls.Add(this.pictureBox1);
            this.pn_crear.Controls.Add(this.groupBox1);
            this.pn_crear.Location = new System.Drawing.Point(0, 0);
            this.pn_crear.Name = "pn_crear";
            this.pn_crear.Size = new System.Drawing.Size(376, 420);
            this.pn_crear.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SIFCA.Properties.Resources.nueva_especie;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grupoEcoCbx);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.btn_crearImg);
            this.groupBox1.Controls.Add(this.cbox_GrupoComercial);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.txt_DMC);
            this.groupBox1.Controls.Add(this.Btn_Crear);
            this.groupBox1.Controls.Add(this.txt_ZonaVida);
            this.groupBox1.Controls.Add(this.txt_ZonaGeografica);
            this.groupBox1.Controls.Add(this.txt_Familia);
            this.groupBox1.Controls.Add(this.txt_NombreCientifico);
            this.groupBox1.Controls.Add(this.txt_NombreComun);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(5, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 304);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la especie";
            // 
            // grupoEcoCbx
            // 
            this.grupoEcoCbx.DisplayMember = "GRUPOCOM";
            this.grupoEcoCbx.FormattingEnabled = true;
            this.grupoEcoCbx.Items.AddRange(new object[] {
            "Tolerante",
            "No Tolerante"});
            this.grupoEcoCbx.Location = new System.Drawing.Point(189, 217);
            this.grupoEcoCbx.Name = "grupoEcoCbx";
            this.grupoEcoCbx.Size = new System.Drawing.Size(133, 21);
            this.grupoEcoCbx.TabIndex = 10;
            this.grupoEcoCbx.ValueMember = "GRUPOCOM";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(22, 221);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(91, 13);
            this.label42.TabIndex = 11;
            this.label42.Text = "Grupo ecológico :";
            // 
            // btn_crearImg
            // 
            this.btn_crearImg.Location = new System.Drawing.Point(49, 259);
            this.btn_crearImg.Name = "btn_crearImg";
            this.btn_crearImg.Size = new System.Drawing.Size(87, 23);
            this.btn_crearImg.TabIndex = 7;
            this.btn_crearImg.Text = "Cargar imagen";
            this.btn_crearImg.UseVisualStyleBackColor = true;
            this.btn_crearImg.Click += new System.EventHandler(this.btn_crearImg_Click);
            // 
            // cbox_GrupoComercial
            // 
            this.cbox_GrupoComercial.DataSource = this.grupoComercialBSource;
            this.cbox_GrupoComercial.DisplayMember = "DESCRIPGRUPO";
            this.cbox_GrupoComercial.FormattingEnabled = true;
            this.cbox_GrupoComercial.Location = new System.Drawing.Point(136, 24);
            this.cbox_GrupoComercial.Name = "cbox_GrupoComercial";
            this.cbox_GrupoComercial.Size = new System.Drawing.Size(186, 21);
            this.cbox_GrupoComercial.TabIndex = 0;
            this.cbox_GrupoComercial.ValueMember = "GRUPOCOM";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(235, 259);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(87, 23);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_DMC
            // 
            this.txt_DMC.AcceptsTab = true;
            this.eP_errors.SetError(this.txt_DMC, "Medida en metros");
            this.txt_DMC.Location = new System.Drawing.Point(189, 189);
            this.txt_DMC.MaxLength = 25;
            this.txt_DMC.Name = "txt_DMC";
            this.txt_DMC.Size = new System.Drawing.Size(133, 20);
            this.txt_DMC.TabIndex = 6;
            this.txt_DMC.Text = "0.0";
            this.txt_DMC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatedNumericValues);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(142, 259);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(86, 23);
            this.Btn_Crear.TabIndex = 8;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // txt_ZonaVida
            // 
            this.txt_ZonaVida.AcceptsTab = true;
            this.txt_ZonaVida.Location = new System.Drawing.Point(136, 161);
            this.txt_ZonaVida.MaxLength = 200;
            this.txt_ZonaVida.Name = "txt_ZonaVida";
            this.txt_ZonaVida.Size = new System.Drawing.Size(186, 20);
            this.txt_ZonaVida.TabIndex = 5;
            this.txt_ZonaVida.Text = "Ninguna zona especificada";
            // 
            // txt_ZonaGeografica
            // 
            this.txt_ZonaGeografica.AcceptsTab = true;
            this.txt_ZonaGeografica.Location = new System.Drawing.Point(136, 132);
            this.txt_ZonaGeografica.MaxLength = 200;
            this.txt_ZonaGeografica.Name = "txt_ZonaGeografica";
            this.txt_ZonaGeografica.Size = new System.Drawing.Size(186, 20);
            this.txt_ZonaGeografica.TabIndex = 4;
            this.txt_ZonaGeografica.Text = "Ninguna zona especificada";
            // 
            // txt_Familia
            // 
            this.txt_Familia.AcceptsTab = true;
            this.txt_Familia.Location = new System.Drawing.Point(136, 106);
            this.txt_Familia.MaxLength = 200;
            this.txt_Familia.Name = "txt_Familia";
            this.txt_Familia.Size = new System.Drawing.Size(186, 20);
            this.txt_Familia.TabIndex = 3;
            // 
            // txt_NombreCientifico
            // 
            this.txt_NombreCientifico.AcceptsTab = true;
            this.txt_NombreCientifico.Location = new System.Drawing.Point(136, 80);
            this.txt_NombreCientifico.MaxLength = 200;
            this.txt_NombreCientifico.Name = "txt_NombreCientifico";
            this.txt_NombreCientifico.Size = new System.Drawing.Size(186, 20);
            this.txt_NombreCientifico.TabIndex = 2;
            // 
            // txt_NombreComun
            // 
            this.txt_NombreComun.AcceptsTab = true;
            this.txt_NombreComun.Location = new System.Drawing.Point(136, 54);
            this.txt_NombreComun.MaxLength = 200;
            this.txt_NombreComun.Name = "txt_NombreComun";
            this.txt_NombreComun.Size = new System.Drawing.Size(186, 20);
            this.txt_NombreComun.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Diametro minimo corte (Mtrs) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zona vida :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zona geografica :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Familia :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre científico :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre común :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Grupo comercial :";
            // 
            // pn_editar
            // 
            this.pn_editar.Controls.Add(this.groupBox6);
            this.pn_editar.Controls.Add(this.groupBox3);
            this.pn_editar.Location = new System.Drawing.Point(0, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(723, 445);
            this.pn_editar.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.UpdateImageBN);
            this.groupBox6.Controls.Add(this.updImgUbic);
            this.groupBox6.Controls.Add(this.pB_imgUpdate);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(label40);
            this.groupBox6.Controls.Add(this.updImgDesc);
            this.groupBox6.Controls.Add(label41);
            this.groupBox6.Controls.Add(this.updImgName);
            this.groupBox6.Location = new System.Drawing.Point(355, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(357, 388);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Imagenes";
            // 
            // UpdateImageBN
            // 
            this.UpdateImageBN.AddNewItem = null;
            this.UpdateImageBN.BindingSource = this.imagenesBS;
            this.UpdateImageBN.CountItem = this.bindingNavigatorCountItem1;
            this.UpdateImageBN.DeleteItem = null;
            this.UpdateImageBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator4,
            this.toolStripButton2,
            this.toolStripButton1});
            this.UpdateImageBN.Location = new System.Drawing.Point(3, 16);
            this.UpdateImageBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.UpdateImageBN.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.UpdateImageBN.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.UpdateImageBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.UpdateImageBN.Name = "UpdateImageBN";
            this.UpdateImageBN.PositionItem = this.bindingNavigatorPositionItem1;
            this.UpdateImageBN.Size = new System.Drawing.Size(351, 25);
            this.UpdateImageBN.TabIndex = 0;
            this.UpdateImageBN.Text = "bindingNavigator1";
            // 
            // imagenesBS
            // 
            this.imagenesBS.DataSource = typeof(SIFCA_DAL.IMAGEN);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Agregar nuevo";
            this.toolStripButton2.Click += new System.EventHandler(this.btn_crearImg_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Eliminar";
            this.toolStripButton1.Click += new System.EventHandler(this.deleteImage_Click);
            // 
            // updImgUbic
            // 
            this.updImgUbic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagenesBS, "RUTA", true));
            this.updImgUbic.Location = new System.Drawing.Point(77, 221);
            this.updImgUbic.Name = "updImgUbic";
            this.updImgUbic.Size = new System.Drawing.Size(237, 20);
            this.updImgUbic.TabIndex = 84;
            this.updImgUbic.TabStop = false;
            this.updImgUbic.Text = "Ninguna ruta ha sido especificada";
            this.updImgUbic.TextChanged += new System.EventHandler(this.rutaUpdtxt_TextChanged);
            // 
            // pB_imgUpdate
            // 
            this.pB_imgUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.imagenesBS, "RUTA", true));
            this.pB_imgUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.imagenesBS, "RUTA", true));
            this.pB_imgUpdate.Image = global::SIFCA.Properties.Resources.ninguna_imagen;
            this.pB_imgUpdate.Location = new System.Drawing.Point(27, 52);
            this.pB_imgUpdate.Name = "pB_imgUpdate";
            this.pB_imgUpdate.Size = new System.Drawing.Size(308, 160);
            this.pB_imgUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_imgUpdate.TabIndex = 83;
            this.pB_imgUpdate.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(10, 221);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 13);
            this.label36.TabIndex = 82;
            this.label36.Text = "Ubicacion";
            // 
            // updImgDesc
            // 
            this.updImgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagenesBS, "DESCRIPCION", true));
            this.updImgDesc.Location = new System.Drawing.Point(76, 290);
            this.updImgDesc.Multiline = true;
            this.updImgDesc.Name = "updImgDesc";
            this.updImgDesc.Size = new System.Drawing.Size(238, 84);
            this.updImgDesc.TabIndex = 76;
            this.updImgDesc.TabStop = false;
            this.updImgDesc.Text = "Ninguna";
            // 
            // updImgName
            // 
            this.updImgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagenesBS, "NOMBRE", true));
            this.updImgName.Location = new System.Drawing.Point(77, 256);
            this.updImgName.Name = "updImgName";
            this.updImgName.Size = new System.Drawing.Size(238, 20);
            this.updImgName.TabIndex = 74;
            this.updImgName.TabStop = false;
            this.updImgName.Text = "Ninguno";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updGrupoEcoCbx);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.Btn_CancelarUpdate);
            this.groupBox3.Controls.Add(this.grupoComercialCbx);
            this.groupBox3.Controls.Add(this.Guardar);
            this.groupBox3.Controls.Add(this.txt_DimCor);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txt_ZonaVid);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txt_ZonaGeogra);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txt_Fam);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txt_NomCientifico);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.txt_NomComun);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Location = new System.Drawing.Point(10, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 378);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editar Especie";
            // 
            // updGrupoEcoCbx
            // 
            this.updGrupoEcoCbx.FormattingEnabled = true;
            this.updGrupoEcoCbx.Items.AddRange(new object[] {
            "Tolerante",
            "No Tolerante"});
            this.updGrupoEcoCbx.Location = new System.Drawing.Point(152, 230);
            this.updGrupoEcoCbx.Name = "updGrupoEcoCbx";
            this.updGrupoEcoCbx.Size = new System.Drawing.Size(153, 21);
            this.updGrupoEcoCbx.TabIndex = 19;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(32, 233);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(85, 13);
            this.label43.TabIndex = 18;
            this.label43.Text = "Grupo ecológico";
            // 
            // Btn_CancelarUpdate
            // 
            this.Btn_CancelarUpdate.Location = new System.Drawing.Point(230, 351);
            this.Btn_CancelarUpdate.Name = "Btn_CancelarUpdate";
            this.Btn_CancelarUpdate.Size = new System.Drawing.Size(75, 23);
            this.Btn_CancelarUpdate.TabIndex = 8;
            this.Btn_CancelarUpdate.Text = "Cancelar";
            this.Btn_CancelarUpdate.UseVisualStyleBackColor = true;
            this.Btn_CancelarUpdate.Click += new System.EventHandler(this.Btn_CancelarUpdate_Click);
            // 
            // grupoComercialCbx
            // 
            this.grupoComercialCbx.DataSource = this.GroupComBSource;
            this.grupoComercialCbx.DisplayMember = "DESCRIPGRUPO";
            this.grupoComercialCbx.FormattingEnabled = true;
            this.grupoComercialCbx.Location = new System.Drawing.Point(153, 82);
            this.grupoComercialCbx.Name = "grupoComercialCbx";
            this.grupoComercialCbx.Size = new System.Drawing.Size(152, 21);
            this.grupoComercialCbx.TabIndex = 2;
            this.grupoComercialCbx.ValueMember = "GRUPOCOM";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(131, 351);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // txt_DimCor
            // 
            this.txt_DimCor.Location = new System.Drawing.Point(153, 201);
            this.txt_DimCor.Name = "txt_DimCor";
            this.txt_DimCor.Size = new System.Drawing.Size(152, 20);
            this.txt_DimCor.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(33, 201);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Diametro Corte (Mtrs)";
            // 
            // txt_ZonaVid
            // 
            this.txt_ZonaVid.Location = new System.Drawing.Point(152, 171);
            this.txt_ZonaVid.Name = "txt_ZonaVid";
            this.txt_ZonaVid.Size = new System.Drawing.Size(153, 20);
            this.txt_ZonaVid.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(31, 171);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Zona De Vida";
            // 
            // txt_ZonaGeogra
            // 
            this.txt_ZonaGeogra.Location = new System.Drawing.Point(152, 141);
            this.txt_ZonaGeogra.Name = "txt_ZonaGeogra";
            this.txt_ZonaGeogra.Size = new System.Drawing.Size(153, 20);
            this.txt_ZonaGeogra.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(32, 141);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 13);
            this.label25.TabIndex = 12;
            this.label25.Text = "Zona Geografica";
            // 
            // txt_Fam
            // 
            this.txt_Fam.Location = new System.Drawing.Point(152, 111);
            this.txt_Fam.Name = "txt_Fam";
            this.txt_Fam.Size = new System.Drawing.Size(153, 20);
            this.txt_Fam.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Familia";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(31, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Grupo Comercial";
            // 
            // txt_NomCientifico
            // 
            this.txt_NomCientifico.Location = new System.Drawing.Point(152, 52);
            this.txt_NomCientifico.Name = "txt_NomCientifico";
            this.txt_NomCientifico.Size = new System.Drawing.Size(153, 20);
            this.txt_NomCientifico.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(32, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "Nombre Cientifico";
            // 
            // txt_NomComun
            // 
            this.txt_NomComun.Location = new System.Drawing.Point(152, 23);
            this.txt_NomComun.Name = "txt_NomComun";
            this.txt_NomComun.Size = new System.Drawing.Size(153, 20);
            this.txt_NomComun.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(31, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(80, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Nombre Comun";
            // 
            // eP_errors
            // 
            this.eP_errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eP_errors.ContainerControl = this;
            // 
            // imagenTxt
            // 
            this.eP_errors.SetError(this.imagenTxt, "Cargue una imagen");
            this.imagenTxt.Location = new System.Drawing.Point(16, 14);
            this.imagenTxt.Name = "imagenTxt";
            this.imagenTxt.ReadOnly = true;
            this.imagenTxt.Size = new System.Drawing.Size(193, 20);
            this.imagenTxt.TabIndex = 24;
            this.imagenTxt.Text = "Seleccione una imagen";
            // 
            // txt_descripcionImg
            // 
            this.eP_errors.SetError(this.txt_descripcionImg, "Campo requerido");
            this.txt_descripcionImg.Location = new System.Drawing.Point(15, 74);
            this.txt_descripcionImg.Multiline = true;
            this.txt_descripcionImg.Name = "txt_descripcionImg";
            this.txt_descripcionImg.Size = new System.Drawing.Size(292, 128);
            this.txt_descripcionImg.TabIndex = 1;
            // 
            // txt_nombreImg
            // 
            this.eP_errors.SetError(this.txt_nombreImg, "Campo requerido");
            this.txt_nombreImg.Location = new System.Drawing.Point(96, 25);
            this.txt_nombreImg.Name = "txt_nombreImg";
            this.txt_nombreImg.Size = new System.Drawing.Size(211, 20);
            this.txt_nombreImg.TabIndex = 0;
            // 
            // btn_cargarImg
            // 
            this.btn_cargarImg.Location = new System.Drawing.Point(226, 12);
            this.btn_cargarImg.Name = "btn_cargarImg";
            this.btn_cargarImg.Size = new System.Drawing.Size(72, 23);
            this.btn_cargarImg.TabIndex = 0;
            this.btn_cargarImg.Text = "Cargar";
            this.btn_cargarImg.UseVisualStyleBackColor = true;
            this.btn_cargarImg.Click += new System.EventHandler(this.btn_cargarImg_Click);
            // 
            // pB_imgCrear
            // 
            this.pB_imgCrear.Location = new System.Drawing.Point(16, 38);
            this.pB_imgCrear.Name = "pB_imgCrear";
            this.pB_imgCrear.Size = new System.Drawing.Size(282, 220);
            this.pB_imgCrear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_imgCrear.TabIndex = 21;
            this.pB_imgCrear.TabStop = false;
            // 
            // pn_detalle
            // 
            this.pn_detalle.Controls.Add(this.groupBox5);
            this.pn_detalle.Controls.Add(this.ver_detalle);
            this.pn_detalle.Controls.Add(this.btn_cerrar);
            this.pn_detalle.Location = new System.Drawing.Point(0, 0);
            this.pn_detalle.Name = "pn_detalle";
            this.pn_detalle.Size = new System.Drawing.Size(678, 474);
            this.pn_detalle.TabIndex = 3;
            this.pn_detalle.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pB_imgDetalle);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.rutatxt);
            this.groupBox5.Controls.Add(this.imagenesBN);
            this.groupBox5.Controls.Add(dESCRIPCIONLabel);
            this.groupBox5.Controls.Add(this.dESCRIPCIONTextBox);
            this.groupBox5.Controls.Add(nOMBRELabel);
            this.groupBox5.Controls.Add(this.nOMBRETextBox);
            this.groupBox5.Location = new System.Drawing.Point(321, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 396);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Imagenes";
            // 
            // pB_imgDetalle
            // 
            this.pB_imgDetalle.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.imagenesBS, "RUTA", true));
            this.pB_imgDetalle.Image = global::SIFCA.Properties.Resources.ninguna_imagen;
            this.pB_imgDetalle.Location = new System.Drawing.Point(56, 55);
            this.pB_imgDetalle.Name = "pB_imgDetalle";
            this.pB_imgDetalle.Size = new System.Drawing.Size(260, 145);
            this.pB_imgDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_imgDetalle.TabIndex = 78;
            this.pB_imgDetalle.TabStop = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(10, 221);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(55, 13);
            this.label39.TabIndex = 82;
            this.label39.Text = "Ubicacion";
            // 
            // rutatxt
            // 
            this.rutatxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagenesBS, "RUTA", true));
            this.rutatxt.Enabled = false;
            this.rutatxt.Location = new System.Drawing.Point(74, 218);
            this.rutatxt.Name = "rutatxt";
            this.rutatxt.Size = new System.Drawing.Size(238, 20);
            this.rutatxt.TabIndex = 0;
            this.rutatxt.Text = "Ninguna ubicacion especificada";
            this.rutatxt.TextChanged += new System.EventHandler(this.rutatxt_TextChanged);
            // 
            // imagenesBN
            // 
            this.imagenesBN.AddNewItem = null;
            this.imagenesBN.BindingSource = this.imagenesBS;
            this.imagenesBN.CountItem = this.bindingNavigatorCountItem;
            this.imagenesBN.DeleteItem = null;
            this.imagenesBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.imagenesBN.Location = new System.Drawing.Point(3, 16);
            this.imagenesBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imagenesBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imagenesBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imagenesBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imagenesBN.Name = "imagenesBN";
            this.imagenesBN.PositionItem = this.bindingNavigatorPositionItem;
            this.imagenesBN.Size = new System.Drawing.Size(330, 25);
            this.imagenesBN.TabIndex = 80;
            this.imagenesBN.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "Ver imagenes";
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
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagenesBS, "DESCRIPCION", true));
            this.dESCRIPCIONTextBox.Enabled = false;
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(76, 290);
            this.dESCRIPCIONTextBox.Multiline = true;
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(238, 84);
            this.dESCRIPCIONTextBox.TabIndex = 2;
            this.dESCRIPCIONTextBox.Text = "Ninguna";
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagenesBS, "NOMBRE", true));
            this.nOMBRETextBox.Enabled = false;
            this.nOMBRETextBox.Location = new System.Drawing.Point(77, 256);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(238, 20);
            this.nOMBRETextBox.TabIndex = 1;
            this.nOMBRETextBox.Text = "Ninguno";
            // 
            // ver_detalle
            // 
            this.ver_detalle.Controls.Add(this.detailGrupoEcoTxt);
            this.ver_detalle.Controls.Add(this.label44);
            this.ver_detalle.Controls.Add(this.pictureBox2);
            this.ver_detalle.Controls.Add(this.cbxGrupoComercial_det);
            this.ver_detalle.Controls.Add(this.txt_DimCor_det);
            this.ver_detalle.Controls.Add(this.label2);
            this.ver_detalle.Controls.Add(this.txt_ZonaVid_det);
            this.ver_detalle.Controls.Add(this.label30);
            this.ver_detalle.Controls.Add(this.txt_ZonaGeogra_det);
            this.ver_detalle.Controls.Add(this.label31);
            this.ver_detalle.Controls.Add(this.txt_Fam_det);
            this.ver_detalle.Controls.Add(this.label32);
            this.ver_detalle.Controls.Add(this.label33);
            this.ver_detalle.Controls.Add(this.txt_NomCientifico_det);
            this.ver_detalle.Controls.Add(this.label34);
            this.ver_detalle.Controls.Add(this.txt_NomComun_det);
            this.ver_detalle.Controls.Add(this.label35);
            this.ver_detalle.Location = new System.Drawing.Point(10, 5);
            this.ver_detalle.Name = "ver_detalle";
            this.ver_detalle.Size = new System.Drawing.Size(303, 396);
            this.ver_detalle.TabIndex = 58;
            this.ver_detalle.TabStop = false;
            this.ver_detalle.Text = "Detalle especie";
            // 
            // detailGrupoEcoTxt
            // 
            this.detailGrupoEcoTxt.Location = new System.Drawing.Point(137, 312);
            this.detailGrupoEcoTxt.Name = "detailGrupoEcoTxt";
            this.detailGrupoEcoTxt.ReadOnly = true;
            this.detailGrupoEcoTxt.Size = new System.Drawing.Size(152, 20);
            this.detailGrupoEcoTxt.TabIndex = 72;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(17, 312);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(85, 13);
            this.label44.TabIndex = 73;
            this.label44.Text = "Grupo ecológico";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::SIFCA.Properties.Resources.nueva_especie;
            this.pictureBox2.Location = new System.Drawing.Point(3, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // cbxGrupoComercial_det
            // 
            this.cbxGrupoComercial_det.DataSource = this.GroupComBSource;
            this.cbxGrupoComercial_det.DisplayMember = "DESCRIPGRUPO";
            this.cbxGrupoComercial_det.Enabled = false;
            this.cbxGrupoComercial_det.FormattingEnabled = true;
            this.cbxGrupoComercial_det.Location = new System.Drawing.Point(136, 156);
            this.cbxGrupoComercial_det.Name = "cbxGrupoComercial_det";
            this.cbxGrupoComercial_det.Size = new System.Drawing.Size(152, 21);
            this.cbxGrupoComercial_det.TabIndex = 2;
            this.cbxGrupoComercial_det.ValueMember = "GRUPOCOM";
            // 
            // txt_DimCor_det
            // 
            this.txt_DimCor_det.Location = new System.Drawing.Point(137, 280);
            this.txt_DimCor_det.Name = "txt_DimCor_det";
            this.txt_DimCor_det.ReadOnly = true;
            this.txt_DimCor_det.Size = new System.Drawing.Size(152, 20);
            this.txt_DimCor_det.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Diametro Corte";
            // 
            // txt_ZonaVid_det
            // 
            this.txt_ZonaVid_det.Location = new System.Drawing.Point(136, 250);
            this.txt_ZonaVid_det.Name = "txt_ZonaVid_det";
            this.txt_ZonaVid_det.ReadOnly = true;
            this.txt_ZonaVid_det.Size = new System.Drawing.Size(153, 20);
            this.txt_ZonaVid_det.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 250);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 13);
            this.label30.TabIndex = 66;
            this.label30.Text = "Zona De Vida";
            // 
            // txt_ZonaGeogra_det
            // 
            this.txt_ZonaGeogra_det.Location = new System.Drawing.Point(136, 220);
            this.txt_ZonaGeogra_det.Name = "txt_ZonaGeogra_det";
            this.txt_ZonaGeogra_det.ReadOnly = true;
            this.txt_ZonaGeogra_det.Size = new System.Drawing.Size(153, 20);
            this.txt_ZonaGeogra_det.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 220);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 13);
            this.label31.TabIndex = 64;
            this.label31.Text = "Zona Geografica";
            // 
            // txt_Fam_det
            // 
            this.txt_Fam_det.Location = new System.Drawing.Point(135, 185);
            this.txt_Fam_det.Name = "txt_Fam_det";
            this.txt_Fam_det.ReadOnly = true;
            this.txt_Fam_det.Size = new System.Drawing.Size(153, 20);
            this.txt_Fam_det.TabIndex = 3;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(14, 185);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 13);
            this.label32.TabIndex = 62;
            this.label32.Text = "Familia";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(14, 156);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(85, 13);
            this.label33.TabIndex = 61;
            this.label33.Text = "Grupo Comercial";
            // 
            // txt_NomCientifico_det
            // 
            this.txt_NomCientifico_det.Location = new System.Drawing.Point(135, 123);
            this.txt_NomCientifico_det.Name = "txt_NomCientifico_det";
            this.txt_NomCientifico_det.ReadOnly = true;
            this.txt_NomCientifico_det.Size = new System.Drawing.Size(153, 20);
            this.txt_NomCientifico_det.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 123);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 13);
            this.label34.TabIndex = 59;
            this.label34.Text = "Nombre Cientifico";
            // 
            // txt_NomComun_det
            // 
            this.txt_NomComun_det.Location = new System.Drawing.Point(135, 94);
            this.txt_NomComun_det.Name = "txt_NomComun_det";
            this.txt_NomComun_det.ReadOnly = true;
            this.txt_NomComun_det.Size = new System.Drawing.Size(153, 20);
            this.txt_NomComun_det.TabIndex = 0;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(14, 94);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 13);
            this.label35.TabIndex = 57;
            this.label35.Text = "Nombre Comun";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(565, 408);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(92, 23);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pn_cargarImg
            // 
            this.pn_cargarImg.Controls.Add(this.pB_imgCrear);
            this.pn_cargarImg.Controls.Add(this.groupBox4);
            this.pn_cargarImg.Controls.Add(this.imagenTxt);
            this.pn_cargarImg.Controls.Add(this.btn_cargarImg);
            this.pn_cargarImg.Location = new System.Drawing.Point(0, 0);
            this.pn_cargarImg.Name = "pn_cargarImg";
            this.pn_cargarImg.Size = new System.Drawing.Size(655, 317);
            this.pn_cargarImg.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_descripcionImg);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.txt_nombreImg);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.btn_ImgCancelar);
            this.groupBox4.Controls.Add(this.btn_ImgAceptar);
            this.groupBox4.Location = new System.Drawing.Point(304, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 249);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 56);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(63, 13);
            this.label38.TabIndex = 39;
            this.label38.Text = "Descripción";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(81, 13);
            this.label37.TabIndex = 37;
            this.label37.Text = "Nombre imagen";
            // 
            // btn_ImgCancelar
            // 
            this.btn_ImgCancelar.Location = new System.Drawing.Point(209, 220);
            this.btn_ImgCancelar.Name = "btn_ImgCancelar";
            this.btn_ImgCancelar.Size = new System.Drawing.Size(98, 23);
            this.btn_ImgCancelar.TabIndex = 3;
            this.btn_ImgCancelar.Text = "Cancelar";
            this.btn_ImgCancelar.UseVisualStyleBackColor = true;
            this.btn_ImgCancelar.Click += new System.EventHandler(this.btn_ImgCancelar_Click);
            // 
            // btn_ImgAceptar
            // 
            this.btn_ImgAceptar.Location = new System.Drawing.Point(105, 220);
            this.btn_ImgAceptar.Name = "btn_ImgAceptar";
            this.btn_ImgAceptar.Size = new System.Drawing.Size(98, 23);
            this.btn_ImgAceptar.TabIndex = 2;
            this.btn_ImgAceptar.Text = "Aceptar";
            this.btn_ImgAceptar.UseVisualStyleBackColor = true;
            this.btn_ImgAceptar.Click += new System.EventHandler(this.btn_ImgAceptar_Click);
            // 
            // cargarArchivo
            // 
            this.cargarArchivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cargarArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cargarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cargarArchivo.Name = "cargarArchivo";
            this.cargarArchivo.Size = new System.Drawing.Size(88, 22);
            this.cargarArchivo.Text = "Cargar archivo";
            this.cargarArchivo.ToolTipText = "Cargar archivo con especies desde excel";
            this.cargarArchivo.Click += new System.EventHandler(this.cargarArchivo_Click);
            // 
            // Especies_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(893, 486);
            this.Controls.Add(this.pn_listado);
            this.Controls.Add(this.pn_editar);
            this.Controls.Add(this.pn_detalle);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_cargarImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Especies_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especies";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoComercialBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specieBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEspecie)).EndInit();
            this.paginacionEspecie.ResumeLayout(false);
            this.paginacionEspecie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupComBSource)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pn_crear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_editar.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateImageBN)).EndInit();
            this.UpdateImageBN.ResumeLayout(false);
            this.UpdateImageBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_imgUpdate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_imgCrear)).EndInit();
            this.pn_detalle.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_imgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesBN)).EndInit();
            this.imagenesBN.ResumeLayout(false);
            this.imagenesBN.PerformLayout();
            this.ver_detalle.ResumeLayout(false);
            this.ver_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pn_cargarImg.ResumeLayout(false);
            this.pn_cargarImg.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_listado;
        private System.Windows.Forms.BindingSource grupoComercialBSource;
        private System.Windows.Forms.BindingNavigator paginacionEspecie;
        private System.Windows.Forms.ToolStripLabel buscarLbl;
        private System.Windows.Forms.ToolStripTextBox busquedaTxt;
        private System.Windows.Forms.ToolStripLabel filtrarLbl;
        private System.Windows.Forms.ToolStripComboBox criterioCbx;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_GroupCom;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox txt_DimCorte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ZonaGeo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_NomCient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_NomCom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource specieBSource;
        private System.Windows.Forms.ToolStripButton Btn_nuevaEspecie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource GroupComBSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView ListadoEspecies;
        private System.Windows.Forms.Panel pn_crear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox_GrupoComercial;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.TextBox txt_ZonaVida;
        private System.Windows.Forms.TextBox txt_ZonaGeografica;
        private System.Windows.Forms.TextBox txt_Familia;
        private System.Windows.Forms.TextBox txt_NombreCientifico;
        private System.Windows.Forms.TextBox txt_NombreComun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pn_editar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_CancelarUpdate;
        private System.Windows.Forms.ComboBox grupoComercialCbx;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox txt_DimCor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_ZonaVid;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_ZonaGeogra;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_Fam;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_NomCientifico;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_NomComun;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ErrorProvider eP_errors;
        private System.Windows.Forms.OpenFileDialog imgFichero;
        private System.Windows.Forms.Button btn_crearImg;
        private System.Windows.Forms.Panel pn_cargarImg;
        private System.Windows.Forms.Panel pn_detalle;
        private System.Windows.Forms.PictureBox pB_imgCrear;
        private System.Windows.Forms.TextBox imagenTxt;
        private System.Windows.Forms.Button btn_cargarImg;
        private System.Windows.Forms.BindingSource imagenesBS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_descripcionImg;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txt_nombreImg;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btn_ImgCancelar;
        private System.Windows.Forms.Button btn_ImgAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.BindingNavigator imagenesBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.PictureBox pB_imgDetalle;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.GroupBox ver_detalle;
        private System.Windows.Forms.ComboBox cbxGrupoComercial_det;
        private System.Windows.Forms.TextBox txt_DimCor_det;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ZonaVid_det;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txt_ZonaGeogra_det;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_Fam_det;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_NomCientifico_det;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txt_NomComun_det;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox rutatxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_DMC;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox updImgDesc;
        private System.Windows.Forms.TextBox updImgName;
        private System.Windows.Forms.TextBox updImgUbic;
        private System.Windows.Forms.PictureBox pB_imgUpdate;
        private System.Windows.Forms.BindingNavigator UpdateImageBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox grupoEcoCbx;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox updGrupoEcoCbx;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox detailGrupoEcoTxt;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCIENTIFICODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gRUPOCOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPOECOLOGICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMILIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zONAGEOGRAFICADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zONADEVIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIAMMINCORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
        private System.Windows.Forms.ToolStripButton cargarArchivo;
    }
}