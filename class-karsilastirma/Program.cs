using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_karsilastirma
{
    /* IComparable
     * Değerler arası karşılaştırma ve sıralama gibi işlemler yapabildiğimiz interface
     * 
     * */

    class Urun:IComparable
    {
        public int No { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public Urun (int no, string ad, double fiyat)
        {
            this.No = no;
            this.Adi = ad;
            this.Fiyat = fiyat;
        }
        public int CompareTo(object obj)
        {
            //urun sınıfına gelen her değeri urun sınıfından olarak al
            Urun gelenUrun = (Urun)obj;

            ////obj nesnesi urun sınıfının bir üyesi mi 
            //Urun urun = obj as Urun;

            ////
            //int? a = 0;

            if (this.Fiyat > gelenUrun.Fiyat)
            {
                return 1;
            }
            else if (this.Fiyat < gelenUrun.Fiyat)
            {
                return 0;
            }
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun[] uruns =
            {
                new Urun(1,"Elma",100.5),
                new Urun(2,"Artmut",80.2),
                new Urun(3,"Muz",150.8)
            };

            Array.Sort(uruns);
            foreach (var item in uruns)
            {
                Console.WriteLine(item.No+" "+item.Adi+" "+item.Fiyat);
            }
        }
    }
}
