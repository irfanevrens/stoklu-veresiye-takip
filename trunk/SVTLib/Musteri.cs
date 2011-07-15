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
        private string firma_adi;
        private string ev_telefonu;
        private string is_telefonu;
        private string cep_telefonu;
        private string adres;

        public Musteri(int id, string adi)
        {
            this.id = id;
            Adi = adi;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Adi
        {
            get { return adi; }
            set { adi = value.Trim(); }
        }
    }
}
