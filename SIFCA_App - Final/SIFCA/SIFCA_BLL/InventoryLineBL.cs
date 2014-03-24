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
    public class InventoryLineBL
    {
        private SIFCA_CONTEXT sifcaRepository;

        public InventoryLineBL(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<LINEAINVENTARIO> GetInventoryLines()
        {
            return this.sifcaRepository.LINEAINVENTARIO.ToList();
        }

        public LINEAINVENTARIO GetInventoryLine(int InventoryLineId)
        {
            return this.sifcaRepository.LINEAINVENTARIO.Find(InventoryLineId);
        }

        public void InsertInventoryLine(LINEAINVENTARIO InventoryLine)
        {
            try
            {
                this.sifcaRepository.LINEAINVENTARIO.Add(InventoryLine);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteInventoryLine(Guid InventoryLineId)
        {
            try
            {
                LINEAINVENTARIO InventoryLine = this.sifcaRepository.LINEAINVENTARIO.Find(InventoryLineId);
                this.sifcaRepository.LINEAINVENTARIO.Remove(InventoryLine);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateInventoryLine(LINEAINVENTARIO InventoryLine)
        {
            try
            {
                this.sifcaRepository.Entry(InventoryLine).State = EntityState.Modified;

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

        public IEnumerable<LINEAINVENTARIO> SearchLine(string search, string criteria, FORMULARIO form)
        {
            try
            {
                if (criteria == "Especie N. Cientifico")
                {
                    var query = from l in this.sifcaRepository.LINEAINVENTARIO where (l.ESPECIE.NOMCIENTIFICO.Contains(search) && l.FORMULARIO.NROFORMULARIO == form.NROFORMULARIO) select l;
                    return query.ToList();
                }
                if (criteria == "Especie N. Comun")
                {
                    var query = from l in this.sifcaRepository.LINEAINVENTARIO where (l.ESPECIE.NOMCOMUN.Contains(search) && l.FORMULARIO.NROFORMULARIO == form.NROFORMULARIO) select l;
                    return query.ToList();
                }
                if (criteria == "Calidad")
                {
                    var query = from l in this.sifcaRepository.LINEAINVENTARIO where (l.CALIDAD.DESCRIPCALIDAD.Contains(search) && l.FORMULARIO.NROFORMULARIO == form.NROFORMULARIO) select l;
                    return query.ToList();
                }
                if (criteria == "Estado")
                {
                    var query = from l in this.sifcaRepository.LINEAINVENTARIO where (l.ESTADOSANITARIO.DESCRIPESTADO.Contains(search) && l.FORMULARIO.NROFORMULARIO == form.NROFORMULARIO) select l;
                    return query.ToList();
                }
                if (criteria == "Arbol")
                {
                    var query = from l in this.sifcaRepository.LINEAINVENTARIO where (SqlFunctions.StringConvert(l.NROARB).Contains(search) && l.FORMULARIO.NROFORMULARIO == form.NROFORMULARIO) select l;
                    return query.ToList();
                }
                return new List<LINEAINVENTARIO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public REPORTECLASESDIAMETRICAS searchDiametricClass(Guid codEsp, Guid codFr, string CD, int rangeInit, int rangeEnd, REPORTECLASESDIAMETRICAS rp)
        {
            try
            {
                if (codEsp != Guid.Empty)
                {
                    if (CD.Equals("General"))
                    {
                        var query = from l in this.sifcaRepository.LINEAINVENTARIO where (l.ESPECIE.CODESP == codEsp && l.NROFORMULARIO == codFr && (l.DAP * 100) >= rangeInit && (l.DAP * 100) < rangeEnd) select l;
                        foreach (LINEAINVENTARIO ln in query.ToList())
                        {
                            rp.VOLUMEN += ln.VOLCOM;
                            rp.AREABASAL += ln.AREABASAL;
                            rp.CONTEO++;
                        }
                        return rp;
                    }
                    else
                        if (CD.Equals("Valor comercial"))
                        {
                            var query = from l in this.sifcaRepository.LINEAINVENTARIO where (l.ESPECIE.CODESP == codEsp && l.NROFORMULARIO == codFr && (l.DAP * 100) >= rangeInit && (l.DAP * 100) < rangeEnd) select l;
                            foreach (LINEAINVENTARIO ln in query.ToList())
                            {
                                rp.VOLUMEN += ln.VOLCOM;
                                rp.AREABASAL += ln.AREABASAL;
                                rp.CONTEO++;
                            }
                            return rp;
                        }
                }
                else
                    if (CD.Equals("Estratos"))
                    {
                        var query = from l in this.sifcaRepository.LINEAINVENTARIO where (l.NROFORMULARIO == codFr && (l.DAP * 100) >= rangeInit && (l.DAP * 100) < rangeEnd) select l;
                        foreach (LINEAINVENTARIO ln in query.ToList())
                        {
                            rp.VOLUMEN += ln.VOLCOM;
                            rp.AREABASAL += ln.AREABASAL;
                            rp.CONTEO++;
                        }
                        return rp;
                    }                
                return rp;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
