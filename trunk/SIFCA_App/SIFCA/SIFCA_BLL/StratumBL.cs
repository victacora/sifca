using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;

namespace SIFCA_BLL
{
    public class StratumBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public StratumBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<ESTRATO> GetStratums()
        {
            return this.sifcaRepository.ESTRATO.ToList();
        }

        public ESTRATO GetStratumByDescription(string description)
        {
            return this.sifcaRepository.ESTRATO.SingleOrDefault(e => e.DESCRIPESTRATO == description);
        }

        public ESTRATO GetStratum(int stratumId)
        {
            return this.sifcaRepository.ESTRATO.Find(stratumId);
        }

        public void InsertStratum(ESTRATO stratum)
        {
            try
            {
                this.sifcaRepository.ESTRATO.Add(stratum);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStratum(int stratumId)
        {
            try
            {
                ESTRATO proyecto = this.sifcaRepository.ESTRATO.Find(stratumId);
                this.sifcaRepository.ESTRATO.Remove(proyecto);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStratum(ESTRATO stratum)
        {
            try
            {
                this.sifcaRepository.Entry(stratum).State = EntityState.Modified;

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
