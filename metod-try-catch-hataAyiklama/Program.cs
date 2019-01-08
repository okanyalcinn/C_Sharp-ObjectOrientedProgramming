using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_try_catch_hataAyiklama
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("1. sayıyı giriniz");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("2. sayıyı giriniz");
                int b = int.Parse(Console.ReadLine());
                char islem = Convert.ToChar(Console.ReadLine());
                switch (islem)
                {
                    case '+':
                        Console.WriteLine("Sonuç: {0} ", a + b);                        
                        break;
                    case '-':
                        Console.WriteLine("Sonuç: {0} ", a - b);
                        break;
                    case '*':
                        Console.WriteLine("Sonuç: {0} ", a * b);
                        break;
                    case '/':
                        Console.WriteLine("Sonuç: {0} ", a / b);
                        break;
                    default:
                        throw new InvalidOperationException("Sadece belirtilen karakterler girilebilir + - * /");
                }
                
            }
            catch (DivideByZeroException x)
            {
                Console.WriteLine("Sıfıra bölünemez. " + x);
            }
            
            catch (Exception )
            {
                throw;
            }

            Console.ReadKey();
        }
    }
}
