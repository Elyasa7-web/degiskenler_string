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
    public partial class Degiskenler_texte_girilen_sayinin_kupu : Form
    {
        public Degiskenler_texte_girilen_sayinin_kupu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt16(textBox1.Text);
            sonuc = sayi * sayi * sayi;
            label2.Text = sonuc.ToString();
        }
    }
}
