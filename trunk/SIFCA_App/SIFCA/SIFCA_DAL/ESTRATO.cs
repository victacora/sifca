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
    public partial class ESTRATO
    {
        public ESTRATO()
        {
            this.FORMULARIO = new HashSet<FORMULARIO>();
            this.LISTADODEESTRATOS = new HashSet<LISTADODEESTRATOS>();
        }
    
        public decimal CODEST { get; set; }
        public string DESCRIPESTRATO { get; set; }
    
        public virtual ICollection<FORMULARIO> FORMULARIO { get; set; }
        public virtual ICollection<LISTADODEESTRATOS> LISTADODEESTRATOS { get; set; }
    }
    
}