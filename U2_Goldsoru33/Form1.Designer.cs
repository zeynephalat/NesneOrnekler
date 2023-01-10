
namespace U2_Goldsoru33
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbrobotik = new System.Windows.Forms.RadioButton();
            this.rbnesne = new System.Windows.Forms.RadioButton();
            this.rbtur = new System.Windows.Forms.RadioButton();
            this.rbmat = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnot1 = new System.Windows.Forms.TextBox();
            this.txtnot3 = new System.Windows.Forms.TextBox();
            this.txtnot2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbrobotik);
            this.groupBox1.Controls.Add(this.rbnesne);
            this.groupBox1.Controls.Add(this.rbtur);
            this.groupBox1.Controls.Add(this.rbmat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbrobotik
            // 
            this.rbrobotik.AutoSize = true;
            this.rbrobotik.Location = new System.Drawing.Point(6, 113);
            this.rbrobotik.Name = "rbrobotik";
            this.rbrobotik.Size = new System.Drawing.Size(103, 17);
            this.rbrobotik.TabIndex = 3;
            this.rbrobotik.TabStop = true;
            this.rbrobotik.Text = "robotik kodlama:";
            this.rbrobotik.UseVisualStyleBackColor = true;
            this.rbrobotik.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbnesne
            // 
            this.rbnesne.AutoSize = true;
            this.rbnesne.Location = new System.Drawing.Point(6, 81);
            this.rbnesne.Name = "rbnesne";
            this.rbnesne.Size = new System.Drawing.Size(154, 17);
            this.rbnesne.TabIndex = 2;
            this.rbnesne.TabStop = true;
            this.rbnesne.Text = "nesne tabanlı programlama:";
            this.rbnesne.UseVisualStyleBackColor = true;
            this.rbnesne.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbtur
            // 
            this.rbtur.AutoSize = true;
            this.rbtur.Location = new System.Drawing.Point(6, 51);
            this.rbtur.Name = "rbtur";
            this.rbtur.Size = new System.Drawing.Size(58, 17);
            this.rbtur.TabIndex = 1;
            this.rbtur.TabStop = true;
            this.rbtur.Text = "türkçe:";
            this.rbtur.UseVisualStyleBackColor = true;
            this.rbtur.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbmat
            // 
            this.rbmat.AutoSize = true;
            this.rbmat.Location = new System.Drawing.Point(6, 19);
            this.rbmat.Name = "rbmat";
            this.rbmat.Size = new System.Drawing.Size(76, 17);
            this.rbmat.TabIndex = 0;
            this.rbmat.TabStop = true;
            this.rbmat.Text = "matematik:";
            this.rbmat.UseVisualStyleBackColor = true;
            this.rbmat.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnhesapla);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtnot1);
            this.groupBox2.Controls.Add(this.txtnot3);
            this.groupBox2.Controls.Add(this.txtnot2);
            this.groupBox2.Location = new System.Drawing.Point(231, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(0, 125);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(183, 23);
            this.btnhesapla.TabIndex = 8;
            this.btnhesapla.Text = "Ortalama hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ortalama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "yazılı3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "yazılı2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "yazılı1:";
            // 
            // txtnot1
            // 
            this.txtnot1.Location = new System.Drawing.Point(83, 26);
            this.txtnot1.Name = "txtnot1";
            this.txtnot1.Size = new System.Drawing.Size(100, 20);
            this.txtnot1.TabIndex = 2;
            // 
            // txtnot3
            // 
            this.txtnot3.Location = new System.Drawing.Point(83, 78);
            this.txtnot3.Name = "txtnot3";
            this.txtnot3.Size = new System.Drawing.Size(100, 20);
            this.txtnot3.TabIndex = 1;
            // 
            // txtnot2
            // 
            this.txtnot2.Location = new System.Drawing.Point(83, 52);
            this.txtnot2.Name = "txtnot2";
            this.txtnot2.Size = new System.Drawing.Size(100, 20);
            this.txtnot2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "mat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "turkce";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "nesne";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "rob";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(55, 265);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(359, 19);
            this.progressBar3.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(55, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 19);
            this.progressBar1.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(55, 209);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(359, 19);
            this.progressBar2.TabIndex = 10;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(55, 178);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(359, 19);
            this.progressBar4.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "ortalama";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(55, 295);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(359, 19);
            this.progressBar5.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(420, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "      ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Chartreuse;
            this.label12.Location = new System.Drawing.Point(420, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "      ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(420, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "      ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(420, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 326);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbrobotik;
        private System.Windows.Forms.RadioButton rbnesne;
        private System.Windows.Forms.RadioButton rbtur;
        private System.Windows.Forms.RadioButton rbmat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnot1;
        private System.Windows.Forms.TextBox txtnot3;
        private System.Windows.Forms.TextBox txtnot2;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

