﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar_kullanimlari_tanimi
{
    class Program
    {
        /* 
         * Sysyem.Collections
         * 
         * Generic Collections                  Non-Generic Collections
         * Queue<Type>                          Queue
         * SortedDictionary<Key,T>              SortedList
         * Stack<T>                             Stack
         * List<T>                              ArrayList
         * Dictionary<K,T>                      Hashtable
         * 
         * Non-Generic koleksiyonlar elemanlarını object tipli aldıkları için Boxing işlemine maruz kalır. 
         *   Boxing işlemine maruz kaldığı için unboxing işlemi yaparız. 
         * Koleksiyonumuzda bazen tek tipli değerler girilirse bu Non-Generic oluyor haliyle 
         *   Boxing ve unboxing işlemi uygulandığı için performans olarak daha yavaş çalışır
         *   
         * Generic koleksiyonlarda ise tanımlanan nesnelerin taşıdığı değerler kümesinin tiplerini bildiğimiz için.
         *   Boxing ve un-boxing işlemine maruz kalmaz direkt olarak erişim sağlanır, bu durumda performans artışı kaçınılmaz,
         *   aynı zamanda daha güvenlidir
         * 
         * 
         * 
         * Generic(genel amaçlı koleksiyonlar) Collections
         *  -Diziler değer bazlı aynı tip elemanları barındırır
         *  -Koleksiyonlar ise referans tipli new ahahtar sözcüğü ile nesne türetebilir, aynı zamanda dizilerin 
         *      aksine koleksiyon olarak türetilen nesneye birden çok nesne bağlanabilir, n tane gider
         *  
         *  -Değer tipli: int,float, double, short, byte, enum, char, struct
         *  -Referans tipli: string, object, delegate, interface, class, var
         *  
         * ArrayList
         * 
         * -Sınırlı fakat dinamik değişebilir dizi olarak tanımlanabilir
         * 
         * 1-Dizi boyutları sınırlı ve sabittir
         * 2-Dizinin tüm elemanları aynı türden olur
         * 3-Ram de uzunluğu kadar yer tutarlar
         * 
         * •ArrayList ile normal dizi arasındaki fark
         *   -Dizinin değer uzunluğu kadar ram de yer tutar, 
         *          olaki dizi değerlerinin dışına çıkılırsa da bu değer arrayLisette tutulur,
         *          bu normal int[] i gibi tanımlarda index taşma hatası verir.
         *   -ArrayList object türünde olduğu için, tüm yapıları (int, string, float) bünyesinde barındırabilir. 
         *          Gönderdiğin tipte değeri tutar (int gönderildiyse int olarak tutar)
         * 
         * •List Kullanımı
         *   Liste dizilerinin aksine Liste oluşturma, Listeye eleman ekleme, silme, sıralama, arama gibi işlemleri kendi barındırır.
         *          daha komplike daha komplex yapıları içerisinde barındırabilir.
         *   Kullanımı:
         *      List<string> liste = new List<string>();
         *      List<tipi> nesne = new List<tipi>();
         *      
         * Queue - Kuyruk
         *      İlk giren ilk çıkar algoritmasına haizdir (sahiptir)
         *      Kuyruk yapısı (first-in  first-out), FIFO prensibine göre çalışır         
         *      enqueue(arka sıraya katılma)
         *      dequeue(sırayı önden terkeder)
         *  Kullanımı 
         *    Queue qu = new Queue(5)
         *    qu.enqueue("demo");
         *    qu.enqueue("demo1");
         *    qu.enqueue("demo2");
         *    cw(qu.dequeue()); ilk giren ilk çıkar mantığından dolayı → ekrana demo yazar
         *    cw(qu.dequeue()); demo1 ekrana yazar
         *    
         * 
         * Stack - yığın yapısı
         *      ilk giren son çıkar algoritmasına haizdir (sahiptir)
         *      yığın yapısı vardır burada (lasft-in, first-out) LIFO prensbine göre çalışmaktadır
         *  Kullanımı
         *    Stack st = new Stack(5);
         *    st.Push("demo");
         *    st.Push(123456456);
         *    st.Push(true);
         *    st.Push('d');
         *    st.Push(5.5);
         *    cw(st.Pop());
         * 
         * SortedList Kullanımı
         *  SortedList(Sıralı liste) Sınıfı hastable ile aynı özellikleri gösterir
         *  SortedList anahtar ve value şeklinde verileri tutar ve sıralama işleminde anahtara göre sıralamayı otomatik yapar
         *  
         *  kullanımı
         *  SortedList not = new SortedList();
         *  not["matematik"] = 100;
         *  not["fizik"] = 50;
         *  
         *  not[53] = "rize";
         *  
         *  foreach(var item in not)
         *      string ders = (string)item.Key
         *      int not = (int)item.Value
         *  
         *  HashTable Kullanımı 
         *  HashTable (karışık içerikler) veriler key-value ilişkisi ile tutulur (anahtar değer şeklinde) veriler datayı barındırır.
         *  
         *  Key tablosunu ayrı bir tabloda değerler ise value tablosunda tutulur
         *  
         *  Hashtable ders = new Hastable();
         *  
         *  ders["mat"] = 50;
         *  ders["fizik"] = 70;
         *  
         *  foreach(var item in not)
         *      string ders = (string)item.Key
         *      int not = (int)item.Value
         *  
         * 
         * */
        static void Main(string[] args)
        {
        }
    }
}
