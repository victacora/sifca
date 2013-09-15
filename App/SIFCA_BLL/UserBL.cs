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

        public USUARIO GetUser(Guid userId)
        {
            return this.sifcaRepository.USUARIO.Find(userId);
        }

        public List<USUARIO> SearchUsers(string search, string criteria) 
        {
            if(criteria=="Nombres")return this.sifcaRepository.USUARIO.ToList().Where(u => u.NOMBRES.Contains(search)).ToList();
            if (criteria == "Apellidos") return this.sifcaRepository.USUARIO.ToList().Where(u => u.APELLIDOS.Contains(search)).ToList();
            if (criteria == "Cedula") return this.sifcaRepository.USUARIO.ToList().Where(u => u.CEDULA==int.Parse(search)).ToList();
            if (criteria == "Usuario") return this.sifcaRepository.USUARIO.ToList().Where(u => u.NOMBREUSUARIO.Contains(search)).ToList();
            return new List<USUARIO>();
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

        public void DeleteUser(int userId)
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

        public void UpdateUser(USUARIO user)
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
