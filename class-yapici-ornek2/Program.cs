using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // ekranda bekletme için kütüphaneyi çağırıyoruz

namespace class_yapici_ornek2
{
    // bu örnekte diyor ki sınıfa özel alanların method içerisinde this yardımıyla dış sınıftan gelen değerle bir olmasını yani değişimini sağlamak
    /*
     * Taşıt sınıfı
     *      hız
     *      konum
     *      zaman
     *      renk
     *      marka
     * 
     * 
     * */

    class Tasit
    {
        private int hiz { get; set; } // private (sınıfa özel) olsa bile this ile değişim sağlanıyor | hoca böyle yapmadı ben denedim
        public int konum { get; set; }
        public int zaman { get; set; }
        public string renk { get; set; }
        public string marka { get; set; }
        private int m { get; set; }

        public Tasit(int hiz, int konum, int zaman, string renk, string marka)
        {
            //this ilgili bulunduğu sınıfın alanları ile kullanılan metot parametrelerini birbirinden ayırmak için kullanılır
            this.hiz = konum / zaman;
            this.konum=konum;
            this.zaman = zaman;
            this.renk = renk;
            this.marka = marka;
        }

        public void TasitBilgi()
        {
            Thread.Sleep(2000); // bu satırda 2 saniye beklet
            Console.WriteLine("Aracın hızı {0}, konum {1}, zaman {2}, renk {3}, markalar {4}",hiz,konum,zaman,renk,marka);
        }
        ~Tasit()
        {
            Console.WriteLine("yıkıcı: Aracın hızı {0}, konum {1}, zaman {2}, renk {3}, markalar {4} → {5}", hiz, konum, zaman, renk, marka,m);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Tasit tasit = new Tasit(50,120,30,"mavi","bmc");
            tasit.TasitBilgi();
        }
    }
}
