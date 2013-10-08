using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Data.Entity.Validation;

namespace SIFCA_BLL
{
    public class ProjectBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public ProjectBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }

        public IEnumerable<PROYECTO> GetProjects()
        {
            return this.sifcaRepository.PROYECTO.ToList();
        }

        public PROYECTO GetProject(Guid projectId)
        {
            return this.sifcaRepository.PROYECTO.Find(projectId);
        }

        public List<ESPECIE> GetProjectSpeciesList(Guid projectId)
        {
            PROYECTO prj=this.sifcaRepository.PROYECTO.SingleOrDefault(p=>p.NROPROY==projectId);
            if (prj != null) return prj.ESPECIE.ToList();
            return null;
        }

        public List<FORMULARIO> GetProjectFormsList(Guid projectId)
        {
            PROYECTO prj = this.sifcaRepository.PROYECTO.SingleOrDefault(p => p.NROPROY == projectId);
            if (prj != null) return prj.FORMULARIO.ToList();
            return null;
        }

        public List<LISTADODEESTRATOS> GetProjectStratumsList(Guid projectId)
        {
            PROYECTO prj = this.sifcaRepository.PROYECTO.SingleOrDefault(p => p.NROPROY == projectId);
            if (prj != null) return prj.LISTADODEESTRATOS.ToList();
            return null;
        }

        public void UpdateProject(PROYECTO project)
        {
            try
            {
                this.sifcaRepository.PROYECTO.Add(project);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProject(Guid projectId)
        {
            try
            {
                PROYECTO project = this.sifcaRepository.PROYECTO.Find(projectId);
                this.sifcaRepository.PROYECTO.Remove(project);
                
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


        public IEnumerable<PROYECTO> SearchProject(string search, string criteria)
        {
            if (criteria == "Responsable")
            {
                var query = from p in this.sifcaRepository.PROYECTO where ((p.USUARIO.NOMBRES+" "+p.USUARIO.APELLIDOS).Contains(search)) select p;
                return query.ToList();
            }
            if (criteria == "Lugar")
            {
                var query = from p in this.sifcaRepository.PROYECTO where (p.LUGAR.Contains(search)) select p;
                return query.ToList();
            }
            if (criteria == "dd/mm/aaaa")
            {
                DateTime parameter = DateTime.Parse(search);
                var query = from p in this.sifcaRepository.PROYECTO where (p.FECHA==parameter) select p;
                return query.ToList();
            }
            if (criteria == "Tipo Inventario")
            {
                var query = from p in this.sifcaRepository.PROYECTO where (p.OBJETIVOINVENTARIO.DESCRIPOBJETINV.Contains(search)) select p;
                return query.ToList();
            }
            if (criteria == "Tipo Diseño")
            {
                var query = from p in this.sifcaRepository.PROYECTO where (p.TIPODISENOMUESTRAL.DESCRIPTIPODISEMUEST.Contains(search)) select p;
                return query.ToList();
            }
            if (criteria == "Numero Etapas")
            {
                var query = from p in this.sifcaRepository.PROYECTO where ( SqlFunctions.StringConvert(p.NUMEROETAPAS).Contains(search)) select p;
                return query.ToList();
            }
            return new List<PROYECTO>();
        }
    }
}
