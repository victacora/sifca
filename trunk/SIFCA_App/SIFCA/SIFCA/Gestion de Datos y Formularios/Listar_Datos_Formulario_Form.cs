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
        private NonTimberLineBL notimberLine;
        private FORMULARIO form;
        public Listar_Datos_Formulario_Form(FORMULARIO form, int selectIndex)
        {
            InitializeComponent();
            this.form = form;
            specie = new SpeciesBL(Program.ContextData);
            quality = new QualityBL(Program.ContextData);
            state = new StateBL(Program.ContextData);
            notimberLine = new NonTimberLineBL(Program.ContextData);

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
        
        private void lineaInventarioDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            int count = 1;
            foreach (DataGridViewRow row in lineaInventarioDGW.Rows)
            {
                row.Cells["NumeroMaderables"].Value = count;
                count++;
            }
        }

        private void regenracionDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int count = 1;
            foreach (DataGridViewRow row in regenracionDGW.Rows)
            {
                row.Cells["NumeroRegen"].Value = count;
                count++;
            }
        }

        private void noMaderablesDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int count = 1;
            foreach (DataGridViewRow row in noMaderablesDGW.Rows)
            {
                row.Cells["NumeroNoMade"].Value = count;
                count++;
                if (row.Cells["codigo"].Value != null)
                {
                    LINEANOMADERABLES currentLine = notimberLine.GetNonTimberLine((Guid)row.Cells["codigo"].Value);
                    string usos = "";
                    int countUseType = 0;
                    List<TIPODEUSO> types = currentLine.TIPODEUSO.ToList();
                    foreach (TIPODEUSO uso in types)
                    {
                        usos += uso.DESCRIPCION;
                        countUseType++;
                        if (countUseType != types.Count)
                        {
                            usos += " - ";
                        }
                    }
                    row.Cells["usos"].Value = usos;
                }
            }
        }
    }
}
