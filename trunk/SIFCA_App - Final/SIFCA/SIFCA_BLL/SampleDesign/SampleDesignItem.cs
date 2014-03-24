using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;

namespace SIFCA_BLL
{
    public class SampleDesignItem
    {
        public FORMULARIO formulario { get; set; }

        public string Estrato { get; set; }
        public string Parcela { get; set; }
        
        public double volumenTotalHtas { get; set; }
        public double volumenComercialHtas { get; set; }
        public double numeroArbolesHtas { get; set; }
        public double areaBasalHtas { get; set; }

        public double volumenTotalParcela { get; set; }
        public double volumenComercialParcela { get; set; }
        public double numeroArbolesParcela { get; set; }
        public double areaBasalParcela { get; set; }
    }
}
