using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;

namespace SIFCA_BLL
{
    public class StateBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public StateBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }

        public IEnumerable<ESTADOSANITARIO> SearchStates(string search, string criteria)
        {
            if (criteria == "Descripcion")
            {
                var query = from e in this.sifcaRepository.ESTADOSANITARIO where (e.DESCRIPESTADO.Contains(search)) select e;
                return query.ToList();
            }
            else
            {
                return new List<ESTADOSANITARIO>();
            }
        }

        public IEnumerable<ESTADOSANITARIO> GetStates()
        {
            return this.sifcaRepository.ESTADOSANITARIO.ToList();
        }

        public ESTADOSANITARIO GetState(String stateId)
        {
            return this.sifcaRepository.ESTADOSANITARIO.Find(stateId);
        }

        public void InsertState(ESTADOSANITARIO state)
        {
            try
            {
                this.sifcaRepository.ESTADOSANITARIO.Add(state);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteState(String stateId)
        {
            try
            {
                ESTADOSANITARIO state = this.sifcaRepository.ESTADOSANITARIO.Find(stateId);
                this.sifcaRepository.ESTADOSANITARIO.Remove(state);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateState(ESTADOSANITARIO state)
        {
            try
            {
                this.sifcaRepository.Entry(state).State = EntityState.Modified;

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
