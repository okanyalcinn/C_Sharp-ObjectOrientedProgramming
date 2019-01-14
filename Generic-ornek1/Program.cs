using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_generic_ornek1
{
    //gelen iki not ortalama degere durum ve sonuc bilgini Generic Metotlar
    class Islem<T>
    {
        public string Sonuc { get; set; }
        public string Durum { get; set; }
        public T Not1 { get; set; }
        public T Not2 { get; set; }
        public T Not { get; set; }

        public Islem(T a, T b)
        {
            this.Not1 = a;
            this.Not2 = b;
        }
        public T Hesapla(ref double not1, ref double not2)
        {
            //Notun defaoult degerini alıyor int o sifr string null gibi
            T not = default(T);
            //not = (not1 + not2) / 2;
            if (not1 > 50)
            {
                Durum = "iyi";
                Sonuc = "Geçti";
                Console.WriteLine(not1 + "\n" + Durum + "\n" + Sonuc);
            }
            return not;
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Islem<double> islem = new Islem<double>(90, 50);
            double a = islem.Not1;
            double b = islem.Not2;
            islem.Hesapla(ref a, ref b);
        }
    }
}