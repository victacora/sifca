﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Caching;
using SIFCA_DAL;
using SIFCA_BLL;
using SIFCA.Gestionar_Especies;

namespace SIFCA
{
    public partial class Principal_Form : Form
    {
        private ProjectBL project;
        private StationBL station;

        public Principal_Form()
        {
            InitializeComponent();
            project = new ProjectBL(Program.ContextData);
            station = new StationBL(Program.ContextData);
        }

        private void CreateNewProject(object sender, EventArgs e)
        {
            Crear_Proyecto_Form childForm = new Crear_Proyecto_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ImportProject(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de importacion xml (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void ExportProject(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de exportacion (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void introducirDatosEstacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_Estacion_Form childForm = new Crear_Estacion_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void listarEstacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Estaciones_Form childForm = new Listar_Estaciones_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void introducirDatosDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestDatInv_Form childForm = new GestDatInv_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void regeneracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestDatRegen_Form childForm = new GestDatRegen_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //TODO:
        private void Principal_Form_Load(object sender, EventArgs e)
        {
            //cargar stage activo

            if (!Program.Cache.Contains("principalProject"))
            {
                PROYECTO activateProject = project.GetActivateProject();
                ESTACION localStation = station.GetStations().First();
                if (activateProject != null) Program.Cache.Add("principalProject", activateProject, new CacheItemPolicy());
                else MessageBox.Show("No se ha creado ningun proyecto, que tenga por estado Activo.", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (localStation != null) Program.Cache.Add("localStation", localStation, new CacheItemPolicy());
                else MessageBox.Show("No se ha registrado la informacion para esta estacion", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cambiar el stage activo y cargarlo en la Cache
            PROYECTO activateProject = project.GetActivateProject();
            Program.Cache.Set("principalProject", activateProject, new CacheItemPolicy());
        }

        private void listarEspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Especies_Form childForm = new Listado_Especies_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void listarProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Proyectos_Form childForm = new Listar_Proyectos_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ingresarEspecieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_Especie_Form childForm = new Ingresar_Especie_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void crearListadoEspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Especies_Form childForm = new Listado_Especies_Form();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}