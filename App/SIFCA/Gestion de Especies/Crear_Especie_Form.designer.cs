namespace SIFCA.Gestion_de_Especies
{
    partial class Ingresar_Especie_Form
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
            this.grupoComercialBSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNewUser = new System.Windows.Forms.PictureBox();
            this.cbox_GrupoComercial = new System.Windows.Forms.ComboBox();
            this.txt_DMC = new System.Windows.Forms.TextBox();
            this.txt_ZonaVida = new System.Windows.Forms.TextBox();
            this.txt_ZonaGeografica = new System.Windows.Forms.TextBox();
            this.txt_Familia = new System.Windows.Forms.TextBox();
            this.txt_NombreCientifico = new System.Windows.Forms.TextBox();
            this.txt_NombreComun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupoComercialBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoComercialBSource
            // 
            this.grupoComercialBSource.DataSource = typeof(SIFCA_DAL.GRUPOCOMERCIAL);
            // 
            // imageNewUser
            // 
            this.imageNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageNewUser.Image = global::SIFCA.Properties.Resources.Nueva_Especie;
            this.imageNewUser.Location = new System.Drawing.Point(0, 0);
            this.imageNewUser.Name = "imageNewUser";
            this.imageNewUser.Size = new System.Drawing.Size(354, 62);
            this.imageNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNewUser.TabIndex = 25;
            this.imageNewUser.TabStop = false;
            // 
            // cbox_GrupoComercial
            // 
            this.cbox_GrupoComercial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.grupoComercialBSource, "GRUPOCOM", true));
            this.cbox_GrupoComercial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.grupoComercialBSource, "GRUPOCOM", true));
            this.cbox_GrupoComercial.DataSource = this.grupoComercialBSource;
            this.cbox_GrupoComercial.DisplayMember = "DESCRIPGRUPO";
            this.cbox_GrupoComercial.FormattingEnabled = true;
            this.cbox_GrupoComercial.Location = new System.Drawing.Point(145, 81);
            this.cbox_GrupoComercial.Name = "cbox_GrupoComercial";
            this.cbox_GrupoComercial.Size = new System.Drawing.Size(183, 21);
            this.cbox_GrupoComercial.TabIndex = 41;
            this.cbox_GrupoComercial.ValueMember = "GRUPOCOM";
            // 
            // txt_DMC
            // 
            this.txt_DMC.Location = new System.Drawing.Point(145, 240);
            this.txt_DMC.Name = "txt_DMC";
            this.txt_DMC.Size = new System.Drawing.Size(183, 20);
            this.txt_DMC.TabIndex = 39;
            // 
            // txt_ZonaVida
            // 
            this.txt_ZonaVida.Location = new System.Drawing.Point(145, 212);
            this.txt_ZonaVida.Name = "txt_ZonaVida";
            this.txt_ZonaVida.Size = new System.Drawing.Size(183, 20);
            this.txt_ZonaVida.TabIndex = 38;
            // 
            // txt_ZonaGeografica
            // 
            this.txt_ZonaGeografica.Location = new System.Drawing.Point(145, 186);
            this.txt_ZonaGeografica.Name = "txt_ZonaGeografica";
            this.txt_ZonaGeografica.Size = new System.Drawing.Size(183, 20);
            this.txt_ZonaGeografica.TabIndex = 37;
            // 
            // txt_Familia
            // 
            this.txt_Familia.Location = new System.Drawing.Point(145, 160);
            this.txt_Familia.Name = "txt_Familia";
            this.txt_Familia.Size = new System.Drawing.Size(183, 20);
            this.txt_Familia.TabIndex = 36;
            // 
            // txt_NombreCientifico
            // 
            this.txt_NombreCientifico.Location = new System.Drawing.Point(145, 134);
            this.txt_NombreCientifico.Name = "txt_NombreCientifico";
            this.txt_NombreCientifico.Size = new System.Drawing.Size(183, 20);
            this.txt_NombreCientifico.TabIndex = 35;
            // 
            // txt_NombreComun
            // 
            this.txt_NombreComun.Location = new System.Drawing.Point(145, 108);
            this.txt_NombreComun.Name = "txt_NombreComun";
            this.txt_NombreComun.Size = new System.Drawing.Size(183, 20);
            this.txt_NombreComun.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Diametro minimo corte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Zona vida";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Zona geografica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Familia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre cientifico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre común";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Grupo comercial";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(248, 277);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 23);
            this.btn_Cancelar.TabIndex = 43;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(145, 277);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(82, 23);
            this.btn_Crear.TabIndex = 42;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            // 
            // Ingresar_Especie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 333);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.cbox_GrupoComercial);
            this.Controls.Add(this.txt_DMC);
            this.Controls.Add(this.txt_ZonaVida);
            this.Controls.Add(this.txt_ZonaGeografica);
            this.Controls.Add(this.txt_Familia);
            this.Controls.Add(this.txt_NombreCientifico);
            this.Controls.Add(this.txt_NombreComun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageNewUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingresar_Especie_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar_Especie_Form";
            ((System.ComponentModel.ISupportInitialize)(this.grupoComercialBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoComercialBSource;
        private System.Windows.Forms.PictureBox imageNewUser;
        private System.Windows.Forms.ComboBox cbox_GrupoComercial;
        private System.Windows.Forms.TextBox txt_DMC;
        private System.Windows.Forms.TextBox txt_ZonaVida;
        private System.Windows.Forms.TextBox txt_ZonaGeografica;
        private System.Windows.Forms.TextBox txt_Familia;
        private System.Windows.Forms.TextBox txt_NombreCientifico;
        private System.Windows.Forms.TextBox txt_NombreComun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Crear;
    }
}