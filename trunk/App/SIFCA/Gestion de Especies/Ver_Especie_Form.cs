using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;

namespace SIFCA.Gestion_de_Especies
{
    public partial class Ver_Especie_Form : Form
    {
        SpeciesBL specie = new SpeciesBL(Program.ContextData);
        public Ver_Especie_Form()
        {
            InitializeComponent();
            SpecieBSource.DataSource = specie.GetSpecies();
        }
    }
}
