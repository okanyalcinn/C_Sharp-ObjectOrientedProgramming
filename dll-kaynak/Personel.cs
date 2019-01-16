using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_kaynak
{
    public class Personel<T>
    {
        private int no { get; set; }

        public int NO
        {
            get { return no; }
            set { no = value; }
        }
        public string Ad { get; set; }
        protected string Soyad { get; set; }
        public T Saat { get; set; }
        public T SaatlikUcret { get; set; }
        public T Maas { get; set; }
        /// <summary>
        /// Pesonel yapıcı metodu ile diğer classtan gelen verileri bu classtaki T tipli fieldlara 
        /// değer atamasını gerçekleştirdik
        /// </summary>
        /// <param name="Saat"></param>
        /// <param name="SaatlikUcret"></param>
        public Personel(T _Saat, T _SaatlikUcret)
        {
            this.Saat = _Saat;
            this.SaatlikUcret = _SaatlikUcret;
        }
        /// <summary>
        /// hesapla metodunda T tipli fieldları önce double a çevirip çarpma işlemini yaptırarak 
        /// sonrasında T tipine tekrar çevirim maas fieldına atama yaptık
        /// </summary>
        /// <returns></returns>
        T MaasHesapla()
        {
            // (double)(object)Saat → kullanımıyla T tipli saat fieldını önce objecte sonrasında double'a çevirdik

            // (T)(Object) (dönüşüm ve çarpma işlemi) → yukarıda açıklamasını yaptığım dönüşümlerden sonra double olan 
            //        verileri çarpma işlemine tabii tuttuk sonrasında elden edilen sonucu object'e çevirip
            //        T tipli değere dönüştürüp T tipli maas field'ımıza değerini atadık
            Maas = (T)(Object)((double)(Object)Saat * (double)(Object)SaatlikUcret);            
            return Maas;
        }
        public T Goster()
        {
            MaasHesapla();// maasHesapla() metodunu çağırarak çıkan sonuca göre if yardımıyla sonucu ekrana bastırmayı istiyoruz
            // T tipli maas field'ını object'e sonrasında double' a çevirerek işleme tabii tutuyoruz
            if ((double)(Object)Maas <= 150)
            {
                Console.WriteLine("Personel maaşınız: " + Maas);
            }
            else if ((double)(Object)Maas > 150)
            {
                Console.WriteLine("Yönetici maaşınız: " + Maas);
            }
            return Saat;
            
        }


        // tür dönüşümleri

        // T Maas = (T)Convert.ChangeType(carpimi, TypeCode.Double); //double veriyi T türüne dönüştürme

        //public T Hesapla<T>(ref T a, ref T b)
        //{
        //    T maas = (T)(object)0;
        //    if (typeof(T) == typeof(int))
        //    {
        //        maas = (T)(Object)((int)(Object)a * (int)(Object)b);
        //        return maas;
        //    }
        //    if (typeof(T) == typeof(double))
        //    {
        //        maas = (T)(Object)((double)(Object)a * (double)(Object)b);
        //        return maas;
        //    }
        //    return maas;
        //}
    }
}
