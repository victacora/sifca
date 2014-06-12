using SIFCA.Helper;
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
        DataGridViewTextBoxColumn Column1;
        int NumClass =0;
        int rangeDAP = 0;
        decimal DIM = 0;


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
                    this.DIM = 0;
                    
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
                    
                    NumClass = (int)nUd_NumClases.Value;
                    controladorErrores.Clear();                    
                    project = (PROYECTO)Program.Cache.Get("project");
                    this.progressBar.Visible = true;
                    this.DtgDatos.ColumnCount = 0;
                    if (project != null)
                    {
                        this.DIM = project.LIMITINFDAP * 100;
                        if (tipoClaseCbx.Text.Equals("General"))
                        {
                            this.reporteGeneral();                            
                        }
                        else
                        {
                            if (tipoClaseCbx.Text.Equals("Valor comercial"))
                            {
                                this.reporteValorComercial();                                                                               
                            }
                            else
                                if (tipoClaseCbx.Text.Equals("Estratos"))
                                {
                                    this.reporteEstratos();
                                }
                        }
                        this.progressBar.Visible = false;
                        this.exportarBtn.Enabled = true;
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

        private void reporteEstratos()
        {
            try
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
                decimal posClase = this.DIM;
                for (int i = 0; i < NumClass; i++)
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
                Column1.HeaderText = "Otros";
                Column1.Name = "ClaseOtros";
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                DtgDatos.Columns.Add(Column1);
                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Column1.HeaderText = "Total";
                Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                DtgDatos.Columns.Add(Column1);

                StratumBL StBL = new StratumBL(Program.ContextData);
                InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
                decimal[] totalConteoClase = new decimal[NumClass + 1];
                decimal[] totalABClase = new decimal[NumClass + 1];
                decimal[] totalVolComClase = new decimal[NumClass + 1];
                decimal[] totalVolTotClase = new decimal[NumClass + 1];
                ArrayList RowsData = new ArrayList();
                this.progressBar.Value = 0;
                this.progressBar.Minimum = 0;
                this.progressBar.Maximum = project.LISTADODEESTRATOS.Count;

                foreach (LISTADODEESTRATOS st in project.LISTADODEESTRATOS)
                {
                    string RowConteo = "", RowAB = " ,Area Basal,", RowVolCom = " ,Volumen comercial,", RowVolTot = " ,Volumen total,";
                    decimal totalConteo = 0, totalAB = 0, totalVolCom = 0, totalVolTot = 0;
                    RowConteo += (StBL.GetStratum((int)st.CODEST)).DESCRIPESTRATO + ", Densidad,";
                    decimal ValorClase = this.DIM;
                    List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();
                    for (int i = 0; i <= NumClass; i++, ValorClase = ValorClase + rangeDAP)
                    {
                        REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                        foreach (FORMULARIO fr in project.FORMULARIO.Where(f => f.CODEST == st.CODEST))
                        {
                            if (i == NumClass)
                            {
                                rpCD.CLASE = "otros";
                                rpCD = lnBL.searchDiametricClass(Guid.Empty, fr.NROFORMULARIO, tipoClaseCbx.Text, ValorClase, -1, rpCD);
                            }
                            else
                            {
                                rpCD.CLASE = i + " - " + (i + rangeDAP);
                                rpCD = lnBL.searchDiametricClass(Guid.Empty, fr.NROFORMULARIO, tipoClaseCbx.Text, ValorClase, ValorClase + rangeDAP, rpCD);
                            }
                        }
                        rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                        if (rpCD.CONTEO > 0)
                        {
                            rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                            rpCD.VOLUMENCOMERCIAL = rpCD.VOLUMENCOMERCIAL / rpCD.CONTEO;
                            rpCD.VOLUMENTOTAL = rpCD.VOLUMENTOTAL / rpCD.CONTEO;
                        }
                        RowConteo += Decimal.Round(rpCD.CONTEO, 4) + ",";
                        RowAB += Decimal.Round(rpCD.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                        RowVolCom += Decimal.Round(rpCD.VOLUMENCOMERCIAL, 4).ToString().Replace(",", ".") + ",";
                        RowVolTot += Decimal.Round(rpCD.VOLUMENTOTAL, 4).ToString().Replace(",", ".") + ",";
                        totalConteo += rpCD.CONTEO;
                        totalAB += rpCD.AREABASAL;
                        totalVolCom += rpCD.VOLUMENCOMERCIAL;
                        totalVolTot += rpCD.VOLUMENTOTAL;
                        //Se realiza para los totales por clase de densidad,AB, vol
                        totalConteoClase[i] += rpCD.CONTEO;
                        totalABClase[i] += rpCD.AREABASAL;
                        totalVolComClase[i] += rpCD.VOLUMENCOMERCIAL;
                        totalVolTotClase[i] += rpCD.VOLUMENTOTAL;
                    }                                    //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                    //entonces ahora se lleva los valores de la especie y las clases diametricas
                    if (opcionCheck.Checked)
                    {
                        RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                        RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                        RowVolCom += Decimal.Round(totalVolCom, 4).ToString().Replace(",", ".") + ",";
                        RowVolTot += Decimal.Round(totalVolTot, 4).ToString().Replace(",", ".") + ",";
                        RowsData.Add(RowConteo);
                        RowsData.Add(RowAB);
                        RowsData.Add(RowVolCom);
                        RowsData.Add(RowVolTot);
                    }
                    else
                    {
                        if (totalConteo > 0)
                        {
                            RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                            RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                            RowVolCom += Decimal.Round(totalVolCom, 4).ToString().Replace(",", ".") + ",";
                            RowVolTot += Decimal.Round(totalVolTot, 4).ToString().Replace(",", ".") + ",";
                            RowsData.Add(RowConteo);
                            RowsData.Add(RowAB);
                            RowsData.Add(RowVolCom);
                            RowsData.Add(RowVolTot);
                        }
                    }
                    this.progressBar.Value++;

                }

                string RowTotalC = "TOTALES,Densidad,", RowTotalAB = " ,Area Basal,", RowTotalVolCom = " ,Volumen comercial,", RowTotalVolTot = " ,Volumen total,";
                foreach (decimal d in totalConteoClase)
                {
                    RowTotalC += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalABClase)
                {
                    RowTotalAB += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalVolComClase)
                {
                    RowTotalVolCom += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalVolTotClase)
                {
                    RowTotalVolTot += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                RowTotalC += Decimal.Round(totalConteoClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalAB += Decimal.Round(totalABClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalVolCom += Decimal.Round(totalVolComClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalVolTot += Decimal.Round(totalVolTotClase.Sum(), 4).ToString().Replace(",", ".") + ",";

                Column1 = new DataGridViewTextBoxColumn();
                Column1.HeaderText = "Porcentaje";
                Column1.Name = "Clase" + (nUd_NumClases.Value + 4);
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                DtgDatos.Columns.Add(Column1);
                int numCampos = 3;

                for (int i = 0; i < RowsData.Count; i = i + 4)
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

                    //Se arregla la fila que corresponde al volumen comercial
                    cadena = (string)RowsData[i + 2];
                    fila = cadena.Split(',');
                    total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                    p = 0;
                    if (totalConteoClase.Sum() > 0) p = (total / totalVolComClase.Sum()) * 100;
                    result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                    DtgDatos.Rows.Add(result.Split(','));

                    //Se arregla la fila que corresponde al volumen total
                    cadena = (string)RowsData[i + 3];
                    fila = cadena.Split(',');
                    total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                    p = 0;
                    if (totalConteoClase.Sum() > 0) p = (total / totalVolTotClase.Sum()) * 100;
                    result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                    DtgDatos.Rows.Add(result.Split(','));
                }
                DtgDatos.AutoResizeColumns();
                DtgDatos.Rows.Add(RowTotalC.Split(','));
                DtgDatos.Rows.Add(RowTotalAB.Split(','));
                DtgDatos.Rows.Add(RowTotalVolCom.Split(','));
                DtgDatos.Rows.Add(RowTotalVolTot.Split(','));
                DtgDatos.Refresh();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this.MdiParent;
                er.Show();
            }
        }

        private void reporteValorComercial()
        {
            try{
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
                decimal posClase = this.DIM;
                for (int i = 0; i < NumClass; i++)
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
                Column1.HeaderText = "Mayores a " + posClase;
                Column1.Name = "ClaseMayores";
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                DtgDatos.Columns.Add(Column1);
                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Column1.HeaderText = "Total";
                Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                DtgDatos.Columns.Add(Column1);

                SpeciesBL SpBL = new SpeciesBL(Program.ContextData);
                GroupBL groupBL = new GroupBL(Program.ContextData);
                InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
                decimal[] totalConteoClase = new decimal[NumClass + 1];
                decimal[] totalABClase = new decimal[NumClass + 1];
                decimal[] totalVolComClase = new decimal[NumClass + 1];
                decimal[] totalVolTotClase = new decimal[NumClass + 1];
                ArrayList RowsData = new ArrayList();

                List<GRUPOCOMERCIAL> ListGC = groupBL.GetGroups().ToList();
                this.progressBar.Value = 0;
                this.progressBar.Minimum = 0;
                this.progressBar.Maximum = ListGC.Count;

                foreach (GRUPOCOMERCIAL gc in ListGC)
                {
                    string RowConteo = "", RowAB = " ,Area Basal,", RowVolCom = " ,Volumen comercial,", RowVolTot = " ,Volumen total,";
                    decimal totalConteo = 0, totalAB = 0, totalVolCom = 0, totalVolTot = 0;
                    RowConteo += gc.DESCRIPGRUPO + ", Densidad,";
                    List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();
                    decimal ValorClase = this.DIM;
                    for (int i = 0; i <= NumClass; i++, ValorClase = ValorClase + rangeDAP)
                    {
                        REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                        foreach (ESPECIE sp in project.ESPECIE.Where(p => p.GRUPOCOM == gc.GRUPOCOM))
                        {
                            if (i == NumClass)
                            {
                                rpCD.CLASE = "otros";
                                rpCD = lnBL.searchDiametricClass(sp.CODESP, project.NROPROY, tipoClaseCbx.Text, ValorClase, -1, rpCD);
                            }
                            else
                            {
                                rpCD.CLASE = i + " - " + (i + rangeDAP);
                                rpCD = lnBL.searchDiametricClass(sp.CODESP, project.NROPROY, tipoClaseCbx.Text, ValorClase, ValorClase + rangeDAP, rpCD);
                            }
                        }
                        rpCD.PORCENTAJE = rpCD.TOTAL * 100;
                        if (rpCD.CONTEO > 0)
                        {
                            rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                            rpCD.VOLUMENCOMERCIAL = rpCD.VOLUMENCOMERCIAL/ rpCD.CONTEO;
                            rpCD.VOLUMENTOTAL = rpCD.VOLUMENTOTAL / rpCD.CONTEO;
                        }
                        RowConteo += Decimal.Round(rpCD.CONTEO, 4) + ",";
                        RowAB += Decimal.Round(rpCD.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                        RowVolCom += Decimal.Round(rpCD.VOLUMENCOMERCIAL, 4).ToString().Replace(",", ".") + ",";
                        RowVolTot += Decimal.Round(rpCD.VOLUMENTOTAL, 4).ToString().Replace(",", ".") + ",";
                        totalConteo += rpCD.CONTEO;
                        totalAB += rpCD.AREABASAL;
                        totalVolCom += rpCD.VOLUMENCOMERCIAL;
                        totalVolTot += rpCD.VOLUMENTOTAL;
                        //Se realiza para los totales por clase de densidad,AB, vol
                        totalConteoClase[i] += rpCD.CONTEO;
                        totalABClase[i] += rpCD.AREABASAL;
                        totalVolComClase[i] += rpCD.VOLUMENCOMERCIAL;
                        totalVolTotClase[i] += rpCD.VOLUMENTOTAL;
                    }                                    //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                    //entonces ahora se lleva los valores de la especie y las clases diametricas
                    if (opcionCheck.Checked)
                    {
                        RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                        RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                        RowVolCom += Decimal.Round(totalVolCom, 4).ToString().Replace(",", ".") + ",";
                        RowVolTot += Decimal.Round(totalVolTot, 4).ToString().Replace(",", ".") + ",";
                        RowsData.Add(RowConteo);
                        RowsData.Add(RowAB);
                        RowsData.Add(RowVolCom);
                        RowsData.Add(RowVolTot);
                    }
                    else
                    {
                        if (totalConteo > 0)
                        {
                            RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                            RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                            RowVolCom += Decimal.Round(totalVolCom, 4).ToString().Replace(",", ".") + ",";
                            RowVolTot += Decimal.Round(totalVolTot, 4).ToString().Replace(",", ".") + ",";
                            RowsData.Add(RowConteo);
                            RowsData.Add(RowAB);
                            RowsData.Add(RowVolCom);
                            RowsData.Add(RowVolTot);
                        }
                    }
                    this.progressBar.Value++;

                }

                string RowTotalC = "TOTALES,Densidad,", RowTotalAB = " ,Area Basal,", RowTotalVolCom = " ,Volumen comercial,", RowTotalVolTot = " ,Volumen comercial,";
                foreach (decimal d in totalConteoClase)
                {
                    RowTotalC += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalABClase)
                {
                    RowTotalAB += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalVolComClase)
                {
                    RowTotalVolCom += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalVolTotClase)
                {
                    RowTotalVolTot += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }

                RowTotalC += Decimal.Round(totalConteoClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalAB += Decimal.Round(totalABClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalVolCom += Decimal.Round(totalVolComClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalVolTot += Decimal.Round(totalVolTotClase.Sum(), 4).ToString().Replace(",", ".") + ",";

                Column1 = new DataGridViewTextBoxColumn();
                Column1.HeaderText = "Porcentaje";
                Column1.Name = "Clase" + (nUd_NumClases.Value + 4);
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                DtgDatos.Columns.Add(Column1);
                int numCampos = 3;

                for (int i = 0; i < RowsData.Count; i = i + 4)
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

                    //Se arregla la fila que corresponde al volumen comercial
                    cadena = (string)RowsData[i + 2];
                    fila = cadena.Split(',');
                    total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                    p = 0;
                    if (totalConteoClase.Sum() > 0) p = (total / totalVolComClase.Sum()) * 100;
                    result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                    DtgDatos.Rows.Add(result.Split(','));

                    //Se arregla la fila que corresponde al volumen total
                    cadena = (string)RowsData[i + 3];
                    fila = cadena.Split(',');
                    total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                    p = 0;
                    if (totalConteoClase.Sum() > 0) p = (total / totalVolTotClase.Sum()) * 100;
                    result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                    DtgDatos.Rows.Add(result.Split(','));
                }
                DtgDatos.AutoResizeColumns();
                DtgDatos.Rows.Add(RowTotalC.Split(','));
                DtgDatos.Rows.Add(RowTotalAB.Split(','));
                DtgDatos.Rows.Add(RowTotalVolCom.Split(','));
                DtgDatos.Rows.Add(RowTotalVolTot.Split(','));
                DtgDatos.Refresh();         
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this.MdiParent;
                er.Show();
            }
        }

        private void reporteGeneral()
        {
            try
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
                decimal posClase = this.DIM;
                for (int i = 0; i < NumClass; i++)
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
                Column1.HeaderText = "Mayores a " + posClase;
                Column1.Name = "ClaseMayores";
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                DtgDatos.Columns.Add(Column1);

                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Column1.HeaderText = "Total";
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                Column1.Name = "Clase" + (nUd_NumClases.Value + 3);
                DtgDatos.Columns.Add(Column1);

                SpeciesBL SpBL = new SpeciesBL(Program.ContextData);
                InventoryLineBL lnBL = new InventoryLineBL(Program.ContextData);
                decimal[] totalConteoClase = new decimal[NumClass + 1];
                decimal[] totalABClase = new decimal[NumClass + 1];
                decimal[] totalVolComClase = new decimal[NumClass + 1];
                decimal[] totalVolTotClase = new decimal[NumClass + 1];
                ArrayList RowsData = new ArrayList();

                this.progressBar.Value = 0;
                this.progressBar.Minimum = 0;
                this.progressBar.Maximum = project.ESPECIE.Count;
                foreach (ESPECIE sp in project.ESPECIE)
                {
                    List<REPORTECLASESDIAMETRICAS> resultReportCD = new List<REPORTECLASESDIAMETRICAS>();

                    decimal totalConteo = 0, totalAB = 0, totalVolCom = 0, totalVolTot = 0;
                    string RowConteo = "", RowAB = " ,,,Area Basal,", RowVolCom = " ,,,Volumen comercial,", RowVolTot = " ,,,Volumen total,";

                    string gEco = "";
                    if (sp.GRUPOECOLOGICO == "NT") gEco = "No Tolerante";
                    if (sp.GRUPOECOLOGICO == "TL") gEco = "Tolerante";
                    RowConteo += RowConteo + sp.NOMCOMUN.Replace(',', ' ') + " - " + sp.NOMCIENTIFICO.Replace(',', ' ') + "," + gEco + "," + sp.GRUPOCOMERCIAL.DESCRIPGRUPO + ", Densidad,";
                    decimal ValorClase = this.DIM;
                    for (int i = 0; i <= NumClass; i++)
                    {
                        REPORTECLASESDIAMETRICAS rpCD = new REPORTECLASESDIAMETRICAS();
                        if (i == NumClass)
                        {
                            rpCD.CLASE = "otros";
                            rpCD = lnBL.searchDiametricClass(sp.CODESP, project.NROPROY, tipoClaseCbx.Text, ValorClase, -1, rpCD);
                        }
                        else
                        {
                            rpCD.CLASE = i + " - " + (i + rangeDAP);
                            rpCD = lnBL.searchDiametricClass(sp.CODESP, project.NROPROY, tipoClaseCbx.Text, ValorClase, ValorClase + rangeDAP, rpCD);
                        }

                        if (rpCD.CONTEO > 0)
                        {
                            rpCD.AREABASAL = rpCD.AREABASAL / rpCD.CONTEO;
                            rpCD.VOLUMENCOMERCIAL = rpCD.VOLUMENCOMERCIAL / rpCD.CONTEO;
                            rpCD.VOLUMENTOTAL = rpCD.VOLUMENTOTAL / rpCD.CONTEO;
                        }

                        RowConteo += Decimal.Round(rpCD.CONTEO, 4) + ",";
                        RowAB += Decimal.Round(rpCD.AREABASAL, 4).ToString().Replace(",", ".") + ",";
                        RowVolCom += Decimal.Round(rpCD.VOLUMENCOMERCIAL, 4).ToString().Replace(",", ".") + ",";
                        RowVolTot += Decimal.Round(rpCD.VOLUMENTOTAL, 4).ToString().Replace(",", ".") + ",";
                        totalConteo += rpCD.CONTEO;
                        totalAB += rpCD.AREABASAL;
                        totalVolCom += rpCD.VOLUMENCOMERCIAL;
                        totalVolTot += rpCD.VOLUMENTOTAL;

                        //Se realiza para los totales por clase de densidad,AB, vol
                        totalConteoClase[i] += rpCD.CONTEO;
                        totalABClase[i] += rpCD.AREABASAL;
                        totalVolComClase[i] += rpCD.VOLUMENCOMERCIAL;
                        totalVolTotClase[i] += rpCD.VOLUMENTOTAL;
                        ValorClase = ValorClase + rangeDAP;
                    }
                    if (opcionCheck.Checked)
                    {
                        RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                        RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                        RowVolCom += Decimal.Round(totalVolCom, 4).ToString().Replace(",", ".") + ",";
                        RowVolTot += Decimal.Round(totalVolTot, 4).ToString().Replace(",", ".") + ",";
                        RowsData.Add(RowConteo);
                        RowsData.Add(RowAB);
                        RowsData.Add(RowVolCom);
                        RowsData.Add(RowVolTot);
                    }
                    else
                    {
                        if (totalConteo > 0)
                        {
                            RowConteo += Decimal.Round(totalConteo, 4).ToString().Replace(",", ".") + ",";
                            RowAB += Decimal.Round(totalAB, 4).ToString().Replace(",", ".") + ",";
                            RowVolCom += Decimal.Round(totalVolCom, 4).ToString().Replace(",", ".") + ",";
                            RowVolTot += Decimal.Round(totalVolTot, 4).ToString().Replace(",", ".") + ",";
                            RowsData.Add(RowConteo);
                            RowsData.Add(RowAB);
                            RowsData.Add(RowVolCom);
                            RowsData.Add(RowVolTot);
                        }
                    }
                    this.progressBar.Value++;
                }
                //Se hace fuera del for porque en este for se lleva todos los valores de esa especie para cada clase diametrica y todas las variables
                //entonces ahora se lleva los valores de la especie y las clases diametricas

                string RowTotalC = ",TOTALES,,Densidad,", RowTotalAB = " ,,,Area Basal,", RowTotalVolCom = " ,,,Volumen comercial,", RowTotalVolTot = " ,,,Volumen total,";
                foreach (decimal d in totalConteoClase)
                {
                    RowTotalC += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalABClase)
                {
                    RowTotalAB += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalVolComClase)
                {
                    RowTotalVolCom += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }
                foreach (decimal d in totalVolTotClase)
                {
                    RowTotalVolTot += decimal.Round(d, 4).ToString().Replace(",", ".") + ",";
                }

                RowTotalC += Decimal.Round(totalConteoClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalAB += Decimal.Round(totalABClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalVolCom += Decimal.Round(totalVolComClase.Sum(), 4).ToString().Replace(",", ".") + ",";
                RowTotalVolTot += Decimal.Round(totalVolTotClase.Sum(), 4).ToString().Replace(",", ".") + ",";

                Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                Column1.HeaderText = "Porcentaje";
                Column1.Name = "Clase" + (nUd_NumClases.Value + 4);
                Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
                DtgDatos.Columns.Add(Column1);

                int numCampos = 5;

                for (int i = 0; i < RowsData.Count; i = i + 4)
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

                    //Se arregla la fila que corresponde al volumen comercial
                    cadena = (string)RowsData[i + 2];
                    fila = cadena.Split(',');
                    total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                    p = 0;
                    if (totalConteoClase.Sum() > 0) p = (total / totalVolComClase.Sum()) * 100;
                    result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                    DtgDatos.Rows.Add(result.Split(','));

                    //Se arregla la fila que corresponde al volumen total
                    cadena = (string)RowsData[i + 3];
                    fila = cadena.Split(',');
                    total = decimal.Parse(fila[NumClass + numCampos].Replace('.', ','));
                    p = 0;
                    if (totalConteoClase.Sum() > 0) p = (total / totalVolTotClase.Sum()) * 100;
                    result = cadena + decimal.Round(p, 2).ToString().Replace(',', '.') + "";
                    DtgDatos.Rows.Add(result.Split(','));
                }
                DtgDatos.AutoResizeColumns();
                DtgDatos.Rows.Add(RowTotalC.Split(','));
                DtgDatos.Rows.Add(RowTotalAB.Split(','));
                DtgDatos.Rows.Add(RowTotalVolCom.Split(','));
                DtgDatos.Rows.Add(RowTotalVolTot.Split(','));
                DtgDatos.Refresh();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this.MdiParent;
                er.Show();
            }
        }

        private void exportarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtgDatos.Rows.Count < 1)
                {
                    this.button1_Click(sender, e);
                }
                ImporExportExcel exportDiametricClass = new ImporExportExcel();
                exportDiametricClass.exportarExcelDiametricClass(progressBar, this.DtgDatos, tipoClaseCbx.Text, NumClass);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
        }
    }
}
