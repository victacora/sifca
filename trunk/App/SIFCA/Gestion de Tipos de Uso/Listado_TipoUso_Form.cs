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

namespace SIFCA.Gestion_de_Tipos_De_Uso
{
    public partial class Listado_TipoUso_Form : Form
    {
        private TypeUseBL typeUseBl;

        public Listado_TipoUso_Form()
        {

            InitializeComponent();
            typeUseBl = new TypeUseBL(Program.ContextData);
            TypeUseBSource.DataSource = typeUseBl.GetTypeUses();
        }
    }
}
