using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class TstudentBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public TstudentBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<TSTUDENT> GetTstudent()
        {
            return this.sifcaRepository.TSTUDENT.ToList();
        }

        public TSTUDENT GetTstudent(int TstudentId)
        {
            return this.sifcaRepository.TSTUDENT.Find(TstudentId);
        }

        public void InsertTstudent(TSTUDENT Tstudent)
        {
            try
            {
                this.sifcaRepository.TSTUDENT.Add(Tstudent);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTstudent(int TstudentId)
        {
            try
            {
                TSTUDENT Tstudent = this.sifcaRepository.TSTUDENT.Find(TstudentId);
                this.sifcaRepository.TSTUDENT.Remove(Tstudent);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTstudent(TSTUDENT Tstudent)
        {
            try
            {
                this.sifcaRepository.Entry(Tstudent).State = EntityState.Modified;

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
