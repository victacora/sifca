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

namespace SIFCA.Gestion_de_Estratos
{
    public partial class Listado_Estratos_Form : Form
    {
        private StratumBL stratum;

        public Listado_Estratos_Form()
        {
            InitializeComponent();
            stratum = new StratumBL(Program.ContextData);
            this.estratoBSource.DataSource = stratum.GetStratums();
            this.ListadoEspecies.DataSource = estratoBSource;
            this.criterioBusquedaCbx.SelectedIndex = 0;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var newLine = new ESTRATO();
            newLine.DESCRIPESTRATO = string.Empty;
            stratum.InsertStratum(newLine);
            stratum.SaveChanges();
            estratoBSource.Add(newLine);
            estratoBSource.EndEdit();
            ListadoEspecies.Refresh();

        }


        private void especieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            stratum.SaveChanges();
        }

        private void ListadoEspecies_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (ListadoEspecies.Rows.Count != 0)
            {
                DataGridViewRow row = ListadoEspecies.Rows[e.RowIndex];
                string specieCode = row.Cells["Codigo"].Value.ToString();
                stratum.DeleteStratum(int.Parse(specieCode));
            }

        }

    }
}
