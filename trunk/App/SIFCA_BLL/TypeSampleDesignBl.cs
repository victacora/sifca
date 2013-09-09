using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class TypeSampleDesignBl 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public TypeSampleDesignBl(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<TIPODISENOMUESTRAL> GetInventoryTypes()
        {
            return this.sifcaRepository.TIPODISENOMUESTRAL.ToList();
        }

        public TIPODISENOMUESTRAL GetInventoryType(int inventoryTypeId)
        {
            return this.sifcaRepository.TIPODISENOMUESTRAL.Find(inventoryTypeId);
        }

        public void InsertInventoryType(TIPODISENOMUESTRAL inventoryType)
        {
            try
            {
                this.sifcaRepository.TIPODISENOMUESTRAL.Add(inventoryType);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteInventoryType(int inventoryTypeId)
        {
            try
            {
                TIPODISENOMUESTRAL inventoryType = this.sifcaRepository.TIPODISENOMUESTRAL.Find(inventoryTypeId);
                this.sifcaRepository.TIPODISENOMUESTRAL.Remove(inventoryType);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateInventoryType(TIPODISENOMUESTRAL inventoryType)
        {
            try
            {
                this.sifcaRepository.Entry(inventoryType).State = EntityState.Modified;
                
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
