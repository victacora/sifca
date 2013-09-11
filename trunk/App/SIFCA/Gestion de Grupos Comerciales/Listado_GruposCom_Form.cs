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

namespace SIFCA.Gestion_de_GruposCom
{
    public partial class Listado_GruposCom_Form : Form
    {
        private GroupBL group;

        public Listado_GruposCom_Form()
        {
            InitializeComponent();
            group = new GroupBL(Program.ContextData);
            this.grupoComBSource.DataSource = group.GetGroups();
            this.ListadoEspecies.DataSource = grupoComBSource;
            this.criterioBusquedaCbx.SelectedIndex = 0;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var newLine = new GRUPOCOMERCIAL();
            newLine.DESCRIPGRUPO = string.Empty;
            group.InsertGroup(newLine);
            group.SaveChanges();
            grupoComBSource.Add(newLine);
            grupoComBSource.EndEdit();
            ListadoEspecies.Refresh();

        }


        private void especieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            group.SaveChanges();
        }

        private void ListadoEspecies_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (ListadoEspecies.Rows.Count != 0)
            {
                DataGridViewRow row = ListadoEspecies.Rows[e.RowIndex];
                string specieCode = row.Cells["Codigo"].Value.ToString();
                group.DeleteGroup(int.Parse(specieCode));
            }

        }

    }
}
