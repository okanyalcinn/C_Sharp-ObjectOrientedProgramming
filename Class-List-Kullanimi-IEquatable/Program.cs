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
            Kisim kisim = obj as Kisim; //obj kisim sinifinin bir üyesi mi?
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

            List<Kisim> kisim = new List<Kisim>();
            kisim.Add(new Kisim() {KisimSira = 10, KisimAdi = "Demo" });

            foreach (Kisim item in kisim)
            {
                Console.WriteLine(item);
            }
        }
    }
}
