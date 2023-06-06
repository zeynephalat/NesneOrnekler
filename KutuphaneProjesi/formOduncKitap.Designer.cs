
namespace KutuphaneProjesi
{
    partial class formOduncKitap
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
            this.components = new System.ComponentModel.Container();
            this.GridOgrenci = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAramaOgrenci = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combosınıf = new System.Windows.Forms.ComboBox();
            this.txtÇıklama = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridOgrenci)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridOgrenci
            // 
            this.GridOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOgrenci.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridOgrenci.Location = new System.Drawing.Point(12, 208);
            this.GridOgrenci.Name = "GridOgrenci";
            this.GridOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOgrenci.Size = new System.Drawing.Size(630, 109);
            this.GridOgrenci.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAramaOgrenci);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odunç Kitap Arama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ogrenci Adi:";
            // 
            // txtAramaOgrenci
            // 
            this.txtAramaOgrenci.Location = new System.Drawing.Point(97, 28);
            this.txtAramaOgrenci.Name = "txtAramaOgrenci";
            this.txtAramaOgrenci.Size = new System.Drawing.Size(121, 20);
            this.txtAramaOgrenci.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapAl);
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btnKitapVer);
            this.groupBox3.Location = new System.Drawing.Point(266, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 81);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapAl.ImageIndex = 2;
            this.btnKitapAl.Location = new System.Drawing.Point(218, 28);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(115, 40);
            this.btnKitapAl.TabIndex = 2;
            this.btnKitapAl.Text = "KİTAP AL";
            this.btnKitapAl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapAl.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 1;
            this.btnSil.Location = new System.Drawing.Point(112, 28);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 40);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapVer.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnKitapVer.ImageIndex = 0;
            this.btnKitapVer.Location = new System.Drawing.Point(6, 28);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(100, 40);
            this.btnKitapVer.TabIndex = 0;
            this.btnKitapVer.Text = "KİTAP VER";
            this.btnKitapVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapVer.UseVisualStyleBackColor = true;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKitapVer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combosınıf);
            this.groupBox1.Controls.Add(this.txtÇıklama);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Girişi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Açıklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap adi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ogrenci No:";
            // 
            // combosınıf
            // 
            this.combosınıf.FormattingEnabled = true;
            this.combosınıf.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.combosınıf.Location = new System.Drawing.Point(73, 62);
            this.combosınıf.Name = "combosınıf";
            this.combosınıf.Size = new System.Drawing.Size(155, 21);
            this.combosınıf.TabIndex = 4;
            // 
            // txtÇıklama
            // 
            this.txtÇıklama.Location = new System.Drawing.Point(293, 33);
            this.txtÇıklama.Name = "txtÇıklama";
            this.txtÇıklama.Size = new System.Drawing.Size(121, 20);
            this.txtÇıklama.TabIndex = 1;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(76, 33);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(152, 20);
            this.txtNo.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // formOduncKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 382);
            this.Controls.Add(this.GridOgrenci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "formOduncKitap";
            this.Text = "formOduncKitap";
            ((System.ComponentModel.ISupportInitialize)(this.GridOgrenci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridOgrenci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAramaOgrenci;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combosınıf;
        private System.Windows.Forms.TextBox txtÇıklama;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.ImageList ımageList1;
    }
}