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

namespace SIFCA.Gestion_de_Estratos
{
    public partial class Crear_Estrato_Form : Form
    {
        private StratumBL stratum;
        public Crear_Estrato_Form()
        {
            InitializeComponent();
            stratum = new StratumBL(Program.ContextData);
        }
         
        private void btn_Crear_Click(object sender, EventArgs e)
        {
           
            ESTRATO newStratum = new ESTRATO();

            newStratum.DESCRIPESTRATO = this.txt_Nombre.Text;
            //newStratum.CODEST = Guid.NewGuid();

            stratum.InsertStratum(newStratum);
            stratum.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();            
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
