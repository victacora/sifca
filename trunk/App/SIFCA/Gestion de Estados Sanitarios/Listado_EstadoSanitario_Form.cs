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

namespace SIFCA.Gestion_de_Estados_Sanitarios
{
    public partial class Listado_EstadoSanitario_Form : Form
    {
        private ESTADOSANITARIO state;
        private StateBL stateBL;

        public Listado_EstadoSanitario_Form()
        {

            InitializeComponent();
            stateBL = new StateBL(Program.ContextData);
            StateBSource.DataSource = stateBL.GetStates();
        }
    }
}
