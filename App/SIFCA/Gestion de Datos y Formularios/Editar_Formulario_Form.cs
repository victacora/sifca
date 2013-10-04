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
    public partial class Editar_Formulario_Form : Form
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
        private FORMULARIO formToUpdate;
        private LINEANOMADERABLES newLineNoTimber;
        private bool modified;

        public Editar_Formulario_Form(FORMULARIO f)
        {
            InitializeComponent();
            formToUpdate = f;
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
            
            noMaderableBS.DataSource = formToUpdate.LINEANOMADERABLES.ToList();
            regeneracionBS.DataSource = formToUpdate.LINEAREGENERACION.ToList();
            lineaInvBS.DataSource = formToUpdate.LINEAINVENTARIO.ToList();

            newLineNoTimber = new LINEANOMADERABLES();

            modified = true;

            lineaInvBS.AddNew();
            regeneracionBS.AddNew();
            noMaderableBS.AddNew();
            responsableTxt.Text=f.USUARIO.NOMBRES+" "+f.USUARIO.APELLIDOS;
            proyectoTxt.Text = f.PROYECTO.LUGAR;
            formularioBS.DataSource = f;
        }

        private void actualizarformularioBtn_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            formToUpdate.PARCELA = decimal.Parse(parcelaTxt.Text); 
            formToUpdate.LINEA = int.Parse(lineaInventarioTxt.Text);
            formToUpdate.HORAFINAL=inicioDpk.Value;
            formToUpdate.ESTRATO = (ESTRATO)estratoCbx.SelectedItem;
            formToUpdate.COORDENADAX = decimal.Parse(coordXTxt.Text);
            formToUpdate.COORDENADAY = decimal.Parse(coordYTxt.Text);
            form.UpdateForm(formToUpdate);
            form.SaveChanges();
            
            PROYECTO result = project.GetProject(formToUpdate.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
            
            MessageBox.Show("Los datos fueron actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listarDatosBtn_Click(object sender, EventArgs e)
        {
            FORMULARIO f = form.GetForm(formToUpdate.NROFORMULARIO);
            Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(f, 0);
            childForm.MdiParent = this.ParentForm;
            childForm.Show();
        }

        private void guardarLineaBtn_Click(object sender, EventArgs e)
        {
            PROYECTO p = (PROYECTO)Program.Cache.Get("project");
            LINEAINVENTARIO newLine = new LINEAINVENTARIO();
            FORMULARIO f = form.GetForm(formToUpdate.NROFORMULARIO);
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
            f = form.GetForm(formToUpdate.NROFORMULARIO);
            lineInv.SaveChanges();
            lineaInvBS.DataSource = f.LINEAINVENTARIO.ToList();
            lineaInvBN.Refresh();
            lineaInvBS.AddNew();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            PROYECTO result = project.GetProject(formToUpdate.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
        }

        private void guardarRegenBtn_Click(object sender, EventArgs e)
        {
            LINEAREGENERACION newLine = new LINEAREGENERACION();
            newLine.LINEAREGEN = Guid.NewGuid();
            FORMULARIO f = form.GetForm(formToUpdate.NROFORMULARIO);
            newLine.FORMULARIO = f;
            newLine.ESPECIE = (ESPECIE)especieRegenCbx.SelectedItem;
            newLine.LATIZAL = decimal.Parse(latizalTxt.Text);
            newLine.BRINZAL = decimal.Parse(brinzalTxt.Text);
            lineRegen.InsertRegenerationLine(newLine);
            lineRegen.SaveChanges();
            f = form.GetForm(formToUpdate.NROFORMULARIO);
            regeneracionBS.DataSource = f.LINEAREGENERACION.ToList();
            regeneracionBN.Refresh();
            regeneracionBS.AddNew();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            PROYECTO result = project.GetProject(formToUpdate.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
        }

        private void guardarLineNoMadBtn_Click(object sender, EventArgs e)
        {
            newLineNoTimber.LINEANMAD = Guid.NewGuid();
            FORMULARIO f = form.GetForm(formToUpdate.NROFORMULARIO);
            newLineNoTimber.FORMULARIO = f;
            newLineNoTimber.OBSERVACIONES = observacionesTxt.Text;
            lineNonTimber.InsertNonTimberLine(newLineNoTimber);
            lineNonTimber.SaveChanges();
            f = form.GetForm(formToUpdate.NROFORMULARIO);
            noMaderableBS.DataSource = f.LINEANOMADERABLES.ToList();
            noMaderablesBN.Refresh();
            noMaderableBS.AddNew();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            PROYECTO result = project.GetProject(formToUpdate.PROYECTO.NROPROY);
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
            FORMULARIO f = form.GetForm(formToUpdate.NROFORMULARIO);
            Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(f, 1);
            childForm.MdiParent = this.ParentForm;
            childForm.Show();
        }

        private void listarNoMaderableBtn_Click(object sender, EventArgs e)
        {
            FORMULARIO f = form.GetForm(formToUpdate.NROFORMULARIO);
            Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(f, 2);
            childForm.MdiParent = this.ParentForm;
            childForm.Show();
        }


    }
}
