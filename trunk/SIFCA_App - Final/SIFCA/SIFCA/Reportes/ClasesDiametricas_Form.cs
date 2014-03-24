using SIFCA_BLL;
using SIFCA_DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIFCA
{
    public partial class ClasesDiametricas_Form : Form
    {
        public ClasesDiametricas_Form()
        {
            try
            {
                InitializeComponent();
                tipoClaseCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this.MdiParent;
                er.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int rangeDAP = 0;
                bool canConvert = int.TryParse(this.txt_rangoDAP.Text, out rangeDAP);
                if (nUd_NumClases.Value <= 1)
                {
                    controladorErrores.SetError(nUd_NumClases, "Se debe especificar mas de una clase");
                }
                else if (!canConvert)
                {
                    controladorErrores.SetError(txt_rangoDAP, "El rango debe ser númerico");
                }
                else if (tipoClaseCbx.Text.Equals(""))
                {
                    controladorErrores.SetError(tipoClaseCbx, "Seleccione una opción");
                }
                else
                {
                    controladorErrores.Clear();
                    int NumClass = (int)nUd_NumClases.Value;
                    PROYECTO currentProject = (PROYECTO)Program.Cache.Get("project");
                    if (currentProject != null)
                    {
                        DataGridViewTextBoxColumn Column1;
                        if (tipoClaseCbx.Text.Equals("General"))
                        {
                            this.DtgDatos.ColumnCount = 0;
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Especie";
                            Column1.Name = "ColNombre";
                            DtgDatos.Columns.Add(Column1);
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Grupo ecológico";
                            Column1.Name = "ColGrupoEcologico";
                            DtgDatos.Columns.Add(Column1);
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Valor comercial";
                            Column1.Name = "ColEspecie";
                            DtgDatos.Columns.Add(Column1);
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Variable";
                            Column1.Name = "ColVariable";
                            DtgDatos.Columns.Add(Column1);
                            for (int i = 0, posClase = rangeDAP; i < NumClass; i++)
                            {

                                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                Column1.HeaderText = posClase + " - " + (posClase + rangeDAP);
                                Column1.Name = "Clase" + (i + 1);
                                DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                                dataGridViewCellStyle1.Format = "0.000###";
                                Column1.DefaultCellStyle = dataGridViewCellStyle1;
                                DtgDatos.Columns.Add(Column1);

                                posClase = posClase + rangeDAP;
                            }
                            
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Total";
                            Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                            DtgDatos.Columns.Add(Column1);
                            List<REPORTECLASESDIAMETRICASDATASOURCE> ListresultReportCD = new List<REPORTECLASESDIAMETRICASDATASOURCE>();
                            SpeciesBL SpBL = new SpeciesBL(Program.ContextData);
                            InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
                            decimal[] totalConteoClase = new decimal[NumClass];
                            decimal[] totalABClase = new decimal[NumClass];
                            decimal[] totalVolClase = new decimal[NumClass];
                            ArrayList RowsData = new ArrayList();

                            foreach (ESPECIE sp in currentProject.ESPECIE)
                            {
                                List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();

                                for (int i = 10; i <= (rangeDAP * NumClass); i = i + rangeDAP)
                                {
                                    REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                                    rpCD.CLASE = i + " - " + (i + rangeDAP);

                                    foreach (FORMULARIO fr in currentProject.FORMULARIO)
                                    {
                                        rpCD = lnBL.searchDiametricClass(sp.CODESP, fr.NROFORMULARIO, tipoClaseCbx.Text, i, i + rangeDAP, rpCD);
                                    }
                                    rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                                    if (rpCD.CONTEO > 0)
                                    {
                                        rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                                        rpCD.VOLUMEN = rpCD.VOLUMEN / rpCD.CONTEO;
                                    }
                                
                                    resultReportCD.Add(rpCD);
                                    //Se realiza para los totales por clase de densidad,AB, vol
                                    totalConteoClase[(i - rangeDAP) / rangeDAP] += rpCD.CONTEO;
                                    totalABClase[(i - rangeDAP) / rangeDAP] += rpCD.AREABASAL;
                                    totalVolClase[(i - rangeDAP) / rangeDAP] += rpCD.VOLUMEN;
                                }
                                //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                                //entonces ahora se lleva los valores de la especie y las clases diametricas
                                string RowConteo = "", RowAB = " ,,,Area Basal,", RowVol = " ,,,Volumen,";
                                decimal totalConteo = 0, totalAB = 0, totalVol = 0;
                                RowConteo += RowConteo + sp.NOMCOMUN + " - " + sp.NOMCIENTIFICO + "," + sp.GRUPOECOLOGICO + "," + sp.GRUPOCOMERCIAL.DESCRIPGRUPO + ", Densidad,";
                                foreach (REPORTECLASESDIAMETRICAS rp in resultReportCD)
                                {
                                    RowConteo += Decimal.Round(rp.CONTEO, 4) + ",";
                                    RowAB += Decimal.Round(rp.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                                    RowVol += Decimal.Round(rp.VOLUMEN, 4).ToString().Replace(",", ".") + ",";
                                    totalConteo += rp.CONTEO;
                                    totalAB += rp.AREABASAL;
                                    totalVol += rp.VOLUMEN;
                                }
                                RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                                RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                                RowVol += Decimal.Round(totalVol, 4).ToString().Replace(",", ".") + ",";
                                RowsData.Add(RowConteo);
                                RowsData.Add(RowAB);
                                RowsData.Add(RowVol);

                            }

                            string RowTotalC = "TOTALES,,,Densidad,", RowTotalAB = " ,,,Area Basal,", RowTotalVol = " ,,,Volumen,";
                            foreach (decimal d in totalConteoClase)
                            {
                                RowTotalC += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                            }
                            foreach (decimal d in totalABClase)
                            {
                                RowTotalAB += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                            }
                            foreach (decimal d in totalVolClase)
                            {
                                RowTotalVol += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                            }

                            RowTotalC += Decimal.Round(totalConteoClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                            RowTotalAB += Decimal.Round(totalABClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                            RowTotalVol += Decimal.Round(totalVolClase.Sum(), 4).ToString().Replace(",", ".") + ",";

                            //RowsData.Add(RowTotalC);
                            //RowsData.Add(RowTotalAB);
                            //RowsData.Add(RowTotalVol);
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Porcentaje";
                            Column1.Name = "Clase" + (nUd_NumClases.Value + 4);
                            DtgDatos.Columns.Add(Column1);
                            int numCampos = 4;
                            for (int i = 0; i < RowsData.Count; i = i + 3)
                            {
                                //Se arregla la fila que corresponde a la densidad
                                string cadena = (string)RowsData[i];
                                string[] fila = cadena.Split(',');
                                decimal total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                decimal p = 0;
                                if (totalConteoClase.Sum() > 0) p = ((total) / totalConteoClase.Sum()) * 100;
                                string result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                DtgDatos.Rows.Add(result.Split(','));

                                //Se arregla la fila que corresponde la area basal
                                cadena = (string)RowsData[i + 1];
                                fila = cadena.Split(',');
                                total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                p = 0;
                                if (totalConteoClase.Sum() > 0) p = (total / totalABClase.Sum()) * 100;
                                result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                DtgDatos.Rows.Add(result.Split(','));

                                //Se arregla la fila que corresponde al volumen
                                cadena = (string)RowsData[i + 2];
                                fila = cadena.Split(',');
                                total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                p = 0;
                                if (totalConteoClase.Sum() > 0) p = (total / totalVolClase.Sum()) * 100;
                                result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                DtgDatos.Rows.Add(result.Split(','));
                            }

                            //DtgDatos.Rows.Add(RowConteo.Split(','));
                            //DtgDatos.Rows.Add(RowAB.Split(','));
                            //DtgDatos.Rows.Add(RowVol.Split(','));
                            //DtgDatos.Refresh();

                            DtgDatos.Rows.Add(RowTotalC.Split(','));
                            DtgDatos.Rows.Add(RowTotalAB.Split(','));
                            DtgDatos.Rows.Add(RowTotalVol.Split(','));
                            DtgDatos.Refresh();                        
                        }
                        else
                        {
                            if (tipoClaseCbx.Text.Equals("Valor comercial"))
                            {
                                this.DtgDatos.ColumnCount = 0;
                                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                Column1.HeaderText = "Valor comercial";
                                Column1.Name = "valorComercial";
                                DtgDatos.Columns.Add(Column1);
                                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                Column1.HeaderText = "Variable";
                                Column1.Name = "ColVariable";
                                DtgDatos.Columns.Add(Column1);
                                for (int i = 0, posClase = rangeDAP; i < NumClass; i++)
                                {

                                    Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                    Column1.HeaderText = posClase + " - " + (posClase + rangeDAP);
                                    Column1.Name = "Clase" + (i + 1);
                                    DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                                    dataGridViewCellStyle1.Format = "0.000###";
                                    Column1.DefaultCellStyle = dataGridViewCellStyle1;
                                    DtgDatos.Columns.Add(Column1);

                                    posClase = posClase + rangeDAP;
                                }
                                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                Column1.HeaderText = "Total";
                                Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                                DtgDatos.Columns.Add(Column1);
                                
                                List<REPORTECLASESDIAMETRICASDATASOURCE> ListresultReportCD = new List<REPORTECLASESDIAMETRICASDATASOURCE>();
                                SpeciesBL SpBL = new SpeciesBL(Program.ContextData);
                                GroupBL groupBL = new GroupBL(Program.ContextData);
                                InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
                                decimal[] totalConteoClase = new decimal[NumClass];
                                decimal[] totalABClase = new decimal[NumClass];
                                decimal[] totalVolClase = new decimal[NumClass];
                                ArrayList RowsData = new ArrayList();

                                foreach (GRUPOCOMERCIAL gc in groupBL.GetGroups())
                                {

                                    List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();
                                    for (int i = 10; i <= (rangeDAP * NumClass); i = i + rangeDAP)
                                    {
                                        REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                                        rpCD.CLASE = i + " - " + (i + rangeDAP);
                                        foreach (ESPECIE sp in currentProject.ESPECIE.Where(p => p.GRUPOCOM == gc.GRUPOCOM))
                                        {
                                            foreach (FORMULARIO fr in currentProject.FORMULARIO)
                                            {
                                                rpCD = lnBL.searchDiametricClass(sp.CODESP, fr.NROFORMULARIO, tipoClaseCbx.Text, i, i + rangeDAP, rpCD);
                                            }
                                        }
                                        rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                                        if (rpCD.CONTEO > 0)
                                        {
                                            rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                                            rpCD.VOLUMEN = rpCD.VOLUMEN / rpCD.CONTEO;
                                        }

                                        resultReportCD.Add(rpCD);
                                        //Se realiza para los totales por clase de densidad,AB, vol
                                        totalConteoClase[(i - rangeDAP) / rangeDAP] += rpCD.CONTEO;
                                        totalABClase[(i - rangeDAP) / rangeDAP] += rpCD.AREABASAL;
                                        totalVolClase[(i - rangeDAP) / rangeDAP] += rpCD.VOLUMEN;
                                    }                                    //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                                    //entonces ahora se lleva los valores de la especie y las clases diametricas
                                    string RowConteo = "", RowAB = " ,Area Basal,", RowVol = " ,Volumen,";
                                    decimal totalConteo = 0, totalAB = 0, totalVol = 0;
                                    RowConteo += gc.DESCRIPGRUPO + ", Densidad,";
                                    foreach (REPORTECLASESDIAMETRICAS rp in resultReportCD)
                                    {
                                        RowConteo += Decimal.Round(rp.CONTEO, 4) + ",";
                                        RowAB += Decimal.Round(rp.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                                        RowVol += Decimal.Round(rp.VOLUMEN, 4).ToString().Replace(",", ".") + ",";
                                        totalConteo += rp.CONTEO;
                                        totalAB += rp.AREABASAL;
                                        totalVol += rp.VOLUMEN;
                                    }
                                    RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                                    RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                                    RowVol += Decimal.Round(totalVol, 4).ToString().Replace(",", ".") + ",";
                                    RowsData.Add(RowConteo);
                                    RowsData.Add(RowAB);
                                    RowsData.Add(RowVol);

                                }

                                string RowTotalC = "TOTALES,Densidad,", RowTotalAB = " ,Area Basal,", RowTotalVol = " ,Volumen,";
                                foreach (decimal d in totalConteoClase)
                                {
                                    RowTotalC += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                                }
                                foreach (decimal d in totalABClase)
                                {
                                    RowTotalAB += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                                }
                                foreach (decimal d in totalVolClase)
                                {
                                    RowTotalVol += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                                }

                                RowTotalC += Decimal.Round(totalConteoClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                                RowTotalAB += Decimal.Round(totalABClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                                RowTotalVol += Decimal.Round(totalVolClase.Sum(), 4).ToString().Replace(",", ".") + ",";

                                Column1 = new DataGridViewTextBoxColumn();
                                Column1.HeaderText = "Porcentaje";
                                Column1.Name = "Clase" + (nUd_NumClases.Value + 4);
                                DtgDatos.Columns.Add(Column1);
                                int numCampos = 2;
                                for (int i = 0; i < RowsData.Count; i = i + 3)
                                {
                                    //Se arregla la fila que corresponde a la densidad
                                    string cadena = (string)RowsData[i];
                                    string[] fila = cadena.Split(',');
                                    decimal total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                    decimal p = 0;
                                    if (totalConteoClase.Sum() > 0) p = ((total) / totalConteoClase.Sum()) * 100;
                                    string result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                    DtgDatos.Rows.Add(result.Split(','));

                                    //Se arregla la fila que corresponde la area basal
                                    cadena = (string)RowsData[i + 1];
                                    fila = cadena.Split(',');
                                    total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                    p = 0;
                                    if (totalConteoClase.Sum() > 0) p = (total / totalABClase.Sum()) * 100;
                                    result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                    DtgDatos.Rows.Add(result.Split(','));

                                    //Se arregla la fila que corresponde al volumen
                                    cadena = (string)RowsData[i + 2];
                                    fila = cadena.Split(',');
                                    total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                    p = 0;
                                    if (totalConteoClase.Sum() > 0) p = (total / totalVolClase.Sum()) * 100;
                                    result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                    DtgDatos.Rows.Add(result.Split(','));
                                }

                                DtgDatos.Rows.Add(RowTotalC.Split(','));
                                DtgDatos.Rows.Add(RowTotalAB.Split(','));
                                DtgDatos.Rows.Add(RowTotalVol.Split(','));
                                DtgDatos.Refresh();                                                        
                            }
                            else
                                if (tipoClaseCbx.Text.Equals("Estratos"))
                                {
                                    this.DtgDatos.ColumnCount = 0;
                                    Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                    Column1.HeaderText = "Estrato";
                                    Column1.Name = "estrato";
                                    DtgDatos.Columns.Add(Column1);
                                    Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                    Column1.HeaderText = "Variable";
                                    Column1.Name = "ColVariable";
                                    DtgDatos.Columns.Add(Column1);
                                    for (int i = 0, posClase = rangeDAP; i < NumClass; i++)
                                    {
                                        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                        Column1.HeaderText = posClase + " - " + (posClase + rangeDAP);
                                        Column1.Name = "Clase" + (i + 1);
                                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                                        dataGridViewCellStyle1.Format = "0.000###";
                                        Column1.DefaultCellStyle = dataGridViewCellStyle1;
                                        DtgDatos.Columns.Add(Column1);

                                        posClase = posClase + rangeDAP;
                                    }
                                    Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                    Column1.HeaderText = "Total";
                                    Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                                    DtgDatos.Columns.Add(Column1);

                                    List<REPORTECLASESDIAMETRICASDATASOURCE> ListresultReportCD = new List<REPORTECLASESDIAMETRICASDATASOURCE>();
                                    StratumBL StBL = new StratumBL(Program.ContextData);
                                    InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
                                    decimal[] totalConteoClase = new decimal[NumClass];
                                    decimal[] totalABClase = new decimal[NumClass];
                                    decimal[] totalVolClase = new decimal[NumClass];
                                    ArrayList RowsData = new ArrayList();

                                    foreach (LISTADODEESTRATOS st in currentProject.LISTADODEESTRATOS)
                                    {
                                        List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();
                                        for (int i = 10; i <= (rangeDAP * NumClass); i = i + rangeDAP)
                                        {
                                            REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                                            rpCD.CLASE = i + " - " + (i + rangeDAP);
                                            foreach (FORMULARIO fr in currentProject.FORMULARIO.Where(f => f.CODEST == st.CODEST))
                                            {
                                               rpCD = lnBL.searchDiametricClass(Guid.Empty, fr.NROFORMULARIO, tipoClaseCbx.Text, i, i + rangeDAP, rpCD);
                                        
                                            }
                                            rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                                            if (rpCD.CONTEO > 0)
                                            {
                                                rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                                                rpCD.VOLUMEN = rpCD.VOLUMEN / rpCD.CONTEO;
                                            }

                                            resultReportCD.Add(rpCD);
                                            //Se realiza para los totales por clase de densidad,AB, vol
                                            totalConteoClase[(i - rangeDAP) / rangeDAP] += rpCD.CONTEO;
                                            totalABClase[(i - rangeDAP) / rangeDAP] += rpCD.AREABASAL;
                                            totalVolClase[(i - rangeDAP) / rangeDAP] += rpCD.VOLUMEN;
                                        }                                    //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                                        //entonces ahora se lleva los valores de la especie y las clases diametricas
                                        string RowConteo = "", RowAB = " ,Area Basal,", RowVol = " ,Volumen,";
                                        decimal totalConteo = 0, totalAB = 0, totalVol = 0;
                                        RowConteo += (StBL.GetStratum((int)st.CODEST)).DESCRIPESTRATO + ", Densidad,";
                                        foreach (REPORTECLASESDIAMETRICAS rp in resultReportCD)
                                        {
                                            RowConteo += Decimal.Round(rp.CONTEO, 4) + ",";
                                            RowAB += Decimal.Round(rp.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                                            RowVol += Decimal.Round(rp.VOLUMEN, 4).ToString().Replace(",", ".") + ",";
                                            totalConteo += rp.CONTEO;
                                            totalAB += rp.AREABASAL;
                                            totalVol += rp.VOLUMEN;
                                        }
                                        RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                                        RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                                        RowVol += Decimal.Round(totalVol, 4).ToString().Replace(",", ".") + ",";
                                        RowsData.Add(RowConteo);
                                        RowsData.Add(RowAB);
                                        RowsData.Add(RowVol);

                                    }

                                    string RowTotalC = "TOTALES,Densidad,", RowTotalAB = " ,Area Basal,", RowTotalVol = " ,Volumen,";
                                    foreach (decimal d in totalConteoClase)
                                    {
                                        RowTotalC += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                                    }
                                    foreach (decimal d in totalABClase)
                                    {
                                        RowTotalAB += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                                    }
                                    foreach (decimal d in totalVolClase)
                                    {
                                        RowTotalVol += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                                    }

                                    foreach (string fila in RowsData)
                                    {
                                        string[] aux = fila.Split(',');
                                    }
                                    RowTotalC += Decimal.Round(totalConteoClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                                    RowTotalAB += Decimal.Round(totalABClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                                    RowTotalVol += Decimal.Round(totalVolClase.Sum(), 4).ToString().Replace(",", ".") + ",";

                                    Column1 = new DataGridViewTextBoxColumn();
                                    Column1.HeaderText = "Porcentaje";
                                    Column1.Name = "Clase" + (nUd_NumClases.Value + 4);
                                    DtgDatos.Columns.Add(Column1);
                                    int numCampos = 2;
                                    for (int i = 0; i < RowsData.Count; i = i + 3)
                                    {
                                        //Se arregla la fila que corresponde a la densidad
                                        string cadena = (string)RowsData[i];
                                        string[] fila = cadena.Split(',');
                                        decimal total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                        decimal p = 0;
                                        if (totalConteoClase.Sum() > 0) p = ((total) / totalConteoClase.Sum()) * 100;
                                        string result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                        DtgDatos.Rows.Add(result.Split(','));

                                        //Se arregla la fila que corresponde la area basal
                                        cadena = (string)RowsData[i + 1];
                                        fila = cadena.Split(',');
                                        total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                        p = 0;
                                        if (totalConteoClase.Sum() > 0) p = (total / totalABClase.Sum()) * 100;
                                        result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                        DtgDatos.Rows.Add(result.Split(','));

                                        //Se arregla la fila que corresponde al volumen
                                        cadena = (string)RowsData[i + 2];
                                        fila = cadena.Split(',');
                                        total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                                        p = 0;
                                        if (totalConteoClase.Sum() > 0) p = (total / totalVolClase.Sum()) * 100;
                                        result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                                        DtgDatos.Rows.Add(result.Split(','));
                                    }

                                    DtgDatos.Rows.Add(RowTotalC.Split(','));
                                    DtgDatos.Rows.Add(RowTotalAB.Split(','));
                                    DtgDatos.Rows.Add(RowTotalVol.Split(','));
                                    DtgDatos.Refresh();
                                }
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
    }
}
