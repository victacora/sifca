﻿namespace SIFCA
{
    partial class Autenticar_Usuario_Form
    {
        /// <summary>
        /// Required designer operador.
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
            System.Windows.Forms.Label usuarioLbl;
            System.Windows.Forms.Label cONTRASENALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autenticar_Usuario_Form));
            this.datosAutenticacionGbx = new System.Windows.Forms.GroupBox();
            this.versionLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guardarDatosInicioChk = new System.Windows.Forms.CheckBox();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.controladorErrores = new System.Windows.Forms.ErrorProvider(this.components);
            usuarioLbl = new System.Windows.Forms.Label();
            cONTRASENALabel = new System.Windows.Forms.Label();
            this.datosAutenticacionGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLbl
            // 
            usuarioLbl.AutoSize = true;
            usuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            usuarioLbl.Location = new System.Drawing.Point(33, 53);
            usuarioLbl.Name = "usuarioLbl";
            usuarioLbl.Size = new System.Drawing.Size(58, 16);
            usuarioLbl.TabIndex = 15;
            usuarioLbl.Text = "Usuario:";
            // 
            // cONTRASENALabel
            // 
            cONTRASENALabel.AutoSize = true;
            cONTRASENALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            cONTRASENALabel.Location = new System.Drawing.Point(33, 109);
            cONTRASENALabel.Name = "cONTRASENALabel";
            cONTRASENALabel.Size = new System.Drawing.Size(80, 16);
            cONTRASENALabel.TabIndex = 21;
            cONTRASENALabel.Text = "Contraseña:";
            // 
            // datosAutenticacionGbx
            // 
            this.datosAutenticacionGbx.BackColor = System.Drawing.SystemColors.Window;
            this.datosAutenticacionGbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.datosAutenticacionGbx.Controls.Add(this.versionLbl);
            this.datosAutenticacionGbx.Controls.Add(this.label4);
            this.datosAutenticacionGbx.Controls.Add(this.guardarDatosInicioChk);
            this.datosAutenticacionGbx.Controls.Add(this.SalirBtn);
            this.datosAutenticacionGbx.Controls.Add(this.label3);
            this.datosAutenticacionGbx.Controls.Add(this.label2);
            this.datosAutenticacionGbx.Controls.Add(this.label1);
            this.datosAutenticacionGbx.Controls.Add(cONTRASENALabel);
            this.datosAutenticacionGbx.Controls.Add(this.contrasenaTxt);
            this.datosAutenticacionGbx.Controls.Add(usuarioLbl);
            this.datosAutenticacionGbx.Controls.Add(this.usuarioTxt);
            this.datosAutenticacionGbx.Controls.Add(this.AceptarBtn);
            this.datosAutenticacionGbx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datosAutenticacionGbx.Location = new System.Drawing.Point(23, 25);
            this.datosAutenticacionGbx.Name = "datosAutenticacionGbx";
            this.datosAutenticacionGbx.Size = new System.Drawing.Size(366, 304);
            this.datosAutenticacionGbx.TabIndex = 0;
            this.datosAutenticacionGbx.TabStop = false;
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Location = new System.Drawing.Point(146, 287);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(78, 13);
            this.versionLbl.TabIndex = 28;
            this.versionLbl.Text = "Versión 0.0.0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "¿desea guardar los datos de inicio de sesión ?";
            // 
            // guardarDatosInicioChk
            // 
            this.guardarDatosInicioChk.AutoSize = true;
            this.guardarDatosInicioChk.Location = new System.Drawing.Point(296, 178);
            this.guardarDatosInicioChk.Name = "guardarDatosInicioChk";
            this.guardarDatosInicioChk.Size = new System.Drawing.Size(15, 14);
            this.guardarDatosInicioChk.TabIndex = 26;
            this.guardarDatosInicioChk.UseVisualStyleBackColor = true;
            this.guardarDatosInicioChk.CheckedChanged += new System.EventHandler(this.guardarDatosInicioChk_CheckedChanged);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SalirBtn.Location = new System.Drawing.Point(187, 211);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(124, 32);
            this.SalirBtn.TabIndex = 4;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sistema de información para Inventarios Forestales en el Cauca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "SIFCA, 2014";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Iniciar Sesión";
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.contrasenaTxt.Location = new System.Drawing.Point(59, 132);
            this.contrasenaTxt.MaxLength = 100;
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Size = new System.Drawing.Size(252, 31);
            this.contrasenaTxt.TabIndex = 2;
            this.contrasenaTxt.Tag = "";
            this.contrasenaTxt.UseSystemPasswordChar = true;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTxt.Location = new System.Drawing.Point(59, 74);
            this.usuarioTxt.MaxLength = 100;
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(252, 31);
            this.usuarioTxt.TabIndex = 1;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AceptarBtn.Location = new System.Drawing.Point(59, 211);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(124, 32);
            this.AceptarBtn.TabIndex = 3;
            this.AceptarBtn.Text = "Ingresar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // controladorErrores
            // 
            this.controladorErrores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.controladorErrores.ContainerControl = this;
            // 
            // Autenticar_Usuario_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIFCA.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 358);
            this.Controls.Add(this.datosAutenticacionGbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autenticar_Usuario_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Autenticar_Usuario_Form_KeyDown);
            this.datosAutenticacionGbx.ResumeLayout(false);
            this.datosAutenticacionGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controladorErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datosAutenticacionGbx;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.ErrorProvider controladorErrores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox guardarDatosInicioChk;
        private System.Windows.Forms.Label versionLbl;


    }
}