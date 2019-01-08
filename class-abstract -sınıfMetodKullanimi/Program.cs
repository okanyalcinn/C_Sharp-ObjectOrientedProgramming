using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_abstract__sınıfMetodKullanimi
{
    //polimorfizm
    // Abstract Sınıf ve metodlar
    /* Abstract Class, ortak özellikleri onlardan miras almış olan sınıflara Base (taban) olma görevini üstlenir
     * Bir projede birden çok sınıfta aynı metodlardan çok fazla istifade etmek istiyorsanız bu durumda abstract class tanımlanır ve buradan base alan tüm sınıflar
     *      bu abstract class içerisindeki tüm alanları kullanma imkanı sağlar
     * 
     * -- Abstract sınıflardan Base olduğu için nesne türetilemez
     * -- İçerisinde metot tanımlarken Abstract ifadesi kullnılır varsa parametre eklenir
     * -- metod içeriği davet edildiği sınıf içerisinde doldurulur
     * orn: 
     * public abstract class Sinif1
     * {
     *      public abstract int M1(int a)
     * }
     * 
     * public class Sinif3: Sinif1
     * {
     *      public override int M1(int a)
     * }
     * Base = ona bağlı olan Base (taban) sınıfın öğelerine bir sonraki miras alan sınıftan erişim sağlaması durumunda kullanılır
     *
     * Abstract metod
     * Abstract metodlar sadece abstract sınıflarda türetilebilir/ oluşturulabilir.
     * Abstarct sınıftan kalıtım alan sınıf bu sınıfta oluşturulan metodu override etmelidir.
     * -- Abstract  metodlar private olarak kullanılamaz 
     * 
     * 
     * */

    public abstract class Ucak
    {
        public int UcakHizi { get; set; }
        //public int UCAK
        //{
        //    get { return UcakHizi; }
        //    set { value = UcakHizi; }
        //}
        public int hiziAl()
        {
            return UcakHizi;
        }
        public void hiziYaz(int UcakHizi)
        {
            this.UcakHizi = UcakHizi;
        }
        public abstract int HizHesabi(int a);
    }
    class YolcuUcagi : Ucak
    {
        public override int HizHesabi(int a)
        {
            int hiz = (hiziAl() * a) / 2;
            return hiz;
            //throw new NotImplementedException();
        }
    }
    class SavasUcagi : Ucak
    {
        public override int HizHesabi(int a)
        {
            int hiz = hiziAl() * a;
            return hiz;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            int hiz = 0;
            string sayi = "0";
            Console.WriteLine("Sayı gir");
            ConsoleKeyInfo karakter;
            // klavyeden girilen sayı mı değiş mi kontrolü        
            do
            {
                karakter = Console.ReadKey(true);
                if (karakter.Key != ConsoleKey.Backspace)
                {
                    bool kontrol = int.TryParse(karakter.KeyChar.ToString(), out hiz);
                    if (kontrol)
                    {
                        sayi += karakter.KeyChar;
                        Console.Write(karakter.KeyChar);
                    }
                    else
                    {
                        if(karakter.Key == ConsoleKey.Backspace && sayi.Length >0)
                        {
                            sayi = sayi.Substring(0, (sayi.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
            } while (karakter.Key != ConsoleKey.Enter);

            SavasUcagi savasUcagi = new SavasUcagi();
            savasUcagi.hiziYaz(hiz);
            Console.WriteLine(savasUcagi.HizHesabi(savasUcagi.UcakHizi));

            YolcuUcagi yolcuUcagi = new YolcuUcagi();
            yolcuUcagi.hiziYaz(hiz);
            Console.WriteLine(yolcuUcagi.HizHesabi(yolcuUcagi.UcakHizi));
            Console.ReadKey();
        }
    }
}
