﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIFCA
{
    public partial class Principal_Form : Form
    {
        public Principal_Form()
        {
            InitializeComponent();
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

        }

        private void introducirDatosDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regeneracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Form_Load(object sender, EventArgs e)
        {
            //cargar proyecto activo
        }
    }
}