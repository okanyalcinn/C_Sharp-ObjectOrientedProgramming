using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_virtual_base_ornek2
{
    /* not sistemi
     *  notlar sınıfı
     *  1. dönem sınıfın
     *  2. dönem sınıfın
     * 
     * 
     * */   
    public class Hazirlik
    {
        public double not1 { get; set; }
        public double not2 { get; set; }
        public virtual void NotHesaplama(double n1, double n2)
        {
            Console.WriteLine("1. not: " + n1);
            Console.WriteLine("2. not: " + n2);
            Console.WriteLine("Hazirlik dönemi ortalaması: " + ((n1 + n2) / 2));
        }
    }
    public class Donem1:Hazirlik
    {
        public override void NotHesaplama(double n1, double n2)
        {
            Console.WriteLine("1. not: " + n1);
            Console.WriteLine("2. not: " + n2);
            Console.WriteLine("1. dönem ortalaması: " + ((n1 + n2) / 2));
        }
    }
    public class Donem2:Hazirlik
    {
        public override void NotHesaplama(double n1, double n2)
        {
            Console.WriteLine("1. not: " + n1);
            Console.WriteLine("2. not: " + n2);
            Console.WriteLine("2. dönem ortalaması: " + ((n1 + n2) / 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Hazirlik hazirlik = new Hazirlik();

            Hazirlik hazirlikyeni = hazirlik;
            hazirlik.NotHesaplama(21, 77);

            Donem1 donem1 = new Donem1();
            hazirlik = donem1;
            hazirlik.NotHesaplama(24, 42);

            Donem2 donem2 = new Donem2();
            hazirlik = donem1;
            hazirlik.NotHesaplama(54, 72);

        }
    }
}
