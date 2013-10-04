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

namespace SIFCA.Gestion_Configuracion
{
    public partial class GruposComerciales_Form : Form
    {
        GRUPOCOMERCIAL groupCom;
        GroupBL groupComBL;
        public GruposComerciales_Form()
        {
            InitializeComponent();
            groupCom = new GRUPOCOMERCIAL();
            groupComBL = new GroupBL(Program.ContextData);
            grupoComBSource.DataSource = groupComBL.GetGroups();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            groupCom = new GRUPOCOMERCIAL();
            if (abrevTxt.Text != "" && descripcionTxt.Text != "")
            {
                groupCom.DESCRIPGRUPO = this.descripcionTxt.Text;
                groupCom.GRUPOCOM = this.abrevTxt.Text;

                groupComBL.InsertGroup(groupCom);
                groupComBL.SaveChanges();
                MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grupoComBSource.DataSource = groupComBL.GetGroups();
                ListadoGruposComerciales.Refresh();
                panel2.Hide();
                panel1.Show();
                panel3.Hide();
            }

        }

        private void ListadoDeEspecies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (ListadoGruposComerciales.Columns[e.ColumnIndex].Name == "Acciones")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoGruposComerciales.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                groupCom = new GRUPOCOMERCIAL();

                groupCom = groupComBL.GetGroup(row.Cells[1].Value.ToString());

                updateAbrevTxt.Text = groupCom.GRUPOCOM;
                updateDescripcionTxt.Text = groupCom.DESCRIPGRUPO;
                panel1.Hide();
                panel2.Hide();
                panel3.Show();
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateDescripcionTxt.Text != "")
            {
                groupCom.GRUPOCOM= updateAbrevTxt.Text;
                groupCom.DESCRIPGRUPO= updateDescripcionTxt.Text;
                MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateAbrevTxt.Text = "";
                updateDescripcionTxt.Text = "";
                ListadoGruposComerciales.Refresh();
                panel1.Show();
                panel2.Hide();
                panel3.Hide();
            }
        }

        private void Btn_CancelarUpdate_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel1.Show();

        }

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            if (busquedaTxt.Text != "")
            {
                ListadoGruposComerciales.DataSource = groupComBL.SearchGroup(busquedaTxt.Text);
                ListadoGruposComerciales.Refresh();            
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel1.Hide();
            panel2.Show();
        }
    }
}
