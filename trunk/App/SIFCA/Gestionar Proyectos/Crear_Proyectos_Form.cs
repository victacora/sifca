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
    public partial class Crear_Proyecto_Form : Form
    {
        private ProjectBL project;
        private InventoryTypeBL inventoryType;
        private SpeciesListBL speciesList;

        
        public Crear_Proyecto_Form()
        {
            InitializeComponent();
            project= new ProjectBL();
            inventoryType=new InventoryTypeBL();
            speciesList = new SpeciesListBL();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            ObjectCache cache = MemoryCache.Default;
            PROYECTO activateProject= (PROYECTO)cache.Get("principalProject");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Crear_Proyecto_Form_Load(object sender, EventArgs e)
        {
            this.tipoInvenCbx.DataSource = inventoryType.GetInventoryTypes();
            this.tipoInvenCbx.DisplayMember = "NOMBRETIPOINV";
            this.tipoInvenCbx.ValueMember = "NOMBRETIPOINV";
            this.tipoInvenCbx.Invalidate();
            this.listaEspCbx.DataSource = speciesList.GetSpeciesLists();
            this.listaEspCbx.DisplayMember = "NOMARCH";
            this.listaEspCbx.ValueMember = "NOMARCH";
            this.listaEspCbx.Invalidate();
        }
    }
}
