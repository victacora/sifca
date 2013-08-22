﻿using System;
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
            this.inventarioDataGridView.DataSource = this.inventarioBSource;
        }

        private void inventarioDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //TODO: solucionar el error System.ArgumentException: DataGridViewComboBoxCell value is not valid
        }
        
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var newLine = new INVENTARIO();
            newLine.NROPROY = 1;
            newLine.ALTCOMER_M = 0;
            newLine.ALTTOT_M = 0;
            newLine.AREABASAL = 0;
            newLine.CAP = 0;
            newLine.DAP = 0;
            newLine.VOLCOM = 0;
            newLine.VOLTOT = 0;
            newLine.PARCELA = 0;
            //TODO:
            //newLine.NROEST = recuperar el identificar de la estacion;
            newLine.CODESP = 1;
            newLine.CODEST = 1;
            newLine.CODETAPA = 1;
            newLine.CODCALIDAD = 1;
            newLine.PARCELA = 0;
            newLine.NROARB = 0;
            newLine.ESTADO = "AI";
            inventarioBSource.Add(newLine);
            inventarioDataGridView.Refresh();
        }

        private void iNVENTARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            inventory.SaveChanges();
        }

    }
}
