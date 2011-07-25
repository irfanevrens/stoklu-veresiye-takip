using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SVTLib
{
    public class Hareket
    {
        private int id;
        private string aciklama;
        private decimal veresiyeMiktari;
        private decimal tahsilatMiktari;
        private DateTime tarih;

        private HareketTurleri hareketTuru;

        public Hareket(int id, string aciklama, DateTime tarih, decimal veresiyeMiktari, decimal tahsilatMiktari, HareketTurleri hareketTuru)
        {
            this.id = id;
            this.aciklama = aciklama;
            this.tarih = tarih;
            this.veresiyeMiktari = veresiyeMiktari;
            this.tahsilatMiktari = tahsilatMiktari;
            this.hareketTuru = hareketTuru;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }

        public decimal VeresiyeMiktari
        {
            get { return veresiyeMiktari; }
            set { veresiyeMiktari = value; }
        }

        public decimal TahsilatMiktari
        {
            get { return tahsilatMiktari; }
            set { tahsilatMiktari = value; }
        }

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }

        public HareketTurleri HareketTuru
        {
            get { return hareketTuru; }
            set { hareketTuru = value; }
        }
    }



    public enum HareketTurleri
    { 
        Veresiye,
        Tahsilat
    }

 
}
