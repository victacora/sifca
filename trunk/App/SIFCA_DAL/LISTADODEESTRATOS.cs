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
    public partial class LISTADODEESTRATOS
    {
        public System.Guid NROPROY { get; set; }
        public decimal CODEST { get; set; }
        public Nullable<decimal> PESO { get; set; }
    
        public virtual ESTRATO ESTRATO { get; set; }
        public virtual PROYECTO PROYECTO { get; set; }
    }
    
}
