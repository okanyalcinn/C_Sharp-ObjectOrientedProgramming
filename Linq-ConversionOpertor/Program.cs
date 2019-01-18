using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_ConversionOpertor
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqArray();

            //LinqToList();

            ListToDictionary();

        }
        //ToArray()
        //ArrayList sınıfının tüm özelliklerini oluşturulan Linq sorgusuna dahil eder
        static void LinqArray()
        {
            double[] kesirliSayi = { 1.7, 1.6, 1.7, 4.6 };
            var siralanmis = from n in kesirliSayi orderby n descending select n;
            var diziyeCevir = siralanmis.ToArray();
            //veya bu şekilde kullanılabilir
            //var siralanmis = (from n in kesirliSayi orderby n descending select n).ToArray();

            for (int i = 0; i < diziyeCevir.Length; i++)
            {
                Console.WriteLine(diziyeCevir[i]);
            }
        }
        static void LinqToList()
        {
            string[] kelimeler = { "deno", "demo1", "demo2" };
            var sirala = (from n in kelimeler orderby n select n).ToList();
            var liste = sirala.ToList();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
        static void ListToDictionary()
        {
            var skorTablosu = new[]
            {
                new{Adi = "okan", skor=50},
                new{Adi = "osman", skor=40},
                new{Adi = "ali", skor=30}
            };
            Console.WriteLine("Ad ara: ");
            string ara = Console.ReadLine().ToString();

            var skorAra = skorTablosu.ToDictionary(n => n.Adi);
            var skr = skorTablosu.ToDictionary(x => x.skor);

            Console.WriteLine("{0}'nin skoru {1}", skorAra[ara].Adi, skorAra[ara].skor);
        }

    }
}
