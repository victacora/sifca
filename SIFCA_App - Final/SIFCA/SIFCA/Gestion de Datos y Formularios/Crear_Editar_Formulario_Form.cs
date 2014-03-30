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
            
            if (f == null) newForm = Program.ContextData.FORMULARIO.Create();
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

            int countEspecies = ((PROYECTO)Program.Cache.Get("project")).ESPECIE.ToList().Count;
            if (countEspecies != 0) especieBS.DataSource = ((PROYECTO)Program.Cache.Get("project")).ESPECIE.ToList().OrderBy(e => e.NOMCOMUN);
            else
            {
                MessageBox.Show("No existen especies asociadas a este proyecto, seleccione uno o mas especies.", "Parametros insuficiente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            List<ESTRATO> listStratums = new List<ESTRATO>();
            foreach(LISTADODEESTRATOS list in ((PROYECTO)Program.Cache.Get("project")).LISTADODEESTRATOS)
            {
                listStratums.Add(list.ESTRATO);
            }
            estratoBS.DataSource =listStratums;
            if (estratoBS.Count != 0) estratoCbx.SelectedItem = (ESTRATO)estratoBS.Current;
            else estratoBS.Add(new ESTRATO() { DESCRIPESTRATO = "Diseño muestral simple." });
            
            calidadBS.DataSource = quality.GetQualities();
            
            estadoSanitarioBS.DataSource = state.GetStates();
            
            tipoUsoBS.DataSource=typeUses.GetTypeUse();
            tipoDeUsosLbc.DataSource = tipoUsoBS;
            tipoDeUsosLbc.DisplayMember ="DESCRIPCION";
            tipoDeUsosLbc.ValueMember = "NOMBRETIPOUSO";

            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("BFB", "Bifurcacion Abajo de la A.P."));
            data.Add(new KeyValuePair<string, string>("NBF", "Ninguna Bifurcacion"));
            
            tipoArbolCbx.DataSource = data;
            tipoArbolCbx.DisplayMember = "Value";
            tipoArbolCbx.ValueMember = "Key";
            tipoArbolCbx.SelectedValue = "NBF";
            
            newLineNoTimber =  Program.ContextData.LINEANOMADERABLES.Create();

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
                this.Text = "Editando formulario e introduciendo datos";
                lineaInvBS.AddNew();
                regeneracionBS.AddNew();
                noMaderableBS.AddNew();
            }

            PROYECTO py = (PROYECTO)Program.Cache.Get("project");
            if (py.TIPODISENOMUESTRAL.NOMTIPODISEMUEST.ToString() == "SI")
            {
                estratoCbx.Enabled = false;
            }
            if(f!=null)formularioBS.DataSource = f;
            else formularioBS.DataSource = newForm;

            modified = true;
        }

        private void guardarformularioBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = false;
                if (parcelaTxt.Text == "")
                {
                    controladorErrores.SetError(parcelaTxt, "La Parcela es un campo requerido.");
                    error = true;
                }
                if (lineaInventarioTxt.Text == "")
                {
                    controladorErrores.SetError(lineaInventarioTxt, "La linea es un campo requerido.");
                    error = true;
                }
                if (decimal.Parse(lineaInventarioTxt.Text) < 0)
                {
                    controladorErrores.SetError(lineaInventarioTxt, "La linea no puede ser menor o igual a cero.");
                    error = true;
                }
                if (coordXTxt.Text == "")
                {
                    controladorErrores.SetError(coordXTxt, "La coordenada X es un campo requerido.");
                    error = true;
                }
                if (coordYTxt.Text == "")
                {
                    controladorErrores.SetError(coordYTxt, "La coordenada Y un campo requerido.");
                    error = true;
                }
                if (error) return;

                controladorErrores.Clear();


                if (newForm.NROFORMULARIO == Guid.Empty)
                {
                    USUARIO user = (USUARIO)Program.Cache.Get("user");
                    newForm.NROFORMULARIO = Guid.NewGuid();
                    newForm.FECHACREACION = DateTime.Now;
                    newForm.PARCELA = decimal.Parse(parcelaTxt.Text);
                    newForm.LINEA = int.Parse(lineaInventarioTxt.Text);
                    newForm.HORAINICIO = inicioDpk.Value;
                    newForm.ESTRATO = ((ESTRATO)estratoCbx.SelectedItem).DESCRIPESTRATO == "Diseño muestral simple." ? null : (ESTRATO)estratoCbx.SelectedItem;
                    newForm.PROYECTO = (PROYECTO)Program.Cache.Get("project");
                    newForm.USUARIO = user;
                    newForm.COORDENADAX = decimal.Parse(coordXTxt.Text);
                    newForm.COORDENADAY = decimal.Parse(coordYTxt.Text);
                    form.InsertForm(newForm);
                    string resultSaveChangues = form.SaveChanges();
                    if (resultSaveChangues == "")
                    {
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

                        tipoArbolCbx.SelectedValue = "NBF";
                        if (especieBS.Count != 0)
                        {
                            especieCbx.SelectedItem = (ESPECIE)especieBS.Current;
                            especieRegenCbx.SelectedItem = (ESPECIE)especieBS.Current;
                        }
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(resultSaveChangues);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
                }
                else
                {
                    newForm.PARCELA = decimal.Parse(parcelaTxt.Text);
                    newForm.LINEA = int.Parse(lineaInventarioTxt.Text);
                    newForm.HORAFINAL = finalDpk.Value;
                    newForm.ESTRATO = ((ESTRATO)estratoCbx.SelectedItem).DESCRIPESTRATO == "Diseño muestral simple." ? null : (ESTRATO)estratoCbx.SelectedItem;
                    newForm.PROYECTO = (PROYECTO)Program.Cache.Get("project");
                    newForm.COORDENADAX = decimal.Parse(coordXTxt.Text);
                    newForm.COORDENADAY = decimal.Parse(coordYTxt.Text);
                    form.UpdateForm(newForm);
                    string resultSaveChangues = form.SaveChanges();
                    if (resultSaveChangues == "")
                    {
                        PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
                        Program.Cache.Add("project", result, new CacheItemPolicy());
                        MessageBox.Show("Los datos fueron Actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(resultSaveChangues);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
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
            try
            {
                PROYECTO p = (PROYECTO)Program.Cache.Get("project");
                LINEAINVENTARIO newLine = Program.ContextData.LINEAINVENTARIO.Create();
                LINEAINVENTARIO currentLine = (LINEAINVENTARIO)lineaInvBS.Current;
                FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);

                bool error = false;

                if (especieCbx.SelectedItem == null)
                {
                    controladorErrores.SetError(especieCbx, "Seleccione una especie.");
                    error = true;
                }
                if (decimal.Parse(nroArbolTxt.Text) < 1)
                {
                    controladorErrores.SetError(nroArbolTxt, "El numero de arbol debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(alturaComercialTxt.Text) < 0)
                {
                    controladorErrores.SetError(alturaComercialTxt, "La altura comercial del arbol debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(alturaTotalTxt.Text) < 0)
                {
                    controladorErrores.SetError(alturaTotalTxt, "La altura total del arbol debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(dAPTxt.Text) < 0)
                {
                    controladorErrores.SetError(dAPTxt, "El valor del diametro del arbol debe ser mayor o igual a cero.");
                    error = true;
                }
                if (decimal.Parse(cAPTxt.Text) < 0)
                {
                    controladorErrores.SetError(cAPTxt, "El valor de la circufernecia de arbol debe ser mayor o igual a cero.");
                    error = true;
                }
                if (error) return;

                controladorErrores.Clear();

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
                    newLine.AREABASAL = Math.Round((decimal)(ForestCalculatorHelper.BasalAreaCAP((double)newLine.CAP)),3);
                    newLine.VOLCOM = Math.Round((decimal)(ForestCalculatorHelper.TreeVolumeByBasalArea((double)newLine.AREABASAL, (double)newLine.ALTCOMER_M, (double)p.FACTORDEFORMA)),3);
                    newLine.VOLTOT = Math.Round((decimal)(ForestCalculatorHelper.TreeVolumeByBasalArea((double)newLine.AREABASAL, (double)newLine.ALTTOT_M, (double)p.FACTORDEFORMA)),3);
                    lineInv.InsertInventoryLine(newLine);
                    f = form.GetForm(newForm.NROFORMULARIO);
                    string resultSaveChangues = lineInv.SaveChanges();
                    if (resultSaveChangues == "")
                    {
                        lineaInvBS.DataSource = f.LINEAINVENTARIO.ToList();
                        lineaInvBN.Refresh();
                        MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lineaInvBS.AddNew();
                        currentLine = (LINEAINVENTARIO)lineaInvBS.Current;
                        tipoArbolCbx.SelectedIndex = 1;
                        especieCbx.SelectedItem = newLine.ESPECIE;
                        if (newLine.TIPOARBOL == "BFB")
                        {
                            nroArbolTxt.Text = newLine.NROARB.ToString();
                            alturaComercialTxt.Text = newLine.ALTCOMER_M.ToString();
                            alturaTotalTxt.Text = newLine.ALTTOT_M.ToString();
                            tipoArbolCbx.SelectedValue = "NBF";
                            currentLine.NROARB = newLine.NROARB;
                            currentLine.ESPECIE = newLine.ESPECIE;
                            currentLine.ALTCOMER_M = newLine.ALTCOMER_M;
                            currentLine.ALTTOT_M = newLine.ALTTOT_M;
                        }
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(resultSaveChangues);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
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
                    currentLine.AREABASAL = (decimal)(ForestCalculatorHelper.BasalAreaDAP((double)newLine.DAP));
                    currentLine.VOLCOM = (decimal)(ForestCalculatorHelper.TreeVolumeByBasalArea((double)newLine.AREABASAL, (double)newLine.ALTCOMER_M, (double)p.FACTORDEFORMA));
                    currentLine.VOLTOT = (decimal)(ForestCalculatorHelper.TreeVolumeByBasalArea((double)newLine.AREABASAL, (double)newLine.ALTTOT_M, (double)p.FACTORDEFORMA));
                    lineInv.UpdateInventoryLine(currentLine);
                    f = form.GetForm(newForm.NROFORMULARIO);
                    string resultSaveChangues = lineInv.SaveChanges();
                    if (resultSaveChangues == "")
                    {
                        lineaInvBS.DataSource = f.LINEAINVENTARIO.ToList();
                        lineaInvBN.Refresh();
                        MessageBox.Show("Los datos fueron actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tipoArbolCbx.SelectedValue = "NBF";
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(resultSaveChangues);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
                }
                modified = true;
                PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
                Program.Cache.Add("project", result, new CacheItemPolicy());
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void guardarRegenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = false;

                if (especieRegenCbx.SelectedItem == null)
                {
                    controladorErrores.SetError(especieRegenCbx, "Seleccione una especie.");
                    error = true;
                }
                if (decimal.Parse(latizalTxt.Text) < 0)
                {
                    controladorErrores.SetError(latizalTxt, "El valor del latizal debe ser mayor que cero.");
                    error = true;
                }
                if (decimal.Parse(brinzalTxt.Text) < 0)
                {
                    controladorErrores.SetError(brinzalTxt, "El valor del brinzal debe ser mayor que cero.");
                    error = true;
                }
                if (error) return;

                controladorErrores.Clear();

                LINEAREGENERACION currentLine = (LINEAREGENERACION)regeneracionBS.Current;
                FORMULARIO f = form.GetForm(newForm.NROFORMULARIO);
                if (currentLine.LINEAREGEN == Guid.Empty)
                {
                    LINEAREGENERACION newLine = Program.ContextData.LINEAREGENERACION.Create();
                    newLine.LINEAREGEN = Guid.NewGuid();
                    newLine.FORMULARIO = f;
                    newLine.ESPECIE = (ESPECIE)especieRegenCbx.SelectedItem;
                    newLine.LATIZAL = decimal.Parse(latizalTxt.Text);
                    newLine.BRINZAL = decimal.Parse(brinzalTxt.Text);
                    lineRegen.InsertRegenerationLine(newLine);
                    string resultSaveChangues = lineRegen.SaveChanges();
                    if (resultSaveChangues == string.Empty)
                    {
                        f = form.GetForm(newForm.NROFORMULARIO);
                        regeneracionBS.DataSource = f.LINEAREGENERACION.ToList();
                        regeneracionBN.Refresh();
                        regeneracionBS.AddNew();
                        MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(resultSaveChangues);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
                }
                else
                {
                    currentLine.ESPECIE = (ESPECIE)especieRegenCbx.SelectedItem;
                    currentLine.LATIZAL = decimal.Parse(latizalTxt.Text);
                    currentLine.BRINZAL = decimal.Parse(brinzalTxt.Text);
                    lineRegen.UpdateRegenerationLine(currentLine);
                    string resultSaveChangues = lineRegen.SaveChanges();
                    if (resultSaveChangues == string.Empty)
                    {
                        f = form.GetForm(newForm.NROFORMULARIO);
                        regeneracionBS.DataSource = f.LINEAREGENERACION.ToList();
                        regeneracionBN.Refresh();
                        MessageBox.Show("Los datos fueron Actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(resultSaveChangues);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
                }
                PROYECTO result = project.GetProject(newForm.PROYECTO.NROPROY);
                Program.Cache.Add("project", result, new CacheItemPolicy());
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void guardarLineNoMadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = false;

                if (observacionesTxt.Text == "")
                {
                    controladorErrores.SetError(observacionesTxt, "El campo observaciones es requerido.");
                    error = true;
                }
                if (newLineNoTimber.TIPODEUSO.ToList().Count == 0)
                {
                    controladorErrores.SetError(tipoDeUsosLbc, "No se ha seleccionado ningun tipo de uso, escoga al menos uno.");
                    error = true;
                }
                if (error) return;

                controladorErrores.Clear();
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
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void calcularParametros()
        {
            PROYECTO p = (PROYECTO)Program.Cache.Get("project");
            if (p!=null)
            {
                double areaBasal = cAPTxt.Text!=string.Empty?Math.Round(ForestCalculatorHelper.BasalAreaCAP(double.Parse(cAPTxt.Text)), 3):0;
                double volumenComercial =alturaComercialTxt.Text!=string.Empty? Math.Round(ForestCalculatorHelper.TreeVolumeByBasalArea(areaBasal, double.Parse(alturaComercialTxt.Text), (double)p.FACTORDEFORMA), 3):0;
                double volumenTotal = alturaTotalTxt.Text != string.Empty ? Math.Round(ForestCalculatorHelper.TreeVolumeByBasalArea(areaBasal, double.Parse(alturaTotalTxt.Text), (double)p.FACTORDEFORMA), 3) : 0;
                parametrosLineaTxt.Text = "1) Area basal: " + areaBasal + Environment.NewLine + "2) Volumen comercial: " + volumenComercial + Environment.NewLine + "3) Volumen total: " + volumenTotal;
            }
        }

        private void dAPTxt_TextChanged(object sender, EventArgs e)
        {
            LINEAINVENTARIO currentLine = (LINEAINVENTARIO)lineaInvBS.Current;
            if (currentLine != null)
            {
                if (currentLine.LINEAINV == Guid.Empty)
                {
                    if (!modified)
                    {
                        modified = true;
                        return;
                    }
                    if (dAPTxt.Text != "")
                    {
                        double output = 0;
                        bool result = double.TryParse(dAPTxt.Text, out output);
                        if (result)
                        {
                            modified = false;
                            ((LINEAINVENTARIO)lineaInvBS.Current).CAP = Math.Round((decimal)(output * Math.PI),3);
                            ((LINEAINVENTARIO)lineaInvBS.Current).DAP = (decimal)output;
                        }
                        else MessageBox.Show("Entra invalida para el diametro.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            calcularParametros();
        }

        private void cAPTxt_TextChanged(object sender, EventArgs e)
        {
            LINEAINVENTARIO currentLine = (LINEAINVENTARIO)lineaInvBS.Current;
            if (currentLine != null)
            {
                if (currentLine.LINEAINV == Guid.Empty)
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
                            ((LINEAINVENTARIO)lineaInvBS.Current).DAP = Math.Round((decimal)(output / Math.PI),3);
                            ((LINEAINVENTARIO)lineaInvBS.Current).CAP = (decimal)output;
                        }
                        else MessageBox.Show("Entra invalida para la medida de la circunferencia.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            calcularParametros();
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
            childForm.Btn_nuevaEspecieForm_Click(sender, e, (PROYECTO)Program.Cache.Get("project"),"formulario");
            childForm.ShowDialog(this);
            especieBS.DataSource = ((PROYECTO)Program.Cache.Get("project")).ESPECIE.OrderBy(ex => ex.NOMCOMUN);
            especieCbx.DataSource = especieBS;
            especieCbx.DisplayMember = "NOMCIENTIFICO";
            especieCbx.ValueMember = "CODESP";
            especieCbx.Refresh();
            if (especieBS.Count != 0)
            {
                especieCbx.SelectedItem = (ESPECIE)especieBS.Current;
                especieRegenCbx.SelectedItem = (ESPECIE)especieBS.Current;
            }
        }

        private void cambiarOpcionBusqueda(object sender, EventArgs e)
        {
            if (nombreCientRbtn.Checked) 
            {
                nombreComunRbtn.Checked = false;
                especieBS.DataSource = ((PROYECTO)Program.Cache.Get("project")).ESPECIE.OrderBy(esp => esp.NOMCIENTIFICO); 
                especieCbx.DataSource = especieBS;
                especieCbx.DisplayMember = "NOMCIENTIFICO";
                especieCbx.ValueMember = "CODESP";
                especieCbx.Refresh();
            }
            else 
            {
                nombreCientRbtn.Checked = false;
                especieBS.DataSource = ((PROYECTO)Program.Cache.Get("project")).ESPECIE.OrderBy(esp => esp.NOMCOMUN); ;
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
                especieBS.DataSource = ((PROYECTO)Program.Cache.Get("project")).ESPECIE.OrderBy(esp => esp.NOMCIENTIFICO);
                especieRegenCbx.DataSource = especieBS;
                especieRegenCbx.DisplayMember = "NOMCIENTIFICO";
                especieRegenCbx.ValueMember = "CODESP";
                especieRegenCbx.Refresh();
            }
            else
            {
                nomCientificoRegenRbtn.Checked = false;
                especieBS.DataSource = ((PROYECTO)Program.Cache.Get("project")).ESPECIE.OrderBy(esp => esp.NOMCOMUN); 
                especieRegenCbx.DataSource = especieBS;
                especieRegenCbx.DisplayMember = "NOMCOMUN";
                especieRegenCbx.ValueMember = "CODESP";
                especieRegenCbx.Refresh();
            }
        }

        private void verDetalleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Guid cod = (Guid)especieCbx.SelectedValue;
                Especies_Form childForm = new Especies_Form();
                childForm.MdiParent = ParentForm;
                childForm.setstate("formulario");
                childForm.btn_detalle(sender, e, cod);
                childForm.Show();
            }
            catch(Exception ex)
            {
                Error_Form childForm = new Error_Form(ex.Message);
                childForm.Show();
            }
        }

        private void noMaderableBS_CurrentChanged(object sender, EventArgs e)
        {
            if (noMaderableBS.Count > 0)
            {
                guardarLineNoMadBtn.Enabled = true;
                eliminarLineaNoMaderables.Enabled = true;
            }
            else
            {
                guardarLineNoMadBtn.Enabled = false;
                eliminarLineaNoMaderables.Enabled = false;
            }
            LINEANOMADERABLES linea = (LINEANOMADERABLES)noMaderableBS.Current;
            tipoDeUsosLbc.ClearSelected();
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
            if (lineaInvBS.Count > 0)
            {
                guardarLineaBtn.Enabled = true;
                eliminarLineaInv.Enabled = true;
            }
            else 
            {
                guardarLineaBtn.Enabled = false;
                eliminarLineaInv.Enabled = false;
            }
            LINEAINVENTARIO currentLine=(LINEAINVENTARIO)lineaInvBS.Current;
            if (currentLine != null)
            {
                if (currentLine.TIPOARBOL == "NBF") tipoArbolCbx.SelectedValue = "NBF";
                else tipoArbolCbx.SelectedValue = "BFB";
            }
        }

        private void EliminarLineaInv_Click(object sender, EventArgs e)
        {
            try
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
                    tipoArbolCbx.SelectedValue = "NBF";
                    if (especieBS.Count != 0)
                    {
                        especieCbx.SelectedItem = (ESPECIE)especieBS.Current;
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void eliminarRegen_Click(object sender, EventArgs e)
        {
            try
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
                    if (especieBS.Count != 0)
                    {
                        especieRegenCbx.SelectedItem = (ESPECIE)especieBS.Current;
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void eliminarNoMaderables_Click(object sender, EventArgs e)
        {
            try{
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
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void detalleEspecieRegenBtn_Click(object sender, EventArgs e)
        {
            Guid cod = (Guid)especieRegenCbx.SelectedValue;
            Especies_Form childForm = new Especies_Form();
            childForm.MdiParent = ParentForm;
            childForm.setstate("formulario");
            childForm.btn_detalle(sender, e, cod);
            childForm.Show();
        }

        private void registrarEspecieRegenBtn_Click(object sender, EventArgs e)
        {
            Especies_Form childForm = new Especies_Form();
            childForm.MdiParent = ParentForm;
            childForm.Btn_nuevaEspecieForm_Click(sender, e, (PROYECTO)Program.Cache.Get("project"),"formulario");
            childForm.Show();
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            nroArbolTxt.Text = "0";
            especieCbx.SelectedItem = null;
            dAPTxt.Text  = "0";
            cAPTxt.Text = "0";
            alturaComercialTxt.Text = "0";
            alturaTotalTxt.Text = "0";
        }

        private void SeleccionarTodosUsosBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tipoDeUsosLbc.Items.Count; i++)
            {
                tipoDeUsosLbc.SetItemChecked (i, true);
            }
        }

        private void LimpiarTodosUsosBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tipoDeUsosLbc.Items.Count; i++)
            {
                tipoDeUsosLbc.SetItemChecked(i, false);
            }
        }

        private void Crear_Editar_Formulario_Form_Load(object sender, EventArgs e)
        {
            tipoArbolCbx.SelectedValue = "NBF";
            if (especieBS.Count != 0)
            {
                especieCbx.SelectedItem = (ESPECIE)especieBS.Current;
                especieRegenCbx.SelectedItem = (ESPECIE)especieBS.Current;
            }
        }

        private void validatedNumericValues(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void inicioDpk_ValueChanged(object sender, EventArgs e)
        {
            if (inicioDpk.Value.CompareTo(finalDpk.Value) > 0)
            {
                MessageBox.Show("La fecha y hora de inicio no pude ser posterior a la fecha y hora final.", "Fecha invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inicioDpk.Value = DateTime.Now;
            }
        }

        private void finalDpk_ValueChanged(object sender, EventArgs e)
        {
            if (finalDpk.Value.CompareTo(inicioDpk.Value) < 0)
            {
                MessageBox.Show("La fecha y hora final no pude ser anterior a la fecha y hora inicial.", "Fecha invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                finalDpk.Value = DateTime.Now;
            }
        }

        private void agregarLineInv_Click(object sender, EventArgs e)
        {
            lineaInvBS.AddNew();
            tipoArbolCbx.SelectedValue = "NBF";
            if (especieBS.Count != 0)
            {
                especieCbx.SelectedItem = (ESPECIE)especieBS.Current;
            }
        }

        private void agregarLineaRegen_Click(object sender, EventArgs e)
        {
            regeneracionBS.AddNew();
            if (especieBS.Count != 0)
            {
                especieRegenCbx.SelectedItem = (ESPECIE)especieBS.Current;
            }
        }

        private void datosTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datosTabControl.SelectedIndex == 1)
            {
                if (especieBS.Count != 0 && especieRegenCbx.SelectedItem==null)
                {
                    especieRegenCbx.SelectedItem = (ESPECIE)especieBS.Current;
                }
            }
        }
        
        private void regeneracionBS_CurrentItemChanged(object sender, EventArgs e)
        {
            if (regeneracionBS.Count > 0)
            {
                eliminarLineaRegen.Enabled = true;
                guardarRegenBtn.Enabled = true;
            }
            else
            {
                guardarRegenBtn.Enabled = false;
                eliminarLineaRegen.Enabled = false;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            especieRegenCbx.Dispose();
            especieCbx.Dispose();
            especieBS.Dispose();
            estratoCbx.Dispose();
            estratoBS.Dispose();
            base.OnClosing(e);
        }

        private void alturaComercialTxt_TextChanged(object sender, EventArgs e)
        {
            calcularParametros();
        }

        private void alturaTotalTxt_TextChanged(object sender, EventArgs e)
        {
            calcularParametros();
        }
    }
}

