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
        private List<PROYECTO> listProjects;
        private PROYECTO newProject;
        
        public Crear_Proyecto_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            newProject = new PROYECTO();
            listProjects = new List<PROYECTO>();
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
            proyectoBS.DataSource = project.GetProjects();
            proyectoDGW.DataSource = proyectoBS;
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
                newProject.DESCRIPCION = DescripcionTxt.Text;
                OBJETIVOINVENTARIO objetivo = (OBJETIVOINVENTARIO)tipoObjetivoCbx.SelectedItem;
                newProject.OBJETIVOINVENTARIO = objetivo;
                newProject.TIPODISENOMUESTRAL = tipoDiseno;
                string tipoProyecto = TipoProyectoCbx.SelectedItem.ToString();
                newProject.TIPOPROYECTO = tipoProyecto=="Independiente"?"IN":"CR";
                newProject.TAMANO = int.Parse(tamParcelaTxt.Text);
                newProject.LIMITINFDAP = int.Parse(limiteInfTxt.Text);
                newProject.LIMITSUPDAP = int.Parse(limiteSupTxt.Text);
                newProject.INTMUE = decimal.Parse(intMuestreoTxt.Text);
                newProject.SUPMUE = decimal.Parse(AreaMuestradaTxt.Text);
                newProject.AREAFUSTALESPORPARCELA = decimal.Parse(areaFustalesTxt.Text);
                newProject.FACTORDEFORMA = decimal.Parse(factorFormaTxt.Text);
                newProject.FECHA = DateTime.Today;
                newProject.NUMEROETAPAS = int.Parse(numeroEtapasTxt.Text);
                project.InsertProject(newProject);
                project.SaveChanges();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
                DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cellSelecion.Value != null)
                {
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            string commonName = (string)row.Cells["NOMCOMUN"].Value;
                            string scientificName = (string)row.Cells["NOMCIENTIFICO"].Value;
                            ESPECIE data = species.GetSpecieByComNameAndScienName(commonName, scientificName);
                            if(data!=null)newProject.ESPECIE.Add(data);
                        }
                        else
                        {
                            string commonName = (string)row.Cells["NOMCOMUN"].Value;
                            string scientificName = (string)row.Cells["NOMCIENTIFICO"].Value;
                            ESPECIE data = species.GetSpecieByComNameAndScienName(commonName, scientificName);
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
                DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cellSelecion.Value != null)
                {
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        LISTADODEESTRATOS stratumData = new LISTADODEESTRATOS();
                        string description = (string)row.Cells["DESCRIPESTRATO"].Value;
                        stratumData.PESO =Convert.ToDecimal(row.Cells["Peso"].Value);
                        ESTRATO data = stratum.GetStratumByDescription(description);
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
                        LISTADODEESTRATOS stratumData = new LISTADODEESTRATOS();
                        string description = (string)row.Cells["DESCRIPESTRATO"].Value;
                        stratumData.PESO = Convert.ToDecimal(row.Cells["Peso"].Value); 
                        row.Cells["Peso"].Value = 0.000m;
                        ESTRATO data = stratum.GetStratumByDescription(description);
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
                        PROYECTO projectData = new PROYECTO();
                        projectData.LUGAR = (string)row.Cells["LUGAR"].Value;
                        projectData.FECHA = (DateTime)row.Cells["FECHA"].Value;
                        projectData.NOMBRETIPOINV = (string)row.Cells["NOMBRETIPOINV"].Value;
                        projectData.NOMTIPODISEMUEST = (string)row.Cells["NOMTIPODISEMUEST"].Value;
                        decimal peso = row.Cells["PesoProyecto"].Value != null ? (decimal)row.Cells["PesoProyecto"].Value : 0;
                        listProjects.Add(projectData);
                    }
                    else
                    {
                        PROYECTO projectData = new PROYECTO();
                        projectData.LUGAR = (string)row.Cells["LUGAR"].Value;
                        projectData.FECHA = (DateTime)row.Cells["FECHA"].Value;
                        projectData.NOMBRETIPOINV = (string)row.Cells["NOMBRETIPOINV"].Value;
                        projectData.NOMTIPODISEMUEST = (string)row.Cells["NOMTIPODISEMUEST"].Value;
                        decimal peso = row.Cells["PesoProyecto"].Value != null ? (decimal)row.Cells["PesoProyecto"].Value : 0;
                        listProjects.Remove(projectData);
                    }
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
    }
}
