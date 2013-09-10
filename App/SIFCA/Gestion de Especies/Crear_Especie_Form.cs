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

namespace SIFCA.Gestion_de_Especies
{
    public partial class Ingresar_Especie_Form : Form
    {
        private SpeciesBL species;
        private GroupBL GC;
        public Ingresar_Especie_Form()
        {
            InitializeComponent();
            GC = new GroupBL(Program.ContextData);
            species = new SpeciesBL(Program.ContextData);
            this.grupoComercialBSource.DataSource = GC.GetGroups();
        }
         
        private void btn_Crear_Click(object sender, EventArgs e)
        {
           
            ESPECIE newSpecies = new ESPECIE();

            Decimal DAP = System.Convert.ToDecimal(this.txt_DMC.Text);

            newSpecies.DIAMMINCORTE = DAP;
            newSpecies.CODESP =  Guid.NewGuid();
            newSpecies.GRUPOCOM = this.cbox_GrupoComercial.SelectedValue.ToString();
            newSpecies.NOMCOMUN = this.txt_NombreComun.Text;
            newSpecies.NOMCIENTIFICO = this.txt_NombreCientifico.Text;
            newSpecies.FAMILIA = this.txt_Familia.Text;
            newSpecies.ZONAGEOGRAFICA = this.txt_ZonaGeografica.Text;
            newSpecies.ZONADEVIDA = this.txt_ZonaVida.Text;

            species.InsertSpecie(newSpecies);
            species.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();            
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
