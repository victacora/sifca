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
        private TypeSampleDesignBl typeExample;
        private ObjectiveInventoryBL objetiveInventory;
        private StratumBL stratum;
        private SpeciesBL species;
        private List<LISTADODEESTRATOS> litsStratum;
        private List<PROYECTO> listProjects;
        private PROYECTO newProject;

        public Actualizar_Proyectos_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            newProject = new PROYECTO();
            litsStratum = new List<LISTADODEESTRATOS>();
            listProjects = new List<PROYECTO>();
            project = new ProjectBL(Program.ContextData);
            typeExample = new TypeSampleDesignBl (Program.ContextData);
            objetiveInventory = new ObjectiveInventoryBL(Program.ContextData);
            stratum = new StratumBL(Program.ContextData);
            species = new SpeciesBL(Program.ContextData);
            PROYECTO p = (PROYECTO)Program.Cache.Get("project");

            proyectoBS.DataSource = p;
            proyectoDGW.DataSource = proyectoBS;

            objetivoInventarioBS.DataSource= objetiveInventory.GetObjectiveInventories();
            tipoObjetivoCbx.DataSource = objetivoInventarioBS;
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("IN", "Independiente"));
            data.Add(new KeyValuePair<string, string>("CR", "Contenedor"));
            TipoProyectoCbx.DataSource = data;
            TipoProyectoCbx.DisplayMember = "Value";
            TipoProyectoCbx.ValueMember = "Key";           

            tipoDisenoBS.DataSource = typeExample.GetTypeSampleDesignList();
            tipoDisenoCbx.DataSource = tipoDisenoBS;
            
            especieBS.DataSource = species.GetSpecies();
            especiesDGW.DataSource = especieBS;

            formulariosBS.DataSource = p.FORMULARIO;
            formulariosDGW.DataSource = formulariosBS;

            estratoBS.DataSource = stratum.GetStratums();
            estratosDGW.DataSource = estratoBS;
            

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
                newProject.NROPROY = Guid.NewGuid();
                newProject.USUARIO = (USUARIO)Program.Cache.Get("user");
                newProject.LUGAR = lugarTxt.Text;
                newProject.DESCRIPCION = DescripcionTxt.Text;
                OBJETIVOINVENTARIO objetivo = (OBJETIVOINVENTARIO)tipoObjetivoCbx.SelectedItem;
                TIPODISENOMUESTRAL tipoDiseno = (TIPODISENOMUESTRAL)tipoDisenoCbx.SelectedItem;
                newProject.OBJETIVOINVENTARIO = objetivo;
                newProject.TIPODISENOMUESTRAL = tipoDiseno;
                //newProject.TIPOPROYECTO = TipoProyectoTxt.Text=="Independiente"?"IN":"CR";
                newProject.TAMANO = decimal.Parse(tamParcelaTxt.Text);
                newProject.LIMITINFDAP = decimal.Parse(limiteInfTxt.Text);
                newProject.LIMITSUPDAP = decimal.Parse(limiteSupTxt.Text);
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
                string commonName = (string)row.Cells["NOMCOMUN"].Value;
                string scientificName = (string)row.Cells["NOMCIENTIFICO"].Value;
                ESPECIE data = species.GetSpecieByComNameAndScienName(commonName, scientificName);
                if (data != null) newProject.ESPECIE.Add(data);
            }
        }

        private void RemoverEspciesBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in especiesDGW.Rows)
            {
                row.Cells[0].Value = false;
                string commonName = (string)row.Cells["NOMCOMUN"].Value;
                string scientificName = (string)row.Cells["NOMCIENTIFICO"].Value;
                ESPECIE data = species.GetSpecieByComNameAndScienName(commonName, scientificName);
                if (data != null) newProject.ESPECIE.Remove(data);
            }
        }

        private void SeleccEstratosBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in estratosDGW.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void removerEstratosBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in estratosDGW.Rows)
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
            if (estratosDGW.Columns[e.ColumnIndex].Name == "Estratos")
            {
                DataGridViewRow row = estratosDGW.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cellSelecion.Value != null)
                {
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        LISTADODEESTRATOS stratumData = new LISTADODEESTRATOS();
                        string descripcion = (string)row.Cells["DESCRIPESTRATO"].Value;
                        stratumData.PESO = row.Cells["Peso"].Value!=null?(decimal)row.Cells["Peso"].Value:0;
                        litsStratum.Add(stratumData);
                    }
                    else
                    {
                        LISTADODEESTRATOS stratumData = new LISTADODEESTRATOS();
                        string description = (string)row.Cells["DESCRIPESTRATO"].Value;
                        stratumData.PESO = row.Cells["Peso"].Value != null ? (decimal)row.Cells["Peso"].Value : 0;
                        litsStratum.Remove(stratumData);
                    }
                }

            }
        }

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
            Crear_Formulario_Form childForm = new Crear_Formulario_Form();
            childForm.MdiParent = this.ParentForm;
            childForm.Show();
            this.Close();
        }

        private void formulariosDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == formulariosDGW.Columns["ListarDatos"].Index && e.RowIndex >= 0)
            {
                Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form();
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
                if (p.TIPOPROYECTO == "IN") TipoProyectoCbx.SelectedIndex = 0;
                else TipoProyectoCbx.SelectedIndex = 1;
                List<ESPECIE> speciesProject = p.ESPECIE.ToList();
                foreach (DataGridViewRow row in especiesDGW.Rows)
                {
                    ESPECIE tempSpecie = new ESPECIE();
                    foreach (ESPECIE specie in speciesProject)
                    {
                        if (specie.NOMCOMUN == row.Cells[1].Value.ToString())
                        {
                            tempSpecie = specie;
                            break;
                        }
                    }
                    if (tempSpecie.NOMCOMUN != "")
                    {
                        speciesProject.Remove(tempSpecie);
                        row.Cells[0].Value = true;
                    }
                }
            }
        }

        private void estratosDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PROYECTO p = (PROYECTO)proyectoBS.Current;
            if (p != null)
            {
                List<LISTADODEESTRATOS> stratumsProject = p.LISTADODEESTRATOS.ToList();
                foreach (DataGridViewRow row in estratosDGW.Rows)
                {
                    LISTADODEESTRATOS tempStratum = new LISTADODEESTRATOS();
                    foreach (LISTADODEESTRATOS stratum in stratumsProject)
                    {
                        if (stratum.ESTRATO.DESCRIPESTRATO == row.Cells[1].Value.ToString())
                        {
                            tempStratum = stratum;
                            tempStratum.ESTRATO = stratum.ESTRATO;
                            break;
                        }
                    }
                    if (tempStratum.ESTRATO != null)
                    {
                        if (tempStratum.ESTRATO.DESCRIPESTRATO != "")
                        {
                            stratumsProject.Remove(tempStratum);
                            row.Cells[0].Value = true;
                            row.Cells[2].Value = tempStratum.PESO;
                        }
                    }
                }
            }

        }
        

    }
}
