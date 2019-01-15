using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_sozluk_ornek
{
    class Sozluk
    {
        Dictionary<string, string> sozluk = new Dictionary<string, string>();
        void Icindekiler()
        {
            sozluk.Add("KALEM", "Pencil");
            sozluk.Add("PENCERE", "Window");
            sozluk.Add("BİR", "One");
        }
        public void Ara(string aranan)
        {
            Icindekiler();
            bool bulunduMu = false;
            //Console.WriteLine(sozluk[a.ToUpper()]);
            foreach (var item in sozluk.Keys)
            {
                if (item == aranan) // sozluk içerisindeki key lerin içinde 
                {
                    Console.WriteLine(sozluk[item]);
                    bulunduMu = true;
                }                
            }
            if (!bulunduMu) // bulundu false ise
            {
                Console.WriteLine("Aradığınız kelime sözlüğümüzde bulunmuyor");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Aramak istediğiniz kelime");
            string aranan = Console.ReadLine().ToString().ToUpper();

            Sozluk sozluk = new Sozluk();

            sozluk.Ara(aranan); // oluşturulan sözlükte arama yapma key e göre

            //sozluk.Ara(Console.ReadLine().ToString().ToUpper()); // veya bu şekilde yazabiliriz

            Console.ReadKey();
        }
    }
}
