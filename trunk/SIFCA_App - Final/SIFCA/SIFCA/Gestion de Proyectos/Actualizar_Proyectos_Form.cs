using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;
using SIFCA_DAL;
using System.Runtime.Caching;
using SIFCA.Gestion_Configuracion;

namespace SIFCA
{
   
    public partial class Actualizar_Proyectos_Form : Form
    {
 
        private ProjectBL project;
        private FormBL form;
        private TypeSampleDesignBl typeExample;
        private ObjectiveInventoryBL objetiveInventory;
        private StratumBL stratum;
        private SpeciesBL species;
        private FormulateBL formulateBL;
        private bool enableSpeciesList=false;
        private bool enableStratumsList=false;
        private bool enableProjectList = false;
        private bool modificate = false;

        public Actualizar_Proyectos_Form()
        {
            try
            {
                InitializeComponent();
                this.ControlBox = false;
                project = new ProjectBL(Program.ContextData);
                typeExample = new TypeSampleDesignBl(Program.ContextData);
                objetiveInventory = new ObjectiveInventoryBL(Program.ContextData);
                stratum = new StratumBL(Program.ContextData);
                species = new SpeciesBL(Program.ContextData);
                form = new FormBL(Program.ContextData);
                formulateBL = new FormulateBL(Program.ContextData);

                PROYECTO p = (PROYECTO)Program.Cache.Get("project");

                proyectoBS.DataSource = p;

                proyectosBS.DataSource = project.GetProjects(p);
                proyectoDGW.DataSource = proyectosBS;

                objetivoInventarioBS.DataSource = objetiveInventory.GetObjectiveInventories();
                tipoObjetivoCbx.DataSource = objetivoInventarioBS;
                List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
                data.Add(new KeyValuePair<string, string>("IN", "Independiente"));
                data.Add(new KeyValuePair<string, string>("CR", "Contenedor"));
                TipoProyectoCbx.DataSource = data;
                TipoProyectoCbx.DisplayMember = "Value";
                TipoProyectoCbx.ValueMember = "Key";
                TipoProyectoCbx.SelectedValue = p.TIPOPROYECTO;

                criterioCbx.SelectedIndex = 0;
                tipoDisenoBS.DataSource = typeExample.GetTypeSampleDesignList();
                tipoDisenoCbx.DataSource = tipoDisenoBS;

                especieBS.DataSource = species.GetSpecies();
                especiesDGW.DataSource = especieBS;

                formulariosBS.DataSource = p.FORMULARIO;
                formulariosDGW.DataSource = formulariosBS;

                //formulaBS.DataSource = formulateBL.GetFormulates();
                //formularComboBox.DataSource = formulaBS;
                formularComboBox.DataSource = formulateBL.GetFormulates();
                formularComboBox.SelectedValue = p.NROFORMULA;

                //formularComboBox.SelectedItem = p.FORMULA;
                expresionTxt.Text = p.FORMULA.EXPRESION;

                estratoBS.DataSource = stratum.GetStratums();
                estratoDGW.DataSource = estratoBS;

                numeroEtapasTxt.Text = p.ETAPA.ToString();
                
                confianzaTxt.Text = p.CONFIANZA.ToString();                
                tamParcelaTxt.Text = p.TAMANO.ToString();
                numeroParcelasTxt.Text = p.NUMEROPARCELAS.ToString();
                numeroParcelasMuestraTxt.Text = p.NUMEROPARCELASAMUESTREAR.ToString();
                limiteInfTxt.Text = p.LIMITINFDAP.ToString();
                intMuestreoTxt.Text = p.INTMUE.ToString();
                AreaTotalTxt.Text = p.SUPTOT.ToString();
                areaMuestrearTxt.Text = p.SUPMUE.ToString();
                areaFustalesTxt.Text = p.AREAFUSTALESPORPARCELA.ToString();
                factorFormaTxt.Text = p.FACTORDEFORMA.ToString();

                this.modificate = false;
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void crearProyectoTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Graphics g;
                String sText;
                float iX;
                float iY;
                SizeF sizeText;
                TabControl ctlTab;
                ctlTab = (TabControl)sender;
                g = e.Graphics;
                sText = ctlTab.TabPages[e.Index].Text;
                sizeText = g.MeasureString(sText, ctlTab.Font);
                iX = e.Bounds.Left + 6;
                iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;
                g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY);
                if (e.Index == 2) this.modificate = true;
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        //TODO:arreglar la navegacion, y sehabilitar los click en los tab para que unicamente funcione la navegacion
        private void ActualizarProyectoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = false;

                if (lugarTxt.Text == "")
                {
                    controladorErrores.SetError(lugarTxt, "El campo lugar es requerido.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(tamParcelaTxt.Text) <= 0)
                {
                    controladorErrores.SetError(lugarTxt, "El tamaño de la parcela debe ser mayor que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(numeroParcelasMuestraTxt.Text) <= 0)
                {
                    controladorErrores.SetError(numeroParcelasMuestraTxt, "El numero de parcelas a muestrea debe ser mayor que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(numeroParcelasTxt.Text) <= 0)
                {
                    controladorErrores.SetError(numeroParcelasTxt, "El numero total de parcelas debe ser mayor que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(limiteInfTxt.Text) < 0)
                {
                    controladorErrores.SetError(limiteInfTxt, "El limite inferior A.P. debe ser mayor o igual que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(intMuestreoTxt.Text) <= 0)
                {
                    controladorErrores.SetError(intMuestreoTxt, "La intensidad de muestreo debe ser mayor que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(AreaTotalTxt.Text) <= 0)
                {
                    controladorErrores.SetError(AreaTotalTxt, "El area muestreada debe ser mayor que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(areaFustalesTxt.Text) < 0)
                {
                    controladorErrores.SetError(areaFustalesTxt, "El Area de los Fustales debe ser mayor que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(factorFormaTxt.Text) <= 0)
                {
                    controladorErrores.SetError(factorFormaTxt, "El Factor de Forma debe ser mayor que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(numeroEtapasTxt.Text) < 0)
                {
                    controladorErrores.SetError(numeroEtapasTxt, "El numero de Etapas debe ser mayor o igual que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (decimal.Parse(confianzaTxt.Text) < 0)
                {
                    controladorErrores.SetError(confianzaTxt, "La confianza asociada al proyecto debe ser mayor que cero.");
                    actualizarProyectoTab.SelectedIndex = 0;
                    error = true;
                }
                if (numeroParcelasTxt.Text != "" && numeroParcelasMuestraTxt.Text != "")
                {
                    if (decimal.Parse(numeroParcelasTxt.Text) < decimal.Parse(numeroParcelasMuestraTxt.Text))
                    {
                        controladorErrores.SetError(numeroParcelasMuestraTxt, "El numero de parcelas a muestrear debe ser menor o igual que el numero total de parcelas.");
                        actualizarProyectoTab.SelectedIndex = 0;
                        error = true;
                    }
                }
                if (error) return;

                if (error) return;

                controladorErrores.Clear();
                PROYECTO p = (PROYECTO)proyectoBS.Current;
                if (p.ESPECIE.Count > 0)
                {
                    TIPODISENOMUESTRAL tipoDiseno = (TIPODISENOMUESTRAL)tipoDisenoCbx.SelectedItem;
                    if (tipoDiseno.DESCRIPTIPODISEMUEST == "Diseño estratificado" && !(p.LISTADODEESTRATOS.Count > 0))
                    {
                        MessageBox.Show("No se ha seleccionado ningun estrato para el proyecto.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (p.NOMTIPODISEMUEST == "ES")
                        {
                            if (!this.validateStratumWeight())
                            {
                                MessageBox.Show("Pesos de los estratos o tamaño incorrectos.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }                    
                    if (int.Parse(numeroParcelasMuestraTxt.Text) > int.Parse(numeroParcelasTxt.Text))
                    {
                        MessageBox.Show("El número de parcelas a muestrear no puede ser mayor al número de parcelas.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    p.LUGAR = lugarTxt.Text;
                    p.DESCRIPCION = DescripcionTxt.Text;
                    OBJETIVOINVENTARIO objetivo = (OBJETIVOINVENTARIO)tipoObjetivoCbx.SelectedItem;
                    p.OBJETIVOINVENTARIO = objetivo;
                    p.CONFIANZA = decimal.Parse(confianzaTxt.Text.Replace('.', ','));
                    p.TIPODISENOMUESTRAL = tipoDiseno;
                    FORMULA formula = (FORMULA)formularComboBox.SelectedItem;
                    string tipoProyecto = TipoProyectoCbx.SelectedItem.ToString();
                    p.NROFORMULA = formula.NROFORMULA;
                    p.TIPOPROYECTO = tipoProyecto == "Independiente" ? "IN" : "CR";
                    p.TAMANO = decimal.Parse(tamParcelaTxt.Text);
                    p.NUMEROPARCELAS = decimal.Parse(numeroParcelasTxt.Text.Replace('.', ','));
                    p.NUMEROPARCELASAMUESTREAR = decimal.Parse(numeroParcelasMuestraTxt.Text.Replace('.', ','));
                    p.LIMITINFDAP = decimal.Parse(limiteInfTxt.Text);
                    p.INTMUE = decimal.Parse(intMuestreoTxt.Text);
                    p.SUPTOT = decimal.Parse(AreaTotalTxt.Text);
                    p.SUPMUE = decimal.Parse(areaMuestrearTxt.Text);
                    p.AREAFUSTALESPORPARCELA = decimal.Parse(areaFustalesTxt.Text);
                    p.FACTORDEFORMA = decimal.Parse(factorFormaTxt.Text);
                    p.FECHA = DateTime.Today;
                    p.ETAPA = int.Parse(numeroEtapasTxt.Text);
                    project.UpdateProject(p);
                    string result = project.SaveChanges();
                    if (result == "")
                    {
                        MessageBox.Show("Los datos fueron actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(result);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }

                }
                else MessageBox.Show("No se ha seleccionado ninguna especie para el proyecto.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private bool validateStratumWeight()
        {
            try
            {
                List<LISTADODEESTRATOS> stratumsProject = ((PROYECTO)proyectoBS.Current).LISTADODEESTRATOS.ToList();
                decimal sumTam = 0, areaTotal = 0 ;
                //inten = decimal.Parse(intMuestreoTxt.Text.ToString().Replace('.',','));
                //areaTotal = decimal.Parse(AreaTotalTxt.Text.ToString().Replace('.',','));
                areaTotal = decimal.Parse(AreaTotalTxt.Text.ToString().Replace('.', ','));
                foreach (DataGridViewRow row in estratoDGW.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if ((bool)row.Cells[0].Value)
                        {
                            if (row.Cells["Tamanio"].Value == null || row.Cells["Peso"].Value == null)
                            {
                                errorLbl.Text = "Se debe indicar un peso y un tamaño";
                                errorLbl.ForeColor = Color.Red;
                                return false;
                            }
                            else
                            {
                                //string weight = row.Cells["Peso"].Value.ToString().Replace('.', ',');
                                //sumWeight += decimal.Parse(weight);

                                string tam = row.Cells["Tamanio"].Value.ToString().Replace('.', ',');
                                sumTam += decimal.Parse(tam);

                            }
                        }
                    }
                }
                if (decimal.Round(sumTam,2) != decimal.Round(areaTotal, 2))
                {
                    //int = AreaMuestreada/ AreaTotal
                    if (decimal.Round(sumTam, 2) != decimal.Round(areaTotal, 2)) errorLbl.Text = "La suma de los tamaños debe ser igual al area total: " + decimal.Round(areaTotal, 2);
                    errorLbl.ForeColor = Color.Red;
                    return false;
                }
                else
                {
                    this.createStratumList();
                }
                return true;
            }
            catch(Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
                return false;
            }
        }

        //se busca en la lista de estratos asociada al proyecto que recibe por parametro el listadoEstrato que recibe como parametro y lo elimina
        public int exitsStratumListStrato(PROYECTO pj, string stratum)
        {
            try
            {
                foreach (LISTADODEESTRATOS st in pj.LISTADODEESTRATOS)
                {
                    if (st.ESTRATO.DESCRIPESTRATO == stratum)
                    {
                        pj.LISTADODEESTRATOS.Remove(st);
                        return 1;
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
                return 0;
            }
        }

        private void createStratumList()
        {
            try
            {
                PROYECTO p = (PROYECTO)proyectoBS.Current;
                if (p != null)
                {
                    List<LISTADODEESTRATOS> stratumsProject = p.LISTADODEESTRATOS.ToList();
                    //List<LISTADODEESTRATOS> newListStratumsProject = new List<LISTADODEESTRATOS>();
                    foreach (DataGridViewRow row in estratoDGW.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if ((bool)row.Cells[0].Value)
                            {
                                LISTADODEESTRATOS tempStratum = null;
                                if (stratumsProject.Count == 0) break;
                                foreach (LISTADODEESTRATOS stratum in stratumsProject)
                                {
                                    if (stratum.ESTRATO.DESCRIPESTRATO == row.Cells[1].Value.ToString())
                                    {
                                        tempStratum = stratum;
                                        tempStratum.ESTRATO = stratum.ESTRATO;
                                        break;
                                    }
                                }
                                if (tempStratum != null)
                                {
                                    if (tempStratum.ESTRATO != null)
                                    {
                                        int posEliminado = this.exitsStratumListStrato(p, tempStratum.ESTRATO.DESCRIPESTRATO);
                                        stratumsProject.Remove(tempStratum);
                                        tempStratum.PROYECTO = p;
                                        tempStratum.PESO = (decimal.Parse(row.Cells[2].Value.ToString().Replace('.', ',')));
                                        tempStratum.TAMANOMUESTRA = (decimal.Parse(row.Cells[3].Value.ToString().Replace('.', ',')));
                                        p.LISTADODEESTRATOS.Add(tempStratum);
                                    }
                                }
                            }
                        }                        
                    }
                    //p.LISTADODEESTRATOS = newListStratumsProject;
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccEspecieBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in especiesDGW.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void RemoverEspciesBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in especiesDGW.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void SeleccEstratosBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in estratoDGW.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void removerEstratosBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in estratoDGW.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void seleccionarProyectosBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in proyectoDGW.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void removerProyectosBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in proyectoDGW.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void especiesDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (enableSpeciesList)
                {
                    PROYECTO p = (PROYECTO)proyectoBS.Current;
                    if (especiesDGW.Columns[e.ColumnIndex].Name == "Especie")
                    {
                        DataGridViewRow row = especiesDGW.Rows[e.RowIndex];
                        especieBS.Position = row.Index;
                        DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;
                        if (cellSelecion.Value != null)
                        {

                            if (Convert.ToBoolean(cellSelecion.Value))
                            {
                                ESPECIE data = (ESPECIE)especieBS.Current;
                                if (data != null) p.ESPECIE.Add(data);
                            }
                            else
                            {
                                ESPECIE data = (ESPECIE)especieBS.Current;
                                if (data != null) p.ESPECIE.Remove(data);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }
       
        private void estratoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (enableStratumsList)
                {
                    PROYECTO p = (PROYECTO)proyectoBS.Current;
                    if (estratoDGW.Columns[e.ColumnIndex].Name == "Estratos")
                    {

                        DataGridViewRow row = estratoDGW.Rows[e.RowIndex];
                        estratoBS.Position = row.Index;
                        DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;
                        if (cellSelecion.Value != null)
                        {
                            if (Convert.ToBoolean(cellSelecion.Value))
                            {
                                LISTADODEESTRATOS stratumData = Program.ContextData.LISTADODEESTRATOS.Create();
                                ESTRATO data = (ESTRATO)estratoBS.Current;
                                if (data != null)
                                {
                                    stratumData.ESTRATO = data;
                                    stratumData.PROYECTO = p;
                                    stratumData.PESO = row.Cells["Peso"].Value == null ? 0 : decimal.Parse(row.Cells["Peso"].Value.ToString().Replace('.', ','));
                                    stratumData.TAMANOMUESTRA = row.Cells["Tamanio"].Value == null ? 0 : decimal.Parse(row.Cells["Tamanio"].Value.ToString().Replace('.', ','));
                                    this.exitsStratumListStrato(p, stratumData.ESTRATO.DESCRIPESTRATO);
                                    p.LISTADODEESTRATOS.Add(stratumData);
                                }
                            }
                            else
                            {
                                LISTADODEESTRATOS stratumData = Program.ContextData.LISTADODEESTRATOS.Create();
                                row.Cells["Peso"].Value = 0.000m;
                                row.Cells["Tamanio"].Value = 0.00m;
                                ESTRATO data = (ESTRATO)estratoBS.Current;
                                if (data != null)
                                {
                                    stratumData.ESTRATO = data;
                                    stratumData.PROYECTO = p;
                                    this.exitsStratumListStrato(p, data.DESCRIPESTRATO);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (estratoDGW.Columns[e.ColumnIndex].Name == "Tamanio")
                        {
                            if (tamParcelaTxt.Text != "" && tamParcelaTxt.Text != "0")
                            {
                                errorLbl.Text = "";
                                DataGridViewRow row = estratoDGW.Rows[e.RowIndex];
                                if (row.Cells["Tamanio"].Value.ToString() != "0" && row.Cells["Tamanio"].Value.ToString() != "")
                                {
                                    row.Cells["Peso"].Value = decimal.Round(decimal.Parse(row.Cells["Tamanio"].Value.ToString().Replace('.', ',')) / decimal.Parse(AreaTotalTxt.Text.ToString().Replace('.', ',')), 2);
                                    if (row.Cells[0].Value != null)
                                    {
                                        if (Convert.ToBoolean(row.Cells[0].Value))
                                        {
                                            LISTADODEESTRATOS stratumData = Program.ContextData.LISTADODEESTRATOS.Create();
                                            ESTRATO data = (ESTRATO)estratoBS.Current;
                                            if (data != null)
                                            {
                                                stratumData.ESTRATO = data;
                                                stratumData.PROYECTO = p;
                                                stratumData.PESO = row.Cells["Peso"].Value == null ? 0 : decimal.Parse(row.Cells["Peso"].Value.ToString().Replace('.', ','));
                                                stratumData.TAMANOMUESTRA = row.Cells["Tamanio"].Value == null ? 0 : decimal.Parse(row.Cells["Tamanio"].Value.ToString().Replace('.', ','));
                                                exitsStratumListStrato(p, stratumData.ESTRATO.DESCRIPESTRATO);
                                                p.LISTADODEESTRATOS.Add(stratumData);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                errorLbl.Text = "No se ha especificado el area total ";
                                errorLbl.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void proyectoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PROYECTO p = (PROYECTO)proyectoBS.Current;
                if (enableProjectList && p != null)
                {
                    if (proyectoDGW.Columns[e.ColumnIndex].Name == "Proyectos")
                    {
                        DataGridViewRow row = proyectoDGW.Rows[e.RowIndex];
                        DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;

                        if (cellSelecion.Value != null)
                        {

                            if (Convert.ToBoolean(cellSelecion.Value))
                            {
                                PROYECTO Py = project.GetProject((Guid)row.Cells["Codigo"].Value);
                                PROYECTOSPORETAPA projectStageFather = Program.ContextData.PROYECTOSPORETAPA.Create();

                                projectStageFather.NROPROYCONTENEDOR = p.NROPROY;
                                projectStageFather.NROPROYCONTENIDO = Py.NROPROY;
                                projectStageFather.PESO = row.Cells["PesoProyecto"].Value != null ? (decimal)row.Cells["PesoProyecto"].Value : 0;
                                projectStageFather.ETAPA = p.ETAPA + 1;
                                
                                if (Py != null)
                                {
                                    p.PROYECTOSPORETAPA.Add(projectStageFather); //Proyectos por por etapa va a ser la lista de los hijos 
                                    Py.PROYECTOSPORETAPA1.Add(projectStageFather); // proyectos por etapa 1 va a ser el campo para el padre
                                    Py.ETAPA = p.ETAPA + 1;
                                    row.Cells["ETAPA"].Value = p.ETAPA + 1;
                                }
                            }
                            else
                            {
                                PROYECTO Py = project.GetProject((Guid)row.Cells["Codigo"].Value);
                                
                                if (Py != null)
                                {
                                    int pos = exitsProjectStage(p, Py);
                                    Py.ETAPA = 0;
                                
                                }
                            }
                            proyectosBS.DataSource = project.GetProjects(p);
                            proyectoDGW.DataSource = proyectosBS;
                        }
                    }
                    proyectoBS.DataSource = p;
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void TipoProyectoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)cmb.SelectedItem;
                if (selectedItem.Value != null)
                {
                    if (selectedItem.Value == "Contenedor")
                    {
                        foreach (Control ctl in actualizarProyectoTab.TabPages["proyectosContTabP"].Controls) ctl.Enabled = true;
                    }
                    else
                    {
                        foreach (Control ctl in actualizarProyectoTab.TabPages["proyectosContTabP"].Controls) ctl.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void tipoDisenoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                Object selectedItem = cmb.SelectedItem;
                if (selectedItem != null)
                {
                    TIPODISENOMUESTRAL tipoDiseno = (TIPODISENOMUESTRAL)selectedItem;

                    if (tipoDiseno.DESCRIPTIPODISEMUEST == "Diseño estratificado")
                    {
                        foreach (Control ctl in actualizarProyectoTab.TabPages["estratosTabP"].Controls) ctl.Enabled = true;
                    }
                    else
                    {
                        foreach (Control ctl in actualizarProyectoTab.TabPages["estratosTabP"].Controls) ctl.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        
        private void crearFormBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Crear_Editar_Formulario_Form childForm = new Crear_Editar_Formulario_Form(null);
                childForm.MdiParent = this.ParentForm;
                childForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void formulariosDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == formulariosDGW.Columns["ListarDatos"].Index && e.RowIndex >= 0)
                {
                    FORMULARIO result = form.GetForm((Guid)formulariosDGW.Rows[e.RowIndex].Cells[1].Value);
                    Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(result, 0);
                    childForm.MdiParent = this.ParentForm;
                    childForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void formulariosDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                UserBL user = new UserBL(Program.ContextData);
                foreach (DataGridViewRow row in formulariosDGW.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        USUARIO data = user.GetUser((Guid)row.Cells[1].Value);
                        if (data != null) row.Cells[2].Value = data.NOMBRES + " " + data.APELLIDOS;
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void especiesDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                PROYECTO p = (PROYECTO)proyectoBS.Current;
                if (p != null)
                {
                    enableSpeciesList = false;
                    if (p.TIPOPROYECTO == "IN") TipoProyectoCbx.SelectedIndex = 0;
                    else TipoProyectoCbx.SelectedIndex = 1;
                    List<ESPECIE> speciesProject = p.ESPECIE.ToList();
                    foreach (DataGridViewRow row in especiesDGW.Rows)
                    {
                        ESPECIE tempSpecie = null;
                        if (speciesProject.Count == 0) break;
                        foreach (ESPECIE specie in speciesProject)
                        {
                            if (specie.NOMCOMUN == row.Cells[1].Value.ToString())
                            {
                                tempSpecie = specie;
                                break;
                            }
                        }
                        if (tempSpecie != null)
                        {
                            speciesProject.Remove(tempSpecie);
                            row.Cells[0].Value = true;
                        }
                    }
                    enableSpeciesList = true;
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void estratosDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                PROYECTO p = (PROYECTO)proyectoBS.Current;
                if (p != null)
                {
                    enableStratumsList = false;
                    List<LISTADODEESTRATOS> stratumsProject = p.LISTADODEESTRATOS.ToList();
                    foreach (DataGridViewRow row in estratoDGW.Rows)
                    {
                        LISTADODEESTRATOS tempStratum = null;
                        if (stratumsProject.Count == 0) break;
                        foreach (LISTADODEESTRATOS stratum in stratumsProject)
                        {
                            if (stratum.ESTRATO.DESCRIPESTRATO == row.Cells[1].Value.ToString())
                            {
                                tempStratum = stratum;
                                tempStratum.ESTRATO = stratum.ESTRATO;
                                break;
                            }
                        }
                        if (tempStratum != null)
                        {
                            if (tempStratum.ESTRATO != null)
                            {
                                stratumsProject.Remove(tempStratum);
                                row.Cells[0].Value = true;
                                row.Cells[2].Value = tempStratum.PESO;
                                row.Cells[3].Value = tempStratum.TAMANOMUESTRA;
                            }
                        }
                        else
                        {
                            row.Cells[2].Value = 0.0m;
                            row.Cells[3].Value = 0.0m;
                        }

                    }
                    enableStratumsList = true;
                    modificate = true;
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                foreach (DataGridViewRow row in estratoDGW.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value)) count++;
                }
                if (count > 0)
                {
                    decimal porcentaje = (100.000m) / count;
                    foreach (DataGridViewRow row in estratoDGW.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) row.Cells[2].Value = porcentaje;
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void proyectoDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                PROYECTO p = (PROYECTO)proyectoBS.Current;
                if (p != null)
                {
                    enableProjectList = false;
                    List<PROYECTOSPORETAPA> projectStage = p.PROYECTOSPORETAPA.ToList();
                    foreach (DataGridViewRow row in proyectoDGW.Rows)
                    {
                        PROYECTOSPORETAPA tempProject = null;
                        if (p.PROYECTOSPORETAPA.Count == 0) break;
                        foreach (PROYECTOSPORETAPA pyS in projectStage)
                        {
                            if (pyS.NROPROYCONTENIDO == (Guid)row.Cells[1].Value)
                            {
                                tempProject = pyS;
                                row.Cells["PesoProyecto"].Value = pyS.PESO;
                                break;
                            }
                        }
                        if (tempProject != null)
                        {
                            row.Cells[0].Value = true;
                            
                            projectStage.Remove(tempProject);
                        }
                    }
                    enableProjectList = true;
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }
        //se verifica si existe el proyecto hijo en la lista de hijos del padre lo elimina.
        public int exitsProjectStage(PROYECTO pyFather, PROYECTO pySon)
        {
            try
            {
                foreach (PROYECTOSPORETAPA listPy in pyFather.PROYECTOSPORETAPA)
                {
                    if (listPy.NROPROYCONTENIDO == pySon.NROPROY)
                    {
                        pyFather.PROYECTOSPORETAPA.Remove(listPy);
                        pySon.PROYECTOSPORETAPA1.Remove(listPy);
                        return 1;
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
                return 0;
            }
        }

        private void arbolEtapasBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PROYECTO p = (PROYECTO)proyectoBS.Current;
                if (p != null)
                {
                    Arbol_Proyectos_Por_Etapas_Form childForm = new Arbol_Proyectos_Por_Etapas_Form(p);
                    childForm.MdiParent = this.ParentForm;
                    childForm.Show();
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void datosDeAreaEIntensida()
        {
            if (modificate)
            {
                numeroParcelasTxt.Text = AreaTotalTxt.Text != "" && tamParcelaTxt.Text != "" && decimal.Parse(tamParcelaTxt.Text) != 0 ? Math.Round((decimal.Parse(AreaTotalTxt.Text) / decimal.Parse(tamParcelaTxt.Text)), 0).ToString() : "0";
                areaMuestrearTxt.Text = numeroParcelasMuestraTxt.Text != "" && tamParcelaTxt.Text != "" ? (decimal.Parse(tamParcelaTxt.Text) * decimal.Parse(numeroParcelasMuestraTxt.Text)).ToString() : "0";
                intMuestreoTxt.Text = (AreaTotalTxt.Text != "" && decimal.Parse(AreaTotalTxt.Text) != 0 && areaMuestrearTxt.Text != "" ? decimal.Parse(areaMuestrearTxt.Text) / decimal.Parse(AreaTotalTxt.Text) * 100 : 0).ToString();
                modificate = true;
            }

        }

        private void tamParcelaTxt_TextChanged(object sender, EventArgs e)
        {
            datosDeAreaEIntensida();
        }
        
        private void numeroParcelasMuestraTxt_TextChanged(object sender, EventArgs e)
        {
            datosDeAreaEIntensida();
        }        

        private void registrarSpecieBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Especies_Form childForm = new Especies_Form();
                childForm.Btn_nuevaEspecieForm_Click(sender, e, null, "proyecto");
                childForm.ShowDialog(this);
                especieBS.DataSource = species.GetSpecies();
                especiesDGW.DataSource = especieBS;
                PROYECTO p = (PROYECTO)proyectoBS.Current;
                if (p != null)
                {
                    List<ESPECIE> speciesProject = p.ESPECIE.ToList();
                    foreach (DataGridViewRow row in especiesDGW.Rows)
                    {
                        ESPECIE tempSpecie = null;
                        if (speciesProject.Count == 0) break;
                        foreach (ESPECIE specie in speciesProject)
                        {
                            if (specie.NOMCOMUN == row.Cells[1].Value.ToString())
                            {
                                tempSpecie = specie;
                                break;
                            }
                        }
                        if (tempSpecie != null)
                        {
                            speciesProject.Remove(tempSpecie);
                            row.Cells[0].Value = true;
                        }
                    }
                }
                especiesDGW.Refresh();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
        }

        private void formularComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formularComboBox.SelectedValue!=null)
            {
                FORMULA fm = formulateBL.GetFormulate((Guid)formularComboBox.SelectedValue);
                expresionTxt.Text =fm.EXPRESION;
            }
            
        }

        private void AreaTotalTxt_TextChanged(object sender, EventArgs e)
        {
            datosDeAreaEIntensida();
        }


    }
}
