using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class StratumBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public StratumBL()
        {
            this.sifcaRepository = new SIFCA_CONTEXT();
        }


        public IEnumerable<ESTRATO> GetStratums()
        {
            return this.sifcaRepository.ESTRATO.ToList();
        }

        public ESTRATO GetStratum(int stratumId)
        {
            return this.sifcaRepository.ESTRATO.Find(stratumId);
        }

        public void InsertStratum(ESTRATO stratum)
        {
            try
            {
                this.sifcaRepository.ESTRATO.Add(stratum);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStratum(int stratumId)
        {
            try
            {
                ESTRATO proyecto = this.sifcaRepository.ESTRATO.Find(stratumId);
                this.sifcaRepository.ESTRATO.Remove(proyecto);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStratum(ESTRATO stratum)
        {
            try
            {
                this.sifcaRepository.Entry(stratum).State = EntityState.Modified;
                
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
