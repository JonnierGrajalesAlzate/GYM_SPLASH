﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            frmPrincipal ppal = new frmPrincipal();
            ppal.Show();
            tmrTiempo.Enabled = false;
            this.Hide();
        
    }
    }
}
