using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class InventoryLineBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public InventoryLineBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<LINEAINVENTARIO> GetInventoryLines()
        {
            return this.sifcaRepository.LINEAINVENTARIO.ToList();
        }

        public LINEAINVENTARIO GetInventoryLine(int InventoryLineId)
        {
            return this.sifcaRepository.LINEAINVENTARIO.Find(InventoryLineId);
        }

        public void InsertInventoryLine(LINEAINVENTARIO InventoryLine)
        {
            try
            {
                this.sifcaRepository.LINEAINVENTARIO.Add(InventoryLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteInventoryLine(Guid InventoryLineId)
        {
            try
            {
                LINEAINVENTARIO InventoryLine = this.sifcaRepository.LINEAINVENTARIO.Find(InventoryLineId);
                this.sifcaRepository.LINEAINVENTARIO.Remove(InventoryLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateInventoryLine(LINEAINVENTARIO InventoryLine)
        {
            try
            {
                this.sifcaRepository.Entry(InventoryLine).State = EntityState.Modified;
                
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
