namespace Program
{
    partial class MusteriForm
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
            this.dGWHareketler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // dGWHareketler
            // 
            this.dGWHareketler.AllowUserToAddRows = false;
            this.dGWHareketler.AllowUserToDeleteRows = false;
            this.dGWHareketler.AllowUserToResizeColumns = false;
            this.dGWHareketler.AllowUserToResizeRows = false;
            this.dGWHareketler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWHareketler.Location = new System.Drawing.Point(12, 54);
            this.dGWHareketler.Name = "dGWHareketler";
            this.dGWHareketler.ReadOnly = true;
            this.dGWHareketler.RowHeadersVisible = false;
            this.dGWHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGWHareketler.Size = new System.Drawing.Size(607, 348);
            this.dGWHareketler.TabIndex = 1;
            this.dGWHareketler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dGWHareketler_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Veresiye Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tahsilat Yap";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Değişiklik Yap";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "&Sil";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(501, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "&Kapat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 36);
            this.button7.TabIndex = 8;
            this.button7.Text = "Önceki Müşteri";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(501, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "Sonraki Müşteri";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(136, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(359, 36);
            this.button8.TabIndex = 10;
            this.button8.Text = "Müşteri Düzenle";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 456);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGWHareketler);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriForm";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MusteriForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dGWHareketler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGWHareketler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}