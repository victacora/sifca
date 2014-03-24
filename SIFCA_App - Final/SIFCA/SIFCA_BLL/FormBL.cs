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
    public class FormBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public FormBL(SIFCA_CONTEXT contextProvider )
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<FORMULARIO> GetForms()
        {
            return this.sifcaRepository.FORMULARIO.ToList();
        }

        public FORMULARIO GetForm(Guid nrForm)
        {
            return this.sifcaRepository.FORMULARIO.Find(nrForm);
        }

        public void InsertForm(FORMULARIO form)
        {
            try
            {
                this.sifcaRepository.FORMULARIO.Add(form); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteForm(Guid nrProject)
        {
            try
            {
                FORMULARIO form = this.sifcaRepository.FORMULARIO.Find(nrProject);
                this.sifcaRepository.FORMULARIO.Remove(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateForm(FORMULARIO form)
        {
            try
            {
                this.sifcaRepository.Entry(form).State = EntityState.Modified;
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


        public List<FORMULARIO> SearchForm(string search, string criteria, PROYECTO p)
        {
            if (criteria == "Responsable")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where ((f.USUARIO.NOMBRES+" "+f.USUARIO.APELLIDOS).Contains(search)&&f.PROYECTO.NROPROY ==p.NROPROY) select f;
                return query.ToList();
            }
            if (criteria == "dd/mm/aaaa")
            {
                DateTime parameter = DateTime.Parse(search);
                var query = from f in this.sifcaRepository.FORMULARIO where (f.FECHACREACION.Year == parameter.Year && f.FECHACREACION.Month == parameter.Month && f.FECHACREACION.Day == parameter.Day && f.PROYECTO.NROPROY == p.NROPROY) select f;
                return query.ToList();
            }
            if (criteria == "Estrato")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where (f.ESTRATO.DESCRIPESTRATO.Contains(search) && f.PROYECTO.NROPROY == p.NROPROY) select f;
                return query.ToList();
            }
            if (criteria == "Parcela")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where (SqlFunctions.StringConvert(f.PARCELA).Contains(search) && f.PROYECTO.NROPROY == p.NROPROY) select f;
                return query.ToList();
            }
            if (criteria == "Coord.X;Coord.Y")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where ((SqlFunctions.StringConvert(f.COORDENADAX) + ";" + SqlFunctions.StringConvert(f.COORDENADAY)).Contains(search) && f.PROYECTO.NROPROY == p.NROPROY) select f;
                return query.ToList();
            }
            if (criteria == "Linea")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where (SqlFunctions.StringConvert(f.LINEA).Contains(search) && f.PROYECTO.NROPROY == p.NROPROY) select f;
                return query.ToList();
            }
            return new List<FORMULARIO>();
        }
    }
}
