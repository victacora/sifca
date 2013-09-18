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
    public partial class Ver_Calidad_Form : Form
    {
        private CALIDAD quality;
        private QualityBL qualityBl;

        public Ver_Calidad_Form()
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
    }
}
