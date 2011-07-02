using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SVTLib
{
    public class MiktarBirimi
    {
        private int id;
        private string ad;

        public MiktarBirimi(int id, string ad)
        {
            this.id = id;
            this.ad = ad;
        }

        public int Id
        {
            get { return id; }
        }

        public string Ad
        {
            get { return ad; }
        }
    }
}
