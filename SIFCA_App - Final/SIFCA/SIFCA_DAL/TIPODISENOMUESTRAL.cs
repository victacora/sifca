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
    public partial class TIPODISENOMUESTRAL
    {
        public TIPODISENOMUESTRAL()
        {
            this.PROYECTO = new HashSet<PROYECTO>();
        }
    
        public string NOMTIPODISEMUEST { get; set; }
        public string DESCRIPTIPODISEMUEST { get; set; }
    
        public virtual ICollection<PROYECTO> PROYECTO { get; set; }
    }
    
}