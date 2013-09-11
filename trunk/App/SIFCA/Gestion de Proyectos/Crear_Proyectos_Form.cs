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
        List<ESPECIE> listEspecies;
        List<LISTADODEESTRATOS> litsStratum;
        List<PROYECTO> listProjects;

        public Crear_Proyecto_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            project = new ProjectBL(Program.ContextData);
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

        private void AceptarBtn3_Click(object sender, EventArgs e)
        {
            PROYECTO newProject = new PROYECTO();
            //Deshabilitar el proyecto activo cambiado su estado
            PROYECTO activateProject = (PROYECTO)Program.Cache.Get("principalProject");
           // ESTACION stationData = (ESTACION)Program.Cache.Get("localStation");            
            if (activateProject != null)
            {
             //   activateProject.ESTADOPROY = "I";
                project.UpdateProject(activateProject);
                project.SaveChanges();
            }
            //newProject.LUGAR = lugarTxt.Text;
            //newProject.NOMARCH = lugarTxt.Text;
            //newProject.ESTADOPROY = "A";
            //if (stationData != null)
            //{
            //    newProject.NROEST = stationData.NROEST;
            //}
            //newProject.TAMANO = int.Parse(tamParcelaTxt.Text);
            //newProject.LIMTINFDAP = int.Parse(limiteInfTxt.Text);
            //newProject.LIMTSUPDAP = int.Parse(limiteSupTxt.Text);
            //newProject.INTMUE = decimal.Parse(intMuestreoTxt.Text);
            //newProject.SUPMUE =decimal.Parse(AreaMuestradaTxt.Text);
            //newProject.AREAFUSTALESPORPARCELA = decimal.Parse(areaFustalesTxt.Text);
            //newProject.FACTORDEFORMA = decimal.Parse(factorFormaTxt.Text);
            //newProject.NOMARCH = listaEspCbx.SelectedValue.ToString();
            //newProject.NOMBRETIPOINV = tipoObjetivoCbx.SelectedValue.ToString();
            //project.InsertProject(newProject);
            //project.SaveChanges();
            Program.Cache.Set("principalProject", newProject, new CacheItemPolicy());
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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

        private void Siguiente_Click(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {

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
            if (especiesDGW.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                DataGridViewRow row = especiesDGW.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cellSelecion.Value != null)
                {
                    if (cellSelecion.Value != "")
                    {
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            ESPECIE esp = new ESPECIE();
                            esp.NOMCOMUN = (string)row.Cells["NOMCOMUN"].Value;
                            esp.NOMCIENTIFICO = (string)row.Cells["NOMCIENTIFICO"].Value;
                            esp.FAMILIA = (string)row.Cells["FAMILIA"].Value;
                            listEspecies.Add(esp);
                        }
                        else
                        {
                            ESPECIE esp = new ESPECIE();
                            esp.NOMCOMUN = (string)row.Cells["NOMCOMUN"].Value;
                            esp.NOMCIENTIFICO = (string)row.Cells["NOMCIENTIFICO"].Value;
                            esp.FAMILIA = (string)row.Cells["FAMILIA"].Value;
                            listEspecies.Remove(esp);
                        }
                    }
                }

            }
        }

        private void estratoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void proyectoDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tipoDisenoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoProyectoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
