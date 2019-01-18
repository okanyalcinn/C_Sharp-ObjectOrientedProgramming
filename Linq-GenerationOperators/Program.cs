using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_GenerationOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.LinqRepeat();

            p.LinqRange();
        }
        public void LinqRepeat()
        {
            var numara = Enumerable.Repeat(53, 20); // Repeat(x,y); x i y defa yazdırma → x i string olarakta alabiliriz
            foreach (var item in numara)
            {
                Console.WriteLine(item);
            }
        }
        //Range
        //Verilen sayıların tek çift durumunu Linq ile incele
        public void LinqRange()
        {//                                       10 dan başla 100 adet sayı üret
            var numara = from n in Enumerable.Range(10, 100) select new { numara = n, durum = n % 2 == 0 ? "Çift":"Tek"};

            foreach (var item in numara)
            {
                Console.WriteLine("numara: {0} , {1} ",item.numara, item.durum);
            }

        }
    }
}
