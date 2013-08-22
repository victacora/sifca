using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class InventoryBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public InventoryBL()
        {
            this.sifcaRepository = new SIFCA_CONTEXT();
        }


        public IEnumerable<INVENTARIO> GetInventories()
        {
            return this.sifcaRepository.INVENTARIO.ToList();
        }

        public INVENTARIO GetInventory(int inventoryId)
        {
            return this.sifcaRepository.INVENTARIO.Find(inventoryId);
        }

        public void InsertInventory(INVENTARIO inventory)
        {
            try
            {
                this.sifcaRepository.INVENTARIO.Add(inventory);
                this.sifcaRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteInventory(int inventoryId)
        {
            try
            {
                INVENTARIO proyecto = this.sifcaRepository.INVENTARIO.Find(inventoryId);
                this.sifcaRepository.INVENTARIO.Remove(proyecto);
                this.sifcaRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateInventory(INVENTARIO inventory)
        {
            try
            {
                this.sifcaRepository.Entry(inventory).State = EntityState.Modified;
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
