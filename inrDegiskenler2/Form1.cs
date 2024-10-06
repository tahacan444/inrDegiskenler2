using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inrDegiskenler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi,sonuc,sonuc2;
            //sayi = Convert.ToInt16(textBox1.Text);
            //label2.Text = sayi.ToString();

            int sayi3 = 100;
            sayi = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc = (int)Math.Pow(sayi,3);
            sonuc2 = (int)Math.Pow(sayi2, 3);
            label2.Text=sonuc.ToString();
            label3.Text = sonuc2.ToString();
        }
    }
}
