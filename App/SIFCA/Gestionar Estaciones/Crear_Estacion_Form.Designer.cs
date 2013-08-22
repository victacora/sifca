namespace SIFCA
{
    partial class Estacion_Form
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
            System.Windows.Forms.Label nombreLbl;
            System.Windows.Forms.Label responsableLbl;
            System.Windows.Forms.Label codigoLbl;
            this.datosEstacionGbx = new System.Windows.Forms.GroupBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.responsableTxt = new System.Windows.Forms.TextBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            nombreLbl = new System.Windows.Forms.Label();
            responsableLbl = new System.Windows.Forms.Label();
            codigoLbl = new System.Windows.Forms.Label();
            this.datosEstacionGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // datosEstacionGbx
            // 
            this.datosEstacionGbx.BackColor = System.Drawing.SystemColors.Control;
            this.datosEstacionGbx.Controls.Add(codigoLbl);
            this.datosEstacionGbx.Controls.Add(this.codigoTxt);
            this.datosEstacionGbx.Controls.Add(this.cancelarBtn);
            this.datosEstacionGbx.Controls.Add(this.AceptarBtn);
            this.datosEstacionGbx.Controls.Add(nombreLbl);
            this.datosEstacionGbx.Controls.Add(this.nombreTxt);
            this.datosEstacionGbx.Controls.Add(responsableLbl);
            this.datosEstacionGbx.Controls.Add(this.responsableTxt);
            this.datosEstacionGbx.Location = new System.Drawing.Point(12, 12);
            this.datosEstacionGbx.Name = "datosEstacionGbx";
            this.datosEstacionGbx.Size = new System.Drawing.Size(334, 139);
            this.datosEstacionGbx.TabIndex = 0;
            this.datosEstacionGbx.TabStop = false;
            this.datosEstacionGbx.Text = "Datos estacion";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new System.Drawing.Point(20, 46);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new System.Drawing.Size(90, 13);
            nombreLbl.TabIndex = 0;
            nombreLbl.Text = "Nombre estacion:";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(122, 44);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(202, 20);
            this.nombreTxt.TabIndex = 1;
            // 
            // responsableLbl
            // 
            responsableLbl.AutoSize = true;
            responsableLbl.Location = new System.Drawing.Point(20, 73);
            responsableLbl.Name = "responsableLbl";
            responsableLbl.Size = new System.Drawing.Size(72, 13);
            responsableLbl.TabIndex = 4;
            responsableLbl.Text = "Responsable:";
            // 
            // responsableTxt
            // 
            this.responsableTxt.Location = new System.Drawing.Point(122, 70);
            this.responsableTxt.Name = "responsableTxt";
            this.responsableTxt.Size = new System.Drawing.Size(202, 20);
            this.responsableTxt.TabIndex = 5;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(168, 110);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 6;
            this.AceptarBtn.Text = "Guardar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(249, 110);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 7;
            this.cancelarBtn.Text = "Salir";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // codigoLbl
            // 
            codigoLbl.AutoSize = true;
            codigoLbl.Location = new System.Drawing.Point(20, 19);
            codigoLbl.Name = "codigoLbl";
            codigoLbl.Size = new System.Drawing.Size(74, 13);
            codigoLbl.TabIndex = 8;
            codigoLbl.Text = "Codigo Unico:";
            // 
            // codigoTxt
            // 
            this.codigoTxt.Enabled = false;
            this.codigoTxt.Location = new System.Drawing.Point(123, 16);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(202, 20);
            this.codigoTxt.TabIndex = 9;
            // 
            // Estacion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 160);
            this.Controls.Add(this.datosEstacionGbx);
            this.Name = "Estacion_Form";
            this.Text = "Gestionar estacion";
            this.datosEstacionGbx.ResumeLayout(false);
            this.datosEstacionGbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datosEstacionGbx;
        private System.Windows.Forms.TextBox codigoTxt;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox responsableTxt;


    }
}