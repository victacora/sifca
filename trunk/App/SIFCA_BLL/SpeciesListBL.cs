﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class SpeciesListBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public SpeciesListBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<LISTADODEESPECIES> GetSpeciesLists()
        {
            return this.sifcaRepository.LISTADODEESPECIES.ToList();
        }

        public LISTADODEESPECIES GetSpeciesList(int SpeciesListId)
        {
            return this.sifcaRepository.LISTADODEESPECIES.Find(SpeciesListId);
        }

        public void InsertSpeciesList(LISTADODEESPECIES SpeciesList)
        {
            try
            {
                this.sifcaRepository.LISTADODEESPECIES.Add(SpeciesList);
                
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
                LISTADODEESPECIES speciesList = this.sifcaRepository.LISTADODEESPECIES.Find(SpeciesListId);
                this.sifcaRepository.LISTADODEESPECIES.Remove(speciesList);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateSpeciesList(LISTADODEESPECIES SpeciesList)
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