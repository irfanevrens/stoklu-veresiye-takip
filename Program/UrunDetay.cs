using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SVTLib;

namespace Program
{
    public partial class UrunDetay : Form
    {
        private int id = 0;

        public UrunListesi urunListesiFormu = new UrunListesi();

        public UrunDetay()
        {
            InitializeComponent();
        }

        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        private void UrunDetay_Load(object sender, EventArgs e)
        {
            if (id == 0) throw new Exception("Ürün id bilgisi tanımsız.");

            UrunlerTablosu urunlerTablosu = new UrunlerTablosu();

            Urun urun = urunlerTablosu.getDetay1(id);

            lUrunKodu.Text = urun.Id.ToString();
            lUrunAdi.Text = urun.Ad;
            lUrunMiktari.Text = urun.Miktar + " " + urun.MiktarBirimi.Ad;
            lUrunAciklamasi.Text = urun.Aciklama;
        }

        private void bKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ürün silinecek! Emin misiniz?", "Ürün Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                UrunlerTablosu urunlerTablosu = new UrunlerTablosu();

                urunlerTablosu.UrunSilById(id);

                urunListesiFormu.UrunListesiniGuncelle();

                Close();
            }
        }
    }
}
