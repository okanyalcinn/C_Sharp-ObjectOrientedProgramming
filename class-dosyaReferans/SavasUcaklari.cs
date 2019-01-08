using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dosyaReferans
{
    class SavasUcaklari : Ucaklar
    {
        public string Yon { get; set; }
        public string PilotAdi { get; set; }
        public int YolcuSayisi { get; set; }
        public int PersonelSayisi { get; set; }
        public void SavasUcakBilgi()
        {
            Console.WriteLine("Savaş uçağı bilgileri \n Yolcu sayısı {0} \n Personel Sayisi {1} \n Ağırlık {2} \n Uzunluk {3} Yükseklik {4}", YolcuSayisi, PersonelSayisi, Agirlik, Uzunluk, Yukseklik);
        }
    }
}
