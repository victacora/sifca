namespace SIFCA
{
    partial class GestDatRegen_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestDatRegen_Form));
            this.regenracionBSource = new System.Windows.Forms.BindingSource(this.components);
            this.regeneracionBNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rEGENERACIONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.regeneracionDataGridView = new System.Windows.Forms.DataGridView();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latizal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brinzal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.regenracionBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regeneracionBNavigator)).BeginInit();
            this.regeneracionBNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regeneracionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // regenracionBSource
            // 
            this.regenracionBSource.DataSource = typeof(SIFCA_DAL.REGENERACION);
            // 
            // regeneracionBNavigator
            // 
            this.regeneracionBNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.regeneracionBNavigator.BindingSource = this.regenracionBSource;
            this.regeneracionBNavigator.CountItem = this.bindingNavigatorCountItem;
            this.regeneracionBNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.regeneracionBNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rEGENERACIONBindingNavigatorSaveItem});
            this.regeneracionBNavigator.Location = new System.Drawing.Point(0, 0);
            this.regeneracionBNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.regeneracionBNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.regeneracionBNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.regeneracionBNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.regeneracionBNavigator.Name = "regeneracionBNavigator";
            this.regeneracionBNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.regeneracionBNavigator.Size = new System.Drawing.Size(916, 25);
            this.regeneracionBNavigator.TabIndex = 0;
            this.regeneracionBNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // rEGENERACIONBindingNavigatorSaveItem
            // 
            this.rEGENERACIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rEGENERACIONBindingNavigatorSaveItem.Enabled = false;
            this.rEGENERACIONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rEGENERACIONBindingNavigatorSaveItem.Image")));
            this.rEGENERACIONBindingNavigatorSaveItem.Name = "rEGENERACIONBindingNavigatorSaveItem";
            this.rEGENERACIONBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rEGENERACIONBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // regeneracionDataGridView
            // 
            this.regeneracionDataGridView.AutoGenerateColumns = false;
            this.regeneracionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.regeneracionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regeneracionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proyecto,
            this.Estacion,
            this.Etapa,
            this.dataGridViewTextBoxColumn1,
            this.Parcela,
            this.Arbol,
            this.Especie,
            this.Latizal,
            this.Brinzal});
            this.regeneracionDataGridView.DataSource = this.regenracionBSource;
            this.regeneracionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regeneracionDataGridView.Location = new System.Drawing.Point(0, 25);
            this.regeneracionDataGridView.Name = "regeneracionDataGridView";
            this.regeneracionDataGridView.Size = new System.Drawing.Size(916, 416);
            this.regeneracionDataGridView.TabIndex = 1;
            // 
            // Proyecto
            // 
            this.Proyecto.DataPropertyName = "NROPROY";
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            // 
            // Estacion
            // 
            this.Estacion.DataPropertyName = "CODEST";
            this.Estacion.HeaderText = "Estacion";
            this.Estacion.Name = "Estacion";
            // 
            // Etapa
            // 
            this.Etapa.DataPropertyName = "CODETAPA";
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.Name = "Etapa";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Estrato";
            this.dataGridViewTextBoxColumn1.HeaderText = "Estrato";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Parcela
            // 
            this.Parcela.DataPropertyName = "PARCELA";
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            // 
            // Arbol
            // 
            this.Arbol.DataPropertyName = "NROARB";
            this.Arbol.HeaderText = "Arbol";
            this.Arbol.Name = "Arbol";
            // 
            // Especie
            // 
            this.Especie.DataPropertyName = "CODESP";
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            // 
            // Latizal
            // 
            this.Latizal.DataPropertyName = "LATIZAL";
            this.Latizal.HeaderText = "Latizal";
            this.Latizal.Name = "Latizal";
            // 
            // Brinzal
            // 
            this.Brinzal.DataPropertyName = "BRINZAL";
            this.Brinzal.HeaderText = "Brinzal";
            this.Brinzal.Name = "Brinzal";
            // 
            // GestDatRegen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 441);
            this.Controls.Add(this.regeneracionDataGridView);
            this.Controls.Add(this.regeneracionBNavigator);
            this.Name = "GestDatRegen_Form";
            this.Text = "Datos regeneracion";
            ((System.ComponentModel.ISupportInitialize)(this.regenracionBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regeneracionBNavigator)).EndInit();
            this.regeneracionBNavigator.ResumeLayout(false);
            this.regeneracionBNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regeneracionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource regenracionBSource;
        private System.Windows.Forms.BindingNavigator regeneracionBNavigator;
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
        private System.Windows.Forms.ToolStripButton rEGENERACIONBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView regeneracionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latizal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brinzal;
    }
}