using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_UYG4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = textBox1.Text;
                notlar[index] = int.Parse(textBox2.Text);
                index++;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (index < isimler.Length)
            {
                isimler[index] = textBox1.Text;
                notlar[index] = int.Parse(textBox2.Text);
                index++;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (index < isimler.Length)
                {
                    isimler[index] = textBox1.Text;
                    notlar[index] = int.Parse(textBox2.Text);
                    index++;
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i]>enyuksek)
                {
                    enyuksek = notlar[i];
                }
            }
            textBox2.Text = textBox2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            textBox5.Text = ortalama.ToString();
        }
    }
}