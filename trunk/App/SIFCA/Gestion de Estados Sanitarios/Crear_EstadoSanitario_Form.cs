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
    public partial class Crear_EstadoSanitario_Form : Form
    {
        private ESTADOSANITARIO state;
        private StateBL stateBL;
        public Crear_EstadoSanitario_Form()
        {
            InitializeComponent();
            stateBL = new StateBL(Program.ContextData);
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            state = new ESTADOSANITARIO();
            state.ESTADO = txt_Nombre.Text;
            state.DESCRIPESTADO = txt_Descripcion.Text;
            stateBL.InsertSpecie(state);
            stateBL.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();    
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
