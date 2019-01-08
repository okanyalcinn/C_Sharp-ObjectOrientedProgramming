using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumlar1
{
    class Program
    {
        //Enum sabitleri sayesinde baı özel sözcüklerin tam sayıları temsil etmesi sağlanır
        //web sitesinde seçimlerde kullanılır
        //enum ad { a, y };

        enum durum : byte { altına, yanına, sagina, soluna};

        static void Main(string[] args)
        {            
            int[] a = new int[10];
            Diziyaz(durum.altına, a);
            Console.WriteLine("------------");
            Diziyaz(durum.yanına, a);
            

            Console.ReadKey();
        }

        static void Diziyaz(durum d, Array dizi)
        {            
            if (d==durum.yanına)
            {
                foreach (var item in dizi)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
            }

            if (d == durum.altına)
            {
                foreach (var item in dizi)
                {
                    Console.WriteLine(item + " ");
                }
            }
        }
    }
}
