using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Koleksiyonlar_List
{
    class Program
    {
        // Generic koleksiyonlar
        static void Main(string[] args)
        {
            List<string> ts = new List<string>();
            ts.Add("a");
            ts.Add("b");

            for (int i = 0; i < ts.Count; i++)
            {
                Console.WriteLine(ts[i]);
            }
            Console.WriteLine("\nTersten sıralama ------------------");
            ts.Reverse();
            for (int i = 0; i < ts.Count; i++)
            {
                Console.WriteLine(ts[i]);
            }

        }
    }
}
