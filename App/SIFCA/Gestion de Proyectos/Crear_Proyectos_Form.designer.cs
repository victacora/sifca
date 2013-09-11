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
            this.crearProyectoTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DatosProyectoGbx = new System.Windows.Forms.GroupBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.tipoDisenoCbx = new System.Windows.Forms.ComboBox();
            this.tipoDisenoBS = new System.Windows.Forms.BindingSource(this.components);
            this.tipoObjetivoCbx = new System.Windows.Forms.ComboBox();
            this.objetivoInventarioBS = new System.Windows.Forms.BindingSource(this.components);
            this.datosDAPGbx = new System.Windows.Forms.GroupBox();
            this.limiteSupTxt = new System.Windows.Forms.TextBox();
            this.limiteInfTxt = new System.Windows.Forms.TextBox();
            this.otrosDatosGbx = new System.Windows.Forms.GroupBox();
            this.factorFormaTxt = new System.Windows.Forms.TextBox();
            this.areaFustalesTxt = new System.Windows.Forms.TextBox();
            this.tamParcelaTxt = new System.Windows.Forms.TextBox();
            this.IntensidadGbx = new System.Windows.Forms.GroupBox();
            this.intMuestreoTxt = new System.Windows.Forms.TextBox();
            this.AreaMuestreadaGbx = new System.Windows.Forms.GroupBox();
            this.AreaMuestradaTxt = new System.Windows.Forms.TextBox();
            this.lugarTxt = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.seleccEspecieBtn = new System.Windows.Forms.Button();
            this.RemoverEspciesBtn = new System.Windows.Forms.Button();
            this.especiesDGW = new System.Windows.Forms.DataGridView();
            this.especieBS = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SeleccEstratosBtn = new System.Windows.Forms.Button();
            this.removerEstratosBtn = new System.Windows.Forms.Button();
            this.estratoDGW = new System.Windows.Forms.DataGridView();
            this.estratoBS = new System.Windows.Forms.BindingSource(this.components);
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.atrasBtn = new System.Windows.Forms.Button();
            this.Especie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrato = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.crearProyectoTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.DatosProyectoGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInventarioBS)).BeginInit();
            this.datosDAPGbx.SuspendLayout();
            this.otrosDatosGbx.SuspendLayout();
            this.IntensidadGbx.SuspendLayout();
            this.AreaMuestreadaGbx.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especiesDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBS)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estratoDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBS)).BeginInit();
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
            DAPLbl.Location = new System.Drawing.Point(41, 22);
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
            porcentajeLbl.Location = new System.Drawing.Point(114, 22);
            porcentajeLbl.Name = "porcentajeLbl";
            porcentajeLbl.Size = new System.Drawing.Size(15, 13);
            porcentajeLbl.TabIndex = 24;
            porcentajeLbl.Text = "%";
            // 
            // HectareasLbl
            // 
            HectareasLbl.AutoSize = true;
            HectareasLbl.Location = new System.Drawing.Point(98, 22);
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
            TipoDisenoLbl.Location = new System.Drawing.Point(11, 149);
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
            // crearProyectoTab
            // 
            this.crearProyectoTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.crearProyectoTab.Controls.Add(this.tabPage2);
            this.crearProyectoTab.Controls.Add(this.tabPage1);
            this.crearProyectoTab.Controls.Add(this.tabPage3);
            this.crearProyectoTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.crearProyectoTab.ItemSize = new System.Drawing.Size(30, 120);
            this.crearProyectoTab.Location = new System.Drawing.Point(-3, -1);
            this.crearProyectoTab.Multiline = true;
            this.crearProyectoTab.Name = "crearProyectoTab";
            this.crearProyectoTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.crearProyectoTab.SelectedIndex = 0;
            this.crearProyectoTab.Size = new System.Drawing.Size(585, 460);
            this.crearProyectoTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.crearProyectoTab.TabIndex = 0;
            this.crearProyectoTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.crearProyectoTab_DrawItem);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DatosProyectoGbx);
            this.tabPage2.Location = new System.Drawing.Point(124, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(457, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos del proyecto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DatosProyectoGbx
            // 
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
            this.DatosProyectoGbx.Location = new System.Drawing.Point(17, 6);
            this.DatosProyectoGbx.Name = "DatosProyectoGbx";
            this.DatosProyectoGbx.Size = new System.Drawing.Size(436, 434);
            this.DatosProyectoGbx.TabIndex = 3;
            this.DatosProyectoGbx.TabStop = false;
            this.DatosProyectoGbx.Text = "Definicion del proyecto";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(145, 50);
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(279, 62);
            this.DescripcionTxt.TabIndex = 26;
            // 
            // tipoDisenoCbx
            // 
            this.tipoDisenoCbx.DataSource = this.tipoDisenoBS;
            this.tipoDisenoCbx.DisplayMember = "DESCRIPTIPODISEMUEST";
            this.tipoDisenoCbx.FormattingEnabled = true;
            this.tipoDisenoCbx.Location = new System.Drawing.Point(145, 146);
            this.tipoDisenoCbx.Name = "tipoDisenoCbx";
            this.tipoDisenoCbx.Size = new System.Drawing.Size(279, 21);
            this.tipoDisenoCbx.TabIndex = 23;
            this.tipoDisenoCbx.ValueMember = "NOMTIPODISEMUEST";
            // 
            // tipoDisenoBS
            // 
            this.tipoDisenoBS.DataSource = typeof(SIFCA_DAL.TIPODISENOMUESTRAL);
            // 
            // tipoObjetivoCbx
            // 
            this.tipoObjetivoCbx.DataSource = this.objetivoInventarioBS;
            this.tipoObjetivoCbx.DisplayMember = "DESCRIPOBJETINV";
            this.tipoObjetivoCbx.FormattingEnabled = true;
            this.tipoObjetivoCbx.Location = new System.Drawing.Point(145, 118);
            this.tipoObjetivoCbx.Name = "tipoObjetivoCbx";
            this.tipoObjetivoCbx.Size = new System.Drawing.Size(279, 21);
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
            this.datosDAPGbx.Location = new System.Drawing.Point(6, 192);
            this.datosDAPGbx.Name = "datosDAPGbx";
            this.datosDAPGbx.Size = new System.Drawing.Size(135, 53);
            this.datosDAPGbx.TabIndex = 22;
            this.datosDAPGbx.TabStop = false;
            this.datosDAPGbx.Text = "Limites DAP (cms)";
            // 
            // limiteSupTxt
            // 
            this.limiteSupTxt.Location = new System.Drawing.Point(95, 19);
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
            this.otrosDatosGbx.Controls.Add(facFormaLbl);
            this.otrosDatosGbx.Controls.Add(this.factorFormaTxt);
            this.otrosDatosGbx.Controls.Add(areaFustalesLbl);
            this.otrosDatosGbx.Controls.Add(this.areaFustalesTxt);
            this.otrosDatosGbx.Controls.Add(tamanioParLbl);
            this.otrosDatosGbx.Controls.Add(this.tamParcelaTxt);
            this.otrosDatosGbx.Location = new System.Drawing.Point(6, 251);
            this.otrosDatosGbx.Name = "otrosDatosGbx";
            this.otrosDatosGbx.Size = new System.Drawing.Size(418, 127);
            this.otrosDatosGbx.TabIndex = 22;
            this.otrosDatosGbx.TabStop = false;
            // 
            // factorFormaTxt
            // 
            this.factorFormaTxt.Location = new System.Drawing.Point(139, 76);
            this.factorFormaTxt.Name = "factorFormaTxt";
            this.factorFormaTxt.Size = new System.Drawing.Size(264, 20);
            this.factorFormaTxt.TabIndex = 9;
            this.factorFormaTxt.Text = "0.000";
            // 
            // areaFustalesTxt
            // 
            this.areaFustalesTxt.Location = new System.Drawing.Point(139, 50);
            this.areaFustalesTxt.Name = "areaFustalesTxt";
            this.areaFustalesTxt.Size = new System.Drawing.Size(264, 20);
            this.areaFustalesTxt.TabIndex = 7;
            this.areaFustalesTxt.Text = "1.000";
            // 
            // tamParcelaTxt
            // 
            this.tamParcelaTxt.Location = new System.Drawing.Point(139, 24);
            this.tamParcelaTxt.Name = "tamParcelaTxt";
            this.tamParcelaTxt.Size = new System.Drawing.Size(264, 20);
            this.tamParcelaTxt.TabIndex = 5;
            this.tamParcelaTxt.Text = "1";
            // 
            // IntensidadGbx
            // 
            this.IntensidadGbx.Controls.Add(porcentajeLbl);
            this.IntensidadGbx.Controls.Add(this.intMuestreoTxt);
            this.IntensidadGbx.Location = new System.Drawing.Point(150, 192);
            this.IntensidadGbx.Name = "IntensidadGbx";
            this.IntensidadGbx.Size = new System.Drawing.Size(135, 53);
            this.IntensidadGbx.TabIndex = 21;
            this.IntensidadGbx.TabStop = false;
            this.IntensidadGbx.Text = "Intensidad del muestreo";
            // 
            // intMuestreoTxt
            // 
            this.intMuestreoTxt.Location = new System.Drawing.Point(6, 19);
            this.intMuestreoTxt.Name = "intMuestreoTxt";
            this.intMuestreoTxt.Size = new System.Drawing.Size(103, 20);
            this.intMuestreoTxt.TabIndex = 6;
            this.intMuestreoTxt.Text = "10.000";
            // 
            // AreaMuestreadaGbx
            // 
            this.AreaMuestreadaGbx.Controls.Add(HectareasLbl);
            this.AreaMuestreadaGbx.Controls.Add(this.AreaMuestradaTxt);
            this.AreaMuestreadaGbx.Location = new System.Drawing.Point(291, 192);
            this.AreaMuestreadaGbx.Name = "AreaMuestreadaGbx";
            this.AreaMuestreadaGbx.Size = new System.Drawing.Size(133, 53);
            this.AreaMuestreadaGbx.TabIndex = 20;
            this.AreaMuestreadaGbx.TabStop = false;
            this.AreaMuestreadaGbx.Text = "Area muestreada";
            // 
            // AreaMuestradaTxt
            // 
            this.AreaMuestradaTxt.Location = new System.Drawing.Point(6, 19);
            this.AreaMuestradaTxt.Name = "AreaMuestradaTxt";
            this.AreaMuestradaTxt.Size = new System.Drawing.Size(86, 20);
            this.AreaMuestradaTxt.TabIndex = 5;
            this.AreaMuestradaTxt.Text = "1.000";
            // 
            // lugarTxt
            // 
            this.lugarTxt.Location = new System.Drawing.Point(145, 23);
            this.lugarTxt.Name = "lugarTxt";
            this.lugarTxt.Size = new System.Drawing.Size(279, 20);
            this.lugarTxt.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.seleccEspecieBtn);
            this.tabPage1.Controls.Add(this.RemoverEspciesBtn);
            this.tabPage1.Controls.Add(this.especiesDGW);
            this.tabPage1.Location = new System.Drawing.Point(124, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 452);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Listado de Especies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // seleccEspecieBtn
            // 
            this.seleccEspecieBtn.Location = new System.Drawing.Point(227, 9);
            this.seleccEspecieBtn.Name = "seleccEspecieBtn";
            this.seleccEspecieBtn.Size = new System.Drawing.Size(112, 23);
            this.seleccEspecieBtn.TabIndex = 16;
            this.seleccEspecieBtn.Text = "Seleccionar Todos";
            this.seleccEspecieBtn.UseVisualStyleBackColor = true;
            // 
            // RemoverEspciesBtn
            // 
            this.RemoverEspciesBtn.Location = new System.Drawing.Point(345, 9);
            this.RemoverEspciesBtn.Name = "RemoverEspciesBtn";
            this.RemoverEspciesBtn.Size = new System.Drawing.Size(104, 23);
            this.RemoverEspciesBtn.TabIndex = 14;
            this.RemoverEspciesBtn.Text = "Remover Todos";
            this.RemoverEspciesBtn.UseVisualStyleBackColor = true;
            // 
            // especiesDGW
            // 
            this.especiesDGW.AutoGenerateColumns = false;
            this.especiesDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.especiesDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especiesDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Especie,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.especiesDGW.DataSource = this.especieBS;
            this.especiesDGW.Location = new System.Drawing.Point(3, 38);
            this.especiesDGW.Name = "especiesDGW";
            this.especiesDGW.Size = new System.Drawing.Size(446, 414);
            this.especiesDGW.TabIndex = 0;
            // 
            // especieBS
            // 
            this.especieBS.DataSource = typeof(SIFCA_DAL.ESPECIE);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SeleccEstratosBtn);
            this.tabPage3.Controls.Add(this.removerEstratosBtn);
            this.tabPage3.Controls.Add(this.estratoDGW);
            this.tabPage3.Location = new System.Drawing.Point(124, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(457, 452);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Listado de Estratos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SeleccEstratosBtn
            // 
            this.SeleccEstratosBtn.Location = new System.Drawing.Point(229, 9);
            this.SeleccEstratosBtn.Name = "SeleccEstratosBtn";
            this.SeleccEstratosBtn.Size = new System.Drawing.Size(112, 23);
            this.SeleccEstratosBtn.TabIndex = 18;
            this.SeleccEstratosBtn.Text = "Seleccionar Todos";
            this.SeleccEstratosBtn.UseVisualStyleBackColor = true;
            // 
            // removerEstratosBtn
            // 
            this.removerEstratosBtn.Location = new System.Drawing.Point(347, 9);
            this.removerEstratosBtn.Name = "removerEstratosBtn";
            this.removerEstratosBtn.Size = new System.Drawing.Size(104, 23);
            this.removerEstratosBtn.TabIndex = 17;
            this.removerEstratosBtn.Text = "Remover Todos";
            this.removerEstratosBtn.UseVisualStyleBackColor = true;
            // 
            // estratoDGW
            // 
            this.estratoDGW.AutoGenerateColumns = false;
            this.estratoDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.estratoDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estratoDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estrato,
            this.dataGridViewTextBoxColumn2,
            this.Peso});
            this.estratoDGW.DataSource = this.estratoBS;
            this.estratoDGW.Location = new System.Drawing.Point(6, 38);
            this.estratoDGW.Name = "estratoDGW";
            this.estratoDGW.Size = new System.Drawing.Size(445, 414);
            this.estratoDGW.TabIndex = 0;
            // 
            // estratoBS
            // 
            this.estratoBS.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(499, 470);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 11;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(417, 470);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 10;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Location = new System.Drawing.Point(336, 470);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(75, 23);
            this.siguienteBtn.TabIndex = 13;
            this.siguienteBtn.Text = "Siguiente";
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // atrasBtn
            // 
            this.atrasBtn.Location = new System.Drawing.Point(254, 470);
            this.atrasBtn.Name = "atrasBtn";
            this.atrasBtn.Size = new System.Drawing.Size(75, 23);
            this.atrasBtn.TabIndex = 12;
            this.atrasBtn.Text = "Atras";
            this.atrasBtn.UseVisualStyleBackColor = true;
            this.atrasBtn.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Seleccion";
            this.Especie.Name = "Especie";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NOMCOMUN";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre Comun";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NOMCIENTIFICO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre Cientifico";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FAMILIA";
            this.dataGridViewTextBoxColumn6.HeaderText = "Familia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Estrato
            // 
            this.Estrato.HeaderText = "Estratos";
            this.Estrato.Name = "Estrato";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPESTRATO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // Crear_Proyecto_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIFCA.Properties.Resources.fondoTab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 505);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.atrasBtn);
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
            this.tabPage2.ResumeLayout(false);
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.especiesDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBS)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estratoDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl crearProyectoTab;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource tipoDisenoBS;
        private System.Windows.Forms.BindingSource objetivoInventarioBS;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Button atrasBtn;
        private System.Windows.Forms.BindingSource especieBS;
        private System.Windows.Forms.DataGridView estratoDGW;
        private System.Windows.Forms.BindingSource estratoBS;
        private System.Windows.Forms.DataGridView especiesDGW;
        private System.Windows.Forms.Button seleccEspecieBtn;
        private System.Windows.Forms.Button RemoverEspciesBtn;
        private System.Windows.Forms.Button SeleccEstratosBtn;
        private System.Windows.Forms.Button removerEstratosBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;


    }
}