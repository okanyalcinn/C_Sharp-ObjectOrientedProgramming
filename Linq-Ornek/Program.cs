using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek();
        }
        static void Ornek()
        {            
            List<int> sayilar = new List<int>();
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {                
                sayilar.Add(rd.Next(1,10));
            }

            foreach (var item in sayilar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            int max = sayilar.Max();
            Console.WriteLine("Maximum sayı: {0}", max);

            var sirala = from ss in sayilar orderby ss select ss * 5;
            foreach (var item in sirala)
            {
                Console.WriteLine(item);
            }

            /////////////
            // dizi hali
            /////////////
            //int[] sayilar = new int[10];
            //Random rd = new Random();

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    int a = rd.Next(1, 10);
            //    sayilar[i] = a;
            //}

            //foreach (var item in sayilar)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine("");
            //int max = sayilar.Max();
            //Console.WriteLine("Maximum sayı: {0}",max);

            //var sirala = from ss in sayilar orderby ss select ss*5;
            //foreach (var item in sirala)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
