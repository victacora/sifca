using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;

namespace SIFCA
{
    public partial class Listar_Proyectos_Form : Form
    {

        private ProjectBL project;
        private InventoryTypeBL inventoryType;
        private SpeciesListBL speciesList;
        private StationBL station;

        public Listar_Proyectos_Form()
        {
            InitializeComponent();
            project = new ProjectBL(Program.ContextData);
            inventoryType = new InventoryTypeBL(Program.ContextData);
            speciesList = new SpeciesListBL(Program.ContextData);
            station = new StationBL(Program.ContextData);
            this.proyectoBSource.DataSource = project.GetProjects();
            this.tipoInventarioBSource.DataSource = inventoryType.GetInventoryTypes();
            this.listadoEspeciesBSource.DataSource = speciesList.GetSpeciesLists();
            this.tipoInvenCbx.DataSource = tipoInventarioBSource;
            this.tipoInvenCbx.DisplayMember = "DESCRIPTIPOINV";
            this.tipoInvenCbx.ValueMember = "NOMBRETIPOINV";
            this.tipoInvenCbx.Invalidate();
            this.nomArchCbx.DataSource = listadoEspeciesBSource;
            this.nomArchCbx.DisplayMember = "NOMARCH";
            this.nomArchCbx.ValueMember = "NOMARCH";
            this.nomArchCbx.Invalidate();
            this.estacionBSource.DataSource = station.GetStations();
            this.estacionCbx.DataSource = estacionBSource;
            this.estacionCbx.DisplayMember = "NOMBRE";
            this.estacionCbx.ValueMember = "NROEST";
            this.estacionCbx.Invalidate();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveItem_Click(object sender, EventArgs e)
        {

        }
                
    }
}
