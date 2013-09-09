using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class FromTypeBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public FromTypeBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<TIPOFORMULARIO> GetFormTypes()
        {
            return this.sifcaRepository.TIPOFORMULARIO.ToList();
        }

        public TIPOFORMULARIO GetFormType(int FormTypeId)
        {
            return this.sifcaRepository.TIPOFORMULARIO.Find(FormTypeId);
        }

        public void InsertFormType(TIPOFORMULARIO FormType)
        {
            try
            {
                this.sifcaRepository.TIPOFORMULARIO.Add(FormType);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteFormType(int FormTypeId)
        {
            try
            {
                TIPOFORMULARIO FormType = this.sifcaRepository.TIPOFORMULARIO.Find(FormTypeId);
                this.sifcaRepository.TIPOFORMULARIO.Remove(FormType);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateFormType(TIPOFORMULARIO FormType)
        {
            try
            {
                this.sifcaRepository.Entry(FormType).State = EntityState.Modified;
                
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
