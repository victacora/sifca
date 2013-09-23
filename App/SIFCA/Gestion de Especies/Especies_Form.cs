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
    public partial class Especies_Form : Form
    {
        private ESPECIE specie;
        private SpeciesBL specieBL;
        private GroupBL group;


        public Especies_Form()
        {
            specie = new ESPECIE();
            specieBL = new SpeciesBL(Program.ContextData);
            group = new GroupBL(Program.ContextData);
            InitializeComponent();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            specieBSource.DataSource = specieBL.GetSpecies();
            grupoComercialBSource.DataSource = group.GetGroups();

        }

        private void Btn_nuevaEspecie_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Show();

            GroupComBSource.DataSource = group.GetGroups();
            
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            ESPECIE newSpecies = new ESPECIE();

            Decimal DAP = System.Convert.ToDecimal(this.txt_DMC.Text);

            newSpecies.DIAMMINCORTE = DAP;
            newSpecies.CODESP = Guid.NewGuid();
            newSpecies.GRUPOCOM = this.cbox_GrupoComercial.SelectedValue.ToString();
            newSpecies.NOMCOMUN = this.txt_NombreComun.Text;
            newSpecies.NOMCIENTIFICO = this.txt_NombreCientifico.Text;
            newSpecies.FAMILIA = this.txt_Familia.Text;
            newSpecies.ZONAGEOGRAFICA = this.txt_ZonaGeografica.Text;
            newSpecies.ZONADEVIDA = this.txt_ZonaVida.Text;

            specieBL.InsertSpecie(newSpecies);
            specieBL.SaveChanges();
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            specieBSource.DataSource = specieBL.GetSpecies();
            ListadoEspecies.Refresh();
            panel2.Hide();
            panel1.Show();
            panel3.Hide();

        }

        private void ListadoDeEspecies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                Guid codigo = (Guid) row.Cells[1].Value;

                specie = new ESPECIE();
                panel2.Hide();
                panel3.Show();
                specie = specieBL.GetSpecie(codigo);
                
                GroupComBSource.DataSource = group.GetGroups();
                cbxGrupoComercial.SelectedValue = specie.GRUPOCOM; 
                txt_NomComun.Text = specie.NOMCOMUN;
                txt_NomCientifico.Text = specie.NOMCIENTIFICO;
                txt_Fam.Text = specie.FAMILIA;
                txt_ZonaGeogra.Text = specie.ZONAGEOGRAFICA;
                txt_ZonaVid.Text = specie.ZONADEVIDA;
                txt_DimCor.Text = "" + specie.DIAMMINCORTE;
                                

            }
        }
        

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            
            specie.GRUPOCOM = (String)cbxGrupoComercial.SelectedValue;
            specie.NOMCOMUN = txt_NomComun.Text;
            specie.NOMCIENTIFICO = txt_NomCientifico.Text;
            specie.FAMILIA = txt_Fam.Text;
            specie.ZONAGEOGRAFICA = txt_ZonaGeogra.Text;
            specie.ZONADEVIDA = txt_ZonaVid.Text;
            specie.DIAMMINCORTE = Decimal.Parse(txt_DimCor.Text);
            specieBL.UpdateSpecies(specie);
            specieBL.SaveChanges();
            MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbx_GroupCom.SelectedValue = "";
            txt_NomCom.Text = "";
            txt_NomCient.Text = "";
            txt_Familia.Text = "";
            txt_ZonaGeo.Text = "";
            txt_ZonaVida.Text = "";
            txt_DimCorte.Text = "";
            ListadoEspecies.Refresh();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
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
                string criteria = criterioCbx.SelectedItem.ToString();
                if (criteria != "Grupo Comercial")
                {
                    ListadoEspecies.DataSource = specieBL.SearchSpecies(busquedaTxt.Text, criteria);
                    
                    ListadoEspecies.Refresh();
                }
                else
                {

                    if (busquedaTxt.Text != "sin valor")
                    {
                        ListadoEspecies.DataSource = specieBL.SearchSpecies("SV", criteria);

                        ListadoEspecies.Refresh();
                    }
                    if (busquedaTxt.Text != "valiosas")
                    {
                        ListadoEspecies.DataSource = specieBL.SearchSpecies("V", criteria);

                        ListadoEspecies.Refresh();
                    }
                    if (busquedaTxt.Text != "muy valiosas")
                    {
                        ListadoEspecies.DataSource = specieBL.SearchSpecies("MV", criteria);

                        ListadoEspecies.Refresh();
                    }
                }
            }
            else
            {
                ListadoEspecies.DataSource = specieBL.GetSpecies();

                ListadoEspecies.Refresh();
            }
        }

    }
}
