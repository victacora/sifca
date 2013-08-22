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

        public SpeciesBL()
        {
            this.sifcaRepository = new SIFCA_CONTEXT();
        }


        public IEnumerable<ESPECIE> GetSpecies()
        {
            return this.sifcaRepository.ESPECIE.ToList();
        }

        public ESPECIE GetSpecie(int SpecieId)
        {
            return this.sifcaRepository.ESPECIE.Find(SpecieId);
        }

        public void InsertSpecie(ESPECIE Specie)
        {
            try
            {
                this.sifcaRepository.ESPECIE.Add(Specie);
                this.sifcaRepository.SaveChanges();
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
                ESPECIE proyecto = this.sifcaRepository.ESPECIE.Find(SpecieId);
                this.sifcaRepository.ESPECIE.Remove(proyecto);
                this.sifcaRepository.SaveChanges();
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
                this.sifcaRepository.SaveChanges();
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
