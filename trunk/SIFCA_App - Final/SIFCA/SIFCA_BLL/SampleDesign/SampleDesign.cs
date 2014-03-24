using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.Distributions;
using SIFCA_DAL;
namespace SIFCA_BLL
{
    public class SampleDesign
    {
        private List<SampleDesignItem> data;
        private Dictionary<string,object> results;
        private double sizeSample;
        private double sizePopulation;
        private int sampleDesignType = -1;
        private PROYECTO project;
        private TSTUDENT tStudent;

        public SampleDesign(PROYECTO project,TSTUDENT tStudent, List<SampleDesignItem> data, double sizeSample, double sizePopulation,int sampleDesignType) 
        {
            this.project = project;
            this.data = data;
            this.sizePopulation = sizePopulation;
            this.sizeSample = sizeSample;
            this.sampleDesignType = sampleDesignType;
            this.tStudent = tStudent;
        }


        public Dictionary<string, object> Execute(int varType)
        {
            if (sampleDesignType == 0)
            {
                return sampleDesignOperations(DataProcesssing(varType,-1));
            }
            else
            {
                Dictionary<string, object> resultsStratums = new Dictionary<string, object>();
                Dictionary<string, object> temporalResults = new Dictionary<string, object>();
                //agrupar los formularios por estratos
                var groupStratums = data.GroupBy(d => d.formulario.CODEST);
                //calcular las variables por cada estrato como si se tratase de un muestreo simple e ir sumando 
                // a variables temporales para calcular el total por todos los estratos
                double standardDesviation = 0;
                double mean= 0;
                double standardDesviationSummation = 0;
                foreach (var stratum in groupStratums)
                {
                    //resultados por estrato
                    if (stratum.Key != null)
                    {
                        temporalResults = sampleDesignOperations(DataProcesssing(varType, (decimal)stratum.Key));
                        resultsStratums.Add(stratum.Key.ToString(), temporalResults);
                        LISTADODEESTRATOS stratumProject = project.LISTADODEESTRATOS.SingleOrDefault(est => est.CODEST == stratum.Key);
                        if (stratumProject != null)
                        {
                            temporalResults.Add("weight", (double)stratumProject.PESO);
                            mean += (double)temporalResults["Mean"] * (double)stratumProject.PESO;
                            standardDesviation += (double)temporalResults["StandardDeviation"] * (double)stratumProject.PESO;
                            standardDesviationSummation += Math.Pow((double)temporalResults["StandardDeviation"], 2) * (double)stratumProject.PESO;
                        }
                    }
                }
                //calculo resultados finales
                double standardError = 0;
                double temporalOperation = (Math.Pow(standardDesviation, 2) / sizeSample) - (standardDesviationSummation / sizePopulation);
                standardError=Math.Sqrt(temporalOperation);
                //TODO: calcular el error de muestreo, error relativo y el error asociado por cada uno delos estratos
                Dictionary<string, object> stratumTotal = new Dictionary<string, object>();
                //unificar los resultados: obtener los pesos del muestreo
                stratumTotal.Add("Mean",mean);
                stratumTotal.Add("StandardError", standardError);
                double t = (double)this.tStudent.VALOR;
                double absError = t * standardError;
                stratumTotal.Add("AbsoulteErrorSample", standardError);
                double relativeErrorSample = (absError / mean) * 100;
                stratumTotal.Add("RelativeErrorSample", relativeErrorSample);
                resultsStratums.Add("totales", stratumTotal);
                return resultsStratums;
                
            }
        }

        private List<Double> DataProcesssing(int varType,decimal codStratum) 
        {
            List<Double> dataDesign = new List<double>();
            if (sampleDesignType == 0)
            {
                foreach (SampleDesignItem item in data)
                {
                    if (varType == 0) dataDesign.Add(item.numeroArbolesHtas);
                    else if (varType == 1) dataDesign.Add(item.volumenComercialHtas);
                    else if (varType == 2) dataDesign.Add(item.volumenTotalHtas);
                    else dataDesign.Add(item.areaBasalHtas);
                }
            }
            else 
            {
                foreach (SampleDesignItem item in data)
                {
                    if (codStratum != null)
                    {
                        if (item.formulario.CODEST == codStratum)
                        {
                            if (varType == 0) dataDesign.Add(item.numeroArbolesHtas);
                            else if (varType == 1) dataDesign.Add(item.volumenComercialHtas);
                            else if (varType == 2) dataDesign.Add(item.volumenTotalHtas);
                            else dataDesign.Add(item.areaBasalHtas);
                        }
                    }
                }
            }
            return dataDesign;
        }

        private Dictionary<string, object> sampleDesignOperations(List<Double> dataDesign) 
        {
            DescriptiveStatistics statistics = new DescriptiveStatistics(dataDesign);
            results = new Dictionary<string, object>();
            results.Add("Mean", statistics.Mean);
            results.Add("StandardDeviation", statistics.StandardDeviation);
            results.Add("VariationCoefficient", (statistics.StandardDeviation / statistics.Mean) * 100);
            double standardError = statistics.StandardDeviation / Math.Sqrt(sizeSample - (1 - (sizeSample / sizePopulation)));
            results.Add("StandardError", standardError);
            //TODO:Calcular el area bajo la curva y determinar  cual es la distribucion adecuada 
            //para un valor t
            //añadir la confianza como variable al proyecto
            double t = (double)this.tStudent.VALOR;
            double absError = t * standardError;
            results.Add("AbsoulteErrorSample", absError);
            results.Add("LowLimit", statistics.Mean - absError);
            results.Add("HightLimit", statistics.Mean + absError);
            double relativeErrorSample = (absError / statistics.Mean) * 100;
            results.Add("RelativeErrorSample", relativeErrorSample);
            return results;
        }
    }
}
