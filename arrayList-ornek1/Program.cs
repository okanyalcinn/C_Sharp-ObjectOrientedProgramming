using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // array kütüphanesi

namespace arrayList_ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() // ArrayList(5) olarak tanımlarsak eleman sayısı 5 olarak başlıyor ram de o kadar yer kaplıyor
            {
                5.4F,5.2F,"c",'c'

            };
            Console.WriteLine("--------------------");
            Console.WriteLine("Eleman sayısı: " + list.Count);
            Console.WriteLine("--------------------");

            list.Add(2.8F);
            list.Add(5.0F);
            list.Add("bugün");
            list.Add("hava");
            list.Add("bugün");
            list.Add(5);
            list.Add(true);
            list.Add('c');

            Console.WriteLine("\n4. indisteki değer" + list[4]);
            Console.WriteLine("");

            foreach (var deger in list)
            {
                Console.Write(deger + " ");
                Console.WriteLine(deger.GetType());
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Eleman sayısı: "+list.Count);
            Console.WriteLine("------------------");
            list.Remove("bugün");

            Console.WriteLine((float)list[0] + (float)list[1]); //list listesindeki 0 ve 1. indistekini toplama
            list.Reverse();

            Console.WriteLine("");
            foreach (var deger in list)
            {
                Console.Write(deger + " ");
                Console.WriteLine(deger.GetType());
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Eleman sayısı: " + list.Count);
            Console.WriteLine("--------------------");

            
        }
    }
}
