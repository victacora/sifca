namespace SIFCA.Gestion_de_Especies
{
    partial class Editar_Especie_Form
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
            this.lblNombreComun = new System.Windows.Forms.Label();
            this.cbx_NomComun = new System.Windows.Forms.ComboBox();
            this.SpecieBSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBx_NomCient = new System.Windows.Forms.ComboBox();
            this.lbl_NomCient = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cbx_GroupCom = new System.Windows.Forms.ComboBox();
            this.GroupComBSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_DimCorte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ZonaVida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ZonaGeo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Familia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomCient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NomCom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpecieBSource)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupComBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreComun
            // 
            this.lblNombreComun.AutoSize = true;
            this.lblNombreComun.Location = new System.Drawing.Point(12, 34);
            this.lblNombreComun.Name = "lblNombreComun";
            this.lblNombreComun.Size = new System.Drawing.Size(80, 13);
            this.lblNombreComun.TabIndex = 0;
            this.lblNombreComun.Text = "Nombre Comun";
            // 
            // cbx_NomComun
            // 
            this.cbx_NomComun.DataSource = this.SpecieBSource;
            this.cbx_NomComun.DisplayMember = "NOMCOMUN";
            this.cbx_NomComun.FormattingEnabled = true;
            this.cbx_NomComun.Location = new System.Drawing.Point(98, 31);
            this.cbx_NomComun.Name = "cbx_NomComun";
            this.cbx_NomComun.Size = new System.Drawing.Size(121, 21);
            this.cbx_NomComun.TabIndex = 1;
            this.cbx_NomComun.ValueMember = "CODESP";
            this.cbx_NomComun.SelectedIndexChanged += new System.EventHandler(this.SeleccionPorNombreComun);
            // 
            // SpecieBSource
            // 
            this.SpecieBSource.DataSource = typeof(SIFCA_DAL.ESPECIE);
            // 
            // cBx_NomCient
            // 
            this.cBx_NomCient.DataSource = this.SpecieBSource;
            this.cBx_NomCient.DisplayMember = "NOMCIENTIFICO";
            this.cBx_NomCient.FormattingEnabled = true;
            this.cBx_NomCient.Location = new System.Drawing.Point(332, 31);
            this.cBx_NomCient.Name = "cBx_NomCient";
            this.cBx_NomCient.Size = new System.Drawing.Size(121, 21);
            this.cBx_NomCient.TabIndex = 3;
            this.cBx_NomCient.ValueMember = "CODESP";
            // 
            // lbl_NomCient
            // 
            this.lbl_NomCient.AutoSize = true;
            this.lbl_NomCient.Location = new System.Drawing.Point(236, 34);
            this.lbl_NomCient.Name = "lbl_NomCient";
            this.lbl_NomCient.Size = new System.Drawing.Size(90, 13);
            this.lbl_NomCient.TabIndex = 2;
            this.lbl_NomCient.Text = "Nombre Cientifico";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.cbx_GroupCom);
            this.groupBox.Controls.Add(this.txt_DimCorte);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.txt_ZonaVida);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.txt_ZonaGeo);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.txt_Familia);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.txt_NomCient);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.txt_NomCom);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(49, 79);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(381, 259);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Editar Especie";
            // 
            // cbx_GroupCom
            // 
            this.cbx_GroupCom.DataSource = this.GroupComBSource;
            this.cbx_GroupCom.DisplayMember = "DESCRIPGRUPO";
            this.cbx_GroupCom.FormattingEnabled = true;
            this.cbx_GroupCom.Location = new System.Drawing.Point(157, 93);
            this.cbx_GroupCom.Name = "cbx_GroupCom";
            this.cbx_GroupCom.Size = new System.Drawing.Size(152, 21);
            this.cbx_GroupCom.TabIndex = 18;
            this.cbx_GroupCom.ValueMember = "GRUPOCOM";
            // 
            // GroupComBSource
            // 
            this.GroupComBSource.DataSource = typeof(SIFCA_DAL.GRUPOCOMERCIAL);
            // 
            // txt_DimCorte
            // 
            this.txt_DimCorte.Location = new System.Drawing.Point(157, 212);
            this.txt_DimCorte.Name = "txt_DimCorte";
            this.txt_DimCorte.Size = new System.Drawing.Size(61, 20);
            this.txt_DimCorte.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Diametro Corte";
            // 
            // txt_ZonaVida
            // 
            this.txt_ZonaVida.Location = new System.Drawing.Point(156, 182);
            this.txt_ZonaVida.Name = "txt_ZonaVida";
            this.txt_ZonaVida.Size = new System.Drawing.Size(153, 20);
            this.txt_ZonaVida.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zona De Vida";
            // 
            // txt_ZonaGeo
            // 
            this.txt_ZonaGeo.Location = new System.Drawing.Point(156, 152);
            this.txt_ZonaGeo.Name = "txt_ZonaGeo";
            this.txt_ZonaGeo.Size = new System.Drawing.Size(153, 20);
            this.txt_ZonaGeo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Zona Geografica";
            // 
            // txt_Familia
            // 
            this.txt_Familia.Location = new System.Drawing.Point(156, 122);
            this.txt_Familia.Name = "txt_Familia";
            this.txt_Familia.Size = new System.Drawing.Size(153, 20);
            this.txt_Familia.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Familia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grupo Comercial";
            // 
            // txt_NomCient
            // 
            this.txt_NomCient.Location = new System.Drawing.Point(156, 63);
            this.txt_NomCient.Name = "txt_NomCient";
            this.txt_NomCient.Size = new System.Drawing.Size(153, 20);
            this.txt_NomCient.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre Cientifico";
            // 
            // txt_NomCom
            // 
            this.txt_NomCom.Location = new System.Drawing.Point(156, 34);
            this.txt_NomCom.Name = "txt_NomCom";
            this.txt_NomCom.Size = new System.Drawing.Size(153, 20);
            this.txt_NomCom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Comun";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(82, 344);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(251, 344);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 6;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Editar_Especie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 379);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cBx_NomCient);
            this.Controls.Add(this.lbl_NomCient);
            this.Controls.Add(this.cbx_NomComun);
            this.Controls.Add(this.lblNombreComun);
            this.Name = "Editar_Especie_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Especie";
            ((System.ComponentModel.ISupportInitialize)(this.SpecieBSource)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupComBSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreComun;
        private System.Windows.Forms.ComboBox cbx_NomComun;
        private System.Windows.Forms.BindingSource SpecieBSource;
        private System.Windows.Forms.ComboBox cBx_NomCient;
        private System.Windows.Forms.Label lbl_NomCient;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbx_GroupCom;
        private System.Windows.Forms.BindingSource GroupComBSource;
        private System.Windows.Forms.TextBox txt_DimCorte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ZonaVida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ZonaGeo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Familia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomCient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NomCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}