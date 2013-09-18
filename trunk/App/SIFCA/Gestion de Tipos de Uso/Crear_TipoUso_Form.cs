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

namespace SIFCA.Gestion_de_Tipos_De_Uso
{
    public partial class Crear_TipoUso_Form : Form
    {
        private TIPODEUSO typeUse;
        private TypeUseBL typeUseBl;
        public Crear_TipoUso_Form()
        {
            InitializeComponent();
            typeUseBl = new TypeUseBL(Program.ContextData);
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            typeUse = new TIPODEUSO();
            typeUse.NOMBRETIPOUSO = txt_Nombre.Text;
            typeUse.DESCRIPCION = txt_Descripcion.Text;
            typeUseBl.InsertTypeUse(typeUse);
            typeUseBl.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();    
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
