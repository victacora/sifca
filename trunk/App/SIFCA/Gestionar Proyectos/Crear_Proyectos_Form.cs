using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;

namespace SIFCA
{
    public partial class Crear_Proyecto_Form : Form
    {
        private ProjectBL project;
        
        public Crear_Proyecto_Form()
        {
            InitializeComponent();
            project= new ProjectBL();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Crear_Proyecto_Form_Load(object sender, EventArgs e)
        {
            this.tipoInvenCbx.DataSource = publishContext.Authors.ToList();
            cmoAuthors.DisplayMember = "FirstName";
            cmoAuthors.Invalidate();
        }
    }
}
