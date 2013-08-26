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
using System.Runtime.Caching;

namespace SIFCA
{
    public partial class Crear_Estacion_Form : Form
    {
        private StationBL station;
        private Guid code;
        public Crear_Estacion_Form()
        {
            InitializeComponent();
            code = Guid.NewGuid();
            ESTACION stationData = (ESTACION)Program.Cache.Get("localStation");
            if (stationData == null)
            {
                this.codigoTxt.Text = code.ToString();
            }
            else
            {
                this.codigoTxt.Text = stationData.NROEST.ToString();
                this.nombreTxt.Text = stationData.NOMBRE;
                this.responsableTxt.Text = stationData.PERSONARESPONSABLE;
                this.AceptarBtn.Text = "Actualizar";
            }
            station = new StationBL(Program.ContextData);
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            ESTACION newStation = new ESTACION();
            ESTACION stationData = (ESTACION)Program.Cache.Get("localStation");
            newStation.NROEST = code;
            newStation.NOMBRE = this.nombreTxt.Text;
            newStation.PERSONARESPONSABLE = this.responsableTxt.Text;
            if (this.AceptarBtn.Text == "Aceptar")
            {
                station.InsertStation(newStation);
            }
            else
            {
                newStation.NROEST = stationData.NROEST;
                station.UpdateEstation(newStation);
            }
            station.SaveChanges();
            Program.Cache.Set("localStation", newStation, new CacheItemPolicy());
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
