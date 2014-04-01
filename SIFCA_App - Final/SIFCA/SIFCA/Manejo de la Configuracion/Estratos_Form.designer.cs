namespace SIFCA.Gestion_Configuracion
{
    partial class Estratos_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estratos_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.ListadoEstratos = new System.Windows.Forms.DataGridView();
            this.cODESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPESTRATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stratumListBSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginacionEstrato = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btn_nuevoEstrato = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarLbl = new System.Windows.Forms.ToolStripLabel();
            this.busquedaTxt = new System.Windows.Forms.ToolStripTextBox();
            this.pn_crear = new System.Windows.Forms.Panel();
            this.crearGbx = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_editar = new System.Windows.Forms.Panel();
            this.editarGbx = new System.Windows.Forms.GroupBox();
            this.btn_cancelarUpdate = new System.Windows.Forms.Button();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.eP_errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.stratumEditBSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEstratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stratumListBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEstrato)).BeginInit();
            this.paginacionEstrato.SuspendLayout();
            this.pn_crear.SuspendLayout();
            this.crearGbx.SuspendLayout();
            this.pn_editar.SuspendLayout();
            this.editarGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stratumEditBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_listado
            // 
            this.pn_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_listado.Controls.Add(this.ListadoEstratos);
            this.pn_listado.Controls.Add(this.paginacionEstrato);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(539, 326);
            this.pn_listado.TabIndex = 0;
            // 
            // ListadoEstratos
            // 
            this.ListadoEstratos.AllowUserToAddRows = false;
            this.ListadoEstratos.AllowUserToDeleteRows = false;
            this.ListadoEstratos.AutoGenerateColumns = false;
            this.ListadoEstratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoEstratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEstratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODESTDataGridViewTextBoxColumn,
            this.dESCRIPESTRATODataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.ListadoEstratos.DataSource = this.stratumListBSource;
            this.ListadoEstratos.Location = new System.Drawing.Point(0, 25);
            this.ListadoEstratos.Name = "ListadoEstratos";
            this.ListadoEstratos.ReadOnly = true;
            this.ListadoEstratos.Size = new System.Drawing.Size(520, 283);
            this.ListadoEstratos.TabIndex = 3;
            this.ListadoEstratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listado_CellValueChanged);
            // 
            // cODESTDataGridViewTextBoxColumn
            // 
            this.cODESTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.cODESTDataGridViewTextBoxColumn.DataPropertyName = "CODEST";
            this.cODESTDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.cODESTDataGridViewTextBoxColumn.Name = "cODESTDataGridViewTextBoxColumn";
            this.cODESTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODESTDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRIPESTRATODataGridViewTextBoxColumn
            // 
            this.dESCRIPESTRATODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dESCRIPESTRATODataGridViewTextBoxColumn.DataPropertyName = "DESCRIPESTRATO";
            this.dESCRIPESTRATODataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.dESCRIPESTRATODataGridViewTextBoxColumn.Name = "dESCRIPESTRATODataGridViewTextBoxColumn";
            this.dESCRIPESTRATODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 19;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 5;
            // 
            // stratumListBSource
            // 
            this.stratumListBSource.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // paginacionEstrato
            // 
            this.paginacionEstrato.AddNewItem = null;
            this.paginacionEstrato.BindingSource = this.stratumListBSource;
            this.paginacionEstrato.CountItem = this.bindingNavigatorCountItem;
            this.paginacionEstrato.DeleteItem = null;
            this.paginacionEstrato.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevoEstrato,
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
            this.busquedaTxt});
            this.paginacionEstrato.Location = new System.Drawing.Point(0, 0);
            this.paginacionEstrato.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionEstrato.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionEstrato.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionEstrato.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionEstrato.Name = "paginacionEstrato";
            this.paginacionEstrato.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionEstrato.Size = new System.Drawing.Size(535, 25);
            this.paginacionEstrato.TabIndex = 2;
            this.paginacionEstrato.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // btn_nuevoEstrato
            // 
            this.btn_nuevoEstrato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_nuevoEstrato.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevoEstrato.Image")));
            this.btn_nuevoEstrato.ImageTransparentColor = System.Drawing.Color.Black;
            this.btn_nuevoEstrato.Name = "btn_nuevoEstrato";
            this.btn_nuevoEstrato.Size = new System.Drawing.Size(85, 22);
            this.btn_nuevoEstrato.Text = "Nuevo estrato";
            this.btn_nuevoEstrato.Click += new System.EventHandler(this.btn_nuevoEstrato_Click);
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
            // buscarLbl
            // 
            this.buscarLbl.Name = "buscarLbl";
            this.buscarLbl.Size = new System.Drawing.Size(45, 22);
            this.buscarLbl.Text = "Buscar:";
            // 
            // busquedaTxt
            // 
            this.busquedaTxt.Name = "busquedaTxt";
            this.busquedaTxt.Size = new System.Drawing.Size(150, 25);
            this.busquedaTxt.TextChanged += new System.EventHandler(this.busquedaTxt_TextChanged);
            // 
            // pn_crear
            // 
            this.pn_crear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_crear.Controls.Add(this.crearGbx);
            this.pn_crear.Location = new System.Drawing.Point(0, 0);
            this.pn_crear.Name = "pn_crear";
            this.pn_crear.Size = new System.Drawing.Size(350, 223);
            this.pn_crear.TabIndex = 1;
            // 
            // crearGbx
            // 
            this.crearGbx.Controls.Add(this.btn_Cancelar);
            this.crearGbx.Controls.Add(this.btn_Crear);
            this.crearGbx.Controls.Add(this.txt_Nombre);
            this.crearGbx.Controls.Add(this.label2);
            this.crearGbx.Location = new System.Drawing.Point(18, 8);
            this.crearGbx.Name = "crearGbx";
            this.crearGbx.Size = new System.Drawing.Size(299, 171);
            this.crearGbx.TabIndex = 1;
            this.crearGbx.TabStop = false;
            this.crearGbx.Text = "Crear estrato";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(195, 132);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(75, 131);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(92, 23);
            this.btn_Crear.TabIndex = 1;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(71, 26);
            this.txt_Nombre.MaxLength = 500;
            this.txt_Nombre.Multiline = true;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(213, 98);
            this.txt_Nombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // pn_editar
            // 
            this.pn_editar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_editar.Controls.Add(this.editarGbx);
            this.pn_editar.Location = new System.Drawing.Point(0, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(350, 223);
            this.pn_editar.TabIndex = 2;
            // 
            // editarGbx
            // 
            this.editarGbx.Controls.Add(this.btn_cancelarUpdate);
            this.editarGbx.Controls.Add(this.txt_Descripcion);
            this.editarGbx.Controls.Add(this.btn_Guardar);
            this.editarGbx.Controls.Add(this.label6);
            this.editarGbx.Location = new System.Drawing.Point(9, 9);
            this.editarGbx.Name = "editarGbx";
            this.editarGbx.Size = new System.Drawing.Size(312, 168);
            this.editarGbx.TabIndex = 12;
            this.editarGbx.TabStop = false;
            this.editarGbx.Text = "Editar Estrato";
            // 
            // btn_cancelarUpdate
            // 
            this.btn_cancelarUpdate.Location = new System.Drawing.Point(213, 121);
            this.btn_cancelarUpdate.Name = "btn_cancelarUpdate";
            this.btn_cancelarUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarUpdate.TabIndex = 2;
            this.btn_cancelarUpdate.Text = "Cancelar";
            this.btn_cancelarUpdate.UseVisualStyleBackColor = true;
            this.btn_cancelarUpdate.Click += new System.EventHandler(this.btn_cancelarUpdate_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(84, 22);
            this.txt_Descripcion.MaxLength = 500;
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(206, 93);
            this.txt_Descripcion.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(84, 121);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(84, 23);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripcion";
            // 
            // eP_errors
            // 
            this.eP_errors.ContainerControl = this;
            // 
            // stratumEditBSource
            // 
            this.stratumEditBSource.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // Estratos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 338);
            this.Controls.Add(this.pn_editar);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estratos_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estratos ";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEstratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stratumListBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEstrato)).EndInit();
            this.paginacionEstrato.ResumeLayout(false);
            this.paginacionEstrato.PerformLayout();
            this.pn_crear.ResumeLayout(false);
            this.crearGbx.ResumeLayout(false);
            this.crearGbx.PerformLayout();
            this.pn_editar.ResumeLayout(false);
            this.editarGbx.ResumeLayout(false);
            this.editarGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stratumEditBSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_listado;
        private System.Windows.Forms.DataGridView ListadoEstratos;
        private System.Windows.Forms.BindingSource stratumListBSource;
        private System.Windows.Forms.BindingNavigator paginacionEstrato;
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
        private System.Windows.Forms.ToolStripTextBox busquedaTxt;
        private System.Windows.Forms.Panel pn_crear;
        private System.Windows.Forms.GroupBox crearGbx;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_editar;
        private System.Windows.Forms.GroupBox editarGbx;
        private System.Windows.Forms.Button btn_cancelarUpdate;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource stratumEditBSource;
        private System.Windows.Forms.ToolStripButton btn_nuevoEstrato;
        private System.Windows.Forms.ErrorProvider eP_errors;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPESTRATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;


    }
}