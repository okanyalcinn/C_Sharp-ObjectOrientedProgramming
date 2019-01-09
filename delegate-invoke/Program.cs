using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_invoke
{
    // Delegede saklanan metotları senkron şekilde çalıştırır
     
    class Program
    {
        delegate void Temsilci(string deger);
        static void Mesaj(string deger)
        {
            Console.WriteLine(deger);
        }
        static void Main(string[] args)
        {
            // ramde Temsilci için oluşturulan nesne için temsilci oluşturulan alanda 
                    // Mesaj() metoduna çalışma zamanında etki edip Invoke metodu ile değişimini sağlıyoruz
            Temsilci temsilci = x => Mesaj(x);
            temsilci.Invoke("deneme deneme");
        }
    }
}
