using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;

namespace SIFCA_BLL
{
    public class RegenerationLineBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public RegenerationLineBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<LINEAREGENERACION> GetRegenerationLines()
        {
            return this.sifcaRepository.LINEAREGENERACION.ToList();
        }

        public LINEAREGENERACION GetRegenerationLine(int RegenerationLineId)
        {
            return this.sifcaRepository.LINEAREGENERACION.Find(RegenerationLineId);
        }

        public void InsertRegenerationLine(LINEAREGENERACION RegenerationLine)
        {
            try
            {
                this.sifcaRepository.LINEAREGENERACION.Add(RegenerationLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteRegenerationLine(Guid RegenerationLineId)
        {
            try
            {
                LINEAREGENERACION RegenerationLine = this.sifcaRepository.LINEAREGENERACION.Find(RegenerationLineId);
                this.sifcaRepository.LINEAREGENERACION.Remove(RegenerationLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateRegenerationLine(LINEAREGENERACION RegenerationLine)
        {
            try
            {
                this.sifcaRepository.Entry(RegenerationLine).State = EntityState.Modified;
                
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
                throw ex;
            }
            return string.Empty;
        }

    }
}
