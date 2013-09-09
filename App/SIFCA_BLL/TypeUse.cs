using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class TypeUse 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public TypeUse(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<TIPODEUSO> GetSpeciesLists()
        {
            return this.sifcaRepository.TIPODEUSO.ToList();
        }

        public TIPODEUSO GetSpeciesList(int SpeciesListId)
        {
            return this.sifcaRepository.TIPODEUSO.Find(SpeciesListId);
        }

        public void InsertSpeciesList(TIPODEUSO SpeciesList)
        {
            try
            {
                this.sifcaRepository.TIPODEUSO.Add(SpeciesList);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteSpeciesList(int SpeciesListId)
        {
            try
            {
                TIPODEUSO speciesList = this.sifcaRepository.TIPODEUSO.Find(SpeciesListId);
                this.sifcaRepository.TIPODEUSO.Remove(speciesList);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateSpeciesList(TIPODEUSO SpeciesList)
        {
            try
            {
                this.sifcaRepository.Entry(SpeciesList).State = EntityState.Modified;
                
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
