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
    public partial class Editar_Especie_Form : Form
    {
        SpeciesBL specie; //objeto para recuperar las especies de la base de datos
        ESPECIE esp; //objeto de cual se quiere actualizar datos
        GroupBL group; // Grupo comercial
        public Editar_Especie_Form()
        {
            InitializeComponent();
            specie = new SpeciesBL(Program.ContextData);
            group = new GroupBL(Program.ContextData);
            SpecieBSource.DataSource = specie.GetSpecies();
            
        }

        private void SeleccionPorNombreComun(object sender, EventArgs e)
        {
            
            if(cbx_NomComun.SelectedValue!=null){
                esp = specie.GetSpecie((Guid)cbx_NomComun.SelectedValue);
                GroupComBSource.DataSource = group.GetGroups();
            
                cbx_GroupCom.SelectedValue = esp.GRUPOCOM;
                txt_NomCom.Text = esp.NOMCOMUN;
                txt_NomCient.Text = esp.NOMCIENTIFICO;
                txt_Familia.Text = esp.FAMILIA;
                txt_ZonaGeo.Text = esp.ZONAGEOGRAFICA;
                txt_ZonaVida.Text = esp.ZONADEVIDA;
                txt_DimCorte.Text = ""+esp.DIAMMINCORTE;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            esp.GRUPOCOM = cbx_GroupCom.SelectedValue.ToString();
            esp.NOMCOMUN = txt_NomCom.Text;
            esp.NOMCIENTIFICO = txt_NomCient.Text;
            esp.FAMILIA = txt_Familia.Text;
            esp.ZONAGEOGRAFICA = txt_ZonaGeo.Text;
            esp.ZONADEVIDA = txt_ZonaVida.Text;
            esp.DIAMMINCORTE = Decimal.Parse(txt_DimCorte.Text);
            MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbx_GroupCom.SelectedValue = "";
            txt_NomCom.Text = "";
            txt_NomCient.Text = "";
            txt_Familia.Text = "";
            txt_ZonaGeo.Text = "";
            txt_ZonaVida.Text = "";
            txt_DimCorte.Text = "";
            SpecieBSource.DataSource = specie.GetSpecies();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
