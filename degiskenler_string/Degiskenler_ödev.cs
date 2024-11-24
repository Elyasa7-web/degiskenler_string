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
    public partial class Degiskenler_ödev : Form
    {
        public Degiskenler_ödev()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urun;
            int s1;
            double kdv;
            kdv = Convert.ToInt16(textBox3.Text);
            s1=Convert.ToInt16(textBox2.Text);
            urun = textBox1.Text;
            listBox1.Items.Add(urun + " " + s1 + " " + "KDV dahil: "+kdv);
        }
    }
}
