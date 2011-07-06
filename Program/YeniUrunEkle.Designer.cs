namespace Program
{
    partial class YeniUrunEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMiktar = new System.Windows.Forms.NumericUpDown();
            this.buttonSifirla = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonYeniBirimTanimla = new System.Windows.Forms.Button();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.comboBoxMiktarBirimId = new System.Windows.Forms.ComboBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "YENİ ÜRÜN EKLEME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownMiktar);
            this.groupBox1.Controls.Add(this.buttonSifirla);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.buttonYeniBirimTanimla);
            this.groupBox1.Controls.Add(this.textBoxAciklama);
            this.groupBox1.Controls.Add(this.comboBoxMiktarBirimId);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(556, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDownMiktar
            // 
            this.numericUpDownMiktar.Location = new System.Drawing.Point(125, 50);
            this.numericUpDownMiktar.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownMiktar.Name = "numericUpDownMiktar";
            this.numericUpDownMiktar.Size = new System.Drawing.Size(99, 23);
            this.numericUpDownMiktar.TabIndex = 1;
            this.numericUpDownMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMiktar.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownMiktar.Enter += new System.EventHandler(this.numericUpDownMiktar_Enter);
            // 
            // buttonSifirla
            // 
            this.buttonSifirla.Location = new System.Drawing.Point(266, 282);
            this.buttonSifirla.Name = "buttonSifirla";
            this.buttonSifirla.Size = new System.Drawing.Size(110, 27);
            this.buttonSifirla.TabIndex = 5;
            this.buttonSifirla.Text = "Formu Sıfırla";
            this.buttonSifirla.UseVisualStyleBackColor = true;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(125, 282);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(135, 27);
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonYeniBirimTanimla
            // 
            this.buttonYeniBirimTanimla.Location = new System.Drawing.Point(372, 48);
            this.buttonYeniBirimTanimla.Name = "buttonYeniBirimTanimla";
            this.buttonYeniBirimTanimla.Size = new System.Drawing.Size(177, 26);
            this.buttonYeniBirimTanimla.TabIndex = 8;
            this.buttonYeniBirimTanimla.Text = "Yeni Birim Tanımla";
            this.buttonYeniBirimTanimla.UseVisualStyleBackColor = true;
            this.buttonYeniBirimTanimla.Click += new System.EventHandler(this.buttonYeniBirimTanimla_Click);
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(125, 81);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(424, 195);
            this.textBoxAciklama.TabIndex = 3;
            // 
            // comboBoxMiktarBirimId
            // 
            this.comboBoxMiktarBirimId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxMiktarBirimId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMiktarBirimId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMiktarBirimId.FormattingEnabled = true;
            this.comboBoxMiktarBirimId.Location = new System.Drawing.Point(230, 49);
            this.comboBoxMiktarBirimId.Name = "comboBoxMiktarBirimId";
            this.comboBoxMiktarBirimId.Size = new System.Drawing.Size(136, 26);
            this.comboBoxMiktarBirimId.TabIndex = 2;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(125, 20);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(241, 23);
            this.textBoxAd.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // YeniUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YeniUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniUrunEkle";
            this.Load += new System.EventHandler(this.YeniUrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.ComboBox comboBoxMiktarBirimId;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonYeniBirimTanimla;
        private System.Windows.Forms.Button buttonSifirla;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.NumericUpDown numericUpDownMiktar;
    }
}