﻿namespace SIFCA
{
    partial class Crear_Usuario_Form
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cONTRASENALabel;
            System.Windows.Forms.Label aPELLIDOSLabel;
            System.Windows.Forms.Label nOMBRESLabel;
            System.Windows.Forms.Label cEDULALabel;
            System.Windows.Forms.Label usuarioLbl;
            System.Windows.Forms.Label tipoUsuarioLbl;
            this.verificarContrasenaTxt = new System.Windows.Forms.TextBox();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.apellidosTxt = new System.Windows.Forms.TextBox();
            this.nombresTxt = new System.Windows.Forms.TextBox();
            this.cedulaTxt = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.imageNewUser = new System.Windows.Forms.PictureBox();
            this.tipoUsuarioCbx = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            cONTRASENALabel = new System.Windows.Forms.Label();
            aPELLIDOSLabel = new System.Windows.Forms.Label();
            nOMBRESLabel = new System.Windows.Forms.Label();
            cEDULALabel = new System.Windows.Forms.Label();
            usuarioLbl = new System.Windows.Forms.Label();
            tipoUsuarioLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 244);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 13);
            label1.TabIndex = 38;
            label1.Text = "Verificar Contraseña:";
            // 
            // cONTRASENALabel
            // 
            cONTRASENALabel.AutoSize = true;
            cONTRASENALabel.Location = new System.Drawing.Point(22, 218);
            cONTRASENALabel.Name = "cONTRASENALabel";
            cONTRASENALabel.Size = new System.Drawing.Size(64, 13);
            cONTRASENALabel.TabIndex = 36;
            cONTRASENALabel.Text = "Contraseña:";
            // 
            // aPELLIDOSLabel
            // 
            aPELLIDOSLabel.AutoSize = true;
            aPELLIDOSLabel.Location = new System.Drawing.Point(22, 109);
            aPELLIDOSLabel.Name = "aPELLIDOSLabel";
            aPELLIDOSLabel.Size = new System.Drawing.Size(52, 13);
            aPELLIDOSLabel.TabIndex = 35;
            aPELLIDOSLabel.Text = "Apellidos:";
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(22, 84);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(52, 13);
            nOMBRESLabel.TabIndex = 34;
            nOMBRESLabel.Text = "Nombres:";
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(22, 135);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(43, 13);
            cEDULALabel.TabIndex = 32;
            cEDULALabel.Text = "Cedula:";
            // 
            // usuarioLbl
            // 
            usuarioLbl.AutoSize = true;
            usuarioLbl.Location = new System.Drawing.Point(22, 192);
            usuarioLbl.Name = "usuarioLbl";
            usuarioLbl.Size = new System.Drawing.Size(46, 13);
            usuarioLbl.TabIndex = 33;
            usuarioLbl.Text = "Usuario:";
            // 
            // verificarContrasenaTxt
            // 
            this.verificarContrasenaTxt.Location = new System.Drawing.Point(134, 240);
            this.verificarContrasenaTxt.Name = "verificarContrasenaTxt";
            this.verificarContrasenaTxt.Size = new System.Drawing.Size(206, 20);
            this.verificarContrasenaTxt.TabIndex = 37;
            this.verificarContrasenaTxt.UseSystemPasswordChar = true;
            this.verificarContrasenaTxt.TextChanged += new System.EventHandler(this.verificarContrasenaTxt_TextChanged);
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Location = new System.Drawing.Point(134, 214);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Size = new System.Drawing.Size(206, 20);
            this.contrasenaTxt.TabIndex = 29;
            this.contrasenaTxt.UseSystemPasswordChar = true;
            this.contrasenaTxt.TextChanged += new System.EventHandler(this.verificarContrasenaTxt_TextChanged);
            // 
            // apellidosTxt
            // 
            this.apellidosTxt.Location = new System.Drawing.Point(134, 106);
            this.apellidosTxt.Name = "apellidosTxt";
            this.apellidosTxt.Size = new System.Drawing.Size(206, 20);
            this.apellidosTxt.TabIndex = 26;
            // 
            // nombresTxt
            // 
            this.nombresTxt.Location = new System.Drawing.Point(134, 81);
            this.nombresTxt.Name = "nombresTxt";
            this.nombresTxt.Size = new System.Drawing.Size(206, 20);
            this.nombresTxt.TabIndex = 25;
            // 
            // cedulaTxt
            // 
            this.cedulaTxt.Location = new System.Drawing.Point(134, 131);
            this.cedulaTxt.Name = "cedulaTxt";
            this.cedulaTxt.Size = new System.Drawing.Size(206, 20);
            this.cedulaTxt.TabIndex = 27;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(134, 188);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(206, 20);
            this.usuarioTxt.TabIndex = 28;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(250, 304);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(90, 23);
            this.cancelarBtn.TabIndex = 31;
            this.cancelarBtn.Text = "Salir";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(155, 304);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(90, 23);
            this.AceptarBtn.TabIndex = 30;
            this.AceptarBtn.Text = "Guardar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(131, 274);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 39;
            // 
            // imageNewUser
            // 
            this.imageNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageNewUser.Image = global::SIFCA.Properties.Resources.agregar_usuarios;
            this.imageNewUser.Location = new System.Drawing.Point(0, 0);
            this.imageNewUser.Name = "imageNewUser";
            this.imageNewUser.Size = new System.Drawing.Size(360, 62);
            this.imageNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNewUser.TabIndex = 24;
            this.imageNewUser.TabStop = false;
            // 
            // tipoUsuarioCbx
            // 
            this.tipoUsuarioCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuarioCbx.FormattingEnabled = true;
            this.tipoUsuarioCbx.Items.AddRange(new object[] {
            "Administrador",
            "No Administrador"});
            this.tipoUsuarioCbx.Location = new System.Drawing.Point(134, 160);
            this.tipoUsuarioCbx.Name = "tipoUsuarioCbx";
            this.tipoUsuarioCbx.Size = new System.Drawing.Size(206, 21);
            this.tipoUsuarioCbx.TabIndex = 44;
            // 
            // tipoUsuarioLbl
            // 
            tipoUsuarioLbl.AutoSize = true;
            tipoUsuarioLbl.Location = new System.Drawing.Point(21, 165);
            tipoUsuarioLbl.Name = "tipoUsuarioLbl";
            tipoUsuarioLbl.Size = new System.Drawing.Size(68, 13);
            tipoUsuarioLbl.TabIndex = 43;
            tipoUsuarioLbl.Text = "Tipo usuario:";
            // 
            // Crear_Usuario_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(360, 344);
            this.Controls.Add(this.tipoUsuarioCbx);
            this.Controls.Add(tipoUsuarioLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(label1);
            this.Controls.Add(this.verificarContrasenaTxt);
            this.Controls.Add(cONTRASENALabel);
            this.Controls.Add(this.contrasenaTxt);
            this.Controls.Add(aPELLIDOSLabel);
            this.Controls.Add(this.apellidosTxt);
            this.Controls.Add(nOMBRESLabel);
            this.Controls.Add(this.nombresTxt);
            this.Controls.Add(cEDULALabel);
            this.Controls.Add(this.cedulaTxt);
            this.Controls.Add(usuarioLbl);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.imageNewUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Crear_Usuario_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.imageNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageNewUser;
        private System.Windows.Forms.TextBox verificarContrasenaTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;
        private System.Windows.Forms.TextBox apellidosTxt;
        private System.Windows.Forms.TextBox nombresTxt;
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.ComboBox tipoUsuarioCbx;



    }
}