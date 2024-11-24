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
    public partial class Degiskenler_not_ort_hesaplama : Form
    {
        public Degiskenler_not_ort_hesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, toplam;
            sinav1 = 100;
            sinav2 = 85;
            sinav3 = 95;
            toplam = (sinav1 + sinav2 + sinav3) / 3;
            label1.Text = "Ortalama: " + toplam;
        }
    }
}
