namespace SIFCA
{
    partial class Listar_Proyectos_Form
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
            System.Windows.Forms.Label lugarLbl;
            System.Windows.Forms.Label proyecto;
            System.Windows.Forms.Label tipoInvLbl;
            System.Windows.Forms.Label nomArchLbl;
            System.Windows.Forms.Label areaFustalesParcelaLbl;
            System.Windows.Forms.Label fACTORDEFORMALabel;
            System.Windows.Forms.Label intenMuetreoLbl;
            System.Windows.Forms.Label limiteInfLbl;
            System.Windows.Forms.Label limiSupLbl;
            System.Windows.Forms.Label superMuestreoLbl;
            System.Windows.Forms.Label supTotTxt;
            System.Windows.Forms.Label tamanoParcelaLbl;
            System.Windows.Forms.Label estacionLbl;
            System.Windows.Forms.Label estadoLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar_Proyectos_Form));
            this.proyectoBSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoBNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.AddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.SaveItem = new System.Windows.Forms.ToolStripButton();
            this.estacionBSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadoEspeciesBSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosGrx = new System.Windows.Forms.GroupBox();
            this.estadoCbx = new System.Windows.Forms.ComboBox();
            this.estacionCbx = new System.Windows.Forms.ComboBox();
            this.lugarTxt = new System.Windows.Forms.TextBox();
            this.nROPROYTextBox = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.tipoInvenCbx = new System.Windows.Forms.ComboBox();
            this.nomArchCbx = new System.Windows.Forms.ComboBox();
            this.AreaFustalesParcelaTxt = new System.Windows.Forms.TextBox();
            this.factorFormaTxt = new System.Windows.Forms.TextBox();
            this.intenMuestreoTxt = new System.Windows.Forms.TextBox();
            this.limitInfDapTxt = new System.Windows.Forms.TextBox();
            this.limiSupDapTxt = new System.Windows.Forms.TextBox();
            this.superMuestralTxt = new System.Windows.Forms.TextBox();
            this.superTotalTxt = new System.Windows.Forms.TextBox();
            this.tamanoParcelaTxt = new System.Windows.Forms.TextBox();
            this.tipoInventarioBSource = new System.Windows.Forms.BindingSource(this.components);
            lugarLbl = new System.Windows.Forms.Label();
            proyecto = new System.Windows.Forms.Label();
            tipoInvLbl = new System.Windows.Forms.Label();
            nomArchLbl = new System.Windows.Forms.Label();
            areaFustalesParcelaLbl = new System.Windows.Forms.Label();
            fACTORDEFORMALabel = new System.Windows.Forms.Label();
            intenMuetreoLbl = new System.Windows.Forms.Label();
            limiteInfLbl = new System.Windows.Forms.Label();
            limiSupLbl = new System.Windows.Forms.Label();
            superMuestreoLbl = new System.Windows.Forms.Label();
            supTotTxt = new System.Windows.Forms.Label();
            tamanoParcelaLbl = new System.Windows.Forms.Label();
            estacionLbl = new System.Windows.Forms.Label();
            estadoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBNavigator)).BeginInit();
            this.proyectoBNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEspeciesBSource)).BeginInit();
            this.proyectosGrx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoInventarioBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lugarLbl
            // 
            lugarLbl.AutoSize = true;
            lugarLbl.Location = new System.Drawing.Point(18, 51);
            lugarLbl.Name = "lugarLbl";
            lugarLbl.Size = new System.Drawing.Size(105, 13);
            lugarLbl.TabIndex = 71;
            lugarLbl.Text = "Lugar o Descripcion:";
            // 
            // proyecto
            // 
            proyecto.AutoSize = true;
            proyecto.Location = new System.Drawing.Point(18, 26);
            proyecto.Name = "proyecto";
            proyecto.Size = new System.Drawing.Size(52, 13);
            proyecto.TabIndex = 69;
            proyecto.Text = "Proyecto:";
            // 
            // tipoInvLbl
            // 
            tipoInvLbl.AutoSize = true;
            tipoInvLbl.Location = new System.Drawing.Point(18, 424);
            tipoInvLbl.Name = "tipoInvLbl";
            tipoInvLbl.Size = new System.Drawing.Size(81, 13);
            tipoInvLbl.TabIndex = 65;
            tipoInvLbl.Text = "Tipo Inventario:";
            // 
            // nomArchLbl
            // 
            nomArchLbl.AutoSize = true;
            nomArchLbl.Location = new System.Drawing.Point(19, 397);
            nomArchLbl.Name = "nomArchLbl";
            nomArchLbl.Size = new System.Drawing.Size(105, 13);
            nomArchLbl.TabIndex = 64;
            nomArchLbl.Text = "Listado de Especies:";
            // 
            // areaFustalesParcelaLbl
            // 
            areaFustalesParcelaLbl.AutoSize = true;
            areaFustalesParcelaLbl.Location = new System.Drawing.Point(18, 190);
            areaFustalesParcelaLbl.Name = "areaFustalesParcelaLbl";
            areaFustalesParcelaLbl.Size = new System.Drawing.Size(131, 13);
            areaFustalesParcelaLbl.TabIndex = 37;
            areaFustalesParcelaLbl.Text = "Area Fustales por Parcela:";
            // 
            // fACTORDEFORMALabel
            // 
            fACTORDEFORMALabel.AutoSize = true;
            fACTORDEFORMALabel.Location = new System.Drawing.Point(18, 214);
            fACTORDEFORMALabel.Name = "fACTORDEFORMALabel";
            fACTORDEFORMALabel.Size = new System.Drawing.Size(87, 13);
            fACTORDEFORMALabel.TabIndex = 41;
            fACTORDEFORMALabel.Text = "Factor de Forma:";
            // 
            // intenMuetreoLbl
            // 
            intenMuetreoLbl.AutoSize = true;
            intenMuetreoLbl.Location = new System.Drawing.Point(18, 238);
            intenMuetreoLbl.Name = "intenMuetreoLbl";
            intenMuetreoLbl.Size = new System.Drawing.Size(105, 13);
            intenMuetreoLbl.TabIndex = 43;
            intenMuetreoLbl.Text = "Intensidad muestreo:";
            // 
            // limiteInfLbl
            // 
            limiteInfLbl.AutoSize = true;
            limiteInfLbl.Location = new System.Drawing.Point(18, 264);
            limiteInfLbl.Name = "limiteInfLbl";
            limiteInfLbl.Size = new System.Drawing.Size(96, 13);
            limiteInfLbl.TabIndex = 45;
            limiteInfLbl.Text = "Limite inferior DAP:";
            // 
            // limiSupLbl
            // 
            limiSupLbl.AutoSize = true;
            limiSupLbl.Location = new System.Drawing.Point(18, 290);
            limiSupLbl.Name = "limiSupLbl";
            limiSupLbl.Size = new System.Drawing.Size(102, 13);
            limiSupLbl.TabIndex = 47;
            limiSupLbl.Text = "Limite superior DAP:";
            // 
            // superMuestreoLbl
            // 
            superMuestreoLbl.AutoSize = true;
            superMuestreoLbl.Location = new System.Drawing.Point(18, 316);
            superMuestreoLbl.Name = "superMuestreoLbl";
            superMuestreoLbl.Size = new System.Drawing.Size(100, 13);
            superMuestreoLbl.TabIndex = 59;
            superMuestreoLbl.Text = "Superficie Muestral:";
            // 
            // supTotTxt
            // 
            supTotTxt.AutoSize = true;
            supTotTxt.Location = new System.Drawing.Point(18, 342);
            supTotTxt.Name = "supTotTxt";
            supTotTxt.Size = new System.Drawing.Size(84, 13);
            supTotTxt.TabIndex = 61;
            supTotTxt.Text = "Superficie Total:";
            // 
            // tamanoParcelaLbl
            // 
            tamanoParcelaLbl.AutoSize = true;
            tamanoParcelaLbl.Location = new System.Drawing.Point(18, 368);
            tamanoParcelaLbl.Name = "tamanoParcelaLbl";
            tamanoParcelaLbl.Size = new System.Drawing.Size(88, 13);
            tamanoParcelaLbl.TabIndex = 63;
            tamanoParcelaLbl.Text = "Tamaño Parcela:";
            // 
            // estacionLbl
            // 
            estacionLbl.AutoSize = true;
            estacionLbl.Location = new System.Drawing.Point(19, 126);
            estacionLbl.Name = "estacionLbl";
            estacionLbl.Size = new System.Drawing.Size(51, 13);
            estacionLbl.TabIndex = 73;
            estacionLbl.Text = "Estacion:";
            // 
            // estadoLbl
            // 
            estadoLbl.AutoSize = true;
            estadoLbl.Location = new System.Drawing.Point(19, 157);
            estadoLbl.Name = "estadoLbl";
            estadoLbl.Size = new System.Drawing.Size(40, 13);
            estadoLbl.TabIndex = 75;
            estadoLbl.Text = "Estado";
            // 
            // proyectoBSource
            // 
            this.proyectoBSource.DataSource = typeof(SIFCA_DAL.PROYECTO);
            // 
            // proyectoBNavigator
            // 
            this.proyectoBNavigator.AddNewItem = this.AddNewItem;
            this.proyectoBNavigator.BindingSource = this.proyectoBSource;
            this.proyectoBNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proyectoBNavigator.DeleteItem = null;
            this.proyectoBNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.AddNewItem,
            this.DeleteItem,
            this.SaveItem});
            this.proyectoBNavigator.Location = new System.Drawing.Point(0, 0);
            this.proyectoBNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proyectoBNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proyectoBNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proyectoBNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proyectoBNavigator.Name = "proyectoBNavigator";
            this.proyectoBNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proyectoBNavigator.Size = new System.Drawing.Size(495, 25);
            this.proyectoBNavigator.TabIndex = 0;
            this.proyectoBNavigator.Text = "bindingNavigator1";
            // 
            // AddNewItem
            // 
            this.AddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("AddNewItem.Image")));
            this.AddNewItem.Name = "AddNewItem";
            this.AddNewItem.RightToLeftAutoMirrorImage = true;
            this.AddNewItem.Size = new System.Drawing.Size(23, 22);
            this.AddNewItem.Text = "Agregar nuevo";
            this.AddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // DeleteItem
            // 
            this.DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteItem.Image")));
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.RightToLeftAutoMirrorImage = true;
            this.DeleteItem.Size = new System.Drawing.Size(23, 22);
            this.DeleteItem.Text = "Eliminar";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // SaveItem
            // 
            this.SaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveItem.Image")));
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.Size = new System.Drawing.Size(23, 22);
            this.SaveItem.Text = "Guardar datos";
            this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // estacionBSource
            // 
            this.estacionBSource.DataSource = typeof(SIFCA_DAL.ESTACION);
            // 
            // listadoEspeciesBSource
            // 
            this.listadoEspeciesBSource.DataSource = typeof(SIFCA_DAL.LISTADODEESPECIES);
            // 
            // proyectosGrx
            // 
            this.proyectosGrx.Controls.Add(estadoLbl);
            this.proyectosGrx.Controls.Add(this.estadoCbx);
            this.proyectosGrx.Controls.Add(estacionLbl);
            this.proyectosGrx.Controls.Add(this.estacionCbx);
            this.proyectosGrx.Controls.Add(lugarLbl);
            this.proyectosGrx.Controls.Add(this.lugarTxt);
            this.proyectosGrx.Controls.Add(proyecto);
            this.proyectosGrx.Controls.Add(this.nROPROYTextBox);
            this.proyectosGrx.Controls.Add(this.cancelarBtn);
            this.proyectosGrx.Controls.Add(this.AceptarBtn);
            this.proyectosGrx.Controls.Add(tipoInvLbl);
            this.proyectosGrx.Controls.Add(this.tipoInvenCbx);
            this.proyectosGrx.Controls.Add(nomArchLbl);
            this.proyectosGrx.Controls.Add(this.nomArchCbx);
            this.proyectosGrx.Controls.Add(areaFustalesParcelaLbl);
            this.proyectosGrx.Controls.Add(this.AreaFustalesParcelaTxt);
            this.proyectosGrx.Controls.Add(fACTORDEFORMALabel);
            this.proyectosGrx.Controls.Add(this.factorFormaTxt);
            this.proyectosGrx.Controls.Add(intenMuetreoLbl);
            this.proyectosGrx.Controls.Add(this.intenMuestreoTxt);
            this.proyectosGrx.Controls.Add(limiteInfLbl);
            this.proyectosGrx.Controls.Add(this.limitInfDapTxt);
            this.proyectosGrx.Controls.Add(limiSupLbl);
            this.proyectosGrx.Controls.Add(this.limiSupDapTxt);
            this.proyectosGrx.Controls.Add(superMuestreoLbl);
            this.proyectosGrx.Controls.Add(this.superMuestralTxt);
            this.proyectosGrx.Controls.Add(supTotTxt);
            this.proyectosGrx.Controls.Add(this.superTotalTxt);
            this.proyectosGrx.Controls.Add(tamanoParcelaLbl);
            this.proyectosGrx.Controls.Add(this.tamanoParcelaTxt);
            this.proyectosGrx.Location = new System.Drawing.Point(13, 28);
            this.proyectosGrx.Name = "proyectosGrx";
            this.proyectosGrx.Size = new System.Drawing.Size(470, 487);
            this.proyectosGrx.TabIndex = 3;
            this.proyectosGrx.TabStop = false;
            this.proyectosGrx.Text = "Proyectos";
            // 
            // estadoCbx
            // 
            this.estadoCbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "ESTADOPROY", true));
            this.estadoCbx.FormattingEnabled = true;
            this.estadoCbx.Items.AddRange(new object[] {
            "A",
            "I"});
            this.estadoCbx.Location = new System.Drawing.Point(190, 154);
            this.estadoCbx.Name = "estadoCbx";
            this.estadoCbx.Size = new System.Drawing.Size(262, 21);
            this.estadoCbx.TabIndex = 76;
            // 
            // estacionCbx
            // 
            this.estacionCbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionBSource, "NOMBRE", true));
            this.estacionCbx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estacionBSource, "NROEST", true));
            this.estacionCbx.FormattingEnabled = true;
            this.estacionCbx.Location = new System.Drawing.Point(190, 126);
            this.estacionCbx.Name = "estacionCbx";
            this.estacionCbx.Size = new System.Drawing.Size(262, 21);
            this.estacionCbx.TabIndex = 74;
            // 
            // lugarTxt
            // 
            this.lugarTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "LUGAR", true));
            this.lugarTxt.Location = new System.Drawing.Point(190, 48);
            this.lugarTxt.Multiline = true;
            this.lugarTxt.Name = "lugarTxt";
            this.lugarTxt.Size = new System.Drawing.Size(262, 72);
            this.lugarTxt.TabIndex = 72;
            // 
            // nROPROYTextBox
            // 
            this.nROPROYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "NROPROY", true));
            this.nROPROYTextBox.Enabled = false;
            this.nROPROYTextBox.Location = new System.Drawing.Point(190, 23);
            this.nROPROYTextBox.Name = "nROPROYTextBox";
            this.nROPROYTextBox.Size = new System.Drawing.Size(262, 20);
            this.nROPROYTextBox.TabIndex = 70;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(377, 448);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 11;
            this.cancelarBtn.Text = "Salir";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(296, 448);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 10;
            this.AceptarBtn.Text = "Guardar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // tipoInvenCbx
            // 
            this.tipoInvenCbx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoInventarioBSource, "NOMBRETIPOINV", true));
            this.tipoInvenCbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoInventarioBSource, "DESCRIPTIPOINV", true));
            this.tipoInvenCbx.FormattingEnabled = true;
            this.tipoInvenCbx.Location = new System.Drawing.Point(190, 421);
            this.tipoInvenCbx.Name = "tipoInvenCbx";
            this.tipoInvenCbx.Size = new System.Drawing.Size(262, 21);
            this.tipoInvenCbx.TabIndex = 66;
            // 
            // nomArchCbx
            // 
            this.nomArchCbx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listadoEspeciesBSource, "NOMARCH", true));
            this.nomArchCbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadoEspeciesBSource, "NOMARCH", true));
            this.nomArchCbx.FormattingEnabled = true;
            this.nomArchCbx.Location = new System.Drawing.Point(190, 394);
            this.nomArchCbx.Name = "nomArchCbx";
            this.nomArchCbx.Size = new System.Drawing.Size(262, 21);
            this.nomArchCbx.TabIndex = 65;
            // 
            // AreaFustalesParcelaTxt
            // 
            this.AreaFustalesParcelaTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "AREAFUSTALESPORPARCELA", true));
            this.AreaFustalesParcelaTxt.Location = new System.Drawing.Point(190, 187);
            this.AreaFustalesParcelaTxt.Name = "AreaFustalesParcelaTxt";
            this.AreaFustalesParcelaTxt.Size = new System.Drawing.Size(262, 20);
            this.AreaFustalesParcelaTxt.TabIndex = 38;
            // 
            // factorFormaTxt
            // 
            this.factorFormaTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "FACTORDEFORMA", true));
            this.factorFormaTxt.Location = new System.Drawing.Point(190, 211);
            this.factorFormaTxt.Name = "factorFormaTxt";
            this.factorFormaTxt.Size = new System.Drawing.Size(262, 20);
            this.factorFormaTxt.TabIndex = 42;
            // 
            // intenMuestreoTxt
            // 
            this.intenMuestreoTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "INTMUE", true));
            this.intenMuestreoTxt.Location = new System.Drawing.Point(190, 235);
            this.intenMuestreoTxt.Name = "intenMuestreoTxt";
            this.intenMuestreoTxt.Size = new System.Drawing.Size(262, 20);
            this.intenMuestreoTxt.TabIndex = 44;
            // 
            // limitInfDapTxt
            // 
            this.limitInfDapTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "LIMTINFDAP", true));
            this.limitInfDapTxt.Location = new System.Drawing.Point(190, 261);
            this.limitInfDapTxt.Name = "limitInfDapTxt";
            this.limitInfDapTxt.Size = new System.Drawing.Size(262, 20);
            this.limitInfDapTxt.TabIndex = 46;
            // 
            // limiSupDapTxt
            // 
            this.limiSupDapTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "LIMTSUPDAP", true));
            this.limiSupDapTxt.Location = new System.Drawing.Point(190, 287);
            this.limiSupDapTxt.Name = "limiSupDapTxt";
            this.limiSupDapTxt.Size = new System.Drawing.Size(262, 20);
            this.limiSupDapTxt.TabIndex = 48;
            // 
            // superMuestralTxt
            // 
            this.superMuestralTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "SUPMUE", true));
            this.superMuestralTxt.Location = new System.Drawing.Point(190, 313);
            this.superMuestralTxt.Name = "superMuestralTxt";
            this.superMuestralTxt.Size = new System.Drawing.Size(262, 20);
            this.superMuestralTxt.TabIndex = 60;
            // 
            // superTotalTxt
            // 
            this.superTotalTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "SUPTOT", true));
            this.superTotalTxt.Location = new System.Drawing.Point(190, 339);
            this.superTotalTxt.Name = "superTotalTxt";
            this.superTotalTxt.Size = new System.Drawing.Size(262, 20);
            this.superTotalTxt.TabIndex = 62;
            // 
            // tamanoParcelaTxt
            // 
            this.tamanoParcelaTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBSource, "TAMANO", true));
            this.tamanoParcelaTxt.Location = new System.Drawing.Point(190, 365);
            this.tamanoParcelaTxt.Name = "tamanoParcelaTxt";
            this.tamanoParcelaTxt.Size = new System.Drawing.Size(262, 20);
            this.tamanoParcelaTxt.TabIndex = 64;
            // 
            // tipoInventarioBSource
            // 
            this.tipoInventarioBSource.DataSource = typeof(SIFCA_DAL.TIPOINVENTARIO);
            // 
            // Listar_Proyectos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 526);
            this.Controls.Add(this.proyectosGrx);
            this.Controls.Add(this.proyectoBNavigator);
            this.Name = "Listar_Proyectos_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBNavigator)).EndInit();
            this.proyectoBNavigator.ResumeLayout(false);
            this.proyectoBNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEspeciesBSource)).EndInit();
            this.proyectosGrx.ResumeLayout(false);
            this.proyectosGrx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoInventarioBSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource proyectoBSource;
        private System.Windows.Forms.BindingNavigator proyectoBNavigator;
        private System.Windows.Forms.ToolStripButton AddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton DeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton SaveItem;
        private System.Windows.Forms.BindingSource estacionBSource;
        private System.Windows.Forms.BindingSource listadoEspeciesBSource;
        private System.Windows.Forms.GroupBox proyectosGrx;
        private System.Windows.Forms.ComboBox estacionCbx;
        private System.Windows.Forms.TextBox lugarTxt;
        private System.Windows.Forms.TextBox nROPROYTextBox;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.ComboBox tipoInvenCbx;
        private System.Windows.Forms.ComboBox nomArchCbx;
        private System.Windows.Forms.TextBox AreaFustalesParcelaTxt;
        private System.Windows.Forms.TextBox factorFormaTxt;
        private System.Windows.Forms.TextBox intenMuestreoTxt;
        private System.Windows.Forms.TextBox limitInfDapTxt;
        private System.Windows.Forms.TextBox limiSupDapTxt;
        private System.Windows.Forms.TextBox superMuestralTxt;
        private System.Windows.Forms.TextBox superTotalTxt;
        private System.Windows.Forms.TextBox tamanoParcelaTxt;
        private System.Windows.Forms.ComboBox estadoCbx;
        private System.Windows.Forms.BindingSource tipoInventarioBSource;
    }
}