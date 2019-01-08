using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_kapsulleme_ayakkabi_ornek
{
    // ayakkabı numarasını sınırla -properties kullanarak private numara 
    // fiyatı da sınırlandır
    class Ayakkabi
    {
        private int numara { get; set; }

        public string Tur { get; set; }
        private int fiyat { get; set; }


        public int Numara
        {
            get
            {
                if (numara > 50)
                {
                    return 0;
                }
                else
                {
                    return numara;
                }
            }
            set
            {
                if (value < 30 || value > 50)
                {
                    Console.WriteLine("Max büyük");
                    numara = 50;
                }
                else
                {
                    numara = value;
                }
            }
        }

        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value < 0 || value > 250)
                {
                    Console.WriteLine("max ücret 20 TL olarak ayarlandı");
                }
                else
                {
                    fiyat = value;
                }
            }
        }

        public void Bilgiler()
        {
            Console.WriteLine("numara {0} Türü {1} fiyat {2}", numara, Tur, fiyat);
        }
        
        ~Ayakkabi()
        {
            Console.WriteLine("numara {0} Türü {1} fiyat {2}", numara, Tur, fiyat);
        }
    }

    class Bot : Ayakkabi
    {
        public Bot()
        {
            Tur = "Bot";
        }
    }
    class Spor : Ayakkabi
    {
        public Spor()
        {
            Tur = "Spor";
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Spor");
            Spor spor = new Spor();

            spor.Numara = 33;
            spor.Fiyat = 240;

            spor.Bilgiler();
            
        }
    }
}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace class_kapsulleme_ayakkabi_ornek
//{
//    // ayakkabı numarasını sınırla -properties kullanarak private numara 
//    // fiyatı da sınırlandır
//    class Ayakkabi
//    {
//        private int AyakNo;

//        public int no
//        {
//            get
//            {
//                if (AyakNo > 42)
//                {
//                    return 1;
//                }
//                else
//                {
//                    return 2;
//                }
//            }
//            set
//            {
//                if (value == 1 )
//                {
//                    Console.WriteLine("Çok büyük");
//                }
//                else if (value < 42)
//                {
//                    Console.WriteLine("Çok küçük");
//                }
//            }
//        }

//        public void Mesaj()
//        {
//            Console.WriteLine(AyakNo);
//        }
//    }

//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Ayak n gir ");
//            Ayakkabi ayakkabi = new Ayakkabi();


//        }
//    }
//}
