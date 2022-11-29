using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS66_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SAY = 1;
            int TOPLAM = 0; 
            while (SAY <= 20) 
            {
                TOPLAM = TOPLAM + SAY;
                listBox1.Items.Add(TOPLAM);
                SAY ++;
            }
        }
    }
}
