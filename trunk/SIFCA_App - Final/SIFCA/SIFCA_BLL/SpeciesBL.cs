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
    public class SpeciesBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public SpeciesBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<ESPECIE> GetSpecies()
        {
            try
            {
                return this.sifcaRepository.ESPECIE.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public ESPECIE GetSpecie(Guid SpecieId)
        {
            try
            {
                return this.sifcaRepository.ESPECIE.Find(SpecieId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public ESPECIE GetSpecieByComNameAndScienName(string commonName, string scientificName)
        {
            try
            {
                return this.sifcaRepository.ESPECIE.SingleOrDefault(p => p.NOMCOMUN == commonName && p.NOMCIENTIFICO == scientificName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ESPECIE> SearchSpecies(string search, string criteria)
        {
            try
            {
                if (criteria == "Grupo Comercial")
                {
                    var query = from e in this.sifcaRepository.ESPECIE where (e.GRUPOCOM.Contains(search)) select e;
                    return query.ToList();
                }
                if (criteria == "Nombre Comun")
                {
                    var query = from e in this.sifcaRepository.ESPECIE where (e.NOMCOMUN.Contains(search)) select e;
                    return query.ToList();
                }
                if (criteria == "Nombre Cientifico")
                {
                    var query = from e in this.sifcaRepository.ESPECIE where (e.NOMCIENTIFICO.Contains(search)) select e;
                    return query.ToList();
                }
                if (criteria == "Familia")
                {
                    var query = from e in this.sifcaRepository.ESPECIE where (e.FAMILIA.Contains(search)) select e;
                    return query.ToList();
                }
                if (criteria == "Zona Geografica")
                {
                    var query = from e in this.sifcaRepository.ESPECIE where (e.ZONAGEOGRAFICA.Contains(search)) select e;
                    return query.ToList();
                }
                if (criteria == "Zona Vida")
                {
                    var query = from e in this.sifcaRepository.ESPECIE where (e.ZONADEVIDA.Contains(search)) select e;
                    return query.ToList();
                }
                return new List<ESPECIE>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void InsertSpecie(ESPECIE Specie)
        {
            try
            {
                this.sifcaRepository.ESPECIE.Add(Specie);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteSpecies(Guid SpecieId)
        {
            try
            {
                ESPECIE specie = this.sifcaRepository.ESPECIE.Find(SpecieId);
                this.sifcaRepository.ESPECIE.Remove(specie);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateSpecies(ESPECIE Specie)
        {
            try
            {
                this.sifcaRepository.Entry(Specie).State = EntityState.Modified;

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

    }
}
