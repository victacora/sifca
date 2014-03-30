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

namespace SIFCA
{
    public partial class Totales_Formularios_Form : Form
    {
        private List<SampleDesignItem> datos;
        private List<string> opciones=new List<string>();
        private int numeroParcelas = 0;
        private int numeroLineas = 0;

        public Totales_Formularios_Form(List<FORMULARIO> formularios, List<string> opciones)
        {
            InitializeComponent();
            try
            {
                datos = new List<SampleDesignItem>();
                this.opciones = opciones;
                tamanoParcelaTxt.Text = ((PROYECTO)Program.Cache.Get("project")).TAMANO.ToString();
                foreach (FORMULARIO frm in formularios)
                {
                    numeroParcelas++;
                    procesarDatosFormulario(frm);
                }
                numTotalLineasTxt.Text = numeroLineas.ToString();
                numTotalParcelasTxt.Text = numeroParcelas.ToString();
                promedioLineasTxt.Text = Math.Round((double)numeroLineas / numeroParcelas, 3).ToString();

                totalesBS.DataSource = datos;
                totalesDGW.Refresh();
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = ParentForm;
                errorForm.Show();
            }
        }

        private void verReporteBtn_Click(object sender, EventArgs e)
        {
            Ver_Reporte_Form childForm = new Ver_Reporte_Form(datos, opciones);
            childForm.MdiParent = ParentForm;
            childForm.Show();
            this.Close();
        }

        private void procesarDatosFormulario(FORMULARIO formulario)
        {
            PROYECTO currentProject = (PROYECTO)Program.Cache.Get("project");
            //Cargando datos del proyecto al reporte
            
            if (currentProject != null)
            {
                int totalArboles = 0;
                double volumenTotal = 0;
                double volumenComercial = 0;
                double areaBasal = 0;
                SampleDesignItem itemData = new SampleDesignItem();
                itemData.formulario = formulario;
                itemData.Parcela=formulario.PARCELA.ToString();
                itemData.Estrato = formulario.ESTRATO==null?"Diseño muestral simple.":formulario.ESTRATO.DESCRIPESTRATO;
                foreach (LINEAINVENTARIO linea in formulario.LINEAINVENTARIO)
                {
                    volumenComercial += (double)linea.VOLCOM;
                    volumenTotal += (double)linea.VOLTOT;
                    areaBasal += (double)linea.AREABASAL;
                    numeroLineas++;
                }
                totalArboles = formulario.LINEAINVENTARIO.GroupBy(l => l.NROARB).Count();
                //llevado a hectareas
                itemData.numeroArbolesHtas = totalArboles / (double)currentProject.TAMANO;
                itemData.volumenComercialHtas = volumenComercial / (double)currentProject.TAMANO;
                itemData.volumenTotalHtas = volumenTotal / (double)currentProject.TAMANO;
                itemData.areaBasalHtas = areaBasal / (double)currentProject.TAMANO;
                //llevado a parcelas
                itemData.numeroArbolesParcela = totalArboles;
                itemData.volumenComercialParcela = volumenComercial;
                itemData.volumenTotalParcela = volumenTotal;
                itemData.areaBasalParcela = areaBasal;
                datos.Add(itemData);
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
