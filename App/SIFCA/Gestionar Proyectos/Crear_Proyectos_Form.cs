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
        private ProjectBL project;
        private StationBL station;
        public Proyecto_Form()
        {
            InitializeComponent();
            project= new ProjectBL();
            station = new StationBL();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
