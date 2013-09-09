using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class NontimberLineBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public NontimberLineBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<LINEANOMADERABLES> GetNontimberLineList()
        {
            return this.sifcaRepository.LINEANOMADERABLES.ToList();
        }

        public LINEANOMADERABLES GetNontimberLine(int NontimberLineId)
        {
            return this.sifcaRepository.LINEANOMADERABLES.Find(NontimberLineId);
        }

        public void InsertNontimberLine(LINEANOMADERABLES NontimberLine)
        {
            try
            {
                this.sifcaRepository.LINEANOMADERABLES.Add(NontimberLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteNontimberLine(int NontimberLineId)
        {
            try
            {
                LINEANOMADERABLES NontimberLine = this.sifcaRepository.LINEANOMADERABLES.Find(NontimberLineId);
                this.sifcaRepository.LINEANOMADERABLES.Remove(NontimberLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateNontimberLine(LINEANOMADERABLES NontimberLine)
        {
            try
            {
                this.sifcaRepository.Entry(NontimberLine).State = EntityState.Modified;
                
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
