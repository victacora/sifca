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
using System.Runtime.Caching;

namespace SIFCA
{
    public partial class Crear_Formulario_Form : Form
    {
        private SpeciesBL species;
        private ProjectBL project;
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
            project = new ProjectBL(Program.ContextData);
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
            
            tipoUsoBS.DataSource=typeUses.GetTypeUse();
            TipoDeUsosLbc.DataSource = tipoUsoBS;
            TipoDeUsosLbc.DisplayMember ="DESCRIPCION";
            TipoDeUsosLbc.ValueMember = "NOMBRETIPOUSO";

            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("NBF", "Ninguna Bifurcacion"));
            data.Add(new KeyValuePair<string, string>("BFA", "Bifurcacion Arriba de la A.P."));
            data.Add(new KeyValuePair<string, string>("BFB", "Bifurcacion Abajo de la A.P."));
            tipoArbolCbx.DataSource = data;
            tipoArbolCbx.DisplayMember = "Value";
            tipoArbolCbx.ValueMember = "Key";
            tipoArbolCbx.SelectedIndex = 0;

            noMaderableBS.DataSource = new List<LINEANOMADERABLES>();
            regeneracionBS.DataSource = new List<LINEAREGENERACION>();
            lineaInvBS.DataSource = new List<LINEAINVENTARIO>();

            USUARIO user = (USUARIO)Program.Cache.Get("user");
            PROYECTO p = (PROYECTO)Program.Cache.Get("project");
            responsableTxt.Text = user.NOMBRES + " " + user.APELLIDOS;
            proyectoTxt.Text = p.LUGAR;
            newLineNoTimber = new LINEANOMADERABLES();

            modified = true;
        }

        private void guardarformularioBtn_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            newForm.NROFORMULARIO = Guid.NewGuid();
            newForm.FECHACREACION = DateTime.Now;
            newForm.PARCELA = decimal.Parse(parcelaTxt.Text); 
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
            
            PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
            
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            datosTabControl.Enabled = true;
            actualizarformularioBtn.Enabled = false;
            coordXTxt.Enabled = false;
            coordYTxt.Enabled = false;
            estratoCbx.Enabled = false;
            parcelaTxt.Enabled = false;
            lineaInventarioTxt.Enabled = false;
            finalDpk.Enabled = true;
            inicioDpk.Enabled = false;

            lineaInvBS.AddNew();
            regeneracionBS.AddNew();
            noMaderableBS.AddNew();
        }

        private void listarDatosBtn_Click(object sender, EventArgs e)
        {
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(f, 0);
            childForm.MdiParent = this.ParentForm;
            childForm.Show();
        }

        private void guardarLineaBtn_Click(object sender, EventArgs e)
        {
            PROYECTO p = (PROYECTO)Program.Cache.Get("project");
            LINEAINVENTARIO newLine = new LINEAINVENTARIO();
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            newLine.LINEAINV = Guid.NewGuid();
            newLine.FORMULARIO = f;
            newLine.ESPECIE = (ESPECIE)especieCbx.SelectedItem;
            newLine.CALIDAD = (CALIDAD)calidadCbx.SelectedItem;
            newLine.ESTADOSANITARIO = (ESTADOSANITARIO)estadoCbx.SelectedItem;
            newLine.NROARB = int.Parse(nroArbolTxt.Text);
            newLine.ALTCOMER_M = decimal.Parse(alturaComercialTxt.Text);
            newLine.ALTTOT_M = decimal.Parse(alturaTotalTxt.Text);
            newLine.CAP = decimal.Parse(cAPTxt.Text);
            newLine.DAP = decimal.Parse(dAPTxt.Text);
            newLine.AREABASAL = (decimal)(ForestCalculator.BasalAreaDAP((double)newLine.DAP));
            newLine.VOLCOM = (decimal)(ForestCalculator.TreeVolumeByBasalArea((double)newLine.AREABASAL, (double)newLine.ALTCOMER_M, (double)p.FACTORDEFORMA));
            newLine.VOLTOT = (decimal)(ForestCalculator.TreeVolumeByBasalArea((double)newLine.AREABASAL, (double)newLine.ALTTOT_M, (double)p.FACTORDEFORMA)); 
            lineInv.InsertInventoryLine(newLine);
            f = form.GetForm(newForm.NROFORMULARIO);
            lineInv.SaveChanges();
            lineaInvBS.DataSource = f.LINEAINVENTARIO.ToList();
            lineaInvBN.Refresh();
            lineaInvBS.AddNew();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
        }

        private void guardarRegenBtn_Click(object sender, EventArgs e)
        {
            LINEAREGENERACION newLine = new LINEAREGENERACION();
            newLine.LINEAREGEN = Guid.NewGuid();
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            newLine.FORMULARIO = f;
            newLine.ESPECIE = (ESPECIE)especieRegenCbx.SelectedItem;
            newLine.LATIZAL = decimal.Parse(latizalTxt.Text);
            newLine.BRINZAL = decimal.Parse(brinzalTxt.Text);
            lineRegen.InsertRegenerationLine(newLine);
            lineRegen.SaveChanges();
            f = form.GetForm(newForm.NROFORMULARIO);
            regeneracionBS.DataSource = f.LINEAREGENERACION.ToList();
            regeneracionBN.Refresh();
            regeneracionBS.AddNew();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
        }

        private void guardarLineNoMadBtn_Click(object sender, EventArgs e)
        {
            newLineNoTimber.LINEANMAD = Guid.NewGuid();
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            newLineNoTimber.FORMULARIO = f;
            newLineNoTimber.OBSERVACIONES = observacionesTxt.Text;
            lineNonTimber.InsertNonTimberLine(newLineNoTimber);
            lineNonTimber.SaveChanges();
            f = form.GetForm(newForm.NROFORMULARIO);
            noMaderableBS.DataSource = f.LINEANOMADERABLES.ToList();
            noMaderablesBN.Refresh();
            noMaderableBS.AddNew();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
        }

        private void dAPTxt_TextChanged(object sender, EventArgs e)
        {
            if (!modified)
            {
                modified = true;
                return;
            }
            if (dAPTxt.Text!="")
            {
                double output = 0;
                bool result = double.TryParse(dAPTxt.Text, out output);
                if (result)
                {
                    modified = false;
                    ((LINEAINVENTARIO)lineaInvBS.Current).CAP = (decimal)(output * Math.PI);
                }
                else MessageBox.Show("Entra invalida para el diametro.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cAPTxt_TextChanged(object sender, EventArgs e)
        {
            if (!modified)
            {
                modified = true;
                return;
            }
            if (cAPTxt.Text != "")
            {
                double output = 0;
                bool result = double.TryParse(cAPTxt.Text, out output);
                if (result)
                {
                    modified = false;   
                    ((LINEAINVENTARIO)lineaInvBS.Current).DAP =(decimal) (output / Math.PI);
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

        private void listarRegenbtn_Click(object sender, EventArgs e)
        {
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(f, 1);
            childForm.MdiParent = this.ParentForm;
            childForm.Show();
        }

        private void listarNoMaderableBtn_Click(object sender, EventArgs e)
        {
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(f, 2);
            childForm.MdiParent = this.ParentForm;
            childForm.Show();
        }

        private void RegistrarEspecieBtn_Click(object sender, EventArgs e)
        {

        }

        private void cambiarOpcionBusqueda(object sender, EventArgs e)
        {
            if (nombreCientRbtn.Checked) 
            {
                nombreComunRbtn.Checked = false;
                especieBS.DataSource = species.GetSpecies();
                especieCbx.DataSource = especieBS;
                especieCbx.DisplayMember = "NOMCIENTIFICO";
                especieCbx.ValueMember = "CODESP";
                especieCbx.Refresh();
            }
            else 
            {
                nombreCientRbtn.Checked = false;
                especieBS.DataSource = species.GetSpecies();
                especieCbx.DataSource = especieBS;
                especieCbx.DisplayMember = "NOMCOMUN";
                especieCbx.ValueMember = "CODESP";
                especieCbx.Refresh();
            }
        }

        private void verDetalleBtn_Click(object sender, EventArgs e)
        {

        }


    }
}

