namespace Program
{
    partial class YeniMusteri
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
            this.lFormBaslik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBAdres = new System.Windows.Forms.TextBox();
            this.tBCepTelefonu = new System.Windows.Forms.TextBox();
            this.tBIsTelefonu = new System.Windows.Forms.TextBox();
            this.tBEvTelefonu = new System.Windows.Forms.TextBox();
            this.tBFirmaAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bSifirla = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.tBAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFormBaslik
            // 
            this.lFormBaslik.AutoSize = true;
            this.lFormBaslik.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lFormBaslik.Location = new System.Drawing.Point(13, 29);
            this.lFormBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFormBaslik.Name = "lFormBaslik";
            this.lFormBaslik.Size = new System.Drawing.Size(224, 40);
            this.lFormBaslik.TabIndex = 0;
            this.lFormBaslik.Text = "YENİ MÜŞTERİ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBAdres);
            this.groupBox1.Controls.Add(this.tBCepTelefonu);
            this.groupBox1.Controls.Add(this.tBIsTelefonu);
            this.groupBox1.Controls.Add(this.tBEvTelefonu);
            this.groupBox1.Controls.Add(this.tBFirmaAdi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bSifirla);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.tBAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(518, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tBAdres
            // 
            this.tBAdres.Location = new System.Drawing.Point(125, 165);
            this.tBAdres.Multiline = true;
            this.tBAdres.Name = "tBAdres";
            this.tBAdres.Size = new System.Drawing.Size(386, 117);
            this.tBAdres.TabIndex = 13;
            // 
            // tBCepTelefonu
            // 
            this.tBCepTelefonu.Location = new System.Drawing.Point(125, 136);
            this.tBCepTelefonu.Name = "tBCepTelefonu";
            this.tBCepTelefonu.Size = new System.Drawing.Size(115, 23);
            this.tBCepTelefonu.TabIndex = 12;
            // 
            // tBIsTelefonu
            // 
            this.tBIsTelefonu.Location = new System.Drawing.Point(125, 107);
            this.tBIsTelefonu.Name = "tBIsTelefonu";
            this.tBIsTelefonu.Size = new System.Drawing.Size(115, 23);
            this.tBIsTelefonu.TabIndex = 11;
            // 
            // tBEvTelefonu
            // 
            this.tBEvTelefonu.Location = new System.Drawing.Point(125, 78);
            this.tBEvTelefonu.Name = "tBEvTelefonu";
            this.tBEvTelefonu.Size = new System.Drawing.Size(115, 23);
            this.tBEvTelefonu.TabIndex = 10;
            // 
            // tBFirmaAdi
            // 
            this.tBFirmaAdi.Location = new System.Drawing.Point(125, 49);
            this.tBFirmaAdi.Name = "tBFirmaAdi";
            this.tBFirmaAdi.Size = new System.Drawing.Size(241, 23);
            this.tBFirmaAdi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cep Telefonu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "İş Telefonu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ev Telefonu:";
            // 
            // bSifirla
            // 
            this.bSifirla.Location = new System.Drawing.Point(266, 288);
            this.bSifirla.Name = "bSifirla";
            this.bSifirla.Size = new System.Drawing.Size(110, 27);
            this.bSifirla.TabIndex = 5;
            this.bSifirla.Text = "Formu Sıfırla";
            this.bSifirla.UseVisualStyleBackColor = true;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(125, 288);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(135, 27);
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // tBAdi
            // 
            this.tBAdi.Location = new System.Drawing.Point(125, 20);
            this.tBAdi.Name = "tBAdi";
            this.tBAdi.Size = new System.Drawing.Size(241, 23);
            this.tBAdi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Firma Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı:";
            // 
            // YeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lFormBaslik);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YeniMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Müşteri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSifirla;
        private System.Windows.Forms.Button buttonKaydet;
        public System.Windows.Forms.Label lFormBaslik;
        private System.Windows.Forms.TextBox tBAdres;
        private System.Windows.Forms.TextBox tBCepTelefonu;
        private System.Windows.Forms.TextBox tBIsTelefonu;
        private System.Windows.Forms.TextBox tBEvTelefonu;
        private System.Windows.Forms.TextBox tBFirmaAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}