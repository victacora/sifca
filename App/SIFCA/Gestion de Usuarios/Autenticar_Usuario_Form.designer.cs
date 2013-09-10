namespace SIFCA
{
    partial class Autenticar_Usuario_Form
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
            System.Windows.Forms.Label usuarioLbl;
            System.Windows.Forms.Label cONTRASENALabel;
            this.datosEstacionGbx = new System.Windows.Forms.GroupBox();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            usuarioLbl = new System.Windows.Forms.Label();
            cONTRASENALabel = new System.Windows.Forms.Label();
            this.datosEstacionGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioLbl
            // 
            usuarioLbl.AutoSize = true;
            usuarioLbl.Location = new System.Drawing.Point(11, 22);
            usuarioLbl.Name = "usuarioLbl";
            usuarioLbl.Size = new System.Drawing.Size(46, 13);
            usuarioLbl.TabIndex = 15;
            usuarioLbl.Text = "Usuario:";
            // 
            // cONTRASENALabel
            // 
            cONTRASENALabel.AutoSize = true;
            cONTRASENALabel.Location = new System.Drawing.Point(11, 48);
            cONTRASENALabel.Name = "cONTRASENALabel";
            cONTRASENALabel.Size = new System.Drawing.Size(64, 13);
            cONTRASENALabel.TabIndex = 21;
            cONTRASENALabel.Text = "Contraseña:";
            // 
            // datosEstacionGbx
            // 
            this.datosEstacionGbx.BackColor = System.Drawing.SystemColors.Control;
            this.datosEstacionGbx.Controls.Add(cONTRASENALabel);
            this.datosEstacionGbx.Controls.Add(this.contrasenaTxt);
            this.datosEstacionGbx.Controls.Add(usuarioLbl);
            this.datosEstacionGbx.Controls.Add(this.usuarioTxt);
            this.datosEstacionGbx.Controls.Add(this.cancelarBtn);
            this.datosEstacionGbx.Controls.Add(this.AceptarBtn);
            this.datosEstacionGbx.Location = new System.Drawing.Point(12, 12);
            this.datosEstacionGbx.Name = "datosEstacionGbx";
            this.datosEstacionGbx.Size = new System.Drawing.Size(338, 116);
            this.datosEstacionGbx.TabIndex = 0;
            this.datosEstacionGbx.TabStop = false;
            this.datosEstacionGbx.Text = "Datos usuario";
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Location = new System.Drawing.Point(123, 44);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Size = new System.Drawing.Size(206, 20);
            this.contrasenaTxt.TabIndex = 22;
            this.contrasenaTxt.UseSystemPasswordChar = true;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(123, 18);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(206, 20);
            this.usuarioTxt.TabIndex = 16;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(254, 80);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 7;
            this.cancelarBtn.Text = "Salir";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(173, 80);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 6;
            this.AceptarBtn.Text = "Ingresar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // Autenticar_Usuario_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 137);
            this.Controls.Add(this.datosEstacionGbx);
            this.Name = "Autenticar_Usuario_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar usuarios";
            this.datosEstacionGbx.ResumeLayout(false);
            this.datosEstacionGbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datosEstacionGbx;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;


    }
}