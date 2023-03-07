using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler;
        int[,] notlar;
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[index] = txtAdSoyad.Text;
            notlar[index, 0] = int.Parse(txtNot1.Text);
            notlar[index, 1] = int.Parse(txtNot2.Text);
            notlar[index, 2] = int.Parse(txtNot3.Text);
            notlar[index, 3] = int.Parse(txtNot4.Text);
            index++;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int ogrSayisi = int.Parse(txtOgrSayisi.Text);
            isimler = new string[ogrSayisi];
            notlar = new int[ogrSayisi, 4]; 
        }
    }
}
