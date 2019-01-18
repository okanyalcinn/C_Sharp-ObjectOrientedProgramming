using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_AggregateOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.LinqSum();
        }
        public void LinqSum()
        {
            int[] numara = { 1, 2, 3, 4, 5 };
            //elemanları topla işlemi
            int sum = numara.Sum();
            //Minimum 
            int min = numara.Min();
            //Maximum
            int max = numara.Max();
            //Maximum uzun kelimeye Lambda ile alma
            string[] kelime = { "hakan", "basri", "pehlivanlar" };
            int uzunKelime = kelime.Max(n => n.Length);
            //Avarage
            double average = numara.Average();
            //Dis Count → eleman sayısı
            int disCount = numara.Distinct().Count();
            Console.WriteLine(disCount);


        }
    }
}
