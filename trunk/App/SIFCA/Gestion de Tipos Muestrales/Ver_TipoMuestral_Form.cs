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

namespace SIFCA.Gestion_de_Tipos_Muestrales
{
    public partial class Ver_TipoMuestral_Form : Form
    {

        private TIPODISENOMUESTRAL tipo;
        private TypeSampleDesignBl typeBl;
        public Ver_TipoMuestral_Form()
        {
            InitializeComponent();
            typeBl = new TypeSampleDesignBl(Program.ContextData);
            TypeDesignBSource.DataSource = typeBl.GetTypeSampleDesignList();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_por_nombre(object sender, EventArgs e)
        {
            if (cbx_Nom.SelectedValue != null)
            {
                tipo = typeBl.GetTypeSampleDesign((String)cbx_Nom.SelectedValue);
                txt_Nombre.Text = tipo.NOMTIPODISEMUEST;
                txt_Descripcion.Text = tipo.DESCRIPTIPODISEMUEST;
            }
        }
    }
}
