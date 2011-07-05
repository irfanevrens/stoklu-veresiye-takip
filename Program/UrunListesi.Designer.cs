namespace Program
{
    partial class UrunListesi
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
            this.dGWUrunListesi = new System.Windows.Forms.DataGridView();
            this.tBAramaYap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bUrunSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Listesi";
            // 
            // dGWUrunListesi
            // 
            this.dGWUrunListesi.AllowUserToAddRows = false;
            this.dGWUrunListesi.AllowUserToDeleteRows = false;
            this.dGWUrunListesi.AllowUserToResizeColumns = false;
            this.dGWUrunListesi.AllowUserToResizeRows = false;
            this.dGWUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWUrunListesi.Location = new System.Drawing.Point(12, 81);
            this.dGWUrunListesi.Name = "dGWUrunListesi";
            this.dGWUrunListesi.ReadOnly = true;
            this.dGWUrunListesi.RowHeadersVisible = false;
            this.dGWUrunListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGWUrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGWUrunListesi.ShowCellToolTips = false;
            this.dGWUrunListesi.ShowEditingIcon = false;
            this.dGWUrunListesi.Size = new System.Drawing.Size(547, 326);
            this.dGWUrunListesi.TabIndex = 1;
            // 
            // tBAramaYap
            // 
            this.tBAramaYap.Location = new System.Drawing.Point(385, 53);
            this.tBAramaYap.Name = "tBAramaYap";
            this.tBAramaYap.Size = new System.Drawing.Size(174, 23);
            this.tBAramaYap.TabIndex = 2;
            this.tBAramaYap.TextChanged += new System.EventHandler(this.tBAramaYap_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama Yap";
            // 
            // bUrunSil
            // 
            this.bUrunSil.Location = new System.Drawing.Point(12, 413);
            this.bUrunSil.Name = "bUrunSil";
            this.bUrunSil.Size = new System.Drawing.Size(115, 23);
            this.bUrunSil.TabIndex = 4;
            this.bUrunSil.Text = "SEÇİLENLERİ SİL";
            this.bUrunSil.UseVisualStyleBackColor = true;
            this.bUrunSil.Click += new System.EventHandler(this.bUrunSil_Click);
            // 
            // UrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 533);
            this.Controls.Add(this.bUrunSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBAramaYap);
            this.Controls.Add(this.dGWUrunListesi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UrunListesi";
            this.Text = "UrunListesi";
            this.Load += new System.EventHandler(this.UrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWUrunListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGWUrunListesi;
        private System.Windows.Forms.TextBox tBAramaYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bUrunSil;
    }
}