namespace SIFCA.Gestion_de_Especies
{
    partial class Crear_Listado_Especies_Form
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
            this.DataGrid_Species = new System.Windows.Forms.DataGridView();
            this.SpeciesBSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODESP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPOCOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCOMUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMCIENTIFICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONAGEOGRAFICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONADEVIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAMMINCORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Species)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeciesBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.BtnIngresar);
            this.groupBox1.Controls.Add(this.DataGrid_Species);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.btnUnselectAll);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Listado Especies";
            // 
            // DataGrid_Species
            // 
            this.DataGrid_Species.AllowUserToAddRows = false;
            this.DataGrid_Species.AllowUserToOrderColumns = true;
            this.DataGrid_Species.AutoGenerateColumns = false;
            this.DataGrid_Species.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Species.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Species.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.CODESP,
            this.gRUPOCOM,
            this.nOMCOMUN,
            this.NOMCIENTIFICO,
            this.FAMILIA,
            this.ZONAGEOGRAFICA,
            this.ZONADEVIDA,
            this.DIAMMINCORTE});
            this.DataGrid_Species.DataSource = this.SpeciesBSource;
            this.DataGrid_Species.Location = new System.Drawing.Point(16, 54);
            this.DataGrid_Species.Name = "DataGrid_Species";
            this.DataGrid_Species.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGrid_Species.Size = new System.Drawing.Size(861, 222);
            this.DataGrid_Species.TabIndex = 8;
            this.DataGrid_Species.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.DataGrid_Species.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
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
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(237, 25);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(120, 23);
            this.btnUnselectAll.TabIndex = 5;
            this.btnUnselectAll.Text = "Deseleccionar Todos";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(98, 25);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(120, 23);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "Seleccionar Todos";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
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
            // Seleccion
            // 
            this.Seleccion.FalseValue = "";
            this.Seleccion.FillWeight = 75.56236F;
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.TrueValue = "";
            // 
            // CODESP
            // 
            this.CODESP.DataPropertyName = "CODESP";
            this.CODESP.HeaderText = "CODESP";
            this.CODESP.Name = "CODESP";
            this.CODESP.ReadOnly = true;
            this.CODESP.Visible = false;
            // 
            // gRUPOCOM
            // 
            this.gRUPOCOM.DataPropertyName = "GRUPOCOM";
            this.gRUPOCOM.FillWeight = 74.26701F;
            this.gRUPOCOM.HeaderText = "GRUPOCOM";
            this.gRUPOCOM.Name = "gRUPOCOM";
            // 
            // nOMCOMUN
            // 
            this.nOMCOMUN.DataPropertyName = "NOMCOMUN";
            this.nOMCOMUN.FillWeight = 74.26701F;
            this.nOMCOMUN.HeaderText = "NOMCOMUN";
            this.nOMCOMUN.Name = "nOMCOMUN";
            // 
            // NOMCIENTIFICO
            // 
            this.NOMCIENTIFICO.DataPropertyName = "NOMCIENTIFICO";
            this.NOMCIENTIFICO.FillWeight = 74.26701F;
            this.NOMCIENTIFICO.HeaderText = "NOMCIENTIFICO";
            this.NOMCIENTIFICO.Name = "NOMCIENTIFICO";
            // 
            // FAMILIA
            // 
            this.FAMILIA.DataPropertyName = "FAMILIA";
            this.FAMILIA.FillWeight = 74.26701F;
            this.FAMILIA.HeaderText = "FAMILIA";
            this.FAMILIA.Name = "FAMILIA";
            // 
            // ZONAGEOGRAFICA
            // 
            this.ZONAGEOGRAFICA.DataPropertyName = "ZONAGEOGRAFICA";
            this.ZONAGEOGRAFICA.FillWeight = 74.26701F;
            this.ZONAGEOGRAFICA.HeaderText = "ZONAGEOGRAFICA";
            this.ZONAGEOGRAFICA.Name = "ZONAGEOGRAFICA";
            // 
            // ZONADEVIDA
            // 
            this.ZONADEVIDA.DataPropertyName = "ZONADEVIDA";
            this.ZONADEVIDA.FillWeight = 74.26701F;
            this.ZONADEVIDA.HeaderText = "ZONADEVIDA";
            this.ZONADEVIDA.Name = "ZONADEVIDA";
            // 
            // DIAMMINCORTE
            // 
            this.DIAMMINCORTE.DataPropertyName = "DIAMMINCORTE";
            this.DIAMMINCORTE.FillWeight = 74.26701F;
            this.DIAMMINCORTE.HeaderText = "DIAMMINCORTE";
            this.DIAMMINCORTE.Name = "DIAMMINCORTE";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(26, 282);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(97, 27);
            this.BtnIngresar.TabIndex = 9;
            this.BtnIngresar.Text = "Crear";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // Crear_Listado_Especies_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 333);
            this.Controls.Add(this.groupBox1);
            this.Name = "Crear_Listado_Especies_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Listado Especies";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Species)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeciesBSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrid_Species;
        private System.Windows.Forms.BindingSource SpeciesBSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODESP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRUPOCOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCOMUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMCIENTIFICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONAGEOGRAFICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONADEVIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAMMINCORTE;
        private System.Windows.Forms.Button BtnIngresar;
    }
}