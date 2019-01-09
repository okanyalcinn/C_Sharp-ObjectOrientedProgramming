using System;
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
         * int[] i
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
         *          daha komplike daha komplex yapılaro içerisinde barındırabilir.
         *   Kullanımı:
         *      List<string> liste = new List<string>();
         *      List<tipi> nesne = new List<tipi>();
         *      
         * Queue - Kuyruk
         *      İlk giren ilk çıkar algoritmasına haizdir (sahiptir)
         *      Kuyruk yapısı (first-in  firs-out), FIFO prensibine göre çalışır         
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
         * 
         * */
        static void Main(string[] args)
        {
        }
    }
}
