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

        public InventoryBL(SIFCA_CONTEXT contextProvider )
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<INVENTARIO> GetInventories()
        {
            return this.sifcaRepository.INVENTARIO.ToList();
        }

        public INVENTARIO GetInventory(int nrProject,Guid nroStation,int parcel, int nroTree)
        {
            return this.sifcaRepository.INVENTARIO.Find(nrProject,nroStation,parcel,nroTree);
        }

        public void InsertInventory(INVENTARIO inventory)
        {
            try
            {
                this.sifcaRepository.INVENTARIO.Add(inventory); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteInventory(int nrProject, Guid nroStation,int parcel,int nroTree )
        {
            try
            {
                INVENTARIO inventory = this.sifcaRepository.INVENTARIO.Find(nrProject,nroStation,parcel,nroTree);
                this.sifcaRepository.INVENTARIO.Remove(inventory);
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
