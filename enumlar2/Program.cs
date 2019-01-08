using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumlar2
{
    class Program
    {
        enum not : byte { basarisiz, gecmez, gecer, orta, iyi, pekiyi}

        enum not1 : byte { basarisiz = 10, gecmez = 50, gecer = 60, orta = 70, iyi = 80, pekiyi = 100 };

        static void Main(string[] args)
        {
            Console.WriteLine("Notu gir ");
            not a = (not)Convert.ToByte(Console.ReadLine());// not a = (not)1; 1inci indexteki değeri alır
            Console.WriteLine(a);

            byte c = (byte)a;
            Console.WriteLine(c.GetType());

            Console.ReadKey();
        }
    }
}
