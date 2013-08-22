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
    public partial class GestDatInv_Form : Form
    {
        private InventoryBL inventory;
        private SpeciesBL species;

        public GestDatInv_Form()
        {
            InitializeComponent();
            inventory = new InventoryBL();
            species = new SpeciesBL();
        }

        private void GestDatInv_Form_Load(object sender, EventArgs e)
        {
            this.criterioBusquedaCbx.SelectedIndex = 0;
            this.especiesCbx.SelectedIndex = 0;
            this.inventarioBSource.DataSource=inventory.GetInventories();
            this.especieBSource.DataSource = species.GetSpecies();
        }
    }
}
