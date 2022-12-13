using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Goldsoru33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtnot2.Text = "";
            txtnot3.Text = "";
            txtnot1.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtnot1.Text = "";
            txtnot2.Text = "";
            txtnot3.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtnot1.Text = "";
            txtnot2.Text = "";
            txtnot3.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtnot1.Text = "";
            txtnot2.Text = "";
            txtnot3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                
                progressBar1.ForeColor = Color.Red;
                progressBar1.ForeColor = Color.Green;
                progressBar1.ForeColor = Color.Purple;
                progressBar1.ForeColor = Color.Crimson;


                int not1, not2, not3, ortalama;
                not1 = Convert.ToInt16(txtnot1.Text);
                not2 = Convert.ToInt16(txtnot2.Text);
                not3 = Convert.ToInt16(txtnot3.Text);

                if (not1 > 100 || not1 < 0 || not2 > 100 ||not2 < 0 || not3 > 100 || not3 < 0)
                {
                    MessageBox.Show("geçerli bir not");
                }
                else
                {
                    ortalama = (not1 + not2 + not3);
                    label5.Text = ortalama.ToString();
                }
                not1 = Convert.ToInt16(txtnot1.Text);
              
                ortalama = (not1 + not2 + not3) / 3;
                label5.Text = ortalama.ToString();

                if (rbmat.Checked == true)
                {
                    progressBar1.Value = ortalama;
                    label1.Text = ("matematik");
                }
                else if (rbtur.Checked == true)
                {
                    progressBar2.Value = ortalama;
                    label1.Text = ("türkçe");
                }
                else if (rbnesne.Checked == true)
                {
                    progressBar3.Value = ortalama;
                    label1.Text = ("nesne tabanlı programlama");
                }
                else
                {
                    progressBar4.Value = ortalama;
                    label1.Text = ("robotik");
                }
            }
            catch
            {
                MessageBox.Show("sayı giriniz!!!");
            }
        }
        
     }


}
    