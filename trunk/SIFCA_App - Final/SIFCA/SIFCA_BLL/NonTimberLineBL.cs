using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Data.Objects.SqlClient;

namespace SIFCA_BLL
{
    public class NonTimberLineBL 
    {
        private SIFCA_CONTEXT sifcaRepository;

        public NonTimberLineBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<LINEANOMADERABLES> GetNonTimberLineList()
        {
            return this.sifcaRepository.LINEANOMADERABLES.ToList();
        }

        public LINEANOMADERABLES GetNonTimberLine(Guid NonTimberLineId)
        {
            return this.sifcaRepository.LINEANOMADERABLES.Find(NonTimberLineId);
        }

        public void InsertNonTimberLine(LINEANOMADERABLES NonTimberLine)
        {
            try
            {
                this.sifcaRepository.LINEANOMADERABLES.Add(NonTimberLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteNonTimberLine(Guid NonTimberLineId)
        {
            try
            {
                LINEANOMADERABLES NonTimberLine = this.sifcaRepository.LINEANOMADERABLES.Find(NonTimberLineId);
                this.sifcaRepository.LINEANOMADERABLES.Remove(NonTimberLine);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateNonTimberLine(LINEANOMADERABLES NonTimberLine)
        {
            try
            {
                this.sifcaRepository.Entry(NonTimberLine).State = EntityState.Modified;
                
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
        //TODO: desarrollar la busqueda par los usos
        public IEnumerable<LINEANOMADERABLES> SearchLine(string search, string criteria, FORMULARIO form)
        {
      
            if (criteria == "Usos")
            {
                List<LINEANOMADERABLES> query = (from l in this.sifcaRepository.LINEANOMADERABLES where l.NROFORMULARIO ==form.NROFORMULARIO  select l).ToList();
                List<LINEANOMADERABLES> listNonTimberLine=new List<LINEANOMADERABLES>();
                foreach (LINEANOMADERABLES line in query)
                {
                    foreach (TIPODEUSO  ut in line.TIPODEUSO)
                    {
                        if (ut.DESCRIPCION.Contains(search))
                        {
                            listNonTimberLine.Add(line);
                            break;
                        }
                    }
                }
                return listNonTimberLine;
            }
            if (criteria == "Observaciones")
            {
                var query = from l in this.sifcaRepository.LINEANOMADERABLES where (l.OBSERVACIONES.Contains(search) && l.FORMULARIO.NROFORMULARIO == form.NROFORMULARIO) select l;
                return query.ToList();
            }
            return new List<LINEANOMADERABLES>();
        }
    }
}
