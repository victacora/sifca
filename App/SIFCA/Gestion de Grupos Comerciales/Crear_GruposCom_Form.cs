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

namespace SIFCA.Gestion_de_GruposCom
{
    public partial class Crear_GruposCom_Form : Form
    {
        private GroupBL group;
        public Crear_GruposCom_Form()
        {
            InitializeComponent();
            group = new GroupBL(Program.ContextData);
        }
         
        private void btn_Crear_Click(object sender, EventArgs e)
        {
           
            GRUPOCOMERCIAL newGroup = new GRUPOCOMERCIAL();

            newGroup.DESCRIPGRUPO = this.txt_Descripcion.Text;            
            
            //newStratum.CODEST = Guid.NewGuid();

            group.InsertGroup(newGroup);
            group.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();            
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
