using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SVTLib
{
    public class Veresiye
    {
        private int id;
        private string aciklama;
        private float miktar;
        private int musteriId;
        private DateTime tarih;

        public Veresiye(int id, string aciklama, DateTime tarih, float miktar)
        {
            this.id = id;
            this.aciklama = aciklama;
            this.tarih = tarih;
            this.miktar = miktar;
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

        public float Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        public int MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
    }
}
