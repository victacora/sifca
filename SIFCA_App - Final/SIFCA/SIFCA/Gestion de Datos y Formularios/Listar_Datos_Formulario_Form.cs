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

namespace SIFCA
{
    public partial class Listar_Datos_Formulario_Form : Form
    {
        private SpeciesBL specie;
        private QualityBL quality;
        private StateBL state;
        private NonTimberLineBL notimberLine;
        private InventoryLineBL  inventoryLine;
        private RegenerationLineBL  regenerationLine;
        private FORMULARIO form;

        public Listar_Datos_Formulario_Form(FORMULARIO form, int selectIndex)
        {
            InitializeComponent();
            specie = new SpeciesBL(Program.ContextData);
            quality = new QualityBL(Program.ContextData);
            state = new StateBL(Program.ContextData);
            notimberLine = new NonTimberLineBL(Program.ContextData);
            inventoryLine = new InventoryLineBL (Program.ContextData);
            regenerationLine = new RegenerationLineBL(Program.ContextData);

            this.form = form;
            especieBS.DataSource = specie.GetSpecies();
            calidadBS.DataSource = quality.GetQualities();
            estadoSanitarioBS.DataSource = state.GetStates();

            lineaInventarioBS.DataSource = form.LINEAINVENTARIO.Count == 0 ? new List<LINEAINVENTARIO>() : form.LINEAINVENTARIO;
            lineaInventarioDGW.DataSource = lineaInventarioBS;

            regeneracionBS.DataSource = form.LINEAREGENERACION.Count == 0 ? new List<LINEAREGENERACION>() : form.LINEAREGENERACION;
            regeneracionDGW.DataSource = regeneracionBS;

            noMaderablesBS.DataSource = form.LINEANOMADERABLES.Count == 0 ? new List<LINEANOMADERABLES>() : form.LINEANOMADERABLES; 
            noMaderablesDGW.DataSource = noMaderablesBS;
            
            criterioInvCbx.SelectedIndex = 0;
            criterioNoMaderCbx.SelectedIndex = 0;
            criterioRegenCbx.SelectedIndex = 0;
            lineasTab.SelectedIndex = selectIndex;
        }
        
        private void busquedaInvTxt_TextChanged(object sender, EventArgs e)
        {
            if (busquedaInvTxt.Text != "")
            {
                string criteria = criterioInvCbx.SelectedItem.ToString();
                lineaInventarioBS.DataSource = inventoryLine.SearchLine(busquedaInvTxt.Text, criteria,form);
                lineaInventarioDGW.DataSource = lineaInventarioBS;
                lineaInventarioDGW.Refresh();
            }
            else
            {
                lineaInventarioBS.DataSource = form.LINEAINVENTARIO;
                lineaInventarioDGW.DataSource = lineaInventarioBS;
                lineaInventarioDGW.Refresh();
            }
        }

        private void busquedaNoMaderTxt_TextChanged(object sender, EventArgs e)
        {
            if (busquedaNoMaderTxt.Text != "")
            {
                string criteria = criterioNoMaderCbx.SelectedItem.ToString();
                noMaderablesBS.DataSource = notimberLine.SearchLine(busquedaNoMaderTxt.Text, criteria, form);
                noMaderablesDGW.DataSource = noMaderablesBS;
                noMaderablesDGW.Refresh();
            }
            else
            {
                noMaderablesBS.DataSource = form.LINEANOMADERABLES;
                noMaderablesDGW.DataSource = noMaderablesBS;
                noMaderablesDGW.Refresh();
            }
        }

        private void busquedaRegenTxt_TextChanged(object sender, EventArgs e)
        {
            if (busquedaRegenTxt.Text != "")
            {
                string criteria = criterioRegenCbx.SelectedItem.ToString();
                regeneracionBS.DataSource = regenerationLine.SearchLine(busquedaRegenTxt.Text, criteria, form);
                regeneracionDGW.DataSource = regeneracionBS;
                regeneracionDGW.Refresh();
            }
            else
            {
                regeneracionBS.DataSource = form.LINEAREGENERACION;
                regeneracionDGW.DataSource = regeneracionBS;
                regeneracionDGW.Refresh();
            }
        }
        
        private void lineaInventarioDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (lineaInventarioBS.Count != 0)
            {
                int count = 1;
                foreach (DataGridViewRow row in lineaInventarioDGW.Rows)
                {
                    row.Cells["NumeroMaderables"].Value = count;
                    count++;
                }
            }
        }

        private void regenracionDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (regeneracionBS.Count != 0)
            {
                int count = 1;
                foreach (DataGridViewRow row in regeneracionDGW.Rows)
                {
                    row.Cells["NumeroRegen"].Value = count;
                    count++;
                }
            }
        }

        private void noMaderablesDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (noMaderablesBS.Count != 0)
            {
                int count = 1;
                foreach (DataGridViewRow row in noMaderablesDGW.Rows)
                {
                    row.Cells["NumeroNoMade"].Value = count;
                    count++;
                    if (row.Cells["codigo"].Value != null)
                    {
                        LINEANOMADERABLES currentLine = notimberLine.GetNonTimberLine((Guid)row.Cells["codigo"].Value);
                        string usos = "";
                        int countUseType = 0;
                        List<TIPODEUSO> types = currentLine.TIPODEUSO.ToList();
                        foreach (TIPODEUSO uso in types)
                        {
                            usos += uso.DESCRIPCION;
                            countUseType++;
                            if (countUseType != types.Count)
                            {
                                usos += " - ";
                            }
                        }
                        row.Cells["usos"].Value = usos;
                    }
                }
            }
        }

        private void exportarExcelBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            ProjectBL pyBl = new ProjectBL(Program.ContextData);
            FormBL formBl = new FormBL(Program.ContextData);
            InventoryLineBL lineInvBl = new InventoryLineBL(Program.ContextData);

            PROYECTO project = (PROYECTO)Program.Cache.Get("project");
            if (project != null)
            {

                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {

                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();

                    PROYECTO py = pyBl.GetProject(project.NROPROY);

                    Microsoft.Office.Interop.Excel.Worksheet hoja_regeneracion;
                    hoja_regeneracion = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    hoja_regeneracion.Name = "Regeneracion";
                    hoja_regeneracion.Cells[1, 1] = "Lugar";
                    hoja_regeneracion.Cells[1, 2] = "Responsable";                    
                    hoja_regeneracion.Cells[1, 3] = "Coor X";
                    hoja_regeneracion.Cells[1, 4] = "Coor Y";
                    hoja_regeneracion.Cells[1, 5] = "Linea";
                    hoja_regeneracion.Cells[1, 6] = "Parcela";
                    hoja_regeneracion.Cells[1, 7] = "Estrato";

                    hoja_regeneracion.Cells[1, 8] = "Nombre comun";
                    hoja_regeneracion.Cells[1, 9] = "Nombre cientifico";
                    hoja_regeneracion.Cells[1, 10] = "Brinzal";
                    hoja_regeneracion.Cells[1, 11] = "Latizal";
                    hoja_regeneracion.get_Range("A1", "O1").Font.Bold = true;
                    hoja_regeneracion.get_Range("A1", "O1").VerticalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;


                    int j = 2;
                    hoja_regeneracion.Cells[j, 1] = py.LUGAR.ToString();
                    hoja_regeneracion.Cells[j, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;                        
                    hoja_regeneracion.Cells[j, 3] = form.COORDENADAX;
                    hoja_regeneracion.Cells[j, 4] = form.COORDENADAY;
                    hoja_regeneracion.Cells[j, 5] = form.LINEA.ToString();
                    hoja_regeneracion.Cells[j, 6] = form.PARCELA.ToString();
                    hoja_regeneracion.Cells[j, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                    foreach (LINEAREGENERACION lineInv in form.LINEAREGENERACION)
                    {
                        hoja_regeneracion.Cells[j, 1] = py.LUGAR.ToString();
                        hoja_regeneracion.Cells[j, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;
                        hoja_regeneracion.Cells[j, 3] = form.COORDENADAX;
                        hoja_regeneracion.Cells[j, 4] = form.COORDENADAY;
                        hoja_regeneracion.Cells[j, 5] = form.LINEA.ToString();
                        hoja_regeneracion.Cells[j, 6] = form.PARCELA.ToString();
                        hoja_regeneracion.Cells[j, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                        hoja_regeneracion.Cells[j, 8] = lineInv.ESPECIE.NOMCOMUN;
                        hoja_regeneracion.Cells[j, 9] = lineInv.ESPECIE.NOMCIENTIFICO;

                        hoja_regeneracion.Cells[j, 10] = lineInv.BRINZAL;
                        hoja_regeneracion.Cells[j, 11] = lineInv.LATIZAL;
                        j++;
                    }
                    if (form.LINEAREGENERACION.Count == 0)
                    {
                        j++;
                    }

                    libros_trabajo.Worksheets.Add(hoja_regeneracion);


                    Microsoft.Office.Interop.Excel.Worksheet hoja_nomaderables;
                    hoja_nomaderables = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    hoja_nomaderables.Name = "No maderable";
                    hoja_nomaderables.Cells[1, 1] = "Lugar";
                    hoja_nomaderables.Cells[1, 2] = "Responsable";                    
                    hoja_nomaderables.Cells[1, 3] = "Coor X";
                    hoja_nomaderables.Cells[1, 4] = "Coor Y";
                    hoja_nomaderables.Cells[1, 5] = "Linea";
                    hoja_nomaderables.Cells[1, 6] = "Parcela";
                    hoja_nomaderables.Cells[1, 7] = "Estrato";

                    hoja_nomaderables.Cells[1, 8] = "Observaciones";
                    TypeUseBL typeUseBl = new TypeUseBL(Program.ContextData);
                    int cont=9;
                    foreach(TIPODEUSO type in typeUseBl.GetTypeUse()){
                        hoja_nomaderables.Cells[1, cont] = type.DESCRIPCION.ToString();
                        cont++;
                    }
                    


                    hoja_nomaderables.get_Range("A1", "O1").Font.Bold = true;
                    hoja_nomaderables.get_Range("A1", "O1").VerticalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;


                    int k = 2;
                    hoja_nomaderables.Cells[k, 1] = py.LUGAR.ToString();
                    hoja_nomaderables.Cells[k, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;                        
                    hoja_nomaderables.Cells[k, 3] = form.COORDENADAX;
                    hoja_nomaderables.Cells[k, 4] = form.COORDENADAY;
                    hoja_nomaderables.Cells[k, 5] = form.LINEA.ToString();
                    hoja_nomaderables.Cells[k, 6] = form.PARCELA.ToString();
                    hoja_nomaderables.Cells[k, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                    foreach (LINEANOMADERABLES lineInv in form.LINEANOMADERABLES)
                    {                            
                        hoja_nomaderables.Cells[k, 1] = py.LUGAR.ToString();
                        hoja_nomaderables.Cells[k, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;
                        hoja_nomaderables.Cells[k, 3] = form.COORDENADAX;
                        hoja_nomaderables.Cells[k, 4] = form.COORDENADAY;
                        hoja_nomaderables.Cells[k, 5] = form.LINEA.ToString();
                        hoja_nomaderables.Cells[k, 6] = form.PARCELA.ToString();
                        hoja_nomaderables.Cells[k, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();
                        hoja_nomaderables.Cells[k, 8] = lineInv.OBSERVACIONES.ToString();
                        string usos = "";
                            
                        int n = 9;
                        foreach(TIPODEUSO t in typeUseBl.GetTypeUse()){
                            foreach (TIPODEUSO use in lineInv.TIPODEUSO)
                            {
                                if (use.NOMBRETIPOUSO.Equals(t.NOMBRETIPOUSO))
                                {
                                    hoja_nomaderables.Cells[k, n] = "1";
                                    break;
                                }
                                else
                                {
                                    hoja_nomaderables.Cells[k, n] = "0";
                                }                                 
                            }
                            n++;
                        }
                        k++;
                    }
                    if (form.LINEANOMADERABLES.Count == 0)
                    {
                        k++;
                    } 
                        
                    libros_trabajo.Worksheets.Add(hoja_nomaderables);
                    
                    
                    Microsoft.Office.Interop.Excel.Worksheet hoja_maderable;
                    hoja_maderable = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    
                    QualityBL qualityBl = new QualityBL(Program.ContextData);

                    hoja_maderable.Name = "Maderable";
                    hoja_maderable.Cells[1, 1] = "Convenciones calidad";
                    hoja_maderable.Cells[2, 1] = "Código";
                    hoja_maderable.Cells[2, 2] = "Significado";
                    int i = 3;
                    foreach(CALIDAD quality in qualityBl.GetQualities())
                    {
                        hoja_maderable.Cells[i, 1] = quality.CODCALIDAD;
                        hoja_maderable.Cells[i, 2] = quality.DESCRIPCALIDAD;
                        i++;
                    }
                    i += 2;
                    
                    hoja_maderable.Cells[i, 1] = "Lugar";
                    hoja_maderable.Cells[i, 2] = "Responsable";                    
                    hoja_maderable.Cells[i, 3] = "Coor X";
                    hoja_maderable.Cells[i, 4] = "Coor Y";
                    hoja_maderable.Cells[i, 5] = "Linea";
                    hoja_maderable.Cells[i, 6] = "Parcela";
                    hoja_maderable.Cells[i, 7] = "Estrato";

                    hoja_maderable.Cells[i, 8] = "Numero de arbol";
                    hoja_maderable.Cells[i, 9] = "Nombre comun";
                    hoja_maderable.Cells[i, 10] = "Nombre cientifico";
                    hoja_maderable.Cells[i, 11] = "Calidad";
                    hoja_maderable.Cells[i, 12] = "DAP";
                    hoja_maderable.Cells[i, 13] = "CAP";
                    hoja_maderable.Cells[i, 14] = "Altura Comercial";
                    hoja_maderable.Cells[i, 15] = "Altura Total";
                    hoja_maderable.Cells[i, 16] = "Area basal";
                    hoja_maderable.Cells[i, 17] = "Volumen comercial";
                    hoja_maderable.Cells[i, 18] = "Volumen total";

                    hoja_maderable.get_Range("A1", "O1").Font.Bold = true;
                    hoja_maderable.get_Range("A1", "O1").VerticalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;


                    i++;
 
                    hoja_maderable.Cells[i, 1] = py.LUGAR.ToString();
                    hoja_maderable.Cells[i, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;
                        
                    hoja_maderable.Cells[i, 3] = form.COORDENADAX;
                    hoja_maderable.Cells[i, 4] = form.COORDENADAY;
                    hoja_maderable.Cells[i, 5] = form.LINEA.ToString();
                    hoja_maderable.Cells[i, 6] = form.PARCELA.ToString();
                    hoja_maderable.Cells[i, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                    foreach (LINEAINVENTARIO lineInv in form.LINEAINVENTARIO)
                    {
                        hoja_maderable.Cells[i, 1] = py.LUGAR.ToString();
                        hoja_maderable.Cells[i, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;

                        hoja_maderable.Cells[i, 3] = form.COORDENADAX.ToString();
                        hoja_maderable.Cells[i, 4] = form.COORDENADAY.ToString();
                        hoja_maderable.Cells[i, 5] = form.LINEA.ToString();
                        hoja_maderable.Cells[i, 6] = form.PARCELA.ToString();
                        hoja_maderable.Cells[i, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                        hoja_maderable.Cells[i, 8] = lineInv.NROARB.ToString();
                        hoja_maderable.Cells[i, 9] = lineInv.ESPECIE.NOMCOMUN.ToString();
                        hoja_maderable.Cells[i, 10] = lineInv.ESPECIE.NOMCIENTIFICO.ToString();
                        hoja_maderable.Cells[i, 11] = lineInv.CALIDAD.CODCALIDAD.ToString();
                        hoja_maderable.Cells[i, 12] = lineInv.DAP;
                        hoja_maderable.Cells[i, 13] = lineInv.CAP;
                        hoja_maderable.Cells[i, 14] = lineInv.ALTCOMER_M;
                        hoja_maderable.Cells[i, 15] = lineInv.ALTTOT_M;
                        hoja_maderable.Cells[i, 16] = lineInv.AREABASAL;
                        hoja_maderable.Cells[i, 17] = lineInv.VOLCOM;
                        hoja_maderable.Cells[i, 18] = lineInv.VOLTOT;
                        i++;
                    }
                    if (form.LINEAINVENTARIO.Count == 0)i++;                     
                    libros_trabajo.Worksheets.Add(hoja_maderable);
                    
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }

            }
            else MessageBox.Show("No existe un proyecto abierto dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
        }

        private void cambiarOpcionBusqueda(object sender, EventArgs e)
        {
            if (nombreCientInvRbtn.Checked)
            {
                nombreComunInvRbtn.Checked = false;
                especieBS.DataSource = specie.GetSpecies().OrderBy(esp => esp.NOMCIENTIFICO); 
                DataGridViewComboBoxColumn especieCbx = (DataGridViewComboBoxColumn)lineaInventarioDGW.Columns["CODESPINV"];
                especieCbx.DataSource = especieBS;
                especieCbx.DisplayMember = "NOMCIENTIFICO";
                especieCbx.ValueMember = "CODESP";
                lineaInventarioDGW.Refresh();
            }
            else
            {
                nombreCientInvRbtn.Checked = false;
                especieBS.DataSource = specie.GetSpecies().OrderBy(esp => esp.NOMCOMUN); ;
                DataGridViewComboBoxColumn especieCbx = (DataGridViewComboBoxColumn)lineaInventarioDGW.Columns["CODESPINV"];
                especieCbx.DataSource = especieBS;
                especieCbx.DisplayMember = "NOMCOMUN";
                especieCbx.ValueMember = "CODESP";
                lineaInventarioDGW.Refresh();
            }
        }

        private void cambiarOpcionBusquedaRegen(object sender, EventArgs e)
        {
            if (nombreCientRegenRbtn.Checked)
            {
                nombreComunRegenRbtn.Checked = false;
                especieBS.DataSource = specie.GetSpecies().OrderBy(esp => esp.NOMCIENTIFICO);
                DataGridViewComboBoxColumn especieRegenCbx = (DataGridViewComboBoxColumn)regeneracionDGW .Columns["CODESP"];
                especieRegenCbx.DataSource = especieBS;
                especieRegenCbx.DisplayMember = "NOMCIENTIFICO";
                especieRegenCbx.ValueMember = "CODESP";
                regeneracionDGW.Refresh();
            }
            else
            {
                nombreCientRegenRbtn.Checked = false;
                especieBS.DataSource = specie.GetSpecies().OrderBy(esp => esp.NOMCOMUN);
                DataGridViewComboBoxColumn especieRegenCbx = (DataGridViewComboBoxColumn)regeneracionDGW.Columns["CODESP"];
                especieRegenCbx.DataSource = especieBS;
                especieRegenCbx.DisplayMember = "NOMCOMUN";
                especieRegenCbx.ValueMember = "CODESP";
                regeneracionDGW.Refresh();
            }
        }
    }
}
