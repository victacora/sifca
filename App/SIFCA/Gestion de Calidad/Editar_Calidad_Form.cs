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
    public partial class Editar_Calidad_Form : Form
    {
        private CALIDAD quality;
        private QualityBL qualityBl;

        public Editar_Calidad_Form()
        {
            InitializeComponent();
            qualityBl = new QualityBL(Program.ContextData);
            QualityBSource.DataSource = qualityBl.GetQualities();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_por_nombre(object sender, EventArgs e)
        {
            if (cbx_Nom.SelectedValue != null)
            {
                quality = qualityBl.GetQuality((Decimal)cbx_Nom.SelectedValue);
                txt_Nombre.Text = quality.CODCALIDAD.ToString();
                txt_Descripcion.Text = quality.DESCRIPCALIDAD;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            quality.CODCALIDAD = Convert.ToInt32((String)txt_Nombre.Text);
            quality.DESCRIPCALIDAD = txt_Descripcion.Text;
            MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            QualityBSource.DataSource = qualityBl.GetQualities();
        }

        private void Btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
