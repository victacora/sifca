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
using System.IO;
using SIFCA.Helper;

namespace SIFCA.Gestion_Configuracion
{
    public partial class Especies_Form : Form
    {
        private ESPECIE species;
        private SpeciesBL specieBL;
        private GroupBL group;
        private List<IMAGEN> listImagesDeleted;
        private List<IMAGEN> listImagesAdded;
        private IMAGEN image;
        private string state;
        private PROYECTO project;

        /// <summary>
        /// En esta funcion establecemos el estado desde el cual se hace la llamada a la funcion este estado es para manejar
        /// si se hace una llamada desde este mismo formulario o si es llamado desde el formulario de proyectos o de linea de invetario
        /// </summary>
        /// <param name="st">
        /// parametro que contiene la cadena con el nombre del formulario desde el que se hizo la llamada
        /// </param>
        public void setstate(string st){
            this.state = st;
        }

        /// <summary>
        /// Constructor para inicializar atributos y elementos del formulario
        /// </summary>
        public Especies_Form()
        {
            try
            {
                species = new ESPECIE();
                specieBL = new SpeciesBL(Program.ContextData);
                group = new GroupBL(Program.ContextData);
                InitializeComponent();
                pn_listado.Show();
                pn_crear.Hide();
                pn_editar.Hide();
                pn_detalle.Hide();
                pn_cargarImg.Hide();
                specieBSource.DataSource = specieBL.GetSpecies();
                grupoComercialBSource.DataSource = group.GetGroups();
                criterioCbx.SelectedIndex = 1;
                grupoEcoCbx.SelectedIndex = 0;
                state = "especie";
                //this.txt_DMC.Text="0,5";
                this.project = null;
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }            
        }

        /// <summary>
        /// Funcion que es llamada desde la opcion de nueva especie desde el mismo formulario especie form y en el se redimenciona 
        /// la ventana la el tamaño de crear especie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_nuevaEspecie_Click(object sender, EventArgs e)
        {
            try
            {
                pn_editar.Hide();
                pn_crear.Show();
                pn_listado.Hide();
                pn_detalle.Hide();
                pn_cargarImg.Hide();
                GroupComBSource.DataSource = group.GetGroups();
                this.Width = pn_crear.Width;
                this.Height = pn_crear.Height;
                this.CenterToScreen();
                this.state = "especie";
                this.image = null;
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
        }

        /// <summary>
        /// Funcion que es llamada desde un formulario externo para crear una especie sin la necesidad de entrar 
        /// directamente al formulario de especies se redimensiona la ventana y se fijan unos atributos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="py"></param>
        /// <param name="formCall"></param>
        public void Btn_nuevaEspecieForm_Click(object sender, EventArgs e, PROYECTO py, string formCall)
        {
            try
            {
                pn_editar.Hide();
                pn_crear.Show();
                pn_detalle.Hide();
                pn_listado.Hide();
                pn_cargarImg.Hide();
                btn_Cancelar.Visible = false;
                this.Width = pn_crear.Width;
                this.Height = pn_crear.Height;
                this.CenterToScreen();
                this.state = formCall;
                this.project = py; 
                this.image = null;
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            try
            {
                species = new ESPECIE();
                Decimal DIM = 0;
                bool band = true;
                eP_errors.BlinkRate = 0;

                if (this.txt_NombreComun.Text == "")
                {
                    eP_errors.SetError(txt_NombreComun, "El nombre comun es campo requerido");
                    band = false;
                }                
                if (this.txt_NombreCientifico.Text == "")
                {
                    eP_errors.SetError(txt_NombreCientifico, "El nombre cientifico es campo requerido");
                    band = false;
                }
                
                ESPECIE sp = specieBL.GetSpecieByComNameAndScienName(txt_NombreComun.Text, txt_NombreCientifico.Text);
                if (sp != null)
                {
                    eP_errors.SetError(txt_NombreComun, "La especie ya existe en la base de datos");
                    eP_errors.SetError(txt_NombreCientifico, "La especie ya existe en la base de datos");
                    band = false;
                }
                else
                {
                    species.NOMCIENTIFICO = txt_NombreCientifico.Text;
                    species.NOMCOMUN = txt_NombreComun.Text;
                }

                if (this.grupoEcoCbx.Text == "")
                {
                    eP_errors.SetError(grupoEcoCbx, "Se debe elegir un grupo ecológico");
                    band = false;
                }
                else
                {
                    if (this.grupoEcoCbx.Text == "Tolerante") species.GRUPOECOLOGICO = "TL";
                    if (this.grupoEcoCbx.Text == "No Tolerante") species.GRUPOECOLOGICO = "NT";
                    //eP_errors.Clear();
                }
                
                if (this.txt_Familia.Text == "")
                {
                    eP_errors.SetError(txt_Familia, "La familia es campo requerido");
                    band = false;
                }
                else
                {
                    species.FAMILIA = this.txt_Familia.Text;
                    //eP_errors.Clear();
                }
                                
                //if (this.txt_DMC.Text == "" || this.txt_DMC.Text == "0" || this.txt_DMC.Text == "0.0")
                //{
                //    eP_errors.SetError(txt_DMC, "El Diametro no es válido");
                //    band = false;
                //}
                //else
                //{
                //    bool canConvert = decimal.TryParse(this.txt_DMC.Text.Replace(".",","), out DIM);
                //    if (!canConvert)
                //    {
                //        band = false;
                //        eP_errors.SetError(txt_DMC, "El Diametro es incorrecto");
                //    }
                //    //else eP_errors.Clear();
                //}
                if (band)
                {
                    eP_errors.Clear();
                    species.DIAMMINCORTE = DIM;
                    species.CODESP = Guid.NewGuid();
                    GRUPOCOMERCIAL gp = group.GetGroup(this.cbox_GrupoComercial.SelectedValue.ToString());
                    if (gp != null) { 
                        species.GRUPOCOM = gp.GRUPOCOM;
                        species.GRUPOCOMERCIAL = gp;
                        gp.ESPECIE.Add(species);
                    }
                    else MessageBox.Show("No se ha especificado un grupo comercial, el campo es requerido.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    species.ZONAGEOGRAFICA = this.txt_ZonaGeografica.Text;
                    species.ZONADEVIDA = this.txt_ZonaVida.Text;

                    if (image != null)
                    {
                        ImageBL imgBl = new ImageBL(Program.ContextData);
                        image.CODESP = species.CODESP;
                        imgBl.InsertImage(image);
                        species.IMAGEN.Add(image);
                    }

                    specieBL.InsertSpecie(species);

                    if (this.state == "proyecto")
                    {
                        this.Close();
                        return;
                    }
                    string result = "";
                    
                    result= specieBL.SaveChanges();//se utiliza y si se tiene una imagen
                    if (result == "")
                    {
                        MessageBox.Show("Los datos fueron almacenados de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.state == "formulario" && this.project != null)
                        {
                            project.ESPECIE.Add(species);
                            this.Close();
                            return;
                        }
                            
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(result);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                        return;
                    }
                    
                    specieBSource.DataSource = specieBL.GetSpecies();
                    ListadoEspecies.Refresh();
                    
                    this.cbox_GrupoComercial.SelectedValue.ToString();
                    this.txt_NombreComun.Text = "";
                    this.txt_NombreCientifico.Text = "";
                    this.txt_Familia.Text = "";
                    this.txt_ZonaGeografica.Text = "Ninguna zona especificada";
                    this.txt_ZonaVida.Text = "Ninguna zona especificada";
                    this.imagenTxt.Text = "";
                    //this.txt_DMC.Text = "0,5";
                    pB_imgCrear.Image = null;
                    
                    pn_crear.Hide();
                    pn_listado.Show();
                    pn_editar.Hide();
                    pn_detalle.Hide();
                    pn_cargarImg.Hide();
                    this.Width = 910;
                    this.Height = 530;
                    this.CenterToScreen();
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }           
        }

        private void ListadoDeEspecies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ListadoEspecies.Columns[e.ColumnIndex].Name == "Detalle")
                {
                    //
                    // Se toma la fila seleccionada
                    //
                    DataGridViewRow row = ListadoEspecies.Rows[e.RowIndex];

                    //
                    // Se selecciona la celda del boton
                    //
                    Guid codigo = (Guid)row.Cells[1].Value;
                    this.state = "especie";
                    this.btn_detalle(sender,e,codigo);

                }


                if (ListadoEspecies.Columns[e.ColumnIndex].Name == "Editar")
                {
                    //
                    // Se toma la fila seleccionada
                    //
                    DataGridViewRow row = ListadoEspecies.Rows[e.RowIndex];
                
                    //
                    // Se selecciona la celda del boton
                    //
                    Guid codigo = (Guid) row.Cells[1].Value;

                    this.state = "especieEditar";
                    this.listImagesDeleted = new List<IMAGEN>();
                    this.listImagesAdded = new List<IMAGEN>();
                    this.btn_update(sender, e, codigo);                
                }

                if (ListadoEspecies.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    //
                    // Se toma la fila seleccionada
                    //
                    DataGridViewRow row = ListadoEspecies.Rows[e.RowIndex];

                    //
                    // Se selecciona la celda del boton
                    //

                    Guid codigo = (Guid)row.Cells[1].Value;

                    species = new ESPECIE();
                    species = specieBL.GetSpecie(codigo);
                    DialogResult result = MessageBox.Show("Esta seguro de eliminar el registro", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    // Process message box resultados
                    switch (result)
                    {
                        case DialogResult.OK:
                            specieBL.DeleteSpecies(species.CODESP);
                            string resultD =specieBL.SaveChanges();
                            if (resultD == "")
                            {
                                MessageBox.Show("Se elimino de manera exitosa.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Error_Form errorForm = new Error_Form(resultD);
                                errorForm.MdiParent = ParentForm;
                                errorForm.Show();
                            }
                            specieBSource.DataSource = specieBL.GetSpecies();
                            ListadoEspecies.Refresh();
                            pn_listado.Show();
                            pn_crear.Hide();
                            pn_editar.Hide();
                            pn_cargarImg.Hide();
                            pn_detalle.Hide();
                            break;

                        case DialogResult.Cancel:
                            // User pressed Cancel button
                            // ...
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }

            
        }

        private void btn_update(object sender, DataGridViewCellEventArgs e, Guid codigo)
        {
            try
            {
                species = new ESPECIE();
                pn_crear.Hide();
                pn_editar.Show();
                pn_detalle.Hide();
                pn_listado.Hide();
                pn_cargarImg.Hide();

                species = specieBL.GetSpecie(codigo);

                GroupComBSource.DataSource = group.GetGroups();
            
                grupoComercialCbx.SelectedValue = species.GRUPOCOM;
                if (species.GRUPOECOLOGICO == "TL")
                {
                    updGrupoEcoCbx.SelectedIndex = 0;
                }
                if (species.GRUPOECOLOGICO == "NT")
                {
                    updGrupoEcoCbx.SelectedIndex = 1;
                }
                txt_NomComun.Text = species.NOMCOMUN;
                txt_NomCientifico.Text = species.NOMCIENTIFICO;
                txt_Fam.Text = species.FAMILIA;
                txt_ZonaGeogra.Text = species.ZONAGEOGRAFICA;
                txt_ZonaVid.Text = species.ZONADEVIDA;
                //txt_DimCor.Text = "" + species.DIAMMINCORTE;

                this.imagenesBS.DataSource = species.IMAGEN.ToList();
                if (imagenesBS.Count == 0)
                {
                    string ruta = Application.StartupPath + "\\Resources\\ninguna_imagen.jpg";
                    Bitmap picture = new Bitmap(ruta);
                    pB_imgUpdate.Image = (Image)picture;
                    rutatxt.Text = "Ninguna ruta ha sido especificada";
                    nOMBRETextBox.Text = "Ningun nombre";
                    dESCRIPCIONTextBox.Text = "Ninguna descripcion";
                }           
                this.Width = pn_editar.Width;
                this.Height = pn_editar.Height;
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
        }        

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool band = true;
                if (this.txt_NomComun.Text == "")
                {
                    eP_errors.SetError(txt_NomComun, "El nombre común es campo requerido");
                    band = false;
                }
                
                if (this.txt_NomCientifico.Text == "")
                {
                    eP_errors.SetError(txt_NomCientifico, "El nombre cientifico es campo requerido");
                    band = false;
                }                

                species.GRUPOCOM = (String)grupoComercialCbx.SelectedValue;

                ESPECIE sp = specieBL.GetSpecieByComNameAndScienName(txt_NomComun.Text, txt_NomCientifico.Text);
                if (sp != null)
                {
                    eP_errors.SetError(txt_NomComun, "La especie ya existe en la base de datos");
                    eP_errors.SetError(txt_NomCientifico, "La especie ya existe en la base de datos");
                    band = false;
                }
                else
                {
                    species.NOMCIENTIFICO = txt_NombreCientifico.Text;
                    species.NOMCOMUN = txt_NombreComun.Text;
                }

                

                if (this.txt_Fam.Text == "")
                {
                    eP_errors.SetError(txt_Fam, "La familia es campo requerido");
                    band = false;
                }
                else species.FAMILIA = txt_Fam.Text;
                species.ZONAGEOGRAFICA = txt_ZonaGeogra.Text;
                species.ZONADEVIDA = txt_ZonaVid.Text;
                if (this.updGrupoEcoCbx.Text == "")
                {
                    eP_errors.SetError(updGrupoEcoCbx, "Se debe elegir un grupo ecológico");
                    band = false;
                }
                else
                {
                    if (this.updGrupoEcoCbx.Text == "Tolerante") species.GRUPOECOLOGICO = "TL";
                    if (this.updGrupoEcoCbx.Text == "No Tolerante") species.GRUPOECOLOGICO = "NT";                    
                }
                //if (this.txt_DimCor.Text == "" || this.txt_DimCor.Text == "0" || this.txt_DimCor.Text == "0.0")
                //{
                //    eP_errors.SetError(txt_DimCor, "El Diametro no es válido");
                //    band = false;
                //}
                //else
                //{
                //    //DAP = System.Convert.ToDecimal(this.txt_DMC.Text);
                
                //    decimal DIM;
                //    bool canConvert = decimal.TryParse(this.txt_DimCor.Text.Replace(".", ","), out DIM);
                //    if (!canConvert)
                //    {
                //        eP_errors.SetError(txt_DimCor, "El Diametro debe ser númerico");
                //        band = false;
                //    }
                //    else
                //    {
                //        eP_errors.Dispose();
                //        species.DIAMMINCORTE = DIM;
                //    }
                //}
                if (band)
                {
                    eP_errors.Clear();
                    foreach (IMAGEN img in listImagesDeleted)
                    {                    
                        species.IMAGEN.Remove(img);
                    }
                    foreach (IMAGEN img in listImagesAdded)
                    {
                        species.IMAGEN.Add(img);
                    }
                    specieBL.UpdateSpecies(species);
                    string resultUpd = specieBL.SaveChanges();
                    if (resultUpd == "")
                    {
                        MessageBox.Show("Se realizo la modificación de manera correcta", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Error_Form errorForm = new Error_Form(resultUpd);
                        errorForm.MdiParent = ParentForm;
                        errorForm.Show();
                    }
                    cbx_GroupCom.SelectedValue = "";
                    txt_NomCom.Text = "";
                    txt_NomCient.Text = "";
                    txt_Familia.Text = "";
                    txt_ZonaGeo.Text = "";
                    txt_ZonaVida.Text = "";
                    txt_DimCorte.Text = "";
                    specieBSource.DataSource = specieBL.GetSpecies();
                    ListadoEspecies.DataSource = specieBSource;
                    ListadoEspecies.Refresh();
                    pn_listado.Show();
                    pn_crear.Hide();
                    pn_detalle.Hide();
                    pn_editar.Hide();
                    pn_cargarImg.Hide();
                    this.Width = 910;
                    this.Height = 530;
                    this.CenterToScreen();

                    //pn_crear.Hide();
                    //pn_editar.Hide();
                    //pn_listado.Hide();
                    //pn_detalle.Show();
                    //pn_cargarImg.Hide();
                    //this.Width = pn_detalle.Width;
                    //this.Height = pn_detalle.Height;
                    //this.CenterToScreen();
                }
            }            
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
        }

        private void Btn_CancelarUpdate_Click(object sender, EventArgs e)
        {   
            try{                
                pn_listado.Show();
                pn_crear.Hide();
                pn_editar.Hide();
                pn_cargarImg.Hide();
                pn_detalle.Hide();
                this.Width = 910;
                this.Height = 530;
                this.CenterToScreen(); 
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }         
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try{
                
                pn_editar.Hide();
                pn_listado.Show();
                pn_cargarImg.Hide();
                pB_imgCrear.Image = null;
                imagenTxt.Text = "";
                pn_detalle.Hide();
                this.Width = 910;
                this.Height = 530;
                this.CenterToScreen();            
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            pn_crear.Hide();
        }

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
            try{
                if (busquedaTxt.Text != "")
                {
                    string criteria = criterioCbx.SelectedItem.ToString();                
                    ListadoEspecies.DataSource = specieBL.SearchSpecies(busquedaTxt.Text, criteria);                    
                    ListadoEspecies.Refresh();
                
                }
                else
                {
                    ListadoEspecies.DataSource = specieBL.GetSpecies();
                    ListadoEspecies.Refresh();
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
        }

        public void btn_detalle(object sender, EventArgs e, Guid codigo)
        {
            try{
                species =  new ESPECIE();
            
                this.Width = pn_detalle.Width;
                this.Height = pn_detalle.Height;
                this.CenterToScreen();
            
                species = specieBL.GetSpecie(codigo);

                GroupComBSource.DataSource = group.GetGroups();

                cbxGrupoComercial_det.SelectedValue = species.GRUPOCOM;

                imagenesBS.DataSource = species.IMAGEN.ToList();
                detailGrupoEcoTxt.Text = "";
                if (species.GRUPOECOLOGICO == "TL")
                {
                    detailGrupoEcoTxt.Text = "Tolerante";
                }
                else
                    if (species.GRUPOECOLOGICO == "NT")
                    {
                        detailGrupoEcoTxt.Text = "No Tolerante";
                    }

                if (imagenesBS.Count==0)
                {
                    string ruta = Application.StartupPath + "\\Resources\\ninguna_imagen.jpg";
                    Bitmap picture = new Bitmap(ruta);
                    pB_imgDetalle.Image = (Image)picture;
                    rutatxt.Text = "Ninguna ruta ha sido especificada";
                    nOMBRETextBox.Text = "Ningun nombre";
                    dESCRIPCIONTextBox.Text = "Ninguna descripcion";
                } 

                txt_NomComun_det.Text = species.NOMCOMUN;
                txt_NomCientifico_det.Text = species.NOMCIENTIFICO;
                txt_Fam_det.Text = species.FAMILIA;
                txt_ZonaGeogra_det.Text = species.ZONAGEOGRAFICA;
                txt_ZonaVid_det.Text = species.ZONADEVIDA;
                //txt_DimCor_det.Text = "" + species.DIAMMINCORTE;

                pn_crear.Hide();
                pn_editar.Hide();
                pn_listado.Hide();
                pn_detalle.Show();
                pn_cargarImg.Hide();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
           
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            try{
                if (this.state == "formulario") this.Close();
                else
                {
                    pn_crear.Hide();
                    pn_listado.Show();
                    pn_editar.Hide();
                    pn_detalle.Hide();
                    pn_cargarImg.Hide();
                    this.Width = 910;
                    this.Height = 530;
                    this.CenterToScreen();                     
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
        }

        private void btn_cargarImg_Click(object sender, EventArgs e)
        {
            try{
                imgFichero.Filter = ("Imagen |*.jpg|*.png|*.jpeg");
                if(imgFichero.ShowDialog() == DialogResult.OK)
                {
                    imagenTxt.Text = imgFichero.FileName;
                    Bitmap picture = new Bitmap(imagenTxt.Text);
                    pB_imgCrear.Image = (Image)picture;
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
        }

        private void btn_ImgAceptar_Click(object sender, EventArgs e)
        {
            try{
                bool band = true;
                image =new IMAGEN();
                if (imagenTxt.Text != "" && imagenTxt.Text != "Seleccione una imagen")
                {
                    string nombreCompletoArchivo = imgFichero.FileName;
                    string nombreCompletoConExtension = Path.GetFileName(nombreCompletoArchivo);
                    string ruta = Application.StartupPath + "\\imagenes\\" + txt_NombreCientifico.Text;
                    bool isExists = System.IO.Directory.Exists(ruta);
                    if (!isExists)
                    {
                        System.IO.Directory.CreateDirectory(ruta);
                    }
                    string destPath = Path.Combine(ruta, nombreCompletoConExtension);
                    File.Copy(nombreCompletoArchivo, destPath, true);

                    if (this.txt_nombreImg.Text == "")
                    {
                        eP_errors.SetError(txt_nombreImg, "El nombre de la imagen es campo requerido");
                        band = false;
                    }
                    else eP_errors.Dispose();
                    if (this.txt_descripcionImg.Text == "")
                    {
                        eP_errors.SetError(txt_descripcionImg, "La descripcion de la imagen es campo requerido");
                        band = false;
                    }
                    else eP_errors.Dispose();
                    if (band)
                    {
                        image.RUTA = destPath;
                        image.NOMBRE = txt_nombreImg.Text;
                        image.DESCRIPCION = txt_descripcionImg.Text;
                        image.CODESP = species.CODESP;
                        image.ESPECIE = species;
                        imagenTxt.Text = "";
                        txt_descripcionImg.Text = "";
                        txt_nombreImg.Text = "";
                        if (this.state.Equals("especieEditar"))
                        {
                            pn_editar.Show();
                            pn_crear.Hide();
                            pn_listado.Hide();
                            pn_detalle.Hide();
                            pn_cargarImg.Hide();
                            GroupComBSource.DataSource = group.GetGroups();
                            this.Width = pn_editar.Width;
                            this.Height = pn_editar.Height;
                            this.CenterToScreen();                        
                            List<IMAGEN> ListImg = (List<IMAGEN>)this.imagenesBS.List;
                            ListImg.Add(image);
                            listImagesAdded.Add(image);
                            //this.specieBL.UpdateSpecies(species);
                            //this.specieBL.SaveChanges();
                            this.imagenesBS.DataSource = ListImg;
                            this.imagenesBS.MoveLast();
                        }
                        else
                        {
                            pn_editar.Hide();
                            pn_crear.Show();
                            pn_listado.Hide();
                            pn_detalle.Hide();
                            pn_cargarImg.Hide();
                            GroupComBSource.DataSource = group.GetGroups();
                            this.Width = pn_crear.Width;
                            this.Height = pn_crear.Height;
                            this.CenterToScreen();
                        }                    
                    }
                }
                else
                {
                    eP_errors.SetError(imagenTxt, "Debe seleccionar una imagen");
                    band = false;
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            

        }

        private void btn_ImgCancelar_Click(object sender, EventArgs e)
        {
            try{
                if (this.state.Equals("especieEditar"))
                {
                    pn_listado.Hide();
                    pn_crear.Hide();
                    pn_editar.Show();
                    pn_cargarImg.Hide();
                    pn_detalle.Hide();
                    this.Width = pn_editar.Width;
                    this.Height = pn_editar.Height;
                    this.CenterToScreen();
                    imagenesBS.RemoveCurrent();
                }
                else
                {
                    pn_editar.Hide();
                    pn_crear.Show();
                    pn_listado.Hide();
                    pn_detalle.Hide();
                    pn_cargarImg.Hide();
                    GroupComBSource.DataSource = group.GetGroups();
                    this.Width = pn_crear.Width;
                    this.Height = pn_crear.Height;
                    this.CenterToScreen();
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
            
        }

        private void btn_crearImg_Click(object sender, EventArgs e)
        {
            try{
                pn_editar.Hide();
                pn_crear.Hide();
                pn_listado.Hide();
                pn_detalle.Hide();
            
                pn_cargarImg.Show();

                string ruta = Application.StartupPath + "\\Resources\\ninguna_imagen.jpg";
                Bitmap picture = new Bitmap(ruta);
            
                pB_imgCrear.Image = (Image)picture;
                GroupComBSource.DataSource = group.GetGroups();
                this.Width = pn_cargarImg.Width;
                this.Height = pn_cargarImg.Height;
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
        }

        private void rutatxt_TextChanged(object sender, EventArgs e)
        {
            try{
                if (rutatxt.Text != "" && rutatxt.Text != "Ninguna ruta ha sido especificada")
                {
                    Bitmap imagen = new Bitmap(rutatxt.Text);
                    pB_imgDetalle.Image = imagen;
                }
                else
                {
                    string ruta = Application.StartupPath + "\\Resources\\ninguna_imagen.jpg";
                    Bitmap picture = new Bitmap(ruta);
                    pB_imgCrear.Image = (Image)picture;
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
        }
        
        private void deleteImage_Click(object sender, EventArgs e)
        {
            try{
                listImagesDeleted.Add((IMAGEN)imagenesBS.Current);
                imagenesBS.RemoveCurrent();
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
        }

        private void rutaUpdtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (updImgUbic.Text != "" && updImgUbic.Text != "Ninguna ruta ha sido especificada")
                {
                    Bitmap imagen = new Bitmap(updImgUbic.Text);
                    pB_imgUpdate.Image = imagen;
                }
                else
                {
                    string ruta = Application.StartupPath + "\\Resources\\ninguna_imagen.jpg";
                    Bitmap picture = new Bitmap(ruta);
                    pB_imgUpdate.Image = (Image)picture;
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
            
        }

        private void validatedNumericValues(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }
        }

        private void ListadoEspecies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (ListadoEspecies.Columns[e.ColumnIndex].Name == "GRUPOECOLOGICO")
                {
                    if (e.Value.ToString() == "TL") e.Value = "Tolerante";
                    else e.Value = "No Tolerante";
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }

            
        }

        private void cargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                ImporExportExcel impSpecie = new ImporExportExcel();

                if (impSpecie.loadFicherFile())
                {
                    impSpecie.loadSpecies(null, 1);
                    specieBSource.DataSource = specieBL.GetSpecies();
                    ListadoEspecies.Refresh();
                }
            }
            catch (Exception ex)
            {
                Error_Form er = new Error_Form(ex.Message);
                er.Show();
            }

        }
    }
}
