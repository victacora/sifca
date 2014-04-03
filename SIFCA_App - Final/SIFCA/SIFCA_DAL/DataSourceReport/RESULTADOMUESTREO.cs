using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIFCA_DAL
{
    public class RESULTADOMUESTREO
    {
        public System.Guid NROPROY { get; set; }
        public string ESTRATO { get; set; }
        public string N { get; set; }
        public double PESOESTRATO { get; set; }
        public string VARIABLE { get; set; }
        public double TOTAL { get; set; }
        public double TOTALPORHECTAREA { get; set; }
        public double PROMEDIO { get; set; }
        public double DESVIACIONESTANDAR { get; set; }
        public double ERRORDESVIACION { get; set; }
        public double ERRORRELATIVO { get; set; }
        public double ERRORABSOLUTOMUESTREO { get; set; }
        public double LIMITEINF { get; set; }
        public double LIMITESUP { get; set; }
        public double COEFICIENTEDEVARIACION { get; set; }
        public double TOTALPROMEDIOESTRATIFICADO { get; set; }
        public double TOTALDESESTANDARESTRATIFICADO { get; set; }
        public double TOTALERRRORELATIVO { get; set; }
        public double TOTALERRORMUESTREO { get; set; }
    }
}
