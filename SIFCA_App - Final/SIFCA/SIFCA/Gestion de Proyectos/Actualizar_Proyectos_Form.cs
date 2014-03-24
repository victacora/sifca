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
        private bool enableSpeciesList=false;
        private bool enableStratumsList=false;
        private bool enableProjectList = false;

        public Actualizar_Proyectos_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            project = new ProjectBL(Program.ContextData);
            typeExample = new TypeSampleDesignBl (Program.ContextData);
            objetiveInventory = new ObjectiveInventoryBL(Program.ContextData);
            stratum = new StratumBL(Program.ContextData);
            species = new SpeciesBL(Program.ContextData);
            form = new FormBL(Program.ContextData);
            
            PROYECTO p = (PROYECTO)Program.Cache.Get("project");

            proyectoBS.DataSource = p;

            proyectosBS.DataSource = project.GetProjects(p.NROPROY);
            proyectoDGW.DataSource = proyectosBS;

            objetivoInventarioBS.DataSource= objetiveInventory.GetObjectiveInventories();
            tipoObjetivoCbx.DataSource = objetivoInventarioBS;
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("IN", "Independiente"));
            data.Add(new KeyValuePair<string, string>("CR", "Contenedor"));
            TipoProyectoCbx.DataSource = data;
            TipoProyectoCbx.DisplayMember = "Value";
            TipoProyectoCbx.ValueMember = "Key";
            TipoProyectoCbx.SelectedValue = p.TIPOPROYECTO;


            tipoDisenoBS.DataSource = typeExample.GetTypeSampleDesignList();
            tipoDisenoCbx.DataSource = tipoDisenoBS;

            especieBS.DataSource = species.GetSpecies();
            especiesDGW.DataSource = especieBS;

            formulariosBS.DataSource = p.FORMULARIO;
            formulariosDGW.DataSource = formulariosBS;
         
            estratoBS.DataSource = stratum.GetStratums();
            estratoDGW.DataSource = estratoBS;

            

        }

        private void crearProyectoTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g;
            String sText;
            float iX;
            float iY;
            SizeF sizeText;
            TabControl ctlTab;
            ctlTab = (TabControl) sender; 
            g = e.Graphics;
            sText = ctlTab.TabPages[e.Index].Text;
            sizeText = g.MeasureString(sText, ctlTab.Font);
            iX = e.Bounds.Left + 6;
            iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;
            g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY);
        }

        //TODO:arreglar la navegacion, y sehabilitar los click en los tab para que unicamente funcione la navegacion
        private void ActualizarProyectoBtn_Click(object sender, EventArgs e)
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
            if (decimal.Parse(limiteInfTxt.Text) <= 0)
            {
                controladorErrores.SetError(limiteInfTxt, "El limite inferior A.P. debe ser mayor que cero.");
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
                controladorErrores.SetError(areaFustalesTxt, "El area de los fustales debe ser mayor que cero.");
                error = true;
            }
            if (decimal.Parse(factorFormaTxt.Text) <= 0)
            {
                controladorErrores.SetError(factorFormaTxt, "El factor de forma debe ser mayor que cero.");
                error = true;
            }
            if (decimal.Parse(numeroEtapasTxt.Text) <= 0)
            {
                controladorErrores.SetError(numeroEtapasTxt, "El numero de etapas debe ser mayor que cero.");
                error = true;
            }
            if (decimal.Parse(confianzaTxt.Text) < 0)
            {
                controladorErrores.SetError(confianzaTxt, "La confianza asociada al proyecto debe ser mayor que cero.");
                error = true;
            }

            if (error) return;

            controladorErrores.Clear();
            PROYECTO p = (PROYECTO)proyectoBS.Current;
            if(p.ESPECIE.Count>0)
            {
                TIPODISENOMUESTRAL tipoDiseno = (TIPODISENOMUESTRAL)tipoDisenoCbx.SelectedItem;
                if (tipoDiseno.DESCRIPTIPODISEMUEST == "Diseño estratificado" && !(p.LISTADODEESTRATOS.Count > 0))
                {
                    MessageBox.Show("No se ha seleccionado ningun estrato para el proyecto.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                p.LUGAR = lugarTxt.Text;
                p.DESCRIPCION = DescripcionTxt.Text;
                OBJETIVOINVENTARIO objetivo = (OBJETIVOINVENTARIO)tipoObjetivoCbx.SelectedItem;
                p.OBJETIVOINVENTARIO = objetivo;
                p.CONFIANZA = decimal.Parse(confianzaTxt.Text.Replace('.', ','));
                p.TIPODISENOMUESTRAL = tipoDiseno;
                string tipoProyecto = TipoProyectoCbx.SelectedItem.ToString();
                p.TIPOPROYECTO = tipoProyecto == "Independiente" ? "IN" : "CR";
                p.TAMANO = decimal.Parse(tamParcelaTxt.Text);
                p.LIMITINFDAP = decimal.Parse(limiteInfTxt.Text);
                p.INTMUE = decimal.Parse(intMuestreoTxt.Text);
                p.SUPTOT = decimal.Parse(AreaTotalTxt.Text);
                p.SUPMUE = p.SUPTOT * p.INTMUE/100;
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

        private void estratoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                                p.LISTADODEESTRATOS.Add(stratumData);
                            }
                            decimal total = 0.000m;
                            foreach (DataGridViewRow r in estratoDGW.Rows)
                            {
                                if (Convert.ToBoolean(r.Cells[0].Value)) total += Convert.ToDecimal(row.Cells[2].Value);
                            }
                            if (total > 100.000m)
                            {
                                errorLbl.Text = "La suma de los pesos no es 100";
                                errorLbl.ForeColor = Color.Red;
                            }
                            else if (total > 99.000m && total <= 100.000m)
                            {
                                errorLbl.Text = "Suma de pesos correcta.";
                                errorLbl.ForeColor = Color.Green;
                            }
                            else
                            {
                                errorLbl.Text = "La suma de los pesos no es 100";
                                errorLbl.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            LISTADODEESTRATOS stratumData = Program.ContextData.LISTADODEESTRATOS.Create();
                            row.Cells["Peso"].Value = 0.000m;
                            ESTRATO data = (ESTRATO)estratoBS.Current;
                            if (data != null)
                            {
                                stratumData.ESTRATO = data;
                                stratumData.PROYECTO = p;
                                p.LISTADODEESTRATOS.Remove(stratumData);
                            }
                            decimal total = 0.000m;
                            foreach (DataGridViewRow r in estratoDGW.Rows)
                            {
                                if (Convert.ToBoolean(r.Cells[0].Value)) total += Convert.ToDecimal(row.Cells[2].Value);
                            }
                            if (total > 100.000m)
                            {
                                errorLbl.Text = "La suma de los pesos no es 100";
                                errorLbl.ForeColor = Color.Red;
                            }
                            else if (total > 99.000m && total <= 100.000m)
                            {
                                errorLbl.Text = "Suma de pesos correcta.";
                                errorLbl.ForeColor = Color.Green;
                            }
                            else
                            {
                                errorLbl.Text = "La suma de los pesos no es 100";
                                errorLbl.ForeColor = Color.Red;
                            }
                        }
                    }
                }
                if (estratoDGW.Columns[e.ColumnIndex].Name == "Peso")
                {
                    DataGridViewRow row = estratoDGW.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (cellSelecion.Value != null)
                    {
                        //buscar elemento en la lista y modificarlo
                        string description = (string)row.Cells["DESCRIPESTRATO"].Value;
                        decimal peso = Convert.ToDecimal(row.Cells["Peso"].Value);
                        foreach (var lstratum in p.LISTADODEESTRATOS)
                        {
                            if (lstratum.ESTRATO.DESCRIPESTRATO == description)
                            {
                                lstratum.PESO = peso;
                            }
                        }
                        //verificar suma
                        decimal total = 0.000m;
                        foreach (DataGridViewRow r in estratoDGW.Rows)
                        {
                            if (Convert.ToBoolean(r.Cells[0].Value)) total += Convert.ToDecimal(row.Cells[2].Value);
                        }
                        if (total > 100.000m)
                        {
                            errorLbl.Text = "La suma de los pesos no es 100";
                            errorLbl.ForeColor = Color.Red;
                        }
                        else if (total > 99.000m && total <= 100.000m)
                        {
                            errorLbl.Text = "Suma de pesos correcta.";
                            errorLbl.ForeColor = Color.Green;
                        }
                        else
                        {
                            errorLbl.Text = "La suma de los pesos no es 100";
                            errorLbl.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void proyectoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            PROYECTO p = (PROYECTO)proyectoBS.Current;
            if (enableProjectList && p!=null)
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

                            if (Py != null)
                            {
                                p.PROYECTOSPORETAPA.Add(projectStageFather); //Proyectos por por etapa va a ser la lista de los hijos 
                                Py.PROYECTOSPORETAPA1.Add(projectStageFather); // proyectos por etapa 1 va a ser el campo para el padre 
                            }
                        }
                        else
                        {
                            PROYECTO Py = project.GetProject((Guid)row.Cells["Codigo"].Value);
                            //PROYECTOSPORETAPA projectStage = Program.ContextData.PROYECTOSPORETAPA.Create();
                            //projectStage.NROPROYCONTENEDOR = p.NROPROY;
                            //projectStage.NROPROYCONTENIDO = Py.NROPROY;
                            //projectStage.PESO = row.Cells["PesoProyecto"].Value != null ? (decimal)row.Cells["PesoProyecto"].Value : 0;
                            if (Py != null)
                            {
                                int pos = exitsProjectStage(p, Py);
                                
                                //revisar que no esta funcionando esta parte de quitar de la lista el proyecto por etapa
                                //p.PROYECTOSPORETAPA.Remove(projectStage);
                                //Py.PROYECTOSPORETAPA1.Remove(projectStage);
                            }
                        }
                        proyectosBS.DataSource = project.GetProjects(p.NROPROY);
                        proyectoDGW.DataSource = proyectosBS;
                    }
                }
                proyectoBS.DataSource = p;
            }
        }

        private void TipoProyectoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)cmb.SelectedItem;
            if (selectedItem.Value != null)
            {
                if (selectedItem.Value == "Contenedor")
                {
                    foreach (Control ctl in crearProyectoTab.TabPages["proyectosContTabP"].Controls) ctl.Enabled = true;
                }
                else
                {
                    foreach (Control ctl in crearProyectoTab.TabPages["proyectosContTabP"].Controls) ctl.Enabled = false;
                }
            }
        }

        private void tipoDisenoCbx_SelectedIndexChanged(object sender, EventArgs e)
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

        
        private void crearFormBtn_Click(object sender, EventArgs e)
        {
            Crear_Editar_Formulario_Form childForm = new Crear_Editar_Formulario_Form(null);
            childForm.MdiParent = this.ParentForm;
            childForm.Show();
            this.Close();
        }

        private void formulariosDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == formulariosDGW.Columns["ListarDatos"].Index && e.RowIndex >= 0)
            {
                FORMULARIO result = form.GetForm((Guid)formulariosDGW.Rows[e.RowIndex].Cells[1].Value);
                Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(result,0);
                childForm.MdiParent = this.ParentForm;
                childForm.Show();
                this.Close();
            }
        }

        private void formulariosDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void especiesDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PROYECTO p= (PROYECTO)proyectoBS.Current;
            if (p != null)
            {
                enableSpeciesList = false;
                if (p.TIPOPROYECTO == "IN") TipoProyectoCbx.SelectedIndex = 0;
                else TipoProyectoCbx.SelectedIndex = 1;
                List<ESPECIE> speciesProject = p.ESPECIE.ToList();
                foreach (DataGridViewRow row in especiesDGW.Rows)
                {
                    ESPECIE tempSpecie=null;
                    if (speciesProject.Count == 0) break;
                    foreach (ESPECIE specie in speciesProject)
                    {
                        if (specie.NOMCOMUN == row.Cells[1].Value.ToString())
                        {
                            tempSpecie = specie;
                            break;
                        }
                    }
                    if (tempSpecie!= null)
                    {
                        speciesProject.Remove(tempSpecie);
                        row.Cells[0].Value = true;
                    }
                }
                enableSpeciesList=true;
            }
        }

        private void estratosDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
                        }
                    }
                }
                enableStratumsList=true;
            }

        }

        private void actualizarBtn_Click(object sender, EventArgs e)
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

        private void AreTotalTxt_TextChanged(object sender, EventArgs e)
        {
            PROYECTO currentProject = (PROYECTO)proyectoBS.Current;
            if (currentProject!=null)
            {

                currentProject.SUPTOT = AreaTotalTxt.Text != string.Empty ? decimal.Parse(AreaTotalTxt.Text) : 0;
                currentProject.SUPMUE = currentProject.SUPTOT * currentProject.INTMUE/100;
            }
        }

        private void intMuestreoTxt_TextChanged(object sender, EventArgs e)
        {
            PROYECTO currentProject = (PROYECTO)proyectoBS.Current;
            if (currentProject != null)
            {
                currentProject.INTMUE = intMuestreoTxt.Text != string.Empty ? decimal.Parse(intMuestreoTxt.Text) : 0;
                currentProject.SUPMUE = currentProject.SUPTOT * currentProject.INTMUE/100;
            }
        }

        private void proyectoDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
                            break;
                        }
                    }
                    if(tempProject!=null)
                    {
                        row.Cells[0].Value = true;
                        projectStage.Remove(tempProject);
                    }
                }
                enableProjectList = true;
            }
        }

        public int exitsProjectStage(PROYECTO pyFather, PROYECTO pySon)
        {
            foreach(PROYECTOSPORETAPA listPy in pyFather.PROYECTOSPORETAPA)
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

        private void arbolEtapasBtn_Click(object sender, EventArgs e)
        {
            PROYECTO p = (PROYECTO)proyectoBS.Current;
            if (p != null)
            {
                Arbol_Proyectos_Por_Etapas_Form childForm = new Arbol_Proyectos_Por_Etapas_Form(p);
                childForm.MdiParent = this.ParentForm;
                childForm.Show();
            }
        }


    }
}
