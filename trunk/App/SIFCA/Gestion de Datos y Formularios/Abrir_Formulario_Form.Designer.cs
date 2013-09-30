namespace SIFCA
{
    partial class Abrir_Formulario_Form
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
            this.formularioBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.formularioBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.busquedaTxt = new System.Windows.Forms.ToolStripTextBox();
            this.criterioLbl = new System.Windows.Forms.ToolStripLabel();
            this.criterioCbx = new System.Windows.Forms.ToolStripComboBox();
            this.formularioDGW = new System.Windows.Forms.DataGridView();
            this.estratosBS = new System.Windows.Forms.BindingSource(this.components);
            this.FECHACREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROFORMULARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEST = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HORAINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORAFINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARCELA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COORDENADAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COORDENADAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verDatos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.abrir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBN)).BeginInit();
            this.formularioBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratosBS)).BeginInit();
            this.SuspendLayout();
            // 
            // formularioBN
            // 
            this.formularioBN.AddNewItem = null;
            this.formularioBN.BindingSource = this.formularioBS;
            this.formularioBN.CountItem = null;
            this.formularioBN.DeleteItem = null;
            this.formularioBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBuscar,
            this.busquedaTxt,
            this.criterioLbl,
            this.criterioCbx});
            this.formularioBN.Location = new System.Drawing.Point(0, 0);
            this.formularioBN.MoveFirstItem = null;
            this.formularioBN.MoveLastItem = null;
            this.formularioBN.MoveNextItem = null;
            this.formularioBN.MovePreviousItem = null;
            this.formularioBN.Name = "formularioBN";
            this.formularioBN.PositionItem = null;
            this.formularioBN.Size = new System.Drawing.Size(1009, 25);
            this.formularioBN.TabIndex = 0;
            this.formularioBN.Text = "bindingNavigator1";
            // 
            // formularioBS
            // 
            this.formularioBS.DataSource = typeof(SIFCA_DAL.FORMULARIO);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(104, 22);
            this.lblBuscar.Text = "Buscar formulario:";
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
            "Estrato",
            "Parcela",
            "Linea",
            "Coord.X;Coord.Y"});
            this.criterioCbx.Name = "criterioCbx";
            this.criterioCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // formularioDGW
            // 
            this.formularioDGW.AllowUserToAddRows = false;
            this.formularioDGW.AllowUserToDeleteRows = false;
            this.formularioDGW.AutoGenerateColumns = false;
            this.formularioDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.formularioDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formularioDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHACREACION,
            this.NROFORMULARIO,
            this.NROUSUARIO,
            this.responsable,
            this.CODEST,
            this.HORAINICIO,
            this.HORAFINAL,
            this.PARCELA,
            this.LINEA,
            this.COORDENADAX,
            this.COORDENADAY,
            this.verDatos,
            this.abrir,
            this.eliminar});
            this.formularioDGW.DataSource = this.formularioBS;
            this.formularioDGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formularioDGW.Location = new System.Drawing.Point(0, 25);
            this.formularioDGW.Name = "formularioDGW";
            this.formularioDGW.ReadOnly = true;
            this.formularioDGW.Size = new System.Drawing.Size(1009, 409);
            this.formularioDGW.TabIndex = 1;
            this.formularioDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.formularioDGW_CellClick);
            this.formularioDGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.formularioDGW_DataBindingComplete);
            // 
            // estratosBS
            // 
            this.estratosBS.DataSource = typeof(SIFCA_DAL.ESTRATO);
            // 
            // FECHACREACION
            // 
            this.FECHACREACION.DataPropertyName = "FECHACREACION";
            this.FECHACREACION.HeaderText = "Fecha creaccion";
            this.FECHACREACION.Name = "FECHACREACION";
            this.FECHACREACION.ReadOnly = true;
            // 
            // NROFORMULARIO
            // 
            this.NROFORMULARIO.DataPropertyName = "NROFORMULARIO";
            this.NROFORMULARIO.HeaderText = "NROFORMULARIO";
            this.NROFORMULARIO.Name = "NROFORMULARIO";
            this.NROFORMULARIO.ReadOnly = true;
            this.NROFORMULARIO.Visible = false;
            // 
            // NROUSUARIO
            // 
            this.NROUSUARIO.DataPropertyName = "NROUSUARIO";
            this.NROUSUARIO.HeaderText = "NROUSUARIO";
            this.NROUSUARIO.Name = "NROUSUARIO";
            this.NROUSUARIO.ReadOnly = true;
            this.NROUSUARIO.Visible = false;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            // 
            // CODEST
            // 
            this.CODEST.DataPropertyName = "CODEST";
            this.CODEST.DataSource = this.estratosBS;
            this.CODEST.DisplayMember = "DESCRIPESTRATO";
            this.CODEST.HeaderText = "Estrato";
            this.CODEST.Name = "CODEST";
            this.CODEST.ReadOnly = true;
            this.CODEST.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CODEST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CODEST.ValueMember = "CODEST";
            // 
            // HORAINICIO
            // 
            this.HORAINICIO.DataPropertyName = "HORAINICIO";
            this.HORAINICIO.HeaderText = "H. Inicio";
            this.HORAINICIO.Name = "HORAINICIO";
            this.HORAINICIO.ReadOnly = true;
            // 
            // HORAFINAL
            // 
            this.HORAFINAL.DataPropertyName = "HORAFINAL";
            this.HORAFINAL.HeaderText = "H. Final";
            this.HORAFINAL.Name = "HORAFINAL";
            this.HORAFINAL.ReadOnly = true;
            // 
            // PARCELA
            // 
            this.PARCELA.DataPropertyName = "PARCELA";
            this.PARCELA.HeaderText = "Parcela";
            this.PARCELA.Name = "PARCELA";
            this.PARCELA.ReadOnly = true;
            // 
            // LINEA
            // 
            this.LINEA.DataPropertyName = "LINEA";
            this.LINEA.HeaderText = "Linea";
            this.LINEA.Name = "LINEA";
            this.LINEA.ReadOnly = true;
            // 
            // COORDENADAX
            // 
            this.COORDENADAX.DataPropertyName = "COORDENADAX";
            this.COORDENADAX.HeaderText = "Coord. X";
            this.COORDENADAX.Name = "COORDENADAX";
            this.COORDENADAX.ReadOnly = true;
            // 
            // COORDENADAY
            // 
            this.COORDENADAY.DataPropertyName = "COORDENADAY";
            this.COORDENADAY.HeaderText = "Coord. Y";
            this.COORDENADAY.Name = "COORDENADAY";
            this.COORDENADAY.ReadOnly = true;
            // 
            // verDatos
            // 
            this.verDatos.HeaderText = "";
            this.verDatos.Name = "verDatos";
            this.verDatos.ReadOnly = true;
            this.verDatos.Text = "ver Datos";
            this.verDatos.UseColumnTextForButtonValue = true;
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
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            // 
            // Abrir_Formulario_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 434);
            this.Controls.Add(this.formularioDGW);
            this.Controls.Add(this.formularioBN);
            this.Name = "Abrir_Formulario_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.formularioBN)).EndInit();
            this.formularioBN.ResumeLayout(false);
            this.formularioBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estratosBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource formularioBS;
        private System.Windows.Forms.BindingNavigator formularioBN;
        private System.Windows.Forms.DataGridView formularioDGW;
        private System.Windows.Forms.ToolStripLabel lblBuscar;
        private System.Windows.Forms.ToolStripTextBox busquedaTxt;
        private System.Windows.Forms.ToolStripLabel criterioLbl;
        private System.Windows.Forms.ToolStripComboBox criterioCbx;
        private System.Windows.Forms.BindingSource estratosBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHACREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROFORMULARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewComboBoxColumn CODEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAFINAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARCELA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COORDENADAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn COORDENADAY;
        private System.Windows.Forms.DataGridViewButtonColumn verDatos;
        private System.Windows.Forms.DataGridViewButtonColumn abrir;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}