using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_hayvanlarAlemi
{
    /*hayvanlar sınıfı
     *omurgalılar - balıklar,kuşlar
     *omurgasızlar - sürüngenler, bocekler, ahtapot
     * 
     * 
     **/
    class Hayvanlar
    {
        public class Omurgalilar
        {
            public class Baliklar
            {
                public string TurAdi = "Çinekop";
            }
            public class Kuslar
            {
                public string TurAdi = "Kanarya";
            }
        }
        public class Omurgasizlar
        {
            public class Surungenler
            {
                public string TurAdi = "Surungenler";
                public string HayvanAdi = "Solucan";
                public string Cinsi = "Kobre";
                public int Boyu = 1;
            }
            public class Bocekler
            {
                public string TurAdi = "Bocekler";
            }
            public class Ahtapot
            {

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Hayvanlar.Omurgalilar.Kuslar kuslar = new Hayvanlar.Omurgalilar.Kuslar();
            Console.WriteLine(kuslar.TurAdi);

            Hayvanlar.Omurgasizlar.Bocekler bocekler = new Hayvanlar.Omurgasizlar.Bocekler();
            Console.WriteLine(bocekler.TurAdi);

            Hayvanlar.Omurgasizlar.Surungenler surungenler = new Hayvanlar.Omurgasizlar.Surungenler();
            Console.WriteLine(surungenler.TurAdi+ surungenler.HayvanAdi+ surungenler.Boyu+ surungenler.Cinsi);

            Console.ReadKey();
        }
    }
}
