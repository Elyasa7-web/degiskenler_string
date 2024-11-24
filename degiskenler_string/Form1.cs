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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string adsoyad, yas, meslek, cinsiyet;
            adsoyad = textBox1.Text;
            yas = maskedTextBox1.Text;
            meslek = textBox3.Text;
            cinsiyet = textBox4.Text;
            label5.Text = adsoyad;
            label6.Text = yas;
            label7.Text = meslek;
            label8.Text = cinsiyet;
            listBox1.Items.Add(textBox1.Text + " " + maskedTextBox1.Text + " " + textBox3.Text + " " + textBox4.Text);
        }
    }
}
