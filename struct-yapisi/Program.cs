using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_yapisi
{
    /* Struct (yapı)
     * struct tıpkı class gibidir
     * ama içerisine static tanımlama yapılamaz
     * Temel olarak genel özelliği yapılar(struct) için "Aralarında mantıksal bir ilişki bulunan farklı türden 
     *       bilgilerin tanımlandığı ve içerisinde işlemlerin yapıldığı bir yapı bloğudur"
     * 
     * struct (Yapılar) classlara çok benzemesine rağmen en büyük farkı
     * -Yapılar(struct) değer tiplidir. 
     * -Classlar ise referans tiplidir
     * 
     * -Classlar siz programı çalıştırdığınızda hazır hale gelir. direkt işlem görür
     * -Structlar ise müracat edilince çalışır Stack yerleşir.
     * 
     * */
    struct OgrenciBilgileri
    {
        private int no { get; set; }
        public int NO
        {
            get { return NO; }
            set { value = NO; }
        }
        
        public string ad { get; set; }
        public string soyad { get; set; }
        public int not1 { get; set; }
        public int not2 { get; set; }

        public float Ortalama()
        {
            return (not1 + not2) / 2;
        }
        public void DegerGir(int not1, int not2)
        {
            this.not1 = not1;
            this.not2 = not2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OgrenciBilgileri ogrenciBilgileri = new OgrenciBilgileri();
            int gNot1 = 60;
            int gNot2 = 70;

            ogrenciBilgileri.DegerGir(gNot1, gNot2);
            Console.WriteLine( ogrenciBilgileri.Ortalama());
        }
    }
}
