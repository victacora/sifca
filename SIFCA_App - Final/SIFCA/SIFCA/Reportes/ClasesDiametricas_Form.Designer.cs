namespace SIFCA
{
    partial class ClasesDiametricas_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClasesDiametricas_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.nUd_NumClases = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rangoDAP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.controladorErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tipoClaseCbx = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_NumClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de clases:";
            // 
            // nUd_NumClases
            // 
            this.nUd_NumClases.Location = new System.Drawing.Point(110, 17);
            this.nUd_NumClases.Name = "nUd_NumClases";
            this.nUd_NumClases.Size = new System.Drawing.Size(77, 20);
            this.nUd_NumClases.TabIndex = 0;
            this.nUd_NumClases.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor del rango (cm):";
            // 
            // txt_rangoDAP
            // 
            this.txt_rangoDAP.Location = new System.Drawing.Point(313, 16);
            this.txt_rangoDAP.Name = "txt_rangoDAP";
            this.txt_rangoDAP.Size = new System.Drawing.Size(77, 20);
            this.txt_rangoDAP.TabIndex = 1;
            this.txt_rangoDAP.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controladorErrores
            // 
            this.controladorErrores.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo reporte:";
            // 
            // tipoClaseCbx
            // 
            this.tipoClaseCbx.DisplayMember = "1";
            this.tipoClaseCbx.FormattingEnabled = true;
            this.tipoClaseCbx.Items.AddRange(new object[] {
            "General",
            "Valor comercial",
            "Estratos"});
            this.tipoClaseCbx.Location = new System.Drawing.Point(478, 16);
            this.tipoClaseCbx.Name = "tipoClaseCbx";
            this.tipoClaseCbx.Size = new System.Drawing.Size(193, 21);
            this.tipoClaseCbx.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DtgDatos);
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 403);
            this.panel1.TabIndex = 7;
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.AllowUserToDeleteRows = false;
            this.DtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgDatos.Location = new System.Drawing.Point(0, 0);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.Size = new System.Drawing.Size(782, 403);
            this.DtgDatos.TabIndex = 0;
            // 
            // ClasesDiametricas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tipoClaseCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_rangoDAP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUd_NumClases);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClasesDiametricas_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases diamétricas";
            ((System.ComponentModel.ISupportInitialize)(this.nUd_NumClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUd_NumClases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rangoDAP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider controladorErrores;
        private System.Windows.Forms.ComboBox tipoClaseCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DtgDatos;
    }
}