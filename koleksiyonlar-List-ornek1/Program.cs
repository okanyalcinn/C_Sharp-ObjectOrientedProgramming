using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace koleksiyonlar_List_ornek1
{         
    class Program : Kisiler
    {
        static void Main(string[] args)
        {
            //generic tipli olduğu için 
            List<Kisiler> kisiler = new List<Kisiler>();

            Kisiler kisi = new Kisiler();
            kisi.NO = 53;
            kisi.Ad = "Ali";
            kisi.Soyad = "Çamlıbel";
            kisi.Tel = "05355656560";

            Kisiler kisi2 = new Kisiler();
            kisi2.NO = 53;
            kisi2.Ad = "Okan";
            kisi2.Soyad = "Çamlıbel";
            kisi2.Tel = "05355656560";

            kisiler.Add(kisi);
            kisiler.Add(kisi2);
            Console.WriteLine("\nlistedekiler ----------------------- ");
            Console.WriteLine("\nNo \tAd \tSoyad\t\tTelefon");
            for (int i = 0; i < kisiler.Count; i++)
            {
                Console.WriteLine(kisiler[i].NO.ToString() + " \t" + kisiler[i].Ad + " \t" + kisiler[i].Soyad + " \t" + kisiler[i].Tel);
            }
            Console.WriteLine("silinmede sonra ----------------------- ");
            Console.WriteLine("\nNo \tAd \tSoyad\t\tTelefon");
            kisiler.Remove(kisi2);// silme işlemi
            for (int i = 0; i < kisiler.Count; i++)
            {
                Console.WriteLine(kisiler[i].NO.ToString() + " \t" + kisiler[i].Ad + " \t" + kisiler[i].Soyad + " \t" + kisiler[i].Tel);
            }
            Console.WriteLine("\n----------------------------------------");
            List<Kisiler> kisiler2 = new List<Kisiler>();
            List<Kursiyer> kursiyer = new List<Kursiyer>();
            //en kısası
            for (int i = 0; i < 1 ; i++)
            {
                // bu şekildede kullanılabilir
                //Kisiler2 kisi3 = new Kisiler();

                //kisi3.NO = int.Parse(Console.ReadLine());
                //kisi3.Ad = Console.ReadLine();
                //kisi3.Soyad = Console.ReadLine();
                //kisi3.Tel = Console.ReadLine();

                //kisiler2.Add(kisi3);

                Console.Write("\nno gir: ");
                int _no = int.Parse(Console.ReadLine());
                Console.Write("\nad gir: ");
                string _ad = Console.ReadLine();
                Console.Write("\nsoyad gir: ");
                string _soyad = Console.ReadLine();
                Console.Write("\ntel gir: ");
                string _tel = Console.ReadLine();
                Console.Write("\nPortalno gir: ");
                int _portalNo = int.Parse(Console.ReadLine());
                Console.Write("\nnot1 gir: ");
                float _not1 = float.Parse(Console.ReadLine());
                Console.Write("\nnot2 gir: ");
                float _not2 = float.Parse(Console.ReadLine());
                kisiler2.Add(new Kisiler()
                {
                    NO = _no,
                    Ad = _ad,
                    Soyad = _soyad,
                    Tel = _tel
                });
                Kursiyer kursiyerH = new Kursiyer();
                float _ort = kursiyerH.hesaplama(_not1, _not2);
                kursiyer.Add(new Kursiyer()
                {
                    PortalNo = _portalNo,
                    Not1 = _not1,
                    Not2 = _not2,
                    ortalama = _ort
            });
            }
            Console.WriteLine("\nlistedekiler ----------------------- ");
            Console.WriteLine("\nNo \tAd \tSoyad\t\tTelefon\t\tPortal No\tOrtalama");
            for (int i = 0; i < kisiler2.Count; i++)
            {
                Console.WriteLine(kisiler[i].NO.ToString()+" \t"+kisiler[i].Ad + " \t" + kisiler[i].Soyad + " \t" + kisiler[i].Tel + " \t" + kursiyer[i].PortalNo + " \t\t" + kursiyer[i].ortalama);
            }
            
            
            Console.ReadKey();
        }
    }
}
