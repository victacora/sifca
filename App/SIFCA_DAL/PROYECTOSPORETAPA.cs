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
    public partial class PROYECTOSPORETAPA
    {
        public System.Guid NROPROYCONTENEDOR { get; set; }
        public System.Guid NROPROYCONTENIDO { get; set; }
        public Nullable<decimal> PESO { get; set; }
    
        public virtual PROYECTO PROYECTO { get; set; }
        public virtual PROYECTO PROYECTO1 { get; set; }
    }
    
}
