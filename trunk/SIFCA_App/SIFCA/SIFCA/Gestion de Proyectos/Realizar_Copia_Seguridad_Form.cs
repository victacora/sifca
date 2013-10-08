using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIFCA
{
    public partial class Realizar_Copia_Seguridad_Form : Form
    {
        public Realizar_Copia_Seguridad_Form()
        {
            InitializeComponent();
            tipoCopiaCbx.SelectedIndex = 0;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Program.ContextData.createBackupDB(ubicacionTxt.Text,tipoCopiaCbx.SelectedItem.ToString());
            MessageBox.Show("La copia de seguridad se realizo de manera exitosa", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fld = new FolderBrowserDialog();
            Fld.SelectedPath = ubicacionTxt.Text;
            Fld.ShowNewFolderButton = true;
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                ubicacionTxt.Text = Fld.SelectedPath;
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
