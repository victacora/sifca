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
    public partial class COSTO
    {
        public COSTO()
        {
            this.LISTADODECOSTOS = new HashSet<LISTADODECOSTOS>();
        }
    
        public System.Guid NROCOSTO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string TIPO { get; set; }
    
        public virtual ICollection<LISTADODECOSTOS> LISTADODECOSTOS { get; set; }
    }
    
}