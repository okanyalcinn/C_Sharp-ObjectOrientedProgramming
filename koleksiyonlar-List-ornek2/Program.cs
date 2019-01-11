using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar_List_ornek2
{
    // sınıf pc markaları -ram -işlemci -
    // sınıf asus -ses sistemi özelliği -ekran türü -tasarım -fiyat metod (dolar bazında hesap)
    public enum Emarkalar : byte { Asus, Hp }        
    class EkranaYazdir
    {        
        public EkranaYazdir(List<Asus> marka)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Asus> asus = new List<Asus>();
            Asus pcAsus = new Asus();

            List<Hp> hp = new List<Hp>();
            Hp pcHp = new Hp();

            Console.WriteLine("hangi marka girişi yapılacak?");
            Console.WriteLine("[1]" + Emarkalar.Asus);
            Console.WriteLine("[2]" + Emarkalar.Hp);
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("İşlemci gir");
                    pcAsus.islemci = Console.ReadLine();
                    Console.WriteLine("model gir");
                    pcAsus.model = Console.ReadLine();
                    Console.WriteLine("Ram gir");
                    pcAsus.ram = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ses sistemi gir");
                    pcAsus.sesSistemi = Console.ReadLine();
                    Console.WriteLine("Tasarım gir");
                    pcAsus.tasarim = Console.ReadLine();
                    Console.WriteLine("Ekran türü gir");
                    pcAsus.ekranTuru = Console.ReadLine();
                    Console.WriteLine("Fiyat gir");
                    pcAsus.fiyat = int.Parse(Console.ReadLine());
                    Console.WriteLine("dolar kuru gir");
                    pcAsus.dolar = double.Parse(Console.ReadLine());
                    pcAsus.FiyatNet = pcAsus.Fiyat(pcAsus.fiyat, pcAsus.dolar);
                    

                    asus.Add(pcAsus);
                    Console.WriteLine("\nAsus Model Bilgisayarlar----------------------- ");
                    Console.WriteLine("\nModel \tİslemci \tRam \tSes sitemi \tTasarım \tEkran türü \tFiyat ");
                    for (int i = 0; i < asus.Count; i++)
                    {
                        Console.WriteLine(asus[i].model + " \t" + asus[i].islemci + " \t \t" + asus[i].ram + " \t" + asus[i].sesSistemi + " \t \t" + asus[i].tasarim + " \t \t" + asus[i].ekranTuru + "  \t\t" + asus[i].FiyatNet + " \t");
                    }
                    break;
                case 2:
                    pcHp.islemci = "i7";
                    pcHp.model = "h100";
                    pcHp.ram = 12;
                    pcHp.sesSistemi = "belirsiz";
                    pcHp.tasarim = "ofis";
                    pcHp.ekranTuru = "led";
                    pcHp.FiyatNet = pcHp.Fiyat(455, 5.34);

                    hp.Add(pcHp);
                    Console.WriteLine("\nHp Model Bilgisayarlar----------------------- ");
                    Console.WriteLine("\nModel \tİslemci \tRam \tSes sitemi \tTasarım \tEkran türü \tFiyat ");
                    for (int i = 0; i < hp.Count; i++)
                    {
                        Console.WriteLine(hp[i].model + " \t" + hp[i].islemci + " \t \t" + hp[i].ram + " \t" + hp[i].sesSistemi + " \t \t" + hp[i].tasarim + " \t \t" + hp[i].ekranTuru + "  \t" + hp[i].FiyatNet + " \t");
                    }
                    break;
                default:
                    break;
            }

            

            
        }
    }
}
