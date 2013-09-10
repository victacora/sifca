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

namespace SIFCA.Gestion_de_Especies
{
    public partial class Listado_Especies_Form : Form
    {
        private SpeciesBL species;
        private GroupBL groups;

        public Listado_Especies_Form()
        {
            InitializeComponent();
            species = new SpeciesBL(Program.ContextData);
            groups = new GroupBL(Program.ContextData);
            this.especieBSource.DataSource = species.GetSpecies();
            this.grupoComercialBSource.DataSource = groups.GetGroups();
            this.ListadoEspecies.DataSource = especieBSource;
            this.criterioBusquedaCbx.SelectedIndex = 0;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var newLine = new ESPECIE();
            newLine.GRUPOCOM = "PV";
            newLine.FAMILIA = string.Empty;
            newLine.NOMCIENTIFICO = string.Empty;
            newLine.NOMCOMUN= string.Empty;
            newLine.ZONADEVIDA = string.Empty;
            newLine.ZONAGEOGRAFICA= string.Empty;
            newLine.DIAMMINCORTE = 0;
            species.InsertSpecie(newLine);
            species.SaveChanges();
            especieBSource.Add(newLine);
            especieBSource.EndEdit();
            ListadoEspecies.Refresh();

        }


        private void especieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            species.SaveChanges();
        }

        private void ListadoEspecies_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (ListadoEspecies.Rows.Count != 0)
            {
                DataGridViewRow row = ListadoEspecies.Rows[e.RowIndex];
                string specieCode = row.Cells["Codigo"].Value.ToString();
                species.DeleteSpecies(int.Parse(specieCode));
            }

        }

    }
}
