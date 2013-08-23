﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class InventoryTypeBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public InventoryTypeBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<TIPOINVENTARIO> GetInventoryTypes()
        {
            return this.sifcaRepository.TIPOINVENTARIO.ToList();
        }

        public TIPOINVENTARIO GetInventoryType(int inventoryTypeId)
        {
            return this.sifcaRepository.TIPOINVENTARIO.Find(inventoryTypeId);
        }

        public void InsertInventoryType(TIPOINVENTARIO inventoryType)
        {
            try
            {
                this.sifcaRepository.TIPOINVENTARIO.Add(inventoryType);
                
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
                TIPOINVENTARIO inventoryType = this.sifcaRepository.TIPOINVENTARIO.Find(inventoryTypeId);
                this.sifcaRepository.TIPOINVENTARIO.Remove(inventoryType);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateInventoryType(TIPOINVENTARIO inventoryType)
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
