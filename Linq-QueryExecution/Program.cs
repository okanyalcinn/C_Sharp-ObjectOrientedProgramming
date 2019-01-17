using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_QueryExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //p.LinQEx();

            //p.LinqImmediateExecution();

            p.Soru();
        }

        //eşitleme sıralama - Deferred Execution
        public void LinQEx()
        {
            int[] numaralar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 67 };
            int i = 0;
            var sorgu = from n in numaralar select ++i;

            foreach (var item in sorgu)
            {
                Console.WriteLine("item: {0}, i: {1}", item, i);
            }
        }

        public void LinqImmediateExecution()
        {
            int[] numaralar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 67 };
            //liste oluşturma
            int i = 0;
            var sorgu = (from n in numaralar select ++i).ToList();

            foreach (var item in sorgu)
            {
                Console.WriteLine("item {0}, {1}", item, i);
            }
        }

        // soru
        // verilen dizinin 3 ten küçük olan elemanlarını Linq le listeleyip ekrana yazdırın
        public void Soru()
        {
            int[] numaralar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 67 };

            var sorgu = (from n in numaralar where n < 3 select n).ToList(); // .ToList() yerine .ToArray() de kullanılabilir
            //                                                           Array.Sort(sorgu);

            foreach (var item in sorgu)
            {
                Console.WriteLine(item);
            }
        }
    }
}
