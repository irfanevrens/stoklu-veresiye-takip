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
    public partial class MusteriForm : Form
    {
        private int musteriId;

        public MusteriForm()
        {
            InitializeComponent();
        }

        public int MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            MusterilerTablosu musterilerTablosu = new MusterilerTablosu();

            ArrayList hareketler = musterilerTablosu.GetHareketler1(MusteriId);

            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("TARİH", typeof(DateTime));
            table.Columns.Add("AÇIKLAMA", typeof(string));
            table.Columns.Add("VERESİYE", typeof(string));
            table.Columns.Add("TAHSİLAT", typeof(string));
            table.Columns.Add("HAREKET TÜRÜ", typeof(HareketTurleri));

            foreach (Hareket hareket in hareketler)
            {
                string veresiyeMiktari = (hareket.VeresiyeMiktari == 0) ? "" : hareket.VeresiyeMiktari + " TL";
                string tahsilatMiktari = (hareket.TahsilatMiktari == 0) ? "" : hareket.TahsilatMiktari + " TL";

                table.Rows.Add(hareket.Id, hareket.Tarih, hareket.Aciklama, veresiyeMiktari, tahsilatMiktari, hareket.HareketTuru);
            }

            dGWHareketler.DataSource = table;

            dGWHareketler.Columns[0].Visible = false;
            dGWHareketler.Columns[5].Visible = false;

            dGWHareketler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGWHareketler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dGWHareketler.Sort(dGWHareketler.Columns[1], ListSortDirection.Descending);
        }

        private void MusteriForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void dGWHareketler_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
