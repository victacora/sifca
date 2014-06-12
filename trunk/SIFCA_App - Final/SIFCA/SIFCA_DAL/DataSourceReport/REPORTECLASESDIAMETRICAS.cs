using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIFCA_DAL
{
    public class REPORTECLASESDIAMETRICAS
    {
        //por arreglar

        //public string NOMBRECIEN { get; set; }
        //public Guid CODESP { get; set; }
        public String CLASE { get; set; }
        public decimal CONTEO { get; set; }
        public decimal AREABASAL { get; set; }
        public decimal VOLUMENCOMERCIAL { get; set; }
        public decimal VOLUMENTOTAL { get; set; }
        public decimal TOTAL { get; set; }
        public decimal PORCENTAJE { get; set; }
        public REPORTECLASESDIAMETRICAS()
        {
            try
            {
                //this.NOMBRECIEN = "";
                this.CLASE = "";
                //this.CODESP = Guid.Empty;
                this.CONTEO = 0;
                this.AREABASAL = 0;
                this.VOLUMENCOMERCIAL = 0;
                this.VOLUMENTOTAL = 0;
                this.TOTAL = 0;
                this.PORCENTAJE = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
    }
}
