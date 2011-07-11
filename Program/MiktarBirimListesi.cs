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
using Microsoft.VisualBasic;

namespace Program
{
    public partial class MiktarBirimListesi : Form
    {
        public MiktarBirimListesi()
        {
            InitializeComponent();
        }

        private void MiktarBirimListesi_Load(object sender, EventArgs e)
        {
            MiktarBirimleriListesiniGuncelle();
        }

        private void MiktarBirimleriListesiniGuncelle()
        {
            MiktarBirimleriTablosu miktarBirimleriTablosu = new MiktarBirimleriTablosu();

            ArrayList miktarBirimleri = miktarBirimleriTablosu.GetListe1();

            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("ADI", typeof(string));

            foreach (MiktarBirimi miktarBirimi in miktarBirimleri)
            {
                table.Rows.Add(miktarBirimi.Id, miktarBirimi.Ad);
            }

            dGWMiktarBirimleriListesi.DataSource = table;

            dGWMiktarBirimleriListesi.Columns[0].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bYeniBirimEkle_Click(object sender, EventArgs e)
        {
            MiktarBirimi miktarBirimi = new MiktarBirimi();

            miktarBirimi.Ad = Interaction.InputBox("Birim adını giriniz", "Yeni Birim");

            if (!String.IsNullOrEmpty(miktarBirimi.Ad))
            {
                MiktarBirimleriTablosu miktarBirimleriTablosu = new MiktarBirimleriTablosu();
                miktarBirimleriTablosu.Ekle1(miktarBirimi);

                MiktarBirimleriListesiniGuncelle();
            }
        }

        private void bMiktarBirimiDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGWMiktarBirimleriListesi.SelectedRows.Count != 1) throw new Exception("Lütfen listeden bir tane birim seçiniz.");

                int birimId = Convert.ToInt32(dGWMiktarBirimleriListesi.SelectedRows[0].Cells[0].Value);
                string eskiBirimAdi = dGWMiktarBirimleriListesi.SelectedRows[0].Cells[1].Value.ToString();
                string yeniBirimAdi = Interaction.InputBox("Birim adını giriniz", "Birim Güncelle", eskiBirimAdi);

                if (!String.IsNullOrEmpty(yeniBirimAdi))
                {
                    MiktarBirimleriTablosu miktarBirimleriTablosu = new MiktarBirimleriTablosu();

                    miktarBirimleriTablosu.GuncelleAdiById(yeniBirimAdi, birimId);

                    MiktarBirimleriListesiniGuncelle();
                }
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

        private void bMiktarBirimiSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili birimler silinecek! Emin misiniz?", "Birimler Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MiktarBirimleriTablosu miktarBirimleriTablosu = new MiktarBirimleriTablosu();

                ArrayList silinecekIndexs = new ArrayList();

                UrunlerTablosu urunlerTablosu = new UrunlerTablosu();

                for (int i = 0; i < dGWMiktarBirimleriListesi.SelectedRows.Count; i++)
                {
                    int aktifBirimId = Convert.ToInt32(dGWMiktarBirimleriListesi.SelectedRows[i].Cells[0].Value);
                    string aktifBirimAdi = dGWMiktarBirimleriListesi.SelectedRows[i].Cells[1].Value.ToString();

                    if (urunlerTablosu.IsVarWhereMiktarBirimId(aktifBirimId))
                    {
                        MessageBox.Show(aktifBirimAdi + " birimi ürünlerde kullanıldığı için silinmedi.", "Birim Silinemedi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else 
                    {
                        silinecekIndexs.Add(dGWMiktarBirimleriListesi.SelectedRows[i].Index);
                        miktarBirimleriTablosu.SilById(aktifBirimId);
                    }
                }

                for (int i = 0; i < silinecekIndexs.Count; i++)
                {
                    dGWMiktarBirimleriListesi.Rows.RemoveAt(Convert.ToInt32(silinecekIndexs[i]));
                }
            }
        }
    }
}
