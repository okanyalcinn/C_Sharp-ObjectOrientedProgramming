#define Ingilizce
//#define Turkce

#define uzak
#define local

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontanimlayicilar
{
    class Program
    {
        //önişlemci komutları  (exe de derlenmiyor)
        //region
        //define (en başta tanımlı şuan)
        // #error Local kısmında hatalar var burayı çalıştırma //error da program derlenmez 
        // #warning burası çalışır ama burada değişiklikler gerekir

        #region kod blogu
        #endregion

        static void Main(string[] args)
        {
            #region ekrana yazdırma
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #if Turkce
            Console.WriteLine("Merhaba");
            #error Local kısmında hatalar var burayı çalıştırma //error da program derlenmez
            #warning burası çalışır ama burada değişiklikler gerekir
            #endif

            #if Ingilizce
            Console.WriteLine("Hello");
            #endif

            #if local
            Console.WriteLine("Local masaütü çalışıyor. ");
            #endif

            Console.ReadKey();
        }
    }
}
