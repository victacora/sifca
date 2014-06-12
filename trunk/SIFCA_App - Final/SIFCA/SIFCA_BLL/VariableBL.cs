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
    public class VariableBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public VariableBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }

        public IEnumerable<VARIABLE> GetVariables()
        {
            return this.sifcaRepository.VARIABLE.ToList();
        }

        public VARIABLE GetVariable(Guid cod)
        {
            try
            {
                return this.sifcaRepository.VARIABLE.SingleOrDefault(ts => ts.NROVARIABLE == cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void InsertVariable(VARIABLE variable)
        {
            try
            {
                this.sifcaRepository.VARIABLE.Add(variable);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteVariable(Guid cod)
        {
            try
            {
                VARIABLE variable = this.sifcaRepository.VARIABLE.SingleOrDefault(ts => ts.NROVARIABLE == cod);
                if (variable != null) this.sifcaRepository.VARIABLE.Remove(variable);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateVariable(VARIABLE variable)
        {
            try
            {
                this.sifcaRepository.Entry(variable).State = EntityState.Modified;
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


        public IEnumerable<VARIABLE> SearchVariable(string search, string criteria )
        {
            if (criteria == "DESCRIPCION")
            {
                var query = from e in this.sifcaRepository.VARIABLE where (e.DESCRIPCION == search) select e;
                return query.ToList();
            }
            if (criteria == "NOMBRE")
            {
                var query = from e in this.sifcaRepository.VARIABLE where (e.NOMBRE == search) select e;
                return query.ToList();
            }
            return null;
        }
    }
}
