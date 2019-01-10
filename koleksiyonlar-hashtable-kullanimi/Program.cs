using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace koleksiyonlar_hashtable_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hashtable verileri karışık sırada alır döndürür 
            //-- sıralamak için arrayListe atıp Sort kullanarak sıralayabiliriz. 
            //      ama böyle birşey yapmak mantıksız olacaktır. Tekrar sıralama oluğu için bu işlem daha uzun sürecektir 

            Hashtable hashtable = new Hashtable();
            hashtable.Add(53, "Rize");
            hashtable.Add(34, "Istanbul");

            hashtable[55] = "Samsun";
            hashtable[56] = "Manisa";
            int a = 55;
            if (hashtable.ContainsKey(a)==true)
            {
                Console.WriteLine("ContainsKey "+hashtable[a]); //a yerine 55 te yazılabilir
            }
            Console.WriteLine("-------------------------------");
            if (hashtable.Contains(a) == true)
            {
                Console.WriteLine("Contains "+hashtable[a]); 
            }
            Console.WriteLine("-------------------------------");
            if (hashtable.ContainsValue("Rize")==true)
            {
                Console.WriteLine("ContainsValue - aradığın değer var");
            }
            Console.WriteLine("-------------------------------");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            Console.WriteLine("-------------------------------");
            ArrayList arrayList = new ArrayList(hashtable.Keys); //hastable daki key leri arrayListe atıyoruz
            arrayList.Sort(); // arrayList i sıralamak için kullanıyoruz
            foreach (var item in arrayList)
            {
                Console.WriteLine("{0} il {1}",item, hashtable[item]); //arrayList içerisindekileri döndürdül
            }

        }
    }
}
