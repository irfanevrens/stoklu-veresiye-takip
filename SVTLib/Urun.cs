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
        private int miktar_birim_id;
        private string aciklama;

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

        public int MiktarBirimId
        {
            get { return miktar_birim_id; }
            set { miktar_birim_id = value; }
        }

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value.Trim(); }
        }
    }
}
