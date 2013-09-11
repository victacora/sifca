namespace SIFCA.Gestion_de_Tipos_Muestrales
{
    partial class Listado_TipoMuestal_Form
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
            this.TypeSampleDesingBSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TypeSampleDesingBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeSampleDesingBSource
            // 
            this.TypeSampleDesingBSource.DataSource = typeof(SIFCA_DAL.TIPODISENOMUESTRAL);
            // 
            // Listado_TipoMuestal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Listado_TipoMuestal_Form";
            this.Text = "Listado Tipo Muestal";
            ((System.ComponentModel.ISupportInitialize)(this.TypeSampleDesingBSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource TypeSampleDesingBSource;
    }
}