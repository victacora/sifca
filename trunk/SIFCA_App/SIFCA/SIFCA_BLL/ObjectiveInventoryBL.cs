using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;

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

        public string SaveChanges()
        {
            try
            {
                this.sifcaRepository.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                string error = "";
                foreach (var eve in ex.EntityValidationErrors)
                {
                    error += string.Format("Entidad \"{0}\" \nEstado \"{1}\" \nErrores a validar:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        error += string.Format("\nPropiedad: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                    }
                }
                return error;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return string.Empty;
        }

    }
}
