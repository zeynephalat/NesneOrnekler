using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            decimal cpuFiyat = 0;
            if (radioButton1.Checked)
            {
                cpuFiyat = 300;
            }
            else if (radioButton2.Checked)
            {
                cpuFiyat = 200;
            }
            else if (radioButton3.Checked)
            {
                cpuFiyat = 100;
            }
            else if (radioButton4.Checked)
            {
                cpuFiyat = 250;
            }
            else if (radioButton5.Checked)
            {
                cpuFiyat = 150;
            }
            {
                tabanFiyat += cpuFiyat;
            }
            decimal ramFiyat = 0;
            if (radioButton6.Checked)
            {
                ramFiyat = 125;
            }
            else if (radioButton7.Checked)
            {
                ramFiyat = 75;
            }
            else if (radioButton8.Checked)
            {
                ramFiyat = 45;
            }

            tabanFiyat += ramFiyat;
            MessageBox.Show(string.Format("toplam fiyat = {0:c}", tabanFiyat));

            decimal sabitDiskFiyat = 0;
            if (radioButton9.Checked)
            {
                sabitDiskFiyat = 600;
            }
            else if (radioButton10.Checked)
            {
                sabitDiskFiyat = 450;
            }
            else if (radioButton11.Checked)
            {
                sabitDiskFiyat = 300;
            }
            tabanFiyat += sabitDiskFiyat;
            MessageBox.Show(string.Format("toplam fiyat={0:C}", tabanFiyat));

            decimal ekdonanimfiyat = 0;
            if (checkBox1.Checked)
            {
                ekdonanimfiyat = 1000;
            }
            else if (checkBox2.Checked)
            {
                ekdonanimfiyat = 500;
            }
            else
            {
                ekdonanimfiyat = 300;
            }
            tabanFiyat += ekdonanimfiyat;
            MessageBox.Show(string.Format("toplam fiyat={0:C}", tabanFiyat));
        }
    }
}
