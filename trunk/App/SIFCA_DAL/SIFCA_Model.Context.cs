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
using System.Data.Objects;

namespace SIFCA_DAL
{
    public partial class SIFCA_CONTEXT : DbContext
    {
        public SIFCA_CONTEXT()
            : base("name=SIFCA_CONTEXT")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CALIDAD> CALIDAD { get; set; }
        public DbSet<ESPECIE> ESPECIE { get; set; }
        public DbSet<ESTADOSANITARIO> ESTADOSANITARIO { get; set; }
        public DbSet<ESTRATO> ESTRATO { get; set; }
        public DbSet<FORMULARIO> FORMULARIO { get; set; }
        public DbSet<GRUPOCOMERCIAL> GRUPOCOMERCIAL { get; set; }
        public DbSet<IMAGEN> IMAGEN { get; set; }
        public DbSet<LINEAINVENTARIO> LINEAINVENTARIO { get; set; }
        public DbSet<LINEANOMADERABLES> LINEANOMADERABLES { get; set; }
        public DbSet<LINEAREGENERACION> LINEAREGENERACION { get; set; }
        public DbSet<LISTADODEESTRATOS> LISTADODEESTRATOS { get; set; }
        public DbSet<MEDIDACAPYDAP> MEDIDACAPYDAP { get; set; }
        public DbSet<OBJETIVOINVENTARIO> OBJETIVOINVENTARIO { get; set; }
        public DbSet<PROYECTO> PROYECTO { get; set; }
        public DbSet<PROYECTOSPORETAPA> PROYECTOSPORETAPA { get; set; }
        public DbSet<TIPODEUSO> TIPODEUSO { get; set; }
        public DbSet<TIPODISENOMUESTRAL> TIPODISENOMUESTRAL { get; set; }
        public DbSet<TRANSACCION> TRANSACCION { get; set; }
        public DbSet<TSTUDENT> TSTUDENT { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
    
        public virtual int createBackupDB(string baseLocation, string backupType)
        {
            var baseLocationParameter = baseLocation != null ?
                new ObjectParameter("BaseLocation", baseLocation) :
                new ObjectParameter("BaseLocation", typeof(string));
    
            var backupTypeParameter = backupType != null ?
                new ObjectParameter("BackupType", backupType) :
                new ObjectParameter("BackupType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("createBackupDB", baseLocationParameter, backupTypeParameter);
        }
    }
}
