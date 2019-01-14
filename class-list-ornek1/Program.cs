using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_list_ornek1
{
    // List<T> koleksiyonların kalıtım (inheritance) yapısını göstermektedir
    // Kalıtım yönetimiyle List<T> koleksiyonun kazandığı özellikler aşağıdakiler
    /*
     *  T tipindeki objeleri koleksiyona Add ve Insert
     *  Silme(Removal) metodları
     *          Remove, RemoveAt, RemoveRange, RemoveAll
     *
     *  Sıralama (sort)
     *  Sort (Comparision)
     *  Reverse
     *  
     *  Çevirim (Conversion) metodlar
     *  ConvertAll (Converter<T>)
     *  
     *  CopyTo( T[] )
     *  
     *  Arama ( Predicate<T>     
     *  Exists
     *  FindAll
     *  FindLast
     *  FindIndex
     *  FindLastIndex
     *  IndexOf
     *  LastIndexOf     
     *  TrueForAll
     *  Equals
     *  
     *  döngü mekanizması
     *  Foreach(Action<T>)
     *  örnek1: → class ornek1 bak
     *  
     *  
     *  Sık kullanılan Generic Class ve Interface'ler
     *  Collection<T>
     *  ICollection<T> - Generic koleksiyon için ana (base) sınıf desteği sağlar
     *  
     *  -----------------
     *  Comperer<T>
     *  IComperer<T>
     *  IComparable<T> - Aynı Generic tipteki iki objenin eşitlik (equivalence) ve sıralama sort (Sorting)
     *  
     *  -----------------
     *  Dictionary<Key, Value>
     *  IDictionary<Key, Value> - Key/ Value çiftinden oluşur erişim tutulur, erişim key bazında sağlanır
     *  
     *  Dictionary<KEy,Value>.KeyCollection
     *  Dictionary<KEy,Value>.ValueCollection
     *  -----------------
     *  
     *  LinkedList<T> - birbirine bağlı listeleri temsil eder
     *  -----------------
     *  IEquatable<T> - koleksiyon üzerinde silme arama tarama işlemlerini gerçekleştirmek için kullanılır
     *          
     * */
    class Ornek1
    {
        public void M()
        {
            Dictionary<string, int> yaz = new Dictionary<string, int>();
            yaz["bir"] = 1;
            yaz["iki"] = 2;
            var degerGir = new Dictionary<int, string> { { 1, "demo1" }, { 2, "demo2" } };
            foreach (KeyValuePair<string,int> item in yaz)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }
        }
    }
    class Kisi
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            List<Kisi> kisis = new List<Kisi>();
            kisis.Add(new Kisi { No = 50, Ad = "Okan", Soyad = "Yalçın" });

            Console.WriteLine("------");
            Kisi kisi = new Kisi();
            kisi.No = 55;
            kisi.Ad = "Serkan";
            kisi.Soyad = "Yalçın";

            kisis.Add(kisi);
        }
    }
}
