﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
        int anahtar;
        string deger;

        private void button1_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox1.Text);
            deger = textBox2.Text;
            ogrenciler.Add(anahtar, deger);
            Listele();
        }

        private void Listele()
        {
           listBox1.Items.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                listBox1.Items.Add(ogrenci.Key +"-"+ogrenci.Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox2.Text);
            deger = textBox1.Text;
            ogrenciler[anahtar] = deger;
            Listele();
        }
    }
}
