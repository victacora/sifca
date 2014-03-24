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
using SIFCA.Helper;

namespace SIFCA.Gestion_Configuracion
{
    public partial class TStudent_Form : Form
    {
        private TSTUDENT Tst;
        private TStudentBL TstBl;

        public TStudent_Form()
        {
            InitializeComponent();
            TstBl = new TStudentBL(Program.ContextData);
            TStudentBSource.DataSource = TstBl.GetTStudents();
            Criterio_tSCB.SelectedIndex = 0;
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
            this.Width = pn_listado.Width;
            this.Height = pn_listado.Height;
            this.CenterToScreen();

        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            bool Error=false;
            decimal N = 0, VALOR = 0, ALPHA = 0;
            
            if (!decimal.TryParse(crearN_txt.Text.Replace('.', ','), out N) || crearN_txt.Text=="")
            {
                Error=true;
                eP_errors.SetError(crearN_txt, "Este campo es numérico y obligatorio");
            }
            if (!decimal.TryParse(crearValor_txt.Text.Replace('.', ','), out VALOR) || crearValor_txt.Text=="")
            {
                Error=true;
                eP_errors.SetError(crearValor_txt, "Este campo es numérico y obligatorio");
            }
            if (!decimal.TryParse(crearAlpha_txt.Text.Replace('.', ','), out ALPHA) || crearAlpha_txt.Text=="")
            {
                Error=true;
                eP_errors.SetError(crearAlpha_txt, "Este campo es numérico y obligatorio");
            }
            if (!Error)
            {
                eP_errors.Dispose();
                try
                {
                    Tst = Program.ContextData.TSTUDENT.Create();
                    Tst.N = N;
                    Tst.VALOR = VALOR;
                    Tst.ALPHA = ALPHA;
                    TstBl.InsertTStudent(Tst);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                string result = TstBl.SaveChanges();
                if (result == "")
                {
                    MessageBox.Show("Los datos fueron actualizados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Error_Form errorForm = new Error_Form(result);
                    errorForm.MdiParent = ParentForm;
                    errorForm.Show();
                }
                try
                {
                    TStudentBSource.DataSource = TstBl.GetTStudents();
                    ListadoTStudent.Refresh();
                    crearN_txt.Text = "";
                    pn_crear.Hide();
                    pn_listado.Show();
                    pn_editar.Hide();
                    this.Width = pn_listado.Width;
                    this.Height = pn_listado.Height;
                    this.CenterToScreen();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void ListadoDeEspecies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (ListadoTStudent.Columns[e.ColumnIndex].Name == "Editar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoTStudent.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                Tst= Program.ContextData.TSTUDENT.Create();

                Tst = TstBl.GetTStudent((Decimal)row.Cells[0].Value, (Decimal)row.Cells[1].Value);

                updateN_txt.Text =  Tst.N.ToString();
                updateValor_txt.Text = Tst.VALOR.ToString();
                updateAlpha_txt.Text = Tst.ALPHA.ToString();
                pn_listado.Hide();
                pn_crear.Hide();
                pn_editar.Show();
                this.Width = editarGbx.Width;
                this.Height = editarGbx.Height;
                this.CenterToScreen();
            }

            if (ListadoTStudent.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = ListadoTStudent.Rows[e.RowIndex];

                //
                // Se selecciona la celda del boton
                //

                Tst = Program.ContextData.TSTUDENT.Create();

                Tst = TstBl.GetTStudent((Decimal)row.Cells[0].Value, (Decimal)row.Cells[1].Value);

                DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Process message box resultados
                switch (result)
                {
                    case DialogResult.OK:
                        TstBl.DeleteTStudent((Decimal)Tst.ALPHA, (Decimal)Tst.N);
                        string resultD =TstBl.SaveChanges();
                        if (resultD == "")
                        {
                            MessageBox.Show("Se elimino correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Error_Form errorForm = new Error_Form(resultD);
                            errorForm.MdiParent = ParentForm;
                            errorForm.Show();
                        }
                        try
                        {
                            TStudentBSource.DataSource = TstBl.GetTStudents();
                            ListadoTStudent.Refresh();
                            pn_listado.Show();
                            pn_crear.Hide();
                            pn_editar.Hide();
                            break;
                        }
                        catch(Exception ex)
                        {
                            throw ex;
                        }
                        

                    case DialogResult.Cancel:
                        // User pressed Cancel button
                        // ...
                        break;
                }

            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (updateAlpha_txt.Text != "")
            {
                try
                {
                    Tst.N = decimal.Parse(updateN_txt.Text.Replace('.', ','));
                    Tst.ALPHA = decimal.Parse(updateAlpha_txt.Text.Replace('.', ','));
                    Tst.VALOR = decimal.Parse(updateValor_txt.Text.Replace('.', ','));
                
                }
                catch(Exception EX)
                {
                    throw EX;
                }
                TstBl.UpdateTStudent(Tst);
                string resultUpd = TstBl.SaveChanges();
                if (resultUpd == "")
                {
                    MessageBox.Show("Se realizo la modificación de manera correcta.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Error_Form errorForm = new Error_Form(resultUpd);
                    errorForm.MdiParent = ParentForm;
                    errorForm.Show();
                }
                
                updateAlpha_txt.Text = "";
                updateN_txt.Text = "";
                updateValor_txt.Text = "";
                try
                {
                    TStudentBSource.DataSource = TstBl.GetTStudents();
                    ListadoTStudent.Refresh();
                    pn_listado.Show();
                    pn_crear.Hide();
                    pn_editar.Hide();
                    this.Width = ListadoTStudent.Width;
                    this.Height = ListadoTStudent.Height;
                    this.CenterToScreen();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                
            }
            else
            {
                eP_errors.SetError(updateAlpha_txt, " Por favor ingrese una descripción");
            }
        }

        private void Btn_CancelarUpdate_Click(object sender, EventArgs e)
        {
            pn_listado.Show();
            pn_crear.Hide();
            pn_editar.Hide();
            this.Width = ListadoTStudent.Width;
            this.Height = ListadoTStudent.Height;
            this.CenterToScreen();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            pn_crear.Hide();
            pn_editar.Hide();
            pn_listado.Show();
            this.Width = ListadoTStudent.Width;
            this.Height = ListadoTStudent.Height;
            this.CenterToScreen();

        }

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal b = 0;
                if (busquedaTxt.Text != "" && decimal.TryParse(busquedaTxt.Text, out b))
                {
                    TStudentBSource.DataSource = TstBl.SearchTStudent(b, Criterio_tSCB.Text);
                    ListadoTStudent.Refresh();
                }
                else
                {
                    TStudentBSource.DataSource = TstBl.GetTStudents();
                    ListadoTStudent.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            pn_editar.Hide();
            pn_listado.Hide();
            pn_crear.Show();
            this.Width = crearGbx.Width;
            this.Height = crearGbx.Height;
            this.CenterToScreen();

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            ImporExportExcel loadTstudent = new ImporExportExcel();
            loadTstudent.loadTestStudent(pBarLoad);
        }
    }

 }