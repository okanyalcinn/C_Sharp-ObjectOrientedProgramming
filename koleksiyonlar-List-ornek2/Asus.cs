using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar_List_ornek2
{
    class Asus : PcMarka
    {
        public string sesSistemi { get; set; }
        public string ekranTuru { get; set; }
        public string tasarim { get; set; }
        public double fiyat { get; set; }
        public double dolar { get; set; }
        public double FiyatNet { get; set; }

        public double Fiyat(double fiyat, double dolar)
        {
            double a = fiyat * dolar;
            return a;
        }
    }
}
