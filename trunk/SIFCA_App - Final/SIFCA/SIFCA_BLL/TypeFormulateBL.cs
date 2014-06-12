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
    public class TypeFormulateBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public TypeFormulateBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }

        public IEnumerable<TIPOFORMULA> GetTypeFormulates()
        {
            return this.sifcaRepository.TIPOFORMULA.ToList();
        }

        public TIPOFORMULA GetTypeFormulate(Guid cod)
        {
            try
            {
                return this.sifcaRepository.TIPOFORMULA.SingleOrDefault(ts => ts.NROTIPOFORMULA== cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertTypeFormulate(TIPOFORMULA typeformula)
        {
            try
            {
                this.sifcaRepository.TIPOFORMULA.Add(typeformula);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTypeFormulate(Guid cod)
        {
            try
            {
                TIPOFORMULA typeformula = this.sifcaRepository.TIPOFORMULA.SingleOrDefault(fm => fm.NROTIPOFORMULA == cod);
                if (typeformula != null) this.sifcaRepository.TIPOFORMULA.Remove(typeformula);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTypeFormulate(TIPOFORMULA typeFormula)
        {
            try
            {
                this.sifcaRepository.Entry(typeFormula).State = EntityState.Modified;
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


        public IEnumerable<TIPOFORMULA> SearchTypeFormulate(string search, string criteria)
        {
            if (criteria == "DESCRIPCION")
            {
                var query = from e in this.sifcaRepository.TIPOFORMULA where (e.DESCRIPCION == search) select e;
                return query.ToList();
            }
            if (criteria == "NOMBRE")
            {
                var query = from e in this.sifcaRepository.TIPOFORMULA where (e.NOMBRETIPO == search) select e;
                return query.ToList();
            }

            return null;
        }
    }
}
