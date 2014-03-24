using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIFCA_DAL
{
    public class REPORTERESULTADODATASOURCE
    {
        public List<RESULTADOMUESTREO> resultados{get; set;}

        public REPORTERESULTADODATASOURCE(List<RESULTADOMUESTREO> resultados_)
        {
            resultados=resultados_;
        }

        public List<RESULTADOMUESTREO> ObtenerResultados() 
        {
            return resultados;
        }
        
    }
}
