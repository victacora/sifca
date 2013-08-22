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
        private SpeciesBL species;

        public GestDatInv_Form()
        {
            InitializeComponent();
            inventory = new InventoryBL();
            species = new SpeciesBL();
            this.inventarioBSource.DataSource = inventory.GetInventories();
            this.especieBSource.DataSource = species.GetSpecies();
            this.Especie.DataSource = especieBSource;
            this.criterioBusquedaCbx.SelectedIndex = 0;
            this.especiesCbx.SelectedIndex = 0;
        }
    }
}
