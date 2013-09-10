namespace SIFCA.Gestion_de_Especies
{
    partial class Crear_Listado_Especies
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gRUPOCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCOMUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCIENTIFICODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMILIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zONAGEOGRAFICADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zONADEVIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIAMMINCORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeciesBSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeciesBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Listado Especies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.gRUPOCOMDataGridViewTextBoxColumn,
            this.nOMCOMUNDataGridViewTextBoxColumn,
            this.nOMCIENTIFICODataGridViewTextBoxColumn,
            this.fAMILIADataGridViewTextBoxColumn,
            this.zONAGEOGRAFICADataGridViewTextBoxColumn,
            this.zONADEVIDADataGridViewTextBoxColumn,
            this.dIAMMINCORTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.SpeciesBSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(861, 222);
            this.dataGridView1.TabIndex = 8;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Lista Seleccionados";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.ReadOnly = true;
            // 
            // gRUPOCOMDataGridViewTextBoxColumn
            // 
            this.gRUPOCOMDataGridViewTextBoxColumn.DataPropertyName = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn.HeaderText = "GRUPOCOM";
            this.gRUPOCOMDataGridViewTextBoxColumn.Name = "gRUPOCOMDataGridViewTextBoxColumn";
            this.gRUPOCOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMCOMUNDataGridViewTextBoxColumn
            // 
            this.nOMCOMUNDataGridViewTextBoxColumn.DataPropertyName = "NOMCOMUN";
            this.nOMCOMUNDataGridViewTextBoxColumn.HeaderText = "NOMCOMUN";
            this.nOMCOMUNDataGridViewTextBoxColumn.Name = "nOMCOMUNDataGridViewTextBoxColumn";
            this.nOMCOMUNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMCIENTIFICODataGridViewTextBoxColumn
            // 
            this.nOMCIENTIFICODataGridViewTextBoxColumn.DataPropertyName = "NOMCIENTIFICO";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.HeaderText = "NOMCIENTIFICO";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.Name = "nOMCIENTIFICODataGridViewTextBoxColumn";
            this.nOMCIENTIFICODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fAMILIADataGridViewTextBoxColumn
            // 
            this.fAMILIADataGridViewTextBoxColumn.DataPropertyName = "FAMILIA";
            this.fAMILIADataGridViewTextBoxColumn.HeaderText = "FAMILIA";
            this.fAMILIADataGridViewTextBoxColumn.Name = "fAMILIADataGridViewTextBoxColumn";
            this.fAMILIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zONAGEOGRAFICADataGridViewTextBoxColumn
            // 
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.DataPropertyName = "ZONAGEOGRAFICA";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.HeaderText = "ZONAGEOGRAFICA";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.Name = "zONAGEOGRAFICADataGridViewTextBoxColumn";
            this.zONAGEOGRAFICADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zONADEVIDADataGridViewTextBoxColumn
            // 
            this.zONADEVIDADataGridViewTextBoxColumn.DataPropertyName = "ZONADEVIDA";
            this.zONADEVIDADataGridViewTextBoxColumn.HeaderText = "ZONADEVIDA";
            this.zONADEVIDADataGridViewTextBoxColumn.Name = "zONADEVIDADataGridViewTextBoxColumn";
            this.zONADEVIDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIAMMINCORTEDataGridViewTextBoxColumn
            // 
            this.dIAMMINCORTEDataGridViewTextBoxColumn.DataPropertyName = "DIAMMINCORTE";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.HeaderText = "DIAMMINCORTE";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.Name = "dIAMMINCORTEDataGridViewTextBoxColumn";
            this.dIAMMINCORTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SpeciesBSource
            // 
            this.SpeciesBSource.DataSource = typeof(SIFCA_DAL.ESPECIE);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(26, 238);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(237, 25);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(120, 23);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Deseleccionar Todos";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(98, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Seleccionar Todos";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especies";
            // 
            // Crear_Listado_Especies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 300);
            this.Controls.Add(this.groupBox1);
            this.Name = "Crear_Listado_Especies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear_Listado_Especies";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeciesBSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource SpeciesBSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOCOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCIENTIFICODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMILIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zONAGEOGRAFICADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zONADEVIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIAMMINCORTEDataGridViewTextBoxColumn;
    }
}