using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;

namespace SIFCA.Gestionar_Especies
{
    public partial class Crear_Listado_Especies : Form
    {
        private SpeciesListBL listSpecies;
        private SpeciesBL species;

        public Crear_Listado_Especies()
        {
            InitializeComponent();
            species = new SpeciesBL(ContextProvider.ContextData);
            listSpecies = new SpeciesListBL(ContextProvider.ContextData);
            this.speciesBSource.DataSource = species.GetSpecies();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.listadoEspecies.Items.Add(this.listaEspecies.SelectedItem);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.listadoEspecies.Items.Remove(this.listadoEspecies.SelectedIndex);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
