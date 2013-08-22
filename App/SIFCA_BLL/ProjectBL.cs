using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

namespace SIFCA_BLL
{
    public class ProjectBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public ProjectBL()
        {
            this.sifcaRepository = new SIFCA_CONTEXT();
        }


        public IEnumerable<PROYECTO> GetProjects()
        {
            return this.sifcaRepository.PROYECTO.ToList();
        }

        public PROYECTO GetProject(int projectId)
        {
            return this.sifcaRepository.PROYECTO.Find(projectId);
        }

        public PROYECTO GetActivateProject()
        {
            return this.sifcaRepository.PROYECTO.SingleOrDefault(p=>p.ESTADOPROY=="A");
        }

        public void InsertProject(PROYECTO project)
        {
            try
            {
                this.sifcaRepository.PROYECTO.Add(project);
                this.sifcaRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProject(int projectId)
        {
            try
            {
                PROYECTO proyecto = this.sifcaRepository.PROYECTO.Find(projectId);
                this.sifcaRepository.PROYECTO.Remove(proyecto);
                this.sifcaRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateProject(PROYECTO project)
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

        public void ExportProjectToXml()
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


        public void ImportProjectFromXml()
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
