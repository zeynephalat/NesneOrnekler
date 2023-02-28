using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[3];
        int[,] notlar = new int[3, 4];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            isimler[index] = textBox1.Text;
            notlar[index, 0] = int.Parse(textBox2.Text);
            notlar[index, 1] = int.Parse(textBox3.Text);
            notlar[index, 2] = int.Parse(textBox4.Text);
            notlar[index, 3] = int.Parse(textBox5.Text);
            index++;
        }
    }
}
