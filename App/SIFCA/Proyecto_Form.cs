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
    public partial class Proyecto_Form : Form
    {
        public Proyecto_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ProyectoBL proyecto = new ProyectoBL();
            this.proyectoBindingSource.DataSource =proyecto.GetProjects();
        }

        private void ProyectoBindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void proyectoBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void proyectoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
