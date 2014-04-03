namespace SIFCA
{
    partial class Actualizar_Usuario_Form
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cONTRASENALabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label nOMBRESLabel;
            System.Windows.Forms.Label cEDULALabel;
            System.Windows.Forms.Label usuarioLbl;
            System.Windows.Forms.Label tipoUsuarioLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Usuario_Form));
            this.verificarContrasenaTxt = new System.Windows.Forms.TextBox();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.apellidosTxt = new System.Windows.Forms.TextBox();
            this.nombresTxt = new System.Windows.Forms.TextBox();
            this.cedulaTxt = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.imageNewUser = new System.Windows.Forms.PictureBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.tipoUsuarioCbx = new System.Windows.Forms.ComboBox();
            this.verContrasena = new System.Windows.Forms.Button();
            this.controladorErrores = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            cONTRASENALabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            nOMBRESLabel = new System.Windows.Forms.Label();
            cEDULALabel = new System.Windows.Forms.Label();
            usuarioLbl = new System.Windows.Forms.Label();
            tipoUsuarioLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageNewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 249);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 13);
            label1.TabIndex = 38;
            label1.Text = "Verificar contraseña:";
            // 
            // cONTRASENALabel
            // 
            cONTRASENALabel.AutoSize = true;
            cONTRASENALabel.Location = new System.Drawing.Point(19, 223);
            cONTRASENALabel.Name = "cONTRASENALabel";
            cONTRASENALabel.Size = new System.Drawing.Size(64, 13);
            cONTRASENALabel.TabIndex = 37;
            cONTRASENALabel.Text = "Contraseña:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(19, 117);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 36;
            apellidosLabel.Text = "Apellidos:";
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(19, 92);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(52, 13);
            nOMBRESLabel.TabIndex = 35;
            nOMBRESLabel.Text = "Nombres:";
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(19, 143);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(43, 13);
            cEDULALabel.TabIndex = 33;
            cEDULALabel.Text = "Cedula:";
            // 
            // usuarioLbl
            // 
            usuarioLbl.AutoSize = true;
            usuarioLbl.Location = new System.Drawing.Point(19, 197);
            usuarioLbl.Name = "usuarioLbl";
            usuarioLbl.Size = new System.Drawing.Size(46, 13);
            usuarioLbl.TabIndex = 34;
            usuarioLbl.Text = "Usuario:";
            // 
            // tipoUsuarioLbl
            // 
            tipoUsuarioLbl.AutoSize = true;
            tipoUsuarioLbl.Location = new System.Drawing.Point(18, 170);
            tipoUsuarioLbl.Name = "tipoUsuarioLbl";
            tipoUsuarioLbl.Size = new System.Drawing.Size(68, 13);
            tipoUsuarioLbl.TabIndex = 41;
            tipoUsuarioLbl.Text = "Tipo usuario:";
            // 
            // verificarContrasenaTxt
            // 
            this.verificarContrasenaTxt.Location = new System.Drawing.Point(131, 245);
            this.verificarContrasenaTxt.Name = "verificarContrasenaTxt";
            this.verificarContrasenaTxt.Size = new System.Drawing.Size(206, 20);
            this.verificarContrasenaTxt.TabIndex = 7;
            this.verificarContrasenaTxt.UseSystemPasswordChar = true;
            this.verificarContrasenaTxt.TextChanged += new System.EventHandler(this.verificarContrasenaTxt_TextChanged);
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Location = new System.Drawing.Point(131, 219);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Size = new System.Drawing.Size(206, 20);
            this.contrasenaTxt.TabIndex = 6;
            this.contrasenaTxt.UseSystemPasswordChar = true;
            this.contrasenaTxt.TextChanged += new System.EventHandler(this.verificarContrasenaTxt_TextChanged);
            // 
            // apellidosTxt
            // 
            this.apellidosTxt.Location = new System.Drawing.Point(131, 114);
            this.apellidosTxt.Name = "apellidosTxt";
            this.apellidosTxt.Size = new System.Drawing.Size(206, 20);
            this.apellidosTxt.TabIndex = 2;
            // 
            // nombresTxt
            // 
            this.nombresTxt.Location = new System.Drawing.Point(131, 89);
            this.nombresTxt.Name = "nombresTxt";
            this.nombresTxt.Size = new System.Drawing.Size(206, 20);
            this.nombresTxt.TabIndex = 1;
            // 
            // cedulaTxt
            // 
            this.cedulaTxt.Location = new System.Drawing.Point(131, 139);
            this.cedulaTxt.Name = "cedulaTxt";
            this.cedulaTxt.Size = new System.Drawing.Size(206, 20);
            this.cedulaTxt.TabIndex = 3;
            this.cedulaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaTxt_KeyPress);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(131, 193);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(206, 20);
            this.usuarioTxt.TabIndex = 5;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(247, 338);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(90, 23);
            this.cancelarBtn.TabIndex = 10;
            this.cancelarBtn.Text = "Salir";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(151, 338);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(90, 23);
            this.AceptarBtn.TabIndex = 9;
            this.AceptarBtn.Text = "Actualizar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.ActualizarBtn_Click);
            // 
            // imageNewUser
            // 
            this.imageNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageNewUser.Image = global::SIFCA.Properties.Resources.actualizar_usuarios;
            this.imageNewUser.Location = new System.Drawing.Point(0, 0);
            this.imageNewUser.Name = "imageNewUser";
            this.imageNewUser.Size = new System.Drawing.Size(358, 62);
            this.imageNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNewUser.TabIndex = 39;
            this.imageNewUser.TabStop = false;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(128, 307);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 40;
            // 
            // tipoUsuarioCbx
            // 
            this.tipoUsuarioCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuarioCbx.FormattingEnabled = true;
            this.tipoUsuarioCbx.Items.AddRange(new object[] {
            "Administrador",
            "No Administrador"});
            this.tipoUsuarioCbx.Location = new System.Drawing.Point(131, 165);
            this.tipoUsuarioCbx.Name = "tipoUsuarioCbx";
            this.tipoUsuarioCbx.Size = new System.Drawing.Size(206, 21);
            this.tipoUsuarioCbx.TabIndex = 4;
            // 
            // verContrasena
            // 
            this.verContrasena.Location = new System.Drawing.Point(223, 271);
            this.verContrasena.Name = "verContrasena";
            this.verContrasena.Size = new System.Drawing.Size(114, 23);
            this.verContrasena.TabIndex = 8;
            this.verContrasena.Text = "Ver Contraseña";
            this.verContrasena.UseVisualStyleBackColor = true;
            this.verContrasena.Click += new System.EventHandler(this.verContrasena_Click);
            // 
            // controladorErrores
            // 
            this.controladorErrores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.controladorErrores.ContainerControl = this;
            // 
            // Actualizar_Usuario_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(358, 373);
            this.Controls.Add(this.verContrasena);
            this.Controls.Add(this.tipoUsuarioCbx);
            this.Controls.Add(tipoUsuarioLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.imageNewUser);
            this.Controls.Add(label1);
            this.Controls.Add(this.verificarContrasenaTxt);
            this.Controls.Add(cONTRASENALabel);
            this.Controls.Add(this.contrasenaTxt);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTxt);
            this.Controls.Add(nOMBRESLabel);
            this.Controls.Add(this.nombresTxt);
            this.Controls.Add(cEDULALabel);
            this.Controls.Add(this.cedulaTxt);
            this.Controls.Add(usuarioLbl);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Actualizar_Usuario_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar usuario";
            ((System.ComponentModel.ISupportInitialize)(this.imageNewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox verificarContrasenaTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;
        private System.Windows.Forms.TextBox apellidosTxt;
        private System.Windows.Forms.TextBox nombresTxt;
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.PictureBox imageNewUser;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.ComboBox tipoUsuarioCbx;
        private System.Windows.Forms.Button verContrasena;
        private System.Windows.Forms.ErrorProvider controladorErrores;



    }
}