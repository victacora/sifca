using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

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
            return this.sifcaRepository.ESPECIE.ToList();
        }

        public ESPECIE GetSpecie(Guid SpecieId)
        {
            return this.sifcaRepository.ESPECIE.Find(SpecieId);
        }

        public ESPECIE GetSpecieByComNameAndScienName(string commonName, string scientificName)
        {
            return this.sifcaRepository.ESPECIE.SingleOrDefault(p => p.NOMCOMUN == commonName && p.NOMCIENTIFICO == scientificName);
        }

        public IEnumerable<ESPECIE> SearchSpecies(string search, string criteria)
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

        public void DeleteSpecies(int SpecieId)
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

        public void SaveChanges()
        {
            try
            {
                this.sifcaRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
