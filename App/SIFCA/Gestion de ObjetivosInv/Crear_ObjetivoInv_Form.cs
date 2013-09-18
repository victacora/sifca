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
    public partial class Crear_ObjetivoInv_Form : Form
    {
        private OBJETIVOINVENTARIO objetivo;
        private ObjectiveInventoryBL objetivoBl;
        public Crear_ObjetivoInv_Form()
        {
            InitializeComponent();
            objetivoBl = new ObjectiveInventoryBL(Program.ContextData);
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            objetivo = new OBJETIVOINVENTARIO();
            objetivo.NOMBRETIPOINV = txt_Nombre.Text;
            objetivo.DESCRIPOBJETINV = txt_Descripcion.Text;
            objetivoBl.InsertObjectiveInventory(objetivo);
            objetivoBl.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();    
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
