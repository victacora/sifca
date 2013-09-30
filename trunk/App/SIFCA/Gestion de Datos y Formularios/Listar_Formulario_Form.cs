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
        private ProjectBL project;
        private SpeciesBL species;
        private StratumBL stratums;
        private QualityBL quality;
        private StateBL state;
        private FormTypeBL formType;
        private FormBL form;
        private FORMULARIO newForm;
        private InventoryLineBL lineInv;

        public Crear_Formulario_Form()
        {
            InitializeComponent();
            newForm = new FORMULARIO();
            project = new ProjectBL(Program.ContextData);
            species = new SpeciesBL(Program.ContextData);
            stratums = new StratumBL(Program.ContextData);
            quality = new QualityBL(Program.ContextData);
            state = new StateBL(Program.ContextData);
            formType = new FormTypeBL(Program.ContextData);
            form = new FormBL(Program.ContextData);
            lineInv = new InventoryLineBL(Program.ContextData);
            especieBS.DataSource = species.GetSpecies();
            proyectoBS.DataSource = project.GetProjects();
            estratoBS.DataSource = stratums.GetStratums();
            calidadBS.DataSource = quality.GetQualities();
            estadoSanitarioBS.DataSource = state.GetStates();
            tipoFormularioBS.DataSource = formType.GetFormTypes();
            formularioBS.DataSource = form.GetForms();
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            responsableTxt.Text = user.NOMBRES + " " + user.APELLIDOS;
        }

        private void guardarformularioBtn_Click(object sender, EventArgs e)
        {
            USUARIO user = (USUARIO)Program.Cache.Get("user");
            newForm.NROFORMULARIO = Guid.NewGuid();
            newForm.FECHACREACION = DateTime.Now;
            newForm.LINEA = int.Parse(lineaInventarioTxt.Text);
            newForm.HORAINICIO = inicioDpk.Value;
            newForm.HORAFINAL=inicioDpk.Value;
            newForm.TIPOFORMULARIO = (TIPOFORMULARIO)tipoFormularioCbx.SelectedItem;
            newForm.ESTRATO = (ESTRATO)estratoCbx.SelectedItem;
            newForm.PROYECTO = (PROYECTO)proyectoCbx.SelectedItem;
            newForm.USUARIO = user;
            newForm.COORDENADAX = decimal.Parse(coordXTxt.Text);
            newForm.COORDENADAY = decimal.Parse(coordYTxt.Text);
            form.InsertForm(newForm);
            form.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            datosInventarioGrx.Enabled = true;
            guardarformularioBtn.Text="Actualizar Formulario";
            finalDpk.Enabled = true;
            inicioDpk.Enabled = true;
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
            newLine.VOLCOM = int.Parse(volComercialTxt.Text);
            newLine.VOLTOT = int.Parse(volTotalTxt.Text);
            newLine.ALTCOMER_M = int.Parse(alturaComercialTxt.Text);
            newLine.ALTTOT_M = int.Parse(alturaTotalTxt.Text);
            newLine.CAP = int.Parse(cAPTxt.Text);
            newLine.DAP = int.Parse(dAPTxt.Text);
            newLine.AREABASAL = int.Parse(areaBasalTxt.Text);
            lineInv.InsertInventoryLine(newLine);
            lineInv.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void especieBS_PositionChanged(object sender, EventArgs e)
        {
            var p = "";
        }

    }
}
