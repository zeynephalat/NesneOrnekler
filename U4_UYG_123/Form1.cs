using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_UYG_123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                isimler[index] = textBox1.Text.ToString();
                index++;
            }
            catch (Exception)
            {
                MessageBox.Show("sınırları aştınız lütfen 4 tane veri giriniz");
                
            }

        }
    }
}
