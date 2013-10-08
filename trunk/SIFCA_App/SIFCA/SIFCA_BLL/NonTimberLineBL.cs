using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class NonTimberLineBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public NonTimberLineBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<LINEANOMADERABLES> GetNonTimberLineList()
        {
            return this.sifcaRepository.LINEANOMADERABLES.ToList();
        }

        public LINEANOMADERABLES GetNonTimberLine(Guid NonTimberLineId)
        {
            return this.sifcaRepository.LINEANOMADERABLES.Find(NonTimberLineId);
        }

        public void InsertNonTimberLine(LINEANOMADERABLES NonTimberLine)
        {
            try
            {
                this.sifcaRepository.LINEANOMADERABLES.Add(NonTimberLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteNonTimberLine(Guid NonTimberLineId)
        {
            try
            {
                LINEANOMADERABLES NonTimberLine = this.sifcaRepository.LINEANOMADERABLES.Find(NonTimberLineId);
                this.sifcaRepository.LINEANOMADERABLES.Remove(NonTimberLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateNonTimberLine(LINEANOMADERABLES NonTimberLine)
        {
            try
            {
                this.sifcaRepository.Entry(NonTimberLine).State = EntityState.Modified;
                
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
