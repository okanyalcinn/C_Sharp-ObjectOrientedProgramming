using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ogrenci_ornek
{
    interface IKisi
    {
        int No { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
        int Hesapla(int y, int b);  //metod
    }
    interface IOgrenci
    {
        int KursNo { get; set; }
        int DersNotuHesabi(int n1, int n2);
    }
    interface IEgitmen
    {
        int PortalNo { get; set; }
        int DerSuresi(int saat);
    }
    class Program : IKisi, IOgrenci, IEgitmen
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int KursNo { get; set; }
        public int PortalNo { get; set; }

        static void Main(string[] args)
        {
        }

        public int DersNotuHesabi(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public int DerSuresi(int saat)
        {
            throw new NotImplementedException();
        }

        public int Hesapla(int y, int b)
        {
            throw new NotImplementedException();
        }
    }
}
