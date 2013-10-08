namespace SIFCA.Gestion_Configuracion
{
    partial class TiposUso_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposUso_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.ListadoTiposUso = new System.Windows.Forms.DataGridView();
            this.TypeUseBSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginacionTipoUso = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_editar = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.updateDescripcionTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.updateNombreTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nOMBRETIPOUSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTiposUso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeUseBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTipoUso)).BeginInit();
            this.paginacionTipoUso.SuspendLayout();
            this.pn_crear.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pn_editar.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_listado
            // 
            this.pn_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_listado.Controls.Add(this.ListadoTiposUso);
            this.pn_listado.Controls.Add(this.paginacionTipoUso);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(615, 267);
            this.pn_listado.TabIndex = 0;
            // 
            // ListadoTiposUso
            // 
            this.ListadoTiposUso.AllowUserToAddRows = false;
            this.ListadoTiposUso.AllowUserToDeleteRows = false;
            this.ListadoTiposUso.AutoGenerateColumns = false;
            this.ListadoTiposUso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoTiposUso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoTiposUso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBRETIPOUSODataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.ListadoTiposUso.DataSource = this.TypeUseBSource;
            this.ListadoTiposUso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoTiposUso.Location = new System.Drawing.Point(0, 27);
            this.ListadoTiposUso.Name = "ListadoTiposUso";
            this.ListadoTiposUso.ReadOnly = true;
            this.ListadoTiposUso.Size = new System.Drawing.Size(611, 236);
            this.ListadoTiposUso.TabIndex = 5;
            this.ListadoTiposUso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDeEspecies_CellValueChanged);
            // 
            // TypeUseBSource
            // 
            this.TypeUseBSource.DataSource = typeof(SIFCA_DAL.TIPODEUSO);
            // 
            // paginacionTipoUso
            // 
            this.paginacionTipoUso.AddNewItem = null;
            this.paginacionTipoUso.BindingSource = this.TypeUseBSource;
            this.paginacionTipoUso.CountItem = this.bindingNavigatorCountItem;
            this.paginacionTipoUso.DeleteItem = null;
            this.paginacionTipoUso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paginacionTipoUso.Location = new System.Drawing.Point(0, 0);
            this.paginacionTipoUso.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paginacionTipoUso.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paginacionTipoUso.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paginacionTipoUso.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paginacionTipoUso.Name = "paginacionTipoUso";
            this.paginacionTipoUso.PositionItem = this.bindingNavigatorPositionItem;
            this.paginacionTipoUso.Size = new System.Drawing.Size(611, 27);
            this.paginacionTipoUso.TabIndex = 4;
            this.paginacionTipoUso.Text = "bindingNavigator1";
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
            this.Btn_nuevo.Size = new System.Drawing.Size(46, 24);
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
            "Nombre",
            "Descripcion"});
            this.criterioCbx.Name = "criterioCbx";
            this.criterioCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // pn_crear
            // 
            this.pn_crear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_crear.Controls.Add(this.groupBox1);
            this.pn_crear.Location = new System.Drawing.Point(0, 0);
            this.pn_crear.Name = "pn_crear";
            this.pn_crear.Size = new System.Drawing.Size(357, 225);
            this.pn_crear.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Cancelar);
            this.groupBox1.Controls.Add(this.Btn_Crear);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Tipo De Uso";
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
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(121, 28);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(179, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // pn_editar
            // 
            this.pn_editar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_editar.Controls.Add(this.groupBox);
            this.pn_editar.Location = new System.Drawing.Point(0, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(340, 203);
            this.pn_editar.TabIndex = 2;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.updateDescripcionTxt);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.Btn_Guardar);
            this.groupBox.Controls.Add(this.updateNombreTxt);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(314, 169);
            this.groupBox.TabIndex = 29;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Editar Tipo Uso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_CancelarUpdate_Click);
            // 
            // updateDescripcionTxt
            // 
            this.updateDescripcionTxt.Location = new System.Drawing.Point(101, 50);
            this.updateDescripcionTxt.Multiline = true;
            this.updateDescripcionTxt.Name = "updateDescripcionTxt";
            this.updateDescripcionTxt.ShortcutsEnabled = false;
            this.updateDescripcionTxt.Size = new System.Drawing.Size(187, 72);
            this.updateDescripcionTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(22, 135);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 27;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // updateNombreTxt
            // 
            this.updateNombreTxt.Location = new System.Drawing.Point(101, 21);
            this.updateNombreTxt.Name = "updateNombreTxt";
            this.updateNombreTxt.ReadOnly = true;
            this.updateNombreTxt.Size = new System.Drawing.Size(187, 20);
            this.updateNombreTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // nOMBRETIPOUSODataGridViewTextBoxColumn
            // 
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.DataPropertyName = "NOMBRETIPOUSO";
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.Name = "nOMBRETIPOUSODataGridViewTextBoxColumn";
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBRETIPOUSODataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Eliminar.DataPropertyName = "NOMBRETIPOUSO";
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 5;
            // 
            // TiposUso_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 266);
            this.Controls.Add(this.pn_editar);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_listado);
            this.Name = "TiposUso_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Uso";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTiposUso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeUseBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionTipoUso)).EndInit();
            this.paginacionTipoUso.ResumeLayout(false);
            this.paginacionTipoUso.PerformLayout();
            this.pn_crear.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_editar.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_listado;
        private System.Windows.Forms.DataGridView ListadoTiposUso;
        private System.Windows.Forms.BindingSource TypeUseBSource;
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
        private System.Windows.Forms.ToolStripTextBox busquedaTxt;
        private System.Windows.Forms.ToolStripLabel filtrarLbl;
        private System.Windows.Forms.ToolStripComboBox criterioCbx;
        private System.Windows.Forms.Panel pn_crear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_editar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox updateDescripcionTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox updateNombreTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton Btn_nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRETIPOUSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}