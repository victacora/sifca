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

namespace SIFCA.Gestion_de_ObjetivosInv
{
    public partial class Ver_ObjetivoInv_Form : Form
    {
        private OBJETIVOINVENTARIO objetivo;
        private ObjectiveInventoryBL objetivoBl;

        public Ver_ObjetivoInv_Form()
        {
            InitializeComponent();
            objetivoBl = new ObjectiveInventoryBL(Program.ContextData);
            ObjetiveBSource.DataSource = objetivoBl.GetObjectiveInventories();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_por_nombre(object sender, EventArgs e)
        {
            if (cbx_Nom.SelectedValue != null)
            {
                objetivo = objetivoBl.GetObjectiveInventory((String)cbx_Nom.SelectedValue);
                txt_Nombre.Text = objetivo.NOMBRETIPOINV;
                txt_Descripcion.Text = objetivo.DESCRIPOBJETINV;
            }
        }
    }
}
