namespace Program
{
    partial class UrunDetay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lUrunMiktari = new System.Windows.Forms.Label();
            this.lUrunAdi = new System.Windows.Forms.Label();
            this.lUrunKodu = new System.Windows.Forms.Label();
            this.lUrunAciklamasi = new System.Windows.Forms.Label();
            this.bKapat = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Detay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lUrunAciklamasi);
            this.groupBox1.Controls.Add(this.lUrunKodu);
            this.groupBox1.Controls.Add(this.lUrunAdi);
            this.groupBox1.Controls.Add(this.lUrunMiktari);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kodu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Açıklama:";
            // 
            // lUrunMiktari
            // 
            this.lUrunMiktari.AutoSize = true;
            this.lUrunMiktari.Location = new System.Drawing.Point(104, 77);
            this.lUrunMiktari.Name = "lUrunMiktari";
            this.lUrunMiktari.Size = new System.Drawing.Size(46, 18);
            this.lUrunMiktari.TabIndex = 5;
            this.lUrunMiktari.Text = "label6";
            // 
            // lUrunAdi
            // 
            this.lUrunAdi.AutoSize = true;
            this.lUrunAdi.Location = new System.Drawing.Point(104, 48);
            this.lUrunAdi.Name = "lUrunAdi";
            this.lUrunAdi.Size = new System.Drawing.Size(46, 18);
            this.lUrunAdi.TabIndex = 6;
            this.lUrunAdi.Text = "label7";
            // 
            // lUrunKodu
            // 
            this.lUrunKodu.AutoSize = true;
            this.lUrunKodu.Location = new System.Drawing.Point(104, 19);
            this.lUrunKodu.Name = "lUrunKodu";
            this.lUrunKodu.Size = new System.Drawing.Size(46, 18);
            this.lUrunKodu.TabIndex = 8;
            this.lUrunKodu.Text = "label9";
            // 
            // lUrunAciklamasi
            // 
            this.lUrunAciklamasi.AutoSize = true;
            this.lUrunAciklamasi.Location = new System.Drawing.Point(104, 105);
            this.lUrunAciklamasi.Name = "lUrunAciklamasi";
            this.lUrunAciklamasi.Size = new System.Drawing.Size(54, 18);
            this.lUrunAciklamasi.TabIndex = 9;
            this.lUrunAciklamasi.Text = "label10";
            // 
            // bKapat
            // 
            this.bKapat.Location = new System.Drawing.Point(371, 248);
            this.bKapat.Name = "bKapat";
            this.bKapat.Size = new System.Drawing.Size(75, 31);
            this.bKapat.TabIndex = 3;
            this.bKapat.Text = "Kapat";
            this.bKapat.UseVisualStyleBackColor = true;
            this.bKapat.Click += new System.EventHandler(this.bKapat_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(290, 248);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(75, 31);
            this.bSil.TabIndex = 4;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // UrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 291);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bKapat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UrunDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunDetay";
            this.Load += new System.EventHandler(this.UrunDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lUrunAciklamasi;
        private System.Windows.Forms.Label lUrunKodu;
        private System.Windows.Forms.Label lUrunAdi;
        private System.Windows.Forms.Label lUrunMiktari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bKapat;
        private System.Windows.Forms.Button bSil;
    }
}