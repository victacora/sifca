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
            this.codigoTxt.Text=code.ToString();
            station = new StationBL();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            ESTACION newStation = new ESTACION();
            newStation.NROEST = code;
            newStation.NOMBRE = this.nombreTxt.Text;
            newStation.PERSONARESPONSABLE = this.responsableTxt.Text;
            station.InsertStation(newStation);
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
