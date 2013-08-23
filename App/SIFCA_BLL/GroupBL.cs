using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class GroupBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public GroupBL()
        {
            this.sifcaRepository = new SIFCA_CONTEXT();
        }


        public IEnumerable<GRUPOCOMERCIAL> GetGroups()
        {
            return this.sifcaRepository.GRUPOCOMERCIAL.ToList();
        }

        public GRUPOCOMERCIAL GetGroup(int groupId)
        {
            return this.sifcaRepository.GRUPOCOMERCIAL.Find(groupId);
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

        public void DeleteGroup(int groupId)
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
