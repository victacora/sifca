using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_DAL;
using SIFCA_BLL;

namespace SIFCA
{
    public partial class Listar_Datos_Formulario_Form : Form
    {
        private SpeciesBL specie;
        private QualityBL quality;
        private StateBL state;

        public Listar_Datos_Formulario_Form(FORMULARIO form, int selectIndex)
        {
            InitializeComponent();
            specie = new SpeciesBL(Program.ContextData);
            quality = new QualityBL(Program.ContextData);
            state = new StateBL(Program.ContextData);

            especieBS.DataSource = specie.GetSpecies();
            calidadBS.DataSource = quality.GetQualities();
            estadoSanitarioBS.DataSource = state.GetStates();
            lineaInventarioBS.DataSource = form.LINEAINVENTARIO;
            lineaInventarioDGW.DataSource = lineaInventarioBS;
            regeneracionBS.DataSource = form.LINEAREGENERACION;
            regenracionDGW.DataSource = regeneracionBS;
            noMaderablesBS.DataSource = form.LINEANOMADERABLES;
            noMaderablesDGW.DataSource = noMaderablesBS;
            
            criterioInvCbx.SelectedIndex = 0;
            criterioNoMaderCbx.SelectedIndex = 0;
            criterioRegenCbx.SelectedIndex = 0;
            lineasTab.SelectedIndex = selectIndex;
        }
        
        private void busquedaInvTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void busquedaNoMaderTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void busquedaRegenTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
