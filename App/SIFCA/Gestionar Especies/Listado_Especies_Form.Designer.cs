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
            this.especieBSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.iNVENTARIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buscarLbl = new System.Windows.Forms.ToolStripLabel();
            this.parametroBusTxt = new System.Windows.Forms.ToolStripTextBox();
            this.filtrarLbl = new System.Windows.Forms.ToolStripLabel();
            this.criterioBusquedaCbx = new System.Windows.Forms.ToolStripComboBox();
            this.ListadoEspecies = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoComercial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grupoComercialBSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreComun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCientifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaGeografica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaVida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diamCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEspecie)).BeginInit();
            this.paginacionEspecie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especieBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoComercialBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paginacionEspecie
            // 
            this.paginacionEspecie.AddNewItem = null;
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
            this.criterioBusquedaCbx});
            this.paginacionEspecie.Location = new System.Drawing.Point(0, 0);
            this.paginacionEspecie.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionEspecie.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionEspecie.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionEspecie.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionEspecie.Name = "paginacionEspecie";
            this.paginacionEspecie.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionEspecie.Size = new System.Drawing.Size(949, 25);
            this.paginacionEspecie.TabIndex = 0;
            this.paginacionEspecie.Text = "bindingNavigator1";
            // 
            // especieBSource
            // 
            this.especieBSource.DataSource = typeof(SIFCA_DAL.ESPECIE);
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // iNVENTARIOBindingNavigatorSaveItem
            // 
            this.iNVENTARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iNVENTARIOBindingNavigatorSaveItem.Enabled = false;
            this.iNVENTARIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iNVENTARIOBindingNavigatorSaveItem.Image")));
            this.iNVENTARIOBindingNavigatorSaveItem.Name = "iNVENTARIOBindingNavigatorSaveItem";
            this.iNVENTARIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iNVENTARIOBindingNavigatorSaveItem.Click += new System.EventHandler(this.iNVENTARIOBindingNavigatorSaveItem_Click);
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
            "Codigo",
            "Grupo Comercial",
            "Nombre Comun",
            "Nombre Cientifico",
            "Familia",
            "Zona Geografica",
            "Zona Vida",
            "Diametro Min. Corte"});
            this.criterioBusquedaCbx.Name = "criterioBusquedaCbx";
            this.criterioBusquedaCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // ListadoEspecies
            // 
            this.ListadoEspecies.AutoGenerateColumns = false;
            this.ListadoEspecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.grupoComercial,
            this.nombreComun,
            this.nombreCientifico,
            this.familia,
            this.zonaGeografica,
            this.zonaVida,
            this.diamCorte});
            this.ListadoEspecies.DataSource = this.especieBSource;
            this.ListadoEspecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoEspecies.Location = new System.Drawing.Point(0, 25);
            this.ListadoEspecies.Name = "ListadoEspecies";
            this.ListadoEspecies.Size = new System.Drawing.Size(949, 398);
            this.ListadoEspecies.TabIndex = 1;
            this.ListadoEspecies.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ListadoEspecies_RowsRemoved);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CODESP";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // grupoComercial
            // 
            this.grupoComercial.DataPropertyName = "GRUPOCOM";
            this.grupoComercial.DataSource = this.grupoComercialBSource;
            this.grupoComercial.DisplayMember = "DESCRIPGRUPO";
            this.grupoComercial.HeaderText = "Grupo comercial";
            this.grupoComercial.Name = "grupoComercial";
            this.grupoComercial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grupoComercial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.grupoComercial.ValueMember = "GRUPOCOM";
            // 
            // grupoComercialBSource
            // 
            this.grupoComercialBSource.DataSource = typeof(SIFCA_DAL.GRUPOCOMERCIAL);
            // 
            // nombreComun
            // 
            this.nombreComun.DataPropertyName = "NOMCOMUN";
            this.nombreComun.HeaderText = "Nombre comun";
            this.nombreComun.Name = "nombreComun";
            this.nombreComun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombreCientifico
            // 
            this.nombreCientifico.DataPropertyName = "NOMCIENTIFICO";
            this.nombreCientifico.HeaderText = "Nombre cientifico";
            this.nombreCientifico.Name = "nombreCientifico";
            // 
            // familia
            // 
            this.familia.DataPropertyName = "FAMILIA";
            this.familia.HeaderText = "Familia";
            this.familia.Name = "familia";
            // 
            // zonaGeografica
            // 
            this.zonaGeografica.DataPropertyName = "ZONAGEOGRAFICA";
            this.zonaGeografica.HeaderText = "Zona geografica";
            this.zonaGeografica.Name = "zonaGeografica";
            // 
            // zonaVida
            // 
            this.zonaVida.DataPropertyName = "ZONADEVIDA";
            this.zonaVida.HeaderText = "Zona vida";
            this.zonaVida.Name = "zonaVida";
            // 
            // diamCorte
            // 
            this.diamCorte.DataPropertyName = "DIAMMINCORTE";
            this.diamCorte.HeaderText = "Diametro min. corte";
            this.diamCorte.Name = "diamCorte";
            // 
            // Listado_Especies_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(949, 423);
            this.Controls.Add(this.ListadoEspecies);
            this.Controls.Add(this.paginacionEspecie);
            this.Name = "Listado_Especies_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar especies";
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEspecie)).EndInit();
            this.paginacionEspecie.ResumeLayout(false);
            this.paginacionEspecie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especieBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoComercialBSource)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel buscarLbl;
        private System.Windows.Forms.ToolStripTextBox parametroBusTxt;
        private System.Windows.Forms.ToolStripLabel filtrarLbl;
        private System.Windows.Forms.ToolStripComboBox criterioBusquedaCbx;
        private System.Windows.Forms.ToolStripButton iNVENTARIOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewComboBoxColumn grupoComercial;
        private System.Windows.Forms.BindingSource grupoComercialBSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComun;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCientifico;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaGeografica;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaVida;
        private System.Windows.Forms.DataGridViewTextBoxColumn diamCorte;
    }
}