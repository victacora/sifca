﻿using System;
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

        public StationBL(SIFCA_CONTEXT contextProvider )
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<ESTACION> GetStations()
        {
            return this.sifcaRepository.ESTACION.ToList();
        }

        public ESTACION GetStation(int estationId)
        {
            return this.sifcaRepository.ESTACION.Find(estationId);
        }

        public void InsertStation(ESTACION station)
        {
            try
            {
                this.sifcaRepository.ESTACION.Add(station);
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
                ESTACION station = this.sifcaRepository.ESTACION.Find(stationId);
                this.sifcaRepository.ESTACION.Remove(station);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEstation(ESTACION station)
        {
            try
            {
                this.sifcaRepository.Entry(station).State = EntityState.Modified;
                
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