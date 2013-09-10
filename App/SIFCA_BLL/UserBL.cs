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


        public IEnumerable<USUARIO> GetUsers()
        {
            return this.sifcaRepository.USUARIO.ToList();
        }

        public USUARIO GetUser(int userId)
        {
            return this.sifcaRepository.USUARIO.Find(userId);
        }

        public USUARIO LoginUser(USUARIO user)
        {
            return this.sifcaRepository.USUARIO.SingleOrDefault(u=>u.NOMBREUSUARIO==user.NOMBREUSUARIO&&u.CONTRASENA==user.CONTRASENA);
        }

        public void InsertUser(USUARIO user)
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

        public void DeleteEUser(int userId)
        {
            try
            {
                USUARIO User = this.sifcaRepository.USUARIO.Find(userId);
                this.sifcaRepository.USUARIO.Remove(User);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEUser(USUARIO user)
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
