using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //p.LinQfiers();

            p.LinqAllaSimple();
        }
        //anny - Simple
        //tekli seçim işlemi

        public void LinQfiers()
        {
            string[] kelimeler = { "okan", "Hakan", "Osman" };

            bool sonuc = kelimeler.Any(x => x.Contains("ka"));
            Console.WriteLine("deger var mı ? "+sonuc);

            // kelimeler dizisindeki elemanları Take ile alıyoruz 
            var ara = kelimeler.Take(kelimeler.Count());
            // foreach içerisinde if kontrolü ile arama yaptırıp koşulu sağlayanı ekrana yazdırıyoruz
            foreach (var item in ara)
            {
                if (item == "Hakan")
                {
                    Console.WriteLine(item);
                }
            }
        }
        
        public void LinqAllaSimple()
        {
            int[] rakamlar = { 3, 5, 9, 11, 21, 33 };
            //dizi içerisindeki bütün ifadeleri inceleme
            bool tekler = rakamlar.All(x => x % 2 == 1);

            Console.WriteLine(tekler);

            var a = tekler.GetType();
            Console.WriteLine(a);
        }
    }
}
