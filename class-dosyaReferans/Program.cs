using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_dosyaReferans.Demo; // bunu tanımlaman gerekiyor farklı bir klasör olduğu için

namespace class_dosyaReferans
{
    class Program
    {
        static void Main(string[] args)
        {
            YolcuUcagi yolcuUcagi = new YolcuUcagi();
            SavasUcaklari savasUcaklari = new SavasUcaklari();

            //Console.WriteLine("Yolcu sayısını gir");
            //yolcuUcagi.YolcuSayisi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Personel sayısını gir");
            //yolcuUcagi.PersonelSayisi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Uzunluğu gir");
            //yolcuUcagi.Uzunluk = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ağırlık gir");
            //yolcuUcagi.Agirlik = int.Parse(Console.ReadLine());
            //Console.WriteLine("Yükseklik sayısını gir");
            //yolcuUcagi.Yukseklik = int.Parse(Console.ReadLine());

            yolcuUcagi.YolcuUcakBilgi();

            Console.WriteLine("Pilot adını gir");
            savasUcaklari.PilotAdi = Console.ReadLine();
            Console.WriteLine("Yönü gir");
            savasUcaklari.Yon = Console.ReadLine();
            Console.WriteLine("Uzunluğu gir");
            savasUcaklari.Uzunluk = int.Parse(Console.ReadLine());
            Console.WriteLine("Ağırlık gir");
            savasUcaklari.Agirlik = int.Parse(Console.ReadLine());
            Console.WriteLine("Yükseklik sayısını gir");
            savasUcaklari.Yukseklik = int.Parse(Console.ReadLine());

            savasUcaklari.SavasUcakBilgi();

            //demo klasöründen
            //DSinif dsinif = new DSinif();
            //dsinif.no = 5;
            DSinif dsinif = new DSinif()
            {
                no = 5, // Dsınıf tan geliyor
                Agirlik = 10, //bu özellikler ucaklar sınıfıda 
                Uzunluk = 5, 
                Yukseklik = 10
            };


        }
    }
}
