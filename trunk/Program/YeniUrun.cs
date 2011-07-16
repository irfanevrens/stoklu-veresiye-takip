using System;
using System.Windows.Forms;
using System.Collections;
using SVTLib;
using Microsoft.VisualBasic;

namespace Program
{
    public partial class YeniUrun : Form
    {
        private int urunId = 0;

        public UrunListesi UrunListesiFormu;

        public YeniUrun()
        {
            InitializeComponent();
        }

        public int UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }

        private void MiktarBirimleriniGuncelle()
        {
            comboBoxMiktarBirimId.Items.Clear();

            comboBoxMiktarBirimId.DisplayMember = MiktarBirimi.AD;
            comboBoxMiktarBirimId.ValueMember = MiktarBirimi.ID;

            MiktarBirimleriTablosu miktarBirimleriTablosu = new MiktarBirimleriTablosu();

            try
            {
                ArrayList miktarBirimleri = miktarBirimleriTablosu.GetListe1();

                foreach (MiktarBirimi miktarBirimi in miktarBirimleri)
                {
                    comboBoxMiktarBirimId.Items.Add(miktarBirimi);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void YeniUrunEkle_Load(object sender, EventArgs e)
        {
            MiktarBirimleriniGuncelle();

            // ürün güncellemesi mi yapılacak?
            if (UrunId != 0)
            {
                UrunGuncellemekIcinFormuDoldur();
            }
        }

        private void UrunGuncellemekIcinFormuDoldur()
        {
            UrunlerTablosu urunlerTablosu = new UrunlerTablosu();

            Urun urun = urunlerTablosu.getDetay1(UrunId);

            textBoxAd.Text = urun.Ad;
            numericUpDownMiktar.Value = Convert.ToDecimal(urun.Miktar);

            for (int i = 0; i < comboBoxMiktarBirimId.Items.Count; i++)
            {

                if (((MiktarBirimi)comboBoxMiktarBirimId.Items[i]).Id == urun.MiktarBirimi.Id)
                    comboBoxMiktarBirimId.SelectedIndex = i;
            }


            textBoxAciklama.Text = urun.Aciklama;
        }



        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (UrunId == 0)
            {
                UrunEkle();
            }
            else
            {
                UrunGuncelle();
            }
        }

        private void UrunEkle()
        {
            Urun urun = new Urun();

            try
            {
                urun.Ad = textBoxAd.Text;
                urun.Miktar = Convert.ToInt32(numericUpDownMiktar.Value);
                urun.MiktarBirimi.Id = ((MiktarBirimi)(comboBoxMiktarBirimId.SelectedItem)).Id;
                urun.Aciklama = textBoxAciklama.Text;

                UrunlerTablosu urunlerTablosu = new UrunlerTablosu();

                urunlerTablosu.Ekle1(urun);

                MessageBox.Show("Yeni ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UrunGuncelle()
        {
            Urun urun = new Urun();

            try
            {
                urun.Id = UrunId;

                urun.Ad = textBoxAd.Text;
                urun.Miktar = Convert.ToInt32(numericUpDownMiktar.Value);
                urun.MiktarBirimi.Id = ((MiktarBirimi)(comboBoxMiktarBirimId.SelectedItem)).Id;
                urun.Aciklama = textBoxAciklama.Text;

                UrunlerTablosu urunlerTablosu = new UrunlerTablosu();

                urunlerTablosu.Guncelle1(urun);

                UrunListesiFormu.UrunListesiniGuncelle();

                MessageBox.Show("Ürün bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownMiktar_Enter(object sender, EventArgs e)
        {
            numericUpDownMiktar.Select(0, numericUpDownMiktar.Value.ToString().Length);
        }

        private void buttonYeniBirimTanimla_Click(object sender, EventArgs e)
        {
            MiktarBirimi miktarBirimi = new MiktarBirimi();

            miktarBirimi.Ad = Interaction.InputBox("Birim adını giriniz", "Yeni Birim");

            if (!String.IsNullOrEmpty(miktarBirimi.Ad))
            {
                MiktarBirimleriTablosu miktarBirimleriTablosu = new MiktarBirimleriTablosu();
                miktarBirimleriTablosu.Ekle1(miktarBirimi);

                MiktarBirimleriniGuncelle();

                for (int i = 0; i < comboBoxMiktarBirimId.Items.Count; i++) {
                
                    if (((MiktarBirimi)comboBoxMiktarBirimId.Items[i]).Ad == miktarBirimi.Ad)
                        comboBoxMiktarBirimId.SelectedIndex = i;
                }
            }
        }

        private void bSifirla_Click(object sender, EventArgs e)
        {
            if (UrunId == 0)
            {
                FormuTemizleUrunEklemekIcin();
            }
            else
            {
                FormuTemizleUrunGuncellemekIcın();
            }
        }

        private void FormuTemizleUrunGuncellemekIcın()
        {
            UrunGuncellemekIcinFormuDoldur();
        }

        private void FormuTemizleUrunEklemekIcin()
        {
            textBoxAd.Clear();
            numericUpDownMiktar.ResetText();
            comboBoxMiktarBirimId.ResetText();
            textBoxAciklama.Clear();
        }
    }
}
