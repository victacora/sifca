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
    public partial class Seleccionar_Estratos_Form : Form
    {
        private ProjectBL projects;
        public List<decimal> codEstratos;
        public List<string> opciones;

        public Seleccionar_Estratos_Form()
        {
            InitializeComponent();
            codEstratos = new List<decimal>();
            opciones = new List<string>();
            projects=new ProjectBL(Program.ContextData);
            PROYECTO currentProject = (PROYECTO)Program.Cache.Get("project");
            estratosBS.DataSource = currentProject!=null?projects.GetProjectStratums(currentProject.NROPROY):new List<ESTRATO>();
            if (estratosBS.Count == 0)
            {
                estratosProyectoLBC.Enabled = false;
                LimpiarTodosEstratosBtn.Enabled = false;
                SeleccionarTodosEstratosBtn.Enabled = false;
                estratosBS.Add(new ESTRATO() { DESCRIPESTRATO = "Diseño muestral simple." });
                estratosProyectoLBC.DataSource = estratosBS;
                estratosProyectoLBC.DisplayMember = "DESCRIPESTRATO";
                estratosProyectoLBC.ValueMember = "CODEST";
                estratosProyectoLBC.Refresh();
                estratosProyectoLBC.SetItemChecked(0, true);
                codEstratos.Clear();
            }
            else
            {
                estratosProyectoLBC.DataSource = estratosBS;
                estratosProyectoLBC.DisplayMember = "DESCRIPESTRATO";
                estratosProyectoLBC.ValueMember = "CODEST";
            }
        }

        private void LimpiarTodosUsosBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < estratosProyectoLBC.Items.Count; i++)
            {
                estratosProyectoLBC.SelectedIndex = i;
                estratosProyectoLBC.SetItemChecked(i, false);
            }
        }

        private void SeleccionarTodosUsosBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < estratosProyectoLBC.Items.Count; i++)
            {
                estratosProyectoLBC.SelectedIndex = i;
                estratosProyectoLBC.SetItemChecked(i, true);
            }
        }

        private void estratosProyectoLbc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            decimal codigo = ((ESTRATO)estratosProyectoLBC.SelectedItem).CODEST;
            if (e.NewValue == CheckState.Checked)
            {
                if(!codEstratos.Contains(codigo))codEstratos.Add(codigo);
            }
            else
            {
                codEstratos.Remove(codigo);
            }
        }

        private void seleccionarTodasVarBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seleccionarVariableLBC.Items.Count; i++)
            {
                seleccionarVariableLBC.SelectedIndex = i;
                seleccionarVariableLBC.SetItemChecked(i, true);
            }
        }

        private void limpiarTodasVarBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seleccionarVariableLBC.Items.Count; i++)
            {
                seleccionarVariableLBC.SelectedIndex = i;
                seleccionarVariableLBC.SetItemChecked(i, false);
            }
        }

        private void seleccionarVariableLBC_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string opcion = string.Empty;
            if (e.Index == 0) opcion = "NA";
            else if (e.Index == 1) opcion = "AB";
            else if (e.Index == 2) opcion = "VC";
            else opcion = "VT";
            if (e.NewValue == CheckState.Checked)
            {
                if (!opciones.Contains(opcion)) opciones.Add(opcion);
            }
            else
            {
                opciones.Remove(opcion);
            }
        }

        private void procesarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<FORMULARIO> formularios = new List<FORMULARIO>();
                if (((PROYECTO)Program.Cache.Get("project")).LISTADODEESTRATOS.Count != 0)
                {
                    foreach (FORMULARIO frm in ((PROYECTO)Program.Cache.Get("project")).FORMULARIO.ToList())
                    {
                        if (frm.CODEST != null)
                        {
                            if (codEstratos.Contains((decimal)frm.CODEST))
                            {
                                formularios.Add(frm);
                            }
                        }
                    }
                }
                else formularios = ((PROYECTO)Program.Cache.Get("project")).FORMULARIO.ToList();
                if (formularios.Count != 0)
                {
                    Totales_Formularios_Form childForm = new Totales_Formularios_Form(formularios, opciones);
                    childForm.MdiParent = ParentForm;
                    childForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se ha asociado uno o mas formularios a este proyecto, verifique e intente nuevamente.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this.MdiParent;
                er.Show();
            }
        }

        private void verFormulariosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO user = (USUARIO)Program.Cache.Get("user");
                if (user != null)
                {
                    Abrir_Formulario_Form childForm = new Abrir_Formulario_Form();
                    childForm.MdiParent = this.MdiParent;
                    childForm.Show();
                }
                else MessageBox.Show("Ningun usuario ha iniciado sesión.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.MdiParent = this.MdiParent;
                er.Show();
            } 
        }

        private void verArbolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PROYECTO p = ((PROYECTO)Program.Cache.Get("project"));
                if (p != null)
                {
                    Arbol_Proyectos_Por_Etapas_Form childForm = new Arbol_Proyectos_Por_Etapas_Form(p);
                    childForm.MdiParent = this.ParentForm;
                    childForm.Show();
                }
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }


    }
}
