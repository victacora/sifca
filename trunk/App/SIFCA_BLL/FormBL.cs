using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class FormBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public FormBL(SIFCA_CONTEXT contextProvider )
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<FORMULARIO> GetForms()
        {
            return this.sifcaRepository.FORMULARIO.ToList();
        }

        public FORMULARIO GetForm(Guid nrProject)
        {
            return this.sifcaRepository.FORMULARIO.Find(nrProject);
        }

        public void InsertForm(FORMULARIO form)
        {
            try
            {
                this.sifcaRepository.FORMULARIO.Add(form); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteForm(Guid nrProject)
        {
            try
            {
                FORMULARIO form = this.sifcaRepository.FORMULARIO.Find(nrProject=);
                this.sifcaRepository.FORMULARIO.Remove(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateForm(FORMULARIO form)
        {
            try
            {
                this.sifcaRepository.Entry(form).State = EntityState.Modified;
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
