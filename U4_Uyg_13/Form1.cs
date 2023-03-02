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

namespace U4_Uyg_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue kuyruk = new Queue();
        int sira = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            Lİstele();
        }

        private void Lİstele()
        {
            listBox1.Items.Clear();
            foreach (var sira in kuyruk)
            {
                listBox1.Items.Add(sira);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            Lİstele();
        }
    }
}
