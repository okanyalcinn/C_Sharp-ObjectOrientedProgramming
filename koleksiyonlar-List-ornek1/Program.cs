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
            List<Kursiyer> kursiyer = new List<Kursiyer>();

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
            //en kısası
            for (int i = 0; i < 5 ; i++)
            {
                // bu şekildede kullanılabilir
                //Kisiler kisi3 = new Kisiler();

                //kisi3.NO = int.Parse(Console.ReadLine());
                //kisi3.Ad = Console.ReadLine();
                //kisi3.Soyad = Console.ReadLine();
                //kisi3.Tel = Console.ReadLine();

                //kisiler.Add(kisi3);

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
                float _not1 = int.Parse(Console.ReadLine());
                Console.Write("\nnot2 gir: ");
                float _not2 = int.Parse(Console.ReadLine());
                kisiler.Add(new Kisiler()
                {
                    NO = _no,
                    Ad = _ad,
                    Soyad = _soyad,
                    Tel = _tel
                });
                kursiyer.Add(new Kursiyer()
                {
                    PortalNo = _portalNo,
                    Not1 = _not1,
                    Not2 = _not2
                });
            }
            Console.WriteLine("\nlistedekiler ----------------------- ");
            for (int i = 0; i < kisiler.Count; i++)
            {
                Console.WriteLine(kisiler[i].NO.ToString()+" \t"+kisiler[i].Ad + " \t" + kisiler[i].Soyad + " \t" + kisiler[i].Tel);
            }
            Console.WriteLine("silinmede sonra ----------------------- ");
            kisiler.Remove(kisi2);
            for (int i = 0; i < kisiler.Count; i++)
            {
                Console.WriteLine(kisiler[i].NO.ToString() + " \t" + kisiler[i].Ad + " \t" + kisiler[i].Soyad + " \t" + kisiler[i].Tel);
            }
        }
    }
}
