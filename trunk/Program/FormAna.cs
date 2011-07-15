using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using SVTLib;
using System.Collections;

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

        private void FormAna_Load(object sender, EventArgs e)
        {
            MusterilerTablosu musterilerTablosu = new MusterilerTablosu();

            ArrayList musteriler = musterilerTablosu.GetListe1();

            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("ADI", typeof(string));

            foreach (Musteri musteri in musteriler)
            {
                table.Rows.Add(musteri.Id, musteri.Adi);
            }

            dGWMusteriListesi.DataSource = table;

            dGWMusteriListesi.Columns[0].Visible = false;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
