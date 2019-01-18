using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqGroupBy();

            //LinqGroupBy1();

            Kiyaslama kiyaslama = new Kiyaslama();
            kiyaslama.LinqComparer();
        }
        static void LinqGroupBy()
        {
            int[] numaralar = { 0, 212, 2, 223, 522, 6, 8 };
            var numaraGrup = from n in numaralar group n by n % 5 into g select new { Kalan = g.Key, Numara = g };

            foreach (var g in numaraGrup)
            {
                Console.WriteLine("{0} e bölündüğünde {1} kalanı veren sayılar grubu", g.Numara, g.Kalan);
            }
        }
        static void LinqGroupBy1()
        {
            string[] kelimeler = { "apple", "samsung", "sony" };
            var kelimeGrup = from n in kelimeler orderby n group n by n[0] into c
                             select new
                             {
                                 ilkHarf = c.Key,
                                 kelime = c
                             };
            
            foreach (var harf in kelimeGrup)
            {
                Console.WriteLine(harf.ilkHarf);
                foreach (var harf1 in harf.kelime)
                {
                    Console.WriteLine(harf1);
                }
            }
        }
    }
    
    public class Kiyaslama : IEqualityComparer<string>
    {
        public void LinqComparer()
        {
            string[] ogeler = { "kitap ", " defter", "silgi ", "  cetvel" };
            var siralamaGrup = ogeler.GroupBy(x => x.Trim(), new Kiyaslama());
            foreach (var item in siralamaGrup)
            {
                Console.WriteLine(item.Key);
            }            
        }
        public string getKiyasla(string kelime)
        {
            char[] kelimelerHarf = kelime.ToCharArray();
            Array.Sort<char>(kelimelerHarf);
            return new string(kelimelerHarf);
        }

        public bool Equals(string x, string y)
        {
            return getKiyasla(x) == getKiyasla(y);
            //throw new NotImplementedException();
        }

        //key tablosunda oluşturulan tablo değerlerinin teker teker geri dönüşü sağlanıyor
        public int GetHashCode(string obj)
        {
            return getKiyasla(obj).GetHashCode();
            //throw new NotImplementedException();
        }
    }
}
