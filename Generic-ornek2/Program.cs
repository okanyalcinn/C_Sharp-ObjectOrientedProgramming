using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_ornek2
{
    public class Kisi
    {
        public int not { get; set; }
    }
    //TNot, TDurum, TSonuc bu ara TDurum New anahtar sözcüğü ile türetilen nesne üzerinden 
    class Islem<TNot, TDurum, TSonuc>:Kisi where TDurum : new() where TNot : class
    {
        public TNot Not { get; set; }
        public TDurum Durum { get; set; }
        public TSonuc Sonuc { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Sınıfa müracaat edersek tanımlanmış olduğumuz Type'lere göre değer gönderimi sağladık
            Islem<Kisi, int, bool> islem = new Islem<Kisi, int, bool>();
            islem.Not.not = 50;
            islem.Durum = 55;
            islem.Sonuc = true;

            //farklı bir kullanım
            var deger = new Islem<Kisi, int, string>();
            deger.Durum = 78;
        }
    }
}
