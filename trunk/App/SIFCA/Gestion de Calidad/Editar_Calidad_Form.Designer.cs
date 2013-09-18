namespace SIFCA.Gestion_de_Calidad
{
    partial class Editar_Calidad_Form
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Nom = new System.Windows.Forms.ComboBox();
            this.QualityBSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombreComun = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txt_Descripcion);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.txt_Nombre);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 44);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(367, 158);
            this.groupBox.TabIndex = 26;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Editar Calidad";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(156, 63);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.ShortcutsEnabled = false;
            this.txt_Descripcion.Size = new System.Drawing.Size(187, 72);
            this.txt_Descripcion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(156, 34);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(187, 20);
            this.txt_Nombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // cbx_Nom
            // 
            this.cbx_Nom.DataSource = this.QualityBSource;
            this.cbx_Nom.DisplayMember = "DESCRIPCALIDAD";
            this.cbx_Nom.FormattingEnabled = true;
            this.cbx_Nom.Location = new System.Drawing.Point(95, 17);
            this.cbx_Nom.Name = "cbx_Nom";
            this.cbx_Nom.Size = new System.Drawing.Size(121, 21);
            this.cbx_Nom.TabIndex = 25;
            this.cbx_Nom.ValueMember = "CODCALIDAD";
            this.cbx_Nom.SelectedIndexChanged += new System.EventHandler(this.Seleccion_por_nombre);
            // 
            // QualityBSource
            // 
            this.QualityBSource.DataSource = typeof(SIFCA_DAL.CALIDAD);
            // 
            // lblNombreComun
            // 
            this.lblNombreComun.AutoSize = true;
            this.lblNombreComun.Location = new System.Drawing.Point(28, 17);
            this.lblNombreComun.Name = "lblNombreComun";
            this.lblNombreComun.Size = new System.Drawing.Size(44, 13);
            this.lblNombreComun.TabIndex = 24;
            this.lblNombreComun.Text = "Nombre";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(261, 220);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 15;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click_1);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(51, 220);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 14;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Editar_Calidad_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 286);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.cbx_Nom);
            this.Controls.Add(this.lblNombreComun);
            this.Name = "Editar_Calidad_Form";
            this.Text = "Editar Calidad";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityBSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Nom;
        private System.Windows.Forms.Label lblNombreComun;
        private System.Windows.Forms.BindingSource QualityBSource;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
    }
}