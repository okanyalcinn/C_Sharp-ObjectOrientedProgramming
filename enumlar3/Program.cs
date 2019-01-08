using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumlar3
{
    class Program
    {
        enum gunler : byte { yok, Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar }

        static void Main(string[] args)
        {
            Console.WriteLine(gunler.Cuma);

            Console.WriteLine("1 den 7 ye kadar bir sayı gir ");
            gunler a = (gunler)Convert.ToByte(Console.ReadLine());// gunler a = (gunler)4;   4 üncü indexteki değeri alır
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
