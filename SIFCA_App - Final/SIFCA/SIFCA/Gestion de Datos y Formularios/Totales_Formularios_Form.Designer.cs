namespace SIFCA
{
    partial class Totales_Formularios_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Totales_Formularios_Form));
            this.totalesDGW = new System.Windows.Forms.DataGridView();
            this.parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroArbolesParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroArbolesHtasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaBasalParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaBasalHtasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenComercialParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenComercialHtasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenTotalParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenTotalHtasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalesBS = new System.Windows.Forms.BindingSource(this.components);
            this.verReporteBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InformacionGrx = new System.Windows.Forms.GroupBox();
            this.tamanoParcelaTxt = new System.Windows.Forms.TextBox();
            this.tamanoParcelaLbl = new System.Windows.Forms.Label();
            this.tituloLbl = new System.Windows.Forms.Label();
            this.promedioLineasTxt = new System.Windows.Forms.TextBox();
            this.numTotalLineasTxt = new System.Windows.Forms.TextBox();
            this.numTotalParcelasTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalesDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesBS)).BeginInit();
            this.InformacionGrx.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalesDGW
            // 
            this.totalesDGW.AllowUserToAddRows = false;
            this.totalesDGW.AllowUserToDeleteRows = false;
            this.totalesDGW.AutoGenerateColumns = false;
            this.totalesDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.totalesDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalesDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcela,
            this.Estrato,
            this.numeroArbolesParcelaDataGridViewTextBoxColumn,
            this.numeroArbolesHtasDataGridViewTextBoxColumn,
            this.areaBasalParcelaDataGridViewTextBoxColumn,
            this.areaBasalHtasDataGridViewTextBoxColumn,
            this.volumenComercialParcelaDataGridViewTextBoxColumn,
            this.volumenComercialHtasDataGridViewTextBoxColumn,
            this.volumenTotalParcelaDataGridViewTextBoxColumn,
            this.volumenTotalHtasDataGridViewTextBoxColumn});
            this.totalesDGW.DataSource = this.totalesBS;
            this.totalesDGW.Location = new System.Drawing.Point(6, 150);
            this.totalesDGW.Name = "totalesDGW";
            this.totalesDGW.ReadOnly = true;
            this.totalesDGW.Size = new System.Drawing.Size(769, 250);
            this.totalesDGW.TabIndex = 0;
            // 
            // parcela
            // 
            this.parcela.DataPropertyName = "parcela";
            this.parcela.HeaderText = "parcela";
            this.parcela.Name = "parcela";
            this.parcela.ReadOnly = true;
            // 
            // Estrato
            // 
            this.Estrato.DataPropertyName = "Estrato";
            this.Estrato.HeaderText = "Estrato";
            this.Estrato.Name = "Estrato";
            this.Estrato.ReadOnly = true;
            // 
            // numeroArbolesParcelaDataGridViewTextBoxColumn
            // 
            this.numeroArbolesParcelaDataGridViewTextBoxColumn.DataPropertyName = "numeroArbolesParcela";
            this.numeroArbolesParcelaDataGridViewTextBoxColumn.HeaderText = "Num. Arbo. Parc.";
            this.numeroArbolesParcelaDataGridViewTextBoxColumn.Name = "numeroArbolesParcelaDataGridViewTextBoxColumn";
            this.numeroArbolesParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroArbolesHtasDataGridViewTextBoxColumn
            // 
            this.numeroArbolesHtasDataGridViewTextBoxColumn.DataPropertyName = "numeroArbolesHtas";
            this.numeroArbolesHtasDataGridViewTextBoxColumn.HeaderText = "Num. Arbo. Htas.";
            this.numeroArbolesHtasDataGridViewTextBoxColumn.Name = "numeroArbolesHtasDataGridViewTextBoxColumn";
            this.numeroArbolesHtasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaBasalParcelaDataGridViewTextBoxColumn
            // 
            this.areaBasalParcelaDataGridViewTextBoxColumn.DataPropertyName = "areaBasalParcela";
            this.areaBasalParcelaDataGridViewTextBoxColumn.HeaderText = "Area Basal Parc.";
            this.areaBasalParcelaDataGridViewTextBoxColumn.Name = "areaBasalParcelaDataGridViewTextBoxColumn";
            this.areaBasalParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaBasalHtasDataGridViewTextBoxColumn
            // 
            this.areaBasalHtasDataGridViewTextBoxColumn.DataPropertyName = "areaBasalHtas";
            this.areaBasalHtasDataGridViewTextBoxColumn.HeaderText = "Area Basal Htas.";
            this.areaBasalHtasDataGridViewTextBoxColumn.Name = "areaBasalHtasDataGridViewTextBoxColumn";
            this.areaBasalHtasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumenComercialParcelaDataGridViewTextBoxColumn
            // 
            this.volumenComercialParcelaDataGridViewTextBoxColumn.DataPropertyName = "volumenComercialParcela";
            this.volumenComercialParcelaDataGridViewTextBoxColumn.HeaderText = "Vol. Comercial Parc.";
            this.volumenComercialParcelaDataGridViewTextBoxColumn.Name = "volumenComercialParcelaDataGridViewTextBoxColumn";
            this.volumenComercialParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumenComercialHtasDataGridViewTextBoxColumn
            // 
            this.volumenComercialHtasDataGridViewTextBoxColumn.DataPropertyName = "volumenComercialHtas";
            this.volumenComercialHtasDataGridViewTextBoxColumn.HeaderText = "Vol. Comercial Htas.";
            this.volumenComercialHtasDataGridViewTextBoxColumn.Name = "volumenComercialHtasDataGridViewTextBoxColumn";
            this.volumenComercialHtasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumenTotalParcelaDataGridViewTextBoxColumn
            // 
            this.volumenTotalParcelaDataGridViewTextBoxColumn.DataPropertyName = "volumenTotalParcela";
            this.volumenTotalParcelaDataGridViewTextBoxColumn.HeaderText = "Vol. Total Parc.";
            this.volumenTotalParcelaDataGridViewTextBoxColumn.Name = "volumenTotalParcelaDataGridViewTextBoxColumn";
            this.volumenTotalParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumenTotalHtasDataGridViewTextBoxColumn
            // 
            this.volumenTotalHtasDataGridViewTextBoxColumn.DataPropertyName = "volumenTotalHtas";
            this.volumenTotalHtasDataGridViewTextBoxColumn.HeaderText = "Vol. Total Htas.";
            this.volumenTotalHtasDataGridViewTextBoxColumn.Name = "volumenTotalHtasDataGridViewTextBoxColumn";
            this.volumenTotalHtasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalesBS
            // 
            this.totalesBS.DataSource = typeof(SIFCA_BLL.SampleDesignItem);
            // 
            // verReporteBtn
            // 
            this.verReporteBtn.Location = new System.Drawing.Point(620, 415);
            this.verReporteBtn.Name = "verReporteBtn";
            this.verReporteBtn.Size = new System.Drawing.Size(75, 23);
            this.verReporteBtn.TabIndex = 1;
            this.verReporteBtn.Text = "Ver reporte";
            this.verReporteBtn.UseVisualStyleBackColor = true;
            this.verReporteBtn.Click += new System.EventHandler(this.verReporteBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(701, 415);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 2;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero total de parcelas muestreadas:";
            // 
            // InformacionGrx
            // 
            this.InformacionGrx.Controls.Add(this.tamanoParcelaTxt);
            this.InformacionGrx.Controls.Add(this.tamanoParcelaLbl);
            this.InformacionGrx.Controls.Add(this.tituloLbl);
            this.InformacionGrx.Controls.Add(this.promedioLineasTxt);
            this.InformacionGrx.Controls.Add(this.numTotalLineasTxt);
            this.InformacionGrx.Controls.Add(this.numTotalParcelasTxt);
            this.InformacionGrx.Controls.Add(this.totalesDGW);
            this.InformacionGrx.Controls.Add(this.label3);
            this.InformacionGrx.Controls.Add(this.label2);
            this.InformacionGrx.Controls.Add(this.label1);
            this.InformacionGrx.Location = new System.Drawing.Point(3, 3);
            this.InformacionGrx.Name = "InformacionGrx";
            this.InformacionGrx.Size = new System.Drawing.Size(781, 406);
            this.InformacionGrx.TabIndex = 4;
            this.InformacionGrx.TabStop = false;
            this.InformacionGrx.Text = "Información";
            // 
            // tamanoParcelaTxt
            // 
            this.tamanoParcelaTxt.Location = new System.Drawing.Point(208, 93);
            this.tamanoParcelaTxt.Name = "tamanoParcelaTxt";
            this.tamanoParcelaTxt.ReadOnly = true;
            this.tamanoParcelaTxt.Size = new System.Drawing.Size(566, 20);
            this.tamanoParcelaTxt.TabIndex = 11;
            // 
            // tamanoParcelaLbl
            // 
            this.tamanoParcelaLbl.AutoSize = true;
            this.tamanoParcelaLbl.Location = new System.Drawing.Point(7, 96);
            this.tamanoParcelaLbl.Name = "tamanoParcelaLbl";
            this.tamanoParcelaLbl.Size = new System.Drawing.Size(153, 13);
            this.tamanoParcelaLbl.TabIndex = 10;
            this.tamanoParcelaLbl.Text = "Tamaño de la parcela en Htas:";
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(160, 121);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(492, 18);
            this.tituloLbl.TabIndex = 9;
            this.tituloLbl.Text = "Equivalencia entre unidades por parcela y unidades por hectarea";
            // 
            // promedioLineasTxt
            // 
            this.promedioLineasTxt.Location = new System.Drawing.Point(207, 73);
            this.promedioLineasTxt.Name = "promedioLineasTxt";
            this.promedioLineasTxt.ReadOnly = true;
            this.promedioLineasTxt.Size = new System.Drawing.Size(566, 20);
            this.promedioLineasTxt.TabIndex = 8;
            // 
            // numTotalLineasTxt
            // 
            this.numTotalLineasTxt.Location = new System.Drawing.Point(207, 49);
            this.numTotalLineasTxt.Name = "numTotalLineasTxt";
            this.numTotalLineasTxt.ReadOnly = true;
            this.numTotalLineasTxt.Size = new System.Drawing.Size(566, 20);
            this.numTotalLineasTxt.TabIndex = 7;
            // 
            // numTotalParcelasTxt
            // 
            this.numTotalParcelasTxt.Location = new System.Drawing.Point(208, 23);
            this.numTotalParcelasTxt.Name = "numTotalParcelasTxt";
            this.numTotalParcelasTxt.ReadOnly = true;
            this.numTotalParcelasTxt.Size = new System.Drawing.Size(565, 20);
            this.numTotalParcelasTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Promedio lineas de inventario por parcela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero total de lineas de inventarios:\r\nrecolectadas";
            // 
            // Totales_Formularios_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.InformacionGrx);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.verReporteBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Totales_Formularios_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totales";
            ((System.ComponentModel.ISupportInitialize)(this.totalesDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesBS)).EndInit();
            this.InformacionGrx.ResumeLayout(false);
            this.InformacionGrx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView totalesDGW;
        private System.Windows.Forms.Button verReporteBtn;
        private System.Windows.Forms.BindingSource totalesBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroArbolesParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroArbolesHtasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaBasalParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaBasalHtasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenComercialParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenComercialHtasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenTotalParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenTotalHtasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox InformacionGrx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox promedioLineasTxt;
        private System.Windows.Forms.TextBox numTotalLineasTxt;
        private System.Windows.Forms.TextBox numTotalParcelasTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.TextBox tamanoParcelaTxt;
        private System.Windows.Forms.Label tamanoParcelaLbl;
    }
}