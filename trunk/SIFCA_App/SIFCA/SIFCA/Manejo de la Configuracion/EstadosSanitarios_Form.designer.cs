namespace SIFCA.Gestion_Configuracion
{
    partial class EstadosSanitarios_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadosSanitarios_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.ListadoEstados = new System.Windows.Forms.DataGridView();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPESTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StateBSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginacionEstadoSanitario = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.filtrarLbl = new System.Windows.Forms.ToolStripLabel();
            this.criterioCbx = new System.Windows.Forms.ToolStripComboBox();
            this.pn_crear = new System.Windows.Forms.Panel();
            this.crearGbx = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_editar = new System.Windows.Forms.Panel();
            this.editarGbx = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.updateDescripTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updateNombreTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEstadoSanitario)).BeginInit();
            this.paginacionEstadoSanitario.SuspendLayout();
            this.pn_crear.SuspendLayout();
            this.crearGbx.SuspendLayout();
            this.pn_editar.SuspendLayout();
            this.editarGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_listado
            // 
            this.pn_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_listado.Controls.Add(this.ListadoEstados);
            this.pn_listado.Controls.Add(this.paginacionEstadoSanitario);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(685, 273);
            this.pn_listado.TabIndex = 0;
            // 
            // ListadoEstados
            // 
            this.ListadoEstados.AllowUserToAddRows = false;
            this.ListadoEstados.AllowUserToDeleteRows = false;
            this.ListadoEstados.AutoGenerateColumns = false;
            this.ListadoEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eSTADODataGridViewTextBoxColumn,
            this.dESCRIPESTADODataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.ListadoEstados.DataSource = this.StateBSource;
            this.ListadoEstados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoEstados.Location = new System.Drawing.Point(0, 25);
            this.ListadoEstados.Name = "ListadoEstados";
            this.ListadoEstados.ReadOnly = true;
            this.ListadoEstados.Size = new System.Drawing.Size(681, 244);
            this.ListadoEstados.TabIndex = 5;
            this.ListadoEstados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDeEspecies_CellValueChanged);
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSTADODataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRIPESTADODataGridViewTextBoxColumn
            // 
            this.dESCRIPESTADODataGridViewTextBoxColumn.DataPropertyName = "DESCRIPESTADO";
            this.dESCRIPESTADODataGridViewTextBoxColumn.HeaderText = "Descripción estado";
            this.dESCRIPESTADODataGridViewTextBoxColumn.Name = "dESCRIPESTADODataGridViewTextBoxColumn";
            this.dESCRIPESTADODataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Eliminar.DataPropertyName = "ESTADO";
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 19;
            // 
            // StateBSource
            // 
            this.StateBSource.DataSource = typeof(SIFCA_DAL.ESTADOSANITARIO);
            // 
            // paginacionEstadoSanitario
            // 
            this.paginacionEstadoSanitario.AddNewItem = null;
            this.paginacionEstadoSanitario.BindingSource = this.StateBSource;
            this.paginacionEstadoSanitario.CountItem = this.bindingNavigatorCountItem;
            this.paginacionEstadoSanitario.DeleteItem = null;
            this.paginacionEstadoSanitario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.busquedaTxt,
            this.filtrarLbl,
            this.criterioCbx});
            this.paginacionEstadoSanitario.Location = new System.Drawing.Point(0, 0);
            this.paginacionEstadoSanitario.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionEstadoSanitario.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionEstadoSanitario.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionEstadoSanitario.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionEstadoSanitario.Name = "paginacionEstadoSanitario";
            this.paginacionEstadoSanitario.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionEstadoSanitario.Size = new System.Drawing.Size(681, 25);
            this.paginacionEstadoSanitario.TabIndex = 4;
            this.paginacionEstadoSanitario.Text = "bindingNavigator1";
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
            this.busquedaTxt.TextChanged += new System.EventHandler(this.busquedaTxt_TextChanged);
            // 
            // filtrarLbl
            // 
            this.filtrarLbl.Name = "filtrarLbl";
            this.filtrarLbl.Size = new System.Drawing.Size(92, 22);
            this.filtrarLbl.Text = "Filtrar busqueda";
            // 
            // criterioCbx
            // 
            this.criterioCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterioCbx.Items.AddRange(new object[] {
            "Descripcion"});
            this.criterioCbx.Name = "criterioCbx";
            this.criterioCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // pn_crear
            // 
            this.pn_crear.Controls.Add(this.crearGbx);
            this.pn_crear.Location = new System.Drawing.Point(0, 0);
            this.pn_crear.Name = "pn_crear";
            this.pn_crear.Size = new System.Drawing.Size(325, 174);
            this.pn_crear.TabIndex = 1;
            // 
            // crearGbx
            // 
            this.crearGbx.Controls.Add(this.Btn_Cancelar);
            this.crearGbx.Controls.Add(this.Btn_Crear);
            this.crearGbx.Controls.Add(this.txt_Descripcion);
            this.crearGbx.Controls.Add(this.label2);
            this.crearGbx.Controls.Add(this.txt_Nombre);
            this.crearGbx.Controls.Add(this.label1);
            this.crearGbx.Location = new System.Drawing.Point(0, 0);
            this.crearGbx.Name = "crearGbx";
            this.crearGbx.Size = new System.Drawing.Size(329, 179);
            this.crearGbx.TabIndex = 2;
            this.crearGbx.TabStop = false;
            this.crearGbx.Text = "Crear Estado Sanitario";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(187, 146);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(113, 23);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(28, 146);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(101, 23);
            this.Btn_Crear.TabIndex = 4;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(121, 66);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(179, 65);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(121, 28);
            this.txt_Nombre.MaxLength = 2;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(63, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abreviatura (2 Letras)";
            // 
            // pn_editar
            // 
            this.pn_editar.Controls.Add(this.editarGbx);
            this.pn_editar.Location = new System.Drawing.Point(0, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(300, 173);
            this.pn_editar.TabIndex = 2;
            // 
            // editarGbx
            // 
            this.editarGbx.Controls.Add(this.btnCancelar);
            this.editarGbx.Controls.Add(this.Btn_Guardar);
            this.editarGbx.Controls.Add(this.updateDescripTxt);
            this.editarGbx.Controls.Add(this.label6);
            this.editarGbx.Controls.Add(this.updateNombreTxt);
            this.editarGbx.Controls.Add(this.label3);
            this.editarGbx.Location = new System.Drawing.Point(0, 0);
            this.editarGbx.Name = "editarGbx";
            this.editarGbx.Size = new System.Drawing.Size(301, 174);
            this.editarGbx.TabIndex = 29;
            this.editarGbx.TabStop = false;
            this.editarGbx.Text = "Editar Estado Sanitario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Btn_CancelarUpdate_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(17, 141);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 27;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // updateDescripTxt
            // 
            this.updateDescripTxt.Location = new System.Drawing.Point(93, 63);
            this.updateDescripTxt.Multiline = true;
            this.updateDescripTxt.Name = "updateDescripTxt";
            this.updateDescripTxt.ShortcutsEnabled = false;
            this.updateDescripTxt.Size = new System.Drawing.Size(187, 72);
            this.updateDescripTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción";
            // 
            // updateNombreTxt
            // 
            this.updateNombreTxt.Location = new System.Drawing.Point(93, 34);
            this.updateNombreTxt.Name = "updateNombreTxt";
            this.updateNombreTxt.ReadOnly = true;
            this.updateNombreTxt.Size = new System.Drawing.Size(187, 20);
            this.updateNombreTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // EstadosSanitarios_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(685, 260);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_editar);
            this.Controls.Add(this.pn_listado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstadosSanitarios_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estados Sanitarios";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionEstadoSanitario)).EndInit();
            this.paginacionEstadoSanitario.ResumeLayout(false);
            this.paginacionEstadoSanitario.PerformLayout();
            this.pn_crear.ResumeLayout(false);
            this.crearGbx.ResumeLayout(false);
            this.crearGbx.PerformLayout();
            this.pn_editar.ResumeLayout(false);
            this.editarGbx.ResumeLayout(false);
            this.editarGbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_listado;
        private System.Windows.Forms.DataGridView ListadoEstados;
        private System.Windows.Forms.BindingSource StateBSource;
        private System.Windows.Forms.BindingNavigator paginacionEstadoSanitario;
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
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_editar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox editarGbx;
        private System.Windows.Forms.TextBox updateDescripTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateNombreTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.ToolStripLabel filtrarLbl;
        private System.Windows.Forms.ToolStripComboBox criterioCbx;
        private System.Windows.Forms.ToolStripButton Btn_nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPESTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}