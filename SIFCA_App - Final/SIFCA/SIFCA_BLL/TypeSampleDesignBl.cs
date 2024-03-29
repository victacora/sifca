﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace SIFCA_BLL
{
    public class TypeSampleDesignBl
    {
        private SIFCA_CONTEXT sifcaRepository;

        public TypeSampleDesignBl(SIFCA_CONTEXT contextProvider)
        {
            this.sifcaRepository = contextProvider;
        }


        public IEnumerable<TIPODISENOMUESTRAL> GetTypeSampleDesignList()
        {
            return this.sifcaRepository.TIPODISENOMUESTRAL.ToList();
        }

        public IEnumerable<TIPODISENOMUESTRAL> SearchType(string search, string criterio)
        {
            if (criterio == "Nombre")
            {
                var query = from e in this.sifcaRepository.TIPODISENOMUESTRAL where (e.NOMTIPODISEMUEST.Contains(search)) select e;
                return query.ToList();
            }
            if (criterio == "Descripcion")
            {
                var query = from e in this.sifcaRepository.TIPODISENOMUESTRAL where (e.DESCRIPTIPODISEMUEST.Contains(search)) select e;
                return query.ToList();
            }
            return new List<TIPODISENOMUESTRAL>();

        }

        public TIPODISENOMUESTRAL GetTypeSampleDesign(String TypeSampleDesignId)
        {
            return this.sifcaRepository.TIPODISENOMUESTRAL.Find(TypeSampleDesignId);
        }

        public void InsertTypeSampleDesign(TIPODISENOMUESTRAL TypeSampleDesign)
        {
            try
            {
                this.sifcaRepository.TIPODISENOMUESTRAL.Add(TypeSampleDesign);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTypeSampleDesign(String TypeSampleDesignId)
        {
            try
            {
                TIPODISENOMUESTRAL TypeSampleDesign = this.sifcaRepository.TIPODISENOMUESTRAL.Find(TypeSampleDesignId);
                this.sifcaRepository.TIPODISENOMUESTRAL.Remove(TypeSampleDesign);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTypeSampleDesign(TIPODISENOMUESTRAL TypeSampleDesign)
        {
            try
            {
                this.sifcaRepository.Entry(TypeSampleDesign).State = EntityState.Modified;

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

    }
}
