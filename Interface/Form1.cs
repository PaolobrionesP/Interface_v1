﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toggleButtonDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButtonDarkTheme.Checked)
            {
                this.BackColor = Color.;

            }
            else
            {
                this.BackColor = Color.WhiteSmoke;

            }
        }
    }
}
