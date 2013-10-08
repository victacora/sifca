namespace SIFCA
{
    partial class Abrir_Proyecto_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abrir_Proyecto_Form));
            this.proyectoBS = new System.Windows.Forms.BindingSource(this.components);
            this.objetivoInvBS = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDisenoMuesBS = new System.Windows.Forms.BindingSource(this.components);
            this.buscarProyectoLbl = new System.Windows.Forms.ToolStripLabel();
            this.busquedaTxt = new System.Windows.Forms.ToolStripTextBox();
            this.criterioLbl = new System.Windows.Forms.ToolStripLabel();
            this.criterioCbx = new System.Windows.Forms.ToolStripComboBox();
            this.proyectoBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.proyectosDGW = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROPROY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRETIPOINV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NOMTIPODISEMUEST = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROETAPAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInvBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoMuesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBN)).BeginInit();
            this.proyectoBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // proyectoBS
            // 
            this.proyectoBS.DataSource = typeof(SIFCA_DAL.PROYECTO);
            // 
            // objetivoInvBS
            // 
            this.objetivoInvBS.DataSource = typeof(SIFCA_DAL.OBJETIVOINVENTARIO);
            // 
            // tipoDisenoMuesBS
            // 
            this.tipoDisenoMuesBS.DataSource = typeof(SIFCA_DAL.TIPODISENOMUESTRAL);
            // 
            // buscarProyectoLbl
            // 
            this.buscarProyectoLbl.Name = "buscarProyectoLbl";
            this.buscarProyectoLbl.Size = new System.Drawing.Size(95, 22);
            this.buscarProyectoLbl.Text = "Buscar proyecto:";
            // 
            // busquedaTxt
            // 
            this.busquedaTxt.Name = "busquedaTxt";
            this.busquedaTxt.Size = new System.Drawing.Size(150, 25);
            this.busquedaTxt.TextChanged += new System.EventHandler(this.busquedaTxt_TextChanged);
            // 
            // criterioLbl
            // 
            this.criterioLbl.Name = "criterioLbl";
            this.criterioLbl.Size = new System.Drawing.Size(104, 22);
            this.criterioLbl.Text = "Criterio busqueda:";
            // 
            // criterioCbx
            // 
            this.criterioCbx.Items.AddRange(new object[] {
            "dd/mm/aaaa",
            "Responsable",
            "Lugar",
            "Tipo Inventario",
            "Tipo Diseño",
            "Numero Etapas"});
            this.criterioCbx.Name = "criterioCbx";
            this.criterioCbx.Size = new System.Drawing.Size(135, 25);
            // 
            // proyectoBN
            // 
            this.proyectoBN.AddNewItem = null;
            this.proyectoBN.BindingSource = this.proyectoBS;
            this.proyectoBN.CountItem = null;
            this.proyectoBN.DeleteItem = null;
            this.proyectoBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProyectoLbl,
            this.busquedaTxt,
            this.criterioLbl,
            this.criterioCbx});
            this.proyectoBN.Location = new System.Drawing.Point(0, 0);
            this.proyectoBN.MoveFirstItem = null;
            this.proyectoBN.MoveLastItem = null;
            this.proyectoBN.MoveNextItem = null;
            this.proyectoBN.MovePreviousItem = null;
            this.proyectoBN.Name = "proyectoBN";
            this.proyectoBN.PositionItem = null;
            this.proyectoBN.Size = new System.Drawing.Size(834, 25);
            this.proyectoBN.TabIndex = 0;
            this.proyectoBN.Text = "bindingNavigator1";
            // 
            // proyectosDGW
            // 
            this.proyectosDGW.AllowUserToAddRows = false;
            this.proyectosDGW.AllowUserToDeleteRows = false;
            this.proyectosDGW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proyectosDGW.AutoGenerateColumns = false;
            this.proyectosDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proyectosDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proyectosDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.NROPROY,
            this.NROUSUARIO,
            this.Responsable,
            this.NOMBRETIPOINV,
            this.NOMTIPODISEMUEST,
            this.LUGAR,
            this.DESCRIPCION,
            this.NUMEROETAPAS,
            this.abrir,
            this.eliminar});
            this.proyectosDGW.DataSource = this.proyectoBS;
            this.proyectosDGW.Location = new System.Drawing.Point(0, 25);
            this.proyectosDGW.Name = "proyectosDGW";
            this.proyectosDGW.ReadOnly = true;
            this.proyectosDGW.Size = new System.Drawing.Size(834, 372);
            this.proyectosDGW.TabIndex = 1;
            this.proyectosDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proyectoDGW_CellClick);
            this.proyectosDGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.proyectoDGW_DataBindingComplete);
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "Fecha";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // NROPROY
            // 
            this.NROPROY.DataPropertyName = "NROPROY";
            this.NROPROY.HeaderText = "NROPROY";
            this.NROPROY.Name = "NROPROY";
            this.NROPROY.ReadOnly = true;
            this.NROPROY.Visible = false;
            // 
            // NROUSUARIO
            // 
            this.NROUSUARIO.DataPropertyName = "NROUSUARIO";
            this.NROUSUARIO.HeaderText = "NROUSUARIO";
            this.NROUSUARIO.Name = "NROUSUARIO";
            this.NROUSUARIO.ReadOnly = true;
            this.NROUSUARIO.Visible = false;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            // 
            // NOMBRETIPOINV
            // 
            this.NOMBRETIPOINV.DataPropertyName = "NOMBRETIPOINV";
            this.NOMBRETIPOINV.DataSource = this.objetivoInvBS;
            this.NOMBRETIPOINV.DisplayMember = "DESCRIPOBJETINV";
            this.NOMBRETIPOINV.HeaderText = "Tipo Inventario";
            this.NOMBRETIPOINV.Name = "NOMBRETIPOINV";
            this.NOMBRETIPOINV.ReadOnly = true;
            this.NOMBRETIPOINV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMBRETIPOINV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NOMBRETIPOINV.ValueMember = "NOMBRETIPOINV";
            // 
            // NOMTIPODISEMUEST
            // 
            this.NOMTIPODISEMUEST.DataPropertyName = "NOMTIPODISEMUEST";
            this.NOMTIPODISEMUEST.DataSource = this.tipoDisenoMuesBS;
            this.NOMTIPODISEMUEST.DisplayMember = "DESCRIPTIPODISEMUEST";
            this.NOMTIPODISEMUEST.HeaderText = "Tipo Diseño";
            this.NOMTIPODISEMUEST.Name = "NOMTIPODISEMUEST";
            this.NOMTIPODISEMUEST.ReadOnly = true;
            this.NOMTIPODISEMUEST.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMTIPODISEMUEST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NOMTIPODISEMUEST.ValueMember = "NOMTIPODISEMUEST";
            // 
            // LUGAR
            // 
            this.LUGAR.DataPropertyName = "LUGAR";
            this.LUGAR.HeaderText = "Lugar";
            this.LUGAR.Name = "LUGAR";
            this.LUGAR.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "Descripcion";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // NUMEROETAPAS
            // 
            this.NUMEROETAPAS.DataPropertyName = "NUMEROETAPAS";
            this.NUMEROETAPAS.HeaderText = "Etapas";
            this.NUMEROETAPAS.Name = "NUMEROETAPAS";
            this.NUMEROETAPAS.ReadOnly = true;
            // 
            // abrir
            // 
            this.abrir.HeaderText = "";
            this.abrir.Name = "abrir";
            this.abrir.ReadOnly = true;
            this.abrir.Text = "Abrir";
            this.abrir.UseColumnTextForButtonValue = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            // 
            // Abrir_Proyecto_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 397);
            this.Controls.Add(this.proyectosDGW);
            this.Controls.Add(this.proyectoBN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abrir_Proyecto_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoInvBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDisenoMuesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBN)).EndInit();
            this.proyectoBN.ResumeLayout(false);
            this.proyectoBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource proyectoBS;
        private System.Windows.Forms.BindingSource objetivoInvBS;
        private System.Windows.Forms.BindingSource tipoDisenoMuesBS;
        private System.Windows.Forms.ToolStripLabel buscarProyectoLbl;
        private System.Windows.Forms.ToolStripTextBox busquedaTxt;
        private System.Windows.Forms.ToolStripLabel criterioLbl;
        private System.Windows.Forms.ToolStripComboBox criterioCbx;
        private System.Windows.Forms.BindingNavigator proyectoBN;
        private System.Windows.Forms.DataGridView proyectosDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROPROY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOMBRETIPOINV;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOMTIPODISEMUEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROETAPAS;
        private System.Windows.Forms.DataGridViewButtonColumn abrir;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}