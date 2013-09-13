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

namespace SIFCA.Gestion_de_Calidad
{
    public partial class Crear_Calidad_Form : Form
    {
        private CALIDAD quality;
        private QualityBL qualityBl;
        public Crear_Calidad_Form()
        {
            InitializeComponent();
            qualityBl = new QualityBL(Program.ContextData);
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            quality = new CALIDAD();
            quality.DESCRIPCALIDAD = txt_Descripcion.Text;
            qualityBl.InsertQuality(quality);
            qualityBl.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();    
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
