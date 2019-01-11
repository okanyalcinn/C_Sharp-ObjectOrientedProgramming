#define kullanim2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_base_kullanimi
{
#if (kullanim1)
    class Kitap
    {
        public void Ad()
        {
            Console.WriteLine("Kitap adı");
        }
    }
    class Roman:Kitap
    {
        public void IsbnNo()
        {
            base.Ad();
            Console.WriteLine("Isbn No");
        }
    }
    class RomanDetay :Roman
    {
        public void SayfaNo()
        {
            base.IsbnNo();
            Console.WriteLine("Sayfa No");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RomanDetay romanDetay = new RomanDetay();
            romanDetay.SayfaNo();
            Console.WriteLine("-----------------");
            Roman roman = new Roman();
            roman.IsbnNo();
            Console.WriteLine("-----------------");
            Kitap kitap = new Kitap();
            kitap.Ad();
        }
    }
#elif (kullanim2)
    class Kitap
    {
        public Kitap()
        {
            Console.WriteLine("Kitap adı");
        }
        public Kitap(string ad)
        {
            Console.WriteLine("Kitap adı"+ad);
        }
    }
    class Roman : Kitap
    {
        public Roman()
        {
            Console.WriteLine("Isbn No");
        }
        public Roman(string IsbnNo):base(IsbnNo)
        {
            Console.WriteLine("Isbn No"+ IsbnNo);
        }
    }
    class RomanDetay : Roman
    {
        public RomanDetay()
        {
            Console.WriteLine("Sayfa No");
        }
        public RomanDetay(int SayfaNo)
        {
            Console.WriteLine("Sayfa No"+SayfaNo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Roman roman = new Roman();
            Roman roman1 = new Roman("1231");


        }
    }
#endif
}
