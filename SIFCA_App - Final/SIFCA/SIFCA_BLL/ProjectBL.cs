using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

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
            try
            {
                return this.sifcaRepository.PROYECTO.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public PROYECTO GetProject(Guid projectId)
        {
            try
            {
                return this.sifcaRepository.PROYECTO.Find(projectId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<ESPECIE> GetProjectSpeciesList(Guid projectId)
        {
            try
            {
                PROYECTO prj = this.sifcaRepository.PROYECTO.SingleOrDefault(p => p.NROPROY == projectId);
                if (prj != null) return prj.ESPECIE.ToList();
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<FORMULARIO> GetProjectFormsList(Guid projectId)
        {
            try
            {
                PROYECTO prj = this.sifcaRepository.PROYECTO.SingleOrDefault(p => p.NROPROY == projectId);
                if (prj != null) return prj.FORMULARIO.ToList();
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<LISTADODEESTRATOS> GetProjectStratumsList(Guid projectId)
        {
            try
            {
                PROYECTO prj = this.sifcaRepository.PROYECTO.SingleOrDefault(p => p.NROPROY == projectId);
                if (prj != null) return prj.LISTADODEESTRATOS.ToList();
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ESTRATO> GetProjectStratums(Guid projectId)
        {
            try
            {
                PROYECTO prj = this.sifcaRepository.PROYECTO.SingleOrDefault(p => p.NROPROY == projectId);
                if (prj != null)
                {
                    var result = from ep in prj.LISTADODEESTRATOS select ep.ESTRATO;
                    return result.ToList<ESTRATO>();
                }
                return null;
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
                foreach(LISTADODEESTRATOS stratums in project.LISTADODEESTRATOS)
                {
                    if (this.sifcaRepository.Entry(stratums).State==EntityState.Modified) this.sifcaRepository.Entry(stratums).State = EntityState.Modified;
                    else if (this.sifcaRepository.Entry(stratums).State == EntityState.Added) this.sifcaRepository.Entry(stratums).State = EntityState.Added;
                    else if (this.sifcaRepository.Entry(stratums).State==EntityState.Deleted) this.sifcaRepository.Entry(stratums).State = EntityState.Deleted;
                }
                foreach (ESPECIE  species in project.ESPECIE)
                {
                    if (this.sifcaRepository.Entry(species).State == EntityState.Modified) this.sifcaRepository.Entry(species).State = EntityState.Modified;
                    else if (this.sifcaRepository.Entry(species).State == EntityState.Added) this.sifcaRepository.Entry(species).State = EntityState.Added;
                    else if (this.sifcaRepository.Entry(species).State == EntityState.Deleted) this.sifcaRepository.Entry(species).State = EntityState.Deleted;
                }
                foreach (PROYECTOSPORETAPA projects in project.PROYECTOSPORETAPA)
                {
                    if (this.sifcaRepository.Entry(projects).State == EntityState.Modified) this.sifcaRepository.Entry(projects).State = EntityState.Modified;
                    else if (this.sifcaRepository.Entry(projects).State == EntityState.Added) this.sifcaRepository.Entry(projects).State = EntityState.Added;
                    else if (this.sifcaRepository.Entry(projects).State == EntityState.Deleted) this.sifcaRepository.Entry(projects).State = EntityState.Deleted;
                }       
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertProject(PROYECTO project)
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


        public IEnumerable<PROYECTO> SearchProject(string search, string criteria)
        {
            try
            {
                if (criteria == "Responsable")
                {
                    var query = from p in this.sifcaRepository.PROYECTO where ((p.USUARIO.NOMBRES + " " + p.USUARIO.APELLIDOS).Contains(search)) select p;
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
                    var query = from p in this.sifcaRepository.PROYECTO where (p.FECHA == parameter) select p;
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
                    var query = from p in this.sifcaRepository.PROYECTO where (SqlFunctions.StringConvert(p.ETAPA).Contains(search)) select p;
                    return query.ToList();
                }
                return new List<PROYECTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public PROYECTO GetProjectByPlace(string place)
        {
            try
            {
                PROYECTO prj = this.sifcaRepository.PROYECTO.SingleOrDefault(p => p.LUGAR == place);
                return prj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public IEnumerable<PROYECTO> GetProjectsFree(PROYECTO Pj)
        {
            try
            {
                if (Pj != null) {
                    if(Pj.PROYECTOSPORETAPA1.Count>0) {
                        PROYECTOSPORETAPA[] pjs = Pj.PROYECTOSPORETAPA1.ToArray();
                        Guid cod = pjs[0].NROPROYCONTENEDOR;
                        var query = from p in this.sifcaRepository.PROYECTO where (p.PROYECTOSPORETAPA1.Count == 0 && p.NROPROY != Pj.NROPROY && p.NROPROY !=  cod) select p;
                        return query.ToList();
                    }
                    var query1 = from p in this.sifcaRepository.PROYECTO where (p.PROYECTOSPORETAPA1.Count == 0 && p.NROPROY != Pj.NROPROY) select p;
                    return query1.ToList();
                }
                else
                {
                    var query = from p in this.sifcaRepository.PROYECTO where (p.PROYECTOSPORETAPA1.Count == 0) select p;
                    return query.ToList();
                }
                return null;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //Obtener un los hijos de un proyecto con un guid del proyecto y ademas los proyectos que esten libres que no tengan padre
        public object GetProjects(PROYECTO pj)
        {
            try
            {
                List<PROYECTO> listPy = new List<PROYECTO>();
                PROYECTOSPORETAPA PBS = new PROYECTOSPORETAPA();
                PBS.NROPROYCONTENEDOR = pj.NROPROY;
                listPy = this.GetProjectsFree(pj).ToList(); // obtenemos los proyectos que no tienen un padre y que no sea el proyecto que se va actualizar
                var query = from p in this.sifcaRepository.PROYECTOSPORETAPA where (p.NROPROYCONTENEDOR == pj.NROPROY) select p; //obtenemos los hijos (proyectos por etapa) de este proyecto
                foreach (PROYECTOSPORETAPA pyBstate in query.ToList())
                {
                    listPy.Add(this.GetProject(pyBstate.NROPROYCONTENIDO));
                }
                return listPy;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
    }


}
