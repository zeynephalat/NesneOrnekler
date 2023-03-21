using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void kESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void kOPYALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yAPIŞTIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu dosyayı silmek istediğinize emin misiniz?", "dosya sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap==DialogResult.Yes)
            {
               Application.Exit ();
            }
        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text dosyası|*.txt|tüm dosyalar|*.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap==DialogResult.OK)
            {
                txtEditor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void aÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text dosyası|*.txt|tüm dosyalar|*.*";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.SaveFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
