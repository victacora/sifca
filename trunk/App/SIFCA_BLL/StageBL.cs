using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class StageBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public StageBL()
        {
            this.sifcaRepository = new SIFCA_CONTEXT();
        }


        public IEnumerable<ETAPA> GetStages()
        {
            return this.sifcaRepository.ETAPA.ToList();
        }

        public ETAPA GetStage(int stageId)
        {
            return this.sifcaRepository.ETAPA.Find(stageId);
        }

        public void InsertStage(ETAPA stage)
        {
            try
            {
                this.sifcaRepository.ETAPA.Add(stage);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStage(int stageId)
        {
            try
            {
                ETAPA stage = this.sifcaRepository.ETAPA.Find(stageId);
                this.sifcaRepository.ETAPA.Remove(stage);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStage(ETAPA stage)
        {
            try
            {
                this.sifcaRepository.Entry(stage).State = EntityState.Modified;
                
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
