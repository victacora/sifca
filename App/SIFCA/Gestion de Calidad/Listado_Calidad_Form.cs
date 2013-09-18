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

namespace SIFCA.Gestion_de_Calidad
{
    public partial class Listado_Calidad_Form : Form
    {
        private CALIDAD quality;
        private QualityBL qualityBl;

        public Listado_Calidad_Form()
        {

            InitializeComponent();
            qualityBl = new QualityBL(Program.ContextData);
            QualityBSource.DataSource = qualityBl.GetQualities();
        }
    }
}
