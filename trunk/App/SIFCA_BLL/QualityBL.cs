using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class QualityBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public QualityBL()
        {
            this.sifcaRepository = new SIFCA_CONTEXT();
        }


        public IEnumerable<CALIDAD> GetQualities()
        {
            return this.sifcaRepository.CALIDAD.ToList();
        }

        public CALIDAD GetQuality(int QualityId)
        {
            return this.sifcaRepository.CALIDAD.Find(QualityId);
        }

        public void InsertQuality(CALIDAD quality)
        {
            try
            {
                this.sifcaRepository.CALIDAD.Add(quality);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteQuality(int qualityId)
        {
            try
            {
                CALIDAD quality = this.sifcaRepository.CALIDAD.Find(qualityId);
                this.sifcaRepository.CALIDAD.Remove(quality);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateQuality(CALIDAD quality)
        {
            try
            {
                this.sifcaRepository.Entry(quality).State = EntityState.Modified;
                
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
