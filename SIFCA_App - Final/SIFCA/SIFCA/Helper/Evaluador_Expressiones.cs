using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_BLL;
using AleProjects.AleLexer.AleParser;
using System.Windows.Forms;

namespace SIFCA.Helper
{
    public class Evaluador_Expressiones
    {
        public bool  resultado = false;

        public AleTermResult EvaluarExpresion(string expresion, Dictionary<string, double> valores, Form parent)
        {
            Error_Form er = null;
            ExpressionEvaluator evaluador = new ExpressionEvaluator(true, true);
            int resultado = -1;
            string mensaje = string.Empty;
            AleTermResult val = evaluador.EvaluateExpression(expresion, valores, out resultado);
            if (resultado == 1)
            {
                mensaje = "Error '" + evaluador.AP.ErrorMessage() + "' en la linea:" + evaluador.AP.ErrorLine + " col:" + evaluador.AP.ErrorCol + "\u000d\u000a";
                er = new Error_Form(mensaje);
                er.MdiParent = parent;
                er.ShowDialog();
                this.resultado = false;
                return val;
            }
            if (resultado == 2)
            {
                mensaje = "Error \"" + val.ErrorMessage() + "\" en la linea:" + evaluador.AP.ErrorPosToLine(val.ErrorPos).ToString() + " columna:" + evaluador.AP.ErrorPosToCol(val.ErrorPos).ToString() + "\u000d\u000a";
                er = new Error_Form(mensaje);
                er.MdiParent = parent;
                er.ShowDialog();
                this.resultado = false;
                return val;
            }
            else if (resultado == 3) this.resultado = true;
            return val;
        }
    }
}
