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
    public partial class Crear_Listado_Especies : Form
    {
        private TypeUseBL listSpecies;
        private SpeciesBL species;

        public Crear_Listado_Especies()
        {
            InitializeComponent();
            species = new SpeciesBL(Program.ContextData);
            listSpecies = new TypeUseBL(Program.ContextData);
            this.SpeciesBSource.DataSource = species.GetSpecies();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //int c = this.listaEspecies.Items.Count - 1;
            //for (int i = c; i >= 0; i--)
            //{
            //    if (this.listaEspecies.GetSelected(i))
            //    {
            //        this.listSpeciesBSource.DataSource = (this.listaEspecies.Items[i]);
            //        this.listadoEspecies.DataSource = listSpeciesBSource; 
            //        //this.listadoEspecies.Items.Add(this.listaEspecies.Items[i]);
            //        //this.listaEspecies.Items.RemoveAt(i);
            //    }
            //}           
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //this.listadoEspecies.Items.Remove(this.listadoEspecies.SelectedIndex);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
