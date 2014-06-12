namespace SIFCA
{
    partial class Evaluador_Expresiones_Form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluador_Expresiones_Form));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnEval = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tIPOFORMULAComboBox = new System.Windows.Forms.ComboBox();
            this.tipoFormulaBS = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.chkStrictSyntax = new System.Windows.Forms.CheckBox();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.tipIgnoreCase = new System.Windows.Forms.ToolTip(this.components);
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.operadoresLbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarOperadorBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.variablesLbx = new System.Windows.Forms.ListBox();
            this.variableBS = new System.Windows.Forms.BindingSource(this.components);
            this.removerOperadorBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.removerVarBtn = new System.Windows.Forms.Button();
            this.agregarVarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoFormulaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableBS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 113);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 1;
            // 
            // btnEval
            // 
            this.btnEval.Location = new System.Drawing.Point(302, 332);
            this.btnEval.Name = "btnEval";
            this.btnEval.Size = new System.Drawing.Size(112, 23);
            this.btnEval.TabIndex = 4;
            this.btnEval.Text = "Evaluar expresión";
            this.btnEval.UseVisualStyleBackColor = true;
            this.btnEval.Click += new System.EventHandler(this.btnEval_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(184, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.descripcionTxt);
            this.groupBox1.Controls.Add(this.nombreTxt);
            this.groupBox1.Controls.Add(this.tIPOFORMULAComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkStrictSyntax);
            this.groupBox1.Controls.Add(this.chkIgnoreCase);
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // tIPOFORMULAComboBox
            // 
            this.tIPOFORMULAComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tIPOFORMULAComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tIPOFORMULAComboBox.DataSource = this.tipoFormulaBS;
            this.tIPOFORMULAComboBox.DisplayMember = "NOMBRETIPO";
            this.tIPOFORMULAComboBox.FormattingEnabled = true;
            this.tIPOFORMULAComboBox.Location = new System.Drawing.Point(298, 17);
            this.tIPOFORMULAComboBox.Name = "tIPOFORMULAComboBox";
            this.tIPOFORMULAComboBox.Size = new System.Drawing.Size(237, 21);
            this.tIPOFORMULAComboBox.TabIndex = 26;
            this.tIPOFORMULAComboBox.ValueMember = "NROTIPOFORMULA";
            // 
            // tipoFormulaBS
            // 
            this.tipoFormulaBS.DataSource = typeof(SIFCA_DAL.TIPOFORMULA);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo formula";
            // 
            // chkStrictSyntax
            // 
            this.chkStrictSyntax.AutoSize = true;
            this.chkStrictSyntax.Checked = true;
            this.chkStrictSyntax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStrictSyntax.Location = new System.Drawing.Point(122, 19);
            this.chkStrictSyntax.Name = "chkStrictSyntax";
            this.chkStrictSyntax.Size = new System.Drawing.Size(99, 17);
            this.chkStrictSyntax.TabIndex = 4;
            this.chkStrictSyntax.Text = "Sintaxis estricta";
            this.chkStrictSyntax.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Location = new System.Drawing.Point(6, 19);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(117, 17);
            this.chkIgnoreCase.TabIndex = 0;
            this.chkIgnoreCase.Text = "Ignorar mayúsculas";
            this.tipIgnoreCase.SetToolTip(this.chkIgnoreCase, "This will reset all variables");
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            this.chkIgnoreCase.CheckedChanged += new System.EventHandler(this.chkIgnoreCase_CheckedChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(186, 241);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(378, 85);
            this.txtResult.TabIndex = 3;
            this.txtResult.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Expresión";
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(186, 129);
            this.txtExpression.Multiline = true;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExpression.Size = new System.Drawing.Size(378, 89);
            this.txtExpression.TabIndex = 14;
            this.txtExpression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpression_KeyDown);
            this.txtExpression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpression_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Resultado ";
            // 
            // operadoresLbx
            // 
            this.operadoresLbx.FormattingEnabled = true;
            this.operadoresLbx.Items.AddRange(new object[] {
            "Suma (+)",
            "Resta (-)",
            "Multiplicacion(*)",
            "Division (/)",
            "Potencia(Pow(b,p))",
            "Log base  N(Log(x))",
            "Log base 10 (Log10(x))",
            "Raiz(sqrt(b,r))",
            "E^x(Exp(p))"});
            this.operadoresLbx.Location = new System.Drawing.Point(13, 129);
            this.operadoresLbx.Name = "operadoresLbx";
            this.operadoresLbx.Size = new System.Drawing.Size(156, 56);
            this.operadoresLbx.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Operadores permitidos";
            // 
            // AgregarOperadorBtn
            // 
            this.AgregarOperadorBtn.Location = new System.Drawing.Point(13, 195);
            this.AgregarOperadorBtn.Name = "AgregarOperadorBtn";
            this.AgregarOperadorBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarOperadorBtn.TabIndex = 18;
            this.AgregarOperadorBtn.Text = "Agregar";
            this.AgregarOperadorBtn.UseVisualStyleBackColor = true;
            this.AgregarOperadorBtn.Click += new System.EventHandler(this.AgregarOperadorBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Variables";
            // 
            // variablesLbx
            // 
            this.variablesLbx.DataSource = this.variableBS;
            this.variablesLbx.DisplayMember = "NOMBRE";
            this.variablesLbx.FormattingEnabled = true;
            this.variablesLbx.Location = new System.Drawing.Point(13, 241);
            this.variablesLbx.Name = "variablesLbx";
            this.variablesLbx.Size = new System.Drawing.Size(154, 56);
            this.variablesLbx.TabIndex = 20;
            this.variablesLbx.ValueMember = "NROVARIABLE";
            // 
            // variableBS
            // 
            this.variableBS.DataSource = typeof(SIFCA_DAL.VARIABLE);
            // 
            // removerOperadorBtn
            // 
            this.removerOperadorBtn.Location = new System.Drawing.Point(94, 195);
            this.removerOperadorBtn.Name = "removerOperadorBtn";
            this.removerOperadorBtn.Size = new System.Drawing.Size(75, 23);
            this.removerOperadorBtn.TabIndex = 21;
            this.removerOperadorBtn.Text = "Remover";
            this.removerOperadorBtn.UseVisualStyleBackColor = true;
            this.removerOperadorBtn.Click += new System.EventHandler(this.removerOperadorBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(419, 332);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(70, 23);
            this.guardarBtn.TabIndex = 22;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // removerVarBtn
            // 
            this.removerVarBtn.Location = new System.Drawing.Point(94, 303);
            this.removerVarBtn.Name = "removerVarBtn";
            this.removerVarBtn.Size = new System.Drawing.Size(75, 23);
            this.removerVarBtn.TabIndex = 24;
            this.removerVarBtn.Text = "Remover";
            this.removerVarBtn.UseVisualStyleBackColor = true;
            this.removerVarBtn.Click += new System.EventHandler(this.removerVarBtn_Click);
            // 
            // agregarVarBtn
            // 
            this.agregarVarBtn.Location = new System.Drawing.Point(13, 302);
            this.agregarVarBtn.Name = "agregarVarBtn";
            this.agregarVarBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarVarBtn.TabIndex = 23;
            this.agregarVarBtn.Text = "Agregar";
            this.agregarVarBtn.UseVisualStyleBackColor = true;
            this.agregarVarBtn.Click += new System.EventHandler(this.agregarVarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(494, 332);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(70, 23);
            this.cancelarBtn.TabIndex = 25;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(121, 43);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(414, 20);
            this.nombreTxt.TabIndex = 27;
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(121, 69);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(414, 20);
            this.descripcionTxt.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre formula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Descripción formula";
            // 
            // Evaluador_Expresiones_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 374);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.removerVarBtn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.agregarVarBtn);
            this.Controls.Add(this.btnEval);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.removerOperadorBtn);
            this.Controls.Add(this.variablesLbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgregarOperadorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operadoresLbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Evaluador_Expresiones_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluador de expresiones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoFormulaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnEval;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.ToolTip tipIgnoreCase;
        private System.Windows.Forms.CheckBox chkStrictSyntax;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox operadoresLbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarOperadorBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox variablesLbx;
        private System.Windows.Forms.Button removerOperadorBtn;
        private System.Windows.Forms.BindingSource variableBS;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button removerVarBtn;
        private System.Windows.Forms.Button agregarVarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.ComboBox tIPOFORMULAComboBox;
        private System.Windows.Forms.BindingSource tipoFormulaBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.TextBox nombreTxt;
    }
}

