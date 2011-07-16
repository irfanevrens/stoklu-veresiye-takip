using System;
using System.Windows.Forms;
using System.Collections;
using SVTLib;
using Microsoft.VisualBasic;

namespace Program
{
    public partial class YeniMusteri : Form
    {
        private int urunId = 0;

        public UrunListesi UrunListesiFormu;
        public FormAna FormAnaFormu;

        public YeniMusteri()
        {
            InitializeComponent();
        }

        public int UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            MusterilerTablosu musterilerTablosu = new MusterilerTablosu();

            Musteri musteri = new Musteri();

            musteri.Adi = tBAdi.Text;
            musteri.FirmaAdi = tBFirmaAdi.Text;
            musteri.EvTelefonu = tBEvTelefonu.Text;
            musteri.IsTelefonu = tBIsTelefonu.Text;
            musteri.CepTelefonu = tBCepTelefonu.Text;
            musteri.Adres = tBAdres.Text;

            try
            {
                musterilerTablosu.Ekle1(musteri);

                FormAnaFormu.MusterileriTabloyaGetir();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
