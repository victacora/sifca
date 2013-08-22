using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class StationBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public StationBL()
        {
            this.sifcaRepository = new SIFCA_CONTEXT();
        }


        public IEnumerable<ESTACION> GetStations()
        {
            return this.sifcaRepository.ESTACION.ToList();
        }

        public ESTACION GetStation(int estationId)
        {
            return this.sifcaRepository.ESTACION.Find(estationId);
        }

        public void InsertProject(ESTACION station)
        {
            try
            {
                this.sifcaRepository.ESTACION.Add(station);
                this.sifcaRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteEstation(int stationId)
        {
            try
            {
                ESTACION proyecto = this.sifcaRepository.ESTACION.Find(stationId);
                this.sifcaRepository.ESTACION.Remove(proyecto);
                this.sifcaRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEstation(ESTACION project)
        {
            try
            {
                this.sifcaRepository.Entry(project).State = EntityState.Modified;
                this.sifcaRepository.SaveChanges();
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
