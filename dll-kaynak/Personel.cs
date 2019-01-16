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

        public Personel(T Saat, T SaatlikUcret)
        {
            this.Saat = Saat;
            this.SaatlikUcret = SaatlikUcret;
        }
        public T MaasHesapla(ref double Saat, ref double SaatlikUcret)
        {
            double d = Saat * SaatlikUcret;
            Maas = (T)Convert.ChangeType(d, TypeCode.Double);
            return Maas;
        }
        public T Goster(double SaatlikUcret)
        {
            if (SaatlikUcret <= 150)
            {
                Console.WriteLine("Personel maaşınız: " + Maas);
            }
            else if (SaatlikUcret > 150)
            {
                Console.WriteLine("Yönetici maaşınız: " + Maas);
            }
            return Saat;
            
        }

        // tür dönüşümlü

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
