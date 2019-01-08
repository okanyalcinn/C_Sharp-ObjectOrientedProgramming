using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aracın adı model ve rengi girilen yıla göre fiyat listesi
             * 
             * Araba sınıfı 
             * marka
             * model
             * renk
             * fiyat metod
             * 
             * 
             * 
             * */

            Araba a = new Araba();

            Console.WriteLine("ad gir");
            a.A_Adi = Console.ReadLine();
            Console.WriteLine("model gir");
            a.Model = Console.ReadLine();
            Console.WriteLine("renk gir");
            a.Renk = Console.ReadLine();

            Console.WriteLine("yılı gir");
            int yl = int.Parse(Console.ReadLine());

            float fiyat = a.Fiyat(yl);

            Console.WriteLine(a.A_Adi, a.Model,a.Renk,fiyat);

            Console.ReadKey();
        } 
    }

    class Araba
    {
        public string A_Adi;
        public string Model;
        public string Renk;
        public float Fiyat(int yil)
        {
            float fiyat = 0;

            switch (yil)
            {
                case 2016: fiyat = 50.000F; break;
                case 2017: fiyat = 150.000F; break;
                case 2018: fiyat = 250.000F; break;
                default:
                    break;
            }

            return fiyat;
        }
    }
}
