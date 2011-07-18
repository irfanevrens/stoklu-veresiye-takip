namespace Program
{
    partial class FormAna
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dGWMusteriListesi = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bMusteriSil = new System.Windows.Forms.Button();
            this.bYeniMusteri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMusteriListesi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 427);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ürün Listesi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 427);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Miktar Birimleri Listesi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dGWMusteriListesi
            // 
            this.dGWMusteriListesi.AllowUserToAddRows = false;
            this.dGWMusteriListesi.AllowUserToDeleteRows = false;
            this.dGWMusteriListesi.AllowUserToResizeColumns = false;
            this.dGWMusteriListesi.AllowUserToResizeRows = false;
            this.dGWMusteriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWMusteriListesi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dGWMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMusteriListesi.Location = new System.Drawing.Point(13, 87);
            this.dGWMusteriListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dGWMusteriListesi.Name = "dGWMusteriListesi";
            this.dGWMusteriListesi.ReadOnly = true;
            this.dGWMusteriListesi.RowHeadersVisible = false;
            this.dGWMusteriListesi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGWMusteriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGWMusteriListesi.Size = new System.Drawing.Size(529, 258);
            this.dGWMusteriListesi.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriToolStripMenuItem,
            this.toolStripMenuItem1,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniMüşteriToolStripMenuItem
            // 
            this.yeniMüşteriToolStripMenuItem.Name = "yeniMüşteriToolStripMenuItem";
            this.yeniMüşteriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yeniMüşteriToolStripMenuItem.Text = "Yeni Müşteri";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // tBAra
            // 
            this.tBAra.Location = new System.Drawing.Point(355, 57);
            this.tBAra.Name = "tBAra";
            this.tBAra.Size = new System.Drawing.Size(187, 23);
            this.tBAra.TabIndex = 6;
            this.tBAra.TextChanged += new System.EventHandler(this.tBAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ara:";
            // 
            // bMusteriSil
            // 
            this.bMusteriSil.Image = global::Program.Properties.Resources.images_30x30;
            this.bMusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMusteriSil.Location = new System.Drawing.Point(184, 353);
            this.bMusteriSil.Margin = new System.Windows.Forms.Padding(4);
            this.bMusteriSil.Name = "bMusteriSil";
            this.bMusteriSil.Size = new System.Drawing.Size(163, 40);
            this.bMusteriSil.TabIndex = 8;
            this.bMusteriSil.Text = "Müşteri Sil";
            this.bMusteriSil.UseVisualStyleBackColor = true;
            this.bMusteriSil.Click += new System.EventHandler(this.bMusteriSil_Click);
            // 
            // bYeniMusteri
            // 
            this.bYeniMusteri.Image = global::Program.Properties.Resources.add_30x30;
            this.bYeniMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bYeniMusteri.Location = new System.Drawing.Point(13, 353);
            this.bYeniMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.bYeniMusteri.Name = "bYeniMusteri";
            this.bYeniMusteri.Size = new System.Drawing.Size(163, 40);
            this.bYeniMusteri.TabIndex = 5;
            this.bYeniMusteri.Text = "Yeni Müşteri";
            this.bYeniMusteri.UseVisualStyleBackColor = true;
            this.bYeniMusteri.Click += new System.EventHandler(this.bYeniMusteri_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Program.Properties.Resources.add_30x30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(186, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yeni Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 474);
            this.Controls.Add(this.bMusteriSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBAra);
            this.Controls.Add(this.bYeniMusteri);
            this.Controls.Add(this.dGWMusteriListesi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWMusteriListesi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dGWMusteriListesi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button bYeniMusteri;
        private System.Windows.Forms.TextBox tBAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bMusteriSil;
    }
}

