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

namespace SIFCA.Gestion_de_ObjetivosInv
{
    public partial class Listado_ObjetivoInv_Form : Form
    {
        private ObjectiveInventoryBL objetivoBl;        
        
        public Listado_ObjetivoInv_Form()
        {

            InitializeComponent();
            objetivoBl = new ObjectiveInventoryBL(Program.ContextData);
            ObjetivoBSource.DataSource = objetivoBl.GetObjectiveInventories();
        }
    }
}
