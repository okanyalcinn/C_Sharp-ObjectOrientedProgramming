using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delege_event_kullanimi
{
    //void olayYoneticisi delesi türetildi
    delegate void OlayYonetici();

    class Buton
    {
        // delege üzerinden bir olay türettik burada Tikla aslında olayYöneticisinin temilcisi
        public event OlayYonetici Tikla;

        public void Tiklandi()
        {
            //olayYöneticisi tetikletti olan Tıkla eventi
            Tikla();
        }
    }
    class Pencere
    {
        int a { get; set; }
        public Pencere(int a)
        {
            this.a = a;
        }
        public void Tikla3()
        {
            Console.WriteLine("Pencere sınıfındaki Tikla3() çağrıldı.");
        }
    }
    class Program
    {
        public static void Tikla1()
        {
            Console.WriteLine("Program sınıfındaki Tikla1() çağrıldı.");
        }
        public static void Tikla2()
        {
            Console.WriteLine("Program sınıfındaki Tikla2() çağrıldı.");
        }
        static void Main(string[] args)
        {
            Buton buton = new Buton();
            Pencere pencere = new Pencere(1), pencere1 = new Pencere(2);
            Pencere pencere2 = new Pencere(3);

            buton.Tikla += new OlayYonetici(Tikla1);
            buton.Tikla += new OlayYonetici(Tikla2);
            buton.Tikla += new OlayYonetici(pencere.Tikla3);
            buton.Tikla += new OlayYonetici(pencere.Tikla3);
            buton.Tiklandi();
        }
        
    }
}
