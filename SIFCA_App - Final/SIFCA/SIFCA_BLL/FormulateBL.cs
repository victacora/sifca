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
    public class FormulateBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public FormulateBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }

        public IEnumerable<FORMULA> GetFormulates()
        {
            return this.sifcaRepository.FORMULA.ToList();
        }

        public FORMULA GetFormulate(Guid cod)
        {
            try
            {
                return this.sifcaRepository.FORMULA.SingleOrDefault(ts => ts.NROFORMULA == cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void InsertFormulates(FORMULA formula)
        {
            try
            {
                this.sifcaRepository.FORMULA.Add(formula);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteFormulate(Guid cod)
        {
            try
            {
                FORMULA formula = this.sifcaRepository.FORMULA.SingleOrDefault(fm => fm.NROFORMULA == cod);
                if (formula != null) this.sifcaRepository.FORMULA.Remove(formula);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateFormulate(FORMULA formula)
        {
            try
            {
                this.sifcaRepository.Entry(formula).State = EntityState.Modified;
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


        public IEnumerable<FORMULA> SearchFormulate(string search, string criteria )
        {
            if (criteria == "Descripcion")
            {
                var query = from e in this.sifcaRepository.FORMULA where (e.DESCRIPCION == search) select e;
                return query.ToList();
            }
            if (criteria == "Nombre")
            {
                var query = from e in this.sifcaRepository.FORMULA where (e.NOMBRE == search) select e;
                return query.ToList();
            }
            
            return null;
        }
    }
}
