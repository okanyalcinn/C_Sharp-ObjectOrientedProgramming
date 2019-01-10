using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace queue_list
{
    class Program
    {
        //FİFO - ilk giren ilk çıkar
        /* İşleme ilk giren ilk çıkar
         * 
         * girdi    çıktı
         * 5        5     
         * 4        4
         * 8        8
         * 6        6
         * 
         * 
         * */
        static void Main(string[] args)
        {
            Queue ts = new Queue(4);
            ts.Enqueue("hakan");
            ts.Enqueue("basri");
            ts.Enqueue("ömer");
            ts.Enqueue("utku");

            foreach (var item in ts)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("dequeu > ilk çıkan > "+ts.Dequeue());
            Console.WriteLine("");
            // for u bunda kullanmak pek doğru değil - kuyruktan eksiltme yapılırsa fordan önce karışıklık çıkabilir
            for (int i = -1; i <= ts.Count+1; i++)
            {
                Console.Write(ts.Count);
                Console.WriteLine(" "+ ts.Dequeue());
            }
        }
    }
}
