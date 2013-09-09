using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class UserBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public UserBL(SIFCA_CONTEXT contextProvider )
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<USUARIO> GetStations()
        {
            return this.sifcaRepository.USUARIO.ToList();
        }

        public USUARIO GetStation(int userId)
        {
            return this.sifcaRepository.USUARIO.Find(userId);
        }

        public void InsertStation(USUARIO user)
        {
            try
            {
                this.sifcaRepository.USUARIO.Add(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteEstation(int userId)
        {
            try
            {
                USUARIO station = this.sifcaRepository.USUARIO.Find(userId);
                this.sifcaRepository.USUARIO.Remove(station);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEstation(USUARIO user)
        {
            try
            {
                this.sifcaRepository.Entry(user).State = EntityState.Modified;
                
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
