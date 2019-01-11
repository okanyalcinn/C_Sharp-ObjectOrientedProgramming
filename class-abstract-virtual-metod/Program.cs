using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_abstract_virtual_metod
{
    class Program
    {
        // Virtual metod (sanal metodlar), base class (temel sınıf) 
        // içinde bildirilmiş vede ondan türetilmiş class içinde de tekrar türetebilen metotlardır.
        // Polimorfizm (çok biçimlilik)

        static void Main(string[] args)
        {
            Para para = new Para();  
            
            Para parayeni = para;
            parayeni.ParaCek(5.5,2);

            Havale havale = new Havale();
            parayeni = havale;
            parayeni.ParaCek(2.2,2.1);

            Eft eft = new Eft();
            parayeni = eft;
            parayeni.ParaCek(4.2,5.4);
        }
    }
    class Para
    {
        public virtual void ParaCek(double a, double b)
        {
            Console.WriteLine("Para Yatırıldı "+ (a+b));
        }
    }
    class Havale :Para
    {
        public override void ParaCek(double a, double b)
        {
            //base.ParaCek(a,b);
            Console.WriteLine("Havale ile para gönderildi " + (a + b));
        }
    }
    class Eft : Para
    {
        public override void ParaCek(double a, double b)
        {
            //base.ParaCek(a,b);
            Console.WriteLine("Eft ile para gönderildi " + (a + b));
        }
    }
}
