using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_try_catch_ornek1
{
    class Program
    {
        static void Dizi()
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Dizi();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                //throw;
            }
            finally
            {
                Console.WriteLine("program bitişi");
                int c = 3 + 5;
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
