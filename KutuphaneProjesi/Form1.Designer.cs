
namespace KutuphaneProjesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_kitap = new System.Windows.Forms.Button();
            this.btn_ogrenci = new System.Windows.Forms.Button();
            this.btn_tur = new System.Windows.Forms.Button();
            this.btn_odunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kitap
            // 
            this.btn_kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitap.Image")));
            this.btn_kitap.Location = new System.Drawing.Point(21, 12);
            this.btn_kitap.Name = "btn_kitap";
            this.btn_kitap.Size = new System.Drawing.Size(108, 108);
            this.btn_kitap.TabIndex = 0;
            this.btn_kitap.Text = "Kitap İşlemleri";
            this.btn_kitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kitap.UseVisualStyleBackColor = true;
            this.btn_kitap.Click += new System.EventHandler(this.btn_kitap_Click);
            // 
            // btn_ogrenci
            // 
            this.btn_ogrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenci.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogrenci.Image")));
            this.btn_ogrenci.Location = new System.Drawing.Point(168, 12);
            this.btn_ogrenci.Name = "btn_ogrenci";
            this.btn_ogrenci.Size = new System.Drawing.Size(108, 108);
            this.btn_ogrenci.TabIndex = 1;
            this.btn_ogrenci.Text = "Ogrenci İşlemleri";
            this.btn_ogrenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ogrenci.UseVisualStyleBackColor = true;
            this.btn_ogrenci.Click += new System.EventHandler(this.btn_ogrenci_Click);
            // 
            // btn_tur
            // 
            this.btn_tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tur.Image = ((System.Drawing.Image)(resources.GetObject("btn_tur.Image")));
            this.btn_tur.Location = new System.Drawing.Point(21, 126);
            this.btn_tur.Name = "btn_tur";
            this.btn_tur.Size = new System.Drawing.Size(108, 106);
            this.btn_tur.TabIndex = 2;
            this.btn_tur.Text = "Tür İşlemleri";
            this.btn_tur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tur.UseVisualStyleBackColor = true;
            this.btn_tur.Click += new System.EventHandler(this.btn_tur_Click);
            // 
            // btn_odunc
            // 
            this.btn_odunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_odunc.Image = ((System.Drawing.Image)(resources.GetObject("btn_odunc.Image")));
            this.btn_odunc.Location = new System.Drawing.Point(168, 126);
            this.btn_odunc.Name = "btn_odunc";
            this.btn_odunc.Size = new System.Drawing.Size(108, 106);
            this.btn_odunc.TabIndex = 3;
            this.btn_odunc.Text = "Ödünç Kitap İşlemleri";
            this.btn_odunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_odunc.UseVisualStyleBackColor = true;
            this.btn_odunc.Click += new System.EventHandler(this.btn_odunc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 244);
            this.Controls.Add(this.btn_odunc);
            this.Controls.Add(this.btn_tur);
            this.Controls.Add(this.btn_ogrenci);
            this.Controls.Add(this.btn_kitap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kitap;
        private System.Windows.Forms.Button btn_ogrenci;
        private System.Windows.Forms.Button btn_tur;
        private System.Windows.Forms.Button btn_odunc;
    }
}

