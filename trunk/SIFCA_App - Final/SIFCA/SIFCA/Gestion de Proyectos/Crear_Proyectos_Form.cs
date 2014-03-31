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
   
    public partial class Crear_Proyecto_Form : Form
    {
        private ProjectBL project;
        private TypeSampleDesignBl typeExample;
        private ObjectiveInventoryBL objetiveInventory;
        private StratumBL stratum;
        private SpeciesBL species;
        private FormulateBL formulate;
        private PROYECTO newProject;
        private List<PROYECTOSPORETAPA> listProjectsByStage;
        
        public Crear_Proyecto_Form()
        {
            try
            {
                InitializeComponent();
                this.ControlBox = false;
                criterioCbx.SelectedIndex = 0;
                newProject = Program.ContextData.PROYECTO.Create();
                newProject.CONFIANZA = 95;
                newProject.LIMITINFDAP = 0.1M;
                newProject.AREAFUSTALESPORPARCELA = 0.1M;
                newProject.NUMEROPARCELAS = 0;
                newProject.NUMEROPARCELASAMUESTREAR = 0;
                newProject.INTMUE = 0;
                newProject.SUPMUE = 0;
                newProject.SUPTOT = 0;
                formulate = new FormulateBL(Program.ContextData);
                formulaBS.DataSource = formulate.GetFormulates();
                newProject.NROFORMULA = formulaBS.Count != 0 ? ((FORMULA)formulaBS.Current).NROFORMULA : Guid.Empty;
                project = new ProjectBL(Program.ContextData);
                estratoDGW.Columns[2].DefaultCellStyle.Format = "0.000##";
                typeExample = new TypeSampleDesignBl(Program.ContextData);
                objetiveInventory = new ObjectiveInventoryBL(Program.ContextData);
                stratum = new StratumBL(Program.ContextData);
                species = new SpeciesBL(Program.ContextData);
                objetivoInventarioBS.DataSource = objetiveInventory.GetObjectiveInventories();
                newProject.NOMBRETIPOINV = objetivoInventarioBS.Count != 0 ? ((OBJETIVOINVENTARIO)objetivoInventarioBS.Current).NOMBRETIPOINV : null;
                tipoDisenoBS.DataSource = typeExample.GetTypeSampleDesignList();
                newProject.NOMTIPODISEMUEST = tipoDisenoBS.Count != 0 ? ((TIPODISENOMUESTRAL)tipoDisenoBS.Current).NOMTIPODISEMUEST : null;
                estratoBS.DataSource = stratum.GetStratums();
                estratoDGW.DataSource = estratoBS;
                especieBS.DataSource = species.GetSpecies();
                especiesDGW.DataSource = especieBS;
                proyectoBS.DataSource = project.GetProjectsFree(Guid.Empty);
                proyectoDGW.DataSource = proyectoBS;
                listProjectsByStage = new List<PROYECTOSPORETAPA>();
                TipoProyectoCbx.SelectedIndex = 0;
                nuevoProyectoBS.DataSource = newProject;
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
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        

        //TODO:arreglar la navegacion, y sehabilitar los click en los tab para que unicamente funcione la navegacion
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = false;

                if (lugarTxt.Text == "")
                {
                    controladorErrores.SetError(lugarTxt, "El campo lugar es requerido.");
                    error = true;
                }
                if (decimal.Parse(tamParcelaTxt.Text) <= 0)
                {
                    controladorErrores.SetError(lugarTxt, "El tamaño de la parcela debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(numeroParcelasMuestraTxt.Text) <= 0)
                {
                    controladorErrores.SetError(numeroParcelasMuestraTxt, "El numero de parcelas a muestrea debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(numeroParcelasTxt.Text) <= 0)
                {
                    controladorErrores.SetError(numeroParcelasTxt, "El numero total de parcelas debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(limiteInfTxt.Text) < 0)
                {
                    controladorErrores.SetError(limiteInfTxt, "El limite inferior A.P. debe ser mayor o igual que cero.");
                    error = true;
                }
                if (decimal.Parse(intMuestreoTxt.Text) <= 0)
                {
                    controladorErrores.SetError(intMuestreoTxt, "La intensidad de muestreo debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(AreaTotalTxt.Text) <= 0)
                {
                    controladorErrores.SetError(AreaTotalTxt, "El area muestreada debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(areaFustalesTxt.Text) < 0)
                {
                    controladorErrores.SetError(areaFustalesTxt, "El Area de los Fustales debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(factorFormaTxt.Text) <= 0)
                {
                    controladorErrores.SetError(factorFormaTxt, "El Factor de Forma debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(numeroEtapasTxt.Text) < 0)
                {
                    controladorErrores.SetError(numeroEtapasTxt, "El numero de Etapas debe ser mayor o igual que cero.");
                    error = true;
                }
                if (decimal.Parse(confianzaTextBox.Text) < 0)
                {
                    controladorErrores.SetError(confianzaTextBox, "La confianza asociada al proyecto debe ser mayor que cero.");
                    error = true;
                }

                if (error) return;

                controladorErrores.Clear();

                if (newProject.ESPECIE.Count > 0)
                {
                    TIPODISENOMUESTRAL tipoDiseno = (TIPODISENOMUESTRAL)tipoDisenoCbx.SelectedItem;
                    if (tipoDiseno.DESCRIPTIPODISEMUEST == "Diseño estratificado" && !(newProject.LISTADODEESTRATOS.Count > 0))
                    {
                        MessageBox.Show("No se ha seleccionado ningun estrato para el proyecto.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (tipoDiseno.DESCRIPTIPODISEMUEST == "Diseño estratificado")
                        {
                            if (!this.validateStratumWeight())
                            {
                                MessageBox.Show("Pesos de los estratos o tamaño incorrectos.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    newProject.NROPROY = Guid.NewGuid();
                    newProject.USUARIO = (USUARIO)Program.Cache.Get("user");
                    newProject.LUGAR = lugarTxt.Text;
                    newProject.CONFIANZA = decimal.Parse(confianzaTextBox.Text.Replace('.', ','));
                    newProject.DESCRIPCION = DescripcionTxt.Text;
                    OBJETIVOINVENTARIO objetivo = (OBJETIVOINVENTARIO)tipoObjetivoCbx.SelectedItem;
                    newProject.OBJETIVOINVENTARIO = objetivo;
                    newProject.TIPODISENOMUESTRAL = tipoDiseno;
                    FORMULA formula = (FORMULA)formularComboBox.SelectedItem;
                    string tipoProyecto = TipoProyectoCbx.SelectedItem.ToString();
                    newProject.TIPOPROYECTO = tipoProyecto == "Independiente" ? "IN" : "CR";
                    newProject.TAMANO = decimal.Parse(tamParcelaTxt.Text.Replace('.', ','));
                    newProject.NUMEROPARCELAS = decimal.Parse(numeroParcelasTxt.Text.Replace('.', ','));
                    newProject.NUMEROPARCELASAMUESTREAR = decimal.Parse(numeroParcelasMuestraTxt.Text.Replace('.', ','));
                    newProject.LIMITINFDAP = decimal.Parse(limiteInfTxt.Text.Replace('.', ','));
                    newProject.INTMUE = decimal.Parse(intMuestreoTxt.Text.Replace('.', ','));
                    newProject.SUPTOT = decimal.Parse(AreaTotalTxt.Text.Replace('.', ','));
                    newProject.SUPMUE = newProject.SUPTOT * newProject.INTMUE / 100;
                    newProject.AREAFUSTALESPORPARCELA = decimal.Parse(areaFustalesTxt.Text.Replace('.', ','));
                    newProject.FACTORDEFORMA = decimal.Parse(factorFormaTxt.Text.Replace('.', ','));
                    newProject.FECHA = DateTime.Today;
                    newProject.ETAPA = int.Parse(numeroEtapasTxt.Text);
                    foreach (PROYECTOSPORETAPA pyByStage in listProjectsByStage)
                    {
                        pyByStage.NROPROYCONTENEDOR = newProject.NROPROY;
                        newProject.PROYECTOSPORETAPA.Add(pyByStage);
                    }
                    project.InsertProject(newProject);
                    project.SaveChanges();
                    string result = project.SaveChanges();
                    if (result == "")
                    {
                        MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.Cache.Add("project", newProject, new CacheItemPolicy());
                        Principal_Form parent = (Principal_Form)this.ParentForm;
                        parent.EstatusLabel.Text = parent.EstatusLabel.Text + " - Proyecto Abierto: " + newProject.LUGAR;
                        parent.Text = parent.Text + " - Proyecto Abierto " + newProject.LUGAR;
                        parent.changueMenuProject();
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
            decimal porcentaje = (100.000m) / estratoDGW.Rows.Count;
            foreach (DataGridViewRow row in estratoDGW.Rows)
            {
                row.Cells[0].Value = true;
                row.Cells[2].Value = porcentaje;

            }
        }

        private void removerEstratosBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in estratoDGW.Rows)
            {
                row.Cells[0].Value = false;
                row.Cells[2].Value = 0.000m;
                errorLbl.Text = "";
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
                            if (data != null) newProject.ESPECIE.Add(data);
                        }
                        else
                        {
                            ESPECIE data = (ESPECIE)especieBS.Current;
                            if (data != null) newProject.ESPECIE.Remove(data);
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

        private bool validateStratumWeight()
        {
            try
            {
                List<LISTADODEESTRATOS> stratumsProject = newProject.LISTADODEESTRATOS.ToList();
                decimal sumWeight = 0, sumTam = 0, supTam = decimal.Parse(AreaTotalTxt.Text.Replace('.', ','));
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
                                string weight = row.Cells["Peso"].Value.ToString().Replace('.', ',');
                                sumWeight += decimal.Parse(weight);

                                string tam = row.Cells["Tamanio"].Value.ToString().Replace('.', ',');
                                sumTam += decimal.Parse(tam);
                            }
                        }                        
                    }                    
                }
                if (decimal.Round(sumTam,2) != decimal.Round(supTam,2) || sumWeight != 1)
                {
                    if (sumTam != supTam) errorLbl.Text = "La suma de los pesos debe ser " + decimal.Round(supTam, 2);
                    if (sumWeight != 1) errorLbl.Text = "La suma de los tamaños dede ser 1";
                    if (sumWeight != 1 && sumTam != supTam) errorLbl.Text = "Los pesos y tamaños son incorrectos";
                    errorLbl.ForeColor = Color.Red;
                    return false;
                }
                else
                {
                    this.createStratumList();
                }
                return true;
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
                return false;
            }
        }

        //se busca en la lista de estratos asociada al proyecto que recibe por parametro el listadoEstrato que recibe como parametro y lo elimina
        public int exitsStratumListStrato(PROYECTO pj, string Stratum)
        {
            try
            {
                foreach (LISTADODEESTRATOS st in pj.LISTADODEESTRATOS)
                {
                    if (st.ESTRATO.DESCRIPESTRATO == Stratum)
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
                List<LISTADODEESTRATOS> stratumsProject = newProject.LISTADODEESTRATOS.ToList();
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
                                    int posEliminado = this.exitsStratumListStrato(newProject, tempStratum.ESTRATO.DESCRIPESTRATO);
                                    stratumsProject.Remove(tempStratum);
                                    tempStratum.PROYECTO = newProject;
                                    tempStratum.PESO = (decimal.Parse(row.Cells[2].Value.ToString().Replace('.', ',')));
                                    tempStratum.TAMANOMUESTRA = (decimal.Parse(row.Cells[3].Value.ToString().Replace('.', ',')));
                                    newProject.LISTADODEESTRATOS.Add(tempStratum);
                                }
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
                                stratumData.PROYECTO = newProject;
                                stratumData.PESO = row.Cells["Peso"].Value == null ? 0 : decimal.Parse(row.Cells["Peso"].Value.ToString().Replace('.', ','));
                                stratumData.TAMANOMUESTRA = row.Cells["Tamanio"].Value == null ? 0 : decimal.Parse(row.Cells["Tamanio"].Value.ToString().Replace('.', ','));
                                this.exitsStratumListStrato(newProject, stratumData.ESTRATO.DESCRIPESTRATO);
                                newProject.LISTADODEESTRATOS.Add(stratumData);
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
                                stratumData.PROYECTO = newProject;
                                this.exitsStratumListStrato(newProject, data.DESCRIPESTRATO);
                            }
                        }
                    }
                }
                else
                {
                    if (estratoDGW.Columns[e.ColumnIndex].Name == "Tamanio")
                    {
                        if (AreaTotalTxt.Text != "" && AreaTotalTxt.Text != "0")
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
                                            stratumData.PROYECTO = newProject;
                                            stratumData.PESO = row.Cells["Peso"].Value == null ? 0 : decimal.Parse(row.Cells["Peso"].Value.ToString().Replace('.', ','));
                                            stratumData.TAMANOMUESTRA = row.Cells["Tamanio"].Value == null ? 0 : decimal.Parse(row.Cells["Tamanio"].Value.ToString().Replace('.', ','));
                                            exitsStratumListStrato(newProject, stratumData.ESTRATO.DESCRIPESTRATO);
                                            newProject.LISTADODEESTRATOS.Add(stratumData);
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
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        //TODO: modificar que agregue los proyectos y modificar la base de datos para que acepte el peso del proyecto
        private void proyectoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try {
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

                            projectStageFather.NROPROYCONTENEDOR = newProject.NROPROY;
                            projectStageFather.NROPROYCONTENIDO = Py.NROPROY;
                            projectStageFather.ETAPA = newProject.ETAPA + 1;
                            projectStageFather.PESO = row.Cells["PesoProyecto"].Value != null ? (decimal)row.Cells["PesoProyecto"].Value : 0;

                            if (Py != null)
                            {
                                newProject.PROYECTOSPORETAPA.Add(projectStageFather); //Proyectos por por etapa va a ser la lista de los hijos 
                                Py.PROYECTOSPORETAPA1.Add(projectStageFather); // proyectos por etapa 1 va a ser el campo para el padre 
                                Py.ETAPA = projectStageFather.ETAPA + 1;
                            }
                        }
                        else
                        {
                            PROYECTO Py = project.GetProject((Guid)row.Cells["Codigo"].Value);
                            PROYECTOSPORETAPA projectStage = Program.ContextData.PROYECTOSPORETAPA.Create();
                            projectStage.NROPROYCONTENEDOR = newProject.NROPROY;
                            projectStage.NROPROYCONTENIDO = Py.NROPROY;
                            projectStage.ETAPA = newProject.ETAPA + 1;
                            projectStage.PESO = row.Cells["PesoProyecto"].Value != null ? (decimal)row.Cells["PesoProyecto"].Value : 0;
                            if (Py != null)
                            {
                                newProject.PROYECTOSPORETAPA.Remove(projectStage);
                                Py.PROYECTOSPORETAPA1.Remove(projectStage);
                                Py.ETAPA = projectStage.ETAPA - 1;
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

        public int UnSelectProjectByStage(PROYECTO Py)
        {
            try
            {
                int pos = 0;
                foreach (PROYECTOSPORETAPA pjStage in listProjectsByStage)
                {
                    if (pjStage.NROPROYCONTENIDO == Py.NROPROY) return pos;
                    pos++;
                }
                return -1;
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
                return -1;
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
                        foreach (Control ctl in crearProyectoTab.TabPages["estratosTabP"].Controls) ctl.Enabled = true;
                    }
                    else
                    {
                        foreach (Control ctl in crearProyectoTab.TabPages["estratosTabP"].Controls) ctl.Enabled = false;
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

        private void TipoProyectoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                Object selectedItem = cmb.SelectedItem;
                if (selectedItem != null)
                {
                    if (selectedItem.ToString() == "Contenedor")
                    {
                        foreach (Control ctl in crearProyectoTab.TabPages["proyectosContTabP"].Controls) ctl.Enabled = true;
                    }
                    else
                    {
                        foreach (Control ctl in crearProyectoTab.TabPages["proyectosContTabP"].Controls) ctl.Enabled = false;
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

         private void estratoDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in estratoDGW.Rows)
            {
                row.Cells[2].Value = 0.0m;
                row.Cells[3].Value = 0.0m;
            }
             if(newProject!=null)
             {
                 List<LISTADODEESTRATOS> stratumsProject = newProject.LISTADODEESTRATOS.ToList();
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
                 }
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

         private void actualizarPesoProyectosEtapasBtn_Click(object sender, EventArgs e)
         {
             try
             {
                 int count = 0;
                 foreach (DataGridViewRow row in proyectoDGW.Rows)
                 {
                     if (Convert.ToBoolean(row.Cells[0].Value)) count++;
                 }
                 if (count > 0)
                 {
                     decimal porcentaje = (100.000m) / count;
                     foreach (DataGridViewRow row in proyectoDGW.Rows)
                     {
                         if (Convert.ToBoolean(row.Cells[0].Value)) row.Cells["PesoProyecto"].Value = porcentaje;
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

        
         private void buscarTxt_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 if (busquedaTxt.Text != "")
                 {
                     string criteria = criterioCbx.SelectedItem.ToString();
                     especieBS.DataSource = species.SearchSpecies(busquedaTxt.Text, criteria);
                     especiesDGW.Refresh();
                 }
                 else
                 {
                     especieBS.DataSource = species.GetSpecies();
                     especiesDGW.Refresh();
                 }
                 if (newProject != null)
                 {
                     List<ESPECIE> speciesProject = newProject.ESPECIE.ToList();
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
             }
             catch (Exception ex)
             {
                 Error_Form er = new Error_Form(ex.Message);
                 er.Show();
             }
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
                 if (newProject != null)
                 {
                     List<ESPECIE> speciesProject = newProject.ESPECIE.ToList();
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

         private void crearEstratoBtn_Click(object sender, EventArgs e)
         {
             try
             {
                 Estratos_Form childForm = new Estratos_Form();
                 childForm.Btn_nuevoEstratoForm_Click(sender, e, "proyecto");
                 childForm.ShowDialog(this);
                 estratoBS.DataSource = stratum.GetStratums();
                 estratoDGW.DataSource = estratoBS;
                 especiesDGW.Refresh();
             }
             catch (Exception ex)
             {
                 Error_Form er = new Error_Form(ex.Message);
                 er.Show();
             }
         }

         private void datosDeAreaEIntensida()
         {
             PROYECTO p = (PROYECTO)nuevoProyectoBS.Current;
             nuevoProyectoBS.EndEdit();
             if (p != null)
             {
                 p.SUPTOT = (decimal)p.TAMANO * (decimal)p.NUMEROPARCELAS;
                 p.SUPMUE = (decimal)p.TAMANO * (decimal)p.NUMEROPARCELASAMUESTREAR;
                 p.INTMUE = (decimal)p.SUPTOT!=0?((decimal)p.SUPMUE / (decimal)p.SUPTOT) * 100:0;
             }
         }

         private void tamParcelaTxt_TextChanged(object sender, EventArgs e)
         {
             datosDeAreaEIntensida();
         }

         private void numeroParcelasTxt_TextChanged(object sender, EventArgs e)
         {
             datosDeAreaEIntensida();
         }

         private void numeroParcelasMuestraTxt_TextChanged(object sender, EventArgs e)
         {
             datosDeAreaEIntensida();
         }
        
    }
}
