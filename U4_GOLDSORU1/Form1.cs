using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_GOLDSORU1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] ortalama = new int[30];
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ortalama.Length; i++)
            {
                listBox1.Items.Add(ortalama[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < ortalama.Length; i++)
            {
                ortalama [i] = random.Next(0, 101);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
            for (int i = 0; i < ortalama.Length; i++)
            {
                if (ortalama[i]<50)
                {
                    listBox1.Items.Add(ortalama[i]);
                }
            }
        }

        private void temizle()
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ortalama.Length; i++)
            {
                if (ortalama[i]>70 && ortalama [i]<100)
                {
                    listBox1.Items.Add(ortalama[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < ortalama.Length; i++)
            {
                toplam += ortalama[i];
            }
            label1.Text = (toplam / ortalama.Length).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int enYuksek = 0;
            for (int i = 0; i < ortalama.Length; i++)
            {
                if (ortalama[i] > enYuksek)
                {
                    enYuksek = ortalama[i];
                    label1.Text = enYuksek.ToString();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int endusuk = ortalama[0];
            for (int i = 0; i < ortalama.Length; i++)
            {
                if (ortalama[i]<endusuk)
                {
                    endusuk = ortalama[i];
                }
                label1.Text = endusuk.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int gecensayisi = 0;
            for (int i = 0; i < ortalama.Length; i++)
            {
                if (ortalama[i]>50)
                {
                    gecensayisi++;
                }
            }
            label1.Text = gecensayisi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int kalanOgrenci = 0;
            for (int i = 0; i < ortalama.Length; i++)
            {
                if (ortalama[i]<50)
                {
                    kalanOgrenci++;
                }
            }
            label1.Text = kalanOgrenci.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int gecensayisi = 0;
            int basari = 0;
            for (int i = 0; i <ortalama.Length; i++)
            {
                if (ortalama[i] > 50)
                {
                    gecensayisi++;
                    basari = (100 / 30) * gecensayisi;
                    label1.Text = basari.ToString();
                }
            }
        }
    }
}
