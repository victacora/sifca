﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class StateBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public StateBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<ESTADOSANITARIO> GetStates()
        {
            return this.sifcaRepository.ESTADOSANITARIO.ToList();
        }

        public ESTADOSANITARIO GetState(int stateId)
        {
            return this.sifcaRepository.ESTADOSANITARIO.Find(stateId);
        }

        public void InsertSpecie(ESTADOSANITARIO state)
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

        public void DeleteSpecies(int stateId)
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

        public void UpdateSpecies(ESTADOSANITARIO state)
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
