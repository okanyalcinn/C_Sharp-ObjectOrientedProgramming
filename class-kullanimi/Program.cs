using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_kullanimi
{
    class Program
    {
        /*Class-Sınıflar OOP(nesne yönelimli programlama) nın en öenmli birincil yapılarıdır.
         * 
         * Sınıflar sayesinde programı parçalayıp kontrolünün sağlanması daha kolay olur.         
         * Karmaşık yapıların daha kolay anlaşılabilir olmasını sağlar.
         * Sınıflar bir fonksiyon/yöntem kümesi (metod) olarak tanımlanabilir.         
         * Sınıflar bir özellik kümesi olarakta kullanılabilir.
         * --→ özellik(properties) sınıfları, bellekteki alanları programın nesneleri gibi hareket ederler.
         * Classlar o sınıfa ait nesne türetilmeyene kadar ram'de yer almazlar.
         * 
         * //Erişim Belirleyiciler
         * public = bu erişim belirleyicisiyle tanımlanan yapıya program içerisinde tüm alanlardan erişim sağlanabilir.
         * 
         *      örnek : public int Metod1(),
         * 
         * private = sadece kendi sınıfı içerisinden erişim sağlanır, en özel ve en katı en dar alana sahip erişim belirleyici tipidir.
         * tanımlamadığınız her yapı/ özellik vs private olarak tanımlanır
         *      örnek : private int Metod2(),
         * 
         * protected = sadece tanımladığı class'ın içerisinde ve de onan miras almış yani türetilmiş sınıflarda kullanılır.
         * 
         *      örnek : protected int Metod3(),
         *      
         * internal = yazılan program içerisinde build sonrası oluşturulan exe ve dll dosyalarında erişim belirleyici olarak kullanılabilir.
         * 
         * protected internal = protected ve internal erişim belirleyicilerin VEYA(OR) işlemi ile birleştirilmiş halidir.
         * 
         * 
         * 
         * 
         * 
         * 
         * */

        static void Main(string[] args)
        {
            int s1 = 12,
                s2 = 23;

            Islem n = new Islem();

            Console.WriteLine(n.Hesaplama(s1, s2));
            n.Mesaj("");

            Console.WriteLine(n.Ad);
            Console.WriteLine(n.ozellik1);
            Console.WriteLine(n.ozellik2);

            
            M1("public static");

            Program pp = new Program();
            pp.M1("public", 1);



            Console.ReadKey();
        }
        // erişim belirleyici static olup olmama durumu stack heap metod adı (prarametreler)
        public static void M1(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        public void M1(string mesaj,int a)
        {
            Console.WriteLine(mesaj);
        }
    }


    class Islem
    {
        public int ozellik1 = 12;
        public int ozellik2 = 233;

        public string Ad = "Ömer";

        public int Hesaplama(int o1, int o2)
        {
            int toplam = o1+o2;
            return toplam;
        }

        public void Mesaj(string m)
        {
            Console.WriteLine(m);
        }

        public void Msj()
        {
            Console.WriteLine("Merhaba");
        }
    }
}