using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ornek5
{
    class Pc<T, T1, T2>
    {
        private T No { get; set; }
        public T NO
        {
            get { return No; }
            set { No = value; }
        }
        public T1 Adi { get; set; }
        public T2 Model { get; set; }
        public double Fiyat(double a)
        {
            return a * 2.18;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Pc<object, object, int>> ts = new List<Pc<object, object, int>>();
            ts.Add(new Pc<object, object, int> { NO = 12, Adi = "Hp", Model = 580});

            Pc<object, object, int> pc = new Pc<object, object, int>();
            Console.WriteLine(pc.Fiyat(200)); 
        }
    }
}
