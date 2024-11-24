using System;
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
    public partial class Double_degiskenler : Form
    {
        public Double_degiskenler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1;
            sayi1 = 4.25;
            label1.Text = sayi1.ToString();
        }
    }
}
