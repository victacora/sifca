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
    public partial class Ver_Estrato_Form : Form
    {
        private StratumBL stratum;
        private ESTRATO est;
        public Ver_Estrato_Form()
        {
            InitializeComponent();
            stratum = new StratumBL(Program.ContextData);
            est = new ESTRATO();
            StratumBSource.DataSource = stratum.GetStratums();
        }

        private void Seleccion_Por_Nombre(object sender, EventArgs e)
        {
            if(cbx_Nom.SelectedValue!=null){
                est = stratum.GetStratum(Convert.ToInt32(cbx_Nom.SelectedValue));
                txt_Nombre.Text = est.CODEST.ToString();
                txt_Descripcion.Text = est.DESCRIPESTRATO.ToString();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
