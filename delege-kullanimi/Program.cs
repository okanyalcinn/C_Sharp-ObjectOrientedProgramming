using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delege_kullanimi
{
    /* delege /delegate türetilen sınıf içerisinde işlem yapılacağı zaman türetilen metod çağırımlarını temsilci vasıtasıyla halletmemize yarayan yapıdır.
     *      delegate kullanılırsa içerisine gönderilen veriler hafızada tutulur ve n tane kullanım sağlar. birden fazla sınıftan gönderilen verileri de tutar
     * Bir olayın ya da bir fonksiyonun bir değerin eş zamanlı birden çok kullanımına olanak sağlar
     * Ortak delegate kullanan olaylar delegate, n durumunda haberdar olurlar
     * Delegate metod olarak kullanılır, kod bloğu yoktur
     * Delegate new anahtar sözcüğü kullanılarak nesne türetilebilir
     * */
    class Program
    {
        delegate void Temsilci(); // Temsilci adı hesapla
        static void Islem()
        {
            Console.WriteLine("1.Sayıyı gir ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayıyı gir ");
            int b = Int32.Parse(Console.ReadLine());

            int topla = a + b;
            int cikarma = a - b;
            int bolme = a / b;
            int carpma = a * b;
            Console.WriteLine("Toplamı: " + topla);
            Console.WriteLine("Çıkartma: " + cikarma);
            Console.WriteLine("Bölme: " + bolme);
            Console.WriteLine("Çarpma: " + carpma);
        }
        static void Baslik()
        {
            Console.WriteLine("Hesaplama Programı");
        }
        static void Baslik1()
        {
            Console.WriteLine("İşlem sonu");
        }
        static void Main(string[] args)
        {
            Temsilci temsilci = new Temsilci(Baslik);
            temsilci();
            temsilci = new Temsilci(Baslik1);
            temsilci();
            temsilci = new Temsilci(Islem);
            temsilci();


        }
    }
}
