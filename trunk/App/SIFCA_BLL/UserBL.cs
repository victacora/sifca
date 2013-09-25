using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Objects.SqlClient;

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

        public IEnumerable<USUARIO> SearchUsers(string search, string criteria) 
        {
            if (criteria == "Nombres")
            {
                var query= from u in this.sifcaRepository.USUARIO where(u.NOMBRES.Contains(search)) select u;
                return query.ToList();
            }
            if (criteria == "Apellidos")
            {
                var query = from u in this.sifcaRepository.USUARIO where (u.APELLIDOS.Contains(search)) select u;
                return query.ToList();
            }
            if (criteria == "Cedula")
            {
                var query = from u in this.sifcaRepository.USUARIO where ( SqlFunctions.StringConvert(u.CEDULA).Contains(search)) select u;
                return query.ToList();
            }
            if (criteria == "Usuario")
            {
                var query = from u in this.sifcaRepository.USUARIO where (u.NOMBREUSUARIO.Contains(search)) select u;
                return query.ToList();
            }
            return new List<USUARIO>();
        }
        public USUARIO LoginUser(USUARIO user)
        {
            USUARIO userData=this.sifcaRepository.USUARIO.SingleOrDefault(u=>u.NOMBREUSUARIO==user.NOMBREUSUARIO);
            if (userData != null)
            {
                if (AuthenticatorHelper.Decrypt(userData.CONTRASENA) == user.CONTRASENA) return userData;
            }
            return null;
            
        }

        public void InsertUser(USUARIO user)
        {
            try
            {
                user.CONTRASENA = AuthenticatorHelper.Encrypt(user.CONTRASENA);
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
                user.CONTRASENA = AuthenticatorHelper.Encrypt(user.CONTRASENA);
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
