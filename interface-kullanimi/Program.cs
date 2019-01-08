using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_kullanimi
{
    /* Interface nedir?
     * Davet edildiği classlarda yönlendirici/ şekillendirici görevini üstlenen bir yapıdır.
     *      yazım şekli → Iad  (kod ahlakına uygunluk için büyük I ile başlatılmalı)
     * Classlar birden çok Interface eklerken " , " ile ayırarak kullanılır
     * Bir class sadece bir classtan kalıtım alabilir, fakat Interfaceler birden çok sınıftan kalıtım alabilir
     * 
     * içerisine herhangi kod satırı eklenemez, sadece tanımlamalar yapılır
     * Interface davet edilen sınıfın tüm özellikleri Implement etmek zorundadır. (eklemek zorunda)
     * Bir arayüzü başka bir arayüzden türetebiliriz, classtan ya da struct'tan türetemeyiz.
     * 
     * Interfaceler Public olarak kabul edilir aksi halde hata alınır
     * 
     * Implicity : Hangi Interfaceten geldiğini bilmeden Import etme
     * Explicity : Hangi Interfaceten geldiğini bildirir o şekilde açık Import yapar
     * 
     * 
     * 
     * */
    interface IBilgi
    {
        string Ad { get; set; }
        void M1();
        void M2();
    }
    class Ornek : IBilgi
    {
        public string Ad { get; set; }
        public void M1()
        {
            Console.WriteLine("M1");
        }
        public void M2()
        {
            Console.WriteLine(Ad);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Ornek();

            ornek.Ad = "demo";
            ornek.M1();
            ornek.M2();

        }
    }
}
