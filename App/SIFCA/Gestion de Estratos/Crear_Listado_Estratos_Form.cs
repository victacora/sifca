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

namespace SIFCA.Gestion_de_Estratos
{
    public partial class Crear_Listado_Estratos_Form : Form
    {
        StratumBL stratumBl;
        List<ESTRATO> listEstratum;

        public Crear_Listado_Estratos_Form()
        {
            InitializeComponent();
            stratumBl = new StratumBL(Program.ContextData);
            this.StratumBSource.DataSource = stratumBl.GetStratums();
            this.listEstratum = new List<ESTRATO>();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Funcion para capturar los  click en la lista de check box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = DataGrid_Stratum.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    if ((Boolean)row.Cells[0].Value) row.Cells[0].Value = false;
                    else row.Cells[0].Value = true;
                }
                else row.Cells[0].Value = true;

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (DataGrid_Stratum.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = DataGrid_Stratum.Rows[e.RowIndex];

                //
                // Se selecciona la celda del checkbox
                //
                DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;

                //
                // Se valida si esta checkeada
                //+
                if (cellSelecion.Value != null)
                {
                    if (cellSelecion.Value != "")
                    {
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            //string mensaje = string.Format("Evento CellValueChanged.\n\nSe ha seccionado, \n codigo: '{0}', \n Nombre Comun: '{1}', \n Nombre Cientifico: '{2}'",
                            //                                    row.Cells["CODESP"].Value,
                            //                                    row.Cells["NOMCOMUN"].Value,
                            //                                    row.Cells["NOMCIENTIFICO"].Value);

                            //MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ESTRATO est = new ESTRATO();
                            est.CODEST = (Decimal)row.Cells["CODEST"].Value;
                            est.DESCRIPESTRATO = (String)row.Cells["DESCRIPESTRATO"].Value;
                            
                            listEstratum.Add(est);
                            

                        }
                        else
                        {
                            ESTRATO est = new ESTRATO();
                            est.CODEST = (Decimal)row.Cells["CODEST"].Value;
                            est.DESCRIPESTRATO = (String)row.Cells["DESCRIPESTRATO"].Value; 
                            listEstratum.Remove(est);
                        }
                    }
                }

            }
        }
        public void selectedAll(){
            foreach (DataGridViewRow row in DataGrid_Stratum.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        public void unselectedAll()
        {
            foreach (DataGridViewRow row in DataGrid_Stratum.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            this.selectedAll();
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            this.unselectedAll();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }


    }
}
