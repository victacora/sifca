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

namespace SIFCA.Gestion_de_Especies
{
    public partial class Ver_Especie_Form : Form
    {
        SpeciesBL specie; //objeto para recuperar las especies de la base de datos
        ESPECIE esp; //objeto de cual se quiere actualizar datos
        GroupBL group; // Grupo comercial
        
        public Ver_Especie_Form()
        {
            InitializeComponent();
            specie = new SpeciesBL(Program.ContextData);
            group = new GroupBL(Program.ContextData);
            SpecieBSource.DataSource = specie.GetSpecies();
        }

        private void SeleccionPorNombreComun(object sender, EventArgs e)
        {

            if (cbx_NomComun.SelectedValue != null)
            {
                esp = specie.GetSpecie((Guid)cbx_NomComun.SelectedValue);

                txt_GrupoCom.Text = esp.GRUPOCOM;
                txt_NomCom.Text = esp.NOMCOMUN;
                txt_NomCient.Text = esp.NOMCIENTIFICO;
                txt_Familia.Text = esp.FAMILIA;
                txt_ZonaGeo.Text = esp.ZONAGEOGRAFICA;
                txt_ZonaVida.Text = esp.ZONADEVIDA;
                txt_DimCorte.Text = "" + esp.DIAMMINCORTE;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
