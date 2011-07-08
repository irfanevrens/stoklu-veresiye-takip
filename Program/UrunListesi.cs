using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVTLib;
using System.Collections;

namespace Program
{
    public partial class UrunListesi : Form
    {
        public UrunListesi()
        {
            InitializeComponent();
        }

        private void UrunListesi_Load(object sender, EventArgs e)
        {
            UrunListesiniGuncelle();
        }

        public void UrunListesiniGuncelle()
        {
            UrunlerTablosu urunlerTablosu = new UrunlerTablosu();

            ArrayList urunler = urunlerTablosu.GetListe1();

            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("ADI", typeof(string));
            table.Columns.Add("MİKTAR", typeof(string));

            foreach (Urun urun in urunler)
            {
                table.Rows.Add(urun.Id, urun.Ad, urun.Miktar + " " + urun.MiktarBirimi.Ad);
            }

            dGWUrunListesi.DataSource = table;

            dGWUrunListesi.Columns[0].Visible = false;
        }

        private void tBAramaYap_TextChanged(object sender, EventArgs e)
        {
            if (tBAramaYap.Text != "")
            {
                ((DataTable)this.dGWUrunListesi.DataSource).DefaultView.RowFilter = "ADI LIKE '%" + tBAramaYap.Text.Trim() + "%'";
            }
            else
            {
                ((DataTable)this.dGWUrunListesi.DataSource).DefaultView.RowFilter = "";
            }
        }

        private void bUrunSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili ürünler silinecek! Emin misiniz?", "Ürünler Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                UrunlerTablosu urunTablosu = new UrunlerTablosu();

                ArrayList silinecekIndexs = new ArrayList();

                for (int i = 0; i < dGWUrunListesi.SelectedRows.Count; i++)
                {
                    silinecekIndexs.Add(dGWUrunListesi.SelectedRows[i].Index);

                    urunTablosu.UrunSilById(Convert.ToInt32(dGWUrunListesi.SelectedRows[i].Cells[0].Value));
                }

                for (int i = 0; i < silinecekIndexs.Count; i++)
                {
                    dGWUrunListesi.Rows.RemoveAt(Convert.ToInt32(silinecekIndexs[i]));
                }
            }
        }

        private void bUrunDetayi_Click(object sender, EventArgs e)
        {
            UrunDetay urunDetay = new UrunDetay();

            urunDetay.urunListesiFormu = this;

            try
            {
                if (dGWUrunListesi.SelectedRows.Count != 1) throw new Exception("Lütfen listeden bir adet ürün seçiniz.");

                urunDetay.Id = Convert.ToInt32(dGWUrunListesi.SelectedRows[0].Cells[0].Value);

                urunDetay.Show();
            }
            catch (Exception ex)
            {
                HataMesajiGoster(ex.Message);
            }
        }

        private void bUrunDuzenle_Click(object sender, EventArgs e)
        {
            YeniUrunEkle yeniUrunEkle = new YeniUrunEkle();

            yeniUrunEkle.UrunListesiFormu = this;

            yeniUrunEkle.Text = "Ürün Düzenle";
            yeniUrunEkle.lFormBaslik.Text = yeniUrunEkle.Text;

            try
            {
                if (dGWUrunListesi.SelectedRows.Count != 1) throw new Exception("Lütfen listeden bir adet ürün seçiniz.");

                yeniUrunEkle.UrunId = Convert.ToInt32(dGWUrunListesi.SelectedRows[0].Cells[0].Value);

                yeniUrunEkle.Show();
            }
            catch (Exception ex)
            {
                HataMesajiGoster(ex.Message);
            }
        }

        private void HataMesajiGoster(string hataMesaji)
        {
            MessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
