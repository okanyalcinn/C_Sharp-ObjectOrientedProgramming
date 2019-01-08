using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_kapsulleme_ornek2
{
    class Bul
    {
        private int Sayi { get; set; }

        // sayi için properties kullanıyoruz - aynı tip olmak zorunda
        public int Sorgula
        {
            // get Sayi fieldını ramde okurken kullanılan kontrolü sağlar | atanılan değeri okuma kısmı
            //      return anahtar sözcüğü kullanılmak zorunda
            // set Sayi fieldına değer yazarken kontrolü sağlar  |değer atama kısmı
            //      value parametresi 
            get
            {
                if (Sayi < 100)
                {
                    return Sayi + 100;
                }
                else
                {
                    return Sayi;
                }
            }
            set
            {
                if (value < 0 )
                {
                    value = 10;
                }
                else
                {
                    Sayi = value;
                }
            }
        }

        public void Mesaj ()
        {
            Console.WriteLine(Sayi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bul bul = new Bul();

            int a = int.Parse(Console.ReadLine());

            bul.Sorgula = a;
            Console.WriteLine("Set filitresiz hali");
            bul.Mesaj();

            Console.WriteLine("Get filitresiz hali");
            Console.WriteLine(bul.Sorgula);
        }
    }
}
