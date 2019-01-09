using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delege_olayYeriInceleme
{
    // delege ve eventları kullanarak beş tane ilçenin günlük olaylarını analiz edip geri yazdıran program 

    public delegate void OlayYeriInceleme(int a, int b);
    
    class Program
    {
        static event OlayYeriInceleme inceleme;
        
        static void Taksim(int a, int b)
        {
            Console.WriteLine(a + b + "tane suç işlendi");
        }
        static void Kartal(int a, int b)
        {
            Random rd = new Random();
            int kSuc= rd.Next(a, b);
            Console.WriteLine(kSuc + " Tane suç işlendi");
        }
        static void Sisli(int a, int b)
        {            
            Console.WriteLine((a+b)/2 + " Tane suç işlendi");
        }
        static void Main(string[] args)
        {
            inceleme += new OlayYeriInceleme(Sisli);
            inceleme.Invoke(50, 5);

        }
    }
}
