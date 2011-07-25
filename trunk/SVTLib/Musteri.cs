using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SVTLib
{
    public class Musteri
    {
        private int id = 0;
        private string adi;
        private string firmaAdi;
        private string evTelefonu;
        private string isTelefonu;
        private string cepTelefonu;
        private string adres;

        private float veresiyeToplami;
        private float tahsilatToplami;

        public Musteri()
        {
            
        }

        public Musteri(int id, string adi, float veresiyeToplami, float tahsilatToplami)
        {
            this.id = id;
            Adi = adi;

            this.veresiyeToplami = veresiyeToplami;
            this.tahsilatToplami = tahsilatToplami;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Adi
        {
            get { return adi; }
            set { adi = value.Trim().ToUpper(); }
        }

        public string FirmaAdi
        {
            get { return firmaAdi; }
            set { firmaAdi = value.Trim().ToUpper(); }
        }

        public string EvTelefonu
        {
            get { return evTelefonu; }
            set { evTelefonu = value.Trim().ToUpper(); }
        }

        public string IsTelefonu
        {
            get { return isTelefonu; }
            set { isTelefonu = value.Trim().ToUpper(); }
        }

        public string CepTelefonu
        {
            get { return cepTelefonu; }
            set { cepTelefonu = value.Trim().ToUpper(); }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value.Trim().ToUpper(); }
        }

        public float VeresiyeToplami
        {
            get { return veresiyeToplami; }
        }

        public float TahsilatToplami
        {
            get { return tahsilatToplami; }
        }
    }
}
