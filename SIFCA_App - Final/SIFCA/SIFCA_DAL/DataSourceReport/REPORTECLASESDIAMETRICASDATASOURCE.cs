using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIFCA_DAL
{
    //por arreglar
    public class REPORTECLASESDIAMETRICASDATASOURCE
    {
        public List<REPORTECLASESDIAMETRICAS> resultados{get; set;}

        public string nombre { get; set; }
        public Guid codEsp { get; set; }

        public REPORTECLASESDIAMETRICASDATASOURCE(List<REPORTECLASESDIAMETRICAS> resultados_, string nombre, Guid cod)
        {
            try
            {
                resultados=resultados_;
                this.nombre = nombre;
                this.codEsp = cod;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public List<REPORTECLASESDIAMETRICAS> ObtenerResultados() 
        {
            return resultados;
        }
        
    }
}
