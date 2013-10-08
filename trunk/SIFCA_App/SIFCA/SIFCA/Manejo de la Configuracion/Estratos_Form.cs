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
            this.ListadoEstratos.DataSource = stratumListBSource;            
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();

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
            ListadoEstratos.Refresh();
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            pn_listado.Show();
            pn_editar.Hide();
            pn_crear.Hide();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();
        }

        private void ListadoDeEstratos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (ListadoEstratos.Columns[e.ColumnIndex].Name == "Editar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoEstratos.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //
                int codigo = Convert.ToInt32(row.Cells[0].Value);

                stratum = new ESTRATO();
                pn_listado.Hide();
                pn_crear.Hide();
                pn_editar.Show();
                stratum = stratumBl.GetStratum(codigo);
                txt_Descripcion.Text = stratum.DESCRIPESTRATO;
                this.Width = pn_editar.Width;
                this.Height = pn_editar.Height;
                this.CenterToScreen();

            }

            if (ListadoEstratos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoEstratos.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //
                int codigo = Convert.ToInt32(row.Cells[0].Value);
                
                DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Process message box results
                switch (result)
                {
                    case DialogResult.OK:
                        stratumBl.DeleteStratum(codigo);
                        stratumBl.SaveChanges();
                        stratumListBSource.DataSource = stratumBl.GetStratums();
                        ListadoEstratos.Refresh();
                        pn_listado.Show();
                        pn_crear.Hide();
                        pn_editar.Hide();
                        break;

                    case DialogResult.Cancel:
                        // User pressed Cancel button
                        // ...
                        break;
                }
                this.Width = pn_listado.Width;
                this.Height = pn_listado.Height;
                this.CenterToScreen();

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {            
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();
        }

        private void btn_cancelarUpdate_Click(object sender, EventArgs e)
        {
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();
        }

        private void btn_nuevoEstrato_Click(object sender, EventArgs e)
        {
            pn_editar.Hide();
            pn_listado.Hide();
            pn_crear.Show();
            this.Width = pn_crear.Width;
            this.Height = pn_crear.Height;
            this.CenterToScreen();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {            
            stratum.DESCRIPESTRATO = txt_Descripcion.Text;
            stratumBl.UpdateStratum(stratum);
            stratumBl.SaveChanges();
            MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Descripcion.Text = "";
            stratumListBSource.DataSource = stratumBl.GetStratums();
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();
        }

        
    }
}
