namespace SIFCA.Gestion_Configuracion
{
    partial class GruposComerciales_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GruposComerciales_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.ListadoGruposComerciales = new System.Windows.Forms.DataGridView();
            this.gRUPOCOMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPGRUPODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grupoComBSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginacionGruposCom = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.Btn_nuevo = new System.Windows.Forms.ToolStripButton();
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
            this.ListadoGruposCom = new System.Windows.Forms.DataGridView();
            this.gRUPOCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPGRUPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_crear = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.abrevTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_editar = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateDescripcionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.updateAbrevTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGruposComerciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoComBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionGruposCom)).BeginInit();
            this.paginacionGruposCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGruposCom)).BeginInit();
            this.pn_crear.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pn_editar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_listado
            // 
            this.pn_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_listado.Controls.Add(this.ListadoGruposComerciales);
            this.pn_listado.Controls.Add(this.paginacionGruposCom);
            this.pn_listado.Controls.Add(this.ListadoGruposCom);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(497, 210);
            this.pn_listado.TabIndex = 0;
            // 
            // ListadoGruposComerciales
            // 
            this.ListadoGruposComerciales.AllowUserToAddRows = false;
            this.ListadoGruposComerciales.AllowUserToDeleteRows = false;
            this.ListadoGruposComerciales.AutoGenerateColumns = false;
            this.ListadoGruposComerciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoGruposComerciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gRUPOCOMDataGridViewTextBoxColumn1,
            this.dESCRIPGRUPODataGridViewTextBoxColumn1,
            this.Editar,
            this.Eliminar});
            this.ListadoGruposComerciales.DataSource = this.grupoComBSource;
            this.ListadoGruposComerciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoGruposComerciales.Location = new System.Drawing.Point(0, 25);
            this.ListadoGruposComerciales.Name = "ListadoGruposComerciales";
            this.ListadoGruposComerciales.ReadOnly = true;
            this.ListadoGruposComerciales.Size = new System.Drawing.Size(493, 181);
            this.ListadoGruposComerciales.TabIndex = 4;
            this.ListadoGruposComerciales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDeEspecies_CellValueChanged);
            // 
            // gRUPOCOMDataGridViewTextBoxColumn1
            // 
            this.gRUPOCOMDataGridViewTextBoxColumn1.DataPropertyName = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn1.HeaderText = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn1.Name = "gRUPOCOMDataGridViewTextBoxColumn1";
            this.gRUPOCOMDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gRUPOCOMDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dESCRIPGRUPODataGridViewTextBoxColumn1
            // 
            this.dESCRIPGRUPODataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dESCRIPGRUPODataGridViewTextBoxColumn1.DataPropertyName = "DESCRIPGRUPO";
            this.dESCRIPGRUPODataGridViewTextBoxColumn1.HeaderText = "DESCRIPGRUPO";
            this.dESCRIPGRUPODataGridViewTextBoxColumn1.Name = "dESCRIPGRUPODataGridViewTextBoxColumn1";
            this.dESCRIPGRUPODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 5;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Eliminar.DataPropertyName = "GRUPOCOM";
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 5;
            // 
            // grupoComBSource
            // 
            this.grupoComBSource.DataSource = typeof(SIFCA_DAL.GRUPOCOMERCIAL);
            // 
            // paginacionGruposCom
            // 
            this.paginacionGruposCom.AddNewItem = null;
            this.paginacionGruposCom.BindingSource = this.grupoComBSource;
            this.paginacionGruposCom.CountItem = this.bindingNavigatorCountItem;
            this.paginacionGruposCom.DeleteItem = null;
            this.paginacionGruposCom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_nuevo,
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
            this.paginacionGruposCom.Location = new System.Drawing.Point(0, 0);
            this.paginacionGruposCom.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionGruposCom.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionGruposCom.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionGruposCom.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionGruposCom.Name = "paginacionGruposCom";
            this.paginacionGruposCom.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionGruposCom.Size = new System.Drawing.Size(493, 25);
            this.paginacionGruposCom.TabIndex = 2;
            this.paginacionGruposCom.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nuevo.Image")));
            this.Btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(46, 22);
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
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
            // 
            // ListadoGruposCom
            // 
            this.ListadoGruposCom.AllowUserToAddRows = false;
            this.ListadoGruposCom.AllowUserToDeleteRows = false;
            this.ListadoGruposCom.AutoGenerateColumns = false;
            this.ListadoGruposCom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoGruposCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoGruposCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gRUPOCOMDataGridViewTextBoxColumn,
            this.dESCRIPGRUPODataGridViewTextBoxColumn});
            this.ListadoGruposCom.DataSource = this.grupoComBSource;
            this.ListadoGruposCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoGruposCom.Location = new System.Drawing.Point(0, 0);
            this.ListadoGruposCom.Name = "ListadoGruposCom";
            this.ListadoGruposCom.ReadOnly = true;
            this.ListadoGruposCom.Size = new System.Drawing.Size(493, 206);
            this.ListadoGruposCom.TabIndex = 3;
            // 
            // gRUPOCOMDataGridViewTextBoxColumn
            // 
            this.gRUPOCOMDataGridViewTextBoxColumn.DataPropertyName = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn.HeaderText = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn.Name = "gRUPOCOMDataGridViewTextBoxColumn";
            this.gRUPOCOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPGRUPODataGridViewTextBoxColumn
            // 
            this.dESCRIPGRUPODataGridViewTextBoxColumn.DataPropertyName = "DESCRIPGRUPO";
            this.dESCRIPGRUPODataGridViewTextBoxColumn.HeaderText = "Descripión";
            this.dESCRIPGRUPODataGridViewTextBoxColumn.Name = "dESCRIPGRUPODataGridViewTextBoxColumn";
            this.dESCRIPGRUPODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pn_crear
            // 
            this.pn_crear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_crear.Controls.Add(this.groupBox1);
            this.pn_crear.Location = new System.Drawing.Point(0, 0);
            this.pn_crear.Name = "pn_crear";
            this.pn_crear.Size = new System.Drawing.Size(287, 183);
            this.pn_crear.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descripcionTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_Crear);
            this.groupBox1.Controls.Add(this.abrevTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Grupo Comercial";
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(86, 58);
            this.descripcionTxt.Multiline = true;
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(167, 48);
            this.descripcionTxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripcion";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(149, 112);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 23);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(22, 112);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(92, 23);
            this.btn_Crear.TabIndex = 1;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // abrevTxt
            // 
            this.abrevTxt.Location = new System.Drawing.Point(86, 29);
            this.abrevTxt.MaxLength = 2;
            this.abrevTxt.Name = "abrevTxt";
            this.abrevTxt.Size = new System.Drawing.Size(74, 20);
            this.abrevTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abreviatura";
            // 
            // pn_editar
            // 
            this.pn_editar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_editar.Controls.Add(this.groupBox2);
            this.pn_editar.Location = new System.Drawing.Point(0, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(287, 174);
            this.pn_editar.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateDescripcionTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.Controls.Add(this.updateAbrevTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Grupo Comercial";
            // 
            // updateDescripcionTxt
            // 
            this.updateDescripcionTxt.Location = new System.Drawing.Point(86, 58);
            this.updateDescripcionTxt.Multiline = true;
            this.updateDescripcionTxt.Name = "updateDescripcionTxt";
            this.updateDescripcionTxt.Size = new System.Drawing.Size(167, 34);
            this.updateDescripcionTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_CancelarUpdate_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(22, 98);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(92, 23);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // updateAbrevTxt
            // 
            this.updateAbrevTxt.Location = new System.Drawing.Point(86, 29);
            this.updateAbrevTxt.Name = "updateAbrevTxt";
            this.updateAbrevTxt.ReadOnly = true;
            this.updateAbrevTxt.Size = new System.Drawing.Size(167, 20);
            this.updateAbrevTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Abreviatura";
            // 
            // GruposComerciales_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 211);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_editar);
            this.Controls.Add(this.pn_listado);
            this.Name = "GruposComerciales_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos Comerciales";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGruposComerciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoComBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionGruposCom)).EndInit();
            this.paginacionGruposCom.ResumeLayout(false);
            this.paginacionGruposCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGruposCom)).EndInit();
            this.pn_crear.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_editar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_listado;
        private System.Windows.Forms.BindingNavigator paginacionGruposCom;
        private System.Windows.Forms.BindingSource grupoComBSource;
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
        private System.Windows.Forms.DataGridView ListadoGruposCom;
        private System.Windows.Forms.Panel pn_crear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.TextBox abrevTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_editar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox updateDescripcionTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox updateAbrevTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ListadoGruposComerciales;
        private System.Windows.Forms.ToolStripButton Btn_nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOCOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPGRUPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOCOMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPGRUPODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}