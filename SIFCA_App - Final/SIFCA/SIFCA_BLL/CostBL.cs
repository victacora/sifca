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
    public class CostBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public CostBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<COSTO> GetCosts()
        {
            return this.sifcaRepository.COSTO.ToList();
        }

        public COSTO GetCost(Guid costId)
        {
            return this.sifcaRepository.COSTO.Find(costId);
        }

        public IEnumerable<COSTO> SearchCost(string search)
        {
            var query = from e in this.sifcaRepository.COSTO where (e.NOMBRE.Contains(search)) select e;
            return query.ToList();
        }

        public void InsertCost(COSTO cost)
        {
            try
            {
                this.sifcaRepository.COSTO.Add(cost);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCost(Guid costId)
        {
            try
            {
                COSTO cost = this.sifcaRepository.COSTO.Find(costId);
                this.sifcaRepository.COSTO.Remove(cost);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCost(COSTO cost)
        {
            try
            {
                this.sifcaRepository.Entry(cost).State = EntityState.Modified;

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


        public COSTO getCostByName(string name)
        {
            try
            {
                return this.sifcaRepository.COSTO.SingleOrDefault(p => p.NOMBRE==name);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
