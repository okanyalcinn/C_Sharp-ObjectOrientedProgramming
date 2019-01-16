using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq; //xml ile çalışma

namespace xml_serialization_deserializasyon
{
    class Program
    {
        /* XML nedir ne işe yarar !
         * 
         * Yapısal nod'lar kullanılan bir metinsel dosya biçimleridir
         * 
         * Oluşturulan mekanizmayı xml serileştirmesiyle düzenli bir veri akışı sağlanır ve kaydı tutulur
         * 
         * Oluşturulan mekanizma sayesinde xml deserializasyona da bu verinin düzenli sıralı ve hızlı bir şekilde geri okuma ve erişim sağlanır
         * 
         * node - nokta : o sınıfa ait fieldları temsil eder
         * root - o sınıfın kendisini temsil eder
         * 
         * */
        static void Main(string[] args)
        {
            // xml yapısı
            XDocument document = new XDocument();
            //alan ekleme işlemi
            document.Add(new XElement("Pc",
                new XElement("Hp",

                new XElement("Model", 500),
                new XElement("Fiyat", 500)),

                new XElement("Acer",

                new XElement("Model", 210),
                new XElement("Fiyat", 1400))
                ));

            document.Save("pc.xml");
            
        }
    }
}
