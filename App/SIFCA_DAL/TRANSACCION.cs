//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace SIFCA_DAL
{
    public partial class TRANSACCION
    {
        public System.Guid NROTRANS { get; set; }
        public System.Guid NROUSUARIO { get; set; }
        public System.DateTime FECHA { get; set; }
        public string TABLA { get; set; }
        public decimal IDREGISTRO { get; set; }
        public string OPERACION { get; set; }
        public string VALORESVIEJOS { get; set; }
        public string VALORESNUEVOS { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
    
}
