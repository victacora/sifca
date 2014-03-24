using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace SIFCA_BLL
{
    public class QualityBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public QualityBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }

        public IEnumerable<CALIDAD> SearchType(string search)
        {
            try
            {
                var query = from e in this.sifcaRepository.CALIDAD where (e.DESCRIPCALIDAD.Contains(search)) select e;
                return query.ToList();         

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CALIDAD getQualityByDescription(string description)
        {
            try
            {
                return this.sifcaRepository.CALIDAD.SingleOrDefault(p => p.DESCRIPCALIDAD.Contains(description));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<CALIDAD> GetQualities()
        {
            try
            {
                return this.sifcaRepository.CALIDAD.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CALIDAD GetQuality(Decimal QualityId)
        {
            try
            {
                return this.sifcaRepository.CALIDAD.Find(QualityId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void InsertQuality(CALIDAD quality)
        {
            try
            {
                this.sifcaRepository.CALIDAD.Add(quality);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteQuality(Decimal qualityId)
        {
            try
            {
                CALIDAD quality = this.sifcaRepository.CALIDAD.Find(qualityId);
                this.sifcaRepository.CALIDAD.Remove(quality);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateQuality(CALIDAD quality)
        {
            try
            {
                this.sifcaRepository.Entry(quality).State = EntityState.Modified;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string SaveChanges()
        {
            try
            {
                this.sifcaRepository.SaveChanges();
            }
            catch (UpdateException ex)
            {
                string error = "";
                error += string.Format("Error: {0}", ex.InnerException);
                return error;
            }
            catch (DbUpdateException ex)
            {
                string error = "";

                foreach (var ve in ex.Entries)
                {
                    error += string.Format("\nPropiedad: \"{0}\", Error: \"{1}\"", ve.Entity.GetType().Name, ex.InnerException);
                }

                return error;
            }
            catch (DbEntityValidationException ex)
            {
                string error = "";
                foreach (var eve in ex.EntityValidationErrors)
                {
                    error += string.Format("Entidad \"{0}\" \nEstado \"{1}\" \nErrores a validar:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        error += string.Format("\nPropiedad: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                    }
                }
                return error;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return string.Empty;
        }

    }
}
