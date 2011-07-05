using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SVTLib
{
    public class Urun
    {
        private int id = 0;
        private string ad;
        private int miktar;
        private MiktarBirimi miktarBirimi;
        private string aciklama;

        public Urun(int id, string ad, int miktar, string aciklama, string miktar_birim_ad, int miktar_birim_id)
        {
            this.id = id;
            Ad = ad;
            Miktar = miktar;
            Aciklama = aciklama;

            miktarBirimi = new MiktarBirimi(miktar_birim_id, miktar_birim_ad);
        }

        public Urun()
        {
            // TODO: Complete member initialization
        }

        public int Id
        {
            get { return id; }
        }

        public string Ad
        {
            get { return ad; }
            set { ad = value.Trim(); }
        }

        public int Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        public MiktarBirimi MiktarBirimi
        {
            get { return miktarBirimi; }
        }

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value.Trim(); }
        }
    }
}
