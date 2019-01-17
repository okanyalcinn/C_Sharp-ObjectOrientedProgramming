using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_kullanimi2_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.LinqTake();

            //p.LinqSkip();

            p.LinqTakeWhile();
        }
        //take
        public void LinqTake()
        {
            int[] numaralar = { 5, 6, 5, 4, 6, 7 };

            var numara = numaralar.Take(5);

            foreach (var item in numara)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----");
        }
        //Skip
        public void LinqSkip()
        {
            int[] numaralar = { 5, 6, 5, 4, 6, 7 };

            var numara = numaralar.Take(5);
            //ondan sonraki değeri al
            var atla = numaralar.Skip(3);
            foreach (var item in atla)
            {
                Console.WriteLine(item);
            }
        }
        //TakeWhile 
        // bir listenin baştan itibaren verilen bir şarta (while) uyan elemanlarını şart sağlandığı sürece seçer, şart sağlanmadığı yerde seçmeyi bırakır.
        public void LinqTakeWhile()
        {
            int[] numaralar = { 5, 6, 2, 3, 4, 9, 11, 10, 0};

            // dizinin başlangıcından başlayarak, dizinin indexindeki sayı ile index numarasını kıyaslama
            //                                          dizinin indexindeki sayı > dizi index numarası
            var kNo = numaralar.TakeWhile((n, index) => n >= index);

            Console.WriteLine("En küçük no");
            foreach (var item in kNo)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
