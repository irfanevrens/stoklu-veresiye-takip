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

            // ((DataTable)this.dGWUrunListesi.DataSource).DefaultView.RowFilter = "Name LIKE '%jo%'";
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
    }
}
