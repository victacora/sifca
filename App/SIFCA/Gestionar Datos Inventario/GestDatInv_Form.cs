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
        private FormBL inventory;
        private UserBL stations;
        private SpeciesBL species;
        private StateBL states;
        private StageBL stages;
        private StratumBL stratum;
        private QualityBL qualities;

        public GestDatInv_Form()
        {
            InitializeComponent();

            inventory = new FormBL(Program.ContextData);
            species = new SpeciesBL(Program.ContextData);
            stations = new UserBL(Program.ContextData);
            states = new StateBL(Program.ContextData);
            stratum = new StratumBL(Program.ContextData);
            qualities = new QualityBL(Program.ContextData);

            /*this.inventarioBSource.DataSource = inventory.GetInventories();
            this.especieBSource.DataSource = species.GetSpecies();
            this.estacionBSource.DataSource = stations.GetStations();
            this.calidadBSource.DataSource = qualities.GetQualities();
            this.estratoBSource.DataSource = stratum.GetStratums();
            this.estadoSaniBSource.DataSource = states.GetStates();
            this.etapaBSource.DataSource = stages.GetStages();
            this.criterioBusquedaCbx.SelectedIndex = 0;*/
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
            PROYECTO project = (PROYECTO)Program.Cache.Get("principalProject");
            ESTACION station = (ESTACION)Program.Cache.Get("localStation");
            newLine.NROPROY = project.NROPROY;
            newLine.NROEST = station.NROEST;
            newLine.ALTCOMER_M = 0;
            newLine.ALTTOT_M = 0;
            newLine.AREABASAL = 0;
            newLine.CAP = 0;
            newLine.DAP = 0;
            newLine.VOLCOM = 0;
            newLine.VOLTOT = 0;
            newLine.PARCELA = 0;
            newLine.CODESP = 1;
            newLine.CODEST = 1;
            newLine.CODETAPA = 1;
            newLine.CODCALIDAD = 1;
            newLine.PARCELA = 0;
            newLine.NROARB = 0;
            newLine.ESTADO = "AI";
            inventarioBSource.Add(newLine);
            inventory.InsertInventory(newLine);
            inventarioBSource.EndEdit();
            inventarioDataGridView.Refresh();
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            inventory.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void inventarioDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (inventarioDataGridView.Rows.Count != 0)
            {
                DataGridViewRow row = inventarioDataGridView.Rows[e.RowIndex];
                string project = row.Cells["Proyecto"].Value.ToString();
                string nroStation=row.Cells["Estacion"].Value.ToString();
                string parcel=row.Cells["Parcela"].Value.ToString();
                string tree=row.Cells["Arbol"].Value.ToString();
                inventory.DeleteInventory(int.Parse(project), Guid.Parse(nroStation), int.Parse(parcel), int.Parse(tree));
            }
        }

        private void criterioBusquedaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: buscar por el criterio elegido ademas de paginar
        }

        private void especiesCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: cambiar el texto de los combobox en especies de nombres comunes a cientificos
        }



    }
}
