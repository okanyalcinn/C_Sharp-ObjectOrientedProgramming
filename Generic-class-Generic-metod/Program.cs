using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class_Generic_metod
{
    /*Generic Metod kendisine müracaat edildiği zaman, müracat esnasından gönderilen değer tipini baz alır ve ona göre davranır    
     *Generic method tanımlandığında içerisine gelen değerlerin ne tipli olacağını belirlemek için aşağıdaki tanımlamalar kullanılabilir 
     * 
     *  where T:<ifade>
     *  
     *  where T:class = T'nin System.ValueType tipinde olması gerektiğini belirtmek için kullanılır
     *  
     *  where T:new() = T'nin default constructor (yapıcı metod) olması gerektiğini belirtmek için kullanılır
     *  
     *  where T:struct = T'nin System.ValueType tipinde olması gerektiğini belirtmek için kullanılır
     *  
     *  where T:NameOfBaseClass = yerine bir sınıf ismi yazılır ve T'nin bundan türetilmiş olması gerekiyor
     *  
     *  where T:NameOfInterface = bunun yerine interface ismi yazılır T'nin bu interface'yi veya birden çok interface'leri implement etmiş olması gerekir
     *  
     *  where → Generic metoda gönderilecek tipin nereden alınacağını bildirme (yazılımcılar için bir nevi klavuz class'tan bu değişkenin tipini almayı zorunlu kılabiliriz) 
     *  */
    public class Koordinat<T> //where T:class
    {
        private T x;
        private T y;        
        public Koordinat(T xDeger, T yDeger)
        {
            x = xDeger;
            y = yDeger;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    class Program
    {
        static void DegisMetin(ref string b, ref string c)
        {
            string a;
            a = b;
            c = a;
            Console.WriteLine(c);
        }
        static void DegisSayi(ref int b, ref int c)
        {
            int a;
            a = b;
            c = a;
            Console.WriteLine(c);
        }
        static void Degis<T>(ref T ifade1, ref T ifade2)
        {
            T a;
            a = ifade1;
            ifade2 = a;
            Console.WriteLine(ifade1);
        }
        static void Main(string[] args)
        {
            string deger1 = "metin1";
            string deger2 = "metin2";

            DegisMetin(ref deger1, ref deger2);

            int deger11 = 1;
            int deger22 = 3;

            DegisSayi(ref deger11, ref deger22);

            Console.WriteLine("--degis string --");
            Degis<string>(ref deger1, ref deger2);
            Console.WriteLine("--degis int --");
            Degis<int>(ref deger11, ref deger22); // Degis(ref deger11, ref deger22);

            Console.WriteLine("--yapıcı metod--");
            Koordinat<int> koordinat = new Koordinat<int>(50, 30);
            Koordinat<Double> koordinat1 = new Koordinat<double>(50.50, 30.30);
            Koordinat<string> koordinat2 = new Koordinat<string>("aaaa", "bbb");

            Console.ReadKey();
        }
    }
}
