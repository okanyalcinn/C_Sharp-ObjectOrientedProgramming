using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ornek3
{//iki farklı yöntemle miras alma
    /* canlı sınıfı
     * ayak sayısı
     * gitme yöntemi
     * ses
     * üreme
     *  -kuş
     *      metod özelliklerini yaz
     *  -kedi
     *      metod özelliklerini yaz
     *  
     *
     * 
     * */

    class Canli
    {
        public int ayakSayisi;
        public string gitmeYontemi;
        public string ses;
        public string ureme;
    }
    class Kus:Canli
    {
        public void kus()
        {
            ayakSayisi = 2;
            gitmeYontemi = "Uçmak ";
            ses = "Cik-cik";
            ureme = "Yumurtlama (Yarasa hariç)";
            Console.WriteLine(ayakSayisi+gitmeYontemi+ses+ureme);
        }
    }
    class Kedi:Canli
    {
        public void kedi()
        {
            Console.WriteLine(ayakSayisi);
            Console.WriteLine(gitmeYontemi);
            Console.WriteLine(ses);
            Console.WriteLine(ureme);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Kus kus = new Kus();
            kus.kus();

            Kedi kediler = new Kedi();
            kediler.gitmeYontemi = "koşma";
            kediler.ses = "miyav";
            kediler.ayakSayisi = 4;
            kediler.ureme = "doğurma";
            kediler.kedi();


            Console.ReadKey();
        }
    }
}
