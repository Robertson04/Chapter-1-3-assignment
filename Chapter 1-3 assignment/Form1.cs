﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_1_3_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            int age = Convert.ToInt32(nudage.Text);
            double height = Convert.ToDouble(txtheight.Text);
            lblgreatings.Text = ($"Hello {name} you have a estimated {82 - age} years until you reach average life expectancy and are {2.51 - height}m shorter than the tallest person");
        }
    }
}
