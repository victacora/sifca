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

namespace SIFCA.Gestion_de_Estados_Sanitarios
{
    public partial class Ver_EstadoSanitario_Form : Form
    {
        private ESTADOSANITARIO state;
        private StateBL stateBL;

        public Ver_EstadoSanitario_Form()
        {
            InitializeComponent();
            stateBL = new StateBL(Program.ContextData);
            StateBSource.DataSource = stateBL.GetStates();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_por_nombre(object sender, EventArgs e)
        {
            if (cbx_Nom.SelectedValue != null)
            {
                state = stateBL.GetState((String)cbx_Nom.SelectedValue);
                txt_Nombre.Text = state.ESTADO;
                txt_Descripcion.Text = state.DESCRIPESTADO;
            }
        }
    }
}
