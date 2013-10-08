using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;

namespace SIFCA_BLL
{
    public class GroupBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public GroupBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<GRUPOCOMERCIAL> GetGroups()
        {
            return this.sifcaRepository.GRUPOCOMERCIAL.ToList();
        }

        public GRUPOCOMERCIAL GetGroup(String groupId)
        {
            return this.sifcaRepository.GRUPOCOMERCIAL.Find(groupId);
        }

        public IEnumerable<GRUPOCOMERCIAL> SearchGroup(string search)
        {
            var query = from e in this.sifcaRepository.GRUPOCOMERCIAL where (e.DESCRIPGRUPO.Contains(search)) select e;
            return query.ToList();
        }

        public void InsertGroup(GRUPOCOMERCIAL group)
        {
            try
            {
                this.sifcaRepository.GRUPOCOMERCIAL.Add(group);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteGroup(String groupId)
        {
            try
            {
                GRUPOCOMERCIAL group = this.sifcaRepository.GRUPOCOMERCIAL.Find(groupId);
                this.sifcaRepository.GRUPOCOMERCIAL.Remove(group);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateGroup(GRUPOCOMERCIAL group)
        {
            try
            {
                this.sifcaRepository.Entry(group).State = EntityState.Modified;

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
                throw ex;
            }
            return string.Empty;
        }

    }
}
