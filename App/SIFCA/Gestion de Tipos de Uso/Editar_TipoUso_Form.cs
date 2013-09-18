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

namespace SIFCA.Gestion_de_Tipos_De_Uso
{
    public partial class Editar_TipoUso_Form : Form
    {
        private TIPODEUSO typeUse;
        private TypeUseBL typeUseBl;

        public Editar_TipoUso_Form()
        {
            InitializeComponent();
            typeUseBl = new TypeUseBL(Program.ContextData);
            TypeUseBSource.DataSource = typeUseBl.GetTypeUses();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_por_nombre(object sender, EventArgs e)
        {
            if (cbx_Nom.SelectedValue != null)
            {
                typeUse = typeUseBl.GetTypeUse((String)cbx_Nom.SelectedValue);
                txt_Nombre.Text = typeUse.NOMBRETIPOUSO;
                txt_Descripcion.Text = typeUse.DESCRIPCION;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            typeUse.NOMBRETIPOUSO = txt_Nombre.Text;
            typeUse.DESCRIPCION= txt_Descripcion.Text;
            MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            TypeUseBSource.DataSource = typeUseBl.GetTypeUses();
        }

        private void Btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
