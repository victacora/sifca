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
    public class TStudentBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public TStudentBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }

        public IEnumerable<TSTUDENT> GetTStudents()
        {
            return this.sifcaRepository.TSTUDENT.ToList();
        }

        public TSTUDENT GetTStudent(decimal alpha, decimal freedomDegrees)
        {
            try
            {

                foreach (TSTUDENT ts in this.sifcaRepository.TSTUDENT.ToList())
                {
                    if(ts.ALPHA == alpha && ts.N == freedomDegrees) return ts;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void InsertTStudent(TSTUDENT TStudent)
        {
            try
            {
                this.sifcaRepository.TSTUDENT.Add(TStudent);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTStudent(decimal alpha, decimal freedomDegrees)
        {
            try
            {
                TSTUDENT TStudent = this.sifcaRepository.TSTUDENT.SingleOrDefault(ts => ts.ALPHA == alpha && ts.N == freedomDegrees);
                if(TStudent!=null)this.sifcaRepository.TSTUDENT.Remove(TStudent);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTStudent(TSTUDENT TStudent)
        {
            try
            {
                this.sifcaRepository.Entry(TStudent).State = EntityState.Modified;
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


        public IEnumerable<TSTUDENT> SearchTStudent(decimal search, string criteria)
        {
            if (criteria == "N")
            {
                var query = from e in this.sifcaRepository.TSTUDENT where (e.N==search) select e;
                return query.ToList();
            }
            if (criteria == "ALPHA")
            {
                var query = from e in this.sifcaRepository.TSTUDENT where (e.ALPHA == search) select e;
                return query.ToList();
            }
            if (criteria == "VALOR")
            {
                var query = from e in this.sifcaRepository.TSTUDENT where (e.VALOR == search) select e;
                return query.ToList();
            }
            return null;
        }
    }
}
