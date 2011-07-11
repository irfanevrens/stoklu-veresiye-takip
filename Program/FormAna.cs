using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Program
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniUrunEkle yeniUrunEkle = new YeniUrunEkle();

            yeniUrunEkle.Text = "Ürün Ekle";
            yeniUrunEkle.lFormBaslik.Text = yeniUrunEkle.Text;

            yeniUrunEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunListesi urunListesi = new UrunListesi();

            urunListesi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MiktarBirimListesi miktarBirimleriListesi = new MiktarBirimListesi();

            miktarBirimleriListesi.Show();
        }
    }
}
