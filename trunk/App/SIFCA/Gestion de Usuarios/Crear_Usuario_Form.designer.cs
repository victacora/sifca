namespace SIFCA
{
    partial class Crear_User_Form
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
            System.Windows.Forms.Label cEDULALabel;
            System.Windows.Forms.Label usuarioLbl;
            System.Windows.Forms.Label nOMBRESLabel;
            System.Windows.Forms.Label aPELLIDOSLabel;
            System.Windows.Forms.Label cONTRASENALabel;
            this.datosEstacionGbx = new System.Windows.Forms.GroupBox();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.apellidosTxt = new System.Windows.Forms.TextBox();
            this.nombresTxt = new System.Windows.Forms.TextBox();
            this.cedulaTxt = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            cEDULALabel = new System.Windows.Forms.Label();
            usuarioLbl = new System.Windows.Forms.Label();
            nOMBRESLabel = new System.Windows.Forms.Label();
            aPELLIDOSLabel = new System.Windows.Forms.Label();
            cONTRASENALabel = new System.Windows.Forms.Label();
            this.datosEstacionGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(10, 74);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(43, 13);
            cEDULALabel.TabIndex = 9;
            cEDULALabel.Text = "Cedula:";
            // 
            // usuarioLbl
            // 
            usuarioLbl.AutoSize = true;
            usuarioLbl.Location = new System.Drawing.Point(10, 100);
            usuarioLbl.Name = "usuarioLbl";
            usuarioLbl.Size = new System.Drawing.Size(46, 13);
            usuarioLbl.TabIndex = 15;
            usuarioLbl.Text = "Usuario:";
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(10, 23);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(52, 13);
            nOMBRESLabel.TabIndex = 17;
            nOMBRESLabel.Text = "Nombres:";
            // 
            // aPELLIDOSLabel
            // 
            aPELLIDOSLabel.AutoSize = true;
            aPELLIDOSLabel.Location = new System.Drawing.Point(10, 48);
            aPELLIDOSLabel.Name = "aPELLIDOSLabel";
            aPELLIDOSLabel.Size = new System.Drawing.Size(52, 13);
            aPELLIDOSLabel.TabIndex = 19;
            aPELLIDOSLabel.Text = "Apellidos:";
            // 
            // cONTRASENALabel
            // 
            cONTRASENALabel.AutoSize = true;
            cONTRASENALabel.Location = new System.Drawing.Point(10, 126);
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
            this.datosEstacionGbx.Controls.Add(aPELLIDOSLabel);
            this.datosEstacionGbx.Controls.Add(this.apellidosTxt);
            this.datosEstacionGbx.Controls.Add(nOMBRESLabel);
            this.datosEstacionGbx.Controls.Add(this.nombresTxt);
            this.datosEstacionGbx.Controls.Add(cEDULALabel);
            this.datosEstacionGbx.Controls.Add(this.cedulaTxt);
            this.datosEstacionGbx.Controls.Add(usuarioLbl);
            this.datosEstacionGbx.Controls.Add(this.usuarioTxt);
            this.datosEstacionGbx.Controls.Add(this.cancelarBtn);
            this.datosEstacionGbx.Controls.Add(this.AceptarBtn);
            this.datosEstacionGbx.Location = new System.Drawing.Point(12, 12);
            this.datosEstacionGbx.Name = "datosEstacionGbx";
            this.datosEstacionGbx.Size = new System.Drawing.Size(338, 196);
            this.datosEstacionGbx.TabIndex = 0;
            this.datosEstacionGbx.TabStop = false;
            this.datosEstacionGbx.Text = "Datos usuario";
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Location = new System.Drawing.Point(122, 122);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Size = new System.Drawing.Size(206, 20);
            this.contrasenaTxt.TabIndex = 22;
            this.contrasenaTxt.UseSystemPasswordChar = true;
            // 
            // apellidosTxt
            // 
            this.apellidosTxt.Location = new System.Drawing.Point(122, 45);
            this.apellidosTxt.Name = "apellidosTxt";
            this.apellidosTxt.Size = new System.Drawing.Size(206, 20);
            this.apellidosTxt.TabIndex = 20;
            // 
            // nombresTxt
            // 
            this.nombresTxt.Location = new System.Drawing.Point(122, 20);
            this.nombresTxt.Name = "nombresTxt";
            this.nombresTxt.Size = new System.Drawing.Size(206, 20);
            this.nombresTxt.TabIndex = 18;
            // 
            // cedulaTxt
            // 
            this.cedulaTxt.Location = new System.Drawing.Point(122, 70);
            this.cedulaTxt.Name = "cedulaTxt";
            this.cedulaTxt.Size = new System.Drawing.Size(206, 20);
            this.cedulaTxt.TabIndex = 10;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(122, 96);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(206, 20);
            this.usuarioTxt.TabIndex = 16;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(253, 158);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 7;
            this.cancelarBtn.Text = "Salir";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(172, 158);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 6;
            this.AceptarBtn.Text = "Guardar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // Crear_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 224);
            this.Controls.Add(this.datosEstacionGbx);
            this.Name = "Crear_User_Form";
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
        private System.Windows.Forms.TextBox apellidosTxt;
        private System.Windows.Forms.TextBox nombresTxt;
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;


    }
}