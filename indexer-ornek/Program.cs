using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_ornek
{
    /*IEnumarable
     * yield iki turlu kullanımı mevcut
     * 
     * yield return<ifade>
     * iteratöre çağrı yapılan foreach döngüsüne bir eleman döndürme işlemi sırasında kullanılır
     * 
     * yield break
     * foreach içerisinde dönerken bulunan değerin ardından iteratöre arama devamını sonlandırmak için kullanılır
     * */

    class Urun
    {
        public int No { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public Urun(int no, string ad, double fiyat)
        {
            this.No = no;
            this.Adi = ad;
            this.Fiyat = fiyat;
        }
       
    }
    class UrunYonet: IEnumerable<Urun>
    {
        /// <summary>
        /// urun yönet kısmında türetilen nesne üzerinden urun sınıfına gelen tüm değerleri teker teker uruns lere ekliyoruz
        /// </summary>
        Urun[] uruns;
        public Urun[] urunler
        {
            get { return uruns; }
            set { uruns = value; }
        }
        /// <summary>
        /// Bu metod urun sınıfından gelen değerleri teker teker değerlerini geri döndürür
        /// </summary>
        /// <returns></returns>
        private Urun[] UrunGetir()
        {
            return new Urun[] 
            {
                new Urun(1,"Elma",100.5),
                new Urun(2,"Artmut",80.2),
                new Urun(3,"Muz",150.8)
            };
        }
        public UrunYonet()
        {
            uruns = UrunGetir();
        }
        /// <summary>
        /// liste yapısı içerisinde her bir index elamanını tuttuğu değeri geri gönderiyor
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Urun> GetEnumerator()
        {
            for (int i = 0; i < uruns.Length; i++)
            {
                yield return urunler[i];
            }
            //throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
            throw new NotImplementedException();
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            // urun sınıfından nesne türetildi
            UrunYonet urunYonet = new UrunYonet();
            
            // urunu sınıfına iterasyon yapılarını kazandırarak özellikleri barındıran, IEnumarator nesnesi dönen bir metottur
            IEnumerator<Urun> uruns = urunYonet.GetEnumerator(); // GetEnumarator() sürekli kkullanacaksın
            
            //iteratörde son elemana kadar olan tüm değerleri sırayla alıyor → iteratör index numarası gibi - adresleme noktası - pointer
            while (uruns.MoveNext())
            {
                Console.WriteLine(uruns.Current.Adi +" "+ uruns.Current.Fiyat);
            }
            //moveNex() iteratördeki ilk sıradaki elemanı alma
            //Current = o andaki moveNext() edilen elemanı al diyoruz
        }
    }
}
