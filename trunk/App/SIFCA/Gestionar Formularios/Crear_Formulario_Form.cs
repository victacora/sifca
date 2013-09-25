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
        private LINEANOMADERABLES newLineNoTimber;
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
            regeneracionBS.DataSource = lineRegen.GetRegenerationLines();
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            PROYECTO project = (PROYECTO)Program.Cache.Get("project");
            responsableTxt.Text = user.NOMBRES + " " + user.APELLIDOS;
            proyectoTxt.Text = project.LUGAR;
            newLineNoTimber = new LINEANOMADERABLES();
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
            coordXTxt.Enabled = false;
            coordYTxt.Enabled = false;
            estratoCbx.Enabled = false;
            parcelaTxt.Enabled = false;
            lineaInventarioTxt.Enabled = false;
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
            PROYECTO project = (PROYECTO)Program.Cache.Get("project");
            LINEAINVENTARIO newLine = new LINEAINVENTARIO();
            newLine.LINEAINV = Guid.NewGuid();
            newLine.FORMULARIO = form.GetForm(newForm.NROFORMULARIO);
            newLine.ESPECIE = (ESPECIE)especieCbx.SelectedItem;
            newLine.CALIDAD = (CALIDAD)calidadCbx.SelectedItem;
            newLine.ESTADOSANITARIO = (ESTADOSANITARIO)estadoCbx.SelectedItem;
            newLine.NROARB = int.Parse(nroArbolTxt.Text);
            newLine.ALTCOMER_M = decimal.Parse(alturaComercialTxt.Text);
            newLine.ALTTOT_M = decimal.Parse(alturaTotalTxt.Text);
            newLine.CAP = decimal.Parse(cAPTxt.Text);
            newLine.DAP = decimal.Parse(dAPTxt.Text);
            newLine.AREABASAL = (decimal)((Math.PI * Math.Pow(((double)newLine.DAP), 2)) / 4);
            newLine.VOLCOM = newLine.AREABASAL * newLine.ALTCOMER_M * project.FACTORDEFORMA;
            newLine.VOLTOT = newLine.AREABASAL * newLine.ALTTOT_M * project.FACTORDEFORMA;
            lineInv.InsertInventoryLine(newLine);
            lineInv.SaveChanges();
            lineaInvBS.DataSource = lineInv.GetInventoryLines();
            lineaInvBN.Refresh();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardarRegenBtn_Click(object sender, EventArgs e)
        {
            PROYECTO project = (PROYECTO)Program.Cache.Get("project");
            LINEAREGENERACION newLine = new LINEAREGENERACION();
            newLine.LINEAREGEN = Guid.NewGuid();
            newLine.FORMULARIO = form.GetForm(newForm.NROFORMULARIO);
            newLine.ESPECIE = (ESPECIE)especieRegenCbx.SelectedItem;
            newLine.NROARB = int.Parse(nroArbolTxt.Text);
            newLine.LATIZAL = decimal.Parse(latizalTxt.Text);
            newLine.BRINZAL = decimal.Parse(brinzalTxt.Text);
            lineRegen.InsertRegenerationLine(newLine);
            lineRegen.SaveChanges();
            regeneracionBS.DataSource = lineInv.GetInventoryLines();
            regeneracionBN.Refresh();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardarLineNoMadBtn_Click(object sender, EventArgs e)
        {
            PROYECTO project = (PROYECTO)Program.Cache.Get("project");
            newLineNoTimber.LINEANMAD = Guid.NewGuid();
            newLineNoTimber.FORMULARIO = form.GetForm(newForm.NROFORMULARIO);
            newLineNoTimber.OBSERVACIONES = observacionesTxt.Text;
            lineInv.SaveChanges();
            lineaInvBS.DataSource = lineInv.GetInventoryLines();
            lineaInvBN.Refresh();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TipoDeUsosLbc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                newLineNoTimber.TIPODEUSO.Add((TIPODEUSO)TipoDeUsosLbc.SelectedItem);
            }
            else
            {
                newLineNoTimber.TIPODEUSO.Remove((TIPODEUSO)TipoDeUsosLbc.SelectedItem);
            }
        }


    }
}
