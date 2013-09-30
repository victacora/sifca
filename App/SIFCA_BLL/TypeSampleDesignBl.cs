using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIFCA_DAL;
using System.Data;

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

        public void DeleteTypeSampleDesign(int TypeSampleDesignId)
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
