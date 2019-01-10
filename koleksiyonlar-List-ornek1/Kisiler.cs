using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar_List_ornek1
{
    class Kisiler :Kursiyer
    {
        private int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }

        public int NO
        {
            get { return No; }
            set { No = value; }
        }
    }
    class Kursiyer
    {
        public int PortalNo { get; set; }
        public float Not1 { get; set; }
        public float Not2 { get; set; }
        private float ortalama { get; set; }

        public float hesaplama(float a, float b)
        {
            float ortalama = (a + b) / 2;
            return ortalama ;
        }

    }

}
