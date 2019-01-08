//#define SıfırKontrolü
#define KarakterKontrolü

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontanimlayicilar1
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
#if KarakterKontrolü
                        throw new InvalidOperationException("Sadece belirtilen karakterler girilebilir + - * /");
#warning define etkin değil kardeş
#endif
                }

            }
#if SıfırKontrolü
            catch (DivideByZeroException x)
            {
                Console.WriteLine("Sıfıra bölünemez. " + x);

            }
#warning define etkin mi ki kanka
#endif

            catch (Exception)
            {
                //throw;
            }

            Console.ReadKey();
        }
    }
}
