namespace SIFCA
{
    partial class Actualizar_Proyectos_Form
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
            System.Windows.Forms.Label lugarLbl;
            System.Windows.Forms.Label TipoDisenoLbl;
            System.Windows.Forms.Label objetivoInvTxt;
            System.Windows.Forms.Label areaMuestreadaLbl;
            System.Windows.Forms.Label intensidadMuestreLbl;
            System.Windows.Forms.Label porcentajeLbl;
            System.Windows.Forms.Label valorMinimoDAPLbl;
            System.Windows.Forms.Label numeroEtapasLbl;
            System.Windows.Forms.Label facFormaLbl;
            System.Windows.Forms.Label areaFustalesLbl;
            System.Windows.Forms.Label tamanioParLbl;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Proyectos_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crearProyectoTab = new System.Windows.Forms.TabControl();
            this.proyectoTabP = new System.Windows.Forms.TabPage();
            this.DatosProyectoGbx = new System.Windows.Forms.GroupBox();
            this.otrosDatosGbx = new System.Windows.Forms.GroupBox();
            this.areaMuestrearTxt = new System.Windows.Forms.TextBox();
            this.proyectoBS = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.confianzaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AreaTotalTxt = new System.Windows.Forms.TextBox();
            this.intMuestreoTxt = new System.Windows.Forms.TextBox();
            this.limiteInfTxt = new System.Windows.Forms.TextBox();
            this.numeroEtapasTxt = new System.Windows.Forms.TextBox();
            this.proyectosBS = new System.Windows.Forms.BindingSource(this.components);
            this.factorFormaTxt = new System.Windows.Forms.TextBox();
            this.areaFustalesTxt = new System.Windows.Forms.TextBox();
            this.tamParcelaTxt = new System.Windows.Forms.TextBox();
            this.TipoProyectoCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.tipoDisenoCbx = new System.Windows.Forms.ComboBox();
            this.tipoDisenoBS = new System.Windows.Forms.BindingSource(this.components);
            this.tipoObjetivoCbx = new System.Windows.Forms.ComboBox();
            this.objetivoInventarioBS = new System.Windows.Forms.BindingSource(this.components);
            this.lugarTxt = new System.Windows.Forms.TextBox();
            this.especiesTabP = new System.Windows.Forms.TabPage();
            this.especiesDGW = new System.Windows.Forms.DataGridView();
            this.Especie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NOMCOMUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMCIENTIFICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especieBS = new System.Windows.Forms.BindingSource(this.components);
            this.seleccEspecieBtn = new System.Windows.Forms.Button();
            this.RemoverEspciesBtn = new System.Windows.Forms.Button();
            this.estratosTabP = new System.Windows.Forms.TabPage();
            this.errorLbl = new System.Windows.Forms.Label();
            this.actualizarPesosEstratosBtn = new System.Windows.Forms.Button();
            this.SeleccEstratosBtn = new System.Windows.Forms.Button();
            this.removerEstratosBtn = new System.Windows.Forms.Button();
            this.estratoDGW = new System.Windows.Forms.DataGridView();
            this.Estratos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DESCRIPESTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estratoBS = new System.Windows.Forms.BindingSource(this.components);
            this.formulariosTap = new System.Windows.Forms.TabPage();
            this.crearFormBtn = new System.Windows.Forms.Button();
            this.formulariosDGW = new System.Windows.Forms.DataGridView();
            this.FECHACREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROFORMULARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEST = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PARCELA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListarDatos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.formulariosBS = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosContTabP = new System.Windows.Forms.TabPage();
            this.arbolEtapasBtn = new System.Windows.Forms.Button();
            this.proyectoDGW = new System.Windows.Forms.DataGridView();
            this.Proyectos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRETIPOINV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NOMTIPODISEMUEST = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PesoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionarProyectosBtn = new System.Windows.Forms.Button();
            this.removerProyectosBtn = new System.Windows.Forms.Button();
            this.usuarioBS = new System.Windows.Forms.BindingSource(this.components);
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.ActualizarBtn = new System.Windows.Forms.Button();
            this.controladorErrores = new System.Windows.Forms.ErrorProvider(this.components);
            descripcionLbl = new System.Windows.Forms.Label();
            lugarLbl = new System.Windows.Forms.Label();
            TipoDisenoLbl = new System.Windows.Forms.Label();
            objetivoInvTxt = new System.Windows.Forms.Label();
            areaMuestreadaLbl = new System.Windows.Forms.Label();
            intensidadMuestreLbl = new System.Windows.Forms.Label();
            porcentajeLbl = new System.Windows.Forms.Label();
            valorMinimoDAPLbl = new System.Windows.Forms.Label();
            numeroEtapasLbl = new System.Windows.Forms.Label();
            facFormaLbl = new System.Windows.Forms.Label();
            areaFustalesLbl = new System.Windows.Forms.Label();
            tamanioParLbl = new System.Windows.Forms.Label();
            this.crearProyectoTab.SuspendLayout();
            this.proyectoTabP.SuspendLayout();
            this.DatosProyectoGbx.SuspendLayout();
            this.otrosDatosGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInventarioBS)).BeginInit();
            this.especiesTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especiesDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBS)).BeginInit();
            this.estratosTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estratoDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBS)).BeginInit();
            this.formulariosTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulariosDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulariosBS)).BeginInit();
            this.proyectosContTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBS)).BeginInit();
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
            descripcionLbl.Text = "Descripcion:";
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
            // areaMuestreadaLbl
            // 
            areaMuestreadaLbl.AutoSize = true;
            areaMuestreadaLbl.Location = new System.Drawing.Point(13, 42);
            areaMuestreadaLbl.Name = "areaMuestreadaLbl";
            areaMuestreadaLbl.Size = new System.Drawing.Size(90, 13);
            areaMuestreadaLbl.TabIndex = 43;
            areaMuestreadaLbl.Text = "Area Total (Htas):";
            // 
            // intensidadMuestreLbl
            // 
            intensidadMuestreLbl.AutoSize = true;
            intensidadMuestreLbl.Location = new System.Drawing.Point(13, 68);
            intensidadMuestreLbl.Name = "intensidadMuestreLbl";
            intensidadMuestreLbl.Size = new System.Drawing.Size(164, 13);
            intensidadMuestreLbl.TabIndex = 42;
            intensidadMuestreLbl.Text = "Intensidad de muestreo (1-100)%:";
            // 
            // porcentajeLbl
            // 
            porcentajeLbl.AutoSize = true;
            porcentajeLbl.Location = new System.Drawing.Point(246, 68);
            porcentajeLbl.Name = "porcentajeLbl";
            porcentajeLbl.Size = new System.Drawing.Size(15, 13);
            porcentajeLbl.TabIndex = 41;
            porcentajeLbl.Text = "%";
            // 
            // valorMinimoDAPLbl
            // 
            valorMinimoDAPLbl.AutoSize = true;
            valorMinimoDAPLbl.Location = new System.Drawing.Point(14, 119);
            valorMinimoDAPLbl.Name = "valorMinimoDAPLbl";
            valorMinimoDAPLbl.Size = new System.Drawing.Size(117, 13);
            valorMinimoDAPLbl.TabIndex = 40;
            valorMinimoDAPLbl.Text = "Valor minimo DAP(Mts):";
            // 
            // numeroEtapasLbl
            // 
            numeroEtapasLbl.AutoSize = true;
            numeroEtapasLbl.Location = new System.Drawing.Point(14, 199);
            numeroEtapasLbl.Name = "numeroEtapasLbl";
            numeroEtapasLbl.Size = new System.Drawing.Size(38, 13);
            numeroEtapasLbl.TabIndex = 34;
            numeroEtapasLbl.Text = "Etapa:";
            // 
            // facFormaLbl
            // 
            facFormaLbl.AutoSize = true;
            facFormaLbl.Location = new System.Drawing.Point(14, 174);
            facFormaLbl.Name = "facFormaLbl";
            facFormaLbl.Size = new System.Drawing.Size(84, 13);
            facFormaLbl.TabIndex = 32;
            facFormaLbl.Text = "Factor de forma:";
            // 
            // areaFustalesLbl
            // 
            areaFustalesLbl.AutoSize = true;
            areaFustalesLbl.Location = new System.Drawing.Point(14, 142);
            areaFustalesLbl.Name = "areaFustalesLbl";
            areaFustalesLbl.Size = new System.Drawing.Size(103, 26);
            areaFustalesLbl.TabIndex = 31;
            areaFustalesLbl.Text = "Area Parcela de \r\nregeneración (Htas):";
            // 
            // tamanioParLbl
            // 
            tamanioParLbl.AutoSize = true;
            tamanioParLbl.Location = new System.Drawing.Point(13, 93);
            tamanioParLbl.Name = "tamanioParLbl";
            tamanioParLbl.Size = new System.Drawing.Size(119, 13);
            tamanioParLbl.TabIndex = 29;
            tamanioParLbl.Text = "Tamaño Parcela (Htas):";
            // 
            // crearProyectoTab
            // 
            this.crearProyectoTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.crearProyectoTab.Controls.Add(this.proyectoTabP);
            this.crearProyectoTab.Controls.Add(this.especiesTabP);
            this.crearProyectoTab.Controls.Add(this.estratosTabP);
            this.crearProyectoTab.Controls.Add(this.formulariosTap);
            this.crearProyectoTab.Controls.Add(this.proyectosContTabP);
            this.crearProyectoTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.crearProyectoTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.crearProyectoTab.ItemSize = new System.Drawing.Size(40, 120);
            this.crearProyectoTab.Location = new System.Drawing.Point(0, 0);
            this.crearProyectoTab.Multiline = true;
            this.crearProyectoTab.Name = "crearProyectoTab";
            this.crearProyectoTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.crearProyectoTab.SelectedIndex = 0;
            this.crearProyectoTab.Size = new System.Drawing.Size(659, 467);
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
            this.proyectoTabP.Size = new System.Drawing.Size(531, 459);
            this.proyectoTabP.TabIndex = 1;
            this.proyectoTabP.Text = "Datos del proyecto";
            this.proyectoTabP.UseVisualStyleBackColor = true;
            // 
            // DatosProyectoGbx
            // 
            this.DatosProyectoGbx.Controls.Add(this.otrosDatosGbx);
            this.DatosProyectoGbx.Controls.Add(this.TipoProyectoCbx);
            this.DatosProyectoGbx.Controls.Add(this.label1);
            this.DatosProyectoGbx.Controls.Add(this.DescripcionTxt);
            this.DatosProyectoGbx.Controls.Add(descripcionLbl);
            this.DatosProyectoGbx.Controls.Add(this.tipoDisenoCbx);
            this.DatosProyectoGbx.Controls.Add(this.tipoObjetivoCbx);
            this.DatosProyectoGbx.Controls.Add(lugarLbl);
            this.DatosProyectoGbx.Controls.Add(this.lugarTxt);
            this.DatosProyectoGbx.Controls.Add(TipoDisenoLbl);
            this.DatosProyectoGbx.Controls.Add(objetivoInvTxt);
            this.DatosProyectoGbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosProyectoGbx.Location = new System.Drawing.Point(3, 3);
            this.DatosProyectoGbx.Name = "DatosProyectoGbx";
            this.DatosProyectoGbx.Size = new System.Drawing.Size(525, 453);
            this.DatosProyectoGbx.TabIndex = 4;
            this.DatosProyectoGbx.TabStop = false;
            this.DatosProyectoGbx.Text = "Definicion del proyecto";
            // 
            // otrosDatosGbx
            // 
            this.otrosDatosGbx.Controls.Add(this.areaMuestrearTxt);
            this.otrosDatosGbx.Controls.Add(this.label3);
            this.otrosDatosGbx.Controls.Add(this.confianzaTxt);
            this.otrosDatosGbx.Controls.Add(this.label2);
            this.otrosDatosGbx.Controls.Add(areaMuestreadaLbl);
            this.otrosDatosGbx.Controls.Add(this.AreaTotalTxt);
            this.otrosDatosGbx.Controls.Add(intensidadMuestreLbl);
            this.otrosDatosGbx.Controls.Add(porcentajeLbl);
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
            this.otrosDatosGbx.Location = new System.Drawing.Point(10, 209);
            this.otrosDatosGbx.Name = "otrosDatosGbx";
            this.otrosDatosGbx.Size = new System.Drawing.Size(502, 230);
            this.otrosDatosGbx.TabIndex = 28;
            this.otrosDatosGbx.TabStop = false;
            // 
            // areaMuestrearTxt
            // 
            this.areaMuestrearTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "SUPMUE", true));
            this.areaMuestrearTxt.Enabled = false;
            this.areaMuestrearTxt.Location = new System.Drawing.Point(399, 65);
            this.areaMuestrearTxt.Name = "areaMuestrearTxt";
            this.areaMuestrearTxt.Size = new System.Drawing.Size(91, 20);
            this.areaMuestrearTxt.TabIndex = 47;
            // 
            // proyectoBS
            // 
            this.proyectoBS.DataSource = typeof(SIFCA_DAL.PROYECTO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Area a Muestrear (Htas):";
            // 
            // confianzaTxt
            // 
            this.confianzaTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "CONFIANZA", true));
            this.confianzaTxt.Location = new System.Drawing.Point(184, 13);
            this.confianzaTxt.Name = "confianzaTxt";
            this.confianzaTxt.Size = new System.Drawing.Size(306, 20);
            this.confianzaTxt.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "% Confianza:";
            // 
            // AreaTotalTxt
            // 
            this.AreaTotalTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "SUPTOT", true));
            this.AreaTotalTxt.Location = new System.Drawing.Point(184, 39);
            this.AreaTotalTxt.Name = "AreaTotalTxt";
            this.AreaTotalTxt.Size = new System.Drawing.Size(306, 20);
            this.AreaTotalTxt.TabIndex = 35;
            this.AreaTotalTxt.TextChanged += new System.EventHandler(this.AreTotalTxt_TextChanged);
            // 
            // intMuestreoTxt
            // 
            this.intMuestreoTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "INTMUE", true));
            this.intMuestreoTxt.Location = new System.Drawing.Point(184, 65);
            this.intMuestreoTxt.Name = "intMuestreoTxt";
            this.intMuestreoTxt.Size = new System.Drawing.Size(56, 20);
            this.intMuestreoTxt.TabIndex = 33;
            this.intMuestreoTxt.TextChanged += new System.EventHandler(this.intMuestreoTxt_TextChanged);
            // 
            // limiteInfTxt
            // 
            this.limiteInfTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "LIMITINFDAP", true));
            this.limiteInfTxt.Location = new System.Drawing.Point(184, 117);
            this.limiteInfTxt.Name = "limiteInfTxt";
            this.limiteInfTxt.Size = new System.Drawing.Size(306, 20);
            this.limiteInfTxt.TabIndex = 30;
            // 
            // numeroEtapasTxt
            // 
            this.numeroEtapasTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectosBS, "ETAPA", true));
            this.numeroEtapasTxt.Location = new System.Drawing.Point(184, 197);
            this.numeroEtapasTxt.Name = "numeroEtapasTxt";
            this.numeroEtapasTxt.Size = new System.Drawing.Size(306, 20);
            this.numeroEtapasTxt.TabIndex = 39;
            // 
            // proyectosBS
            // 
            this.proyectosBS.DataSource = typeof(SIFCA_DAL.PROYECTO);
            // 
            // factorFormaTxt
            // 
            this.factorFormaTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "FACTORDEFORMA", true));
            this.factorFormaTxt.Location = new System.Drawing.Point(184, 172);
            this.factorFormaTxt.Name = "factorFormaTxt";
            this.factorFormaTxt.Size = new System.Drawing.Size(306, 20);
            this.factorFormaTxt.TabIndex = 38;
            // 
            // areaFustalesTxt
            // 
            this.areaFustalesTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "AREAFUSTALESPORPARCELA", true));
            this.areaFustalesTxt.Location = new System.Drawing.Point(184, 143);
            this.areaFustalesTxt.Name = "areaFustalesTxt";
            this.areaFustalesTxt.Size = new System.Drawing.Size(306, 20);
            this.areaFustalesTxt.TabIndex = 37;
            // 
            // tamParcelaTxt
            // 
            this.tamParcelaTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "TAMANO", true));
            this.tamParcelaTxt.Location = new System.Drawing.Point(184, 91);
            this.tamParcelaTxt.Name = "tamParcelaTxt";
            this.tamParcelaTxt.Size = new System.Drawing.Size(306, 20);
            this.tamParcelaTxt.TabIndex = 36;
            // 
            // TipoProyectoCbx
            // 
            this.TipoProyectoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoProyectoCbx.FormattingEnabled = true;
            this.TipoProyectoCbx.Items.AddRange(new object[] {
            "Independiente",
            "Contenedor"});
            this.TipoProyectoCbx.Location = new System.Drawing.Point(145, 176);
            this.TipoProyectoCbx.Name = "TipoProyectoCbx";
            this.TipoProyectoCbx.Size = new System.Drawing.Size(363, 21);
            this.TipoProyectoCbx.TabIndex = 5;
            this.TipoProyectoCbx.SelectedIndexChanged += new System.EventHandler(this.TipoProyectoCbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo de Proyecto: ";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "DESCRIPCION", true));
            this.DescripcionTxt.Location = new System.Drawing.Point(145, 50);
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripcionTxt.Size = new System.Drawing.Size(363, 62);
            this.DescripcionTxt.TabIndex = 2;
            // 
            // tipoDisenoCbx
            // 
            this.tipoDisenoCbx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proyectoBS, "NOMTIPODISEMUEST", true));
            this.tipoDisenoCbx.DataSource = this.tipoDisenoBS;
            this.tipoDisenoCbx.DisplayMember = "DESCRIPTIPODISEMUEST";
            this.tipoDisenoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDisenoCbx.FormattingEnabled = true;
            this.tipoDisenoCbx.Location = new System.Drawing.Point(145, 146);
            this.tipoDisenoCbx.Name = "tipoDisenoCbx";
            this.tipoDisenoCbx.Size = new System.Drawing.Size(363, 21);
            this.tipoDisenoCbx.TabIndex = 4;
            this.tipoDisenoCbx.ValueMember = "NOMTIPODISEMUEST";
            this.tipoDisenoCbx.SelectedIndexChanged += new System.EventHandler(this.tipoDisenoCbx_SelectedIndexChanged);
            // 
            // tipoDisenoBS
            // 
            this.tipoDisenoBS.DataSource = typeof(SIFCA_DAL.TIPODISENOMUESTRAL);
            // 
            // tipoObjetivoCbx
            // 
            this.tipoObjetivoCbx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proyectoBS, "NOMBRETIPOINV", true));
            this.tipoObjetivoCbx.DataSource = this.objetivoInventarioBS;
            this.tipoObjetivoCbx.DisplayMember = "DESCRIPOBJETINV";
            this.tipoObjetivoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoObjetivoCbx.FormattingEnabled = true;
            this.tipoObjetivoCbx.Location = new System.Drawing.Point(145, 118);
            this.tipoObjetivoCbx.Name = "tipoObjetivoCbx";
            this.tipoObjetivoCbx.Size = new System.Drawing.Size(363, 21);
            this.tipoObjetivoCbx.TabIndex = 3;
            this.tipoObjetivoCbx.ValueMember = "NOMBRETIPOINV";
            // 
            // objetivoInventarioBS
            // 
            this.objetivoInventarioBS.DataSource = typeof(SIFCA_DAL.OBJETIVOINVENTARIO);
            // 
            // lugarTxt
            // 
            this.lugarTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBS, "LUGAR", true));
            this.lugarTxt.Location = new System.Drawing.Point(145, 23);
            this.lugarTxt.Name = "lugarTxt";
            this.lugarTxt.Size = new System.Drawing.Size(363, 20);
            this.lugarTxt.TabIndex = 1;
            // 
            // especiesTabP
            // 
            this.especiesTabP.AutoScroll = true;
            this.especiesTabP.Controls.Add(this.especiesDGW);
            this.especiesTabP.Controls.Add(this.seleccEspecieBtn);
            this.especiesTabP.Controls.Add(this.RemoverEspciesBtn);
            this.especiesTabP.Location = new System.Drawing.Point(124, 4);
            this.especiesTabP.Name = "especiesTabP";
            this.especiesTabP.Padding = new System.Windows.Forms.Padding(3);
            this.especiesTabP.Size = new System.Drawing.Size(531, 459);
            this.especiesTabP.TabIndex = 2;
            this.especiesTabP.Text = "Listado de Especies";
            this.especiesTabP.UseVisualStyleBackColor = true;
            // 
            // especiesDGW
            // 
            this.especiesDGW.AllowUserToAddRows = false;
            this.especiesDGW.AllowUserToDeleteRows = false;
            this.especiesDGW.AutoGenerateColumns = false;
            this.especiesDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.especiesDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.especiesDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especiesDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Especie,
            this.NOMCOMUN,
            this.NOMCIENTIFICO,
            this.FAMILIA});
            this.especiesDGW.DataSource = this.especieBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.especiesDGW.DefaultCellStyle = dataGridViewCellStyle2;
            this.especiesDGW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.especiesDGW.Location = new System.Drawing.Point(3, 41);
            this.especiesDGW.Name = "especiesDGW";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.especiesDGW.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.especiesDGW.Size = new System.Drawing.Size(525, 415);
            this.especiesDGW.TabIndex = 19;
            this.especiesDGW.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.especiesDGW_CellValueChanged);
            this.especiesDGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.especiesDGW_DataBindingComplete);
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
            // seleccEspecieBtn
            // 
            this.seleccEspecieBtn.Location = new System.Drawing.Point(301, 12);
            this.seleccEspecieBtn.Name = "seleccEspecieBtn";
            this.seleccEspecieBtn.Size = new System.Drawing.Size(112, 23);
            this.seleccEspecieBtn.TabIndex = 17;
            this.seleccEspecieBtn.Text = "Seleccionar Todos";
            this.seleccEspecieBtn.UseVisualStyleBackColor = true;
            this.seleccEspecieBtn.Click += new System.EventHandler(this.seleccEspecieBtn_Click);
            // 
            // RemoverEspciesBtn
            // 
            this.RemoverEspciesBtn.Location = new System.Drawing.Point(419, 12);
            this.RemoverEspciesBtn.Name = "RemoverEspciesBtn";
            this.RemoverEspciesBtn.Size = new System.Drawing.Size(104, 23);
            this.RemoverEspciesBtn.TabIndex = 18;
            this.RemoverEspciesBtn.Text = "Remover Todos";
            this.RemoverEspciesBtn.UseVisualStyleBackColor = true;
            this.RemoverEspciesBtn.Click += new System.EventHandler(this.RemoverEspciesBtn_Click);
            // 
            // estratosTabP
            // 
            this.estratosTabP.Controls.Add(this.errorLbl);
            this.estratosTabP.Controls.Add(this.actualizarPesosEstratosBtn);
            this.estratosTabP.Controls.Add(this.SeleccEstratosBtn);
            this.estratosTabP.Controls.Add(this.removerEstratosBtn);
            this.estratosTabP.Controls.Add(this.estratoDGW);
            this.estratosTabP.Location = new System.Drawing.Point(124, 4);
            this.estratosTabP.Name = "estratosTabP";
            this.estratosTabP.Padding = new System.Windows.Forms.Padding(3);
            this.estratosTabP.Size = new System.Drawing.Size(531, 459);
            this.estratosTabP.TabIndex = 3;
            this.estratosTabP.Text = "Listado de Estratos";
            this.estratosTabP.UseVisualStyleBackColor = true;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(8, 10);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 22;
            // 
            // actualizarPesosEstratosBtn
            // 
            this.actualizarPesosEstratosBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actualizarPesosEstratosBtn.BackgroundImage")));
            this.actualizarPesosEstratosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actualizarPesosEstratosBtn.Enabled = false;
            this.actualizarPesosEstratosBtn.Location = new System.Drawing.Point(502, 9);
            this.actualizarPesosEstratosBtn.Name = "actualizarPesosEstratosBtn";
            this.actualizarPesosEstratosBtn.Size = new System.Drawing.Size(23, 23);
            this.actualizarPesosEstratosBtn.TabIndex = 22;
            this.actualizarPesosEstratosBtn.UseVisualStyleBackColor = true;
            this.actualizarPesosEstratosBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // SeleccEstratosBtn
            // 
            this.SeleccEstratosBtn.Enabled = false;
            this.SeleccEstratosBtn.Location = new System.Drawing.Point(273, 9);
            this.SeleccEstratosBtn.Name = "SeleccEstratosBtn";
            this.SeleccEstratosBtn.Size = new System.Drawing.Size(112, 23);
            this.SeleccEstratosBtn.TabIndex = 20;
            this.SeleccEstratosBtn.Text = "Seleccionar Todos";
            this.SeleccEstratosBtn.UseVisualStyleBackColor = true;
            this.SeleccEstratosBtn.Click += new System.EventHandler(this.SeleccEstratosBtn_Click);
            // 
            // removerEstratosBtn
            // 
            this.removerEstratosBtn.Enabled = false;
            this.removerEstratosBtn.Location = new System.Drawing.Point(391, 9);
            this.removerEstratosBtn.Name = "removerEstratosBtn";
            this.removerEstratosBtn.Size = new System.Drawing.Size(104, 23);
            this.removerEstratosBtn.TabIndex = 21;
            this.removerEstratosBtn.Text = "Remover Todos";
            this.removerEstratosBtn.UseVisualStyleBackColor = true;
            this.removerEstratosBtn.Click += new System.EventHandler(this.removerEstratosBtn_Click);
            // 
            // estratoDGW
            // 
            this.estratoDGW.AllowUserToAddRows = false;
            this.estratoDGW.AllowUserToDeleteRows = false;
            this.estratoDGW.AllowUserToOrderColumns = true;
            this.estratoDGW.AutoGenerateColumns = false;
            this.estratoDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.estratoDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.estratoDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estratoDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estratos,
            this.DESCRIPESTRATO,
            this.Peso});
            this.estratoDGW.DataSource = this.estratoBS;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.estratoDGW.DefaultCellStyle = dataGridViewCellStyle5;
            this.estratoDGW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.estratoDGW.Enabled = false;
            this.estratoDGW.Location = new System.Drawing.Point(3, 41);
            this.estratoDGW.Name = "estratoDGW";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.estratoDGW.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.estratoDGW.Size = new System.Drawing.Size(525, 415);
            this.estratoDGW.TabIndex = 23;
            this.estratoDGW.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.estratoDGW_CellValueChanged);
            this.estratoDGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.estratosDGW_DataBindingComplete);
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
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // estratoBS
            // 
            this.estratoBS.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // formulariosTap
            // 
            this.formulariosTap.AutoScroll = true;
            this.formulariosTap.Controls.Add(this.crearFormBtn);
            this.formulariosTap.Controls.Add(this.formulariosDGW);
            this.formulariosTap.Location = new System.Drawing.Point(124, 4);
            this.formulariosTap.Name = "formulariosTap";
            this.formulariosTap.Size = new System.Drawing.Size(531, 459);
            this.formulariosTap.TabIndex = 5;
            this.formulariosTap.Text = "Formularios";
            this.formulariosTap.UseVisualStyleBackColor = true;
            // 
            // crearFormBtn
            // 
            this.crearFormBtn.Location = new System.Drawing.Point(414, 10);
            this.crearFormBtn.Name = "crearFormBtn";
            this.crearFormBtn.Size = new System.Drawing.Size(109, 23);
            this.crearFormBtn.TabIndex = 24;
            this.crearFormBtn.Text = "Crear Formulario";
            this.crearFormBtn.UseVisualStyleBackColor = true;
            this.crearFormBtn.Click += new System.EventHandler(this.crearFormBtn_Click);
            // 
            // formulariosDGW
            // 
            this.formulariosDGW.AllowUserToAddRows = false;
            this.formulariosDGW.AllowUserToDeleteRows = false;
            this.formulariosDGW.AutoGenerateColumns = false;
            this.formulariosDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.formulariosDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.formulariosDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formulariosDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHACREACION,
            this.NROFORMULARIO,
            this.Usuario,
            this.NombreResponsable,
            this.CODEST,
            this.PARCELA,
            this.LINEA,
            this.ListarDatos});
            this.formulariosDGW.DataSource = this.formulariosBS;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formulariosDGW.DefaultCellStyle = dataGridViewCellStyle8;
            this.formulariosDGW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formulariosDGW.Location = new System.Drawing.Point(0, 39);
            this.formulariosDGW.Name = "formulariosDGW";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.formulariosDGW.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.formulariosDGW.Size = new System.Drawing.Size(531, 420);
            this.formulariosDGW.TabIndex = 25;
            this.formulariosDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.formulariosDGW_CellClick);
            this.formulariosDGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.formulariosDGW_DataBindingComplete);
            // 
            // FECHACREACION
            // 
            this.FECHACREACION.DataPropertyName = "FECHACREACION";
            this.FECHACREACION.HeaderText = "Fecha";
            this.FECHACREACION.Name = "FECHACREACION";
            // 
            // NROFORMULARIO
            // 
            this.NROFORMULARIO.DataPropertyName = "NROFORMULARIO";
            this.NROFORMULARIO.HeaderText = "NROFORMULARIO";
            this.NROFORMULARIO.Name = "NROFORMULARIO";
            this.NROFORMULARIO.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "NROUSUARIO";
            this.Usuario.HeaderText = "Responsable";
            this.Usuario.Name = "Usuario";
            this.Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuario.Visible = false;
            // 
            // NombreResponsable
            // 
            this.NombreResponsable.HeaderText = "Responsable";
            this.NombreResponsable.Name = "NombreResponsable";
            // 
            // CODEST
            // 
            this.CODEST.DataPropertyName = "CODEST";
            this.CODEST.DataSource = this.estratoBS;
            this.CODEST.DisplayMember = "DESCRIPESTRATO";
            this.CODEST.HeaderText = "Estrato";
            this.CODEST.Name = "CODEST";
            this.CODEST.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CODEST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CODEST.ValueMember = "CODEST";
            // 
            // PARCELA
            // 
            this.PARCELA.DataPropertyName = "PARCELA";
            this.PARCELA.HeaderText = "Parcela";
            this.PARCELA.Name = "PARCELA";
            // 
            // LINEA
            // 
            this.LINEA.DataPropertyName = "LINEA";
            this.LINEA.HeaderText = "Linea";
            this.LINEA.Name = "LINEA";
            // 
            // ListarDatos
            // 
            this.ListarDatos.HeaderText = "";
            this.ListarDatos.Name = "ListarDatos";
            this.ListarDatos.Text = "Ver";
            this.ListarDatos.UseColumnTextForButtonValue = true;
            // 
            // formulariosBS
            // 
            this.formulariosBS.DataSource = typeof(SIFCA_DAL.FORMULARIO);
            // 
            // proyectosContTabP
            // 
            this.proyectosContTabP.AutoScroll = true;
            this.proyectosContTabP.Controls.Add(this.arbolEtapasBtn);
            this.proyectosContTabP.Controls.Add(this.proyectoDGW);
            this.proyectosContTabP.Controls.Add(this.seleccionarProyectosBtn);
            this.proyectosContTabP.Controls.Add(this.removerProyectosBtn);
            this.proyectosContTabP.Location = new System.Drawing.Point(124, 4);
            this.proyectosContTabP.Name = "proyectosContTabP";
            this.proyectosContTabP.Size = new System.Drawing.Size(531, 459);
            this.proyectosContTabP.TabIndex = 4;
            this.proyectosContTabP.Text = "Proyectos contenidos";
            this.proyectosContTabP.UseVisualStyleBackColor = true;
            // 
            // arbolEtapasBtn
            // 
            this.arbolEtapasBtn.Location = new System.Drawing.Point(206, 15);
            this.arbolEtapasBtn.Name = "arbolEtapasBtn";
            this.arbolEtapasBtn.Size = new System.Drawing.Size(75, 23);
            this.arbolEtapasBtn.TabIndex = 29;
            this.arbolEtapasBtn.Text = "Etapas";
            this.arbolEtapasBtn.UseVisualStyleBackColor = true;
            this.arbolEtapasBtn.Click += new System.EventHandler(this.arbolEtapasBtn_Click);
            // 
            // proyectoDGW
            // 
            this.proyectoDGW.AllowUserToAddRows = false;
            this.proyectoDGW.AllowUserToDeleteRows = false;
            this.proyectoDGW.AllowUserToOrderColumns = true;
            this.proyectoDGW.AutoGenerateColumns = false;
            this.proyectoDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proyectoDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.proyectoDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proyectoDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proyectos,
            this.Codigo,
            this.LUGAR,
            this.FECHA,
            this.NOMBRETIPOINV,
            this.NOMTIPODISEMUEST,
            this.PesoProyecto});
            this.proyectoDGW.DataSource = this.proyectosBS;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.proyectoDGW.DefaultCellStyle = dataGridViewCellStyle11;
            this.proyectoDGW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proyectoDGW.Enabled = false;
            this.proyectoDGW.Location = new System.Drawing.Point(0, 44);
            this.proyectoDGW.Name = "proyectoDGW";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proyectoDGW.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.proyectoDGW.Size = new System.Drawing.Size(531, 415);
            this.proyectoDGW.TabIndex = 28;
            this.proyectoDGW.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.proyectoDGW_CellValueChanged);
            this.proyectoDGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.proyectoDGW_DataBindingComplete);
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
            // seleccionarProyectosBtn
            // 
            this.seleccionarProyectosBtn.Enabled = false;
            this.seleccionarProyectosBtn.Location = new System.Drawing.Point(306, 15);
            this.seleccionarProyectosBtn.Name = "seleccionarProyectosBtn";
            this.seleccionarProyectosBtn.Size = new System.Drawing.Size(112, 23);
            this.seleccionarProyectosBtn.TabIndex = 26;
            this.seleccionarProyectosBtn.Text = "Seleccionar Todos";
            this.seleccionarProyectosBtn.UseVisualStyleBackColor = true;
            this.seleccionarProyectosBtn.Click += new System.EventHandler(this.seleccionarProyectosBtn_Click);
            // 
            // removerProyectosBtn
            // 
            this.removerProyectosBtn.Enabled = false;
            this.removerProyectosBtn.Location = new System.Drawing.Point(424, 15);
            this.removerProyectosBtn.Name = "removerProyectosBtn";
            this.removerProyectosBtn.Size = new System.Drawing.Size(104, 23);
            this.removerProyectosBtn.TabIndex = 27;
            this.removerProyectosBtn.Text = "Remover Todos";
            this.removerProyectosBtn.UseVisualStyleBackColor = true;
            this.removerProyectosBtn.Click += new System.EventHandler(this.removerProyectosBtn_Click);
            // 
            // usuarioBS
            // 
            this.usuarioBS.DataSource = typeof(SIFCA_DAL.USUARIO);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(579, 497);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 30;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ActualizarBtn
            // 
            this.ActualizarBtn.Location = new System.Drawing.Point(497, 497);
            this.ActualizarBtn.Name = "ActualizarBtn";
            this.ActualizarBtn.Size = new System.Drawing.Size(75, 23);
            this.ActualizarBtn.TabIndex = 29;
            this.ActualizarBtn.Text = "Actualizar";
            this.ActualizarBtn.UseVisualStyleBackColor = true;
            this.ActualizarBtn.Click += new System.EventHandler(this.ActualizarProyectoBtn_Click);
            // 
            // controladorErrores
            // 
            this.controladorErrores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.controladorErrores.ContainerControl = this;
            // 
            // Actualizar_Proyectos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIFCA.Properties.Resources.fondo_tab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 525);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.ActualizarBtn);
            this.Controls.Add(this.crearProyectoTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Actualizar_Proyectos_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar proyecto";
            this.crearProyectoTab.ResumeLayout(false);
            this.proyectoTabP.ResumeLayout(false);
            this.DatosProyectoGbx.ResumeLayout(false);
            this.DatosProyectoGbx.PerformLayout();
            this.otrosDatosGbx.ResumeLayout(false);
            this.otrosDatosGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInventarioBS)).EndInit();
            this.especiesTabP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.especiesDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBS)).EndInit();
            this.estratosTabP.ResumeLayout(false);
            this.estratosTabP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estratoDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBS)).EndInit();
            this.formulariosTap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formulariosDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulariosBS)).EndInit();
            this.proyectosContTabP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl crearProyectoTab;
        private System.Windows.Forms.TabPage proyectoTabP;
        private System.Windows.Forms.TabPage especiesTabP;
        private System.Windows.Forms.TabPage estratosTabP;
        private System.Windows.Forms.BindingSource tipoDisenoBS;
        private System.Windows.Forms.BindingSource objetivoInventarioBS;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button ActualizarBtn;
        private System.Windows.Forms.BindingSource especieBS;
        private System.Windows.Forms.DataGridView estratoDGW;
        private System.Windows.Forms.BindingSource estratoBS;
        private System.Windows.Forms.Button SeleccEstratosBtn;
        private System.Windows.Forms.Button removerEstratosBtn;
        private System.Windows.Forms.TabPage proyectosContTabP;
        private System.Windows.Forms.Button seleccionarProyectosBtn;
        private System.Windows.Forms.Button removerProyectosBtn;
        private System.Windows.Forms.BindingSource proyectosBS;
        private System.Windows.Forms.Button seleccEspecieBtn;
        private System.Windows.Forms.Button RemoverEspciesBtn;
        private System.Windows.Forms.TabPage formulariosTap;
        private System.Windows.Forms.DataGridView formulariosDGW;
        private System.Windows.Forms.BindingSource formulariosBS;
        private System.Windows.Forms.Button crearFormBtn;
        private System.Windows.Forms.DataGridView proyectoDGW;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Proyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOMBRETIPOINV;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOMTIPODISEMUEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoProyecto;
        private System.Windows.Forms.GroupBox DatosProyectoGbx;
        private System.Windows.Forms.ComboBox TipoProyectoCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.ComboBox tipoDisenoCbx;
        private System.Windows.Forms.ComboBox tipoObjetivoCbx;
        private System.Windows.Forms.TextBox lugarTxt;
        private System.Windows.Forms.Button actualizarPesosEstratosBtn;
        private System.Windows.Forms.DataGridView especiesDGW;
        private System.Windows.Forms.BindingSource usuarioBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHACREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROFORMULARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreResponsable;
        private System.Windows.Forms.DataGridViewComboBoxColumn CODEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARCELA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINEA;
        private System.Windows.Forms.DataGridViewButtonColumn ListarDatos;
        private System.Windows.Forms.BindingSource proyectoBS;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.ErrorProvider controladorErrores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMCOMUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMCIENTIFICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPESTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.GroupBox otrosDatosGbx;
        private System.Windows.Forms.TextBox confianzaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AreaTotalTxt;
        private System.Windows.Forms.TextBox intMuestreoTxt;
        private System.Windows.Forms.TextBox limiteInfTxt;
        private System.Windows.Forms.TextBox numeroEtapasTxt;
        private System.Windows.Forms.TextBox factorFormaTxt;
        private System.Windows.Forms.TextBox areaFustalesTxt;
        private System.Windows.Forms.TextBox areaMuestrearTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tamParcelaTxt;
        private System.Windows.Forms.Button arbolEtapasBtn;


    }
}