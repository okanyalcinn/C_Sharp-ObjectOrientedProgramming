using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ornek1
{
    class Program
    {
        /**
         * 2 sınıf 2 şer metod
         * program sınıfı
         *      hesapla metodu
         *      yaz metodu
         * 
         * işlem sınıfı
         *      değerleri okutma metodu
         *      ekrana yazdır metodu
         * 
         * 
         * */
        static void Main(string[] args)
        {
            Program p = new Program();
            Islem i = new Islem();
            i.yaz();
            p.yazdir(i.hesapla());
            okut(i.hesapla());

            Console.ReadKey();
        }    
        public void yazdir(int sonuc)
        {
            Console.WriteLine("Toplamları: "+sonuc);
        }
        static void okut(int sonuc)
        {
            Console.WriteLine("Toplamları: " + sonuc);

        }
    }

    class Islem
    {
        //public int s1 = 0; yazılırsa diğer sınıftan bu değer çağrılabilir
        //int s1 = 0; yazılırsa diğer sınıftan bu değer çağrılamaz ama kendi sınıf içerisinde kullanılabilir
        public int s1 = 0;
        public int s2 = 0;

        public void yaz()
        {
            Console.WriteLine("1. sayiyi gir");
            s1= int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayiyi gir");
            s2= int.Parse(Console.ReadLine());
            
        }
        public int hesapla()
        {
            return s1+s2;            
        }        
    }
}
