using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_abstract_ornek2
{
    // ornek kitap türleri roman ve klasik eserler
    // fiyat metodu olsun
    // "isban no"
    public abstract class KitapOzellikleri
    {
        public int fiyat { get; set; }
        public int isbanNo { get; set; }
        public abstract int FiyatM(int fiyat);
        public abstract void KitapIsmi(string ad);
    }
    public class Roman : KitapOzellikleri
    {
        public override int FiyatM(int fiyat)
        {            
            return fiyat;
        }
        public override void KitapIsmi(string ad)
        {
            Console.WriteLine(ad);
        }
    }
    public class KlasikEserler :KitapOzellikleri
    {
        public override int FiyatM(int fiyat)
        {
            return fiyat;
        }
        public override void KitapIsmi(string ad)
        {
            Console.WriteLine(ad);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Roman roman = new Roman();
            Console.WriteLine(" fiyat gir");
            roman.fiyat = int.Parse(Console.ReadLine());
            Console.WriteLine(" isban no gir");
            roman.isbanNo = int.Parse(Console.ReadLine());
            Console.WriteLine(" Roman fiyatı: "+roman.FiyatM(roman.fiyat)+" Isban No: "+ roman.isbanNo);
            roman.KitapIsmi("Alacakaranlık");
            Console.ReadKey();
        }
    }
}
