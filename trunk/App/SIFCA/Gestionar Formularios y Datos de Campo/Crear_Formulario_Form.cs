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

namespace SIFCA
{
    public partial class Crear_Formulario_Form : Form
    {
        private SpeciesBL species;
        private StratumBL stratums;
        private QualityBL quality;
        private StateBL state;
        private FormBL form;
        private InventoryLineBL lineInv;
        private RegenerationLineBL lineRegen;
        private NonTimberLineBL lineNonTimber;
        private TypeUseBL typeUses;
        private FORMULARIO newForm;
        private bool modified;

        public Crear_Formulario_Form()
        {
            InitializeComponent();
            newForm = new FORMULARIO();
            species = new SpeciesBL(Program.ContextData);
            stratums = new StratumBL(Program.ContextData);
            quality = new QualityBL(Program.ContextData);
            state = new StateBL(Program.ContextData);
            form = new FormBL(Program.ContextData);
            lineInv = new InventoryLineBL(Program.ContextData);
            lineRegen = new  RegenerationLineBL(Program.ContextData);
            lineNonTimber = new NonTimberLineBL(Program.ContextData);
            typeUses = new TypeUseBL(Program.ContextData);
            especieBS.DataSource = species.GetSpecies();
            estratoBS.DataSource = stratums.GetStratums();
            calidadBS.DataSource = quality.GetQualities();
            estadoSanitarioBS.DataSource = state.GetStates();
            formularioBS.DataSource = form.GetForms();
            tipoUsoBS.DataSource=typeUses.GetTypeUse();
            TipoDeUsosLbc.DataSource = tipoUsoBS;
            TipoDeUsosLbc.DisplayMember ="DESCRIPCION";
            TipoDeUsosLbc.ValueMember = "NOMBRETIPOUSO";
            lineaNoMaderableBS.DataSource = lineNonTimber.GetNonTimberLineList();
            regenracionBS.DataSource = lineRegen.GetRegenerationLines();
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            PROYECTO project = (PROYECTO)Program.Cache.Get("project");
            responsableTxt.Text = user.NOMBRES + " " + user.APELLIDOS;
            proyectoTxt.Text = project.LUGAR;
            modified = true;
        }

        private void guardarformularioBtn_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            newForm.NROFORMULARIO = Guid.NewGuid();
            newForm.FECHACREACION = DateTime.Now;
            newForm.LINEA = int.Parse(lineaInventarioTxt.Text);
            newForm.HORAINICIO = inicioDpk.Value;
            newForm.HORAFINAL=inicioDpk.Value;
            newForm.ESTRATO = (ESTRATO)estratoCbx.SelectedItem;
            newForm.PROYECTO = (PROYECTO)Program.Cache.Get("project");
            newForm.USUARIO = user;
            newForm.COORDENADAX = decimal.Parse(coordXTxt.Text);
            newForm.COORDENADAY = decimal.Parse(coordYTxt.Text);
            form.InsertForm(newForm);
            form.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            datosTabControl.Enabled = true;
            guardarformularioBtn.Enabled = false;
            
            guardarTodoBtn.Enabled = true;
            guardarformularioBtn.Text="Actualizar Formulario";
            finalDpk.Enabled = true;
            inicioDpk.Enabled = false;
        }

        private void listarDatosBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void guardarLineaBtn_Click(object sender, EventArgs e)
        {
            LINEAINVENTARIO newLine = new LINEAINVENTARIO();
            newLine.LINEAINV = Guid.NewGuid();
            newLine.FORMULARIO = form.GetForm(newForm.NROFORMULARIO);
            newLine.ESPECIE = (ESPECIE)especieCbx.SelectedItem;
            newLine.CALIDAD = (CALIDAD)calidadCbx.SelectedItem;
            newLine.ESTADOSANITARIO = (ESTADOSANITARIO)estadoCbx.SelectedItem;
            newLine.NROARB = int.Parse(nroArbolTxt.Text);
            newLine.VOLCOM = 0;
            newLine.VOLTOT = 0;
            newLine.ALTCOMER_M = int.Parse(alturaComercialTxt.Text);
            newLine.ALTTOT_M = int.Parse(alturaTotalTxt.Text);
            newLine.CAP = int.Parse(cAPTxt.Text);
            newLine.DAP = int.Parse(dAPTxt.Text);
            newLine.AREABASAL = 0;
            lineInv.InsertInventoryLine(newLine);
            lineInv.SaveChanges();
            lineaInvBS.DataSource=lineInv.GetInventoryLines();
            lineaInvBN.Refresh();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardarRegenBtn_Click(object sender, EventArgs e)
        {
            LINEAINVENTARIO newLine = new LINEAINVENTARIO();
            newLine.LINEAINV = Guid.NewGuid();
            newLine.FORMULARIO = form.GetForm(newForm.NROFORMULARIO);
            newLine.ESPECIE = (ESPECIE)especieCbx.SelectedItem;
            newLine.CALIDAD = (CALIDAD)calidadCbx.SelectedItem;
            newLine.ESTADOSANITARIO = (ESTADOSANITARIO)estadoCbx.SelectedItem;
            newLine.NROARB = int.Parse(nroArbolTxt.Text);
            newLine.VOLCOM = 0;
            newLine.VOLTOT = 0;
            newLine.ALTCOMER_M = int.Parse(alturaComercialTxt.Text);
            newLine.ALTTOT_M = int.Parse(alturaTotalTxt.Text);
            newLine.CAP = int.Parse(cAPTxt.Text);
            newLine.DAP = int.Parse(dAPTxt.Text);
            newLine.AREABASAL = 0;
            lineInv.InsertInventoryLine(newLine);
            lineInv.SaveChanges();
            lineaInvBS.DataSource = lineInv.GetInventoryLines().Where(p=>p.NROFORMULARIO==newForm.NROFORMULARIO);
            lineaInvBN.Refresh();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardarLineNoMadBtn_Click(object sender, EventArgs e)
        {
            LINEAINVENTARIO newLine = new LINEAINVENTARIO();
            newLine.LINEAINV = Guid.NewGuid();
            newLine.FORMULARIO = form.GetForm(newForm.NROFORMULARIO);
            newLine.ESPECIE = (ESPECIE)especieCbx.SelectedItem;
            newLine.CALIDAD = (CALIDAD)calidadCbx.SelectedItem;
            newLine.ESTADOSANITARIO = (ESTADOSANITARIO)estadoCbx.SelectedItem;
            newLine.NROARB = int.Parse(nroArbolTxt.Text);
            newLine.VOLCOM = 0;
            newLine.VOLTOT = 0;
            newLine.ALTCOMER_M = int.Parse(alturaComercialTxt.Text);
            newLine.ALTTOT_M = int.Parse(alturaTotalTxt.Text);
            newLine.CAP = int.Parse(cAPTxt.Text);
            newLine.DAP = int.Parse(dAPTxt.Text);
            newLine.AREABASAL = 0;
            lineInv.InsertInventoryLine(newLine);
            lineInv.SaveChanges();
            lineaInvBS.DataSource = lineInv.GetInventoryLines();
            lineaInvBN.Refresh();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void datosRegenGrx_Enter(object sender, EventArgs e)
        {

        }

        private void dAPTxt_TextChanged(object sender, EventArgs e)
        {
            if (dAPTxt.Text!="")
            {
                double output = 0;
                bool result = double.TryParse(dAPTxt.Text, out output);
                if (result)
                {
                    if (modified)
                    {
                        modified = false;
                        cAPTxt.Text = (Math.PI * output).ToString();
                    }
                    else
                    {
                        modified = true;
                        return;
                    }
                }
                else MessageBox.Show("Entra invalida para el diametro.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cAPTxt_TextChanged(object sender, EventArgs e)
        {
            if (cAPTxt.Text != "")
            {
                double output = 0;
                bool result = double.TryParse(cAPTxt.Text, out output);
                if (result)
                {
                    if (modified)
                    {
                        modified = false;
                        dAPTxt.Text = (output / Math.PI).ToString();
                    }
                    else
                    {
                        modified = true;
                        return;
                    }
                }
                else MessageBox.Show("Entra invalida para la medida de la circunferencia.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
