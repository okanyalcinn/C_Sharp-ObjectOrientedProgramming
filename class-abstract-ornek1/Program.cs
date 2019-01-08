using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_abstract_ornek1
{
    public abstract class GiysiOzellik
    {
        public int fiyat { get; set; }
        //burada tanımlanan abstract metod, giysiozellik abstract sınıfından kalıtım alan bütün sınıflarda kullanılmak zorundadır.
        public abstract int FiyatM(int fiyat);

    }

    public class SporGomlek : GiysiOzellik
    {
        public override int FiyatM(int fiyat)
        {
            int a = fiyat * 36;
            return a;
        }
    }
    public class KlasikGomlek : GiysiOzellik
    {
        public override int FiyatM(int fiyat)
        {
            int a = fiyat * 10;
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KlasikGomlek klasikGomlek = new KlasikGomlek();
            klasikGomlek.fiyat = 5; //giysiOzellik classta tanımlanan fiyat alanına atama yaptırılıyor. ama bu sadece klasikgomlek sınıfına ait bir değer olmuş oluyor
            Console.WriteLine(klasikGomlek.FiyatM(klasikGomlek.fiyat));


            SporGomlek sporGomlek = new SporGomlek();
            sporGomlek.fiyat = 15; //giysiOzellik classta tanımlanan fiyat alanına atama yaptırılıyor. ama bu sadece sporGomlek sınıfına ait bir değer olmuş oluyor.
            Console.WriteLine(sporGomlek.FiyatM(sporGomlek.fiyat));
            Console.ReadKey();
        }
    }
}
