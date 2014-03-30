using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_DAL;
using SIFCA_BLL;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace SIFCA
{
    public partial class Ver_Reporte_Form : Form
    {
        private TStudentBL tStudentTable;
        private StratumBL stratums;
        private PROYECTO project;
        private bool estratificado;
        private bool reportCD = false;

        public Ver_Reporte_Form(List<SampleDesignItem> datos, List<string> opciones)
        {
            InitializeComponent();
            try
            {
                tStudentTable = new TStudentBL(Program.ContextData);
                stratums = new StratumBL(Program.ContextData);
                project = new PROYECTO();
                PROYECTO currentProject = (PROYECTO)Program.Cache.Get("project");
                //Cargando datos del proyecto al reporte
                if (project != null)
                {
                    TypeSampleDesignBl tipoDiseno = new TypeSampleDesignBl(Program.ContextData);
                    ObjectiveInventoryBL objetivoInventario = new ObjectiveInventoryBL(Program.ContextData);
                    project.NOMTIPODISEMUEST = tipoDiseno.GetTypeSampleDesign(currentProject.NOMTIPODISEMUEST).DESCRIPTIPODISEMUEST;
                    project.NOMBRETIPOINV = objetivoInventario.GetObjectiveInventory(currentProject.NOMBRETIPOINV).DESCRIPOBJETINV;
                    project.INTMUE = Math.Round(currentProject.INTMUE, 3);
                    project.TAMANO = Math.Round(currentProject.TAMANO, 3);
                    project.DESCRIPCION = currentProject.DESCRIPCION;
                    project.LUGAR = currentProject.LUGAR;
                    project.FECHA = currentProject.FECHA;
                    project.SUPMUE = Math.Round(currentProject.SUPMUE, 3);
                    project.SUPTOT = Math.Round(currentProject.SUPTOT, 3);
                    Decimal confianza = currentProject.CONFIANZA != null ? (decimal)currentProject.CONFIANZA : 0;
                    project.CONFIANZA = Math.Round(confianza, 3);
                    this.estratificado = currentProject.LISTADODEESTRATOS.Count != 0 ? true : false;
                    proyectoBS.DataSource = project;
                }
                Dictionary<string, object> resultados = new Dictionary<string, object>();
                if (datos.Count != 0)
                {
                    double tamanoParcela = project != null ? (double)project.TAMANO : 1;
                    double totalParcelas = project != null ? (int)(project.SUPTOT / project.TAMANO) : 0;
                    int totalParcelasMuestra = datos.Count;
                    double superficieTotal =  project != null ?(double)project.SUPTOT:0;
                    RESULTADOMUESTREO resultado;
                    TOTALESMUESTREOESTRATIFICADOS totales;
                    TSTUDENT resulttStudent = tStudentTable.GetTStudent((decimal)(1 - currentProject.CONFIANZA / 100), (totalParcelasMuestra - 1));
                    TSTUDENT tStudent = resulttStudent != null ? resulttStudent : new TSTUDENT();
                    if (!estratificado)
                    {
                        //
                        SampleDesign diseno = new SampleDesign(currentProject, tStudent, datos, totalParcelasMuestra, totalParcelas, 0);
                        resultados = diseno.Execute(0);
                        //Cargando resultado de los datos al reporte
                        if (opciones.Contains("NA"))
                        {
                            resultado = new RESULTADOMUESTREO();
                            resultado.VARIABLE = "Numero de arboles (#)";
                            resultado.TOTAL = superficieTotal * Math.Round((double)resultados["Mean"], 3);
                            resultado.PROMEDIO = Math.Round((double)resultados["Mean"], 3);
                            resultado.DESVIACIONESTANDAR = Math.Round((double)resultados["StandardDeviation"], 3);
                            resultado.COEFICIENTEDEVARIACION = Math.Round((double)resultados["VariationCoefficient"], 3);
                            resultado.ERRORDESVIACION = Math.Round((double)resultados["StandardError"], 3);
                            resultado.ERRORABSOLUTOMUESTREO = Math.Round((double)resultados["AbsoulteErrorSample"], 3);
                            resultado.LIMITEINF = Math.Round((double)resultados["LowLimit"], 3);
                            resultado.LIMITESUP = Math.Round((double)resultados["HightLimit"], 3);
                            resultado.ERRORRELATIVO = Math.Round((double)resultados["RelativeErrorSample"], 3);
                            resultadosBS.Add(resultado);
                        }
                        if (opciones.Contains("AB"))
                        {
                            resultados = diseno.Execute(3);
                            resultado = new RESULTADOMUESTREO();
                            resultado.VARIABLE = "Area Basal (Mtrs2)";
                            resultado.TOTAL = superficieTotal * Math.Round((double)resultados["Mean"], 3);
                            resultado.PROMEDIO = Math.Round((double)resultados["Mean"], 3);
                            resultado.DESVIACIONESTANDAR = Math.Round((double)resultados["StandardDeviation"], 3);
                            resultado.COEFICIENTEDEVARIACION = Math.Round((double)resultados["VariationCoefficient"], 3);
                            resultado.ERRORDESVIACION = Math.Round((double)resultados["StandardError"], 3);
                            resultado.ERRORABSOLUTOMUESTREO = Math.Round((double)resultados["AbsoulteErrorSample"], 3);
                            resultado.LIMITEINF = Math.Round((double)resultados["LowLimit"], 3);
                            resultado.LIMITESUP = Math.Round((double)resultados["HightLimit"], 3);
                            resultado.ERRORRELATIVO = Math.Round((double)resultados["RelativeErrorSample"], 3);
                            resultadosBS.Add(resultado);
                        }
                        if (opciones.Contains("VC"))
                        {
                            resultados = diseno.Execute(1);
                            resultado = new RESULTADOMUESTREO();
                            resultado.VARIABLE = "Volumen Comercial (Mtrs3)";
                            resultado.TOTAL = superficieTotal * Math.Round((double)resultados["Mean"], 3);
                            resultado.PROMEDIO = Math.Round((double)resultados["Mean"], 3);
                            resultado.DESVIACIONESTANDAR = Math.Round((double)resultados["StandardDeviation"], 3);
                            resultado.COEFICIENTEDEVARIACION = Math.Round((double)resultados["VariationCoefficient"], 3);
                            resultado.ERRORDESVIACION = Math.Round((double)resultados["StandardError"], 3);
                            resultado.ERRORABSOLUTOMUESTREO = Math.Round((double)resultados["AbsoulteErrorSample"], 3);
                            resultado.LIMITEINF = Math.Round((double)resultados["LowLimit"], 3);
                            resultado.LIMITESUP = Math.Round((double)resultados["HightLimit"], 3);
                            resultado.ERRORRELATIVO = Math.Round((double)resultados["RelativeErrorSample"], 3);
                            resultadosBS.Add(resultado);
                        }
                        if (opciones.Contains("VT"))
                        {
                            resultados = diseno.Execute(2);
                            resultado = new RESULTADOMUESTREO();
                            resultado.VARIABLE = "Volumen Total (Mtrs3)";
                            resultado.TOTAL = superficieTotal * Math.Round((double)resultados["Mean"], 3);
                            resultado.PROMEDIO = Math.Round((double)resultados["Mean"], 3);
                            resultado.DESVIACIONESTANDAR = Math.Round((double)resultados["StandardDeviation"], 3);
                            resultado.COEFICIENTEDEVARIACION = Math.Round((double)resultados["VariationCoefficient"], 3);
                            resultado.ERRORDESVIACION = Math.Round((double)resultados["StandardError"], 3);
                            resultado.ERRORABSOLUTOMUESTREO = Math.Round((double)resultados["AbsoulteErrorSample"], 3);
                            resultado.LIMITEINF = Math.Round((double)resultados["LowLimit"], 3);
                            resultado.LIMITESUP = Math.Round((double)resultados["HightLimit"], 3);
                            resultado.ERRORRELATIVO = Math.Round((double)resultados["RelativeErrorSample"], 3);
                            resultadosBS.Add(resultado);
                        }
                    }
                    else
                    {
                        //Cargar datos del analisis de los datos estratificados al proyecto
                        SampleDesign diseno = new SampleDesign(currentProject, tStudent, datos, totalParcelasMuestra, totalParcelas, 1);
                        //Cargando resultado de los datos al reporte
                        Dictionary<string, object> resultadosTemporales = null;
                        if (opciones.Contains("NA"))
                        {
                            resultados = diseno.Execute(0);
                            foreach (KeyValuePair<string, object> resultStratum in resultados)
                            {
                                resultadosTemporales = (Dictionary<string, object>)resultStratum.Value;
                                resultado = new RESULTADOMUESTREO();
                                if (resultStratum.Key != "totales")
                                {
                                    ESTRATO stratum = stratums.GetStratum(int.Parse(resultStratum.Key));
                                    resultado.ESTRATO = stratum != null ? stratum.DESCRIPESTRATO : resultStratum.Key;
                                    resultado.PESOESTRATO = Math.Round((double)resultadosTemporales["weight"], 3);
                                    resultado.VARIABLE = "Numero de arboles (#)";
                                    resultado.TOTAL = totalParcelas * Math.Round((double)resultadosTemporales["Mean"], 3);
                                    resultado.TOTALPORHECTAREA = resultado.TOTAL / (double)currentProject.SUPTOT;
                                    resultado.PROMEDIO = Math.Round((double)resultadosTemporales["Mean"], 3);
                                    resultado.DESVIACIONESTANDAR = Math.Round((double)resultadosTemporales["StandardDeviation"], 3);
                                    resultado.COEFICIENTEDEVARIACION = Math.Round((double)resultadosTemporales["VariationCoefficient"], 3);
                                    resultado.ERRORDESVIACION = Math.Round((double)resultadosTemporales["StandardError"], 3);
                                    resultado.ERRORABSOLUTOMUESTREO = Math.Round((double)resultadosTemporales["AbsoulteErrorSample"], 3);
                                    resultado.LIMITEINF = Math.Round((double)resultadosTemporales["LowLimit"], 3);
                                    resultado.LIMITESUP = Math.Round((double)resultadosTemporales["HightLimit"], 3);
                                    resultado.ERRORRELATIVO = Math.Round((double)resultadosTemporales["RelativeErrorSample"], 3);
                                    resultadosBS.Add(resultado);
                                }
                            }
                            //TODO:añadir total los cuales se encuntran al final
                            resultadosTemporales = (Dictionary<string, object>)resultados.Last().Value;
                            totales = new TOTALESMUESTREOESTRATIFICADOS();
                            totales.VARIABLE = "Numero de arboles (#)";
                            totales.TOTALPROMEDIOESTRATIFICADO = Math.Round((double)resultadosTemporales["Mean"], 3);
                            totales.TOTALDESESTANDARESTRATIFICADO = Math.Round((double)resultadosTemporales["StandardError"], 3);
                            totales.TOTALERRORMUESTREO = Math.Round((double)resultadosTemporales["AbsoulteErrorSample"], 3);
                            totales.TOTALERRRORELATIVO = Math.Round((double)resultadosTemporales["RelativeErrorSample"], 3);
                            totalEstratificadoBS.Add(totales);
                        }
                        if (opciones.Contains("AB"))
                        {
                            resultados = diseno.Execute(3);
                            //Cargando resultado de los datos al reporte
                            foreach (KeyValuePair<string, object> resultStratum in resultados)
                            {
                                resultadosTemporales = (Dictionary<string, object>)resultStratum.Value;
                                resultado = new RESULTADOMUESTREO();
                                if (resultStratum.Key != "totales")
                                {
                                    ESTRATO stratum = stratums.GetStratum(int.Parse(resultStratum.Key));
                                    resultado.ESTRATO = stratum != null ? stratum.DESCRIPESTRATO : resultStratum.Key;
                                    resultado.PESOESTRATO = Math.Round((double)resultadosTemporales["weight"], 3);
                                    resultado.VARIABLE = "Area Basal (Mtrs2)";
                                    resultado.TOTAL = totalParcelas * Math.Round((double)resultadosTemporales["Mean"], 3);
                                    resultado.TOTALPORHECTAREA = resultado.TOTAL / (double)currentProject.SUPTOT;
                                    resultado.PROMEDIO = Math.Round((double)resultadosTemporales["Mean"], 3);
                                    resultado.DESVIACIONESTANDAR = Math.Round((double)resultadosTemporales["StandardDeviation"], 3);
                                    resultado.COEFICIENTEDEVARIACION = Math.Round((double)resultadosTemporales["VariationCoefficient"], 3);
                                    resultado.ERRORDESVIACION = Math.Round((double)resultadosTemporales["StandardError"], 3);
                                    resultado.ERRORABSOLUTOMUESTREO = Math.Round((double)resultadosTemporales["AbsoulteErrorSample"], 3);
                                    resultado.LIMITEINF = Math.Round((double)resultadosTemporales["LowLimit"], 3);
                                    resultado.LIMITESUP = Math.Round((double)resultadosTemporales["HightLimit"], 3);
                                    resultado.ERRORRELATIVO = Math.Round((double)resultadosTemporales["RelativeErrorSample"], 3);
                                    resultadosBS.Add(resultado);
                                }
                            }
                            resultadosTemporales = (Dictionary<string, object>)resultados.Last().Value;
                            totales = new TOTALESMUESTREOESTRATIFICADOS();
                            totales.VARIABLE = "Area Basal (Mtrs2)";
                            totales.TOTALPROMEDIOESTRATIFICADO = Math.Round((double)resultadosTemporales["Mean"], 3);
                            totales.TOTALDESESTANDARESTRATIFICADO = Math.Round((double)resultadosTemporales["StandardError"], 3);
                            totales.TOTALERRORMUESTREO = Math.Round((double)resultadosTemporales["AbsoulteErrorSample"], 3);
                            totales.TOTALERRRORELATIVO = Math.Round((double)resultadosTemporales["RelativeErrorSample"], 3);
                            totalEstratificadoBS.Add(totales);
                        }
                        if (opciones.Contains("VC"))
                        {
                            resultados = diseno.Execute(1);
                            //Cargando resultado de los datos al reporte
                            foreach (KeyValuePair<string, object> resultStratum in resultados)
                            {
                                resultadosTemporales = (Dictionary<string, object>)resultStratum.Value;
                                resultado = new RESULTADOMUESTREO();
                                if (resultStratum.Key != "totales")
                                {
                                    ESTRATO stratum = stratums.GetStratum(int.Parse(resultStratum.Key));
                                    resultado.ESTRATO = stratum != null ? stratum.DESCRIPESTRATO : resultStratum.Key;
                                    resultado.PESOESTRATO = Math.Round((double)resultadosTemporales["weight"], 3);
                                    resultado.VARIABLE = "Volumen Comercial (Mtrs3)";
                                    resultado.TOTAL = totalParcelas * Math.Round((double)resultadosTemporales["Mean"], 3);
                                    resultado.TOTALPORHECTAREA = resultado.TOTAL / (double)currentProject.SUPTOT;
                                    resultado.PROMEDIO = Math.Round((double)resultadosTemporales["Mean"], 3);
                                    resultado.DESVIACIONESTANDAR = Math.Round((double)resultadosTemporales["StandardDeviation"], 3);
                                    resultado.COEFICIENTEDEVARIACION = Math.Round((double)resultadosTemporales["VariationCoefficient"], 3);
                                    resultado.ERRORDESVIACION = Math.Round((double)resultadosTemporales["StandardError"], 3);
                                    resultado.ERRORABSOLUTOMUESTREO = Math.Round((double)resultadosTemporales["AbsoulteErrorSample"], 3);
                                    resultado.LIMITEINF = Math.Round((double)resultadosTemporales["LowLimit"], 3);
                                    resultado.LIMITESUP = Math.Round((double)resultadosTemporales["HightLimit"], 3);
                                    resultado.ERRORRELATIVO = Math.Round((double)resultadosTemporales["RelativeErrorSample"], 3);
                                    resultadosBS.Add(resultado);
                                }
                            }
                            resultadosTemporales = (Dictionary<string, object>)resultados.Last().Value;
                            totales = new TOTALESMUESTREOESTRATIFICADOS();
                            totales.VARIABLE = "Volumen Comercial (Mtrs3)";
                            totales.TOTALPROMEDIOESTRATIFICADO = Math.Round((double)resultadosTemporales["Mean"], 3);
                            totales.TOTALDESESTANDARESTRATIFICADO = Math.Round((double)resultadosTemporales["StandardError"], 3);
                            totales.TOTALERRORMUESTREO = Math.Round((double)resultadosTemporales["AbsoulteErrorSample"], 3);
                            totales.TOTALERRRORELATIVO = Math.Round((double)resultadosTemporales["RelativeErrorSample"], 3);
                            totalEstratificadoBS.Add(totales);
                        }
                        if (opciones.Contains("VT"))
                        {
                            resultados = diseno.Execute(2);
                            //Cargando resultado de los datos al reporte
                            foreach (KeyValuePair<string, object> resultStratum in resultados)
                            {
                                resultadosTemporales = (Dictionary<string, object>)resultStratum.Value;
                                resultado = new RESULTADOMUESTREO();
                                if (resultStratum.Key != "totales")
                                {
                                    ESTRATO stratum = stratums.GetStratum(int.Parse(resultStratum.Key));
                                    resultado.ESTRATO = stratum != null ? stratum.DESCRIPESTRATO : resultStratum.Key;
                                    resultado.PESOESTRATO = Math.Round((double)resultadosTemporales["weight"], 3);
                                    resultado.VARIABLE = "Volumen Total (Mtrs3)";
                                    resultado.TOTAL = totalParcelas * Math.Round((double)resultadosTemporales["Mean"], 3);
                                    resultado.TOTALPORHECTAREA = resultado.TOTAL / (double)currentProject.SUPTOT;
                                    resultado.PROMEDIO = Math.Round((double)resultadosTemporales["Mean"], 3);
                                    resultado.DESVIACIONESTANDAR = Math.Round((double)resultadosTemporales["StandardDeviation"], 3);
                                    resultado.COEFICIENTEDEVARIACION = Math.Round((double)resultadosTemporales["VariationCoefficient"], 3);
                                    resultado.ERRORDESVIACION = Math.Round((double)resultadosTemporales["StandardError"], 3);
                                    resultado.ERRORABSOLUTOMUESTREO = Math.Round((double)resultadosTemporales["AbsoulteErrorSample"], 3);
                                    resultado.LIMITEINF = Math.Round((double)resultadosTemporales["LowLimit"], 3);
                                    resultado.LIMITESUP = Math.Round((double)resultadosTemporales["HightLimit"], 3);
                                    resultado.ERRORRELATIVO = Math.Round((double)resultadosTemporales["RelativeErrorSample"], 3);
                                    resultadosBS.Add(resultado);
                                }
                            }
                            resultadosTemporales = (Dictionary<string, object>)resultados.Last().Value;
                            totales = new TOTALESMUESTREOESTRATIFICADOS();
                            totales.VARIABLE = "Volumen Total (Mtrs3)";
                            totales.TOTALPROMEDIOESTRATIFICADO = Math.Round((double)resultadosTemporales["Mean"], 3);
                            totales.TOTALDESESTANDARESTRATIFICADO = Math.Round((double)resultadosTemporales["StandardError"], 3);
                            totales.TOTALERRORMUESTREO = Math.Round((double)resultadosTemporales["AbsoulteErrorSample"], 3);
                            totales.TOTALERRRORELATIVO = Math.Round((double)resultadosTemporales["RelativeErrorSample"], 3);
                            totalEstratificadoBS.Add(totales);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this.MdiParent;
                er.Show();
            }
        }

        public Ver_Reporte_Form()
        {
            InitializeComponent();
            tStudentTable = new TStudentBL(Program.ContextData);
            stratums = new StratumBL(Program.ContextData);
            project = new PROYECTO();
            PROYECTO currentProject = (PROYECTO)Program.Cache.Get("project");
            //Cargando datos del proyecto al reporte
            if (currentProject != null)
            {
                TypeSampleDesignBl tipoDiseno = new TypeSampleDesignBl(Program.ContextData);
                ObjectiveInventoryBL objetivoInventario = new ObjectiveInventoryBL(Program.ContextData);
                project.NOMTIPODISEMUEST = tipoDiseno.GetTypeSampleDesign(currentProject.NOMTIPODISEMUEST).DESCRIPTIPODISEMUEST;
                project.NOMBRETIPOINV = objetivoInventario.GetObjectiveInventory(currentProject.NOMBRETIPOINV).DESCRIPOBJETINV;
                project.INTMUE = Math.Round(currentProject.INTMUE, 3);
                project.TAMANO = Math.Round(currentProject.TAMANO, 3);
                project.DESCRIPCION = currentProject.DESCRIPCION;
                project.LUGAR = currentProject.LUGAR;
                project.FECHA = currentProject.FECHA;
                project.SUPMUE = Math.Round(currentProject.SUPMUE, 3);
                project.SUPTOT = Math.Round(currentProject.SUPTOT, 3);
                Decimal confianza = currentProject.CONFIANZA != null ? (decimal)currentProject.CONFIANZA : 0;
                project.CONFIANZA = Math.Round(confianza, 3);
                proyectoBS.DataSource = project;                
            }
        }
        
        private void Ver_Reporte_Form_Load(object sender, EventArgs e)
        {
            if (reportCD)
            {
                this.verReporteRPVW.Reset();
                ReportDataSource proyectoDataSet = new Microsoft.Reporting.WinForms.ReportDataSource();
                ReportDataSource clasesDiametricasDataSet = new Microsoft.Reporting.WinForms.ReportDataSource();
                clasesDiametricasDataSet.Name = "CLASESDIAMETRICASDataSet";
                clasesDiametricasDataSet.Value = this.diametricClassesBS;
                proyectoDataSet.Name = "PROYECTODataSet";
                proyectoDataSet.Value = this.proyectoBS;
                this.verReporteRPVW.LocalReport.DataSources.Add(clasesDiametricasDataSet);
                this.verReporteRPVW.LocalReport.DataSources.Add(proyectoDataSet);
                this.verReporteRPVW.LocalReport.ReportEmbeddedResource = "SIFCA.Reportes.DiametricClassesReport.rdlc";
                this.verReporteRPVW.RefreshReport();
            }
            else
            {
                this.verReporteRPVW.Reset();
                ReportDataSource resultadosDataSet = new Microsoft.Reporting.WinForms.ReportDataSource();
                ReportDataSource proyectoDataSet = new Microsoft.Reporting.WinForms.ReportDataSource();
                ReportDataSource totalesDataSet = new Microsoft.Reporting.WinForms.ReportDataSource();
                resultadosDataSet.Name = "RESULTADODATASET";
                resultadosDataSet.Value = this.resultadosBS;
                proyectoDataSet.Name = "PROYECTODATASET";
                proyectoDataSet.Value = this.proyectoBS;
                totalesDataSet.Name = "TOTALESDATASET";
                totalesDataSet.Value = this.totalEstratificadoBS;
                this.verReporteRPVW.LocalReport.DataSources.Add(resultadosDataSet);
                this.verReporteRPVW.LocalReport.DataSources.Add(proyectoDataSet);
                if (!estratificado) this.verReporteRPVW.LocalReport.ReportEmbeddedResource = "SIFCA.Reportes.ResultsReport.rdlc";
                else
                {
                    this.verReporteRPVW.LocalReport.DataSources.Add(totalesDataSet);
                    this.verReporteRPVW.LocalReport.ReportEmbeddedResource = "SIFCA.Reportes.StratumReport.rdlc";
                }
                //this.verReporteRPVW.LocalReport.ReportPath = Path.GetDirectoryName(Application.ExecutablePath)+"\\Reportes\\ResultsReport.rdlc";
                this.verReporteRPVW.RefreshReport();
            }
        }


        internal void createReportDC(decimal NumClases, int rangeDAP, string classDiam)
        {
            PROYECTO currentProject = (PROYECTO)Program.Cache.Get("project");
            //int [] ListClass = new int[int.Parse(NumClases.ToString())];
            
            //hasta aqui se han cargado los datos del proyecto para poder mostrarlos
            //REPORTECLASESDIAMETRICASDATASOURCE dsCD = new REPORTECLASESDIAMETRICASDATASOURCE();
            List<REPORTECLASESDIAMETRICASDATASOURCE> ListresultReportCD = new List<REPORTECLASESDIAMETRICASDATASOURCE>();
            SpeciesBL SpBL = new SpeciesBL(Program.ContextData);
            InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
            foreach (FORMULARIO fr in currentProject.FORMULARIO)
            {
                foreach (ESPECIE sp in currentProject.ESPECIE)
                {
                    List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();
                    for (int i = 10; i <= (rangeDAP * NumClases); i = i + rangeDAP)
                    {
                        REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                        rpCD.CLASE = i + " - " + (i + rangeDAP);
                        //int count = 0;
                        rpCD = lnBL.searchDiametricClass(sp.CODESP,fr.NROFORMULARIO, classDiam, i, i + rangeDAP, rpCD);
                        //rpCD.CONTEO = count;

                        rpCD.TOTAL = rpCD.CONTEO / currentProject.FORMULARIO.Count(); //dividimos el numero entre el numero total de parcelas
                        rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                        rpCD.AREABASAL = rpCD.AREABASAL / currentProject.FORMULARIO.Count();
                        rpCD.VOLUMEN = rpCD.VOLUMEN / currentProject.FORMULARIO.Count();
                        resultReportCD.Add(rpCD);
                    }
                    REPORTECLASESDIAMETRICASDATASOURCE rpCDDS = new REPORTECLASESDIAMETRICASDATASOURCE(resultReportCD,sp.NOMCIENTIFICO,sp.CODESP);
                    ListresultReportCD.Add(rpCDDS);
                }
            }

            diametricClassesBS.DataSource = ListresultReportCD;
            //resultReportCD.GroupBy(p => p.CODESP);
            reportCD = true;
        }
    }
}
