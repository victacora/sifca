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

namespace SIFCA_ENTITIES
{
    public partial class ESTACION
    {
        public ESTACION()
        {
            this.INVENTARIO = new HashSet<INVENTARIO>();
        }
    
        public System.Guid NROEST { get; set; }
        public string PERSONARESPONSABLE { get; set; }
        public string NOMBRE { get; set; }
    
        public virtual ICollection<INVENTARIO> INVENTARIO { get; set; }
    }
    
}
