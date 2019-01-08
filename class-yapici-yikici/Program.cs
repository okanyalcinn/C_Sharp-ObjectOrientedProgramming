using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_yapici_yikici
{

    /* Yapıcı metotlar (Constructors) 
     * 
     * ilgili sınıftan nesne türetildiği an çalışan metoda biz yapıcı metot diyoruz        
     * --Yapıcı metot ilgili bulunduğu sınıfın adını alır
     * --Tip almaz void metod gibi davranırlar
     * 
     * yıkıcı metotlar (Destructors)
     * ilgili sınıftan üretilen nesne ile işimiz bittiği an çalışan metoda biz yıkıcı metot diyoruz 
     * --başına "~" (tilda) işareti konur
     * 
     * sınıf ornek
     * ~ornek()
     * {
     * 
     * }
     *  
     * */

    class Topla
    {
        public int topla { get; set; }

        public Topla(int a, int b)
        {
            topla = a + b;
            Console.WriteLine("Toplam: "+topla);
        }

        ~Topla()
        {
            topla = 0;
            Console.WriteLine("işlem tamamlandı Topla: " + topla);
        }
    }
    class Program
    {
        Program()
        {
            Console.WriteLine("iki sayı toplar");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            

            Topla topla = new Topla(5,3);
        }
    }
}
