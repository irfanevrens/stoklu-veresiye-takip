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
            // müşteri silme işlemi yapmadan evvel kullanıcıdan 
            // yaptığı işin onayını almak için soru soruyoruz
            if (MessageBox.Show("Seçili müşteriler silinecek! Emin misiniz?", "Müşteriler Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // eğer karşısına çıkan uyarıya OK 
                // derse o zaman bu kısım çalışacak

                // müşteriler tablosu için yapılacak 
                // işlemleri bu sınıf üzerinden yapacağız.
                MusterilerTablosu musterilerTablosu = new MusterilerTablosu();

                // müşteriye ait veresiye kayıtları için 
                // gerekli işlemlerde bu nesneyi kullanacağız
                VeresiyelerTablosu veresiyelerTablosu = new VeresiyelerTablosu();

                // müşteriye ait tahsilat kayıtları için 
                // gerekli işlemlerde bu nesneyi kullanacağız
                TahsilatlarTablosu tahsilatlarTablosu = new TahsilatlarTablosu();

                // bu değişken datagrid üzerindeki silinmek üzere 
                // işaretlenen kaytların index değerini tutmak 
                // için kullanılacak. şöyle ki, diyelim ki 
                // datagrid içerisinde 5 tane müşteri var
                // bu müşterilerden 1. 3. ve 4. sıradaki müşterileri 
                // silmek isteyelim. silme işlemine önce 1. 
                // müşteriden başlar ve veritabanından müşteriyi
                // sildiğimiz gibi datagrid üzerindende silersek, 
                // bir sonraki adımda, daha önce 3. sırada olan 
                // müşteri 2. sıraya gelecektir. böyle olunca da 
                // silme ile ilgili sıkıntı çıkacaktır. işte bu 
                // nedenle müşteriler veritabanından silindikten sonra 
                // datagrid üzerindeki müşteri index'i bu değişkene 
                // koyuluyor ve tüm seçili müşteriler silindikten sonra
                // silinen müşterilere ait index değerlerine göre 
                // datagrid üzerinden ilgili kayıtlar kaldırılıyor
                ArrayList silinecekIndexs = new ArrayList();

                // listeden seçilen müşterilerin şayet borcu ya da 
                // bakiyesi bulunuyorsa o halde müşteri silinemeyeceği 
                // için bu işlemlerin en sonunda silinemyen müşteri sayısı 
                // kullanıcıya bilgi olarak verilmelidir. işte bu amaçla
                // bu değişken kullanılacak ve her müşteri silinememe 
                // durumunda değeri 1 artırılacaktır.
                int silinemeyenKayitSayisi = 0;

                // müşteri listesinin bulunduğu datagrid üzerindeki 
                // seçili kayıtlar üzerinde dönme işlemine başlıyoruz. 
                // diyelim ki 1. 3. ve 4. kayıtlar seçili olsun ve 
                // kullanıcı müşterileri sil butonuna tıklamış olsun
                // bu durumda bu döngüye 3 kez girilecek demektir.
                for (int i = 0; i < dGWMusteriListesi.SelectedRows.Count; i++)
                {
                    // diyelim ki 1. 3. ve 4. sıradaki kayıtlar seçilmiş olsunlar
                    // birinci dögüde 1. sıradaki kayıt işleneceği için bu değişkene
                    // 1. sıradaki müşterinin id bilgisi atanacaktır. bu şekilde 
                    // müşterinin id bilgisine göre işlemler yapabileceğiz.
                    int aktifMusteriId = Convert.ToInt32(dGWMusteriListesi.SelectedRows[i].Cells[0].Value);

                    // bu kontrol işlemi aktif müşterinin borcunun olup 
                    // olmadığını kontrol etmektedir.
                    if (musterilerTablosu.IsYokBorcu(aktifMusteriId))
                    {
                        // müşterinin herhangi bir borcu yoksa yani tahsilatları 
                        // ile ödemeleri birbirine eşit ise ya da her hangi bir 
                        // işlemi bulunmuyorsa bu kısım çalışacaktır.

                        // müşteri üzerinde işlem yapmadan önce seçili müşterinin
                        // index bilgisi silinecek index'ler değişkenine atanıyor
                        // daha sonra bu index'lere göre datagrid üzerinden kayıtlar 
                        // silinecektir.
                        silinecekIndexs.Add(dGWMusteriListesi.SelectedRows[i].Index);

                        // bu kısımda müşteriye ait tahsilatlar silinmektedir.
                        // şayet müşterinin tahsilatı hiç yoksa herhangi bir 
                        // kayıt silinmeyecektir.
                        tahsilatlarTablosu.SilWhereMusteriId(aktifMusteriId); 

                        // bu kısımda ise müşteriye ait veresiye kayıtları
                        // silinmektedir. veresiyesi hiç olmayan müşteri için 
                        // herhangi bir işlem yapmayacaktır.
                        veresiyelerTablosu.SilWhereMusteriId(aktifMusteriId);

                        // bu kısımda ise müşterinin kendisi sistemden tamamen 
                        // kaldırılmaktadır
                        musterilerTablosu.SilById(aktifMusteriId);
                    }
                    else
                    {
                        // müşterinin borcu ya da bakiyesi varsa bu kısım 
                        // çalışacaktır. 

                        // müşterinin borcu ya da bakiyesi olduğu için 
                        // silinemeyen kayıt sayısını 1 artırıyoruz.
                        // daha sonra bu bilgiyi kullanacağız.
                        silinemeyenKayitSayisi++;
                    }
                }

                // seçili müşteri kayıtları veritabanından silindikten sonra
                // form üzerinde yer alan datagrid üzerindeki kayıtların 
                // silinmesi işlemine geçebiliriz.
                for (int i = 0; i < silinecekIndexs.Count; i++)
                {
                    // silinen kayıt sayısı kadar bu döngü döner ve 
                    // her döngüde ilgili datagrid satırını siler
                    dGWMusteriListesi.Rows.RemoveAt(Convert.ToInt32(silinecekIndexs[i]));
                }

                // eğer silinemeyen bir müşteri varsa ekrana kaç 
                // adet silinemyen müşteri olduğu bilgisini veren 
                // bir bilgi mesajı çıkartılacaktır.
                if (silinemeyenKayitSayisi > 0) 
                {
                    MessageBox.Show(silinemeyenKayitSayisi.ToString() + " adet müşteri borcu ya da bakiyesi olduğu için silinemedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dGWMusteriListesi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dGWMusteriListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dGWMusteriListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriForm musteriForm = new MusteriForm();

            musteriForm.MusteriId = Convert.ToInt32(dGWMusteriListesi.Rows[e.RowIndex].Cells[0].Value);

            musteriForm.Show();
        }

        private void tBAra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeciliMusterininDetayiniAc();
            }
        }

        private void dGWMusteriListesi_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void dGWMusteriListesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;

                SeciliMusterininDetayiniAc();
            }
        }

        private void SeciliMusterininDetayiniAc()
        {
            int row_index = dGWMusteriListesi.SelectedRows[0].Index;

            dGWMusteriListesi_CellDoubleClick(dGWMusteriListesi, new DataGridViewCellEventArgs(0, row_index));
        }

        private void FormAna_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void tBAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (dGWMusteriListesi.SelectedRows.Count > 0)
                {
                    int toplam_kayit = dGWMusteriListesi.Rows.Count;
                    int eski_index = dGWMusteriListesi.SelectedRows[0].Index;

                    if (eski_index + 1 < toplam_kayit)
                    {
                        dGWMusteriListesi.Rows[eski_index].Selected = false;
                        dGWMusteriListesi.Rows[eski_index + 1].Selected = true;
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (dGWMusteriListesi.SelectedRows.Count > 0)
                {
                    int toplam_kayit = dGWMusteriListesi.Rows.Count;
                    int eski_index = dGWMusteriListesi.SelectedRows[0].Index;

                    if (eski_index > 0)
                    {
                        dGWMusteriListesi.Rows[eski_index].Selected = false;
                        dGWMusteriListesi.Rows[eski_index - 1].Selected = true;
                    }
                }
            }
        }
    }
}
