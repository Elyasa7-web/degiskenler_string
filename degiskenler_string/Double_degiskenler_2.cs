﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degiskenler_string
{
    public partial class Double_degiskenler_2 : Form
    {
        public Double_degiskenler_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1 = 60;
            s2 = 70;
            s3 = 79;
            ort = (s1 + s2 + s3) / 3;
            label1.Text = ort.ToString("0.00");
        }
    }
}
