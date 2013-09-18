namespace SIFCA.Gestion_de_Tipos_De_Uso
{
    partial class Listado_TipoUso_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_TipoUso_Form));
            this.TypeUseBSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoEspecies = new System.Windows.Forms.DataGridView();
            this.nOMBRETIPOUSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginacionTipoUso = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarLbl = new System.Windows.Forms.ToolStripLabel();
            this.parametroBusTxt = new System.Windows.Forms.ToolStripTextBox();
            this.filtrarLbl = new System.Windows.Forms.ToolStripLabel();
            this.criterioBusquedaCbx = new System.Windows.Forms.ToolStripComboBox();
            this.listadoEspLbl = new System.Windows.Forms.ToolStripLabel();
            this.listadoEspCbx = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TypeUseBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTipoUso)).BeginInit();
            this.paginacionTipoUso.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeUseBSource
            // 
            this.TypeUseBSource.DataSource = typeof(SIFCA_DAL.TIPODEUSO);
            // 
            // ListadoEspecies
            // 
            this.ListadoEspecies.AllowUserToAddRows = false;
            this.ListadoEspecies.AllowUserToDeleteRows = false;
            this.ListadoEspecies.AutoGenerateColumns = false;
            this.ListadoEspecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBRETIPOUSODataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.ListadoEspecies.DataSource = this.TypeUseBSource;
            this.ListadoEspecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoEspecies.Location = new System.Drawing.Point(0, 27);
            this.ListadoEspecies.Name = "ListadoEspecies";
            this.ListadoEspecies.ReadOnly = true;
            this.ListadoEspecies.Size = new System.Drawing.Size(284, 234);
            this.ListadoEspecies.TabIndex = 3;
            // 
            // nOMBRETIPOUSODataGridViewTextBoxColumn
            // 
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.DataPropertyName = "NOMBRETIPOUSO";
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.HeaderText = "NOMBRETIPOUSO";
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.Name = "nOMBRETIPOUSODataGridViewTextBoxColumn";
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paginacionTipoUso
            // 
            this.paginacionTipoUso.AddNewItem = null;
            this.paginacionTipoUso.BindingSource = this.TypeUseBSource;
            this.paginacionTipoUso.CountItem = this.bindingNavigatorCountItem;
            this.paginacionTipoUso.DeleteItem = null;
            this.paginacionTipoUso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.parametroBusTxt,
            this.filtrarLbl,
            this.criterioBusquedaCbx,
            this.listadoEspLbl,
            this.listadoEspCbx});
            this.paginacionTipoUso.Location = new System.Drawing.Point(0, 0);
            this.paginacionTipoUso.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionTipoUso.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionTipoUso.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionTipoUso.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionTipoUso.Name = "paginacionTipoUso";
            this.paginacionTipoUso.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionTipoUso.Size = new System.Drawing.Size(284, 27);
            this.paginacionTipoUso.TabIndex = 2;
            this.paginacionTipoUso.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // buscarLbl
            // 
            this.buscarLbl.Name = "buscarLbl";
            this.buscarLbl.Size = new System.Drawing.Size(45, 24);
            this.buscarLbl.Text = "Buscar:";
            // 
            // parametroBusTxt
            // 
            this.parametroBusTxt.Name = "parametroBusTxt";
            this.parametroBusTxt.Size = new System.Drawing.Size(150, 23);
            // 
            // filtrarLbl
            // 
            this.filtrarLbl.Name = "filtrarLbl";
            this.filtrarLbl.Size = new System.Drawing.Size(92, 15);
            this.filtrarLbl.Text = "Filtrar busqueda";
            // 
            // criterioBusquedaCbx
            // 
            this.criterioBusquedaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterioBusquedaCbx.Items.AddRange(new object[] {
            "Codigo",
            "Grupo Comercial",
            "Nombre Comun",
            "Nombre Cientifico",
            "Familia",
            "Zona Geografica",
            "Zona Vida",
            "Diametro Min. Corte"});
            this.criterioBusquedaCbx.Name = "criterioBusquedaCbx";
            this.criterioBusquedaCbx.Size = new System.Drawing.Size(121, 23);
            // 
            // listadoEspLbl
            // 
            this.listadoEspLbl.Name = "listadoEspLbl";
            this.listadoEspLbl.Size = new System.Drawing.Size(97, 15);
            this.listadoEspLbl.Text = "Listado Asociado";
            // 
            // listadoEspCbx
            // 
            this.listadoEspCbx.Name = "listadoEspCbx";
            this.listadoEspCbx.Size = new System.Drawing.Size(121, 23);
            // 
            // Listado_TipoUso_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ListadoEspecies);
            this.Controls.Add(this.paginacionTipoUso);
            this.Name = "Listado_TipoUso_Form";
            this.Text = "Listado Tipos De Uso";
            ((System.ComponentModel.ISupportInitialize)(this.TypeUseBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTipoUso)).EndInit();
            this.paginacionTipoUso.ResumeLayout(false);
            this.paginacionTipoUso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource TypeUseBSource;
        private System.Windows.Forms.DataGridView ListadoEspecies;
        private System.Windows.Forms.BindingNavigator paginacionTipoUso;
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
        private System.Windows.Forms.ToolStripTextBox parametroBusTxt;
        private System.Windows.Forms.ToolStripLabel filtrarLbl;
        private System.Windows.Forms.ToolStripComboBox criterioBusquedaCbx;
        private System.Windows.Forms.ToolStripLabel listadoEspLbl;
        private System.Windows.Forms.ToolStripComboBox listadoEspCbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRETIPOUSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
    }
}