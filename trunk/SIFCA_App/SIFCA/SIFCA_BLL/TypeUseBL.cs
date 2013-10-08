using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;

namespace SIFCA_BLL
{
    public class TypeUseBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public TypeUseBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }

        public IEnumerable<TIPODEUSO> SearchType(string search, string criterio)
        {
            if (criterio == "Nombre")
            {
                var query = from e in this.sifcaRepository.TIPODEUSO where (e.NOMBRETIPOUSO.Contains(search)) select e;
                return query.ToList();
            }
            if (criterio == "Descripcion")
            {
                var query = from e in this.sifcaRepository.TIPODEUSO where (e.DESCRIPCION.Contains(search)) select e;
                return query.ToList();
            }
            return new List<TIPODEUSO>();

        }

        public IEnumerable<TIPODEUSO> GetTypeUse()
        {
            return this.sifcaRepository.TIPODEUSO.ToList();
        }

        public TIPODEUSO GetTypeUse(String TypeUseId)
        {
            return this.sifcaRepository.TIPODEUSO.Find(TypeUseId);
        }

        public void InsertTypeUse(TIPODEUSO TypeUse)
        {
            try
            {
                this.sifcaRepository.TIPODEUSO.Add(TypeUse);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTypeUse(String TypeUseId)
        {
            try
            {
                TIPODEUSO TypeUse = this.sifcaRepository.TIPODEUSO.Find(TypeUseId);
                this.sifcaRepository.TIPODEUSO.Remove(TypeUse);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTypeUse(TIPODEUSO TypeUse)
        {
            try
            {
                this.sifcaRepository.Entry(TypeUse).State = EntityState.Modified;

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
