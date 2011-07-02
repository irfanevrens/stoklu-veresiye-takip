using System;
using System.Windows.Forms;
using System.Collections;
using SVTLib;

namespace Program
{
    public partial class YeniUrunEkle : Form
    {
        public YeniUrunEkle()
        {
            InitializeComponent();
        }

        private void YeniUrunEkle_Load(object sender, EventArgs e)
        {
            comboBoxMiktarBirimId.Items.Clear();

            comboBoxMiktarBirimId.DisplayMember = "Ad";
            comboBoxMiktarBirimId.ValueMember = "Id";

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

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();

            try
            {
                urun.Ad = textBoxAd.Text;
                urun.Miktar = Convert.ToInt32(numericUpDownMiktar.Value);
                urun.MiktarBirimId = ((MiktarBirimi)(comboBoxMiktarBirimId.SelectedItem)).Id;
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

        private void numericUpDownMiktar_Enter(object sender, EventArgs e)
        {
            numericUpDownMiktar.Select(0, numericUpDownMiktar.Value.ToString().Length);
        }
    }
}
