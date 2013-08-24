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

namespace SIFCA.Gestionar_Especies
{
    public partial class Ingresar_Especie_Form : Form
    {
        private SpeciesBL species;
        public Ingresar_Especie_Form()
        {
            InitializeComponent();
            species = new SpeciesBL(ContextProvider.ContextData);
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            ESPECIE newSpecies = new ESPECIE();

            newSpecies.CODESP =  System.Convert.ToDecimal(this.txt_Codigo.Text);
            newSpecies.GRUPOCOM = this.txt_GrupoComercial.Text;
            newSpecies.NOMCOMUN = this.txt_NombreComun.Text;
            newSpecies.NOMCIENTIFICO = this.txt_NombreCientifico.Text;
            newSpecies.FAMILIA = this.txt_Familia.Text;
            newSpecies.ZONAGEOGRAFICA = this.txt_ZonaGeografica.Text;
            newSpecies.ZONADEVIDA = this.txt_ZonaVida.Text;

            if (this.btn_Crear.Text == "Crear")
            {
                species.InsertSpecie(newSpecies);
                species.SaveChanges();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }            
            
        }

        
    }
}
