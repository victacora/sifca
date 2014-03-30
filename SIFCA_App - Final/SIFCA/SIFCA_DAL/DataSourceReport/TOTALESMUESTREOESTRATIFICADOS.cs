using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIFCA_DAL
{
    public class TOTALESMUESTREOESTRATIFICADOS
    {
        public string VARIABLE { get; set; }
        public double COEFICIENTEDEVARIACION { get; set; }
        public double TOTALPROMEDIOESTRATIFICADO { get; set; }
        public double TOTALDESESTANDARESTRATIFICADO { get; set; }
        public double TOTALERRRORELATIVO { get; set; }
        public double TOTALERRORMUESTREO { get; set; }
    }
}
