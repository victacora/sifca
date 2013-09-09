using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class ObjectiveInventoryBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public ObjectiveInventoryBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<OBJETIVOINVENTARIO> GetObjectiveInventories()
        {
            return this.sifcaRepository.OBJETIVOINVENTARIO.ToList();
        }

        public OBJETIVOINVENTARIO GetObjectiveInventory(int ObjectiveInventoryId)
        {
            return this.sifcaRepository.OBJETIVOINVENTARIO.Find(ObjectiveInventoryId);
        }

        public void InsertObjectiveInventory(OBJETIVOINVENTARIO ObjectiveInventory)
        {
            try
            {
                this.sifcaRepository.OBJETIVOINVENTARIO.Add(ObjectiveInventory);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteObjectiveInventory(int ObjectiveInventoryId)
        {
            try
            {
                OBJETIVOINVENTARIO ObjectiveInventory = this.sifcaRepository.OBJETIVOINVENTARIO.Find(ObjectiveInventoryId);
                this.sifcaRepository.OBJETIVOINVENTARIO.Remove(ObjectiveInventory);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateObjectiveInventory(OBJETIVOINVENTARIO ObjectiveInventory)
        {
            try
            {
                this.sifcaRepository.Entry(ObjectiveInventory).State = EntityState.Modified;
                
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
