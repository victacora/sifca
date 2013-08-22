namespace SIFCA
{
    partial class GestDatInv_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestDatInv_Form));
            this.inventarioBNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.inventarioBSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iNVENTARIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buscarLbl = new System.Windows.Forms.ToolStripLabel();
            this.parametroBusTxt = new System.Windows.Forms.ToolStripTextBox();
            this.filtrarLbl = new System.Windows.Forms.ToolStripLabel();
            this.criterioBusquedaCbx = new System.Windows.Forms.ToolStripComboBox();
            this.filtrarEspLbl = new System.Windows.Forms.ToolStripLabel();
            this.especiesCbx = new System.Windows.Forms.ToolStripComboBox();
            this.inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.estacionBSource = new System.Windows.Forms.BindingSource(this.components);
            this.etapaBSource = new System.Windows.Forms.BindingSource(this.components);
            this.estratoBSource = new System.Windows.Forms.BindingSource(this.components);
            this.especieBSource = new System.Windows.Forms.BindingSource(this.components);
            this.calidadBSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSaniBSource = new System.Windows.Forms.BindingSource(this.components);
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Estrato = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Calidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBNavigator)).BeginInit();
            this.inventarioBNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calidadBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSaniBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioBNavigator
            // 
            this.inventarioBNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventarioBNavigator.BindingSource = this.inventarioBSource;
            this.inventarioBNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventarioBNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventarioBNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.iNVENTARIOBindingNavigatorSaveItem,
            this.buscarLbl,
            this.parametroBusTxt,
            this.filtrarLbl,
            this.criterioBusquedaCbx,
            this.filtrarEspLbl,
            this.especiesCbx});
            this.inventarioBNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventarioBNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventarioBNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventarioBNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventarioBNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventarioBNavigator.Name = "inventarioBNavigator";
            this.inventarioBNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventarioBNavigator.Size = new System.Drawing.Size(1134, 25);
            this.inventarioBNavigator.TabIndex = 0;
            this.inventarioBNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            // 
            // inventarioBSource
            // 
            this.inventarioBSource.DataSource = typeof(SIFCA_DAL.INVENTARIO);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iNVENTARIOBindingNavigatorSaveItem
            // 
            this.iNVENTARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iNVENTARIOBindingNavigatorSaveItem.Enabled = false;
            this.iNVENTARIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iNVENTARIOBindingNavigatorSaveItem.Image")));
            this.iNVENTARIOBindingNavigatorSaveItem.Name = "iNVENTARIOBindingNavigatorSaveItem";
            this.iNVENTARIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            // 
            // buscarLbl
            // 
            this.buscarLbl.Name = "buscarLbl";
            this.buscarLbl.Size = new System.Drawing.Size(45, 22);
            this.buscarLbl.Text = "Buscar:";
            // 
            // parametroBusTxt
            // 
            this.parametroBusTxt.Name = "parametroBusTxt";
            this.parametroBusTxt.Size = new System.Drawing.Size(150, 25);
            // 
            // filtrarLbl
            // 
            this.filtrarLbl.Name = "filtrarLbl";
            this.filtrarLbl.Size = new System.Drawing.Size(92, 22);
            this.filtrarLbl.Text = "Filtrar busqueda";
            // 
            // criterioBusquedaCbx
            // 
            this.criterioBusquedaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterioBusquedaCbx.Items.AddRange(new object[] {
            "Estacion",
            "Etapa",
            "Estrato",
            "Arbol",
            "Especie",
            "Estado"});
            this.criterioBusquedaCbx.Name = "criterioBusquedaCbx";
            this.criterioBusquedaCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // filtrarEspLbl
            // 
            this.filtrarEspLbl.Name = "filtrarEspLbl";
            this.filtrarEspLbl.Size = new System.Drawing.Size(84, 22);
            this.filtrarEspLbl.Text = "Filtrar Especies";
            // 
            // especiesCbx
            // 
            this.especiesCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especiesCbx.Items.AddRange(new object[] {
            "Nombre comun",
            "Nombre Cientifico"});
            this.especiesCbx.Name = "especiesCbx";
            this.especiesCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // inventarioDataGridView
            // 
            this.inventarioDataGridView.AutoGenerateColumns = false;
            this.inventarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proyecto,
            this.Estacion,
            this.Etapa,
            this.Estrato,
            this.Parcela,
            this.Arbol,
            this.Especie,
            this.Calidad,
            this.Estado,
            this.CAP,
            this.DAP,
            this.AltComercial,
            this.AltTotal,
            this.AB,
            this.VolComercial,
            this.VolTotal});
            this.inventarioDataGridView.DataSource = this.inventarioBSource;
            this.inventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventarioDataGridView.Location = new System.Drawing.Point(0, 25);
            this.inventarioDataGridView.Name = "inventarioDataGridView";
            this.inventarioDataGridView.Size = new System.Drawing.Size(1134, 406);
            this.inventarioDataGridView.TabIndex = 1;
            // 
            // estacionBSource
            // 
            this.estacionBSource.DataSource = typeof(SIFCA_DAL.ESTACION);
            // 
            // etapaBSource
            // 
            this.etapaBSource.DataSource = typeof(SIFCA_DAL.ETAPA);
            // 
            // estratoBSource
            // 
            this.estratoBSource.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // especieBSource
            // 
            this.especieBSource.DataSource = typeof(SIFCA_DAL.ESPECIE);
            // 
            // calidadBSource
            // 
            this.calidadBSource.DataSource = typeof(SIFCA_DAL.CALIDAD);
            // 
            // estadoSaniBSource
            // 
            this.estadoSaniBSource.DataSource = typeof(SIFCA_DAL.ESTADOSANITARIO);
            // 
            // Proyecto
            // 
            this.Proyecto.DataPropertyName = "NROPROY";
            this.Proyecto.FillWeight = 74.17937F;
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            // 
            // Estacion
            // 
            this.Estacion.DataPropertyName = "NROEST";
            this.Estacion.DataSource = this.estacionBSource;
            this.Estacion.DisplayMember = "NOMBRE";
            this.Estacion.FillWeight = 74.17937F;
            this.Estacion.HeaderText = "Estacion";
            this.Estacion.Name = "Estacion";
            this.Estacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Estacion.ValueMember = "NROEST";
            // 
            // Etapa
            // 
            this.Etapa.DataPropertyName = "CODETAPA";
            this.Etapa.DataSource = this.etapaBSource;
            this.Etapa.DisplayMember = "CODETAPA";
            this.Etapa.FillWeight = 74.17937F;
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.Name = "Etapa";
            this.Etapa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Etapa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Etapa.ValueMember = "CODETAPA";
            // 
            // Estrato
            // 
            this.Estrato.DataPropertyName = "CODEST";
            this.Estrato.DataSource = this.estratoBSource;
            this.Estrato.DisplayMember = "CODEST";
            this.Estrato.FillWeight = 74.17937F;
            this.Estrato.HeaderText = "Estrato";
            this.Estrato.Name = "Estrato";
            this.Estrato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estrato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Estrato.ValueMember = "CODEST";
            // 
            // Parcela
            // 
            this.Parcela.DataPropertyName = "PARCELA";
            this.Parcela.FillWeight = 74.17937F;
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            // 
            // Arbol
            // 
            this.Arbol.DataPropertyName = "NROARB";
            this.Arbol.FillWeight = 74.17937F;
            this.Arbol.HeaderText = "Arbol";
            this.Arbol.Name = "Arbol";
            // 
            // Especie
            // 
            this.Especie.DataPropertyName = "CODESP";
            this.Especie.DataSource = this.especieBSource;
            this.Especie.DisplayMember = "NOMCOMUN";
            this.Especie.FillWeight = 74.17937F;
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Especie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Especie.ValueMember = "CODESP";
            // 
            // Calidad
            // 
            this.Calidad.DataPropertyName = "CODCALIDAD";
            this.Calidad.DataSource = this.calidadBSource;
            this.Calidad.DisplayMember = "CODCALIDAD";
            this.Calidad.FillWeight = 74.17937F;
            this.Calidad.HeaderText = "Calidad";
            this.Calidad.Name = "Calidad";
            this.Calidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Calidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Calidad.ValueMember = "CODCALIDAD";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "ESTADO";
            this.Estado.DataSource = this.estadoSaniBSource;
            this.Estado.DisplayMember = "ESTADO";
            this.Estado.FillWeight = 74.17937F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Estado.ValueMember = "ESTADO";
            // 
            // CAP
            // 
            this.CAP.DataPropertyName = "CAP";
            this.CAP.FillWeight = 74.17937F;
            this.CAP.HeaderText = "CAP";
            this.CAP.Name = "CAP";
            // 
            // DAP
            // 
            this.DAP.DataPropertyName = "DAP";
            this.DAP.FillWeight = 74.17937F;
            this.DAP.HeaderText = "DAP";
            this.DAP.Name = "DAP";
            // 
            // AltComercial
            // 
            this.AltComercial.DataPropertyName = "ALTCOMER_M";
            this.AltComercial.FillWeight = 74.17937F;
            this.AltComercial.HeaderText = "Alt. Comercial";
            this.AltComercial.Name = "AltComercial";
            // 
            // AltTotal
            // 
            this.AltTotal.DataPropertyName = "ALTTOT_M";
            this.AltTotal.FillWeight = 74.17937F;
            this.AltTotal.HeaderText = "Alt. Total";
            this.AltTotal.Name = "AltTotal";
            // 
            // AB
            // 
            this.AB.DataPropertyName = "AREABASAL";
            this.AB.FillWeight = 74.17937F;
            this.AB.HeaderText = "Area basal";
            this.AB.Name = "AB";
            // 
            // VolComercial
            // 
            this.VolComercial.DataPropertyName = "VOLCOM";
            this.VolComercial.FillWeight = 74.17937F;
            this.VolComercial.HeaderText = "Vol. Comercial";
            this.VolComercial.Name = "VolComercial";
            // 
            // VolTotal
            // 
            this.VolTotal.DataPropertyName = "VOLTOT";
            this.VolTotal.FillWeight = 74.17937F;
            this.VolTotal.HeaderText = "Vol. Total";
            this.VolTotal.Name = "VolTotal";
            // 
            // GestDatInv_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 431);
            this.Controls.Add(this.inventarioDataGridView);
            this.Controls.Add(this.inventarioBNavigator);
            this.Name = "GestDatInv_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos inventario";
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBNavigator)).EndInit();
            this.inventarioBNavigator.ResumeLayout(false);
            this.inventarioBNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratoBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calidadBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSaniBSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource inventarioBSource;
        private System.Windows.Forms.BindingNavigator inventarioBNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton iNVENTARIOBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel buscarLbl;
        private System.Windows.Forms.ToolStripTextBox parametroBusTxt;
        private System.Windows.Forms.ToolStripLabel filtrarEspLbl;
        private System.Windows.Forms.ToolStripComboBox especiesCbx;
        private System.Windows.Forms.DataGridView inventarioDataGridView;
        private System.Windows.Forms.ToolStripLabel filtrarLbl;
        private System.Windows.Forms.ToolStripComboBox criterioBusquedaCbx;
        private System.Windows.Forms.BindingSource especieBSource;
        private System.Windows.Forms.BindingSource estacionBSource;
        private System.Windows.Forms.BindingSource etapaBSource;
        private System.Windows.Forms.BindingSource estratoBSource;
        private System.Windows.Forms.BindingSource calidadBSource;
        private System.Windows.Forms.BindingSource estadoSaniBSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estacion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arbol;
        private System.Windows.Forms.DataGridViewComboBoxColumn Especie;
        private System.Windows.Forms.DataGridViewComboBoxColumn Calidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AB;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolTotal;

    }
}