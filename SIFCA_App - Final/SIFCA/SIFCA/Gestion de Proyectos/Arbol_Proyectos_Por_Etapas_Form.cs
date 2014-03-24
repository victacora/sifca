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
    public partial class Arbol_Proyectos_Por_Etapas_Form : Form
    {
        private TypeSampleDesignBl typeExample;
        private ObjectiveInventoryBL objetiveInventory;

        public Arbol_Proyectos_Por_Etapas_Form(PROYECTO project)
        {
            InitializeComponent();
            typeExample = new TypeSampleDesignBl(Program.ContextData);
            objetiveInventory = new ObjectiveInventoryBL(Program.ContextData);
            tipoDisenoBS.DataSource = typeExample.GetTypeSampleDesignList();
            objetivoInventarioBS.DataSource = objetiveInventory.GetObjectiveInventories();

            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("IN", "Independiente"));
            data.Add(new KeyValuePair<string, string>("CR", "Contenedor"));
            TipoProyectoCbx.DataSource = data;
            TipoProyectoCbx.DisplayMember = "Value";
            TipoProyectoCbx.ValueMember = "Key";

            proyectoBS.DataSource = project;
            TipoProyectoCbx.SelectedValue = project.TIPOPROYECTO;

            proyectosVariasEtapasTvw.Nodes.Clear();   
            proyectosVariasEtapasTvw.BeginUpdate();  
            TreeNode node;
            node = proyectosVariasEtapasTvw.Nodes.Add(project.LUGAR);
            node.Tag = project; 
            LoadTree(node);
            proyectosVariasEtapasTvw.EndUpdate();    
            proyectosVariasEtapasTvw.Refresh();
            proyectosVariasEtapasTvw.ExpandAll();
        }

        private void LoadTree(TreeNode node)
        {
            PROYECTO project = (PROYECTO)node.Tag;  
            if (project.PROYECTOSPORETAPA.Count == 0) return;
            TreeNode node_ = null;
            foreach (PROYECTOSPORETAPA projStage in project.PROYECTOSPORETAPA)
            {
                node_ = node.Nodes.Add(projStage.PROYECTO1.LUGAR);
                node_.Tag = projStage.PROYECTO1;                         
                LoadTree(node_);
            }
        }

        private void proyectosVariasEtapasTvw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = proyectosVariasEtapasTvw.SelectedNode;
            if (node != null) 
            {
                if (node.Tag != null) 
                {
                    PROYECTO prj = (PROYECTO)node.Tag;
                    proyectoBS.DataSource = prj;
                    TipoProyectoCbx.SelectedValue = prj.TIPOPROYECTO;
                }
            }
        }
    }
}
