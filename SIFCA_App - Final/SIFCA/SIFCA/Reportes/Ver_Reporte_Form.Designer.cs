namespace SIFCA
{
    partial class Ver_Reporte_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_Reporte_Form));
            this.verReporteRPVW = new Microsoft.Reporting.WinForms.ReportViewer();
            this.resultadosBS = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoBS = new System.Windows.Forms.BindingSource(this.components);
            this.totalEstratificadoBS = new System.Windows.Forms.BindingSource(this.components);
            this.diametricClassesBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resultadosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEstratificadoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diametricClassesBS)).BeginInit();
            this.SuspendLayout();
            // 
            // verReporteRPVW
            // 
            this.verReporteRPVW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verReporteRPVW.Location = new System.Drawing.Point(0, 0);
            this.verReporteRPVW.Name = "verReporteRPVW";
            this.verReporteRPVW.Size = new System.Drawing.Size(798, 516);
            this.verReporteRPVW.TabIndex = 0;
            // 
            // resultadosBS
            // 
            this.resultadosBS.DataMember = "resultados";
            this.resultadosBS.DataSource = typeof(SIFCA_DAL.REPORTERESULTADODATASOURCE);
            // 
            // proyectoBS
            // 
            this.proyectoBS.DataSource = typeof(SIFCA_DAL.PROYECTO);
            // 
            // totalEstratificadoBS
            // 
            this.totalEstratificadoBS.DataSource = typeof(SIFCA_DAL.TOTALESMUESTREOESTRATIFICADOS);
            // 
            // diametricClassesBS
            // 
            this.diametricClassesBS.DataSource = typeof(SIFCA_DAL.REPORTECLASESDIAMETRICASDATASOURCE);
            // 
            // Ver_Reporte_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 516);
            this.Controls.Add(this.verReporteRPVW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ver_Reporte_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Ver_Reporte_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEstratificadoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diametricClassesBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer verReporteRPVW;
        private System.Windows.Forms.BindingSource resultadosBS;
        private System.Windows.Forms.BindingSource proyectoBS;
        private System.Windows.Forms.BindingSource totalEstratificadoBS;
        private System.Windows.Forms.BindingSource diametricClassesBS;
    }
}