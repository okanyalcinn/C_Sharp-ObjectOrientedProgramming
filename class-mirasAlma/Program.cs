using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_mirasAlma
{
    class Program
    {
        /*hayvanlar sınıfı
         *omurgalılar - balıklar,kuşlar
         *omurgasızlar - sürüngenler, bocekler
         * 
         * 
         **/

        class Hayvanlar
        {
            public string TurAdi;
        }
        class Omurgalilar:Hayvanlar //hayvanların alt sınıfı olarak tanımlamış olduk
        {
            public string OmurgaliCins;
        }
        class Baliklar:Omurgalilar
        {

        }
        class Kuslar:Omurgalilar
        {

        }

        class Omurgasizlar : Hayvanlar
        {
            public string OmurgasizCins;
        }
        class Surungenler : Omurgasizlar
        {

        }
        class Bocekler : Omurgasizlar
        {

        }

        static void Main(string[] args)
        {
            Omurgasizlar omurgasizlar = new Omurgasizlar();
            omurgasizlar.TurAdi = "hayvanlar";
            Console.WriteLine(omurgasizlar.TurAdi);

            Bocekler bocekler = new Bocekler();
            bocekler.TurAdi = "";

            Console.ReadKey();
        }

    }
}
