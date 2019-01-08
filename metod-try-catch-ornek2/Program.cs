using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_try_catch_ornek2
{
    class Program
    {        
        static void Main(string[] args)
        {
            int s1;
            int s2;
            etiket:
            try
            {
                Console.WriteLine("sayı gir");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. sayıyı gir");
                s2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                goto etiket;
                throw;
            }
        }
    }
}
