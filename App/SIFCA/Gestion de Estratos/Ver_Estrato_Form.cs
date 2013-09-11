using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;

namespace SIFCA.Gestion_de_Estratos
{
    public partial class Ver_Estrato_Form : Form
    {
        StratumBL stratum = new StratumBL(Program.ContextData);
        public Ver_Estrato_Form()
        {
            InitializeComponent();
            StratumBSource.DataSource = stratum.GetStratums();
        }
    }
}
