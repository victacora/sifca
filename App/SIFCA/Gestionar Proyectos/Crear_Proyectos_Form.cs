﻿using System;
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
            this.tipoInvenCbx.DataSource = inventoryType.GetInventoryTypes();
            this.tipoInvenCbx.DisplayMember = "NOMBRETIPOINV";
            this.tipoInvenCbx.ValueMember = "NOMBRETIPOINV";
            this.tipoInvenCbx.Invalidate();
            this.listaEspCbx.DataSource = speciesList.GetSpeciesLists();
            this.listaEspCbx.DisplayMember = "NOMARCH";
            this.listaEspCbx.ValueMember = "NOMARCH";
            this.listaEspCbx.Invalidate();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            PROYECTO newProject = new PROYECTO();
            //Deshabilitar el proyecto activo cambiado su estado
            PROYECTO activateProject = (PROYECTO)Program.cache.Get("principalProject");
            ESTACION stationData = (ESTACION)Program.cache.Get("localStation");            
            if (activateProject != null)
            {
                activateProject.ESTADOPROY = "I";
                project.UpdateProject(activateProject);
                project.SaveChanges();
            }
            newProject.LUGAR = lugarTxt.Text;
            newProject.NOMARCH = lugarTxt.Text;
            newProject.ESTADOPROY = "A";
            if (stationData != null)
            {
                newProject.NROEST = stationData.NROEST;
            }
            newProject.TAMANO = int.Parse(tamParcelaTxt.Text);
            newProject.LIMTINFDAP = int.Parse(limiteInfTxt.Text);
            newProject.LIMTSUPDAP = int.Parse(limiteSupTxt.Text);
            newProject.INTMUE =decimal.Parse(intMuestreoTxt.Text);
            newProject.SUPMUE =decimal.Parse(AreaMuestradaTxt.Text);
            newProject.TAMANO = decimal.Parse(tamParcelaTxt.Text);
            newProject.AREAFUSTALESPORPARCELA = decimal.Parse(areaFustalesTxt.Text);
            newProject.FACTORDEFORMA = decimal.Parse(factorFormaTxt.Text);
            project.InsertProject(newProject);
            project.SaveChanges();
            Program.cache.Set("principalProject", newProject, new CacheItemPolicy());
            MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
