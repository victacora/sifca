using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data;
using System.Data.Common;
using System.Data.Objects.DataClasses;
using System.Reflection;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;
using System.Runtime.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace SIFCA_DAL
{
    public partial class SIFCA_CONTEXT : DbContext
    {

        public USUARIO usuario;

        public override int  SaveChanges()
        {
            ChangeTracker.DetectChanges();
            if (usuario != null)
            {
                var entityList = ChangeTracker.Entries().Where(p => p.State == EntityState.Added || p.State == EntityState.Deleted || p.State == EntityState.Modified);
                foreach (var entity in entityList)
                {
                    if (entity.Entity != null && !(entity.Entity is TRANSACCION))
                    {
                        TRANSACCION transaccion = this.TrackFactory(entity);
                        this.TRANSACCION.Add(transaccion);
                    }
                }
            }
            return base.SaveChanges();
        
        }
        
        private TRANSACCION TrackFactory(DbEntityEntry entry)
        {
            TRANSACCION transaccion = new TRANSACCION();
            
            TableAttribute tableAttr = entry.Entity.GetType().GetCustomAttributes(typeof(TableAttribute), false).SingleOrDefault() as TableAttribute;
            
            string tableName = tableAttr != null ? tableAttr.Name : entry.Entity.GetType().Name;

            transaccion.NROTRANS = Guid.NewGuid();
            transaccion.NROUSUARIO = usuario.NROUSUARIO;
            transaccion.TABLA = tableName;
            transaccion.FECHA = DateTime.Now;            

            if (entry.State == EntityState.Added)
            {
                transaccion.IDREGISTRO = GetKeyValue(entry);
                transaccion.TIPOIDREGISTRO = GetTypeKey(entry);
                transaccion.VALORESNUEVOS = this.GetXml(entry.CurrentValues.ToObject());
                transaccion.OPERACION = "I";
            }
            else if (entry.State == EntityState.Modified)
            {
                transaccion.IDREGISTRO =GetKeyValue(entry);
                transaccion.TIPOIDREGISTRO = GetTypeKey(entry);
                transaccion.VALORESVIEJOS = this.GetXml(entry.OriginalValues.ToObject());
                transaccion.VALORESNUEVOS = this.GetXml(entry.CurrentValues.ToObject());
                transaccion.OPERACION = "A";
            }
            else
            {
                transaccion.IDREGISTRO = GetKeyValue(entry);
                transaccion.TIPOIDREGISTRO = GetTypeKey(entry);
                transaccion.VALORESVIEJOS = this.GetXml(entry.OriginalValues.ToObject());
                transaccion.OPERACION = "E";
            }

            return transaccion;
        }

        private string GetXml(object value)
        {
            DataContractSerializer dataContractSerializer = new DataContractSerializer(value.GetType());
            string result;
            using (StringWriter stringWriter = new StringWriter())
            {
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
                {
                    dataContractSerializer.WriteObject(xmlTextWriter, value);
                    result = stringWriter.ToString();
                }
            }
            return result;
        }

        public string GetKeyValue(DbEntityEntry entry)
        {
            var objectStateEntry = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
            string id = string.Empty;
            if (objectStateEntry.EntityKey.EntityKeyValues != null)
                id = objectStateEntry.EntityKey.EntityKeyValues[0].Value.ToString();

            return id;
        }

        public string GetTypeKey(DbEntityEntry entry)
        {
            var objectStateEntry = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
            string type = string.Empty;
            if (objectStateEntry.EntityKey.EntityKeyValues != null)
                type = objectStateEntry.EntityKey.EntityKeyValues[0].Value.GetType().ToString();
            return type;
        }
    }
}
