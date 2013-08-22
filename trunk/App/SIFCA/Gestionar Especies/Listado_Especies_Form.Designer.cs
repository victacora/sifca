namespace SIFCA
{
    partial class Listado_Especies_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Especies_Form));
            this.paginacionEspecie = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.ListadoEspecies = new System.Windows.Forms.DataGridView();
            this.cODESPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPOCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCOMUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCIENTIFICODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMILIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zONAGEOGRAFICADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zONADEVIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIAMMINCORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPOCOMERCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGENERACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lISTADODEESPECIESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especieBSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarLbl = new System.Windows.Forms.ToolStripLabel();
            this.parametroBusTxt = new System.Windows.Forms.ToolStripTextBox();
            this.filtrarLbl = new System.Windows.Forms.ToolStripLabel();
            this.criterioBusquedaCbx = new System.Windows.Forms.ToolStripComboBox();
            this.filtrarEspLbl = new System.Windows.Forms.ToolStripLabel();
            this.especiesCbx = new System.Windows.Forms.ToolStripComboBox();
            this.iNVENTARIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEspecie)).BeginInit();
            this.paginacionEspecie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paginacionEspecie
            // 
            this.paginacionEspecie.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paginacionEspecie.BindingSource = this.especieBSource;
            this.paginacionEspecie.CountItem = this.bindingNavigatorCountItem;
            this.paginacionEspecie.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paginacionEspecie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paginacionEspecie.Location = new System.Drawing.Point(0, 0);
            this.paginacionEspecie.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionEspecie.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionEspecie.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionEspecie.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionEspecie.Name = "paginacionEspecie";
            this.paginacionEspecie.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionEspecie.Size = new System.Drawing.Size(1004, 25);
            this.paginacionEspecie.TabIndex = 0;
            this.paginacionEspecie.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // ListadoEspecies
            // 
            this.ListadoEspecies.AutoGenerateColumns = false;
            this.ListadoEspecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ListadoEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODESPDataGridViewTextBoxColumn,
            this.gRUPOCOMDataGridViewTextBoxColumn,
            this.nOMCOMUNDataGridViewTextBoxColumn,
            this.nOMCIENTIFICODataGridViewTextBoxColumn,
            this.fAMILIADataGridViewTextBoxColumn,
            this.zONAGEOGRAFICADataGridViewTextBoxColumn,
            this.zONADEVIDADataGridViewTextBoxColumn,
            this.dIAMMINCORTEDataGridViewTextBoxColumn,
            this.gRUPOCOMERCIALDataGridViewTextBoxColumn,
            this.iNVENTARIODataGridViewTextBoxColumn,
            this.rEGENERACIONDataGridViewTextBoxColumn,
            this.lISTADODEESPECIESDataGridViewTextBoxColumn});
            this.ListadoEspecies.DataSource = this.especieBSource;
            this.ListadoEspecies.Location = new System.Drawing.Point(0, 28);
            this.ListadoEspecies.Name = "ListadoEspecies";
            this.ListadoEspecies.Size = new System.Drawing.Size(1158, 150);
            this.ListadoEspecies.TabIndex = 1;
            // 
            // cODESPDataGridViewTextBoxColumn
            // 
            this.cODESPDataGridViewTextBoxColumn.DataPropertyName = "CODESP";
            this.cODESPDataGridViewTextBoxColumn.HeaderText = "CODESP";
            this.cODESPDataGridViewTextBoxColumn.Name = "cODESPDataGridViewTextBoxColumn";
            this.cODESPDataGridViewTextBoxColumn.Width = 76;
            // 
            // gRUPOCOMDataGridViewTextBoxColumn
            // 
            this.gRUPOCOMDataGridViewTextBoxColumn.DataPropertyName = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn.HeaderText = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn.Name = "gRUPOCOMDataGridViewTextBoxColumn";
            this.gRUPOCOMDataGridViewTextBoxColumn.Width = 95;
            // 
            // nOMCOMUNDataGridViewTextBoxColumn
            // 
            this.nOMCOMUNDataGridViewTextBoxColumn.DataPropertyName = "NOMCOMUN";
            this.nOMCOMUNDataGridViewTextBoxColumn.HeaderText = "NOMCOMUN";
            this.nOMCOMUNDataGridViewTextBoxColumn.Name = "nOMCOMUNDataGridViewTextBoxColumn";
            this.nOMCOMUNDataGridViewTextBoxColumn.Width = 97;
            // 
            // nOMCIENTIFICODataGridViewTextBoxColumn
            // 
            this.nOMCIENTIFICODataGridViewTextBoxColumn.DataPropertyName = "NOMCIENTIFICO";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.HeaderText = "NOMCIENTIFICO";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.Name = "nOMCIENTIFICODataGridViewTextBoxColumn";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.Width = 116;
            // 
            // fAMILIADataGridViewTextBoxColumn
            // 
            this.fAMILIADataGridViewTextBoxColumn.DataPropertyName = "FAMILIA";
            this.fAMILIADataGridViewTextBoxColumn.HeaderText = "FAMILIA";
            this.fAMILIADataGridViewTextBoxColumn.Name = "fAMILIADataGridViewTextBoxColumn";
            this.fAMILIADataGridViewTextBoxColumn.Width = 73;
            // 
            // zONAGEOGRAFICADataGridViewTextBoxColumn
            // 
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.DataPropertyName = "ZONAGEOGRAFICA";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.HeaderText = "ZONAGEOGRAFICA";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.Name = "zONAGEOGRAFICADataGridViewTextBoxColumn";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.Width = 131;
            // 
            // zONADEVIDADataGridViewTextBoxColumn
            // 
            this.zONADEVIDADataGridViewTextBoxColumn.DataPropertyName = "ZONADEVIDA";
            this.zONADEVIDADataGridViewTextBoxColumn.HeaderText = "ZONADEVIDA";
            this.zONADEVIDADataGridViewTextBoxColumn.Name = "zONADEVIDADataGridViewTextBoxColumn";
            this.zONADEVIDADataGridViewTextBoxColumn.Width = 102;
            // 
            // dIAMMINCORTEDataGridViewTextBoxColumn
            // 
            this.dIAMMINCORTEDataGridViewTextBoxColumn.DataPropertyName = "DIAMMINCORTE";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.HeaderText = "DIAMMINCORTE";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.Name = "dIAMMINCORTEDataGridViewTextBoxColumn";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.Width = 116;
            // 
            // gRUPOCOMERCIALDataGridViewTextBoxColumn
            // 
            this.gRUPOCOMERCIALDataGridViewTextBoxColumn.DataPropertyName = "GRUPOCOMERCIAL";
            this.gRUPOCOMERCIALDataGridViewTextBoxColumn.HeaderText = "GRUPOCOMERCIAL";
            this.gRUPOCOMERCIALDataGridViewTextBoxColumn.Name = "gRUPOCOMERCIALDataGridViewTextBoxColumn";
            this.gRUPOCOMERCIALDataGridViewTextBoxColumn.Width = 133;
            // 
            // iNVENTARIODataGridViewTextBoxColumn
            // 
            this.iNVENTARIODataGridViewTextBoxColumn.DataPropertyName = "INVENTARIO";
            this.iNVENTARIODataGridViewTextBoxColumn.HeaderText = "INVENTARIO";
            this.iNVENTARIODataGridViewTextBoxColumn.Name = "iNVENTARIODataGridViewTextBoxColumn";
            this.iNVENTARIODataGridViewTextBoxColumn.Width = 98;
            // 
            // rEGENERACIONDataGridViewTextBoxColumn
            // 
            this.rEGENERACIONDataGridViewTextBoxColumn.DataPropertyName = "REGENERACION";
            this.rEGENERACIONDataGridViewTextBoxColumn.HeaderText = "REGENERACION";
            this.rEGENERACIONDataGridViewTextBoxColumn.Name = "rEGENERACIONDataGridViewTextBoxColumn";
            this.rEGENERACIONDataGridViewTextBoxColumn.Width = 118;
            // 
            // lISTADODEESPECIESDataGridViewTextBoxColumn
            // 
            this.lISTADODEESPECIESDataGridViewTextBoxColumn.DataPropertyName = "LISTADODEESPECIES";
            this.lISTADODEESPECIESDataGridViewTextBoxColumn.HeaderText = "LISTADODEESPECIES";
            this.lISTADODEESPECIESDataGridViewTextBoxColumn.Name = "lISTADODEESPECIESDataGridViewTextBoxColumn";
            this.lISTADODEESPECIESDataGridViewTextBoxColumn.Width = 145;
            // 
            // especieBSource
            // 
            this.especieBSource.DataSource = typeof(SIFCA_DAL.ESPECIE);
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
            // iNVENTARIOBindingNavigatorSaveItem
            // 
            this.iNVENTARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iNVENTARIOBindingNavigatorSaveItem.Enabled = false;
            this.iNVENTARIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iNVENTARIOBindingNavigatorSaveItem.Image")));
            this.iNVENTARIOBindingNavigatorSaveItem.Name = "iNVENTARIOBindingNavigatorSaveItem";
            this.iNVENTARIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            // 
            // Listado_Especies_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1004, 318);
            this.Controls.Add(this.ListadoEspecies);
            this.Controls.Add(this.paginacionEspecie);
            this.Name = "Listado_Especies_Form";
            this.Text = "Listado_Especies_Form";
            this.Load += new System.EventHandler(this.Listado_Especies_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEspecie)).EndInit();
            this.paginacionEspecie.ResumeLayout(false);
            this.paginacionEspecie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator paginacionEspecie;
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
        private System.Windows.Forms.DataGridView ListadoEspecies;
        private System.Windows.Forms.BindingSource especieBSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOCOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCIENTIFICODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMILIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zONAGEOGRAFICADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zONADEVIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIAMMINCORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOCOMERCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVENTARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGENERACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lISTADODEESPECIESDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel buscarLbl;
        private System.Windows.Forms.ToolStripTextBox parametroBusTxt;
        private System.Windows.Forms.ToolStripLabel filtrarLbl;
        private System.Windows.Forms.ToolStripComboBox criterioBusquedaCbx;
        private System.Windows.Forms.ToolStripLabel filtrarEspLbl;
        private System.Windows.Forms.ToolStripComboBox especiesCbx;
        private System.Windows.Forms.ToolStripButton iNVENTARIOBindingNavigatorSaveItem;
    }
}