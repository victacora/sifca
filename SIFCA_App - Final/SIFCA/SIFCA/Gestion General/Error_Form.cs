﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIFCA
{
    public partial class Error_Form : Form
    {
        public Error_Form(string error)
        {
            InitializeComponent();
            errorTxt.Text = error;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
