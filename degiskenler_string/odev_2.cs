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
    public partial class odev_2 : Form
    {
        public odev_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yaricap, alan, cevre;
            double pi;
            pi = 3.14;
            yaricap = Convert.ToInt16(textBox1.Text);
            cevre = Convert.ToInt16(2 * pi * yaricap);
            alan = Convert.ToInt16(pi * yaricap * yaricap);
            label3.Text = " Alan: " + alan + "\n" + " Çevre: " + cevre;
        }
    }
}
