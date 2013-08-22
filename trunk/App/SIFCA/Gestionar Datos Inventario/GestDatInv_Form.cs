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

namespace SIFCA
{
    public partial class GestDatInv_Form : Form
    {
        private InventoryBL inventory;
        private StationBL stations;
        private SpeciesBL species;
        private StateBL states;
        private StageBL stages;
        private StratumBL stratum;
        private QualityBL qualities;

        public GestDatInv_Form()
        {
            InitializeComponent();

            inventory = new InventoryBL();
            species = new SpeciesBL();
            stations = new StationBL();
            states = new StateBL();
            stages = new StageBL();
            stratum = new StratumBL();
            qualities = new QualityBL();

            this.inventarioBSource.DataSource = inventory.GetInventories();
            this.especieBSource.DataSource = species.GetSpecies();
            this.estacionBSource.DataSource = stations.GetStations();
            this.calidadBSource.DataSource = qualities.GetQualities();
            this.estratoBSource.DataSource = stratum.GetStratums();
            this.estadoSaniBSource.DataSource = states.GetStates();
            this.etapaBSource.DataSource = stages.GetStages();
            this.criterioBusquedaCbx.SelectedIndex = 0;
            this.especiesCbx.SelectedIndex = 0;
        }

        private void inventarioDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

    }
}
