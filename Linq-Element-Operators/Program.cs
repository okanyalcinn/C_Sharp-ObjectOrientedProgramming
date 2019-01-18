
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Element_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //p.LinqFirstCondition();

            p.LinqElementAt();
        }
        public void LinqFirstCondition()
        {
            string[] kelimeler = { "sifir", "iki", "üç", "dort", "beş" };
            string getir = kelimeler.First(x => x[0] == 'b');

            Console.WriteLine(getir);            
        }
        public void LinqElementAt()
        {
            int[] numara = { 5, 6, 4, 5, 7, 8, 9 };

            int no = (from n in numara where n > 5 select n).ElementAt(2); // elementAt(x) x'inci elemanı al

            Console.WriteLine(no);
        }
    }
}
