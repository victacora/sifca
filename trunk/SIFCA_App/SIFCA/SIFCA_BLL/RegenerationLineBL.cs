using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;

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
