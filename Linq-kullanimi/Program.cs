using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_kullanimi
{
    /* Linq (.NET dillerine entegre sorgu)
     * 
     * Tasarım olarak SQL sorgulama mimarisine sahip bir sorgulama mekanizmasıdır.
     * Linq Sorgularınızı açık bir şekilde yazabileceğiniz gibi kullanıma 
     *      sunulmuş belli başlı metodlar vasıtasıyla da kullanımı mümkündür.
     * 
     * Linq sorgusu esnasında oluşturulan yapıyı bir nangeneric List ya da generic List< >  veyahut toArray(); yapısına çevirebiliriz
     *
     * .NET Framework 3.5 ile kullanıma başlamıştır
     * 
     * Linq ile bu tanımlamalar kullanılabilir
     * - var
     * - IEnumarable 
     * - IQuaryable
     *  
     *   - Verileri sorgulayabilirsiniz
     *   - Seçip sıralayabilirsiniz
     *   - Bu sorgudan elde edilmiş veriyi işleyebilir kullanıcının hizmetine sunabilirsiniz.
     *   
     * Lambda operatörü ( => )
     * Lambda ifadesi alınan her değer için var olan mekanizmayı her seferinde kullanmak 
     * yerine doğrudan bu operatçr ile kullanım sağlarız
     * 
     * */
    class LambdaKullan
    {
        delegate int Hesapla(int a, int b);
        static void Hesaplama()
        {
            Hesapla hesapla = (sayi1, sayi2) => sayi1 + sayi2;
            
            Console.WriteLine(hesapla.Invoke(10,50));
         }
        //static void Topla(Hesapla islem)
        //{
        //    Console.WriteLine(islem.Invoke(5,6));
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //p.LSelect();

            //p.LSelect2();

            //p.ListDuzenle();

            //p.LSelec3();

            //LambdaKullan lambdaKullan = new LambdaKullan();

            //p.LinqIndex();

            p.LinqFilter();

            p.LinqCompound();

    }
        public void LSelect()
        {
            int[] numaralar = { 5, 6, 4, 8, 9, 10 };            
            //          from temsilci adı       select şartlar..
            //                            SQL,
            //                            XML,
            //                            HTML,
            //                            Json
            var numaraDeger = from no in numaralar select no + 1;

            Console.WriteLine("Numaralar");
            foreach (var item in numaralar)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("");

            Console.WriteLine("No+1");
            foreach (var item in numaraDeger)
            {
                Console.Write(item+" ");
            }
        }

        public void LSelect2()
        {
            int[] numaralar = { 0, 1, 7, 2, 3, 4, 5, 6 };
            string[] kelimeler = { "Sıfır", "bir", "on", "iki", "üc", "dört", "bes", "altı" };
            
            //textAl nesnesini oluşturduk
            //kelimlerin içinden n idexine göre değer aldık
            var textAl = from n in numaralar select kelimeler[n];

            foreach (var item in kelimeler)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n------------");
            foreach (var item in textAl)
            {
                Console.Write(item +" ");
            }
        }

        public void ListDuzenle()
        {
            string[] kelimeler = { "Apple", "WinDOws", "huaWei" };
            //                                       new anahtar sözcüğü ile ilgili index elamanına bağlı 
            var duzenle = from k in kelimeler select new { Buyuk = k.ToUpper(), Kucuk = k.ToLower() };

            foreach (var item in duzenle)
            {
                Console.Write(item.Buyuk+ " ");
            }
            Console.WriteLine("\n----------");
            foreach (var item in duzenle)
            {
                Console.Write(item.Kucuk + " ");
            }
        }

        public void LSelec3()
        {
            int[] numaralar = { 0, 1, 7, 2, 3, 4, 5, 6 };
            string[] kelimeler = { "Sıfır", "bir", "on", "iki", "üc", "dört", "bes", "altı" };

            var secim = from no in numaralar
                        select new
                        {
                            Sayi = kelimeler[no],
                            Basamak = (no % 2 == 0)
                        };
            foreach (var item in secim)
            {
                Console.WriteLine("Sayi {0} , {1} dir",item.Sayi, item.Basamak ? "çift" : "tek");
            }
        }
        //select index
        public void LinqIndex()
        {
            int[] numaralar = { 0, 1, 7, 2, 3, 4, 5, 6 };
            //verilen dizi değer ile index sıralaması aynı olup olmadığını kontrol eden mekanizmadır
            var dogruIndexMi = numaralar.Select((num, index) => new { Numara = num, VarMi = (num == index) });
            Console.WriteLine("durum");
            foreach (var item in dogruIndexMi)
            {
                Console.WriteLine("{0} , {1}",item.Numara, item.VarMi);
            }
        }
        //select - filter
        public void LinqFilter()
        {
            int[] numaralar = { 0, 1, 7, 2, 9, 4, 5, 6 };
            string[] kelimeler = { "Sıfır", "bir", "on", "iki", "üc", "dört", "bes", "altı" };
            var sorliAl = from no in numaralar where no < 5 select kelimeler[no];
            foreach (var item in sorliAl)
            {
                Console.WriteLine(item);
            }
        }
        //select - compound
        public void LinqCompound()
        {
            int[] numaralar1 = { 0, 1, 7, 2, 3, 4, 5, 6 };
            int[] numaralar2 = { 0, 8, 2, 2, 3, 4, 5, 6 };

            var esit = from no1 in numaralar1
                       from no2 in numaralar2
                       where no1 == no2
                       select new { no1, no2 };

            foreach (var item in esit)
            {
                Console.WriteLine("{0} , {1}",item.no1, item.no2);
            }
        }
    }
}
