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
    public partial class odev_3 : Form
    {
        public odev_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3,bolme;
            sinav1 = Convert.ToInt16(textBox1.Text);
            sinav2 = Convert.ToInt16(textBox2.Text);
            sinav3 = Convert.ToInt16(textBox3.Text);
            bolme = (sinav1 + sinav2 + sinav3) / 3;
            label5.Text = bolme.ToString();
        }
    }
}
