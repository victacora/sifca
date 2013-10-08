using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Objects.SqlClient;

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


        public List<FORMULARIO> SearchForm(string search, string criteria)
        {
            if (criteria == "Responsable")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where ((f.USUARIO.NOMBRES+" "+f.USUARIO.APELLIDOS).Contains(search)) select f;
                return query.ToList();
            }
            if (criteria == "dd/mm/aaaa")
            {
                DateTime parameter = DateTime.Parse(search);
                var query = from f in this.sifcaRepository.FORMULARIO where (f.FECHACREACION==parameter) select f;
                return query.ToList();
            }
            if (criteria == "Estrato")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where (f.ESTRATO.DESCRIPESTRATO.Contains(search)) select f;
                return query.ToList();
            }
            if (criteria == "Parcela")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where (SqlFunctions.StringConvert(f.PARCELA).Contains(search)) select f;
                return query.ToList();
            }
            if (criteria == "Coord.X;Coord.Y")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where ((SqlFunctions.StringConvert(f.COORDENADAX)+";"+SqlFunctions.StringConvert(f.COORDENADAY)).Contains(search)) select f;
                return query.ToList();
            }
            if (criteria == "Linea")
            {
                var query = from f in this.sifcaRepository.FORMULARIO where ( SqlFunctions.StringConvert(f.LINEA).Contains(search)) select f;
                return query.ToList();
            }
            return new List<FORMULARIO>();
        }
    }
}
