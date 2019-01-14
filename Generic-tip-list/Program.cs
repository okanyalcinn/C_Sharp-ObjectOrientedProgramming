using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tip_list
{
    class Program
    {
        public string ad { get; set; }
        
        public Program(string ad)
        {
            this.ad = ad;
        }

        public List<T> Veri<T>(int a)
        {            
            return new List<T>();            
        }

        
        static void Main(string[] args)
        {
            Program program = new Program("metin");
            Type ty = typeof(List<>);
            Type[] typ = { Type.GetType(program.ad) };

            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine(program.Veri<string>(i));
                Console.WriteLine(ty.IsPublic);
            }

            program.Veri<string>(50);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(program.Veri<int>(i));
            }
            
        }
    }
}
