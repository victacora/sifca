using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace SIFCA_BLL
{
    public class ImageBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public ImageBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<IMAGEN> GetImages()
        {

            return this.sifcaRepository.IMAGEN.ToList();
        }

        public IMAGEN GetImage(Guid imgId)
        {
            return this.sifcaRepository.IMAGEN.Find(imgId);
        }

        public IEnumerable<IMAGEN> SearchImage(string search)
        {
            var query = from e in this.sifcaRepository.IMAGEN where (e.NOMBRE.Contains(search)) select e;
            return query.ToList();
        }

        public void InsertImage(IMAGEN img)
        {
            try
            {
                this.sifcaRepository.IMAGEN.Add(img);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteImage(Guid imgId)
        {
            try
            {
                IMAGEN image = this.sifcaRepository.IMAGEN.Find(imgId);
                this.sifcaRepository.IMAGEN.Remove(image);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateImage(IMAGEN img)
        {
            try
            {
                this.sifcaRepository.Entry(img).State = EntityState.Modified;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string  SaveChanges()
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
