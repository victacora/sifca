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
    public partial class Crear_TipoMuestral_Form : Form
    {
        private TIPODISENOMUESTRAL tipo;
        private TypeSampleDesignBl typeBl;
        public Crear_TipoMuestral_Form()
        {
            InitializeComponent();
            typeBl = new TypeSampleDesignBl(Program.ContextData);
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            tipo = new TIPODISENOMUESTRAL();
            tipo.NOMTIPODISEMUEST = txt_Nombre.Text;
            tipo.DESCRIPTIPODISEMUEST = txt_Descripcion.Text;
            typeBl.InsertTypeSampleDesign(tipo);
            typeBl.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();    
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
