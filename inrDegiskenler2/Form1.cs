﻿using System;
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
            int sayi,sonuc;
            //sayi = Convert.ToInt16(textBox1.Text);
            //label2.Text = sayi.ToString();


            sayi = Convert.ToInt16(textBox1.Text);
            sonuc = (int)Math.Pow(sayi,3);
            label2.Text=sonuc.ToString();
        }
    }
}
