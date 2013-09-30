namespace SIFCA
{
    partial class Realizar_Copia_Seguridad_Form
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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.datosCopiaSeguridadGrx = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoCopiaCbx = new System.Windows.Forms.ComboBox();
            this.ubicacionTxt = new System.Windows.Forms.TextBox();
            this.directorioLbl = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.datosCopiaSeguridadGrx.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(315, 115);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 5;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(234, 115);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 6;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // datosCopiaSeguridadGrx
            // 
            this.datosCopiaSeguridadGrx.Controls.Add(this.label2);
            this.datosCopiaSeguridadGrx.Controls.Add(this.tipoCopiaCbx);
            this.datosCopiaSeguridadGrx.Controls.Add(this.ubicacionTxt);
            this.datosCopiaSeguridadGrx.Controls.Add(this.directorioLbl);
            this.datosCopiaSeguridadGrx.Controls.Add(this.buscarBtn);
            this.datosCopiaSeguridadGrx.Location = new System.Drawing.Point(12, 12);
            this.datosCopiaSeguridadGrx.Name = "datosCopiaSeguridadGrx";
            this.datosCopiaSeguridadGrx.Size = new System.Drawing.Size(378, 97);
            this.datosCopiaSeguridadGrx.TabIndex = 7;
            this.datosCopiaSeguridadGrx.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de Copia:";
            // 
            // tipoCopiaCbx
            // 
            this.tipoCopiaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCopiaCbx.FormattingEnabled = true;
            this.tipoCopiaCbx.Items.AddRange(new object[] {
            "Full",
            "Differential"});
            this.tipoCopiaCbx.Location = new System.Drawing.Point(84, 58);
            this.tipoCopiaCbx.Name = "tipoCopiaCbx";
            this.tipoCopiaCbx.Size = new System.Drawing.Size(277, 21);
            this.tipoCopiaCbx.TabIndex = 8;
            // 
            // ubicacionTxt
            // 
            this.ubicacionTxt.Location = new System.Drawing.Point(84, 26);
            this.ubicacionTxt.Name = "ubicacionTxt";
            this.ubicacionTxt.Size = new System.Drawing.Size(226, 20);
            this.ubicacionTxt.TabIndex = 7;
            this.ubicacionTxt.Text = "C:\\";
            // 
            // directorioLbl
            // 
            this.directorioLbl.AutoSize = true;
            this.directorioLbl.Location = new System.Drawing.Point(7, 24);
            this.directorioLbl.Name = "directorioLbl";
            this.directorioLbl.Size = new System.Drawing.Size(58, 13);
            this.directorioLbl.TabIndex = 6;
            this.directorioLbl.Text = "Ubicacion:";
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(310, 24);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(51, 23);
            this.buscarBtn.TabIndex = 5;
            this.buscarBtn.Text = "buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // Realizar_Copia_Seguridad_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 147);
            this.Controls.Add(this.datosCopiaSeguridadGrx);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Realizar_Copia_Seguridad_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar copia de seguridad";
            this.datosCopiaSeguridadGrx.ResumeLayout(false);
            this.datosCopiaSeguridadGrx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.GroupBox datosCopiaSeguridadGrx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipoCopiaCbx;
        private System.Windows.Forms.TextBox ubicacionTxt;
        private System.Windows.Forms.Label directorioLbl;
        private System.Windows.Forms.Button buscarBtn;

    }
}