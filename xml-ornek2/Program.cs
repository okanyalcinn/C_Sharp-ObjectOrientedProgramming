using System;
using System.Collections.Generic;
using System.IO; //
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; //
using System.Xml.Serialization; //


/// <summary>
/// Gelen veriyi serialleştirme işlemi için kullanılıyor
/// </summary>
namespace xml_ornek2
{
    public class Kisi
    {
        public string ad { get; set; }
        public string soyad { get; set; }
    }
    class Program
    {
        public string XML_Ser(object bilgiler)
        {
            string XmlBilgi = "";

            // xml document nesnesi belgesi
            XmlDocument belge = new XmlDocument();
            // xml yapısını buraya gelen serializer üzerinden tiplerini alıyor
            XmlSerializer serializer = new XmlSerializer(bilgiler.GetType());
            // Ram de bizim için yer ayırma işlemi yapıyoruz. bunu geçici bellek olarak kullancağız
            MemoryStream memory = new MemoryStream();

            try
            {
                serializer.Serialize(memory, bilgiler); //gelen datayı serileştiriyoruz 

                memory.Position = 0; // ram de başlangıç pozisyonlama

                belge.Load(memory); // memory kanalındaki bilgiler xml belge nesnesine yüklüyoruz

                XmlBilgi = belge.InnerXml; // xmlBilgi değişkenine belge nesnesinin tüm verilerini yüklüyor                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata " + ex);
                throw;
            }
            
            memory.Close();
            memory.Dispose(); // ram de sil

            return XmlBilgi;

        }
        /// <summary>
        /// Bu metod parametre olarak Kisi sınıfının tiplerini alacak Type Kişiler
        /// </summary>
        /// <param name="a"></param>
        /// <param name="kisiler"></param>
        /// <returns></returns>
        public Kisi XML_Deser(string xmlData, Type kisiler)
        {
            Kisi dKisi = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(kisiler);
                using (TextReader oku = new StringReader(xmlData))
                {
                    dKisi = (Kisi)serializer.Deserialize(oku);
                }
            }
            catch(ArgumentException Aex)
            {
                Console.WriteLine(Aex.Source);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
            }
            return dKisi;
        }
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            kisi.ad = "Hakan";
            kisi.soyad = "Pehlivanlar";
            
            // yazdırma
            Program p = new Program();
            Console.WriteLine(p.XML_Ser(kisi));

            // geri okuma
            Kisi kisioku = p.XML_Deser(p.XML_Ser(kisi),kisi.GetType());
            Console.WriteLine(kisioku.ad + " "+ kisioku.soyad);
            
        }
    }
}
