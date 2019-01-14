using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_ornek3
{
    //tek sınıf buraya gelen değerlere göre string  ya da integer geri dönecek
    public class Goster<T>
    {
        private T deger { get; set; }
        public T degerGonderme
        {
            get
            {
                return deger;
            }
            set
            {
                deger = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Goster<int> goster = new Goster<int>();
            Console.WriteLine(goster.degerGonderme = 500); 

            Goster<string> goster2 = new Goster<string>();
            Console.WriteLine(goster2.degerGonderme = "sasa"); 
        }
    }
}
