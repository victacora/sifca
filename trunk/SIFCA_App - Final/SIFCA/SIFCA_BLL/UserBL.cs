using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.Entity.Validation;

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
        public USUARIO LoginUser(USUARIO user,string key)
        {
            USUARIO userData=this.sifcaRepository.USUARIO.SingleOrDefault(u=>u.NOMBREUSUARIO==user.NOMBREUSUARIO);
            if (userData != null)
            {
                if (AuthenticatorHelper.Decrypt(userData.CONTRASENA,key) == user.CONTRASENA) return userData;
            }
            return null;
            
        }

        public void InsertUser(USUARIO user,string key)
        {
            try
            {
                user.CONTRASENA = AuthenticatorHelper.Encrypt(user.CONTRASENA,key);
                this.sifcaRepository.USUARIO.Add(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteUser(Guid userId)
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

        public void UpdateUser(USUARIO user,string key)
        {
            try
            {
                user.CONTRASENA = AuthenticatorHelper.Encrypt(user.CONTRASENA,key);
                this.sifcaRepository.Entry(user).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string SaveChanges()
        {
            try
            {
                this.sifcaRepository.SaveChanges();
            }
            catch (UpdateException ex)
            {
                string error = "";
                error += string.Format("Error: {0}", ex.InnerException);
                return error;
            }
            catch (DbUpdateException ex)
            {
                string error = "";

                foreach (var ve in ex.Entries)
                {
                    error += string.Format("\nPropiedad: \"{0}\", Error: \"{1}\"", ve.Entity.GetType().Name, ex.InnerException);
                }

                return error;
            }
            catch (DbEntityValidationException ex)
            {
                string error = "";
                foreach (var eve in ex.EntityValidationErrors)
                {
                    error += string.Format("Entidad \"{0}\" \nEstado \"{1}\" \nErrores a validar:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        error += string.Format("\nPropiedad: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                    }
                }
                return error;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return string.Empty;
        }


    }
}
