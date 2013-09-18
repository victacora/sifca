using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;
using SIFCA_DAL;

namespace SIFCA.Gestion_de_Estratos
{
    public partial class Editar_Estrato_Form : Form
    {
        StratumBL stratum;
        ESTRATO est;
        public Editar_Estrato_Form()
        {
            InitializeComponent();
            stratum = new StratumBL(Program.ContextData);
            est = new ESTRATO();
            StratumBSource.DataSource = stratum.GetStratums();

        }

        private void SeleccionPorNombreComun(object sender, EventArgs e)
        {
            if (cbx_Nom.SelectedValue != null)
            {
                est = stratum.GetStratum(Convert.ToInt32(cbx_Nom.SelectedValue));
                txt_Cod.Text = est.CODEST.ToString();
                txt_Descripcion.Text = est.DESCRIPESTRATO.ToString();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            est.CODEST = Convert.ToDecimal(txt_Cod.Text);
            est.DESCRIPESTRATO = txt_Descripcion.Text;
            MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Cod.Text = "";
            txt_Descripcion.Text = "";
            StratumBSource.DataSource = stratum.GetStratums();
        }
    }
}
