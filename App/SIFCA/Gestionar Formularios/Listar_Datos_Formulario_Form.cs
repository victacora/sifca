using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_DAL;

namespace SIFCA
{
    public partial class Listar_Datos_Formulario_Form : Form
    {
        public Listar_Datos_Formulario_Form()
        {
            InitializeComponent();
            PROYECTO project = (PROYECTO)Program.Cache.Get("project");
            formularioBS.DataSource = project.FORMULARIO;
            lineaInventarioBS.DataSource = ((FORMULARIO)formularioBS.Current).LINEAINVENTARIO;
            lineaInventarioDGW.DataSource = lineaInventarioBS;
            regeneracionBS.DataSource = ((FORMULARIO)formularioBS.Current).LINEAREGENERACION;
            regenracionDGW.DataSource = regeneracionBS;
            noMaderablesBS.DataSource = ((FORMULARIO)formularioBS.Current).LINEANOMADERABLES;
            noMaderablesDGW.DataSource = noMaderablesBS;
        }

        private void formularioBS_PositionChanged(object sender, EventArgs e)
        {
            lineaInventarioBS.DataSource = ((FORMULARIO)formularioBS.Current).LINEAINVENTARIO;
            lineaInventarioDGW.DataSource = lineaInventarioBS;
            lineaInventarioDGW.Refresh();
            regeneracionBS.DataSource = ((FORMULARIO)formularioBS.Current).LINEAREGENERACION;
            regenracionDGW.DataSource = regeneracionBS;
            regenracionDGW.Refresh();
            noMaderablesBS.DataSource = ((FORMULARIO)formularioBS.Current).LINEANOMADERABLES;
            noMaderablesDGW.DataSource = noMaderablesBS;
            noMaderablesDGW.Refresh();
        }
    }
}
