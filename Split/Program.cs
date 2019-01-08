using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "merhaba deneme";
            string[] dizi2 = a.Split(' ');

            foreach (var item in dizi2)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
