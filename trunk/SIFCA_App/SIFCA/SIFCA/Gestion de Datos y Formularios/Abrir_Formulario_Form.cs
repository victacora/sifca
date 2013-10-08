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
    public partial class Abrir_Formulario_Form : Form
    {
        private FormBL form;
        private StratumBL stratum;
        private ProjectBL project;

        public Abrir_Formulario_Form()
        {
            InitializeComponent();
            form = new FormBL(Program.ContextData);
            stratum = new StratumBL(Program.ContextData);
            project = new ProjectBL(Program.ContextData);
            formularioBS.DataSource = ((PROYECTO)Program.Cache.Get("project")).FORMULARIO.ToList();
            formularioDGW.DataSource = formularioBS;
            estratosBS.DataSource = stratum.GetStratums();
            criterioCbx.SelectedIndex = 0;
        }

        private void formularioDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UserBL user = new UserBL(Program.ContextData);
            foreach (DataGridViewRow row in formularioDGW.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    USUARIO data = user.GetUser((Guid)row.Cells[2].Value);
                    if (data != null) row.Cells[3].Value = data.NOMBRES + " " + data.APELLIDOS;
                }
                else formularioDGW.Rows.RemoveAt(row.Index);
            }

        }

        private void formularioDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == formularioDGW.Columns["abrir"].Index && e.RowIndex >= 0)
            {
                FORMULARIO result = form.GetForm((Guid)formularioDGW.Rows[e.RowIndex].Cells[1].Value);
                Crear_Editar_Formulario_Form childForm = new Crear_Editar_Formulario_Form(result);
                childForm.MdiParent = ParentForm;
                childForm.Show();
                this.Close();
            }
            else if (e.ColumnIndex == formularioDGW.Columns["verDatos"].Index && e.RowIndex >= 0)
            {
                FORMULARIO result = form.GetForm((Guid)formularioDGW.Rows[e.RowIndex].Cells[1].Value);
                Listar_Datos_Formulario_Form childForm = new Listar_Datos_Formulario_Form(result,0);
                childForm.MdiParent = ParentForm;
                childForm.Show();
            }
            else if (e.ColumnIndex == formularioDGW.Columns["eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult myResult= MessageBox.Show("¿Esta seguro de querer eliminar este formulario?", "Mensaje de confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    PROYECTO result = project.GetProject(((PROYECTO)Program.Cache.Get("project")).NROPROY);
                    Program.Cache.Add("project", result, new CacheItemPolicy());
                    form.DeleteForm((Guid)formularioDGW.Rows[e.RowIndex].Cells[1].Value);
                    form.SaveChanges();
                    formularioBS.DataSource = result.FORMULARIO.ToList();
                    formularioDGW.DataSource = formularioBS;
                    formularioDGW.Refresh();
                }
            }
        }

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            
            if (busquedaTxt.Text != "")
            {
                string criteria = criterioCbx.SelectedItem.ToString();
                if (criteria != "dd/mm/aaaa")
                {
                    formularioBS.DataSource = form.SearchForm(busquedaTxt.Text, criteria);
                    formularioDGW.DataSource = formularioBS;
                    formularioDGW.Refresh();
                }
                else 
                {
                    DateTime output;
                    bool result = DateTime.TryParse(busquedaTxt.Text, out output);
                    if (result)
                    {
                        formularioBS.DataSource = form.SearchForm(busquedaTxt.Text, criteria);
                        formularioDGW.DataSource = formularioBS;
                        formularioDGW.Refresh();
                    }
                }
            }
            else
            {
                formularioBS.DataSource = ((PROYECTO)Program.Cache.Get("project")).FORMULARIO.ToList();
                formularioDGW.DataSource = formularioBS;
                formularioDGW.Refresh();
            }

        }
    }
}
