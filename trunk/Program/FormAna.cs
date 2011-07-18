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
            YeniUrun yeniUrunEkle = new YeniUrun();

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
            MusterileriTabloyaGetir();

            tBAra.Focus();
        }

        public void MusterileriTabloyaGetir()
        {
            MusterilerTablosu musterilerTablosu = new MusterilerTablosu();

            ArrayList musteriler = musterilerTablosu.GetListe1();

            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("ADI", typeof(string));
            table.Columns.Add("VERESİYE DURUMU", typeof(string));

            foreach (Musteri musteri in musteriler)
            {
                string veresiyeDurumu = musterilerTablosu.GetVeresiyeDurumu(musteri);

                table.Rows.Add(musteri.Id, musteri.Adi, veresiyeDurumu);
            }

            dGWMusteriListesi.DataSource = table;

            int rowCount = 0;
            foreach (Musteri musteri in musteriler)
            {
                dGWMusteriListesi.Rows[rowCount].DefaultCellStyle.BackColor = musterilerTablosu.GetVeresiyeDurumuRengi(musteri);
                rowCount++;
            }

            dGWMusteriListesi.Columns[0].Visible = false;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bYeniMusteri_Click(object sender, EventArgs e)
        {
            YeniMusteri yeniMusteri = new YeniMusteri();

            yeniMusteri.FormAnaFormu = this;

            yeniMusteri.ShowDialog();
        }

        private void tBAra_TextChanged(object sender, EventArgs e)
        {
            if (tBAra.Text != "")
            {
                ((DataTable)this.dGWMusteriListesi.DataSource).DefaultView.RowFilter = "ADI LIKE '%" + tBAra.Text.Trim().ToUpper() + "%'";
            }
            else
            {
                ((DataTable)this.dGWMusteriListesi.DataSource).DefaultView.RowFilter = "";
            }
        }

        private void bMusteriSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili müşteriler silinecek! Emin misiniz?", "Müşteriler Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MusterilerTablosu musterilerTablosu = new MusterilerTablosu();
                VeresiyelerTablosu veresiyelerTablosu = new VeresiyelerTablosu();
                TahsilatlarTablosu tahsilatlarTablosu = new TahsilatlarTablosu();
                // @TODO tahsilatlar tablosu için sınıf yapılacak ve burada bir nesne oluşturulacak

                ArrayList silinecekIndexs = new ArrayList();

                for (int i = 0; i < dGWMusteriListesi.SelectedRows.Count; i++)
                {
                    int aktifMusteriId = Convert.ToInt32(dGWMusteriListesi.SelectedRows[i].Cells[0].Value);
                    string aktifMusteriAdi = dGWMusteriListesi.SelectedRows[i].Cells[1].Value.ToString();

                    if (musterilerTablosu.IsYokBorcu(aktifMusteriId))
                    {
                        silinecekIndexs.Add(dGWMusteriListesi.SelectedRows[i].Index);
                        tahsilatlarTablosu.SilWhereMusteriId(aktifMusteriId); 
                        veresiyelerTablosu.SilWhereMusteriId(aktifMusteriId);
                        // @TODO burada müşteriye ait tahsilatların silinmesi için gerekli kod yazılacak

                        musterilerTablosu.SilById(aktifMusteriId);
                    }
                    else
                    {
                        MessageBox.Show(aktifMusteriAdi + " isimli müşterinin veresiyesi ya da bakiyesi olduğu için silinenemdi.", "Müşteri Silinemedi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                for (int i = 0; i < silinecekIndexs.Count; i++)
                {
                    dGWMusteriListesi.Rows.RemoveAt(Convert.ToInt32(silinecekIndexs[i]));
                }
            }
        }
    }
}
