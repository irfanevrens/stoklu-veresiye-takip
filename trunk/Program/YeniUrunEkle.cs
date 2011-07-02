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
            comboBoxMiktarBirimi.Items.Clear();

            MiktarBirimleriTablosu miktarBirimleriTablosu = new MiktarBirimleriTablosu();

            try
            {
                ArrayList miktarBirimleri = miktarBirimleriTablosu.GetListe1();

                foreach (MiktarBirimi miktarBirimi in miktarBirimleri)
                {
                    comboBoxMiktarBirimi.Items.Add(miktarBirimi.Ad);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
