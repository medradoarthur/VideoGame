﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame
{
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void frmGenero_Activated(object sender, EventArgs e)
        {
            txtNomeGenero.Focus(); // Foco no texto
        }
    }
}
