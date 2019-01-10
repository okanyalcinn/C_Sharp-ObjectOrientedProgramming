using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace koleksiyonlar_sortedList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            //      key ,   value
            s.Add("araba","car");
            s.Add("masa", "table");
            s.Add("kalem", "pencil");
            s.Add("kitap", "book");

            Console.WriteLine(s.Count);

            Console.WriteLine("\nDictionaryEntry");        
            foreach (DictionaryEntry item in s)
            {
                string a = item.Key.ToString();
                string b = item.Value.ToString();
                Console.WriteLine(a+"-"+b);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\nDictionaryEntry 2");
            foreach (DictionaryEntry item in s)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\ncollection-key");
            ICollection collection = s.Keys;
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\ncollection-value");
            ICollection collection1 = s.Values;
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            SortedList rakam = new SortedList();
            //       key , value
            rakam.Add(1, "car");
            rakam.Add(2, "table");
            rakam.Add(3, "pencil");
            rakam.Add(4, "book");
            foreach (DictionaryEntry item in rakam)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            Console.WriteLine("------------------------");
            foreach (var item in rakam.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            foreach (var item in rakam.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
