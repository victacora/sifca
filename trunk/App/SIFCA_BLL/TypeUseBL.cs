using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class TypeUseBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public TypeUseBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<TIPODEUSO> GetTypeUse()
        {
            return this.sifcaRepository.TIPODEUSO.ToList();
        }

        public TIPODEUSO GetTypeUse(int TypeUseId)
        {
            return this.sifcaRepository.TIPODEUSO.Find(TypeUseId);
        }

        public void InsertTypeUse(TIPODEUSO TypeUse)
        {
            try
            {
                this.sifcaRepository.TIPODEUSO.Add(TypeUse);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTypeUse(int TypeUseId)
        {
            try
            {
                TIPODEUSO TypeUse = this.sifcaRepository.TIPODEUSO.Find(TypeUseId);
                this.sifcaRepository.TIPODEUSO.Remove(TypeUse);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTypeUse(TIPODEUSO TypeUse)
        {
            try
            {
                this.sifcaRepository.Entry(TypeUse).State = EntityState.Modified;
                
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
