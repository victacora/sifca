namespace SIFCA
{
    partial class Estacion_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estacion_Form));
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label nROESTLabel;
            System.Windows.Forms.Label pERSONARESPONSABLELabel;
            this.eSTACIONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eSTACIONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.nROESTTextBox = new System.Windows.Forms.TextBox();
            this.pERSONARESPONSABLETextBox = new System.Windows.Forms.TextBox();
            this.eSTACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nOMBRELabel = new System.Windows.Forms.Label();
            nROESTLabel = new System.Windows.Forms.Label();
            pERSONARESPONSABLELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eSTACIONBindingNavigator)).BeginInit();
            this.eSTACIONBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eSTACIONBindingNavigator
            // 
            this.eSTACIONBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eSTACIONBindingNavigator.BindingSource = this.eSTACIONBindingSource;
            this.eSTACIONBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eSTACIONBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eSTACIONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eSTACIONBindingNavigatorSaveItem});
            this.eSTACIONBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eSTACIONBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eSTACIONBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eSTACIONBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eSTACIONBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eSTACIONBindingNavigator.Name = "eSTACIONBindingNavigator";
            this.eSTACIONBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eSTACIONBindingNavigator.Size = new System.Drawing.Size(290, 25);
            this.eSTACIONBindingNavigator.TabIndex = 0;
            this.eSTACIONBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // eSTACIONBindingNavigatorSaveItem
            // 
            this.eSTACIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eSTACIONBindingNavigatorSaveItem.Enabled = false;
            this.eSTACIONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eSTACIONBindingNavigatorSaveItem.Image")));
            this.eSTACIONBindingNavigatorSaveItem.Name = "eSTACIONBindingNavigatorSaveItem";
            this.eSTACIONBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eSTACIONBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(31, 67);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(90, 13);
            nOMBRELabel.TabIndex = 1;
            nOMBRELabel.Text = "Nombre estacion:";
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTACIONBindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(178, 64);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRETextBox.TabIndex = 2;
            // 
            // nROESTLabel
            // 
            nROESTLabel.AutoSize = true;
            nROESTLabel.Location = new System.Drawing.Point(31, 93);
            nROESTLabel.Name = "nROESTLabel";
            nROESTLabel.Size = new System.Drawing.Size(27, 13);
            nROESTLabel.TabIndex = 3;
            nROESTLabel.Text = "Nro:";
            // 
            // nROESTTextBox
            // 
            this.nROESTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTACIONBindingSource, "NROEST", true));
            this.nROESTTextBox.Location = new System.Drawing.Point(178, 90);
            this.nROESTTextBox.Name = "nROESTTextBox";
            this.nROESTTextBox.Size = new System.Drawing.Size(100, 20);
            this.nROESTTextBox.TabIndex = 4;
            // 
            // pERSONARESPONSABLELabel
            // 
            pERSONARESPONSABLELabel.AutoSize = true;
            pERSONARESPONSABLELabel.Location = new System.Drawing.Point(31, 119);
            pERSONARESPONSABLELabel.Name = "pERSONARESPONSABLELabel";
            pERSONARESPONSABLELabel.Size = new System.Drawing.Size(72, 13);
            pERSONARESPONSABLELabel.TabIndex = 5;
            pERSONARESPONSABLELabel.Text = "Responsable:";
            // 
            // pERSONARESPONSABLETextBox
            // 
            this.pERSONARESPONSABLETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTACIONBindingSource, "PERSONARESPONSABLE", true));
            this.pERSONARESPONSABLETextBox.Location = new System.Drawing.Point(178, 116);
            this.pERSONARESPONSABLETextBox.Name = "pERSONARESPONSABLETextBox";
            this.pERSONARESPONSABLETextBox.Size = new System.Drawing.Size(100, 20);
            this.pERSONARESPONSABLETextBox.TabIndex = 6;
            // 
            // eSTACIONBindingSource
            // 
            this.eSTACIONBindingSource.DataSource = typeof(SIFCA_DAL.ESTACION);
            // 
            // Estacion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 269);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(nROESTLabel);
            this.Controls.Add(this.nROESTTextBox);
            this.Controls.Add(pERSONARESPONSABLELabel);
            this.Controls.Add(this.pERSONARESPONSABLETextBox);
            this.Controls.Add(this.eSTACIONBindingNavigator);
            this.Name = "Estacion_Form";
            this.Text = "Estacion_Form";
            ((System.ComponentModel.ISupportInitialize)(this.eSTACIONBindingNavigator)).EndInit();
            this.eSTACIONBindingNavigator.ResumeLayout(false);
            this.eSTACIONBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTACIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eSTACIONBindingSource;
        private System.Windows.Forms.BindingNavigator eSTACIONBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eSTACIONBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox nROESTTextBox;
        private System.Windows.Forms.TextBox pERSONARESPONSABLETextBox;
    }
}