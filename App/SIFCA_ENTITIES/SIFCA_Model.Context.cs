﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SIFCA_ENTITIES
{
    public partial class SIFCA_CONNECTION : DbContext
    {
        public SIFCA_CONNECTION()
            : base("name=SIFCA_CONNECTION")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CALIDAD> CALIDAD { get; set; }
        public DbSet<ESPECIE> ESPECIE { get; set; }
        public DbSet<ESTACION> ESTACION { get; set; }
        public DbSet<ESTADOSANITARIO> ESTADOSANITARIO { get; set; }
        public DbSet<ESTRATO> ESTRATO { get; set; }
        public DbSet<ETAPA> ETAPA { get; set; }
        public DbSet<GRUPOCOMERCIAL> GRUPOCOMERCIAL { get; set; }
        public DbSet<INVENTARIO> INVENTARIO { get; set; }
        public DbSet<LISTADODEESPECIES> LISTADODEESPECIES { get; set; }
        public DbSet<PROYECTO> PROYECTO { get; set; }
        public DbSet<REGENERACION> REGENERACION { get; set; }
        public DbSet<TIPOINVENTARIO> TIPOINVENTARIO { get; set; }
        public DbSet<TSTUDENT> TSTUDENT { get; set; }
    }
}
