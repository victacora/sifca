using SIFCA_BLL;
using SIFCA_DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using System.Runtime.Caching;

namespace SIFCA.Helper
{
    class ImporExportExcel
    {
        SpeciesBL specieBl = new SpeciesBL(Program.ContextData);
        StratumBL stratumBl = new StratumBL(Program.ContextData);
        ProjectBL pyBl = new ProjectBL(Program.ContextData);
        FormBL formBl = new FormBL(Program.ContextData);
        USUARIO user = (USUARIO)Program.Cache.Get("user");

        PROYECTO newProject;
        ESPECIE specie;
        ESTRATO stratum;
        FORMULARIO form;
        ArrayList listStratumsAdded;

        excel.Application aplicacion;
        excel.Workbook libros_trabajo;
        excel.Worksheet hojas_trabajo;
        excel.Range exlRange;

        public void importarExcel(ToolStripProgressBar bar)
        {
            try
            {
                bar.Visible = true;
                if (this.loadFicherFile())
                {
                    stratum = new ESTRATO();
                    InventoryLineBL lineInvBl = new InventoryLineBL(Program.ContextData);
                    listStratumsAdded = new ArrayList();

                    if (this.loadProject(1))
                    {
                        this.loadSpecies(bar, 2);
                        this.loadInventoryData(bar, 4);

                        bar.Visible = false;
                        //cerramos el libro y la aplicacion
                        libros_trabajo.Close();
                        aplicacion.Quit();

                        Program.Cache.Add("project", newProject, new CacheItemPolicy());
                        ToolStrip menu = bar.GetCurrentParent();
                        Principal_Form parent = (Principal_Form)menu.Parent;
                        parent.EstatusLabel.Text = parent.EstatusLabel.Text + " - Proyecto Abierto: " + newProject.LUGAR;
                        parent.Text = parent.Text + " - Proyecto Abierto " + newProject.LUGAR;
                        parent.changueMenuProject();
                    }
                }
                bar.Visible = false;
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                ToolStrip menu = bar.GetCurrentParent();
                Principal_Form parent = (Principal_Form)menu.Parent;
                errorForm.MdiParent = (Form)parent;
                errorForm.Show();
                bar.Visible = true;
            }        
        }

        private bool loadProject(int p)
        {
            hojas_trabajo = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(p);
            exlRange = hojas_trabajo.UsedRange;
            for (int i = 2; i <= exlRange.Rows.Count; i++)
            {
                string lugar = "" + (exlRange.Cells[i, 1] as excel.Range).Value + "";
                string tamanioParcela = "" + (exlRange.Cells[i, 2] as excel.Range).Value + "";
                string tamanioSupTotal = "" + (exlRange.Cells[i, 3] as excel.Range).Value + "";
                string areaderegeneracion = "" + (exlRange.Cells[i, 4] as excel.Range).Value + "";
                string factorForma = "" + (exlRange.Cells[i, 5] as excel.Range).Value + "";
                string descripcion = "" + (exlRange.Cells[i, 7] as excel.Range).Value + "";
                string TipoDisenio = "" + (exlRange.Cells[i, 8] as excel.Range).Value + "";
                string Objetivo = "" + (exlRange.Cells[i, 9] as excel.Range).Value + "";
                string confianza = "" + (exlRange.Cells[i, 10] as excel.Range).Value + "";
                string tamanioMuestra = "" + (exlRange.Cells[i, 11] as excel.Range).Value + "";
                if (pyBl.GetProjectByPlace(lugar) == null)
                {
                    // area muestreada = multiplicar el numero de parcelas por el tamaño de la parcela
                    // intensidad de muestreo = dividir el area muestreada entre el tamaño total del area a muestrear
                    newProject = new PROYECTO();
                    newProject.NROPROY = Guid.NewGuid();
                    newProject.LUGAR = lugar;
                    decimal tam = 0, factor = 0, tamSupTotal = 0, conf = 0, tamMuestra = 0;
                    int areaReg = 0;
                    decimal.TryParse(tamanioParcela.Replace(".", ","), out tam);
                    newProject.TAMANO = tam;
                    decimal.TryParse(tamanioSupTotal.Replace(".", ","), out tamSupTotal);
                    newProject.SUPTOT = tamSupTotal;
                    int.TryParse(areaderegeneracion, out areaReg);
                    newProject.AREAFUSTALESPORPARCELA = areaReg;
                    decimal.TryParse(factorForma.Replace(".", ","), out factor);
                    newProject.FACTORDEFORMA = factor;
                    newProject.ETAPA = 0;
                    newProject.DESCRIPCION = descripcion;
                    decimal.TryParse(confianza.Replace(".", ","), out conf);
                    newProject.CONFIANZA = conf;
                    TypeSampleDesignBl desingType = new TypeSampleDesignBl(Program.ContextData);
                    ObjectiveInventoryBL objInvBl = new ObjectiveInventoryBL(Program.ContextData);
                    if (TipoDisenio.Equals("Estratificado")) newProject.NOMTIPODISEMUEST = "ES";
                    else if (TipoDisenio.Equals("Simple")) newProject.NOMTIPODISEMUEST = "SI";
                    if (Objetivo.Equals("Maderable")) newProject.NOMBRETIPOINV = "MD";
                    else if (Objetivo.Equals("No Maderable")) newProject.NOMBRETIPOINV = "NM";
                    decimal.TryParse(tamanioMuestra.Replace(".", ","), out tamMuestra);
                    newProject.NUMEROPARCELASAMUESTREAR = tamMuestra;
                    newProject.FECHA = DateTime.Now;
                    newProject.TIPOPROYECTO = "CR";
                    newProject.NROFORMULA = Guid.Parse("ED52569E-5CFD-454F-9F8B-9429A47C829F");
                    newProject.SUPMUE = 0;
                    newProject.INTMUE = 0;
                    newProject.LIMITINFDAP = 0.1m;
                    newProject.USUARIO = user;
                    newProject.NROUSUARIO = user.NROUSUARIO;
                    pyBl.InsertProject(newProject);
                    return true;
                }
                else
                {
                    DialogResult myResult = MessageBox.Show("El proyecto que quiere importar se encuentra en el sistema ¿Desea continuar con la importación de datos?", "Mensaje de confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        newProject = pyBl.GetProjectByPlace(lugar);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool loadSpecies(ToolStripProgressBar bar, int hoja)
        {
            try
            {
                bar.Visible = true;
                hojas_trabajo = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(hoja);
                exlRange = hojas_trabajo.UsedRange;
                if (bar != null)
                {
                    bar.Visible = true;
                    bar.Value = 0;
                    bar.Maximum = exlRange.Rows.Count - 1;
                }

                //Recorremos el archivo excel como si fuera una matriz
                //leemos las especies que se encuentran en la hoja

                for (int i = 2; i <= exlRange.Rows.Count; i++)
                {
                    string nomCom = "" + (exlRange.Cells[i, 1] as excel.Range).Value + "";
                    string nomCien = "" + (exlRange.Cells[i, 2] as excel.Range).Value + "";
                    string nomFam = "" + (exlRange.Cells[i, 3] as excel.Range).Value + "";
                    string numDiam = "" + (exlRange.Cells[i, 4] as excel.Range).Value + "";
                    string gruEco = "" + (exlRange.Cells[i, 5] as excel.Range).Value + "";
                    specie = new ESPECIE();
                    specie = specieBl.GetSpecieByComNameAndScienName(nomCom, nomCien);
                    if (specie == null)
                    {
                        specie = new ESPECIE();
                        specie.CODESP = Guid.NewGuid();
                        //specie.DIAMMINCORTE = decimal.Parse(numDiam.Replace('.', ','));
                        specie.FAMILIA = nomFam;
                        specie.GRUPOCOM = "SV";
                        specie.NOMCIENTIFICO = nomCien;
                        specie.NOMCOMUN = nomCom;
                        if (gruEco == "") specie.GRUPOECOLOGICO = "NT";
                        else
                        {
                            if (gruEco == "Tolerante" || gruEco == "tolerante" || gruEco == "TOLERANTE") specie.GRUPOECOLOGICO = "TL";
                            else if (gruEco == "No Tolerante" || gruEco == "no tolerante" || gruEco == "NO TOLERANTE" || gruEco == "NO tolerante") specie.GRUPOECOLOGICO = "NT";
                        }
                        specieBl.InsertSpecie(specie);
                        string result = specieBl.SaveChanges();
                        if (!result.Equals(""))
                        {
                            Error_Form errorForm = new Error_Form(result);
                            ToolStrip menu = bar.GetCurrentParent();
                            Principal_Form parent = (Principal_Form)menu.Parent;
                            errorForm.MdiParent = (Form)parent;
                            errorForm.Show();
                            return false;
                        }                        
                        if (bar != null) bar.Increment(1);
                    }
                    if (hoja == 2) newProject.ESPECIE.Add(specie);
                }
                if(hoja==1)     MessageBox.Show("Los datos se cargaron correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bar.Visible = false;
                return true;
            }
            catch (Exception ex)
            {
                Error_Form childForm = new Error_Form(ex.Message);
                childForm.Show();
                bar.Visible = false;
                return false;
            }
        }

        private void loadInventoryData(ToolStripProgressBar bar, int p)
        {
            bar.Visible = true;
            //recorremos el archivo para leer las lineas de inventario que estan en el libro
            hojas_trabajo = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(p);

            //Definimos el el rango de celdas que seran leidas
            exlRange = hojas_trabajo.UsedRange;

            int posStratum = 0, posNomCom = 0, posFam = 0, posNomCien = 0, posParcela = 0, posCodCal = 0, posNumArb = 0;
            //Recorremos el archivo excel como si fuera una matriz
            string sValor = "";
            posStratum = 1;
            posParcela = 2;
            posNumArb = 3;
            posNomCom = 4;
            posNomCien = 5;
            posFam = 6;
            posCodCal = 10;
            sValor = "" + (exlRange.Cells[3, posParcela] as excel.Range).Value + "";
            int NumParcela = int.Parse(sValor); // se obtiene el numero de la parcela inicial
            
            //fijar el valor maximo con el numero de registros a insertar en la barra de progreso
            bar.Value = 0;
            bar.Maximum = exlRange.Rows.Count - 2;
                        
            form = new FORMULARIO();
            FormBL FBl = new FormBL(Program.ContextData); //Creamos el BL del formulario
            InventoryLineBL lineInvBl = new InventoryLineBL(Program.ContextData);
            int numParcelas = 0; // operador que se utiliza para contabilizar cuantas parcelas tiene asociadas el proyecto

            for (int i = 3; i <= exlRange.Rows.Count; i++)
            {
                //obtenemos los datos correspodientes a linea de inventario y formulario
                string numPar = "" + (exlRange.Cells[i, posParcela] as excel.Range).Value + ""; //obtenemos el numero de la parcela
                string nomEst = "" + (exlRange.Cells[i, posStratum] as excel.Range).Value + ""; //obtenermos el nombre del estrato

                //stratum.DESCRIPESTRATO = "" + (exlRange.Cells[i, posStratum] as excel.Range).Value + ""; 
                stratum = new ESTRATO(); // creamos una instancia de estrato
                stratum = stratumBl.GetStratumByDescription(nomEst); // fijamos el estrato obtenido de la base de datos con el nomEst

                //sql1 = "INSERT INTO FORMULARIO ( NROFORMULARIO, NROUSUARIO, NROPROY, FECHACREACION, LINEA, CODEST, PARCELA) VALUES ( NEWID()," +user.NROUSUARIO+"," +project.NROPROY+"," +  +","+linea+",";
                //Validamos si estamos en el mismo bloque esto para si se cambio de bloque o proyecto guardarle a este el numero de parcelas, intensidad de muestreo
                // y superficie muestreada, al igual que abrir el siguiente proyecto con el valor del bloque                
                //stratum = Program.ContextData.ESTRATO.;
                if (stratum == null && nomEst != "" && nomEst != "Estrato simple")
                {
                    stratum = new ESTRATO();
                    stratum.CODEST = (stratumBl.GetStratums()).Count<ESTRATO>() + 1;
                    stratum.DESCRIPESTRATO = nomEst;
                    //stratumBl.InsertStratum(stratum);
                }

                if (NumParcela != int.Parse(numPar) || i == 3) // se valida si se ha cambiado de numero de parcela esto para crear un nuevo formulario o si se esta en la primera linea para crear el primer formulario
                {
                    numParcelas++;
                    NumParcela = int.Parse(numPar);
                    form = new FORMULARIO();
                    form.NROFORMULARIO = Guid.NewGuid();
                    form.NROUSUARIO = user.NROUSUARIO;
                    form.NROPROY = newProject.NROPROY;
                    form.FECHACREACION = DateTime.Now;
                    form.LINEA = NumParcela;
                    form.PARCELA = int.Parse(numPar);
                    if (stratum == null) form.CODEST = null;
                    else form.CODEST = stratum.CODEST;
                }
                else
                { // si esta en la misma parcela ahora hay que validar si el estrato esta en null para crearlo 
                    // se valida si se trata de un estrato diferente en la misma parcela entonces se crea un nuevo formulario con ese estrato
                    if (newProject.NOMTIPODISEMUEST == "ES")
                    {
                        if (form.CODEST != stratum.CODEST)
                        {
                            form = new FORMULARIO();
                            form.NROFORMULARIO = Guid.NewGuid();
                            form.NROUSUARIO = user.NROUSUARIO;
                            form.NROPROY = newProject.NROPROY;
                            form.FECHACREACION = DateTime.Now;
                            form.LINEA = NumParcela;
                            form.PARCELA = int.Parse(numPar);
                            if (stratum == null) form.CODEST = null;
                            else form.CODEST = stratum.CODEST;
                        }
                    }
                }
                newProject.FORMULARIO.Add(form);// asociammos el formulario a el proyecto

                if (newProject.NOMTIPODISEMUEST == "ES")
                {
                    //Se va asociar el estrato a la lista de estratos del proyecto, validando si este estrato ya se encuentra en la lista entonces no hace nada si no lo agregamos
                    if (existStratum(stratum, newProject) == -1)
                    {
                        LISTADODEESTRATOS lS = new LISTADODEESTRATOS();
                        lS.ESTRATO = stratum;
                        lS.CODEST = stratum.CODEST;
                        lS.NROPROY = newProject.NROPROY;
                        lS.PROYECTO = newProject;
                        lS.TAMANOMUESTRA = this.returnweight(stratum.DESCRIPESTRATO, 3); // se lee el excel para saber cual es el peso para ese estrato en ese proyecto
                        newProject.LISTADODEESTRATOS.Add(lS);
                        if (newProject.LISTADODEESTRATOS.Count > 1) // cambiamos el tipo de diseño si se tiene  en la lista de estratos 2 o mas 
                        {
                            newProject.NOMTIPODISEMUEST = "ES";
                        }
                        //pyBl.UpdateProject(project);
                    }
                }
                // se debe cargar el codigo de la especie por eso se leen los datos de nombre cientifico y comun

                string familia = "" + (exlRange.Cells[i, posFam] as excel.Range).Value + "";
                string nomCom = "" + (exlRange.Cells[i, posNomCom] as excel.Range).Value + "";
                string nomCien = "" + (exlRange.Cells[i, posNomCien] as excel.Range).Value + "";

                specie = new ESPECIE();
                //se busca la especie por nombre cientifico y nombre comun si no se encuentra una especie se crea con los valores
                specie = specieBl.GetSpecieByComNameAndScienName(nomCom, nomCien);
                if (specie == null)
                {
                    specie = new ESPECIE();
                    specie.CODESP = Guid.NewGuid();
                    //specie.DIAMMINCORTE = 0;
                    specie.FAMILIA = familia;
                    specie.GRUPOCOM = "SV";
                    specie.NOMCIENTIFICO = nomCien;
                    specie.NOMCOMUN = nomCom;
                    //specieBl.InsertSpecie(specie);
                }
                //Se verifica el listado de las especies asociadas a el proyecto si la especie ya esta en la list no se hace nada si no esta se agrega
                if (!newProject.ESPECIE.Contains(specie))
                {
                    newProject.ESPECIE.Add(specie);
                    //pyBl.UpdateProject(project);// se manda a actualizar el proyecto porque se modifico la lista de especies
                }
                //Se van a cargar los datos de la linea de inventario
                string numArb = "" + (exlRange.Cells[i, posNumArb] as excel.Range).Value + "";
                LINEAINVENTARIO lineInv = new LINEAINVENTARIO();
                lineInv.LINEAINV = Guid.NewGuid();
                lineInv.NROFORMULARIO = form.NROFORMULARIO;
                lineInv.CODESP = specie.CODESP;
                lineInv.ESTADO = "AS";

                int numArbol = -1;
                bool band = int.TryParse(numArb, out numArbol);
                if (int.TryParse(numArb, out numArbol))
                {
                    lineInv.NROARB = numArbol;
                    lineInv.TIPOARBOL = "NBF";
                }
                else
                {
                    int.TryParse(numArb.Remove(numArb.Length - 1), out numArbol);
                    lineInv.NROARB = numArbol;
                    lineInv.TIPOARBOL = "BFB";
                }
                int j = 7;
                decimal cap = 0, altCom = 0, altTot = 0;

                if (Decimal.TryParse(((exlRange.Cells[i, j] as excel.Range).Value + "").Replace(".", ","), out cap)) lineInv.CAP = cap;
                if (Decimal.TryParse(((exlRange.Cells[i, j + 1] as excel.Range).Value + "").Replace(".", ","), out altTot)) lineInv.ALTTOT_M = altTot;
                if (Decimal.TryParse(((exlRange.Cells[i, j + 2] as excel.Range).Value + "").Replace(".", ","), out altCom)) lineInv.ALTCOMER_M = altCom;
                QualityBL quality = new QualityBL(Program.ContextData);
                lineInv.CODCALIDAD = (quality.getQualityByDescription("Regular")).CODCALIDAD; // si no se especifica la calidad se la coloca por defecto en regular, 

                if (("" + (exlRange.Cells[i, j + 3] as excel.Range).Value + "").Equals("x")) lineInv.CODCALIDAD = (quality.getQualityByDescription("Bueno")).CODCALIDAD; //si la calidad es buena
                else
                    if (("" + (exlRange.Cells[i, j + 5] as excel.Range).Value + "").Equals("x")) lineInv.CODCALIDAD = (quality.getQualityByDescription("Malo")).CODCALIDAD;//si la calidad es mala


                if (("" + (exlRange.Cells[i, j + 6] as excel.Range).Value + "").Equals("x"))   //si la una linea maderable y el uso pertenece a alimenticia 
                {
                    LINEANOMADERABLES lineInvNM = new LINEANOMADERABLES();
                    NonTimberLineBL lineInvNMBl = new NonTimberLineBL(Program.ContextData);
                    TypeUseBL typeUseBl = new TypeUseBL(Program.ContextData);
                    lineInvNM.LINEANMAD = Guid.NewGuid();
                    lineInvNM.NROFORMULARIO = form.NROPROY;
                    lineInvNM.OBSERVACIONES = "" + (exlRange.Cells[i, j + 9] as excel.Range).Value + "";
                    form.LINEANOMADERABLES.Add(lineInvNM);
                    lineInvNM.TIPODEUSO.Add(typeUseBl.GetTypeUse("AL"));
                    form.LINEANOMADERABLES.Add(lineInvNM);
                    //lineInvNMBl.InsertNonTimberLine(lineInvNM);
                    //formBl.UpdateForm(form);
                }
                else
                {
                    if (("" + (exlRange.Cells[i, j + 7] as excel.Range).Value + "").Equals("x")) //si la una linea maderable y el uso pertenece a artesanal
                    {
                        LINEANOMADERABLES lineInvNM = new LINEANOMADERABLES();
                        NonTimberLineBL lineInvNMBl = new NonTimberLineBL(Program.ContextData);
                        TypeUseBL typeUseBl = new TypeUseBL(Program.ContextData);
                        lineInvNM.LINEANMAD = Guid.NewGuid();
                        lineInvNM.NROFORMULARIO = form.NROPROY;
                        lineInvNM.OBSERVACIONES = (exlRange.Cells[i, j + 9] as excel.Range).Value + "";
                        form.LINEANOMADERABLES.Add(lineInvNM);
                        lineInvNM.TIPODEUSO.Add(typeUseBl.GetTypeUse("AR"));
                        form.LINEANOMADERABLES.Add(lineInvNM);
                        //lineInvNMBl.InsertNonTimberLine(lineInvNM);
                        //formBl.UpdateForm(form);
                    }
                    else
                    {
                        if (("" + (exlRange.Cells[i, j + 8] as excel.Range).Value + "").Equals("x"))  //si la una linea maderable y el uso pertenece a medicinal
                        {
                            LINEANOMADERABLES lineInvNM = new LINEANOMADERABLES();
                            NonTimberLineBL lineInvNMBl = new NonTimberLineBL(Program.ContextData);
                            TypeUseBL typeUseBl = new TypeUseBL(Program.ContextData);
                            lineInvNM.LINEANMAD = Guid.NewGuid();
                            lineInvNM.NROFORMULARIO = form.NROPROY;
                            lineInvNM.OBSERVACIONES = (exlRange.Cells[i, j + 9] as excel.Range).Value + "";
                            form.LINEANOMADERABLES.Add(lineInvNM);
                            lineInvNM.TIPODEUSO.Add(typeUseBl.GetTypeUse("MD"));
                            form.LINEANOMADERABLES.Add(lineInvNM);
                            //lineInvNMBl.InsertNonTimberLine(lineInvNM);
                            //formBl.UpdateForm(form);
                        }
                    }
                }

                lineInv.DAP = lineInv.CAP / Convert.ToDecimal(Math.PI);
                lineInv.AREABASAL = (lineInv.DAP * lineInv.DAP) * (Convert.ToDecimal(Math.PI) / 4);
                lineInv.VOLTOT = (lineInv.ALTTOT_M * lineInv.AREABASAL * newProject.FACTORDEFORMA);
                lineInv.VOLCOM = (lineInv.ALTCOMER_M * lineInv.AREABASAL * newProject.FACTORDEFORMA);
                form.LINEAINVENTARIO.Add(lineInv);

                string result1 = lineInvBl.SaveChanges();
                if (!result1.Equals(""))
                {
                    Error_Form errorForm = new Error_Form(result1);
                    ToolStrip menu = bar.GetCurrentParent();
                    Principal_Form parent = (Principal_Form)menu.Parent;
                    errorForm.MdiParent = (Form)parent;
                    errorForm.Show();
                    return;
                }
                //lineInvBl.InsertInventoryLine(lineInv);
                //lineInvBl.SaveChanges();
                bar.Increment(1);
            }
            if (numParcelas > 0)
            {
                newProject.SUPMUE = numParcelas * newProject.TAMANO;
                newProject.INTMUE = (newProject.SUPMUE / newProject.SUPTOT) * 100;
                pyBl.UpdateProject(newProject);
                string result = pyBl.SaveChanges();
                if (!result.Equals(""))
                {
                    Error_Form errorForm = new Error_Form(result);
                    ToolStrip menu = bar.GetCurrentParent();
                    Principal_Form parent = (Principal_Form)menu.Parent;
                    errorForm.MdiParent = (Form)parent;
                    errorForm.Show();
                    return;
                }
                numParcelas = 0;
            }
            MessageBox.Show("Los datos se importaron correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bar.Visible = false;
        }

        public decimal returnweight(string nameStratum, int p)
        {
            excel.Worksheet hojas_trabajoAux;
            excel.Range exlRangeAux;

            hojas_trabajoAux = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(p);
            exlRangeAux = hojas_trabajo.UsedRange;
            //Recorremos el archivo excel como si fuera una matriz
            //leemos las especies que se encuentran en la hoja
            ProjectBL PyBL = new ProjectBL(Program.ContextData);
            StratumBL strBL = new StratumBL(Program.ContextData);
            string str = "";
            if (newProject != null)
            {
                for (int i = 2; i <= exlRange.Rows.Count; i++)
                {
                    str = (exlRange.Cells[i, 2] as excel.Range).Value + "";
                    if (str != "")
                    {
                        if (str.Equals(nameStratum))
                        {
                            string W = (exlRange.Cells[i, 2] as excel.Range).Value + "";
                            return decimal.Parse(W.Replace(".", ","));
                        }
                    }
                }
            }
            return 0;
        }

        public void exportarExcel(ToolStripProgressBar bar)
        {
            try
            {
                
                SaveFileDialog fichero = new SaveFileDialog();
                bar.Visible = true;
                ProjectBL pyBl = new ProjectBL(Program.ContextData);
                FormBL formBl = new FormBL(Program.ContextData);
                InventoryLineBL lineInvBl = new InventoryLineBL(Program.ContextData);
                bool data = false;
                PROYECTO project = (PROYECTO)Program.Cache.Get("project");
                if (project != null)
                {
                    try
                    {
                        fichero.Filter = "Excel (*.xls)|*.xls";
                        fichero.FileName = "proyecto  " + project.LUGAR + " " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
                        if (fichero.ShowDialog() == DialogResult.OK)
                        {
                            //hacer visible la barra de progreso y fijar el valor maximo con el numero de registros a exportar 
                            bar.Visible = true;

                            aplicacion = new excel.Application();
                            libros_trabajo = aplicacion.Workbooks.Add();

                            PROYECTO py = pyBl.GetProject(project.NROPROY);

                            excel.Worksheet hoja_regeneracion;
                            hoja_regeneracion = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                            hoja_regeneracion.Name = "Regeneracion";
                            hoja_regeneracion.Cells[1, 1] = "Lugar";
                            hoja_regeneracion.Cells[1, 2] = "Responsable";
                            hoja_regeneracion.Cells[1, 3] = "Coor X";
                            hoja_regeneracion.Cells[1, 4] = "Coor Y";
                            hoja_regeneracion.Cells[1, 5] = "Linea";
                            hoja_regeneracion.Cells[1, 6] = "Parcela";
                            hoja_regeneracion.Cells[1, 7] = "Estrato";
                            hoja_regeneracion.Cells[1, 8] = "Nombre Comun";
                            hoja_regeneracion.Cells[1, 9] = "Nombre Cientifico";
                            hoja_regeneracion.Cells[1, 10] = "Brinzal";
                            hoja_regeneracion.Cells[1, 11] = "Latizal";
                            hoja_regeneracion.get_Range("A1", "O1").Font.Bold = true;
                            hoja_regeneracion.get_Range("A1", "O1").VerticalAlignment =
                            excel.XlVAlign.xlVAlignCenter;
                            
                            int j = 2;
                            foreach (FORMULARIO form in py.FORMULARIO)
                            {
                                //de formulario extraer coord x y Y el estrato la linea numero de parcela y el usuario se puede hay que revisar muy bien esta parte
                                bar.Maximum = form.LINEAREGENERACION.Count;
                                bar.Value = 0;
                                hoja_regeneracion.Cells[j, 1] = py.LUGAR.ToString();
                                hoja_regeneracion.Cells[j, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;
                                hoja_regeneracion.Cells[j, 3] = form.COORDENADAX;
                                hoja_regeneracion.Cells[j, 4] = form.COORDENADAY;
                                hoja_regeneracion.Cells[j, 5] = form.LINEA.ToString();
                                hoja_regeneracion.Cells[j, 6] = form.PARCELA.ToString();

                                if(form.ESTRATO!=null) hoja_regeneracion.Cells[j, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                                foreach (LINEAREGENERACION lineInv in form.LINEAREGENERACION)
                                {
                                    hoja_regeneracion.Cells[j, 1] = py.LUGAR.ToString();
                                    hoja_regeneracion.Cells[j, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;
                                    hoja_regeneracion.Cells[j, 3] = form.COORDENADAX;
                                    hoja_regeneracion.Cells[j, 4] = form.COORDENADAY;
                                    hoja_regeneracion.Cells[j, 5] = form.LINEA.ToString();
                                    hoja_regeneracion.Cells[j, 6] = form.PARCELA.ToString();
                                    if (form.ESTRATO != null)   hoja_regeneracion.Cells[j, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                                    hoja_regeneracion.Cells[j, 8] = lineInv.ESPECIE.NOMCOMUN;
                                    hoja_regeneracion.Cells[j, 9] = lineInv.ESPECIE.NOMCIENTIFICO;
                                    hoja_regeneracion.Cells[j, 10] = lineInv.BRINZAL;
                                    hoja_regeneracion.Cells[j, 11] = lineInv.LATIZAL;
                                    bar.Increment(1);
                                    data = true;
                                    j++;
                                }
                                if (form.LINEAREGENERACION.Count == 0) j++;
                            }
                            if(data)libros_trabajo.Worksheets.Add(hoja_regeneracion);
                            data = false;
                            excel.Worksheet hoja_nomaderables;
                            hoja_nomaderables = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                            hoja_nomaderables.Name = "No maderable";
                            hoja_nomaderables.Cells[1, 1] = "Lugar";
                            hoja_nomaderables.Cells[1, 2] = "Responsable";
                            hoja_nomaderables.Cells[1, 3] = "Coor X";
                            hoja_nomaderables.Cells[1, 4] = "Coor Y";
                            hoja_nomaderables.Cells[1, 5] = "Linea";
                            hoja_nomaderables.Cells[1, 6] = "Parcela";
                            hoja_nomaderables.Cells[1, 7] = "Estrato";

                            hoja_nomaderables.Cells[1, 8] = "Observaciones";
                            TypeUseBL typeUseBl = new TypeUseBL(Program.ContextData);
                            int cont = 9;
                            foreach (TIPODEUSO type in typeUseBl.GetTypeUse())
                            {
                                hoja_nomaderables.Cells[1, cont] = type.DESCRIPCION.ToString();
                                cont++;
                            }

                            hoja_nomaderables.get_Range("A1", "O1").Font.Bold = true;
                            hoja_nomaderables.get_Range("A1", "O1").VerticalAlignment = excel.XlVAlign.xlVAlignCenter;

                            int k = 2;
                            
                            foreach (FORMULARIO form in py.FORMULARIO)
                            {
                                bar.Maximum = form.LINEANOMADERABLES.Count;
                                bar.Value = 0;

                                hoja_nomaderables.Cells[k, 1] = py.LUGAR.ToString();
                                hoja_nomaderables.Cells[k, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;
                                hoja_nomaderables.Cells[k, 3] = form.COORDENADAX;
                                hoja_nomaderables.Cells[k, 4] = form.COORDENADAY;
                                hoja_nomaderables.Cells[k, 5] = form.LINEA.ToString();
                                hoja_nomaderables.Cells[k, 6] = form.PARCELA.ToString();
                                if (form.ESTRATO != null)  hoja_nomaderables.Cells[k, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                                foreach (LINEANOMADERABLES lineInv in form.LINEANOMADERABLES)
                                {
                                    data = true;
                                    hoja_nomaderables.Cells[k, 1] = py.LUGAR.ToString();
                                    hoja_nomaderables.Cells[k, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;
                                    hoja_nomaderables.Cells[k, 3] = form.COORDENADAX;
                                    hoja_nomaderables.Cells[k, 4] = form.COORDENADAY;
                                    hoja_nomaderables.Cells[k, 5] = form.LINEA.ToString();
                                    hoja_nomaderables.Cells[k, 6] = form.PARCELA.ToString();
                                    if (form.ESTRATO != null)  hoja_nomaderables.Cells[k, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();
                                    hoja_nomaderables.Cells[k, 8] = lineInv.OBSERVACIONES.ToString();
                                    int n = 9;
                                    foreach (TIPODEUSO t in typeUseBl.GetTypeUse())
                                    {
                                        foreach (TIPODEUSO use in lineInv.TIPODEUSO)
                                        {
                                            if (use.NOMBRETIPOUSO.Equals(t.NOMBRETIPOUSO))
                                            {
                                                hoja_nomaderables.Cells[k, n] = "1";
                                                break;
                                            }
                                            else
                                            {
                                                hoja_nomaderables.Cells[k, n] = "0";
                                            }
                                        }
                                        n++;
                                    }
                                    bar.Increment(1);
                                    k++;
                                }
                                if (form.LINEANOMADERABLES.Count == 0) k++;

                            }
                            if(data)libros_trabajo.Worksheets.Add(hoja_nomaderables);
                            data = false;

                            excel.Worksheet hoja_maderable;
                            hoja_maderable = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                            QualityBL qualityBl = new QualityBL(Program.ContextData);

                            hoja_maderable.Name = "Maderable";
                            hoja_maderable.Cells[1, 1] = "Convenciones calidad";
                            hoja_maderable.Cells[2, 1] = "Código";
                            hoja_maderable.Cells[2, 2] = "Significado";

                            int i = 3;
                            foreach (CALIDAD quality in qualityBl.GetQualities())
                            {
                                hoja_maderable.Cells[i, 1] = quality.CODCALIDAD;
                                hoja_maderable.Cells[i, 2] = quality.DESCRIPCALIDAD;
                                i++;
                            }
                            i += 2;

                            hoja_maderable.Cells[i, 1] = "Lugar";
                            hoja_maderable.Cells[i, 2] = "Responsable";
                            hoja_maderable.Cells[i, 3] = "Coor X";
                            hoja_maderable.Cells[i, 4] = "Coor Y";
                            hoja_maderable.Cells[i, 5] = "Linea";
                            hoja_maderable.Cells[i, 6] = "Parcela";
                            hoja_maderable.Cells[i, 7] = "Estrato";

                            hoja_maderable.Cells[i, 8] = "Numero de arbol";
                            hoja_maderable.Cells[i, 9] = "Nombre comun";
                            hoja_maderable.Cells[i, 10] = "Nombre cientifico";
                            hoja_maderable.Cells[i, 11] = "Calidad";
                            hoja_maderable.Cells[i, 12] = "DAP";
                            hoja_maderable.Cells[i, 13] = "CAP";
                            hoja_maderable.Cells[i, 14] = "Altura comercial";
                            hoja_maderable.Cells[i, 15] = "Altura total";
                            hoja_maderable.Cells[i, 16] = "Area basal";
                            hoja_maderable.Cells[i, 17] = "Volumen comercial";
                            hoja_maderable.Cells[i, 18] = "Volumen total";

                            hoja_maderable.get_Range("A1", "O1").Font.Bold = true;
                            hoja_maderable.get_Range("A1", "O1").VerticalAlignment =
                                excel.XlVAlign.xlVAlignCenter;


                            i++;
                            foreach (FORMULARIO form in py.FORMULARIO)
                            {
                                bar.Maximum = form.LINEAINVENTARIO.Count;
                                bar.Value = 0;

                                hoja_maderable.Cells[i, 1] = py.LUGAR.ToString();
                                hoja_maderable.Cells[i, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;

                                hoja_maderable.Cells[i, 3] = form.COORDENADAX;
                                hoja_maderable.Cells[i, 4] = form.COORDENADAY;
                                hoja_maderable.Cells[i, 5] = form.LINEA.ToString();
                                hoja_maderable.Cells[i, 6] = form.PARCELA.ToString();
                                if (form.ESTRATO != null)  hoja_maderable.Cells[i, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                                foreach (LINEAINVENTARIO lineInv in form.LINEAINVENTARIO)
                                {
                                    data = true;
                                    hoja_maderable.Cells[i, 1] = py.LUGAR.ToString();
                                    hoja_maderable.Cells[i, 2] = form.USUARIO.NOMBRES + form.USUARIO.APELLIDOS;

                                    hoja_maderable.Cells[i, 3] = form.COORDENADAX.ToString();
                                    hoja_maderable.Cells[i, 4] = form.COORDENADAY.ToString();
                                    hoja_maderable.Cells[i, 5] = form.LINEA.ToString();
                                    hoja_maderable.Cells[i, 6] = form.PARCELA.ToString();
                                    if (form.ESTRATO != null)  hoja_maderable.Cells[i, 7] = form.ESTRATO.DESCRIPESTRATO.ToString();

                                    hoja_maderable.Cells[i, 8] = lineInv.NROARB.ToString();
                                    hoja_maderable.Cells[i, 9] = lineInv.ESPECIE.NOMCOMUN.ToString();
                                    hoja_maderable.Cells[i, 10] = lineInv.ESPECIE.NOMCIENTIFICO.ToString();
                                    hoja_maderable.Cells[i, 11] = lineInv.CALIDAD.CODCALIDAD.ToString();
                                    hoja_maderable.Cells[i, 12] = lineInv.DAP;
                                    hoja_maderable.Cells[i, 13] = lineInv.CAP;
                                    hoja_maderable.Cells[i, 14] = lineInv.ALTCOMER_M;
                                    hoja_maderable.Cells[i, 15] = lineInv.ALTTOT_M;
                                    hoja_maderable.Cells[i, 16] = lineInv.AREABASAL;
                                    hoja_maderable.Cells[i, 17] = lineInv.VOLCOM;
                                    hoja_maderable.Cells[i, 18] = lineInv.VOLTOT;
                                    i++;
                                    bar.Increment(1);
                                }
                                if (form.LINEAINVENTARIO.Count == 0) i++;

                            }
                            if(data)libros_trabajo.Worksheets.Add(hoja_maderable);
                            MessageBox.Show("Los datos se exportaron correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bar.Visible = false;
                            libros_trabajo.SaveAs(fichero.FileName,
                            excel.XlFileFormat.xlWorkbookNormal);
                            libros_trabajo.Close(true);
                            aplicacion.Quit();
                            System.Diagnostics.Process.Start(fichero.FileName);
                        }
                        bar.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        bar.Visible = false;
                        throw ex;
                    }
                }
                else MessageBox.Show("No existe un proyecto abierto dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                bar.Visible = false;
                Error_Form errorForm = new Error_Form(ex.Message);
                ToolStrip menu = bar.GetCurrentParent();
                Principal_Form parent = (Principal_Form)menu.Parent;
                errorForm.MdiParent = (Form)parent;
                errorForm.Show();
            }
        }

        public int existStratum(ESTRATO Str, PROYECTO Py)
        {
            int pos = 0;
            foreach (LISTADODEESTRATOS lis in Py.LISTADODEESTRATOS)
            {
                if (lis.CODEST == Str.CODEST) return pos;
                pos++;
            }
            return -1;         
        }

        public void loadTestStudent(ProgressBar bar)
        {
            try
            {
                bar.Visible = true;
                OpenFileDialog fichero = new OpenFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls;*.xlsx";
                bar.Visible = true;

                ProjectBL pyBl = new ProjectBL(Program.ContextData);
                FormBL formBl = new FormBL(Program.ContextData);
                InventoryLineBL lineInvBl = new InventoryLineBL(Program.ContextData);
                listStratumsAdded = new ArrayList();


                if (fichero.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {

                        excel.Application aplicacion;
                        excel.Workbook libros_trabajo;
                        excel.Worksheet hojas_trabajo;
                        excel.Range exlRange;
                        aplicacion = new excel.Application();

                        //Asignamos el libro que sera abierot
                        libros_trabajo = aplicacion.Workbooks.Open(fichero.FileName, 0, true, 5, "", "", true, excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                        hojas_trabajo = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                        exlRange = hojas_trabajo.UsedRange;
                        //Recorremos el archivo excel como si fuera una matriz
                        //leemos las especies que se encuentran en la hoja
                        TStudentBL tStudentBL = new TStudentBL(Program.ContextData);
                        bar.Maximum = exlRange.Rows.Count;
                        bar.Value = 0;
                        string n = "", alpha = "", valor = "";
                        for (int i = 2; i <= exlRange.Rows.Count; i++)
                        {
                            TSTUDENT tableTstudent = new TSTUDENT();
                            n = (exlRange.Cells[i, 1] as excel.Range).Value + "";
                            alpha = (exlRange.Cells[i, 2] as excel.Range).Value + "";
                            valor = (exlRange.Cells[i, 3] as excel.Range).Value + "";

                            tableTstudent.N = int.Parse(n);
                            tableTstudent.ALPHA = decimal.Parse(alpha);
                            tableTstudent.VALOR = decimal.Parse(valor);
                            tStudentBL.InsertTStudent(tableTstudent);
                            string result = tStudentBL.SaveChanges();
                            if (result != "")
                            {
                                if (!result.Equals(""))
                                {
                                    Error_Form errorForm = new Error_Form(result);
                                    errorForm.MdiParent = (Form)bar.Parent.Parent;
                                    errorForm.Show();
                                    return;
                                }
                            }
                            bar.Increment(1);
                        }
                        MessageBox.Show("Los datos se cargaron correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                bar.Visible = false;
            }
            catch (Exception ex)
            {
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.MdiParent = (Form)bar.Parent.Parent;
                errorForm.Show();
                bar.Visible = false;
            }
        }        

        public bool loadFicherFile()
        {
            try
            {

                OpenFileDialog fichero = new OpenFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls;*.xlsx";

                ProjectBL pyBl = new ProjectBL(Program.ContextData);
                FormBL formBl = new FormBL(Program.ContextData);
                InventoryLineBL lineInvBl = new InventoryLineBL(Program.ContextData);
                listStratumsAdded = new ArrayList();

                if (fichero.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    aplicacion = new excel.Application();

                    //Asignamos el libro que sera abierto y como es una operador global no es necesario ni retornarla ni nada
                    libros_trabajo = aplicacion.Workbooks.Open(fichero.FileName, 0, true, 5, "", "", true, excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Error_Form childForm = new Error_Form(ex.Message);
                childForm.Show();
                return false;
            }
        }

        public void exportarExcelDiametricClass(ProgressBar bar, DataGridView data, string Type, int numCLass)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                bar.Visible = true;
                ProjectBL pyBl = new ProjectBL(Program.ContextData);

                PROYECTO project = (PROYECTO)Program.Cache.Get("project");
                if (project != null)
                {
                    fichero.Filter = "Excel (*.xls)|*.xls";
                    fichero.FileName = "Reporte "+ Type+" clases diametricas "+ project.LUGAR + " "+ DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        //hacer visible la barra de progreso y fijar el valor maximo con el numero de registros a exportar 
                        bar.Visible = true;

                        aplicacion = new excel.Application();
                        libros_trabajo = aplicacion.Workbooks.Add();

                        excel.Worksheet hoja_reporte;
                        hoja_reporte = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                        hoja_reporte.Name = "Reporte Clases Diametricas";
                        hoja_reporte.Cells[1, 1] = "Informacion del proyecto";
                        hoja_reporte.Cells[1, 1].Font.Bold = true;
                        hoja_reporte.Range[hoja_reporte.Cells[1, 1], hoja_reporte.Cells[1, data.Columns.Count]].Merge();
                        
                        hoja_reporte.Cells[2, 1] = "Lugar";
                        hoja_reporte.Cells[2, 1].Font.Bold = true;
                        hoja_reporte.Cells[2, 2] = project.LUGAR.ToString();
                        hoja_reporte.Cells[2, 2].HorizontalAlignment =Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        hoja_reporte.Cells[2, 2].WrapText = true;

                        hoja_reporte.Cells[3, 1] = "Descripcion";
                        hoja_reporte.Cells[3, 1].Font.Bold = true;
                        hoja_reporte.Cells[3, 2] = project.DESCRIPCION.ToString();
                        hoja_reporte.Cells[3, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        hoja_reporte.Cells[3, 2].WrapText = true;

                        hoja_reporte.Cells[4, 1] = "Responsable";
                        hoja_reporte.Cells[4, 1].Font.Bold = true;
                        hoja_reporte.Cells[4, 2] = project.USUARIO.NOMBRES.ToString() + " " + project.USUARIO.APELLIDOS.ToString();
                        hoja_reporte.Cells[4, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        hoja_reporte.Cells[4, 2].WrapText = true;

                        hoja_reporte.Cells[5, 1] = "Reporte " + Type;
                        hoja_reporte.Cells[5, 1].Font.Bold = true;
                        hoja_reporte.Range[hoja_reporte.Cells[5, 1], hoja_reporte.Cells[5, data.Columns.Count]].Merge();                        

                        hoja_reporte.get_Range("A1", "O" + data.Columns.Count).HorizontalAlignment = excel.XlVAlign.xlVAlignCenter;
                        hoja_reporte.get_Range("A" + data.Rows.Count + 6, "O" + data.Columns.Count).HorizontalAlignment = excel.XlVAlign.xlVAlignCenter;
                        int col = 1;
                        foreach (DataGridViewColumn column in data.Columns)
                        {
                            hoja_reporte.Cells[6, col].NumberFormat = "@";
                            hoja_reporte.Cells[6, col] = column.HeaderText.ToString();
                            hoja_reporte.Cells[6, col].WrapText = true;
                            hoja_reporte.Cells[6, col].Font.Bold = true;
                            col++;
                        }
                        int i = 7;
                        
                        bar.Minimum = 0;
                        bar.Maximum = data.Rows.Count;
                        foreach (DataGridViewRow row in data.Rows)
                        {
                            //de formulario extraer coord x y Y el estrato la linea numero de parcela y el usuario se puede hay que revisar muy bien esta parte
                            int j = 1;
                            foreach (DataGridViewTextBoxCell cell in row.Cells)
                            {                                
                                hoja_reporte.Cells[i, j].WrapText = true;
                                hoja_reporte.Cells[i, j] = cell.Value.ToString();
                                if (j <= (data.Columns.Count - (numCLass + 3)))
                                {
                                    hoja_reporte.Cells[i, j].Font.Bold = true;
                                }
                                j++;
                            }
                            bar.Increment(1);
                            i++;
                        }

                        
                        libros_trabajo.Worksheets.Add(hoja_reporte);

                        MessageBox.Show("Los datos se exportaron correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bar.Visible = false;
                        libros_trabajo.SaveAs(fichero.FileName, excel.XlFileFormat.xlWorkbookNormal);
                        libros_trabajo.Close(true);
                        aplicacion.Quit();
                        System.Diagnostics.Process.Start(fichero.FileName);
                    }
                }
                else MessageBox.Show("No existe un proyecto abierto dentro del sistema.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar.Visible = false;
            }
            catch (Exception ex)
            {
                bar.Visible = false;
                Error_Form errorForm = new Error_Form(ex.Message);
                errorForm.Show();
            }
        }

        public void importarExcelFuncional(ToolStripProgressBar bar)
        {
            try
            {
                bar.Visible = true;
                OpenFileDialog fichero = new OpenFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls;*.xlsx";
                //ArrayList lstDatos = new ArrayList(); ;

                stratum = new ESTRATO();

                ProjectBL pyBl = new ProjectBL(Program.ContextData);
                FormBL formBl = new FormBL(Program.ContextData);
                InventoryLineBL lineInvBl = new InventoryLineBL(Program.ContextData);
                listStratumsAdded = new ArrayList();

                USUARIO user = (USUARIO)Program.Cache.Get("user");


                if (user != null)
                {
                    try
                    {
                        if (fichero.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            //PROYECTO project;
                            //PROYECTO py = pyBl.GetProject(project.NROPROY);
                            bar.Visible = true;
                            bar.Value = 0;

                            //declaramos las variables que necesitamos para poder abrir un archivo excel
                            excel.Application aplicacion;
                            excel.Workbook libros_trabajo;
                            excel.Worksheet hojas_trabajo;
                            excel.Range exlRange;

                            aplicacion = new excel.Application();


                            //Asignamos el libro que sera abierot
                            libros_trabajo = aplicacion.Workbooks.Open(fichero.FileName, 0, true, 5, "", "", true, excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                            hojas_trabajo = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(3);
                            exlRange = hojas_trabajo.UsedRange;
                            //Recorremos el archivo excel como si fuera una matriz
                            //leemos los proyectos que se encuentran en la hoja
                            bar.Maximum = exlRange.Rows.Count - 2;

                            for (int i = 2; i <= exlRange.Rows.Count; i++)
                            {

                                string lugar = "" + (exlRange.Cells[i, 1] as excel.Range).Value + "";
                                string tamanioParcela = "" + (exlRange.Cells[i, 2] as excel.Range).Value + "";
                                string tamanioSupTotal = "" + (exlRange.Cells[i, 3] as excel.Range).Value + "";
                                string areaderegeneracion = "" + (exlRange.Cells[i, 4] as excel.Range).Value + "";
                                string factorForma = "" + (exlRange.Cells[i, 5] as excel.Range).Value + "";
                                //string numeroEtapas = "" + (exlRange.Cells[i, 6] as excel.Range).Value + "";
                                string descripcion = "" + (exlRange.Cells[i, 7] as excel.Range).Value + "";
                                string TipoDisenio = "" + (exlRange.Cells[i, 8] as excel.Range).Value + "";
                                string Objetivo = "" + (exlRange.Cells[i, 9] as excel.Range).Value + "";
                                string confianza = "" + (exlRange.Cells[i, 10] as excel.Range).Value + "";
                                if (pyBl.GetProjectByPlace(lugar) == null)
                                {
                                    // area muestreada = multiplicar el numero de parcelas por el tamaño de la parcela
                                    // intensidad de muestreo = dividir el area muestreada entre el tamaño total del area a muestrear
                                    PROYECTO py = new PROYECTO();
                                    py.NROPROY = Guid.NewGuid();
                                    py.LUGAR = lugar;
                                    decimal tam = 0, factor = 0, tamSupTotal = 0, conf = 0;
                                    int areaReg = 0;
                                    decimal.TryParse(tamanioParcela.Replace(".", ","), out tam);
                                    py.TAMANO = tam;
                                    decimal.TryParse(tamanioSupTotal.Replace(".", ","), out tamSupTotal);
                                    py.SUPTOT = tamSupTotal;
                                    int.TryParse(areaderegeneracion, out areaReg);
                                    py.AREAFUSTALESPORPARCELA = areaReg;
                                    decimal.TryParse(factorForma.Replace(".", ","), out factor);
                                    py.FACTORDEFORMA = factor;
                                    py.ETAPA = 0;
                                    py.DESCRIPCION = descripcion;
                                    decimal.TryParse(confianza.Replace(".", ","), out conf);
                                    py.CONFIANZA = conf;
                                    TypeSampleDesignBl desingType = new TypeSampleDesignBl(Program.ContextData);
                                    ObjectiveInventoryBL objInvBl = new ObjectiveInventoryBL(Program.ContextData);
                                    if (TipoDisenio.Equals("Estratificado")) py.NOMTIPODISEMUEST = "ES";
                                    else if (TipoDisenio.Equals("Simple")) py.NOMTIPODISEMUEST = "SI";
                                    if (Objetivo.Equals("Maderable")) py.NOMBRETIPOINV = "MD";
                                    else if (Objetivo.Equals("No Maderable")) py.NOMBRETIPOINV = "NM";
                                    py.FECHA = DateTime.Now;
                                    py.TIPOPROYECTO = "CR";
                                    py.NROFORMULA = Guid.Parse("ED52569E-5CFD-454F-9F8B-9429A47C829F");
                                    py.SUPMUE = 0;
                                    py.INTMUE = 0;
                                    py.LIMITINFDAP = 10;
                                    py.USUARIO = user;
                                    py.NROUSUARIO = user.NROUSUARIO;
                                    pyBl.InsertProject(py);
                                    string result = pyBl.SaveChanges();

                                    if (!result.Equals(""))
                                    {
                                        Error_Form errorForm = new Error_Form(result);
                                        ToolStrip menu = bar.GetCurrentParent();
                                        Principal_Form parent = (Principal_Form)menu.Parent;
                                        errorForm.MdiParent = (Form)parent;
                                        errorForm.Show();
                                        return;
                                    }
                                    bar.Increment(1);
                                }


                            }

                            exlRange = hojas_trabajo.UsedRange;

                            this.loadSpecies(bar, 2);

                            //recorremos el archivo para leer las lineas de inventario que estan en el libro
                            hojas_trabajo = (excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                            //Definimos el el rango de celdas que seran leidas
                            exlRange = hojas_trabajo.UsedRange;

                            int posStratum = 0, posBloque = 0, posNomCom = 0, posFam = 0, posNomCien = 0, posParcela = 0, posCodCal = 0, posNumArb = 0;
                            //Recorremos el archivo excel como si fuera una matriz
                            string sValor = "";
                            posBloque = 1;
                            posStratum = 2;
                            posParcela = 3;
                            posNumArb = 4;
                            posNomCom = 5;
                            posNomCien = 6;
                            posFam = 7;
                            posCodCal = 11;
                            sValor = "" + (exlRange.Cells[3, posParcela] as excel.Range).Value + "";
                            int Numparcera = int.Parse(sValor); // se obtiene el numero de la parcela inicial

                            //fijar el valor maximo con el numero de registros a insertar en la barra de progreso
                            bar.Value = 0;
                            bar.Maximum = exlRange.Rows.Count - 3;

                            PROYECTO project = new PROYECTO();
                            form = new FORMULARIO();
                            string bloque = "" + (exlRange.Cells[3, posBloque] as excel.Range).Value + ""; // obtenemos el numero o nombre del bloque inicial
                            project = pyBl.GetProjectByPlace(bloque); // obtenermos el proyecto que tiene asociado ese bloque 
                            FormBL FBl = new FormBL(Program.ContextData); //Creamos el BL del formulario
                            int numParcelas = 0; // operador que se utiliza para contabilizar cuantas parcelas tiene asociadas el proyecto

                            for (int i = 3; i <= exlRange.Rows.Count; i++)
                            {
                                //obtenemos los datos correspodientes a linea de inventario y formulario
                                string numPar = "" + (exlRange.Cells[i, posParcela] as excel.Range).Value + ""; //obtenemos el numero de la parcela
                                string nomEst = "" + (exlRange.Cells[i, posStratum] as excel.Range).Value + ""; //obtenermos el nombre del estrato
                                string numBloque = "" + (exlRange.Cells[i, posBloque] as excel.Range).Value + ""; //obtenermos obtenemos el numero de bloque

                                //stratum.DESCRIPESTRATO = "" + (exlRange.Cells[i, posStratum] as excel.Range).Value + ""; 
                                stratum = new ESTRATO(); // creamos una instancia de estrato
                                stratum = stratumBl.GetStratumByDescription(nomEst); // fijamos el estrato obtenido de la base de datos con el nomEst

                                //sql1 = "INSERT INTO FORMULARIO ( NROFORMULARIO, NROUSUARIO, NROPROY, FECHACREACION, LINEA, CODEST, PARCELA) VALUES ( NEWID()," +user.NROUSUARIO+"," +project.NROPROY+"," +  +","+linea+",";
                                //Validamos si estamos en el mismo bloque esto para si se cambio de bloque o proyecto guardarle a este el numero de parcelas, intensidad de muestreo
                                // y superficie muestreada, al igual que abrir el siguiente proyecto con el valor del bloque
                                if (!bloque.Equals(numBloque))
                                {
                                    bloque = numBloque; // fijamos la operador bloque en el  bloque en el que se esta ahora
                                    project.SUPMUE = numParcelas * project.TAMANO;
                                    project.INTMUE = (project.SUPMUE / project.SUPTOT) * 100;
                                    pyBl.UpdateProject(project);
                                    string result = pyBl.SaveChanges();
                                    if (!result.Equals(""))
                                    {
                                        Error_Form errorForm = new Error_Form(result);
                                        ToolStrip menu = bar.GetCurrentParent();
                                        Principal_Form parent = (Principal_Form)menu.Parent;
                                        errorForm.MdiParent = (Form)parent;
                                        errorForm.Show();
                                        return;
                                    }
                                    numParcelas = 0;
                                    project = pyBl.GetProjectByPlace(bloque);
                                }
                                //stratum = Program.ContextData.ESTRATO.;
                                if (stratum == null && nomEst != "" && nomEst != "Estrato simple")
                                {
                                    stratum = new ESTRATO();
                                    stratum.CODEST = (stratumBl.GetStratums()).Count<ESTRATO>() + 1;
                                    stratum.DESCRIPESTRATO = nomEst;
                                    //stratumBl.InsertStratum(stratum);
                                }

                                if (Numparcera != int.Parse(numPar) || i == 3) // se valida si se ha cambiado de numero de parcela esto para crear un nuevo formulario o si se esta en la primera linea para crear el primer formulario
                                {
                                    numParcelas++;
                                    Numparcera = int.Parse(numPar);
                                    form = new FORMULARIO();
                                    form.NROFORMULARIO = Guid.NewGuid();
                                    form.NROUSUARIO = user.NROUSUARIO;
                                    form.NROPROY = project.NROPROY;
                                    form.FECHACREACION = DateTime.Now;
                                    form.LINEA = int.Parse(numBloque);
                                    form.PARCELA = int.Parse(numPar);
                                    if (stratum == null) form.CODEST = null;
                                    else form.CODEST = stratum.CODEST;
                                    //FBl.InsertForm(form);
                                }
                                else
                                { // si esta en la misma parcela ahora hay que validar si el estrato esta en null para crearlo 
                                    // se valida si se trata de un estrato diferente en la misma parcela entonces se crea un nuevo formulario con ese estrato
                                    if (project.NOMTIPODISEMUEST == "ES")
                                    {
                                        if (form.CODEST != stratum.CODEST)
                                        {
                                            form = new FORMULARIO();
                                            form.NROFORMULARIO = Guid.NewGuid();
                                            form.NROUSUARIO = user.NROUSUARIO;
                                            form.NROPROY = project.NROPROY;
                                            form.FECHACREACION = DateTime.Now;
                                            form.LINEA = int.Parse(numBloque);
                                            form.PARCELA = int.Parse(numPar);
                                            if (stratum == null) form.CODEST = null;
                                            else form.CODEST = stratum.CODEST;
                                            //FBl.InsertForm(form);
                                        }
                                    }
                                }

                                project.FORMULARIO.Add(form);// asociammos el formulario a el proyecto

                                if (project.NOMTIPODISEMUEST == "ES")
                                {
                                    //Se va asociar el estrato a la lista de estratos del proyecto, validando si este estrato ya se encuentra en la lista entonces no hace nada si no lo agregamos
                                    if (existStratum(stratum, project) == -1)
                                    {
                                        LISTADODEESTRATOS lS = new LISTADODEESTRATOS();
                                        lS.ESTRATO = stratum;
                                        lS.CODEST = stratum.CODEST;
                                        lS.NROPROY = project.NROPROY;
                                        lS.PROYECTO = project;
                                        lS.PESO = this.returnweight(stratum.DESCRIPESTRATO,3); // se lee el excel para saber cual es el peso para ese estrato en ese proyecto
                                        project.LISTADODEESTRATOS.Add(lS);
                                        if (project.LISTADODEESTRATOS.Count >= 2) // cambiamos el tipo de diseño si se tiene  en la lista de estratos 2 o mas 
                                        {
                                            project.NOMTIPODISEMUEST = "ES";
                                        }
                                        //pyBl.UpdateProject(project);
                                    }
                                }
                                // se debe cargar el codigo de la especie por eso se leen los datos de nombre cientifico y comun

                                string familia = "" + (exlRange.Cells[i, posFam] as excel.Range).Value + "";
                                string nomCom = "" + (exlRange.Cells[i, posNomCom] as excel.Range).Value + "";
                                string nomCien = "" + (exlRange.Cells[i, posNomCien] as excel.Range).Value + "";

                                specie = new ESPECIE();
                                //se busca la especie por nombre cientifico y nombre comun si no se encuentra una especie se crea con los valores
                                specie = specieBl.GetSpecieByComNameAndScienName(nomCom, nomCien);
                                if (specie == null)
                                {
                                    specie = new ESPECIE();
                                    specie.CODESP = Guid.NewGuid();
                                    //specie.DIAMMINCORTE = 0;
                                    specie.FAMILIA = familia;
                                    specie.GRUPOCOM = "SV";
                                    specie.NOMCIENTIFICO = nomCien;
                                    specie.NOMCOMUN = nomCom;
                                    //specieBl.InsertSpecie(specie);
                                }
                                //Se verifica el listado de las especies asociadas a el proyecto si la especie ya esta en la list no se hace nada si no esta se agrega
                                if (!project.ESPECIE.Contains(specie))
                                {
                                    project.ESPECIE.Add(specie);
                                    //pyBl.UpdateProject(project);// se manda a actualizar el proyecto porque se modifico la lista de especies
                                }
                                //Se van a cargar los datos de la linea de inventario
                                string numArb = "" + (exlRange.Cells[i, posNumArb] as excel.Range).Value + "";
                                LINEAINVENTARIO lineInv = new LINEAINVENTARIO();
                                lineInv.LINEAINV = Guid.NewGuid();
                                lineInv.NROFORMULARIO = form.NROFORMULARIO;
                                lineInv.CODESP = specie.CODESP;
                                lineInv.ESTADO = "AS";

                                int numArbol = -1;
                                bool band = int.TryParse(numArb, out numArbol);
                                if (int.TryParse(numArb, out numArbol))
                                {
                                    lineInv.NROARB = numArbol;
                                    lineInv.TIPOARBOL = "NBF";
                                }
                                else
                                {
                                    int.TryParse(numArb.Remove(numArb.Length - 1), out numArbol);
                                    lineInv.NROARB = numArbol;
                                    lineInv.TIPOARBOL = "BFB";
                                }
                                int j = 8;
                                decimal cap = 0, altCom = 0, altTot = 0;

                                if (Decimal.TryParse(((exlRange.Cells[i, j] as excel.Range).Value + "").Replace(".", ","), out cap)) lineInv.CAP = cap;
                                if (Decimal.TryParse(((exlRange.Cells[i, j + 1] as excel.Range).Value + "").Replace(".", ","), out altTot)) lineInv.ALTTOT_M = altTot;
                                if (Decimal.TryParse(((exlRange.Cells[i, j + 2] as excel.Range).Value + "").Replace(".", ","), out altCom)) lineInv.ALTCOMER_M = altCom;
                                QualityBL quality = new QualityBL(Program.ContextData);
                                lineInv.CODCALIDAD = (quality.getQualityByDescription("Regular")).CODCALIDAD; // si no se especifica la calidad se la coloca por defecto en regular, 

                                if (("" + (exlRange.Cells[i, j + 3] as excel.Range).Value + "").Equals("x")) lineInv.CODCALIDAD = (quality.getQualityByDescription("Bueno")).CODCALIDAD; //si la calidad es buena
                                else
                                    if (("" + (exlRange.Cells[i, j + 5] as excel.Range).Value + "").Equals("x")) lineInv.CODCALIDAD = (quality.getQualityByDescription("Malo")).CODCALIDAD;//si la calidad es mala


                                if (("" + (exlRange.Cells[i, j + 6] as excel.Range).Value + "").Equals("x"))   //si la una linea maderable y el uso pertenece a alimenticia 
                                {
                                    LINEANOMADERABLES lineInvNM = new LINEANOMADERABLES();
                                    NonTimberLineBL lineInvNMBl = new NonTimberLineBL(Program.ContextData);
                                    TypeUseBL typeUseBl = new TypeUseBL(Program.ContextData);
                                    lineInvNM.LINEANMAD = Guid.NewGuid();
                                    lineInvNM.NROFORMULARIO = form.NROPROY;
                                    lineInvNM.OBSERVACIONES = "" + (exlRange.Cells[i, j + 9] as excel.Range).Value + "";
                                    form.LINEANOMADERABLES.Add(lineInvNM);
                                    lineInvNM.TIPODEUSO.Add(typeUseBl.GetTypeUse("AL"));
                                    form.LINEANOMADERABLES.Add(lineInvNM);
                                    //lineInvNMBl.InsertNonTimberLine(lineInvNM);
                                    //formBl.UpdateForm(form);
                                }
                                else
                                {
                                    if (("" + (exlRange.Cells[i, j + 7] as excel.Range).Value + "").Equals("x")) //si la una linea maderable y el uso pertenece a artesanal
                                    {
                                        LINEANOMADERABLES lineInvNM = new LINEANOMADERABLES();
                                        NonTimberLineBL lineInvNMBl = new NonTimberLineBL(Program.ContextData);
                                        TypeUseBL typeUseBl = new TypeUseBL(Program.ContextData);
                                        lineInvNM.LINEANMAD = Guid.NewGuid();
                                        lineInvNM.NROFORMULARIO = form.NROPROY;
                                        lineInvNM.OBSERVACIONES = (exlRange.Cells[i, j + 9] as excel.Range).Value + "";
                                        form.LINEANOMADERABLES.Add(lineInvNM);
                                        lineInvNM.TIPODEUSO.Add(typeUseBl.GetTypeUse("AR"));
                                        form.LINEANOMADERABLES.Add(lineInvNM);
                                        //lineInvNMBl.InsertNonTimberLine(lineInvNM);
                                        //formBl.UpdateForm(form);
                                    }
                                    else
                                    {
                                        if (("" + (exlRange.Cells[i, j + 8] as excel.Range).Value + "").Equals("x"))  //si la una linea maderable y el uso pertenece a medicinal
                                        {
                                            LINEANOMADERABLES lineInvNM = new LINEANOMADERABLES();
                                            NonTimberLineBL lineInvNMBl = new NonTimberLineBL(Program.ContextData);
                                            TypeUseBL typeUseBl = new TypeUseBL(Program.ContextData);
                                            lineInvNM.LINEANMAD = Guid.NewGuid();
                                            lineInvNM.NROFORMULARIO = form.NROPROY;
                                            lineInvNM.OBSERVACIONES = (exlRange.Cells[i, j + 9] as excel.Range).Value + "";
                                            form.LINEANOMADERABLES.Add(lineInvNM);
                                            lineInvNM.TIPODEUSO.Add(typeUseBl.GetTypeUse("MD"));
                                            form.LINEANOMADERABLES.Add(lineInvNM);
                                            //lineInvNMBl.InsertNonTimberLine(lineInvNM);
                                            //formBl.UpdateForm(form);
                                        }
                                    }
                                }

                                lineInv.DAP = lineInv.CAP / Convert.ToDecimal(Math.PI);
                                lineInv.AREABASAL = (lineInv.DAP * lineInv.DAP) * (Convert.ToDecimal(Math.PI) / 4);
                                lineInv.VOLTOT = (lineInv.ALTTOT_M * lineInv.AREABASAL * project.FACTORDEFORMA);
                                lineInv.VOLCOM = (lineInv.ALTCOMER_M * lineInv.AREABASAL * project.FACTORDEFORMA);
                                form.LINEAINVENTARIO.Add(lineInv);

                                string result1 = lineInvBl.SaveChanges();
                                if (!result1.Equals(""))
                                {
                                    Error_Form errorForm = new Error_Form(result1);
                                    ToolStrip menu = bar.GetCurrentParent();
                                    Principal_Form parent = (Principal_Form)menu.Parent;
                                    errorForm.MdiParent = (Form)parent;
                                    errorForm.Show();
                                    return;
                                }
                                //lineInvBl.InsertInventoryLine(lineInv);
                                //lineInvBl.SaveChanges();
                                bar.Increment(1);

                                //sql = "INSERT INTO LINEAINVENTARIO ( LINEAINV, NROFORMULARIO, CODCALIDAD, ESTADO, CODESP, NROARB, ALTCOMER_M, ALTTOT_M, AREABASAL, VOLCOM, VOLTOT, CAP, DAP, TIPOARBOL) VALUES ( NEWID(), '";                     
                            }
                            if (numParcelas > 0)
                            {
                                project.SUPMUE = numParcelas * project.TAMANO;
                                project.INTMUE = (project.SUPMUE / project.SUPTOT) * 100;
                                pyBl.UpdateProject(project);
                                string result = pyBl.SaveChanges();
                                if (!result.Equals(""))
                                {
                                    Error_Form errorForm = new Error_Form(result);
                                    ToolStrip menu = bar.GetCurrentParent();
                                    Principal_Form parent = (Principal_Form)menu.Parent;
                                    errorForm.MdiParent = (Form)parent;
                                    errorForm.Show();
                                    return;
                                }
                                numParcelas = 0;
                            }
                            MessageBox.Show("Los datos se importaron correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bar.Visible = false;
                            //cerramos el libro y la aplicacion
                            libros_trabajo.Close();
                            aplicacion.Quit();
                        }
                        bar.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        bar.Visible = false;
                        Error_Form errorForm = new Error_Form(ex.Message);
                        ToolStrip menu = bar.GetCurrentParent();
                        Principal_Form parent = (Principal_Form)menu.Parent;
                        errorForm.MdiParent = (Form)parent;
                        errorForm.Show();
                    }

                }
                else MessageBox.Show("Ningun usuario ha iniciado sesion. Por favor inicie session.", "Operacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                bar.Visible = false;
                Error_Form errorForm = new Error_Form(ex.Message);
                ToolStrip menu = bar.GetCurrentParent();
                Principal_Form parent = (Principal_Form)menu.Parent;
                errorForm.MdiParent = (Form)parent;
                errorForm.Show();
            }
        }

    }   
}


