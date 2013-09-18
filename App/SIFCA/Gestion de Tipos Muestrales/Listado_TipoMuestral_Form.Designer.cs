namespace SIFCA.Gestion_de_Tipos_Muestrales
{
    partial class Listado_TipoMuestral_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_TipoMuestral_Form));
            this.TypeSampleDesingBSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoEspecies = new System.Windows.Forms.DataGridView();
            this.paginacionGruposCom = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TypeSampleDesingBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionGruposCom)).BeginInit();
            this.paginacionGruposCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeSampleDesingBSource
            // 
            this.TypeSampleDesingBSource.DataSource = typeof(SIFCA_DAL.TIPODISENOMUESTRAL);
            // 
            // ListadoEspecies
            // 
            this.ListadoEspecies.AllowUserToAddRows = false;
            this.ListadoEspecies.AllowUserToDeleteRows = false;
            this.ListadoEspecies.AutoGenerateColumns = false;
            this.ListadoEspecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn,
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn});
            this.ListadoEspecies.DataSource = this.TypeSampleDesingBSource;
            this.ListadoEspecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoEspecies.Location = new System.Drawing.Point(0, 27);
            this.ListadoEspecies.Name = "ListadoEspecies";
            this.ListadoEspecies.ReadOnly = true;
            this.ListadoEspecies.Size = new System.Drawing.Size(284, 234);
            this.ListadoEspecies.TabIndex = 3;
            // 
            // paginacionGruposCom
            // 
            this.paginacionGruposCom.AddNewItem = null;
            this.paginacionGruposCom.BindingSource = this.TypeSampleDesingBSource;
            this.paginacionGruposCom.CountItem = this.bindingNavigatorCountItem;
            this.paginacionGruposCom.DeleteItem = null;
            this.paginacionGruposCom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paginacionGruposCom.Location = new System.Drawing.Point(0, 0);
            this.paginacionGruposCom.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionGruposCom.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionGruposCom.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionGruposCom.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionGruposCom.Name = "paginacionGruposCom";
            this.paginacionGruposCom.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionGruposCom.Size = new System.Drawing.Size(284, 27);
            this.paginacionGruposCom.TabIndex = 2;
            this.paginacionGruposCom.Text = "bindingNavigator1";
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
            // nOMTIPODISEMUESTDataGridViewTextBoxColumn
            // 
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn.DataPropertyName = "NOMTIPODISEMUEST";
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn.HeaderText = "NOMTIPODISEMUEST";
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn.Name = "nOMTIPODISEMUESTDataGridViewTextBoxColumn";
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTIPODISEMUEST";
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn.HeaderText = "DESCRIPTIPODISEMUEST";
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn.Name = "dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn";
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Listado_TipoMuestral_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ListadoEspecies);
            this.Controls.Add(this.paginacionGruposCom);
            this.Name = "Listado_TipoMuestral_Form";
            this.Text = "Listado Tipo Muestal";
            ((System.ComponentModel.ISupportInitialize)(this.TypeSampleDesingBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionGruposCom)).EndInit();
            this.paginacionGruposCom.ResumeLayout(false);
            this.paginacionGruposCom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource TypeSampleDesingBSource;
        private System.Windows.Forms.DataGridView ListadoEspecies;
        private System.Windows.Forms.BindingNavigator paginacionGruposCom;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMTIPODISEMUESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn;
    }
}