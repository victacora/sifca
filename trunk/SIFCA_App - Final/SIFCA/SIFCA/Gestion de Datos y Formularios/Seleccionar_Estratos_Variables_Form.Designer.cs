namespace SIFCA
{
    partial class Seleccionar_Estratos_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccionar_Estratos_Form));
            this.estratosProyectoLBC = new System.Windows.Forms.CheckedListBox();
            this.LimpiarTodosEstratosBtn = new System.Windows.Forms.Button();
            this.SeleccionarTodosEstratosBtn = new System.Windows.Forms.Button();
            this.estratosBS = new System.Windows.Forms.BindingSource(this.components);
            this.procesarBtn = new System.Windows.Forms.Button();
            this.variablesLbl = new System.Windows.Forms.Label();
            this.estratosLbl = new System.Windows.Forms.Label();
            this.seleccionarVariableLBC = new System.Windows.Forms.CheckedListBox();
            this.limpiarTodasVarBtn = new System.Windows.Forms.Button();
            this.seleccionarTodasVarBtn = new System.Windows.Forms.Button();
            this.verFormulariosBtn = new System.Windows.Forms.Button();
            this.verArbolBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estratosBS)).BeginInit();
            this.SuspendLayout();
            // 
            // estratosProyectoLBC
            // 
            this.estratosProyectoLBC.FormattingEnabled = true;
            this.estratosProyectoLBC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.estratosProyectoLBC.Location = new System.Drawing.Point(12, 134);
            this.estratosProyectoLBC.Name = "estratosProyectoLBC";
            this.estratosProyectoLBC.Size = new System.Drawing.Size(437, 139);
            this.estratosProyectoLBC.TabIndex = 40;
            this.estratosProyectoLBC.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.estratosProyectoLbc_ItemCheck);
            // 
            // LimpiarTodosEstratosBtn
            // 
            this.LimpiarTodosEstratosBtn.Location = new System.Drawing.Point(319, 279);
            this.LimpiarTodosEstratosBtn.Name = "LimpiarTodosEstratosBtn";
            this.LimpiarTodosEstratosBtn.Size = new System.Drawing.Size(62, 23);
            this.LimpiarTodosEstratosBtn.TabIndex = 101;
            this.LimpiarTodosEstratosBtn.Text = "Limpiar";
            this.LimpiarTodosEstratosBtn.UseVisualStyleBackColor = true;
            this.LimpiarTodosEstratosBtn.Click += new System.EventHandler(this.LimpiarTodosUsosBtn_Click);
            // 
            // SeleccionarTodosEstratosBtn
            // 
            this.SeleccionarTodosEstratosBtn.Location = new System.Drawing.Point(201, 279);
            this.SeleccionarTodosEstratosBtn.Name = "SeleccionarTodosEstratosBtn";
            this.SeleccionarTodosEstratosBtn.Size = new System.Drawing.Size(112, 23);
            this.SeleccionarTodosEstratosBtn.TabIndex = 100;
            this.SeleccionarTodosEstratosBtn.Text = "Seleccionar Todos";
            this.SeleccionarTodosEstratosBtn.UseVisualStyleBackColor = true;
            this.SeleccionarTodosEstratosBtn.Click += new System.EventHandler(this.SeleccionarTodosUsosBtn_Click);
            // 
            // estratosBS
            // 
            this.estratosBS.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // procesarBtn
            // 
            this.procesarBtn.Location = new System.Drawing.Point(387, 279);
            this.procesarBtn.Name = "procesarBtn";
            this.procesarBtn.Size = new System.Drawing.Size(62, 23);
            this.procesarBtn.TabIndex = 102;
            this.procesarBtn.Text = "Procesar";
            this.procesarBtn.UseVisualStyleBackColor = true;
            this.procesarBtn.Click += new System.EventHandler(this.procesarBtn_Click);
            // 
            // variablesLbl
            // 
            this.variablesLbl.AutoSize = true;
            this.variablesLbl.Location = new System.Drawing.Point(13, 12);
            this.variablesLbl.Name = "variablesLbl";
            this.variablesLbl.Size = new System.Drawing.Size(108, 13);
            this.variablesLbl.TabIndex = 103;
            this.variablesLbl.Text = "Seleccionar variables";
            // 
            // estratosLbl
            // 
            this.estratosLbl.AutoSize = true;
            this.estratosLbl.Location = new System.Drawing.Point(9, 118);
            this.estratosLbl.Name = "estratosLbl";
            this.estratosLbl.Size = new System.Drawing.Size(106, 13);
            this.estratosLbl.TabIndex = 104;
            this.estratosLbl.Text = "Seleccionar estratos:";
            // 
            // seleccionarVariableLBC
            // 
            this.seleccionarVariableLBC.FormattingEnabled = true;
            this.seleccionarVariableLBC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seleccionarVariableLBC.Items.AddRange(new object[] {
            "Numero de arboles",
            "Area basal",
            "Volumen comercial",
            "Volumen total"});
            this.seleccionarVariableLBC.Location = new System.Drawing.Point(12, 28);
            this.seleccionarVariableLBC.Name = "seleccionarVariableLBC";
            this.seleccionarVariableLBC.Size = new System.Drawing.Size(437, 64);
            this.seleccionarVariableLBC.TabIndex = 106;
            this.seleccionarVariableLBC.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.seleccionarVariableLBC_ItemCheck);
            // 
            // limpiarTodasVarBtn
            // 
            this.limpiarTodasVarBtn.Location = new System.Drawing.Point(388, 98);
            this.limpiarTodasVarBtn.Name = "limpiarTodasVarBtn";
            this.limpiarTodasVarBtn.Size = new System.Drawing.Size(62, 23);
            this.limpiarTodasVarBtn.TabIndex = 108;
            this.limpiarTodasVarBtn.Text = "Limpiar";
            this.limpiarTodasVarBtn.UseVisualStyleBackColor = true;
            this.limpiarTodasVarBtn.Click += new System.EventHandler(this.limpiarTodasVarBtn_Click);
            // 
            // seleccionarTodasVarBtn
            // 
            this.seleccionarTodasVarBtn.Location = new System.Drawing.Point(272, 98);
            this.seleccionarTodasVarBtn.Name = "seleccionarTodasVarBtn";
            this.seleccionarTodasVarBtn.Size = new System.Drawing.Size(110, 23);
            this.seleccionarTodasVarBtn.TabIndex = 107;
            this.seleccionarTodasVarBtn.Text = "Seleccionar Todos";
            this.seleccionarTodasVarBtn.UseVisualStyleBackColor = true;
            this.seleccionarTodasVarBtn.Click += new System.EventHandler(this.seleccionarTodasVarBtn_Click);
            // 
            // verFormulariosBtn
            // 
            this.verFormulariosBtn.Location = new System.Drawing.Point(113, 278);
            this.verFormulariosBtn.Name = "verFormulariosBtn";
            this.verFormulariosBtn.Size = new System.Drawing.Size(85, 23);
            this.verFormulariosBtn.TabIndex = 109;
            this.verFormulariosBtn.Text = "Ver formularios";
            this.verFormulariosBtn.UseVisualStyleBackColor = true;
            this.verFormulariosBtn.Click += new System.EventHandler(this.verFormulariosBtn_Click);
            // 
            // verArbolBtn
            // 
            this.verArbolBtn.Image = global::SIFCA.Properties.Resources._1395994362_chart_organisation_add;
            this.verArbolBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verArbolBtn.Location = new System.Drawing.Point(12, 278);
            this.verArbolBtn.Name = "verArbolBtn";
            this.verArbolBtn.Size = new System.Drawing.Size(95, 23);
            this.verArbolBtn.TabIndex = 110;
            this.verArbolBtn.Text = "Ver árbol";
            this.verArbolBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.verArbolBtn.UseVisualStyleBackColor = true;
            this.verArbolBtn.Click += new System.EventHandler(this.verArbolBtn_Click);
            // 
            // Seleccionar_Estratos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 322);
            this.Controls.Add(this.verArbolBtn);
            this.Controls.Add(this.verFormulariosBtn);
            this.Controls.Add(this.limpiarTodasVarBtn);
            this.Controls.Add(this.seleccionarTodasVarBtn);
            this.Controls.Add(this.seleccionarVariableLBC);
            this.Controls.Add(this.estratosLbl);
            this.Controls.Add(this.variablesLbl);
            this.Controls.Add(this.procesarBtn);
            this.Controls.Add(this.LimpiarTodosEstratosBtn);
            this.Controls.Add(this.SeleccionarTodosEstratosBtn);
            this.Controls.Add(this.estratosProyectoLBC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Seleccionar_Estratos_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar reporte";
            ((System.ComponentModel.ISupportInitialize)(this.estratosBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox estratosProyectoLBC;
        private System.Windows.Forms.Button LimpiarTodosEstratosBtn;
        private System.Windows.Forms.Button SeleccionarTodosEstratosBtn;
        private System.Windows.Forms.BindingSource estratosBS;
        private System.Windows.Forms.Button procesarBtn;
        private System.Windows.Forms.Label variablesLbl;
        private System.Windows.Forms.Label estratosLbl;
        private System.Windows.Forms.CheckedListBox seleccionarVariableLBC;
        private System.Windows.Forms.Button limpiarTodasVarBtn;
        private System.Windows.Forms.Button seleccionarTodasVarBtn;
        private System.Windows.Forms.Button verFormulariosBtn;
        private System.Windows.Forms.Button verArbolBtn;
    }
}