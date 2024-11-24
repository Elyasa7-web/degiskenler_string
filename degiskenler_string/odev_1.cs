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
    public partial class odev_1 : Form
    {
        public odev_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa, uzun, cevre, alan;
            kisa = Convert.ToInt16(textBox1.Text);
            uzun = Convert.ToInt16(textBox2.Text);
            cevre = 2 * (kisa + uzun);
            alan = kisa * uzun;
            label4.Text = " Alan: " + alan + " Çevre: " + cevre;
        }
    }
}
