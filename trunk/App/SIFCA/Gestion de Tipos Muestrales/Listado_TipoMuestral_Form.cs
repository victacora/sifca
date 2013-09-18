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

namespace SIFCA.Gestion_de_Tipos_Muestrales
{
    public partial class Listado_TipoMuestral_Form : Form
    {
        private TypeSampleDesignBl typeDesingBl;
        public Listado_TipoMuestral_Form()
        {

            InitializeComponent();
            typeDesingBl = new TypeSampleDesignBl(Program.ContextData);
            TypeSampleDesingBSource.DataSource = typeDesingBl.GetTypeSampleDesignList();
        }
    }
}
