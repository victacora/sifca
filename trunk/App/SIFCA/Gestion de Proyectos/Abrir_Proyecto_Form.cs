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
    public partial class Abrir_Proyecto_Form : Form
    {
        private ProjectBL project;
        private ObjectiveInventoryBL objectiveInv;
        private TypeSampleDesignBl typeSample;

        public Abrir_Proyecto_Form()
        {
            InitializeComponent();
            project = new ProjectBL(Program.ContextData);
            objectiveInv = new ObjectiveInventoryBL(Program.ContextData);
            typeSample=new TypeSampleDesignBl(Program.ContextData);
            proyectoBS.DataSource = project.GetProjects();
            proyectosDGW.DataSource = proyectoBS;
            objetivoInvBS.DataSource=objectiveInv.GetObjectiveInventories();
            tipoDisenoMuesBS.DataSource=typeSample.GetTypeSampleDesignList();
            criterioCbx.SelectedIndex = 0;
        }

        private void proyectoDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UserBL user = new UserBL(Program.ContextData);
            foreach (DataGridViewRow row in proyectosDGW.Rows)
            {
                USUARIO data = user.GetUser((Guid)row.Cells[2].Value);
                if (data != null) row.Cells[3].Value = data.NOMBRES + " " + data.APELLIDOS;
            }
        }

        private void proyectoDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == proyectosDGW.Columns["VerProyectosAsoc"].Index && e.RowIndex >= 0)
            {
                Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form();
                childForm.MdiParent = this.ParentForm;
                childForm.Show();
                this.Close();
            }
            if (e.ColumnIndex == proyectosDGW.Columns["Abrir"].Index && e.RowIndex >= 0)
            {
                Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form();
                childForm.MdiParent = this.ParentForm;
                childForm.Show();
                this.Close();
            }
        }

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            if (busquedaTxt.Text != "")
            {
                string criteria = criterioCbx.SelectedItem.ToString();
                if (criteria != "Fecha (dd/mm/aaaa)")
                {
                    proyectoBS.DataSource = project.SearchProject(busquedaTxt.Text, criteria);
                    proyectosDGW.DataSource = proyectoBS;
                    proyectosDGW.Refresh();
                }
                else
                {
                    DateTime output;
                    bool result = DateTime.TryParse(busquedaTxt.Text, out output);
                    if (result)
                    {
                        proyectoBS.DataSource = project.SearchProject(busquedaTxt.Text, criteria);
                        proyectosDGW.DataSource = proyectoBS;
                        proyectosDGW.Refresh();
                    }
                }
            }
            else
            {
                proyectoBS.DataSource = project.GetProjects();
                proyectosDGW.DataSource = proyectoBS;
                proyectosDGW.Refresh();
            }
        }

    }
}
