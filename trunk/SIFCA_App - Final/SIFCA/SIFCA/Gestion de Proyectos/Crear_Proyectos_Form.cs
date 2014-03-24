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
   
    public partial class Crear_Proyecto_Form : Form
    {
        private ProjectBL project;
        private TypeSampleDesignBl typeExample;
        private ObjectiveInventoryBL objetiveInventory;
        private StratumBL stratum;
        private SpeciesBL species;
        private PROYECTO newProject;
        private List<PROYECTOSPORETAPA> listProjectsByStage;
        private int[] vector;
        private bool modificate;
        public Crear_Proyecto_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            newProject = Program.ContextData.PROYECTO.Create();
            project = new ProjectBL(Program.ContextData);
            estratoDGW.Columns[2].DefaultCellStyle.Format = "0.000##";
            typeExample = new TypeSampleDesignBl (Program.ContextData);
            objetiveInventory = new ObjectiveInventoryBL(Program.ContextData);
            stratum = new StratumBL(Program.ContextData);
            species = new SpeciesBL(Program.ContextData);
            objetivoInventarioBS.DataSource= objetiveInventory.GetObjectiveInventories();
            tipoObjetivoCbx.DataSource = objetivoInventarioBS;
            tipoObjetivoCbx.SelectedIndex = 0;
            TipoProyectoCbx.SelectedIndex = 0;
            tipoDisenoBS.DataSource = typeExample.GetTypeSampleDesignList();
            tipoDisenoCbx.DataSource = tipoDisenoBS;
            tipoDisenoCbx.SelectedIndex = 0;
            estratoBS.DataSource = stratum.GetStratums();
            estratoDGW.DataSource = estratoBS;
            especieBS.DataSource = species.GetSpecies();
            especiesDGW.DataSource=especieBS;
            proyectoBS.DataSource = project.GetProjectsFree(Guid.Empty);
            proyectoDGW.DataSource = proyectoBS;
            listProjectsByStage = new List<PROYECTOSPORETAPA>();
            this.vector = new int[3]{0,0,0};
            this.modificate = true;
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
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (lugarTxt.Text=="")
            {
                controladorErrores.SetError(lugarTxt, "El campo lugar es requerido.");
                error = true;
            }
            if (decimal.Parse(tamParcelaTxt.Text)<=0)
            {
                controladorErrores.SetError(lugarTxt, "El tamaño de la parcela debe ser mayor que cero.");
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

            if(newProject.ESPECIE.Count>0)
            {
                TIPODISENOMUESTRAL tipoDiseno = (TIPODISENOMUESTRAL)tipoDisenoCbx.SelectedItem;
                if(tipoDiseno.DESCRIPTIPODISEMUEST=="Diseño estratificado"&&!(newProject.LISTADODEESTRATOS.Count>0))
                {
                    MessageBox.Show("No se ha seleccionado ningun estrato para el proyecto.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newProject.NROPROY = Guid.NewGuid();
                newProject.USUARIO = (USUARIO)Program.Cache.Get("user");
                newProject.LUGAR = lugarTxt.Text;
                newProject.CONFIANZA = decimal.Parse(confianzaTextBox.Text.Replace('.', ','));
                newProject.DESCRIPCION = DescripcionTxt.Text;
                OBJETIVOINVENTARIO objetivo = (OBJETIVOINVENTARIO)tipoObjetivoCbx.SelectedItem;
                newProject.OBJETIVOINVENTARIO = objetivo;
                newProject.TIPODISENOMUESTRAL = tipoDiseno;
                string tipoProyecto = TipoProyectoCbx.SelectedItem.ToString();
                newProject.TIPOPROYECTO = tipoProyecto=="Independiente"?"IN":"CR";
                newProject.TAMANO = decimal.Parse(tamParcelaTxt.Text.Replace('.', ','));
                newProject.LIMITINFDAP = decimal.Parse(limiteInfTxt.Text.Replace('.', ','));
                newProject.INTMUE = decimal.Parse(intMuestreoTxt.Text.Replace('.', ','));
                newProject.SUPTOT = decimal.Parse(AreaTotalTxt.Text.Replace('.', ','));
                newProject.SUPMUE= newProject.SUPTOT * newProject.INTMUE/100;
                newProject.AREAFUSTALESPORPARCELA = decimal.Parse(areaFustalesTxt.Text.Replace('.', ','));
                newProject.FACTORDEFORMA = decimal.Parse(factorFormaTxt.Text.Replace('.', ','));
                newProject.FECHA = DateTime.Today;
                newProject.ETAPA = int.Parse(numeroEtapasTxt.Text);
                foreach(PROYECTOSPORETAPA pyByStage in listProjectsByStage)
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
                            if(data!=null)newProject.ESPECIE.Add(data);
                        }
                        else
                        {
                            ESPECIE data = (ESPECIE)especieBS.Current;
                            if (data != null) newProject.ESPECIE.Remove(data);
                        }
                }

            }
        }

        private void estratoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                            newProject.LISTADODEESTRATOS.Add(stratumData);
                        }
                        decimal total=0.000m;
                        foreach (DataGridViewRow r in estratoDGW.Rows)
                        {
                            if (Convert.ToBoolean(r.Cells[0].Value)) total += Convert.ToDecimal(row.Cells[2].Value); 
                        }
                        if (total>100.000m)
                        {
                            errorLbl.Text = "La suma de los pesos no es 100";
                            errorLbl.ForeColor = Color.Red;
                        }
                        else if(total>99.000m&&total<=100.000m)
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
                            stratumData.PROYECTO = newProject;
                            newProject.LISTADODEESTRATOS.Remove(stratumData);
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
                    foreach (var lstratum in newProject.LISTADODEESTRATOS)
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

        //TODO: modificar que agregue los proyectos y modificar la base de datos para que acepte el peso del proyecto
        private void proyectoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                        
                        projectStageFather.NROPROYCONTENEDOR = newProject.NROPROY;
                        projectStageFather.NROPROYCONTENIDO = Py.NROPROY;
                        projectStageFather.ETAPA = newProject.ETAPA + 1;
                        projectStageFather.PESO = row.Cells["PesoProyecto"].Value != null ? (decimal)row.Cells["PesoProyecto"].Value : 0; 
                        
                        if (Py!=null)
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
                //verificar suma
                //decimal total = 0.000m;
                //foreach (DataGridViewRow r in proyectoDGW.Rows)
                //{
                //    if (Convert.ToBoolean(r.Cells[0].Value)) total += Convert.ToDecimal(row.Cells["PesoProyecto"].Value);
                //}
                //if (total > 100.000m)
                //{
                //    errorLbl.Text = "La suma de los pesos no es 100";
                //    errorLbl.ForeColor = Color.Red;
                //}
                //else if (total > 99.000m && total <= 100.000m)
                //{
                //    errorLbl.Text = "Suma de pesos correcta.";
                //    errorLbl.ForeColor = Color.Green;
                //}
                //else
                //{
                //    errorLbl.Text = "La suma de los pesos no es 100";
                //    errorLbl.ForeColor = Color.Red;
                //}

            }
        }

        public int UnSelectProjectByStage(PROYECTO Py)
        {
            int pos = 0;
            foreach (PROYECTOSPORETAPA pjStage in listProjectsByStage)
            {
                if (pjStage.NROPROYCONTENIDO == Py.NROPROY) return pos;
                pos++;
            }
            return -1;
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

        private void TipoProyectoCbx_SelectedIndexChanged(object sender, EventArgs e)
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

         private void estratoDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in estratoDGW.Rows)
            {
                row.Cells[2].Value = 0.000m;
            }
        }

         private void actualizarBtn_Click(object sender, EventArgs e)
         {
             int count=0;
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

         private void actualizarPesoProyectosEtapasBtn_Click(object sender, EventArgs e)
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

        
         private void validatedNumericValues(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
             {
                 e.Handled = true;
             }
             // only allow one decimal point
             if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
             {
                 e.Handled = true;
             }
             if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
             {
                 e.Handled = true;
             }
         }

         private void updateVectorChanged(int pos)
         {
             if (vector.Sum() < 2)
             {
                 this.vector[pos] = 1;
             }
             this.calculateValues();
         }

         private void calculateValues()
         {
             if (modificate)
             {
                 modificate = false;
                 if (vector.Sum() == 2)
                 {
                     //si se ingreso area total y intensidad de muestreo se calcula el area muestreada
                     if (vector[0] == 1 && vector[1] == 1)
                     {
                         areaMuestrearTxt.Text = (decimal.Parse(AreaTotalTxt.Text.Replace('.', ',')) * (decimal.Parse(intMuestreoTxt.Text.Replace('.', ',')) / 100)).ToString();
                         areaMuestrearTxt.Text = decimal.Round(decimal.Parse(areaMuestrearTxt.Text), 3).ToString();
                     }
                     else //si se ingreso area total y area muestreada se calcula intensidad de muestreo
                         if (vector[0] == 1 && vector[2] == 1)
                         {
                             intMuestreoTxt.Text = (((decimal.Parse(areaMuestrearTxt.Text.Replace('.', ','))) / (decimal.Parse(AreaTotalTxt.Text.Replace('.', ','))) * 100)).ToString();
                             intMuestreoTxt.Text = decimal.Round(decimal.Parse(intMuestreoTxt.Text), 3).ToString();
                         }
                         else//si ingreso intensidad de muestreo y area muestreada se calcula el area total
                             if (vector[1] == 1 && vector[2] == 1)
                             {
                                 AreaTotalTxt.Text = ((decimal.Parse(areaMuestrearTxt.Text.Replace('.', ','))) / ((decimal.Parse(intMuestreoTxt.Text.Replace('.', ','))) / 100)).ToString();
                                 AreaTotalTxt.Text = decimal.Round(decimal.Parse(AreaTotalTxt.Text), 3).ToString();
                             }
                 }
                 modificate = true;
             }
         }
         private void AreaTotalTxt_TextChanged(object sender, EventArgs e)
         {
             if (AreaTotalTxt.Text == "" || AreaTotalTxt.Text == "0" || AreaTotalTxt.Text == "0.0" || AreaTotalTxt.Text == "0,0")
             {
                 this.vector[0] = 0;
             }else
             this.updateVectorChanged(0);
         }
        
         private void intMuestreoTxt_TextChanged(object sender, EventArgs e)
         {
             if (intMuestreoTxt.Text == "" || intMuestreoTxt.Text == "0" || intMuestreoTxt.Text == "0.0" || intMuestreoTxt.Text == "0,0")
             {
                 this.vector[1] = 0;
             }
             else
             this.updateVectorChanged(1);
         }

         private void areaMuestrearTxt_TextChanged(object sender, EventArgs e)
         {
             if (areaMuestrearTxt.Text == "" || areaMuestrearTxt.Text == "0" || areaMuestrearTxt.Text == "0.0" || areaMuestrearTxt.Text == "0,0")
             {
                 this.vector[2] = 0;
             }
             else
             this.updateVectorChanged(2);
         }

    }
}
