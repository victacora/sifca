using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class ProjectTypeBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public ProjectTypeBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<TIPOPROYECTO> GetProjectTypes()
        {
            return this.sifcaRepository.TIPOPROYECTO.ToList();
        }

        public TIPOPROYECTO GetProjectType(int ProjectTypeId)
        {
            return this.sifcaRepository.TIPOPROYECTO.Find(ProjectTypeId);
        }

        public void InsertProjectType(TIPOPROYECTO ProjectType)
        {
            try
            {
                this.sifcaRepository.TIPOPROYECTO.Add(ProjectType);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProjectType(int ProjectTypeId)
        {
            try
            {
                TIPOPROYECTO ProjectType = this.sifcaRepository.TIPOPROYECTO.Find(ProjectTypeId);
                this.sifcaRepository.TIPOPROYECTO.Remove(ProjectType);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateProjectType(TIPOPROYECTO ProjectType)
        {
            try
            {
                this.sifcaRepository.Entry(ProjectType).State = EntityState.Modified;
                
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
