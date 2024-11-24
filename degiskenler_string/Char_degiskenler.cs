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
    public partial class Char_degiskenler : Form
    {
        public Char_degiskenler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ders;
            ders = Convert.ToChar(textBox1.Text);
            label1.Text = ders.ToString();
        }
    }
}
