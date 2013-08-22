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
    public partial class Listado_Especies_Form : Form
    {
        private SpeciesBL species;

        public Listado_Especies_Form()
        {
            InitializeComponent();
            species = new SpeciesBL();
            this.especieBSource.DataSource = species.GetSpecies();            
        }

        private void Listado_Especies_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
