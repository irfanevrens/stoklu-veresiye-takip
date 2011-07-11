namespace Program
{
    partial class MiktarBirimListesi
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
            this.dGWMiktarBirimleriListesi = new System.Windows.Forms.DataGridView();
            this.bYeniBirimEkle = new System.Windows.Forms.Button();
            this.bMiktarBirimiDuzenle = new System.Windows.Forms.Button();
            this.bMiktarBirimiSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMiktarBirimleriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miktar Birimleri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dGWMiktarBirimleriListesi
            // 
            this.dGWMiktarBirimleriListesi.AllowUserToAddRows = false;
            this.dGWMiktarBirimleriListesi.AllowUserToDeleteRows = false;
            this.dGWMiktarBirimleriListesi.AllowUserToResizeColumns = false;
            this.dGWMiktarBirimleriListesi.AllowUserToResizeRows = false;
            this.dGWMiktarBirimleriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWMiktarBirimleriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMiktarBirimleriListesi.Location = new System.Drawing.Point(13, 90);
            this.dGWMiktarBirimleriListesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGWMiktarBirimleriListesi.Name = "dGWMiktarBirimleriListesi";
            this.dGWMiktarBirimleriListesi.ReadOnly = true;
            this.dGWMiktarBirimleriListesi.RowHeadersVisible = false;
            this.dGWMiktarBirimleriListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGWMiktarBirimleriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGWMiktarBirimleriListesi.ShowCellToolTips = false;
            this.dGWMiktarBirimleriListesi.ShowEditingIcon = false;
            this.dGWMiktarBirimleriListesi.Size = new System.Drawing.Size(430, 342);
            this.dGWMiktarBirimleriListesi.TabIndex = 2;
            // 
            // bYeniBirimEkle
            // 
            this.bYeniBirimEkle.Location = new System.Drawing.Point(12, 439);
            this.bYeniBirimEkle.Name = "bYeniBirimEkle";
            this.bYeniBirimEkle.Size = new System.Drawing.Size(114, 32);
            this.bYeniBirimEkle.TabIndex = 3;
            this.bYeniBirimEkle.Text = "Yeni Birim Ekle";
            this.bYeniBirimEkle.UseVisualStyleBackColor = true;
            this.bYeniBirimEkle.Click += new System.EventHandler(this.bYeniBirimEkle_Click);
            // 
            // bMiktarBirimiDuzenle
            // 
            this.bMiktarBirimiDuzenle.Location = new System.Drawing.Point(132, 439);
            this.bMiktarBirimiDuzenle.Name = "bMiktarBirimiDuzenle";
            this.bMiktarBirimiDuzenle.Size = new System.Drawing.Size(114, 32);
            this.bMiktarBirimiDuzenle.TabIndex = 4;
            this.bMiktarBirimiDuzenle.Text = "Birimi Düzenle";
            this.bMiktarBirimiDuzenle.UseVisualStyleBackColor = true;
            this.bMiktarBirimiDuzenle.Click += new System.EventHandler(this.bMiktarBirimiDuzenle_Click);
            // 
            // bMiktarBirimiSil
            // 
            this.bMiktarBirimiSil.Location = new System.Drawing.Point(252, 439);
            this.bMiktarBirimiSil.Name = "bMiktarBirimiSil";
            this.bMiktarBirimiSil.Size = new System.Drawing.Size(114, 32);
            this.bMiktarBirimiSil.TabIndex = 5;
            this.bMiktarBirimiSil.Text = "Birimi Sil";
            this.bMiktarBirimiSil.UseVisualStyleBackColor = true;
            this.bMiktarBirimiSil.Click += new System.EventHandler(this.bMiktarBirimiSil_Click);
            // 
            // MiktarBirimListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 503);
            this.Controls.Add(this.bMiktarBirimiSil);
            this.Controls.Add(this.bMiktarBirimiDuzenle);
            this.Controls.Add(this.bYeniBirimEkle);
            this.Controls.Add(this.dGWMiktarBirimleriListesi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MiktarBirimListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiktarBirimListesi";
            this.Load += new System.EventHandler(this.MiktarBirimListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWMiktarBirimleriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGWMiktarBirimleriListesi;
        private System.Windows.Forms.Button bYeniBirimEkle;
        private System.Windows.Forms.Button bMiktarBirimiDuzenle;
        private System.Windows.Forms.Button bMiktarBirimiSil;
    }
}