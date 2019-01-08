using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod
{
    
    class Program
    {
        public void Gun(string gun)
        {
            Console.WriteLine(gun);
        }
        public void Gun(string gun, string hava)
        {
            Console.WriteLine(gun+hava);
        }
        public int Hesapla(int a, int b)
        {
            return a+b;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Gun("pazartesi");
            program.Gun("salı", "karlı");
            program.Hesapla(5, 8);
        }
    }
}
