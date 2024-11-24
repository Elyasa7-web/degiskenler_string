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
    public partial class Degiskenler_dikdortgen : Form
    {
        public Degiskenler_dikdortgen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa, uzun, alan, cevre;
            kisa = 10;
            uzun = 20;
            alan = kisa * uzun;
            cevre = 2 * (kisa + uzun);
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;
        }
    }
}
