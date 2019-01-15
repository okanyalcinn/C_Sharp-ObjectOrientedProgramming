using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Generic_ornek1
{
    public class Degis
    {
        /// <summary>
        /// Gelen diziyi yeni boyutuna göre hazırlayıp ona aktarma
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dizi"></param>
        public void Boyutlandir<T>(ref T[] dizi)
        {
            T[] yeniBoyutlu = new T[dizi.Length * 2];

            for (int i = 0; i < dizi.Length; i++)
            {
                yeniBoyutlu[i] = dizi[i];
            }
            dizi = yeniBoyutlu;
        }
    }
    class Program
    {
        static void Goster<T>(ref T[]a)
        {
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4 };
            Goster(ref sayilar);
            Console.WriteLine("\n---------");
            Degis degis = new Degis();
            degis.Boyutlandir(ref sayilar);
            Goster(ref sayilar);

            Console.WriteLine("\n///////////////////////");
            byte[] sy = { 1, 2, 3, 4 };
            Goster(ref sy);
            Console.WriteLine("\n---------");
            degis.Boyutlandir(ref sy);
            Goster(ref sy);

            Console.WriteLine("\n///////////////////////");
            string[] st = { "d1", "d2", "d3", "d4" };
            Goster(ref st);
            Console.WriteLine("\n---------");
            degis.Boyutlandir(ref st);
            Goster(ref st);
        }
    }
}
