namespace SIFCA
{
    partial class Crear_Proyecto_Form
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
            System.Windows.Forms.Label descripcionLbl;
            System.Windows.Forms.Label facFormaLbl;
            System.Windows.Forms.Label areaFustalesLbl;
            System.Windows.Forms.Label tamanioParLbl;
            System.Windows.Forms.Label lugarLbl;
            System.Windows.Forms.Label TipoDisenoLbl;
            System.Windows.Forms.Label objetivoInvTxt;
            System.Windows.Forms.Label numeroEtapasLbl;
            System.Windows.Forms.Label valorMinimoDAPLbl;
            System.Windows.Forms.Label intensidadMuestreLbl;
            System.Windows.Forms.Label areaMuestreadaLbl;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label formulaLbl;
            System.Windows.Forms.Label expresionLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Proyecto_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.crearProyectoTab = new System.Windows.Forms.TabControl();
            this.proyectoTabP = new System.Windows.Forms.TabPage();
            this.DatosProyectoGbx = new System.Windows.Forms.GroupBox();
            this.TipoProyectoCbx = new System.Windows.Forms.ComboBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.tipoDisenoCbx = new System.Windows.Forms.ComboBox();
            this.nuevoProyectoBS = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDisenoBS = new System.Windows.Forms.BindingSource(this.components);
            this.tipoObjetivoCbx = new System.Windows.Forms.ComboBox();
            this.objetivoInventarioBS = new System.Windows.Forms.BindingSource(this.components);
            this.otrosDatosGbx = new System.Windows.Forms.GroupBox();
            this.expresionTxt = new System.Windows.Forms.TextBox();
            this.formulaBS = new System.Windows.Forms.BindingSource(this.components);
            this.formularComboBox = new System.Windows.Forms.ComboBox();
            this.numeroParcelasMuestraTxt = new System.Windows.Forms.TextBox();
            this.numeroParcelasTxt = new System.Windows.Forms.TextBox();
            this.areaMuestrearTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confianzaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AreaTotalTxt = new System.Windows.Forms.TextBox();
            this.intMuestreoTxt = new System.Windows.Forms.TextBox();
            this.limiteInfTxt = new System.Windows.Forms.TextBox();
            this.numeroEtapasTxt = new System.Windows.Forms.TextBox();
            this.factorFormaTxt = new System.Windows.Forms.TextBox();
            this.areaFustalesTxt = new System.Windows.Forms.TextBox();
            this.tamParcelaTxt = new System.Windows.Forms.TextBox();
            this.lugarTxt = new System.Windows.Forms.TextBox();
            this.especiesTabP = new System.Windows.Forms.TabPage();
            this.registrarSpecieBtn = new System.Windows.Forms.Button();
            this.busquedaTxt = new System.Windows.Forms.TextBox();
            this.criterioCbx = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.seleccEspecieBtn = new System.Windows.Forms.Button();
            this.RemoverEspciesBtn = new System.Windows.Forms.Button();
            this.especiesDGW = new System.Windows.Forms.DataGridView();
            this.Especie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NOMCOMUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMCIENTIFICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especieBS = new System.Windows.Forms.BindingSource(this.components);
            this.estratosTabP = new System.Windows.Forms.TabPage();
            this.crearEstratoBtn = new System.Windows.Forms.Button();
            this.SeleccEstratosBtn = new System.Windows.Forms.Button();
            this.removerEstratosBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.estratoDGW = new System.Windows.Forms.DataGridView();
            this.Estratos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DESCRIPESTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estratoBS = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosContTabP = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.seleccionarProyectosBtn = new System.Windows.Forms.Button();
            this.removerProyectosBtn = new System.Windows.Forms.Button();
            this.proyectoDGW = new System.Windows.Forms.DataGridView();
            this.Proyectos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRETIPOINV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NOMTIPODISEMUEST = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PesoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoBS = new System.Windows.Forms.BindingSource(this.components);
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.controladorErrores = new System.Windows.Forms.ErrorProvider(this.components);
            descripcionLbl = new System.Windows.Forms.Label();
            facFormaLbl = new System.Windows.Forms.Label();
            areaFustalesLbl = new System.Windows.Forms.Label();
            tamanioParLbl = new System.Windows.Forms.Label();
            lugarLbl = new System.Windows.Forms.Label();
            TipoDisenoLbl = new System.Windows.Forms.Label();
            objetivoInvTxt = new System.Windows.Forms.Label();
            numeroEtapasLbl = new System.Windows.Forms.Label();
            valorMinimoDAPLbl = new System.Windows.Forms.Label();
            intensidadMuestreLbl = new System.Windows.Forms.Label();
            areaMuestreadaLbl = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            formulaLbl = new System.Windows.Forms.Label();
            expresionLbl = new System.Windows.Forms.Label();
            this.crearProyectoTab.SuspendLayout();
            this.proyectoTabP.SuspendLayout();
            this.DatosProyectoGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoProyectoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInventarioBS)).BeginInit();
            this.otrosDatosGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaBS)).BeginInit();
            this.especiesTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especiesDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBS)).BeginInit();
            this.estratosTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estratoDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBS)).BeginInit();
            this.proyectosContTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLbl
            // 
            descripcionLbl.AutoSize = true;
            descripcionLbl.Location = new System.Drawing.Point(11, 54);
            descripcionLbl.Name = "descripcionLbl";
            descripcionLbl.Size = new System.Drawing.Size(66, 13);
            descripcionLbl.TabIndex = 25;
            descripcionLbl.Text = "Descripción:";
            // 
            // facFormaLbl
            // 
            facFormaLbl.AutoSize = true;
            facFormaLbl.Location = new System.Drawing.Point(10, 201);
            facFormaLbl.Name = "facFormaLbl";
            facFormaLbl.Size = new System.Drawing.Size(84, 13);
            facFormaLbl.TabIndex = 10;
            facFormaLbl.Text = "Factor de forma:";
            // 
            // areaFustalesLbl
            // 
            areaFustalesLbl.AutoSize = true;
            areaFustalesLbl.Location = new System.Drawing.Point(10, 169);
            areaFustalesLbl.Name = "areaFustalesLbl";
            areaFustalesLbl.Size = new System.Drawing.Size(103, 26);
            areaFustalesLbl.TabIndex = 8;
            areaFustalesLbl.Text = "Area Parcela de \r\nregeneración (Htas):";
            // 
            // tamanioParLbl
            // 
            tamanioParLbl.AutoSize = true;
            tamanioParLbl.Location = new System.Drawing.Point(9, 42);
            tamanioParLbl.Name = "tamanioParLbl";
            tamanioParLbl.Size = new System.Drawing.Size(119, 13);
            tamanioParLbl.TabIndex = 6;
            tamanioParLbl.Text = "Tamaño Parcela (Htas):";
            // 
            // lugarLbl
            // 
            lugarLbl.AutoSize = true;
            lugarLbl.Location = new System.Drawing.Point(10, 26);
            lugarLbl.Name = "lugarLbl";
            lugarLbl.Size = new System.Drawing.Size(37, 13);
            lugarLbl.TabIndex = 4;
            lugarLbl.Text = "Lugar:";
            // 
            // TipoDisenoLbl
            // 
            TipoDisenoLbl.AutoSize = true;
            TipoDisenoLbl.Location = new System.Drawing.Point(9, 149);
            TipoDisenoLbl.Name = "TipoDisenoLbl";
            TipoDisenoLbl.Size = new System.Drawing.Size(128, 13);
            TipoDisenoLbl.TabIndex = 6;
            TipoDisenoLbl.Text = "Tipo de Diseño Muestral: ";
            // 
            // objetivoInvTxt
            // 
            objetivoInvTxt.AutoSize = true;
            objetivoInvTxt.Location = new System.Drawing.Point(10, 121);
            objetivoInvTxt.Name = "objetivoInvTxt";
            objetivoInvTxt.Size = new System.Drawing.Size(115, 13);
            objetivoInvTxt.TabIndex = 8;
            objetivoInvTxt.Text = "Objetivo del inventario:";
            // 
            // numeroEtapasLbl
            // 
            numeroEtapasLbl.AutoSize = true;
            numeroEtapasLbl.Location = new System.Drawing.Point(13, 278);
            numeroEtapasLbl.Name = "numeroEtapasLbl";
            numeroEtapasLbl.Size = new System.Drawing.Size(38, 13);
            numeroEtapasLbl.TabIndex = 12;
            numeroEtapasLbl.Text = "Etapa:";
            // 
            // valorMinimoDAPLbl
            // 
            valorMinimoDAPLbl.AutoSize = true;
            valorMinimoDAPLbl.Location = new System.Drawing.Point(10, 146);
            valorMinimoDAPLbl.Name = "valorMinimoDAPLbl";
            valorMinimoDAPLbl.Size = new System.Drawing.Size(117, 13);
            valorMinimoDAPLbl.TabIndex = 17;
            valorMinimoDAPLbl.Text = "Valor minimo DAP(Mts):";
            // 
            // intensidadMuestreLbl
            // 
            intensidadMuestreLbl.AutoSize = true;
            intensidadMuestreLbl.Location = new System.Drawing.Point(237, 121);
            intensidadMuestreLbl.Name = "intensidadMuestreLbl";
            intensidadMuestreLbl.Size = new System.Drawing.Size(164, 13);
            intensidadMuestreLbl.TabIndex = 25;
            intensidadMuestreLbl.Text = "Intensidad de muestreo (0-100)%:";
            // 
            // areaMuestreadaLbl
            // 
            areaMuestreadaLbl.AutoSize = true;
            areaMuestreadaLbl.Location = new System.Drawing.Point(9, 68);
            areaMuestreadaLbl.Name = "areaMuestreadaLbl";
            areaMuestreadaLbl.Size = new System.Drawing.Size(90, 13);
            areaMuestreadaLbl.TabIndex = 26;
            areaMuestreadaLbl.Text = "Area Total (Htas):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(131, 13);
            label4.TabIndex = 50;
            label4.Text = "Numero total de parcelas :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(237, 94);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(148, 13);
            label5.TabIndex = 52;
            label5.Text = "Numero parcelas a muestrear:";
            // 
            // formulaLbl
            // 
            formulaLbl.AutoSize = true;
            formulaLbl.Location = new System.Drawing.Point(10, 225);
            formulaLbl.Name = "formulaLbl";
            formulaLbl.Size = new System.Drawing.Size(105, 13);
            formulaLbl.TabIndex = 53;
            formulaLbl.Text = "Formula de volumen:";
            // 
            // expresionLbl
            // 
            expresionLbl.AutoSize = true;
            expresionLbl.Location = new System.Drawing.Point(10, 250);
            expresionLbl.Name = "expresionLbl";
            expresionLbl.Size = new System.Drawing.Size(119, 13);
            expresionLbl.TabIndex = 55;
            expresionLbl.Text = "Expresión de la formula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo de Proyecto: ";
            // 
            // crearProyectoTab
            // 
            this.crearProyectoTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.crearProyectoTab.Controls.Add(this.proyectoTabP);
            this.crearProyectoTab.Controls.Add(this.especiesTabP);
            this.crearProyectoTab.Controls.Add(this.estratosTabP);
            this.crearProyectoTab.Controls.Add(this.proyectosContTabP);
            this.crearProyectoTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.crearProyectoTab.ItemSize = new System.Drawing.Size(40, 120);
            this.crearProyectoTab.Location = new System.Drawing.Point(-3, -1);
            this.crearProyectoTab.Multiline = true;
            this.crearProyectoTab.Name = "crearProyectoTab";
            this.crearProyectoTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.crearProyectoTab.SelectedIndex = 0;
            this.crearProyectoTab.Size = new System.Drawing.Size(661, 530);
            this.crearProyectoTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.crearProyectoTab.TabIndex = 0;
            this.crearProyectoTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.crearProyectoTab_DrawItem);
            // 
            // proyectoTabP
            // 
            this.proyectoTabP.Controls.Add(this.DatosProyectoGbx);
            this.proyectoTabP.Location = new System.Drawing.Point(124, 4);
            this.proyectoTabP.Name = "proyectoTabP";
            this.proyectoTabP.Padding = new System.Windows.Forms.Padding(3);
            this.proyectoTabP.Size = new System.Drawing.Size(533, 522);
            this.proyectoTabP.TabIndex = 1;
            this.proyectoTabP.Text = "Datos del proyecto";
            this.proyectoTabP.UseVisualStyleBackColor = true;
            // 
            // DatosProyectoGbx
            // 
            this.DatosProyectoGbx.Controls.Add(this.TipoProyectoCbx);
            this.DatosProyectoGbx.Controls.Add(this.label1);
            this.DatosProyectoGbx.Controls.Add(this.DescripcionTxt);
            this.DatosProyectoGbx.Controls.Add(descripcionLbl);
            this.DatosProyectoGbx.Controls.Add(this.tipoDisenoCbx);
            this.DatosProyectoGbx.Controls.Add(this.tipoObjetivoCbx);
            this.DatosProyectoGbx.Controls.Add(this.otrosDatosGbx);
            this.DatosProyectoGbx.Controls.Add(lugarLbl);
            this.DatosProyectoGbx.Controls.Add(this.lugarTxt);
            this.DatosProyectoGbx.Controls.Add(TipoDisenoLbl);
            this.DatosProyectoGbx.Controls.Add(objetivoInvTxt);
            this.DatosProyectoGbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosProyectoGbx.Location = new System.Drawing.Point(3, 3);
            this.DatosProyectoGbx.Name = "DatosProyectoGbx";
            this.DatosProyectoGbx.Size = new System.Drawing.Size(527, 516);
            this.DatosProyectoGbx.TabIndex = 3;
            this.DatosProyectoGbx.TabStop = false;
            this.DatosProyectoGbx.Text = "Definición del proyecto";
            // 
            // TipoProyectoCbx
            // 
            this.TipoProyectoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoProyectoCbx.FormattingEnabled = true;
            this.TipoProyectoCbx.Items.AddRange(new object[] {
            "Independiente",
            "Contenedor"});
            this.TipoProyectoCbx.Location = new System.Drawing.Point(145, 174);
            this.TipoProyectoCbx.Name = "TipoProyectoCbx";
            this.TipoProyectoCbx.Size = new System.Drawing.Size(363, 21);
            this.TipoProyectoCbx.TabIndex = 4;
            this.TipoProyectoCbx.SelectedIndexChanged += new System.EventHandler(this.TipoProyectoCbx_SelectedIndexChanged);
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(145, 50);
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripcionTxt.Size = new System.Drawing.Size(363, 62);
            this.DescripcionTxt.TabIndex = 1;
            // 
            // tipoDisenoCbx
            // 
            this.tipoDisenoCbx.DataSource = this.tipoDisenoBS;
            this.tipoDisenoCbx.DisplayMember = "DESCRIPTIPODISEMUEST";
            this.tipoDisenoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDisenoCbx.FormattingEnabled = true;
            this.tipoDisenoCbx.Location = new System.Drawing.Point(145, 146);
            this.tipoDisenoCbx.Name = "tipoDisenoCbx";
            this.tipoDisenoCbx.Size = new System.Drawing.Size(363, 21);
            this.tipoDisenoCbx.TabIndex = 3;
            this.tipoDisenoCbx.ValueMember = "NOMTIPODISEMUEST";
            this.tipoDisenoCbx.SelectedIndexChanged += new System.EventHandler(this.tipoDisenoCbx_SelectedIndexChanged);
            // 
            // nuevoProyectoBS
            // 
            this.nuevoProyectoBS.DataSource = typeof(SIFCA_DAL.PROYECTO);
            // 
            // tipoDisenoBS
            // 
            this.tipoDisenoBS.DataSource = typeof(SIFCA_DAL.TIPODISENOMUESTRAL);
            // 
            // tipoObjetivoCbx
            // 
            this.tipoObjetivoCbx.DataSource = this.objetivoInventarioBS;
            this.tipoObjetivoCbx.DisplayMember = "DESCRIPOBJETINV";
            this.tipoObjetivoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoObjetivoCbx.FormattingEnabled = true;
            this.tipoObjetivoCbx.Location = new System.Drawing.Point(145, 118);
            this.tipoObjetivoCbx.Name = "tipoObjetivoCbx";
            this.tipoObjetivoCbx.Size = new System.Drawing.Size(363, 21);
            this.tipoObjetivoCbx.TabIndex = 2;
            this.tipoObjetivoCbx.ValueMember = "NOMBRETIPOINV";
            // 
            // objetivoInventarioBS
            // 
            this.objetivoInventarioBS.DataSource = typeof(SIFCA_DAL.OBJETIVOINVENTARIO);
            // 
            // otrosDatosGbx
            // 
            this.otrosDatosGbx.Controls.Add(expresionLbl);
            this.otrosDatosGbx.Controls.Add(this.expresionTxt);
            this.otrosDatosGbx.Controls.Add(this.formularComboBox);
            this.otrosDatosGbx.Controls.Add(formulaLbl);
            this.otrosDatosGbx.Controls.Add(label5);
            this.otrosDatosGbx.Controls.Add(this.numeroParcelasMuestraTxt);
            this.otrosDatosGbx.Controls.Add(label4);
            this.otrosDatosGbx.Controls.Add(this.numeroParcelasTxt);
            this.otrosDatosGbx.Controls.Add(this.areaMuestrearTxt);
            this.otrosDatosGbx.Controls.Add(this.label3);
            this.otrosDatosGbx.Controls.Add(this.confianzaTextBox);
            this.otrosDatosGbx.Controls.Add(this.label2);
            this.otrosDatosGbx.Controls.Add(areaMuestreadaLbl);
            this.otrosDatosGbx.Controls.Add(this.AreaTotalTxt);
            this.otrosDatosGbx.Controls.Add(intensidadMuestreLbl);
            this.otrosDatosGbx.Controls.Add(this.intMuestreoTxt);
            this.otrosDatosGbx.Controls.Add(valorMinimoDAPLbl);
            this.otrosDatosGbx.Controls.Add(this.limiteInfTxt);
            this.otrosDatosGbx.Controls.Add(numeroEtapasLbl);
            this.otrosDatosGbx.Controls.Add(this.numeroEtapasTxt);
            this.otrosDatosGbx.Controls.Add(facFormaLbl);
            this.otrosDatosGbx.Controls.Add(this.factorFormaTxt);
            this.otrosDatosGbx.Controls.Add(areaFustalesLbl);
            this.otrosDatosGbx.Controls.Add(this.areaFustalesTxt);
            this.otrosDatosGbx.Controls.Add(tamanioParLbl);
            this.otrosDatosGbx.Controls.Add(this.tamParcelaTxt);
            this.otrosDatosGbx.Location = new System.Drawing.Point(6, 201);
            this.otrosDatosGbx.Name = "otrosDatosGbx";
            this.otrosDatosGbx.Size = new System.Drawing.Size(515, 308);
            this.otrosDatosGbx.TabIndex = 22;
            this.otrosDatosGbx.TabStop = false;
            // 
            // expresionTxt
            // 
            this.expresionTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formulaBS, "EXPRESION", true));
            this.expresionTxt.Location = new System.Drawing.Point(159, 250);
            this.expresionTxt.MaxLength = 18;
            this.expresionTxt.Name = "expresionTxt";
            this.expresionTxt.ReadOnly = true;
            this.expresionTxt.Size = new System.Drawing.Size(327, 20);
            this.expresionTxt.TabIndex = 54;
            // 
            // formulaBS
            // 
            this.formulaBS.DataSource = typeof(SIFCA_DAL.FORMULA);
            // 
            // formularComboBox
            // 
            this.formularComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nuevoProyectoBS, "NROFORMULA", true));
            this.formularComboBox.DataSource = this.formulaBS;
            this.formularComboBox.DisplayMember = "NOMBRE";
            this.formularComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formularComboBox.FormattingEnabled = true;
            this.formularComboBox.Location = new System.Drawing.Point(159, 224);
            this.formularComboBox.Name = "formularComboBox";
            this.formularComboBox.Size = new System.Drawing.Size(326, 21);
            this.formularComboBox.TabIndex = 53;
            this.formularComboBox.ValueMember = "NROFORMULA";
            // 
            // numeroParcelasMuestraTxt
            // 
            this.numeroParcelasMuestraTxt.Location = new System.Drawing.Point(407, 92);
            this.numeroParcelasMuestraTxt.MaxLength = 25;
            this.numeroParcelasMuestraTxt.Name = "numeroParcelasMuestraTxt";
            this.numeroParcelasMuestraTxt.Size = new System.Drawing.Size(78, 20);
            this.numeroParcelasMuestraTxt.TabIndex = 51;
            this.numeroParcelasMuestraTxt.Text = "0";
            this.numeroParcelasMuestraTxt.TextChanged += new System.EventHandler(this.numeroParcelasMuestraTxt_TextChanged);
            // 
            // numeroParcelasTxt
            // 
            this.numeroParcelasTxt.Location = new System.Drawing.Point(159, 91);
            this.numeroParcelasTxt.MaxLength = 25;
            this.numeroParcelasTxt.Name = "numeroParcelasTxt";
            this.numeroParcelasTxt.ReadOnly = true;
            this.numeroParcelasTxt.Size = new System.Drawing.Size(73, 20);
            this.numeroParcelasTxt.TabIndex = 49;
            this.numeroParcelasTxt.Text = "0";
            // 
            // areaMuestrearTxt
            // 
            this.areaMuestrearTxt.Location = new System.Drawing.Point(159, 117);
            this.areaMuestrearTxt.MaxLength = 25;
            this.areaMuestrearTxt.Name = "areaMuestrearTxt";
            this.areaMuestrearTxt.ReadOnly = true;
            this.areaMuestrearTxt.Size = new System.Drawing.Size(73, 20);
            this.areaMuestrearTxt.TabIndex = 3;
            this.areaMuestrearTxt.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Area a Muestrear (Htas):";
            // 
            // confianzaTextBox
            // 
            this.confianzaTextBox.Location = new System.Drawing.Point(159, 14);
            this.confianzaTextBox.MaxLength = 25;
            this.confianzaTextBox.Name = "confianzaTextBox";
            this.confianzaTextBox.Size = new System.Drawing.Size(327, 20);
            this.confianzaTextBox.TabIndex = 0;
            this.confianzaTextBox.Text = "95";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "% Confianza:";
            // 
            // AreaTotalTxt
            // 
            this.AreaTotalTxt.Location = new System.Drawing.Point(159, 65);
            this.AreaTotalTxt.MaxLength = 25;
            this.AreaTotalTxt.Name = "AreaTotalTxt";
            this.AreaTotalTxt.Size = new System.Drawing.Size(327, 20);
            this.AreaTotalTxt.TabIndex = 1;
            this.AreaTotalTxt.Text = "0";
            this.AreaTotalTxt.TextChanged += new System.EventHandler(this.AreaTotalTxt_TextChanged);
            // 
            // intMuestreoTxt
            // 
            this.intMuestreoTxt.Location = new System.Drawing.Point(407, 118);
            this.intMuestreoTxt.MaxLength = 25;
            this.intMuestreoTxt.Name = "intMuestreoTxt";
            this.intMuestreoTxt.ReadOnly = true;
            this.intMuestreoTxt.Size = new System.Drawing.Size(79, 20);
            this.intMuestreoTxt.TabIndex = 2;
            this.intMuestreoTxt.Text = "0";
            // 
            // limiteInfTxt
            // 
            this.limiteInfTxt.Location = new System.Drawing.Point(159, 144);
            this.limiteInfTxt.MaxLength = 25;
            this.limiteInfTxt.Name = "limiteInfTxt";
            this.limiteInfTxt.Size = new System.Drawing.Size(327, 20);
            this.limiteInfTxt.TabIndex = 5;
            this.limiteInfTxt.Text = "0.1";
            // 
            // numeroEtapasTxt
            // 
            this.numeroEtapasTxt.Enabled = false;
            this.numeroEtapasTxt.Location = new System.Drawing.Point(159, 277);
            this.numeroEtapasTxt.MaxLength = 18;
            this.numeroEtapasTxt.Name = "numeroEtapasTxt";
            this.numeroEtapasTxt.Size = new System.Drawing.Size(327, 20);
            this.numeroEtapasTxt.TabIndex = 8;
            this.numeroEtapasTxt.Text = "0";
            // 
            // factorFormaTxt
            // 
            this.factorFormaTxt.Location = new System.Drawing.Point(159, 198);
            this.factorFormaTxt.MaxLength = 25;
            this.factorFormaTxt.Name = "factorFormaTxt";
            this.factorFormaTxt.Size = new System.Drawing.Size(327, 20);
            this.factorFormaTxt.TabIndex = 7;
            this.factorFormaTxt.Text = "1";
            // 
            // areaFustalesTxt
            // 
            this.areaFustalesTxt.Location = new System.Drawing.Point(159, 170);
            this.areaFustalesTxt.MaxLength = 25;
            this.areaFustalesTxt.Name = "areaFustalesTxt";
            this.areaFustalesTxt.Size = new System.Drawing.Size(327, 20);
            this.areaFustalesTxt.TabIndex = 6;
            this.areaFustalesTxt.Text = "1.000";
            // 
            // tamParcelaTxt
            // 
            this.tamParcelaTxt.Location = new System.Drawing.Point(159, 40);
            this.tamParcelaTxt.MaxLength = 25;
            this.tamParcelaTxt.Name = "tamParcelaTxt";
            this.tamParcelaTxt.Size = new System.Drawing.Size(327, 20);
            this.tamParcelaTxt.TabIndex = 4;
            this.tamParcelaTxt.Text = "0";
            this.tamParcelaTxt.TextChanged += new System.EventHandler(this.tamParcelaTxt_TextChanged);
            // 
            // lugarTxt
            // 
            this.lugarTxt.Location = new System.Drawing.Point(145, 23);
            this.lugarTxt.MaxLength = 100;
            this.lugarTxt.Name = "lugarTxt";
            this.lugarTxt.Size = new System.Drawing.Size(363, 20);
            this.lugarTxt.TabIndex = 0;
            // 
            // especiesTabP
            // 
            this.especiesTabP.Controls.Add(this.registrarSpecieBtn);
            this.especiesTabP.Controls.Add(this.busquedaTxt);
            this.especiesTabP.Controls.Add(this.criterioCbx);
            this.especiesTabP.Controls.Add(this.lblBuscar);
            this.especiesTabP.Controls.Add(this.seleccEspecieBtn);
            this.especiesTabP.Controls.Add(this.RemoverEspciesBtn);
            this.especiesTabP.Controls.Add(this.especiesDGW);
            this.especiesTabP.Location = new System.Drawing.Point(124, 4);
            this.especiesTabP.Name = "especiesTabP";
            this.especiesTabP.Padding = new System.Windows.Forms.Padding(3);
            this.especiesTabP.Size = new System.Drawing.Size(533, 522);
            this.especiesTabP.TabIndex = 2;
            this.especiesTabP.Text = "Listado de Especies";
            this.especiesTabP.UseVisualStyleBackColor = true;
            // 
            // registrarSpecieBtn
            // 
            this.registrarSpecieBtn.Image = global::SIFCA.Properties.Resources._1395994350_tree;
            this.registrarSpecieBtn.Location = new System.Drawing.Point(284, 10);
            this.registrarSpecieBtn.Name = "registrarSpecieBtn";
            this.registrarSpecieBtn.Size = new System.Drawing.Size(26, 23);
            this.registrarSpecieBtn.TabIndex = 24;
            this.registrarSpecieBtn.UseVisualStyleBackColor = true;
            this.registrarSpecieBtn.Click += new System.EventHandler(this.registrarSpecieBtn_Click);
            // 
            // busquedaTxt
            // 
            this.busquedaTxt.Location = new System.Drawing.Point(49, 11);
            this.busquedaTxt.Name = "busquedaTxt";
            this.busquedaTxt.Size = new System.Drawing.Size(127, 20);
            this.busquedaTxt.TabIndex = 23;
            this.busquedaTxt.TextChanged += new System.EventHandler(this.buscarTxt_TextChanged);
            // 
            // criterioCbx
            // 
            this.criterioCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterioCbx.FormattingEnabled = true;
            this.criterioCbx.Items.AddRange(new object[] {
            "Nombre Comun",
            "Nombre Cientifico"});
            this.criterioCbx.Location = new System.Drawing.Point(179, 11);
            this.criterioCbx.Name = "criterioCbx";
            this.criterioCbx.Size = new System.Drawing.Size(101, 21);
            this.criterioCbx.TabIndex = 22;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(5, 14);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.Text = "Buscar:";
            // 
            // seleccEspecieBtn
            // 
            this.seleccEspecieBtn.Location = new System.Drawing.Point(312, 10);
            this.seleccEspecieBtn.Name = "seleccEspecieBtn";
            this.seleccEspecieBtn.Size = new System.Drawing.Size(111, 23);
            this.seleccEspecieBtn.TabIndex = 17;
            this.seleccEspecieBtn.Text = "Seleccionar Todos";
            this.seleccEspecieBtn.UseVisualStyleBackColor = true;
            this.seleccEspecieBtn.Click += new System.EventHandler(this.seleccEspecieBtn_Click);
            // 
            // RemoverEspciesBtn
            // 
            this.RemoverEspciesBtn.Location = new System.Drawing.Point(426, 10);
            this.RemoverEspciesBtn.Name = "RemoverEspciesBtn";
            this.RemoverEspciesBtn.Size = new System.Drawing.Size(98, 23);
            this.RemoverEspciesBtn.TabIndex = 18;
            this.RemoverEspciesBtn.Text = "Remover Todos";
            this.RemoverEspciesBtn.UseVisualStyleBackColor = true;
            this.RemoverEspciesBtn.Click += new System.EventHandler(this.RemoverEspciesBtn_Click);
            // 
            // especiesDGW
            // 
            this.especiesDGW.AllowUserToAddRows = false;
            this.especiesDGW.AllowUserToDeleteRows = false;
            this.especiesDGW.AutoGenerateColumns = false;
            this.especiesDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.especiesDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especiesDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Especie,
            this.NOMCOMUN,
            this.NOMCIENTIFICO,
            this.FAMILIA});
            this.especiesDGW.DataSource = this.especieBS;
            this.especiesDGW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.especiesDGW.Location = new System.Drawing.Point(3, 39);
            this.especiesDGW.Name = "especiesDGW";
            this.especiesDGW.Size = new System.Drawing.Size(527, 480);
            this.especiesDGW.TabIndex = 19;
            this.especiesDGW.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.especiesDGW_CellValueChanged);
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Seleccion";
            this.Especie.Name = "Especie";
            // 
            // NOMCOMUN
            // 
            this.NOMCOMUN.DataPropertyName = "NOMCOMUN";
            this.NOMCOMUN.HeaderText = "Nombre Comun";
            this.NOMCOMUN.Name = "NOMCOMUN";
            this.NOMCOMUN.ReadOnly = true;
            // 
            // NOMCIENTIFICO
            // 
            this.NOMCIENTIFICO.DataPropertyName = "NOMCIENTIFICO";
            this.NOMCIENTIFICO.HeaderText = "Nombre Cientifico";
            this.NOMCIENTIFICO.Name = "NOMCIENTIFICO";
            this.NOMCIENTIFICO.ReadOnly = true;
            // 
            // FAMILIA
            // 
            this.FAMILIA.DataPropertyName = "FAMILIA";
            this.FAMILIA.HeaderText = "Familia";
            this.FAMILIA.Name = "FAMILIA";
            this.FAMILIA.ReadOnly = true;
            // 
            // especieBS
            // 
            this.especieBS.DataSource = typeof(SIFCA_DAL.ESPECIE);
            // 
            // estratosTabP
            // 
            this.estratosTabP.Controls.Add(this.crearEstratoBtn);
            this.estratosTabP.Controls.Add(this.SeleccEstratosBtn);
            this.estratosTabP.Controls.Add(this.removerEstratosBtn);
            this.estratosTabP.Controls.Add(this.actualizarBtn);
            this.estratosTabP.Controls.Add(this.errorLbl);
            this.estratosTabP.Controls.Add(this.estratoDGW);
            this.estratosTabP.Location = new System.Drawing.Point(124, 4);
            this.estratosTabP.Name = "estratosTabP";
            this.estratosTabP.Padding = new System.Windows.Forms.Padding(3);
            this.estratosTabP.Size = new System.Drawing.Size(533, 522);
            this.estratosTabP.TabIndex = 3;
            this.estratosTabP.Text = "Listado de Estratos";
            this.estratosTabP.UseVisualStyleBackColor = true;
            // 
            // crearEstratoBtn
            // 
            this.crearEstratoBtn.Enabled = false;
            this.crearEstratoBtn.Location = new System.Drawing.Point(180, 10);
            this.crearEstratoBtn.Name = "crearEstratoBtn";
            this.crearEstratoBtn.Size = new System.Drawing.Size(104, 23);
            this.crearEstratoBtn.TabIndex = 24;
            this.crearEstratoBtn.Text = "Crear estrato";
            this.crearEstratoBtn.UseVisualStyleBackColor = true;
            this.crearEstratoBtn.Click += new System.EventHandler(this.crearEstratoBtn_Click);
            // 
            // SeleccEstratosBtn
            // 
            this.SeleccEstratosBtn.Enabled = false;
            this.SeleccEstratosBtn.Location = new System.Drawing.Point(290, 10);
            this.SeleccEstratosBtn.Name = "SeleccEstratosBtn";
            this.SeleccEstratosBtn.Size = new System.Drawing.Size(104, 23);
            this.SeleccEstratosBtn.TabIndex = 20;
            this.SeleccEstratosBtn.Text = "Seleccionar Todos";
            this.SeleccEstratosBtn.UseVisualStyleBackColor = true;
            this.SeleccEstratosBtn.Click += new System.EventHandler(this.SeleccEstratosBtn_Click);
            // 
            // removerEstratosBtn
            // 
            this.removerEstratosBtn.Enabled = false;
            this.removerEstratosBtn.Location = new System.Drawing.Point(396, 10);
            this.removerEstratosBtn.Name = "removerEstratosBtn";
            this.removerEstratosBtn.Size = new System.Drawing.Size(102, 23);
            this.removerEstratosBtn.TabIndex = 21;
            this.removerEstratosBtn.Text = "Remover Todos";
            this.removerEstratosBtn.UseVisualStyleBackColor = true;
            this.removerEstratosBtn.Click += new System.EventHandler(this.removerEstratosBtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actualizarBtn.BackgroundImage")));
            this.actualizarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actualizarBtn.Enabled = false;
            this.actualizarBtn.Location = new System.Drawing.Point(503, 10);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(23, 23);
            this.actualizarBtn.TabIndex = 22;
            this.actualizarBtn.UseVisualStyleBackColor = true;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(12, 39);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 19;
            // 
            // estratoDGW
            // 
            this.estratoDGW.AllowUserToAddRows = false;
            this.estratoDGW.AllowUserToDeleteRows = false;
            this.estratoDGW.AutoGenerateColumns = false;
            this.estratoDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.estratoDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estratoDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estratos,
            this.DESCRIPESTRATO,
            this.Tamanio,
            this.Peso});
            this.estratoDGW.DataSource = this.estratoBS;
            this.estratoDGW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.estratoDGW.Enabled = false;
            this.estratoDGW.Location = new System.Drawing.Point(3, 72);
            this.estratoDGW.Name = "estratoDGW";
            this.estratoDGW.Size = new System.Drawing.Size(527, 447);
            this.estratoDGW.TabIndex = 23;
            this.estratoDGW.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.estratoDGW_CellValueChanged);
            this.estratoDGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.estratoDGW_DataBindingComplete);
            // 
            // Estratos
            // 
            this.Estratos.HeaderText = "Estratos";
            this.Estratos.Name = "Estratos";
            // 
            // DESCRIPESTRATO
            // 
            this.DESCRIPESTRATO.DataPropertyName = "DESCRIPESTRATO";
            this.DESCRIPESTRATO.HeaderText = "Descripcion";
            this.DESCRIPESTRATO.Name = "DESCRIPESTRATO";
            this.DESCRIPESTRATO.ReadOnly = true;
            // 
            // Tamanio
            // 
            this.Tamanio.HeaderText = "Tamaño muestral";
            this.Tamanio.Name = "Tamanio";
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.MaxInputLength = 25;
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // estratoBS
            // 
            this.estratoBS.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // proyectosContTabP
            // 
            this.proyectosContTabP.AutoScroll = true;
            this.proyectosContTabP.Controls.Add(this.button1);
            this.proyectosContTabP.Controls.Add(this.seleccionarProyectosBtn);
            this.proyectosContTabP.Controls.Add(this.removerProyectosBtn);
            this.proyectosContTabP.Controls.Add(this.proyectoDGW);
            this.proyectosContTabP.Location = new System.Drawing.Point(124, 4);
            this.proyectosContTabP.Name = "proyectosContTabP";
            this.proyectosContTabP.Size = new System.Drawing.Size(533, 522);
            this.proyectosContTabP.TabIndex = 4;
            this.proyectosContTabP.Text = "Proyectos contenidos";
            this.proyectosContTabP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(500, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.actualizarPesoProyectosEtapasBtn_Click);
            // 
            // seleccionarProyectosBtn
            // 
            this.seleccionarProyectosBtn.Enabled = false;
            this.seleccionarProyectosBtn.Location = new System.Drawing.Point(270, 9);
            this.seleccionarProyectosBtn.Name = "seleccionarProyectosBtn";
            this.seleccionarProyectosBtn.Size = new System.Drawing.Size(112, 23);
            this.seleccionarProyectosBtn.TabIndex = 23;
            this.seleccionarProyectosBtn.Text = "Seleccionar Todos";
            this.seleccionarProyectosBtn.UseVisualStyleBackColor = true;
            this.seleccionarProyectosBtn.Click += new System.EventHandler(this.seleccionarProyectosBtn_Click);
            // 
            // removerProyectosBtn
            // 
            this.removerProyectosBtn.Enabled = false;
            this.removerProyectosBtn.Location = new System.Drawing.Point(390, 9);
            this.removerProyectosBtn.Name = "removerProyectosBtn";
            this.removerProyectosBtn.Size = new System.Drawing.Size(104, 23);
            this.removerProyectosBtn.TabIndex = 24;
            this.removerProyectosBtn.Text = "Remover Todos";
            this.removerProyectosBtn.UseVisualStyleBackColor = true;
            this.removerProyectosBtn.Click += new System.EventHandler(this.removerProyectosBtn_Click);
            // 
            // proyectoDGW
            // 
            this.proyectoDGW.AllowUserToAddRows = false;
            this.proyectoDGW.AllowUserToDeleteRows = false;
            this.proyectoDGW.AllowUserToOrderColumns = true;
            this.proyectoDGW.AutoGenerateColumns = false;
            this.proyectoDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proyectoDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proyectoDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proyectos,
            this.Codigo,
            this.LUGAR,
            this.FECHA,
            this.NOMBRETIPOINV,
            this.NOMTIPODISEMUEST,
            this.PesoProyecto,
            this.ETAPA});
            this.proyectoDGW.DataSource = this.proyectoBS;
            this.proyectoDGW.Enabled = false;
            this.proyectoDGW.Location = new System.Drawing.Point(0, 38);
            this.proyectoDGW.Name = "proyectoDGW";
            this.proyectoDGW.Size = new System.Drawing.Size(533, 436);
            this.proyectoDGW.TabIndex = 25;
            this.proyectoDGW.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.proyectoDGW_CellValueChanged);
            // 
            // Proyectos
            // 
            this.Proyectos.HeaderText = "Seleccion";
            this.Proyectos.Name = "Proyectos";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "NROPROY";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // LUGAR
            // 
            this.LUGAR.DataPropertyName = "LUGAR";
            this.LUGAR.HeaderText = "Lugar";
            this.LUGAR.Name = "LUGAR";
            this.LUGAR.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "Fecha";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // NOMBRETIPOINV
            // 
            this.NOMBRETIPOINV.DataPropertyName = "NOMBRETIPOINV";
            this.NOMBRETIPOINV.DataSource = this.objetivoInventarioBS;
            this.NOMBRETIPOINV.DisplayMember = "DESCRIPOBJETINV";
            this.NOMBRETIPOINV.HeaderText = "Objetivo";
            this.NOMBRETIPOINV.Name = "NOMBRETIPOINV";
            this.NOMBRETIPOINV.ReadOnly = true;
            this.NOMBRETIPOINV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMBRETIPOINV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NOMBRETIPOINV.ValueMember = "NOMBRETIPOINV";
            // 
            // NOMTIPODISEMUEST
            // 
            this.NOMTIPODISEMUEST.DataPropertyName = "NOMTIPODISEMUEST";
            this.NOMTIPODISEMUEST.DataSource = this.tipoDisenoBS;
            this.NOMTIPODISEMUEST.DisplayMember = "DESCRIPTIPODISEMUEST";
            this.NOMTIPODISEMUEST.HeaderText = "Tipo Diseño";
            this.NOMTIPODISEMUEST.Name = "NOMTIPODISEMUEST";
            this.NOMTIPODISEMUEST.ReadOnly = true;
            this.NOMTIPODISEMUEST.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMTIPODISEMUEST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NOMTIPODISEMUEST.ValueMember = "NOMTIPODISEMUEST";
            // 
            // PesoProyecto
            // 
            this.PesoProyecto.HeaderText = "Peso";
            this.PesoProyecto.Name = "PesoProyecto";
            // 
            // ETAPA
            // 
            this.ETAPA.DataPropertyName = "ETAPA";
            this.ETAPA.HeaderText = "Etapa";
            this.ETAPA.Name = "ETAPA";
            this.ETAPA.ReadOnly = true;
            // 
            // proyectoBS
            // 
            this.proyectoBS.DataSource = typeof(SIFCA_DAL.PROYECTO);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(579, 536);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 1;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(497, 536);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 0;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // controladorErrores
            // 
            this.controladorErrores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.controladorErrores.ContainerControl = this;
            // 
            // Crear_Proyecto_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIFCA.Properties.Resources.fondo_tab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 565);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.crearProyectoTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Crear_Proyecto_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear proyecto";
            this.crearProyectoTab.ResumeLayout(false);
            this.proyectoTabP.ResumeLayout(false);
            this.DatosProyectoGbx.ResumeLayout(false);
            this.DatosProyectoGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoProyectoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInventarioBS)).EndInit();
            this.otrosDatosGbx.ResumeLayout(false);
            this.otrosDatosGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaBS)).EndInit();
            this.especiesTabP.ResumeLayout(false);
            this.especiesTabP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especiesDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBS)).EndInit();
            this.estratosTabP.ResumeLayout(false);
            this.estratosTabP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estratoDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBS)).EndInit();
            this.proyectosContTabP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl crearProyectoTab;
        private System.Windows.Forms.TabPage proyectoTabP;
        private System.Windows.Forms.GroupBox DatosProyectoGbx;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.ComboBox tipoDisenoCbx;
        private System.Windows.Forms.ComboBox tipoObjetivoCbx;
        private System.Windows.Forms.TextBox limiteInfTxt;
        private System.Windows.Forms.GroupBox otrosDatosGbx;
        private System.Windows.Forms.TextBox factorFormaTxt;
        private System.Windows.Forms.TextBox areaFustalesTxt;
        private System.Windows.Forms.TextBox tamParcelaTxt;
        private System.Windows.Forms.TextBox intMuestreoTxt;
        private System.Windows.Forms.TextBox AreaTotalTxt;
        private System.Windows.Forms.TextBox lugarTxt;
        private System.Windows.Forms.TabPage especiesTabP;
        private System.Windows.Forms.TabPage estratosTabP;
        private System.Windows.Forms.BindingSource tipoDisenoBS;
        private System.Windows.Forms.BindingSource objetivoInventarioBS;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.BindingSource especieBS;
        private System.Windows.Forms.DataGridView estratoDGW;
        private System.Windows.Forms.BindingSource estratoBS;
        private System.Windows.Forms.DataGridView especiesDGW;
        private System.Windows.Forms.Button seleccEspecieBtn;
        private System.Windows.Forms.Button RemoverEspciesBtn;
        private System.Windows.Forms.ComboBox TipoProyectoCbx;
        private System.Windows.Forms.TabPage proyectosContTabP;
        private System.Windows.Forms.Button seleccionarProyectosBtn;
        private System.Windows.Forms.Button removerProyectosBtn;
        private System.Windows.Forms.DataGridView proyectoDGW;
        private System.Windows.Forms.BindingSource proyectoBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroEtapasTxt;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button SeleccEstratosBtn;
        private System.Windows.Forms.Button removerEstratosBtn;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.ErrorProvider controladorErrores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMCOMUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMCIENTIFICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confianzaTextBox;
        private System.Windows.Forms.TextBox areaMuestrearTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox busquedaTxt;
        private System.Windows.Forms.ComboBox criterioCbx;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button registrarSpecieBtn;
        private System.Windows.Forms.Button crearEstratoBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPESTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.TextBox numeroParcelasMuestraTxt;
        private System.Windows.Forms.TextBox numeroParcelasTxt;
        private System.Windows.Forms.TextBox expresionTxt;
        private System.Windows.Forms.ComboBox formularComboBox;
        private System.Windows.Forms.BindingSource formulaBS;
        private System.Windows.Forms.BindingSource nuevoProyectoBS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Proyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOMBRETIPOINV;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOMTIPODISEMUEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAPA;


    }
}