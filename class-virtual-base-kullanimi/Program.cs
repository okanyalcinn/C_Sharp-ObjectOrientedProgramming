using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_virtual_base_kullanimi
{
    //bas kullanımı:

    public class Kisiler
    {
        public string ad = "hhh";
        public string soyad = "yalaf";

        public virtual void Bilgiler()
        {
            Console.WriteLine(ad +" \n"+ soyad);
        }
    }
    class Isci:Kisiler
    {
        public int id = 212121;
        public override void Bilgiler()
        {
            base.Bilgiler();
            Console.WriteLine(id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Isci iscii = new Isci();
            iscii.Bilgiler();
        }
    }
}
