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

namespace SIFCA.Gestion_Configuracion
{
    public partial class Estratos_Form : Form
    {
        private StratumBL stratumBl;
        ESTRATO stratum;

        public Estratos_Form()
        {
            InitializeComponent();
            stratum = new ESTRATO();
            stratumBl = new StratumBL(Program.ContextData);
            this.stratumListBSource.DataSource = stratumBl.GetStratums();
            this.ListadoEspecies.DataSource = stratumListBSource;            
            panel2.Hide();
            panel3.Hide();
            panel1.Show();

        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            ESTRATO newStratum = new ESTRATO();

            newStratum.DESCRIPESTRATO = this.txt_Nombre.Text;
            //newStratum.CODEST = Guid.NewGuid();

            stratumBl.InsertStratum(newStratum);
            stratumBl.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stratumListBSource.DataSource = stratumBl.GetStratums();
            panel1.Show();
            panel3.Hide();
            panel2.Hide();
        }

        private void ListadoDeEstratos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (ListadoEspecies.Columns[e.ColumnIndex].Name == "Acciones")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoEspecies.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //
                int codigo = Convert.ToInt32(row.Cells[1].Value);

                stratum = new ESTRATO();
                panel1.Hide();
                panel2.Hide();
                panel3.Show();
                stratum = stratumBl.GetStratum(codigo);
                txt_Descripcion.Text = stratum.DESCRIPESTRATO;

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {            
            panel2.Hide();
            panel3.Hide();
            panel1.Show();
        }

        private void btn_cancelarUpdate_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel1.Show();
        }

        private void btn_nuevoEstrato_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel1.Hide();
            panel2.Show();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {            
            stratum.DESCRIPESTRATO = txt_Descripcion.Text;
            stratumBl.UpdateStratum(stratum);
            MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Descripcion.Text = "";
            stratumListBSource.DataSource = stratumBl.GetStratums();
            panel2.Hide();
            panel3.Hide();
            panel1.Show();
        }

        
    }
}
