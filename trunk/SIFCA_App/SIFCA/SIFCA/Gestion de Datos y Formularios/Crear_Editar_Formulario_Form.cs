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
using SIFCA.Gestion_Configuracion;

namespace SIFCA
{
    public partial class Crear_Editar_Formulario_Form : Form
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

        public Crear_Editar_Formulario_Form(FORMULARIO f)
        {
            InitializeComponent();
            
            if (f == null) newForm = new FORMULARIO();
            else newForm = f;

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
            tipoDeUsosLbc.DataSource = tipoUsoBS;
            tipoDeUsosLbc.DisplayMember ="DESCRIPCION";
            tipoDeUsosLbc.ValueMember = "NOMBRETIPOUSO";

            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("BFB", "Bifurcacion Abajo de la A.P."));
            data.Add(new KeyValuePair<string, string>("BFA", "Bifurcacion Arriba de la A.P."));
            data.Add(new KeyValuePair<string, string>("NBF", "Ninguna Bifurcacion"));
            
            
            tipoArbolCbx.DataSource = data;
            tipoArbolCbx.DisplayMember = "Value";
            tipoArbolCbx.ValueMember = "Key";
            tipoArbolCbx.SelectedIndex = 0;
            
            newLineNoTimber = new LINEANOMADERABLES();

            if (f == null)
            {
                noMaderableBS.DataSource = new List<LINEANOMADERABLES>();
                regeneracionBS.DataSource = new List<LINEAREGENERACION>();
                lineaInvBS.DataSource = new List<LINEAINVENTARIO>();
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                PROYECTO p = (PROYECTO)Program.Cache.Get("project");
                responsableTxt.Text = user.NOMBRES + " " + user.APELLIDOS;
                proyectoTxt.Text = p.LUGAR;
            }
            else 
            {
                noMaderableBS.DataSource = newForm.LINEANOMADERABLES.ToList();
                regeneracionBS.DataSource = newForm.LINEAREGENERACION.ToList();
                lineaInvBS.DataSource = newForm.LINEAINVENTARIO.ToList();
                responsableTxt.Text = f.USUARIO.NOMBRES + " " + f.USUARIO.APELLIDOS;
                proyectoTxt.Text = f.PROYECTO.LUGAR;
                datosTabControl.Enabled = true;
                guardarformularioBtn.Text = "Actualizar formulario";
                inicioDpk.Enabled = false;
                finalDpk.Enabled = true;
                this.Text = "Introduciendo datos.";
                lineaInvBS.AddNew();
                regeneracionBS.AddNew();
                noMaderableBS.AddNew();
            }

            if(f!=null)formularioBS.DataSource = f;
            else formularioBS.DataSource = newForm;

            modified = true;
        }

        private void guardarformularioBtn_Click(object sender, EventArgs e)
        {
            if (newForm.NROFORMULARIO == Guid.Empty)
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                newForm.NROFORMULARIO = Guid.NewGuid();
                newForm.FECHACREACION = DateTime.Now;
                newForm.PARCELA = decimal.Parse(parcelaTxt.Text);
                newForm.LINEA = int.Parse(lineaInventarioTxt.Text);
                newForm.HORAINICIO = inicioDpk.Value;
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
                guardarformularioBtn.Text = "Actualizar formulario";
                inicioDpk.Enabled = false;
                finalDpk.Enabled = true;

                this.Text = "Editando formulario e introduciendo datos";

                lineaInvBS.AddNew();
                regeneracionBS.AddNew();
                noMaderableBS.AddNew();
            }
            else 
            {
                newForm.PARCELA = decimal.Parse(parcelaTxt.Text);
                newForm.LINEA = int.Parse(lineaInventarioTxt.Text);
                newForm.HORAFINAL = finalDpk.Value;
                newForm.ESTRATO = (ESTRATO)estratoCbx.SelectedItem;
                newForm.PROYECTO = (PROYECTO)Program.Cache.Get("project");
                newForm.COORDENADAX = decimal.Parse(coordXTxt.Text);
                newForm.COORDENADAY = decimal.Parse(coordYTxt.Text);
                form.UpdateForm(newForm);
                form.SaveChanges();
                PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
                Program.Cache.Add("project", result, new CacheItemPolicy());
                MessageBox.Show("Los datos fueron Actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            LINEAINVENTARIO currentLine = (LINEAINVENTARIO)lineaInvBS.Current;
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            if (currentLine.LINEAINV == Guid.Empty)
            {
                newLine.LINEAINV = Guid.NewGuid();
                newLine.FORMULARIO = f;
                newLine.ESPECIE = (ESPECIE)especieCbx.SelectedItem;
                newLine.CALIDAD = (CALIDAD)calidadCbx.SelectedItem;
                newLine.ESTADOSANITARIO = (ESTADOSANITARIO)estadoCbx.SelectedItem;
                newLine.NROARB = int.Parse(nroArbolTxt.Text);
                newLine.TIPOARBOL = ((KeyValuePair<string, string>)tipoArbolCbx.SelectedItem).Key;
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
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lineaInvBS.AddNew();
                if (newLine.TIPOARBOL == "BFA")
                {
                    currentLine.NROARB = newLine.NROARB;
                    currentLine.DAP = newLine.DAP;
                    tipoArbolCbx.SelectedIndex = 1;
                }
                else if (newLine.TIPOARBOL == "BFB")
                {
                    currentLine.NROARB = newLine.NROARB;
                    currentLine.ALTCOMER_M = newLine.ALTCOMER_M;
                    currentLine.ALTTOT_M = newLine.ALTTOT_M;
                    tipoArbolCbx.SelectedIndex = 2;
                }
                tipoArbolCbx.SelectedIndex = 0;
            }
            else
            {
                currentLine.ESPECIE = (ESPECIE)especieCbx.SelectedItem;
                currentLine.CALIDAD = (CALIDAD)calidadCbx.SelectedItem;
                currentLine.ESTADOSANITARIO = (ESTADOSANITARIO)estadoCbx.SelectedItem;
                currentLine.NROARB = int.Parse(nroArbolTxt.Text);
                currentLine.TIPOARBOL = ((KeyValuePair<string, string>)tipoArbolCbx.SelectedItem).Key;
                currentLine.ALTCOMER_M = decimal.Parse(alturaComercialTxt.Text);
                currentLine.ALTTOT_M = decimal.Parse(alturaTotalTxt.Text);
                currentLine.CAP = decimal.Parse(cAPTxt.Text);
                currentLine.DAP = decimal.Parse(dAPTxt.Text);
                currentLine.AREABASAL = (decimal)(ForestCalculator.BasalAreaDAP((double)newLine.DAP));
                currentLine.VOLCOM = (decimal)(ForestCalculator.TreeVolumeByBasalArea((double)newLine.AREABASAL, (double)newLine.ALTCOMER_M, (double)p.FACTORDEFORMA));
                currentLine.VOLTOT = (decimal)(ForestCalculator.TreeVolumeByBasalArea((double)newLine.AREABASAL, (double)newLine.ALTTOT_M, (double)p.FACTORDEFORMA));
                lineInv.UpdateInventoryLine(currentLine);
                f = form.GetForm(newForm.NROFORMULARIO);
                lineInv.SaveChanges();
                lineaInvBS.DataSource = f.LINEAINVENTARIO.ToList();
                lineaInvBN.Refresh();
                MessageBox.Show("Los datos fueron actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipoArbolCbx.SelectedIndex = 0;
            }
            modified = true;
            PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
        }

        private void guardarRegenBtn_Click(object sender, EventArgs e)
        {
            LINEAREGENERACION currentLine = (LINEAREGENERACION)regeneracionBS.Current;
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            if (currentLine.LINEAREGEN == Guid.Empty)
            {
                LINEAREGENERACION newLine = new LINEAREGENERACION();
                newLine.LINEAREGEN = Guid.NewGuid();
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
            }
            else
            {
                currentLine.ESPECIE = (ESPECIE)especieRegenCbx.SelectedItem;
                currentLine.LATIZAL = decimal.Parse(latizalTxt.Text);
                currentLine.BRINZAL = decimal.Parse(brinzalTxt.Text);
                lineRegen.UpdateRegenerationLine(currentLine);
                lineRegen.SaveChanges();
                f = form.GetForm(newForm.NROFORMULARIO);
                regeneracionBS.DataSource = f.LINEAREGENERACION.ToList();
                regeneracionBN.Refresh();
                MessageBox.Show("Los datos fueron Actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
            Program.Cache.Add("project", result, new CacheItemPolicy());
        }

        private void guardarLineNoMadBtn_Click(object sender, EventArgs e)
        {
            LINEANOMADERABLES currentLine = (LINEANOMADERABLES)noMaderableBS.Current;
            FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
            if (currentLine.LINEANMAD == Guid.Empty)
            {
                newLineNoTimber.LINEANMAD = Guid.NewGuid();
                newLineNoTimber.FORMULARIO = f;
                newLineNoTimber.OBSERVACIONES = observacionesTxt.Text;
                lineNonTimber.InsertNonTimberLine(newLineNoTimber);
                lineNonTimber.SaveChanges();
                f = form.GetForm(newForm.NROFORMULARIO);
                noMaderableBS.DataSource = f.LINEANOMADERABLES.ToList();
                noMaderablesBN.Refresh();
                noMaderableBS.AddNew();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newLineNoTimber = new LINEANOMADERABLES();
            }
            else 
            {
                currentLine.TIPODEUSO.Clear();
                currentLine.TIPODEUSO = newLineNoTimber.TIPODEUSO;
                currentLine.OBSERVACIONES = observacionesTxt.Text;
                lineNonTimber.UpdateNonTimberLine(currentLine);
                lineNonTimber.SaveChanges();
                f = form.GetForm(newForm.NROFORMULARIO);
                noMaderableBS.DataSource = f.LINEANOMADERABLES.ToList();
                noMaderablesBN.Refresh();
                MessageBox.Show("Los datos fueron actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newLineNoTimber = new LINEANOMADERABLES();
            }
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
                newLineNoTimber.TIPODEUSO.Add((TIPODEUSO)tipoDeUsosLbc.SelectedItem);
            }
            else
            {
                newLineNoTimber.TIPODEUSO.Remove((TIPODEUSO)tipoDeUsosLbc.SelectedItem);
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
            Especies_Form childForm = new Especies_Form();
            childForm.MdiParent = ParentForm;
            childForm.Btn_nuevaEspecieForm_Click(sender, e);
            childForm.Show();
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

        private void cambiarOpcionBusquedaRegen(object sender, EventArgs e)
        {
            if (nomCientificoRegenRbtn.Checked)
            {
                nombreComunRegenRbtn.Checked = false;
                especieBS.DataSource = species.GetSpecies();
                especieRegenCbx.DataSource = especieBS;
                especieRegenCbx.DisplayMember = "NOMCIENTIFICO";
                especieRegenCbx.ValueMember = "CODESP";
                especieRegenCbx.Refresh();
            }
            else
            {
                nomCientificoRegenRbtn.Checked = false;
                especieBS.DataSource = species.GetSpecies();
                especieRegenCbx.DataSource = especieBS;
                especieRegenCbx.DisplayMember = "NOMCOMUN";
                especieRegenCbx.ValueMember = "CODESP";
                especieRegenCbx.Refresh();
            }
        }

        private void verDetalleBtn_Click(object sender, EventArgs e)
        {
            Guid cod = (Guid)especieCbx.SelectedValue;
            Especies_Form childForm = new Especies_Form();
            childForm.MdiParent = ParentForm;
            childForm.btn_detalle(sender, e, cod);
            childForm.Show();
        }

        private void noMaderableBS_CurrentChanged(object sender, EventArgs e)
        {
            LINEANOMADERABLES linea = (LINEANOMADERABLES)noMaderableBS.Current;
            if (linea != null)
            {
                tipoUsoBS.DataSource = typeUses.GetTypeUse();
                tipoDeUsosLbc.DataSource = tipoUsoBS;
                tipoDeUsosLbc.DisplayMember = "DESCRIPCION";
                tipoDeUsosLbc.ValueMember = "NOMBRETIPOUSO";
                foreach (TIPODEUSO tipoUso in linea.TIPODEUSO)
                {
                    int count = 0;
                    foreach (TIPODEUSO tipoUsoChbx in tipoDeUsosLbc.Items)
                    {
                        if (tipoUsoChbx.NOMBRETIPOUSO == tipoUso.NOMBRETIPOUSO)
                        {
                            tipoDeUsosLbc.SetItemChecked(count, true);
                            break;
                        }
                        count++;
                    }
                }
            }
        }

        private void lineaInvBS_CurrentChanged(object sender, EventArgs e)
        {
            LINEAINVENTARIO currentLine=(LINEAINVENTARIO)lineaInvBS.Current;

            if (currentLine.TIPOARBOL == "NBF") tipoArbolCbx.SelectedIndex = 0;
            else if (currentLine.TIPOARBOL == "BFA") tipoArbolCbx.SelectedIndex = 1;
            else tipoArbolCbx.SelectedIndex = 2;
        }

        private void EliminarLineaInv_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show("¿Esta seguro de querer eliminar esta Linea?", "Mensaje de confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                LINEAINVENTARIO CurrentLine = (LINEAINVENTARIO)lineaInvBS.Current;
                if (CurrentLine.LINEAINV != Guid.Empty)
                {
                    lineInv.DeleteInventoryLine(CurrentLine.LINEAINV);
                    lineInv.SaveChanges();
                    PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
                    Program.Cache.Add("project", result, new CacheItemPolicy());
                }
                lineaInvBS.RemoveCurrent();
            }
        }

        private void eliminarRegen_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show("¿Esta seguro de querer eliminar esta Linea?", "Mensaje de confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                LINEAREGENERACION CurrentLine = (LINEAREGENERACION)regeneracionBS.Current;
                if (CurrentLine.LINEAREGEN != Guid.Empty)
                {
                    lineRegen.DeleteRegenerationLine(CurrentLine.LINEAREGEN);
                    lineRegen.SaveChanges();
                    PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
                    Program.Cache.Add("project", result, new CacheItemPolicy());
                }
                regeneracionBS.RemoveCurrent();
            }
        }

        private void eliminarNoMaderables_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show("¿Esta seguro de querer eliminar esta Linea?", "Mensaje de confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                LINEANOMADERABLES CurrentLine = (LINEANOMADERABLES)noMaderableBS.Current;
                if (CurrentLine.LINEANMAD != Guid.Empty)
                {
                    lineNonTimber.DeleteNonTimberLine(CurrentLine.LINEANMAD);
                    lineNonTimber.SaveChanges();
                    PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
                    Program.Cache.Add("project", result, new CacheItemPolicy());
                }
                noMaderableBS.RemoveCurrent();
            }
        }

        private void detalleEspecieRegenBtn_Click(object sender, EventArgs e)
        {
            Guid cod = (Guid)especieRegenCbx.SelectedValue;
            Especies_Form childForm = new Especies_Form();
            childForm.MdiParent = ParentForm;
            childForm.btn_detalle(sender, e, cod);
            childForm.Show();
        }

        private void registrarEspecieRegenBtn_Click(object sender, EventArgs e)
        {
            Especies_Form childForm = new Especies_Form();
            childForm.MdiParent = ParentForm;
            childForm.Btn_nuevaEspecieForm_Click(sender, e);
            childForm.Show();
        }
    }
}

