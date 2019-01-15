using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_List_Kullanimi_IEquatable
{
    public class Kisim : IEquatable<Kisim>
    {
        public int KisimSira { get; set; }
        public string KisimAdi { get; set; }
        //ToString() metodunu yazarken override edelim //sadece bu sınıf için geçerli bir override işlemi oluyor
        public override string ToString()
        {
            //return base.ToString();
            return "No: " + KisimSira + "KisimAdi: " + KisimAdi;
        }
        // HashTable key ttablosu gibi düşünülebilir
        public override int GetHashCode()
        {
            return KisimSira;
        }
        //Equatable Equals metodunu implement eder arama karşılaştırma esnasında ifade varsa true döndürür. yok ise false döndürür
        public bool Equals(Kisim kisim)
        {
            if (kisim == null)
            {
                return false;
            }
            return (this.KisimSira.Equals(kisim.KisimSira));                    
            throw new NotImplementedException(); //tek satırlık hata yakalama mekanizması
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Kisim kisim = obj as Kisim; //obj kisim sinifinin bir üyesi mi? - Ram de kisim sinifini seçiyoruz
            if (kisim == null)
            {
                return false;
            }
            return Equals(kisim);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Kisim kisim1 = new Kisim();
            
            // Generic bir liste oluşturduk
            List<Kisim> kisim = new List<Kisim>();
            kisim.Add(new Kisim() {KisimSira = 10, KisimAdi = "Demo" });
            kisim.Add(new Kisim() {KisimSira = 11, KisimAdi = "Demo1" });
            kisim.Add(new Kisim() {KisimSira = 12, KisimAdi = "Demo2" });
            kisim.Add(new Kisim() {KisimSira = 13, KisimAdi = "Demo3" });
            kisim.Add(new Kisim() {KisimSira = 14, KisimAdi = "Demo4" });

            Console.WriteLine("-- arama -kisim no 11 var mı?");            
            var a = kisim.Contains(new Kisim { KisimSira = 11 });
            Console.WriteLine(a);

            Console.WriteLine("-- arama -kisim no 11: " + kisim.Contains(new Kisim { KisimSira = 11 }));

            Console.WriteLine("Remove");
            kisim.Remove(new Kisim { KisimSira = 10 });

            foreach (Kisim item in kisim)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("RemoveAt"); 
            kisim.RemoveAt(2); // index numarası siliniyor
            foreach (Kisim item in kisim)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ekrana aktarma");
            Console.WriteLine(kisim[2]);

            Console.WriteLine("Hangi indexi sileceksin?");            
            int sil = int.Parse(Console.ReadLine());
            Console.WriteLine("Silinen bilgi: "+kisim[sil]);
            kisim.RemoveAt(sil);

            Console.WriteLine("index alma");
            Console.WriteLine(kisim.IndexOf(new Kisim() { KisimSira = 565 }));

            //Console.WriteLine(kisim.LastIndexOf(new Kisim() { KisimSira = 13 }));

            //Console.WriteLine(kisim.FindLastIndex(x => x = new Kisim() {KisimSira = 10, KisimAdi = "demo" }));
            
        }
    }
}
