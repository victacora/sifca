using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIFCA_BLL;

namespace SIFCA.Gestion_de_GruposCom
{
    public partial class Ver_GruposCom_Form : Form
    {
        GroupBL group = new GroupBL(Program.ContextData);
        public Ver_GruposCom_Form()
        {
            InitializeComponent();
            GroupComBSource.DataSource = group.GetGroups();
        }
    }
}
