using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AleProjects.AleLexer.AleParser;
using AleProjects.AleLexer;
using SIFCA_BLL;
using SIFCA_DAL;

namespace SIFCA
{

    public partial class Evaluador_Expresiones_Form : Form
    {
        private AleExpressionParser AP = new AleExpressionParser();
        private VariableBL variable;
        private FormulateBL formulas;
        private TypeFormulateBL tipoFormulas;
        private AleTermResult val;
        Random rnd = new Random();
        Dictionary<string, object> Variables;


        public Evaluador_Expresiones_Form()
        {
            InitializeComponent();
            variable = new VariableBL(Program.ContextData);
            formulas = new FormulateBL(Program.ContextData);
            tipoFormulas = new TypeFormulateBL(Program.ContextData);
            variableBS.DataSource = variable.GetVariables();
            tipoFormulaBS.DataSource = tipoFormulas.GetTypeFormulates();
            AP.InitOperations(AleExpressionParser.OPERATIONS_CLIKESET);
            AP.IgnoreCase = chkIgnoreCase.Checked;
            Variables = new Dictionary<string, object>(AP.IgnoreCase ? StringComparer.CurrentCultureIgnoreCase : StringComparer.CurrentCulture);
            Variables.Add("S", "AleExpressionParser 1.0 beta");
        }


        private void OnSemanticsValidate(object sender, SemanticsValidateEventArgs e)
        {
            bool ignoreCase = chkIgnoreCase.Checked;
            AleExpressionParser P = sender as AleExpressionParser;

            // We want for some reasons that "Rnd" can't be a operador name
            if ((e.Term.HashCode == -1028829980 && !ignoreCase && e.Term.Value.ToString() == "Rnd") ||
                (e.Term.HashCode == 1843313028 && ignoreCase && e.Term.Value.ToString() == "RND"))
            {
                AleTerm parent = e.Term.Parent;
                if (e.Term.TypeOfTerm == AleTermType.Variable && (parent == null || parent.Operation == null || !parent.Operation.IsClassOperator || e.Term != parent[1]))
                    P.SetError(e.Term.Token.StartInOrigin, AleExpressionParser.ERROR_INVALIDVARIABLE);
            }
        }

        // evaluation
        private void OnEvaluate(AleTerm term, AleTermEvaluateArgs e)
        {
            bool ignoreCase = chkIgnoreCase.Checked;
            object res;

            if (e.Instance == null)
            {
                if (Variables.TryGetValue(e.Name, out res)) e.Result = res;
                else
                {
                    res = (int)0;
                    Variables.Add(e.Name, res);
                    e.Result = res;
                }
                return;
            }
        }

        // assignment
        private void OnAssign(AleTerm term, AleTermAssignArgs e)
        {
            bool ignoreCase = chkIgnoreCase.Checked;

            if (e.Instance == null)
            {
                Variables[e.Name] = e.Value;
                return;
            }
            e.SetError(AleTermResult.ERROR_UNKNOWNELEMENT, term.Token.StartInOrigin);
        }

        private void ShowError(AleExpressionParser AP)
        {
            txtResult.Text = "Error '" + AP.ErrorMessage() + "' en la linea:" + AP.ErrorLine + " col:" + AP.ErrorCol + "\u000d\u000a";
            txtExpression.SelectionStart = AP.ErrorPosition;
            txtExpression.SelectionLength = 1;
            txtExpression.Focus();
        }

        private void btnEval_Click(object sender, EventArgs e)
        {
            List<AleToken> list;
            AleTerm T = null;

            lblInfo.Text = "";
            txtResult.Text = "";

            AP.Options = (chkIgnoreCase.Checked ? AleExpressionParser.OPTION_IGNORECASE : 0) +
                AleExpressionParser.OPTION_ALLOWEMPTYLISTMEMBER +
                (chkStrictSyntax.Checked ? AleExpressionParser.OPTION_STRICTSYNTAX : 0) +
                AleExpressionParser.OPTION_ALLOWEMPTYPARAMS +
                AleExpressionParser.OPTION_ALLOWEMPTYINDEX +
                AleExpressionParser.OPTION_ALLOWMULTIDIMINDEXES +
                AleExpressionParser.OPTION_STRICTINDEXES;

            AP.Text = txtExpression.Text;
            AP.VarPrefix ='\0';
            AP.EndOfExpression = "; 'Fin de la expresion' 'Parar aqui'";

            AP.Constants = new Dictionary<string, object>(AP.IgnoreCase ? StringComparer.CurrentCultureIgnoreCase : StringComparer.CurrentCulture);
            AP.Constants.Add("true", true);
            AP.Constants.Add("false", false);
            AP.Constants.Add("PI", Math.PI);
            AP.Constants.Add("π", Math.PI);
            AP.Constants.Add("null", null);

            AP.SemanticsValidate += OnSemanticsValidate;

            int res = 0;


            while (res < AP.Text.Length)
            {
                res = AP.Tokenize(out list, res);

                if (AP.ErrorCode == AleExpressionParser.ERROR_OK) T = AP.Parse(list);

                if (AP.ErrorCode != AleExpressionParser.ERROR_OK)
                {
                    ShowError(AP);
                    break;
                }

                if (T != null)
                {
                    if (!T.Evaluate(out val, OnEvaluate, OnAssign))
                    {
                        txtResult.Text = "Error \"" + val.ErrorMessage() + "\" en la linea:" + AP.ErrorPosToLine(val.ErrorPos).ToString() + " columna:" + AP.ErrorPosToCol(val.ErrorPos).ToString() + "\u000d\u000a";
                        txtExpression.SelectionStart = val.ErrorPos;
                        txtExpression.SelectionLength = 1;
                        txtExpression.Focus();
                        break;
                    }
                    else if (val.Value != null) txtResult.Text += val.Value.ToString() + " :tipo de resultado = " + val.Value.GetType().ToString() + "\u000d\u000a";
                    else txtResult.Text += "<null>\u000d\u000a";
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            txtResult.Text = "";
            txtExpression.Text = "";
        }

        private void chkIgnoreCase_CheckedChanged(object sender, EventArgs e)
        {
            AP.IgnoreCase = chkIgnoreCase.Checked;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            double valor = 0;
            if (val.Value != null && double.TryParse(val.Value.ToString(),out valor))
            {
                FORMULA formula = new FORMULA();
                foreach (VARIABLE variable in variableBS)
                {
                    string[] tokens = txtExpression.Text.Split();
                    for (int i = tokens.Length - 1; i >= 0; i--)
                    {
                        if (tokens[i].Trim() == variable.NOMBRE)
                        {
                            if (!formula.VARIABLE.Contains(variable))
                            {
                                formula.VARIABLE.Add(variable);
                                break;
                            }
                        }
                    }
                }
                formula.EXPRESION = txtExpression.Text;
                formula.DESCRIPCION = descripcionTxt.Text;
                formula.NOMBRE = nombreTxt.Text;
                formula.TIPOFORMULA =tipoFormulaBS.Current!=null?(TIPOFORMULA)tipoFormulaBS.Current:null;
                formulas.InsertFormulates(formula);
                string result = formulas.SaveChanges();
                if (result == "")
                {
                    MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Error_Form errorForm = new Error_Form(result);
                    errorForm.MdiParent = ParentForm;
                    errorForm.Show();
                }
            }
            else 
            {
                MessageBox.Show("La expresion ingresada es erronea.", "Expression erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarOperadorBtn_Click(object sender, EventArgs e)
        {
            if (operadoresLbx.SelectedItem != null)
            {
                string operador = operadoresLbx.SelectedItem.ToString();
                int start = operador.IndexOf("(") + 1;
                int end = operador.IndexOf(")", start);
                operador = operador.Substring(start, end - start) + (operador.Length != end + 1 && operador[end + 1] == ')' ? ")" : "");
                txtExpression.SelectedText +=" "+operador+" ";
            }
        }

        private void removerOperadorBtn_Click(object sender, EventArgs e)
        {
            if (operadoresLbx.SelectedItem != null)
            {
                string operador = operadoresLbx.SelectedItem.ToString();
                int start = operador.IndexOf("(") + 1;
                int end = operador.IndexOf(")", start);
                operador = operador.Substring(start, end - start) + (operador.Length != end + 1 && operador[end + 1] == ')' ? ")" : "");
                int cursorPosition = txtExpression.SelectionStart;
                int selectionStart = 0;
                txtExpression.SelectionStart = selectionStart;
                txtExpression.SelectionLength = txtExpression.Text.Substring(selectionStart, cursorPosition).Length;
                string finalExpresion = txtExpression.Text.Substring(cursorPosition);
                string[] tokens = txtExpression.SelectedText.Split();
                string expression = "";
                bool encontrato = false;
                for (int i = tokens.Length - 1; i >= 0; i--)
                {
                    if (tokens[i] == operador && !encontrato) encontrato=true;
                    else expression += " " + tokens[i] + " "; 
                }
                txtExpression.Text = expression.Trim() + finalExpresion;
            }
        }

        private void agregarVarBtn_Click(object sender, EventArgs e)
        {
            VARIABLE variable = (VARIABLE)variablesLbx.SelectedItem;
            if (variable != null)
            {
                txtExpression.SelectedText += " " + variable.NOMBRE + " "; 
            }
        }

        private void removerVarBtn_Click(object sender, EventArgs e)
        {
             VARIABLE variable = (VARIABLE)variablesLbx.SelectedItem;
             if (variable != null)
             {
                 int cursorPosition = txtExpression.SelectionStart;
                 int selectionStart = 0;
                 txtExpression.SelectionStart = selectionStart;
                 txtExpression.SelectionLength = txtExpression.Text.Substring(selectionStart, cursorPosition).Length;
                 string finalExpresion = txtExpression.Text.Substring(cursorPosition);
                 string[] tokens = txtExpression.SelectedText.Split();
                 string expression="";
                 bool encontrato = false;
                 for (int i = tokens.Length - 1; i >= 0; i--)
                 {
                     if (tokens[i] == variable.NOMBRE && !encontrato) encontrato = true;
                     else expression += " " + tokens[i] + " "; 
                 }
                 txtExpression.Text = expression.Trim()+finalExpresion;
             }
        }

        private void txtExpression_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (Char)Keys.Back)
            {
                int cursorPosition = txtExpression.SelectionStart;
                if ((cursorPosition - 1)>=0 && (cursorPosition - 1) <=txtExpression.Text.Length&& (char.IsDigit(txtExpression.Text[cursorPosition - 1]) || char.IsWhiteSpace(txtExpression.Text[cursorPosition - 1]) || txtExpression.Text[cursorPosition - 1] == ')' || txtExpression.Text[cursorPosition - 1] == '(' || txtExpression.Text[cursorPosition - 1] == '*' || txtExpression.Text[cursorPosition - 1] == '/' || txtExpression.Text[cursorPosition - 1] == '+' || txtExpression.Text[cursorPosition - 1] == '-' || txtExpression.Text[cursorPosition - 1] == '^' || txtExpression.Text[cursorPosition - 1] == '.' || txtExpression.Text[cursorPosition - 1] == ';' || txtExpression.Text[cursorPosition - 1] == ',' || txtExpression.Text[cursorPosition - 1] == '=')) e.Handled = false;
                else e.Handled = true;
            }
            else if (char.IsWhiteSpace(e.KeyChar) || e.KeyChar == ')' || e.KeyChar == '(' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '^' || e.KeyChar == '.' || e.KeyChar == ';' || e.KeyChar == ',' || e.KeyChar == '=') e.Handled = false;
            else if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            else if (char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtExpression_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int cursorPosition = txtExpression.SelectionStart;
                if ((cursorPosition + 1) >= 0 && (cursorPosition + 1)<txtExpression.Text.Length && (char.IsDigit(txtExpression.Text[cursorPosition + 1]) || char.IsWhiteSpace(txtExpression.Text[cursorPosition + 1]) || txtExpression.Text[cursorPosition + 1] == ')' || txtExpression.Text[cursorPosition + 1] == '(' || txtExpression.Text[cursorPosition + 1] == '*' || txtExpression.Text[cursorPosition + 1] == '/' || txtExpression.Text[cursorPosition + 1] == '+' || txtExpression.Text[cursorPosition + 1] == '-' || txtExpression.Text[cursorPosition + 1] == '^' || txtExpression.Text[cursorPosition + 1] == '.' || txtExpression.Text[cursorPosition + 1] == ';' || txtExpression.Text[cursorPosition + 1] == ',' || txtExpression.Text[cursorPosition + 1] == '=')) e.Handled = false;
                else e.Handled = true;
            }
        }

       
    }
}
