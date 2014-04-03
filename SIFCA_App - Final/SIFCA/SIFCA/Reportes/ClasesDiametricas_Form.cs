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
        private PROYECTO project;
        public ClasesDiametricas_Form()
        {

            try
            {
                project = (PROYECTO)Program.Cache.Get("project");
                InitializeComponent();
                if (project != null)
                {
                    if (project.NOMTIPODISEMUEST == "ES")
                    {
                        this.tipoClaseCbx.Items.AddRange(new object[] {
                        "General",
                        "Valor comercial",
                        "Estratos"});
                    }
                    else
                    {
                        this.tipoClaseCbx.Items.AddRange(new object[] {
                        "General",
                        "Valor comercial"});
                    }
                    tipoClaseCbx.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Debe abrir un proyecto para ver los reportes.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    project = (PROYECTO)Program.Cache.Get("project");
                    if (project != null)
                    {
                        DataGridViewTextBoxColumn Column1;
                        if (tipoClaseCbx.Text.Equals("General"))
                        {
                            this.DtgDatos.ColumnCount = 0;
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Especie";
                            Column1.Name = "ColNombre";
                            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                            DtgDatos.Columns.Add(Column1);
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Grupo ecológico";
                            Column1.Name = "ColGrupoEcologico";
                            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                            DtgDatos.Columns.Add(Column1);
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Valor comercial";
                            Column1.Name = "ColEspecie";
                            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                            DtgDatos.Columns.Add(Column1);
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Variable";
                            Column1.Name = "ColVariable";
                            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                            DtgDatos.Columns.Add(Column1);
                            for (int i = 0, posClase = 10; i < NumClass; i++)
                            {

                                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                Column1.HeaderText = posClase + " - " + (posClase + rangeDAP);
                                Column1.Name = "Clase" + (i + 1);
                                DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                                dataGridViewCellStyle1.Format = "0.000###";
                                Column1.DefaultCellStyle = dataGridViewCellStyle1;
                                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                                DtgDatos.Columns.Add(Column1);

                                posClase = posClase + rangeDAP;
                            }
                            
                            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            Column1.HeaderText = "Total";
                            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                            Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                            DtgDatos.Columns.Add(Column1);
                            List<REPORTECLASESDIAMETRICASDATASOURCE> ListresultReportCD = new List<REPORTECLASESDIAMETRICASDATASOURCE>();
                            SpeciesBL SpBL = new SpeciesBL(Program.ContextData);
                            InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
                            decimal[] totalConteoClase = new decimal[NumClass];
                            decimal[] totalABClase = new decimal[NumClass];
                            decimal[] totalVolClase = new decimal[NumClass];
                            ArrayList RowsData = new ArrayList();

                            foreach (ESPECIE sp in project.ESPECIE)
                            {
                                List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();
                                
                                decimal totalConteo = 0, totalAB = 0, totalVol = 0;
                                string RowConteo = "", RowAB = " ,,,Area Basal,", RowVol = " ,,,Volumen,";

                                string gEco = "";
                                if (sp.GRUPOECOLOGICO == "NT") gEco = "No Tolerante";
                                if (sp.GRUPOECOLOGICO == "TL") gEco = "Tolerante";
                                RowConteo += RowConteo + sp.NOMCOMUN.Replace(',', ' ') + " - " + sp.NOMCIENTIFICO.Replace(',', ' ') +"," + gEco + "," + sp.GRUPOCOMERCIAL.DESCRIPGRUPO + ", Densidad,";

                                for (int i = 0, ValorClase = 10; i < NumClass; i++)
                                {
                                    REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                                    rpCD.CLASE = i + " - " + (i + rangeDAP);

                                    rpCD = lnBL.searchDiametricClass(sp.CODESP, project.NROPROY, tipoClaseCbx.Text, ValorClase, ValorClase + rangeDAP, rpCD);

                                    rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                                    if (rpCD.CONTEO > 0)
                                    {
                                        rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                                        rpCD.VOLUMEN = rpCD.VOLUMEN / rpCD.CONTEO;
                                    }

                                    RowConteo += Decimal.Round(rpCD.CONTEO, 4) + ",";
                                    RowAB += Decimal.Round(rpCD.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                                    RowVol += Decimal.Round(rpCD.VOLUMEN, 4).ToString().Replace(",", ".") + ",";
                                    totalConteo += rpCD.CONTEO;
                                    totalAB += rpCD.AREABASAL;
                                    totalVol += rpCD.VOLUMEN;

                                    //resultReportCD.Add(rpCD);
                                    //Se realiza para los totales por clase de densidad,AB, vol
                                    totalConteoClase[i] += rpCD.CONTEO;
                                    totalABClase[i] += rpCD.AREABASAL;
                                    totalVolClase[i] += rpCD.VOLUMEN;
                                    ValorClase = ValorClase + rangeDAP;
                                }
                                if (totalConteo > 0)
                                {
                                    RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                                    RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                                    RowVol += Decimal.Round(totalVol, 4).ToString().Replace(",", ".") + ",";
                                    RowsData.Add(RowConteo);
                                    RowsData.Add(RowAB);
                                    RowsData.Add(RowVol);
                                }
                            }
                                //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                                //entonces ahora se lleva los valores de la especie y las clases diametricas
                                //string RowConteo = "", RowAB = " ,,,Area Basal,", RowVol = " ,,,Volumen,";
                                //decimal totalConteo = 0, totalAB = 0, totalVol = 0;
                                //string gEco = "";
                                //if (sp.GRUPOECOLOGICO == "NT") gEco = "No Tolerante";
                                //if (sp.GRUPOECOLOGICO == "TL") gEco = "Tolerante";
                                //RowConteo += RowConteo + sp.NOMCOMUN + " - " + sp.NOMCIENTIFICO + "," + gEco + "," + sp.GRUPOCOMERCIAL.DESCRIPGRUPO + ", Densidad,";
                                //foreach (REPORTECLASESDIAMETRICAS rp in resultReportCD)
                                //{
                                //    RowConteo += Decimal.Round(rp.CONTEO, 4) + ",";
                                //    RowAB += Decimal.Round(rp.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                                //    RowVol += Decimal.Round(rp.VOLUMEN, 4).ToString().Replace(",", ".") + ",";
                                //    totalConteo += rp.CONTEO;
                                //    totalAB += rp.AREABASAL;
                                //    totalVol += rp.VOLUMEN;
                                //}
                                //RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                                //RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                                //RowVol += Decimal.Round(totalVol, 4).ToString().Replace(",", ".") + ",";
                                //RowsData.Add(RowConteo);
                                //RowsData.Add(RowAB);
                                //RowsData.Add(RowVol);

                            //}

                            string RowTotalC = ",TOTALES,,Densidad,", RowTotalAB = " ,,,Area Basal,", RowTotalVol = " ,,,Volumen,";
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
                            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
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
                            DtgDatos.AutoResizeColumns();
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
                                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                                DtgDatos.Columns.Add(Column1);
                                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                Column1.HeaderText = "Variable";
                                Column1.Name = "ColVariable";
                                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                                DtgDatos.Columns.Add(Column1);
                                for (int i = 0, posClase = 10; i < NumClass; i++)
                                {

                                    Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                    Column1.HeaderText = posClase + " - " + (posClase + rangeDAP);
                                    Column1.Name = "Clase" + (i + 1);
                                    DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                                    dataGridViewCellStyle1.Format = "0.000###";
                                    Column1.DefaultCellStyle = dataGridViewCellStyle1;
                                    Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                                    DtgDatos.Columns.Add(Column1);

                                    posClase = posClase + rangeDAP;
                                }
                                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                Column1.HeaderText = "Total";
                                Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
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
                                    string RowConteo = "", RowAB = " ,Area Basal,", RowVol = " ,Volumen,";
                                    decimal totalConteo = 0, totalAB = 0, totalVol = 0;
                                    RowConteo += gc.DESCRIPGRUPO + ", Densidad,";
                                    List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();
                                    for (int i = 0, ValorClase = 10; i < NumClass; i++, ValorClase = ValorClase+rangeDAP)
                                    {
                                        REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                                        rpCD.CLASE = i + " - " + (i + rangeDAP);
                                        foreach (ESPECIE sp in project.ESPECIE.Where(p => p.GRUPOCOM == gc.GRUPOCOM))
                                        {
                                            rpCD = lnBL.searchDiametricClass(sp.CODESP, project.NROPROY, tipoClaseCbx.Text, ValorClase, ValorClase + rangeDAP, rpCD);
                                        }
                                        rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                                        if (rpCD.CONTEO > 0)
                                        {
                                            rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                                            rpCD.VOLUMEN = rpCD.VOLUMEN / rpCD.CONTEO;
                                        }
                                        RowConteo += Decimal.Round(rpCD.CONTEO, 4) + ",";
                                        RowAB += Decimal.Round(rpCD.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                                        RowVol += Decimal.Round(rpCD.VOLUMEN, 4).ToString().Replace(",", ".") + ",";
                                        totalConteo += rpCD.CONTEO;
                                        totalAB += rpCD.AREABASAL;
                                        totalVol += rpCD.VOLUMEN;
                                        
                                        //resultReportCD.Add(rpCD);
                                        //Se realiza para los totales por clase de densidad,AB, vol
                                        totalConteoClase[i] += rpCD.CONTEO;
                                        totalABClase[i] += rpCD.AREABASAL;
                                        totalVolClase[i] += rpCD.VOLUMEN;
                                    }                                    //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                                    //entonces ahora se lleva los valores de la especie y las clases diametricas
                                    if (totalConteo > 0)
                                    {
                                        RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                                        RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                                        RowVol += Decimal.Round(totalVol, 4).ToString().Replace(",", ".") + ",";
                                        RowsData.Add(RowConteo);
                                        RowsData.Add(RowAB);
                                        RowsData.Add(RowVol);
                                    }
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
                                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
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
                                DtgDatos.AutoResizeColumns();
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
                                    Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                                    DtgDatos.Columns.Add(Column1);
                                    Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                    Column1.HeaderText = "Variable";
                                    Column1.Name = "ColVariable";
                                    Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                                    DtgDatos.Columns.Add(Column1);
                                    for (int i = 0, posClase = 10; i < NumClass; i++)
                                    {
                                        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                        Column1.HeaderText = posClase + " - " + (posClase + rangeDAP);
                                        Column1.Name = "Clase" + (i + 1);
                                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                                        dataGridViewCellStyle1.Format = "0.000###";
                                        Column1.DefaultCellStyle = dataGridViewCellStyle1;
                                        Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                                        DtgDatos.Columns.Add(Column1);

                                        posClase = posClase + rangeDAP;
                                    }
                                    Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                                    Column1.HeaderText = "Total";
                                    Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                                    Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                                    DtgDatos.Columns.Add(Column1);

                                    List<REPORTECLASESDIAMETRICASDATASOURCE> ListresultReportCD = new List<REPORTECLASESDIAMETRICASDATASOURCE>();
                                    StratumBL StBL = new StratumBL(Program.ContextData);
                                    InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
                                    decimal[] totalConteoClase = new decimal[NumClass];
                                    decimal[] totalABClase = new decimal[NumClass];
                                    decimal[] totalVolClase = new decimal[NumClass];
                                    ArrayList RowsData = new ArrayList();

                                    foreach (LISTADODEESTRATOS st in project.LISTADODEESTRATOS)
                                    {                                        
                                        string RowConteo = "", RowAB = " ,Area Basal,", RowVol = " ,Volumen,";
                                        decimal totalConteo = 0, totalAB = 0, totalVol = 0;
                                        RowConteo += (StBL.GetStratum((int)st.CODEST)).DESCRIPESTRATO + ", Densidad,";

                                        List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();
                                        for (int i = 0, ValorClase = 10; i < NumClass; i++, ValorClase = ValorClase+rangeDAP)
                                        {
                                            REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                                            rpCD.CLASE = i + " - " + (i + rangeDAP);
                                            foreach (FORMULARIO fr in project.FORMULARIO.Where(f => f.CODEST == st.CODEST))
                                            {
                                               rpCD = lnBL.searchDiametricClass(Guid.Empty, fr.NROFORMULARIO, tipoClaseCbx.Text, i, i + rangeDAP, rpCD);                                        
                                            }
                                            rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                                            if (rpCD.CONTEO > 0)
                                            {
                                                rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                                                rpCD.VOLUMEN = rpCD.VOLUMEN / rpCD.CONTEO;
                                            }
                                            RowConteo += Decimal.Round(rpCD.CONTEO, 4) + ",";
                                            RowAB += Decimal.Round(rpCD.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                                            RowVol += Decimal.Round(rpCD.VOLUMEN, 4).ToString().Replace(",", ".") + ",";
                                            totalConteo += rpCD.CONTEO;
                                            totalAB += rpCD.AREABASAL;
                                            totalVol += rpCD.VOLUMEN;

                                            //Se realiza para los totales por clase de densidad,AB, vol
                                            totalConteoClase[i] += rpCD.CONTEO;
                                            totalABClase[i] += rpCD.AREABASAL;
                                            totalVolClase[i] += rpCD.VOLUMEN;
                                        }                                    //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                                        //entonces ahora se lleva los valores de la especie y las clases diametricas
                                        if (totalConteo > 0)
                                        {
                                            RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                                            RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                                            RowVol += Decimal.Round(totalVol, 4).ToString().Replace(",", ".") + ",";
                                            RowsData.Add(RowConteo);
                                            RowsData.Add(RowAB);
                                            RowsData.Add(RowVol);
                                        }
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
                                    Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
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
                                    DtgDatos.AutoResizeColumns();
                                    DtgDatos.Rows.Add(RowTotalC.Split(','));
                                    DtgDatos.Rows.Add(RowTotalAB.Split(','));
                                    DtgDatos.Rows.Add(RowTotalVol.Split(','));
                                    DtgDatos.Refresh();
                                }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe abrir un proyecto para ver los reportes.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
