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
    public partial class odev_4 : Form
    {
        public odev_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, toplama, cikarma, carpma;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            sayi3 = Convert.ToInt16(textBox3.Text);
            toplama = sayi1 + sayi2 + sayi3;
            cikarma = sayi1 - sayi2 - sayi3;
            carpma = sayi1 * sayi2 * sayi3;
            label4.Text = (" Toplama: " + toplama + "\n" + " Çıkarma: " + cikarma + "\n" + " Çarpma: " + carpma);
        }
    }
}
