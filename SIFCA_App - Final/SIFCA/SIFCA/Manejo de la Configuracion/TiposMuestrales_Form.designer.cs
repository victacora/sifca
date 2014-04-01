namespace SIFCA.Gestion_Configuracion
{
    partial class TiposMuestrales_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposMuestrales_Form));
            this.pn_listado = new System.Windows.Forms.Panel();
            this.ListadoTiposMuestrales = new System.Windows.Forms.DataGridView();
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TypeSampleDesingBSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginacionGruposCom = new System.Windows.Forms.BindingNavigator(this.components);
            this.Btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.buscarLbl = new System.Windows.Forms.ToolStripLabel();
            this.busquedaTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
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
            this.btn_cancelarUpdate = new System.Windows.Forms.Button();
            this.updateDescripcionTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.updateNombreTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eP_errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.pn_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTiposMuestrales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeSampleDesingBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionGruposCom)).BeginInit();
            this.paginacionGruposCom.SuspendLayout();
            this.pn_crear.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pn_editar.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_listado
            // 
            this.pn_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_listado.Controls.Add(this.ListadoTiposMuestrales);
            this.pn_listado.Controls.Add(this.paginacionGruposCom);
            this.pn_listado.Location = new System.Drawing.Point(0, 0);
            this.pn_listado.Name = "pn_listado";
            this.pn_listado.Size = new System.Drawing.Size(650, 297);
            this.pn_listado.TabIndex = 0;
            // 
            // ListadoTiposMuestrales
            // 
            this.ListadoTiposMuestrales.AllowUserToAddRows = false;
            this.ListadoTiposMuestrales.AllowUserToDeleteRows = false;
            this.ListadoTiposMuestrales.AutoGenerateColumns = false;
            this.ListadoTiposMuestrales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoTiposMuestrales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoTiposMuestrales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn,
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.ListadoTiposMuestrales.DataSource = this.TypeSampleDesingBSource;
            this.ListadoTiposMuestrales.Location = new System.Drawing.Point(0, 25);
            this.ListadoTiposMuestrales.Name = "ListadoTiposMuestrales";
            this.ListadoTiposMuestrales.ReadOnly = true;
            this.ListadoTiposMuestrales.Size = new System.Drawing.Size(632, 268);
            this.ListadoTiposMuestrales.TabIndex = 5;
            this.ListadoTiposMuestrales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listado_CellValueChanged);
            // 
            // nOMTIPODISEMUESTDataGridViewTextBoxColumn
            // 
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn.DataPropertyName = "NOMTIPODISEMUEST";
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn.Name = "nOMTIPODISEMUESTDataGridViewTextBoxColumn";
            this.nOMTIPODISEMUESTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTIPODISEMUEST";
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn.Name = "dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn";
            this.dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 5;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Eliminar.DataPropertyName = "NOMTIPODISEMUEST";
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 5;
            // 
            // TypeSampleDesingBSource
            // 
            this.TypeSampleDesingBSource.DataSource = typeof(SIFCA_DAL.TIPODISENOMUESTRAL);
            // 
            // paginacionGruposCom
            // 
            this.paginacionGruposCom.AddNewItem = null;
            this.paginacionGruposCom.BindingSource = this.TypeSampleDesingBSource;
            this.paginacionGruposCom.CountItem = null;
            this.paginacionGruposCom.DeleteItem = null;
            this.paginacionGruposCom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_nuevo,
            this.buscarLbl,
            this.busquedaTxt,
            this.toolStripLabel1,
            this.criterioCbx});
            this.paginacionGruposCom.Location = new System.Drawing.Point(0, 0);
            this.paginacionGruposCom.MoveFirstItem = null;
            this.paginacionGruposCom.MoveLastItem = null;
            this.paginacionGruposCom.MoveNextItem = null;
            this.paginacionGruposCom.MovePreviousItem = null;
            this.paginacionGruposCom.Name = "paginacionGruposCom";
            this.paginacionGruposCom.PositionItem = null;
            this.paginacionGruposCom.Size = new System.Drawing.Size(646, 25);
            this.paginacionGruposCom.TabIndex = 4;
            this.paginacionGruposCom.Text = "bindingNavigator1";
            this.paginacionGruposCom.TextChanged += new System.EventHandler(this.busquedaTxt_TextChanged);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nuevo.Image")));
            this.Btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(46, 22);
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.ToolTipText = "Nuevo tipo diseño";
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel1.Text = "Filtar";
            // 
            // criterioCbx
            // 
            this.criterioCbx.AutoCompleteCustomSource.AddRange(new string[] {
            "Nombre",
            "Descripcion"});
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
            this.pn_crear.Size = new System.Drawing.Size(347, 219);
            this.pn_crear.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Cancelar);
            this.groupBox1.Controls.Add(this.Btn_Crear);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Tipo Muestreo";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(224, 146);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(76, 23);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(121, 145);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(79, 23);
            this.Btn_Crear.TabIndex = 4;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(121, 66);
            this.txt_Descripcion.MaxLength = 500;
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
            this.txt_Nombre.MaxLength = 2;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(179, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abreviatura";
            // 
            // pn_editar
            // 
            this.pn_editar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_editar.Controls.Add(this.groupBox);
            this.pn_editar.Location = new System.Drawing.Point(1, 0);
            this.pn_editar.Name = "pn_editar";
            this.pn_editar.Size = new System.Drawing.Size(322, 214);
            this.pn_editar.TabIndex = 5;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btn_cancelarUpdate);
            this.groupBox.Controls.Add(this.updateDescripcionTxt);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.btn_Guardar);
            this.groupBox.Controls.Add(this.updateNombreTxt);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Location = new System.Drawing.Point(8, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(283, 167);
            this.groupBox.TabIndex = 29;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Editar Tipo Muestral";
            // 
            // btn_cancelarUpdate
            // 
            this.btn_cancelarUpdate.Location = new System.Drawing.Point(188, 131);
            this.btn_cancelarUpdate.Name = "btn_cancelarUpdate";
            this.btn_cancelarUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarUpdate.TabIndex = 28;
            this.btn_cancelarUpdate.Text = "Cancelar";
            this.btn_cancelarUpdate.UseVisualStyleBackColor = true;
            this.btn_cancelarUpdate.Click += new System.EventHandler(this.Btn_CancelarUpdate_Click);
            // 
            // updateDescripcionTxt
            // 
            this.updateDescripcionTxt.Location = new System.Drawing.Point(92, 53);
            this.updateDescripcionTxt.MaxLength = 500;
            this.updateDescripcionTxt.Multiline = true;
            this.updateDescripcionTxt.Name = "updateDescripcionTxt";
            this.updateDescripcionTxt.ShortcutsEnabled = false;
            this.updateDescripcionTxt.Size = new System.Drawing.Size(171, 72);
            this.updateDescripcionTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(92, 131);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 27;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // updateNombreTxt
            // 
            this.updateNombreTxt.Location = new System.Drawing.Point(92, 24);
            this.updateNombreTxt.Name = "updateNombreTxt";
            this.updateNombreTxt.ReadOnly = true;
            this.updateNombreTxt.Size = new System.Drawing.Size(171, 20);
            this.updateNombreTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // eP_errors
            // 
            this.eP_errors.ContainerControl = this;
            // 
            // TiposMuestrales_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 307);
            this.Controls.Add(this.pn_crear);
            this.Controls.Add(this.pn_listado);
            this.Controls.Add(this.pn_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TiposMuestrales_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos Muestrales";
            this.pn_listado.ResumeLayout(false);
            this.pn_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTiposMuestrales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeSampleDesingBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginacionGruposCom)).EndInit();
            this.paginacionGruposCom.ResumeLayout(false);
            this.paginacionGruposCom.PerformLayout();
            this.pn_crear.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_editar.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eP_errors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_listado;
        private System.Windows.Forms.DataGridView ListadoTiposMuestrales;
        private System.Windows.Forms.BindingSource TypeSampleDesingBSource;
        private System.Windows.Forms.BindingNavigator paginacionGruposCom;
        private System.Windows.Forms.ToolStripLabel buscarLbl;
        private System.Windows.Forms.ToolStripTextBox busquedaTxt;
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
        private System.Windows.Forms.Button btn_cancelarUpdate;
        private System.Windows.Forms.TextBox updateDescripcionTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox updateNombreTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton Btn_nuevo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox criterioCbx;
        private System.Windows.Forms.ErrorProvider eP_errors;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMTIPODISEMUESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIPODISEMUESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}