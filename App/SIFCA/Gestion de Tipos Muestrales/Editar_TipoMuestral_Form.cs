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
    public partial class Editar_TipoMuestral_Form : Form
    {
        private TIPODISENOMUESTRAL tipo;
        private TypeSampleDesignBl typeBl;
        public Editar_TipoMuestral_Form()
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

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            tipo.NOMTIPODISEMUEST = txt_Nombre.Text;
            tipo.DESCRIPTIPODISEMUEST = txt_Descripcion.Text;
            MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            TypeDesignBSource.DataSource = typeBl.GetTypeSampleDesignList();
        }

        private void Btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
