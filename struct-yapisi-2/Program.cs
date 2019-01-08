using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_yapisi_2
{
    //değer tipli
    struct OgrenciBilgileri
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }

    class Program
    {        
        static void Main(string[] args)
        {
            OgrenciBilgileri[] Bilgileris = new OgrenciBilgileri[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}. öğrenci bilgilerini gir", i+1);
                Console.WriteLine("no gir");
                Bilgileris[i].No = int.Parse(Console.ReadLine());
                Console.WriteLine("ad gir");
                Bilgileris[i].Ad = Console.ReadLine().ToString();
                Console.WriteLine("soyad gir");
                Bilgileris[i].Soyad = Console.ReadLine().ToString();
            }
           
            // struct diziye değer atama yöntemleri
            //Bilgileris[1].No = 6;
            //Bilgileris[1].Ad = "Uğur";
            //Bilgileris[1].Soyad = "AKÇORA";

            //Bilgileris[2] = new OgrenciBilgileri()
            //{
            //    No = 10,
            //    Ad = "Metin",
            //    Soyad = "TAŞGIN"
            //};

            for (int i = 0; i < 2; i++)
            {
                Console.Write(Bilgileris[i].No+" ");
                Console.Write(Bilgileris[i].Ad+" ");
                Console.Write(Bilgileris[i].Soyad+" \n");
            }
        }
    }
}
