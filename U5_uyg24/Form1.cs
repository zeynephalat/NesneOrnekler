﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_uyg24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenciler> liste = new List<Ogrenciler>();
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(textBox1.Text);
            ogrenci.AdSoyad = textBox2.Text;
            ogrenci.DersNotu = int.Parse(textBox3.Text);
            liste.Add(ogrenci);
            bagla();
        }

        private void bagla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = liste;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
