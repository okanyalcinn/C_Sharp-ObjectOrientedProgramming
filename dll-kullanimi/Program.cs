using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_kaynak;

namespace dll_kullanimi
{
    //dll_kaynak ta oluşturulan personel sınıfına erişim
    class Program
    {
        static void Main(string[] args)
        {
            //Personel personel = new Personel();
            //personel.Ad = "public";
            //personel.NO = 1; //get set kapsülleme erişimi

            ////////////////////

            
            Console.WriteLine("Kaç saat çalıştınız?");
            double _Saat = double.Parse(Console.ReadLine());
            Console.WriteLine("Saatlik ücretiniz?");
            double _SaatlikUcret = double.Parse(Console.ReadLine());

            Personel<double> personel = new Personel<double>(_Saat, _SaatlikUcret);
            personel.MaasHesapla(ref _Saat, ref _SaatlikUcret);
            personel.Goster(_SaatlikUcret);

            




        }
    }
}
