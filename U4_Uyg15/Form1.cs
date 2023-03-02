using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack yigin = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            yigin.Push(textBox1.Text);
            Listele();
        }

        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (var item in yigin)
            {
                listBox1.Items.Add(yigin);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yigin.Pop();
            Listele();
        }
    }
}
    