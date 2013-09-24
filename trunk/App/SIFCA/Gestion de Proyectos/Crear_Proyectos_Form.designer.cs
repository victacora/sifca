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
            System.Windows.Forms.Label DAPLbl;
            System.Windows.Forms.Label facFormaLbl;
            System.Windows.Forms.Label areaFustalesLbl;
            System.Windows.Forms.Label tamanioParLbl;
            System.Windows.Forms.Label porcentajeLbl;
            System.Windows.Forms.Label HectareasLbl;
            System.Windows.Forms.Label lugarLbl;
            System.Windows.Forms.Label TipoDisenoLbl;
            System.Windows.Forms.Label objetivoInvTxt;
            System.Windows.Forms.Label numeroEtapasLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Proyecto_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.crearProyectoTab = new System.Windows.Forms.TabControl();
            this.proyectoTabP = new System.Windows.Forms.TabPage();
            this.DatosProyectoGbx = new System.Windows.Forms.GroupBox();
            this.TipoProyectoCbx = new System.Windows.Forms.ComboBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.tipoDisenoCbx = new System.Windows.Forms.ComboBox();
            this.tipoDisenoBS = new System.Windows.Forms.BindingSource(this.components);
            this.tipoObjetivoCbx = new System.Windows.Forms.ComboBox();
            this.objetivoInventarioBS = new System.Windows.Forms.BindingSource(this.components);
            this.datosDAPGbx = new System.Windows.Forms.GroupBox();
            this.limiteSupTxt = new System.Windows.Forms.TextBox();
            this.limiteInfTxt = new System.Windows.Forms.TextBox();
            this.otrosDatosGbx = new System.Windows.Forms.GroupBox();
            this.numeroEtapasTxt = new System.Windows.Forms.TextBox();
            this.factorFormaTxt = new System.Windows.Forms.TextBox();
            this.areaFustalesTxt = new System.Windows.Forms.TextBox();
            this.tamParcelaTxt = new System.Windows.Forms.TextBox();
            this.IntensidadGbx = new System.Windows.Forms.GroupBox();
            this.intMuestreoTxt = new System.Windows.Forms.TextBox();
            this.AreaMuestreadaGbx = new System.Windows.Forms.GroupBox();
            this.AreaMuestradaTxt = new System.Windows.Forms.TextBox();
            this.lugarTxt = new System.Windows.Forms.TextBox();
            this.especiesTabP = new System.Windows.Forms.TabPage();
            this.seleccEspecieBtn = new System.Windows.Forms.Button();
            this.RemoverEspciesBtn = new System.Windows.Forms.Button();
            this.especiesDGW = new System.Windows.Forms.DataGridView();
            this.Especie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NOMCOMUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMCIENTIFICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especieBS = new System.Windows.Forms.BindingSource(this.components);
            this.estratosTabP = new System.Windows.Forms.TabPage();
            this.SeleccEstratosBtn = new System.Windows.Forms.Button();
            this.removerEstratosBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.estratoDGW = new System.Windows.Forms.DataGridView();
            this.Estratos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DESCRIPESTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estratoBS = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosContTabP = new System.Windows.Forms.TabPage();
            this.seleccionarProyectosBtn = new System.Windows.Forms.Button();
            this.removerProyectosBtn = new System.Windows.Forms.Button();
            this.proyectoDGW = new System.Windows.Forms.DataGridView();
            this.proyectoBS = new System.Windows.Forms.BindingSource(this.components);
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.Proyectos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRETIPOINV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NOMTIPODISEMUEST = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PesoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descripcionLbl = new System.Windows.Forms.Label();
            DAPLbl = new System.Windows.Forms.Label();
            facFormaLbl = new System.Windows.Forms.Label();
            areaFustalesLbl = new System.Windows.Forms.Label();
            tamanioParLbl = new System.Windows.Forms.Label();
            porcentajeLbl = new System.Windows.Forms.Label();
            HectareasLbl = new System.Windows.Forms.Label();
            lugarLbl = new System.Windows.Forms.Label();
            TipoDisenoLbl = new System.Windows.Forms.Label();
            objetivoInvTxt = new System.Windows.Forms.Label();
            numeroEtapasLbl = new System.Windows.Forms.Label();
            this.crearProyectoTab.SuspendLayout();
            this.proyectoTabP.SuspendLayout();
            this.DatosProyectoGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInventarioBS)).BeginInit();
            this.datosDAPGbx.SuspendLayout();
            this.otrosDatosGbx.SuspendLayout();
            this.IntensidadGbx.SuspendLayout();
            this.AreaMuestreadaGbx.SuspendLayout();
            this.especiesTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especiesDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBS)).BeginInit();
            this.estratosTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estratoDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBS)).BeginInit();
            this.proyectosContTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).BeginInit();
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
            // DAPLbl
            // 
            DAPLbl.AutoSize = true;
            DAPLbl.Location = new System.Drawing.Point(48, 22);
            DAPLbl.Name = "DAPLbl";
            DAPLbl.Size = new System.Drawing.Size(53, 13);
            DAPLbl.TabIndex = 23;
            DAPLbl.Text = "<= DAP <";
            // 
            // facFormaLbl
            // 
            facFormaLbl.AutoSize = true;
            facFormaLbl.Location = new System.Drawing.Point(3, 79);
            facFormaLbl.Name = "facFormaLbl";
            facFormaLbl.Size = new System.Drawing.Size(84, 13);
            facFormaLbl.TabIndex = 10;
            facFormaLbl.Text = "Factor de forma:";
            // 
            // areaFustalesLbl
            // 
            areaFustalesLbl.AutoSize = true;
            areaFustalesLbl.Location = new System.Drawing.Point(3, 53);
            areaFustalesLbl.Name = "areaFustalesLbl";
            areaFustalesLbl.Size = new System.Drawing.Size(130, 13);
            areaFustalesLbl.TabIndex = 8;
            areaFustalesLbl.Text = "Area Fustales por parcela:";
            // 
            // tamanioParLbl
            // 
            tamanioParLbl.AutoSize = true;
            tamanioParLbl.Location = new System.Drawing.Point(3, 27);
            tamanioParLbl.Name = "tamanioParLbl";
            tamanioParLbl.Size = new System.Drawing.Size(118, 13);
            tamanioParLbl.TabIndex = 6;
            tamanioParLbl.Text = "Tamaño parcela (Htas):";
            // 
            // porcentajeLbl
            // 
            porcentajeLbl.AutoSize = true;
            porcentajeLbl.Location = new System.Drawing.Point(134, 22);
            porcentajeLbl.Name = "porcentajeLbl";
            porcentajeLbl.Size = new System.Drawing.Size(15, 13);
            porcentajeLbl.TabIndex = 24;
            porcentajeLbl.Text = "%";
            // 
            // HectareasLbl
            // 
            HectareasLbl.AutoSize = true;
            HectareasLbl.Location = new System.Drawing.Point(112, 22);
            HectareasLbl.Name = "HectareasLbl";
            HectareasLbl.Size = new System.Drawing.Size(29, 13);
            HectareasLbl.TabIndex = 24;
            HectareasLbl.Text = "Htas";
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
            numeroEtapasLbl.Location = new System.Drawing.Point(3, 107);
            numeroEtapasLbl.Name = "numeroEtapasLbl";
            numeroEtapasLbl.Size = new System.Drawing.Size(98, 13);
            numeroEtapasLbl.TabIndex = 12;
            numeroEtapasLbl.Text = "Numero de Etapas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 182);
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
            this.crearProyectoTab.Size = new System.Drawing.Size(661, 467);
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
            this.proyectoTabP.Size = new System.Drawing.Size(533, 459);
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
            this.DatosProyectoGbx.Controls.Add(this.datosDAPGbx);
            this.DatosProyectoGbx.Controls.Add(this.otrosDatosGbx);
            this.DatosProyectoGbx.Controls.Add(this.IntensidadGbx);
            this.DatosProyectoGbx.Controls.Add(this.AreaMuestreadaGbx);
            this.DatosProyectoGbx.Controls.Add(lugarLbl);
            this.DatosProyectoGbx.Controls.Add(this.lugarTxt);
            this.DatosProyectoGbx.Controls.Add(TipoDisenoLbl);
            this.DatosProyectoGbx.Controls.Add(objetivoInvTxt);
            this.DatosProyectoGbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosProyectoGbx.Location = new System.Drawing.Point(3, 3);
            this.DatosProyectoGbx.Name = "DatosProyectoGbx";
            this.DatosProyectoGbx.Size = new System.Drawing.Size(527, 453);
            this.DatosProyectoGbx.TabIndex = 3;
            this.DatosProyectoGbx.TabStop = false;
            this.DatosProyectoGbx.Text = "Definicion del proyecto";
            // 
            // TipoProyectoCbx
            // 
            this.TipoProyectoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoProyectoCbx.FormattingEnabled = true;
            this.TipoProyectoCbx.Items.AddRange(new object[] {
            "Independiente",
            "Contenedor"});
            this.TipoProyectoCbx.Location = new System.Drawing.Point(147, 179);
            this.TipoProyectoCbx.Name = "TipoProyectoCbx";
            this.TipoProyectoCbx.Size = new System.Drawing.Size(361, 21);
            this.TipoProyectoCbx.TabIndex = 28;
            this.TipoProyectoCbx.SelectedIndexChanged += new System.EventHandler(this.TipoProyectoCbx_SelectedIndexChanged);
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(145, 50);
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(363, 62);
            this.DescripcionTxt.TabIndex = 26;
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
            this.tipoDisenoCbx.TabIndex = 23;
            this.tipoDisenoCbx.ValueMember = "NOMTIPODISEMUEST";
            this.tipoDisenoCbx.SelectedIndexChanged += new System.EventHandler(this.tipoDisenoCbx_SelectedIndexChanged);
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
            // datosDAPGbx
            // 
            this.datosDAPGbx.Controls.Add(DAPLbl);
            this.datosDAPGbx.Controls.Add(this.limiteSupTxt);
            this.datosDAPGbx.Controls.Add(this.limiteInfTxt);
            this.datosDAPGbx.Location = new System.Drawing.Point(6, 213);
            this.datosDAPGbx.Name = "datosDAPGbx";
            this.datosDAPGbx.Size = new System.Drawing.Size(161, 53);
            this.datosDAPGbx.TabIndex = 22;
            this.datosDAPGbx.TabStop = false;
            this.datosDAPGbx.Text = "Limites DAP (cms)";
            // 
            // limiteSupTxt
            // 
            this.limiteSupTxt.Location = new System.Drawing.Point(111, 19);
            this.limiteSupTxt.Name = "limiteSupTxt";
            this.limiteSupTxt.Size = new System.Drawing.Size(34, 20);
            this.limiteSupTxt.TabIndex = 5;
            this.limiteSupTxt.Text = "100";
            // 
            // limiteInfTxt
            // 
            this.limiteInfTxt.Location = new System.Drawing.Point(6, 19);
            this.limiteInfTxt.Name = "limiteInfTxt";
            this.limiteInfTxt.Size = new System.Drawing.Size(34, 20);
            this.limiteInfTxt.TabIndex = 4;
            this.limiteInfTxt.Text = "10";
            // 
            // otrosDatosGbx
            // 
            this.otrosDatosGbx.Controls.Add(numeroEtapasLbl);
            this.otrosDatosGbx.Controls.Add(this.numeroEtapasTxt);
            this.otrosDatosGbx.Controls.Add(facFormaLbl);
            this.otrosDatosGbx.Controls.Add(this.factorFormaTxt);
            this.otrosDatosGbx.Controls.Add(areaFustalesLbl);
            this.otrosDatosGbx.Controls.Add(this.areaFustalesTxt);
            this.otrosDatosGbx.Controls.Add(tamanioParLbl);
            this.otrosDatosGbx.Controls.Add(this.tamParcelaTxt);
            this.otrosDatosGbx.Location = new System.Drawing.Point(6, 272);
            this.otrosDatosGbx.Name = "otrosDatosGbx";
            this.otrosDatosGbx.Size = new System.Drawing.Size(502, 158);
            this.otrosDatosGbx.TabIndex = 22;
            this.otrosDatosGbx.TabStop = false;
            // 
            // numeroEtapasTxt
            // 
            this.numeroEtapasTxt.Location = new System.Drawing.Point(139, 104);
            this.numeroEtapasTxt.Name = "numeroEtapasTxt";
            this.numeroEtapasTxt.Size = new System.Drawing.Size(340, 20);
            this.numeroEtapasTxt.TabIndex = 11;
            this.numeroEtapasTxt.Text = "0";
            // 
            // factorFormaTxt
            // 
            this.factorFormaTxt.Location = new System.Drawing.Point(139, 76);
            this.factorFormaTxt.Name = "factorFormaTxt";
            this.factorFormaTxt.Size = new System.Drawing.Size(340, 20);
            this.factorFormaTxt.TabIndex = 9;
            this.factorFormaTxt.Text = "0.000";
            // 
            // areaFustalesTxt
            // 
            this.areaFustalesTxt.Location = new System.Drawing.Point(139, 50);
            this.areaFustalesTxt.Name = "areaFustalesTxt";
            this.areaFustalesTxt.Size = new System.Drawing.Size(340, 20);
            this.areaFustalesTxt.TabIndex = 7;
            this.areaFustalesTxt.Text = "1.000";
            // 
            // tamParcelaTxt
            // 
            this.tamParcelaTxt.Location = new System.Drawing.Point(139, 24);
            this.tamParcelaTxt.Name = "tamParcelaTxt";
            this.tamParcelaTxt.Size = new System.Drawing.Size(340, 20);
            this.tamParcelaTxt.TabIndex = 5;
            this.tamParcelaTxt.Text = "1";
            // 
            // IntensidadGbx
            // 
            this.IntensidadGbx.Controls.Add(porcentajeLbl);
            this.IntensidadGbx.Controls.Add(this.intMuestreoTxt);
            this.IntensidadGbx.Location = new System.Drawing.Point(173, 213);
            this.IntensidadGbx.Name = "IntensidadGbx";
            this.IntensidadGbx.Size = new System.Drawing.Size(179, 53);
            this.IntensidadGbx.TabIndex = 21;
            this.IntensidadGbx.TabStop = false;
            this.IntensidadGbx.Text = "Intensidad del muestreo";
            // 
            // intMuestreoTxt
            // 
            this.intMuestreoTxt.Location = new System.Drawing.Point(6, 19);
            this.intMuestreoTxt.Name = "intMuestreoTxt";
            this.intMuestreoTxt.Size = new System.Drawing.Size(125, 20);
            this.intMuestreoTxt.TabIndex = 6;
            this.intMuestreoTxt.Text = "10.000";
            // 
            // AreaMuestreadaGbx
            // 
            this.AreaMuestreadaGbx.Controls.Add(HectareasLbl);
            this.AreaMuestreadaGbx.Controls.Add(this.AreaMuestradaTxt);
            this.AreaMuestreadaGbx.Location = new System.Drawing.Point(358, 213);
            this.AreaMuestreadaGbx.Name = "AreaMuestreadaGbx";
            this.AreaMuestreadaGbx.Size = new System.Drawing.Size(150, 53);
            this.AreaMuestreadaGbx.TabIndex = 20;
            this.AreaMuestreadaGbx.TabStop = false;
            this.AreaMuestreadaGbx.Text = "Area muestreada";
            // 
            // AreaMuestradaTxt
            // 
            this.AreaMuestradaTxt.Location = new System.Drawing.Point(6, 19);
            this.AreaMuestradaTxt.Name = "AreaMuestradaTxt";
            this.AreaMuestradaTxt.Size = new System.Drawing.Size(102, 20);
            this.AreaMuestradaTxt.TabIndex = 5;
            this.AreaMuestradaTxt.Text = "1.000";
            // 
            // lugarTxt
            // 
            this.lugarTxt.Location = new System.Drawing.Point(145, 23);
            this.lugarTxt.Name = "lugarTxt";
            this.lugarTxt.Size = new System.Drawing.Size(363, 20);
            this.lugarTxt.TabIndex = 1;
            // 
            // especiesTabP
            // 
            this.especiesTabP.Controls.Add(this.seleccEspecieBtn);
            this.especiesTabP.Controls.Add(this.RemoverEspciesBtn);
            this.especiesTabP.Controls.Add(this.especiesDGW);
            this.especiesTabP.Location = new System.Drawing.Point(124, 4);
            this.especiesTabP.Name = "especiesTabP";
            this.especiesTabP.Padding = new System.Windows.Forms.Padding(3);
            this.especiesTabP.Size = new System.Drawing.Size(533, 459);
            this.especiesTabP.TabIndex = 2;
            this.especiesTabP.Text = "Listado de Especies";
            this.especiesTabP.UseVisualStyleBackColor = true;
            // 
            // seleccEspecieBtn
            // 
            this.seleccEspecieBtn.Location = new System.Drawing.Point(304, 12);
            this.seleccEspecieBtn.Name = "seleccEspecieBtn";
            this.seleccEspecieBtn.Size = new System.Drawing.Size(112, 23);
            this.seleccEspecieBtn.TabIndex = 16;
            this.seleccEspecieBtn.Text = "Seleccionar Todos";
            this.seleccEspecieBtn.UseVisualStyleBackColor = true;
            this.seleccEspecieBtn.Click += new System.EventHandler(this.seleccEspecieBtn_Click);
            // 
            // RemoverEspciesBtn
            // 
            this.RemoverEspciesBtn.Location = new System.Drawing.Point(422, 12);
            this.RemoverEspciesBtn.Name = "RemoverEspciesBtn";
            this.RemoverEspciesBtn.Size = new System.Drawing.Size(104, 23);
            this.RemoverEspciesBtn.TabIndex = 14;
            this.RemoverEspciesBtn.Text = "Remover Todos";
            this.RemoverEspciesBtn.UseVisualStyleBackColor = true;
            this.RemoverEspciesBtn.Click += new System.EventHandler(this.RemoverEspciesBtn_Click);
            // 
            // especiesDGW
            // 
            this.especiesDGW.AllowUserToAddRows = false;
            this.especiesDGW.AllowUserToDeleteRows = false;
            this.especiesDGW.AllowUserToOrderColumns = true;
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
            this.especiesDGW.Location = new System.Drawing.Point(3, 41);
            this.especiesDGW.Name = "especiesDGW";
            this.especiesDGW.Size = new System.Drawing.Size(527, 415);
            this.especiesDGW.TabIndex = 0;
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
            this.estratosTabP.Controls.Add(this.SeleccEstratosBtn);
            this.estratosTabP.Controls.Add(this.removerEstratosBtn);
            this.estratosTabP.Controls.Add(this.actualizarBtn);
            this.estratosTabP.Controls.Add(this.errorLbl);
            this.estratosTabP.Controls.Add(this.estratoDGW);
            this.estratosTabP.Location = new System.Drawing.Point(124, 4);
            this.estratosTabP.Name = "estratosTabP";
            this.estratosTabP.Padding = new System.Windows.Forms.Padding(3);
            this.estratosTabP.Size = new System.Drawing.Size(533, 459);
            this.estratosTabP.TabIndex = 3;
            this.estratosTabP.Text = "Listado de Estratos";
            this.estratosTabP.UseVisualStyleBackColor = true;
            // 
            // SeleccEstratosBtn
            // 
            this.SeleccEstratosBtn.Enabled = false;
            this.SeleccEstratosBtn.Location = new System.Drawing.Point(290, 10);
            this.SeleccEstratosBtn.Name = "SeleccEstratosBtn";
            this.SeleccEstratosBtn.Size = new System.Drawing.Size(104, 23);
            this.SeleccEstratosBtn.TabIndex = 22;
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
            this.actualizarBtn.TabIndex = 20;
            this.actualizarBtn.UseVisualStyleBackColor = true;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(7, 10);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 19;
            // 
            // estratoDGW
            // 
            this.estratoDGW.AllowUserToAddRows = false;
            this.estratoDGW.AllowUserToDeleteRows = false;
            this.estratoDGW.AllowUserToOrderColumns = true;
            this.estratoDGW.AutoGenerateColumns = false;
            this.estratoDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.estratoDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estratoDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estratos,
            this.DESCRIPESTRATO,
            this.Peso});
            this.estratoDGW.DataSource = this.estratoBS;
            this.estratoDGW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.estratoDGW.Enabled = false;
            this.estratoDGW.Location = new System.Drawing.Point(3, 41);
            this.estratoDGW.Name = "estratoDGW";
            this.estratoDGW.Size = new System.Drawing.Size(527, 415);
            this.estratoDGW.TabIndex = 0;
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
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // estratoBS
            // 
            this.estratoBS.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // proyectosContTabP
            // 
            this.proyectosContTabP.AutoScroll = true;
            this.proyectosContTabP.Controls.Add(this.seleccionarProyectosBtn);
            this.proyectosContTabP.Controls.Add(this.removerProyectosBtn);
            this.proyectosContTabP.Controls.Add(this.proyectoDGW);
            this.proyectosContTabP.Location = new System.Drawing.Point(124, 4);
            this.proyectosContTabP.Name = "proyectosContTabP";
            this.proyectosContTabP.Size = new System.Drawing.Size(533, 459);
            this.proyectosContTabP.TabIndex = 4;
            this.proyectosContTabP.Text = "Proyectos contenidos";
            this.proyectosContTabP.UseVisualStyleBackColor = true;
            // 
            // seleccionarProyectosBtn
            // 
            this.seleccionarProyectosBtn.Enabled = false;
            this.seleccionarProyectosBtn.Location = new System.Drawing.Point(304, 9);
            this.seleccionarProyectosBtn.Name = "seleccionarProyectosBtn";
            this.seleccionarProyectosBtn.Size = new System.Drawing.Size(112, 23);
            this.seleccionarProyectosBtn.TabIndex = 20;
            this.seleccionarProyectosBtn.Text = "Seleccionar Todos";
            this.seleccionarProyectosBtn.UseVisualStyleBackColor = true;
            this.seleccionarProyectosBtn.Click += new System.EventHandler(this.seleccionarProyectosBtn_Click);
            // 
            // removerProyectosBtn
            // 
            this.removerProyectosBtn.Enabled = false;
            this.removerProyectosBtn.Location = new System.Drawing.Point(422, 9);
            this.removerProyectosBtn.Name = "removerProyectosBtn";
            this.removerProyectosBtn.Size = new System.Drawing.Size(104, 23);
            this.removerProyectosBtn.TabIndex = 19;
            this.removerProyectosBtn.Text = "Remover Todos";
            this.removerProyectosBtn.UseVisualStyleBackColor = true;
            this.removerProyectosBtn.Click += new System.EventHandler(this.removerProyectosBtn_Click);
            // 
            // proyectosDGW
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
            this.PesoProyecto});
            this.proyectoDGW.DataSource = this.proyectoBS;
            this.proyectoDGW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proyectoDGW.Enabled = false;
            this.proyectoDGW.Location = new System.Drawing.Point(0, 44);
            this.proyectoDGW.Name = "proyectosDGW";
            this.proyectoDGW.Size = new System.Drawing.Size(533, 415);
            this.proyectoDGW.TabIndex = 0;
            this.proyectoDGW.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.proyectoDGW_CellValueChanged);
            // 
            // proyectoBS
            // 
            this.proyectoBS.DataSource = typeof(SIFCA_DAL.PROYECTO);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(579, 490);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 11;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(497, 490);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 10;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
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
            // Crear_Proyecto_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIFCA.Properties.Resources.fondoTab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 525);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.crearProyectoTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Crear_Proyecto_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear proyecto";
            this.crearProyectoTab.ResumeLayout(false);
            this.proyectoTabP.ResumeLayout(false);
            this.DatosProyectoGbx.ResumeLayout(false);
            this.DatosProyectoGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInventarioBS)).EndInit();
            this.datosDAPGbx.ResumeLayout(false);
            this.datosDAPGbx.PerformLayout();
            this.otrosDatosGbx.ResumeLayout(false);
            this.otrosDatosGbx.PerformLayout();
            this.IntensidadGbx.ResumeLayout(false);
            this.IntensidadGbx.PerformLayout();
            this.AreaMuestreadaGbx.ResumeLayout(false);
            this.AreaMuestreadaGbx.PerformLayout();
            this.especiesTabP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.especiesDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBS)).EndInit();
            this.estratosTabP.ResumeLayout(false);
            this.estratosTabP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estratoDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBS)).EndInit();
            this.proyectosContTabP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl crearProyectoTab;
        private System.Windows.Forms.TabPage proyectoTabP;
        private System.Windows.Forms.GroupBox DatosProyectoGbx;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.ComboBox tipoDisenoCbx;
        private System.Windows.Forms.ComboBox tipoObjetivoCbx;
        private System.Windows.Forms.GroupBox datosDAPGbx;
        private System.Windows.Forms.TextBox limiteSupTxt;
        private System.Windows.Forms.TextBox limiteInfTxt;
        private System.Windows.Forms.GroupBox otrosDatosGbx;
        private System.Windows.Forms.TextBox factorFormaTxt;
        private System.Windows.Forms.TextBox areaFustalesTxt;
        private System.Windows.Forms.TextBox tamParcelaTxt;
        private System.Windows.Forms.GroupBox IntensidadGbx;
        private System.Windows.Forms.TextBox intMuestreoTxt;
        private System.Windows.Forms.GroupBox AreaMuestreadaGbx;
        private System.Windows.Forms.TextBox AreaMuestradaTxt;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMCOMUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMCIENTIFICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPESTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.TextBox numeroEtapasTxt;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button SeleccEstratosBtn;
        private System.Windows.Forms.Button removerEstratosBtn;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Proyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOMBRETIPOINV;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOMTIPODISEMUEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoProyecto;


    }
}