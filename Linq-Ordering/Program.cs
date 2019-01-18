using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Ordering
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //p.LinqOrder();

            p.LinqOrders();
        }

        public void LinqOrder()
        {
            string[] kelimeler = { "deneme", "demo", "demir" };

            var sirala = from kelime in kelimeler orderby kelime.Length select kelime;
            var sirala2 = from kelime in kelimeler orderby kelime.Length descending select kelime;

            foreach (var item in sirala)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nters sıralama");
            foreach (var item in sirala2)
            {
                Console.WriteLine(item);
            }
        }

        public void LinqOrders()
        {
            string[] kelimeler = { "bir", "iki", "üç", "üü" };
            var sec = (from kelime in kelimeler where kelime[1] == 'ü' select kelime);

            foreach (var item in sec)
            {
                Console.WriteLine(item);
            }
        }
    }
}
