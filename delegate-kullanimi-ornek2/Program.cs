using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_kullanimi_ornek2
{
    class Program
    {
        public delegate double Islem(int a, int b);
        public static double Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public static double Carp(int s1, int s2)
        {
            return s1 * s2;
        }
        static void Main(string[] args)
        {
            Islem islem = new Islem(Topla);
            Console.WriteLine(islem(10, 30));
            Console.WriteLine(islem.Invoke(20, 30));

            islem = new Islem(Carp);
            Console.WriteLine(islem(10, 30));
        }
    }
}
