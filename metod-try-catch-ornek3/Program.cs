using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_try_catch_ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a * b;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Değer girmediniz. " + e.Message);
                throw;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Hatalı türde değer girişi. " + e.Message);
                throw;
            }

            catch (OverflowException e)
            {
                Console.WriteLine("Girilen değer çok büyük. " + e.Message);
                throw;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("dönüşüm işlemi aşamasında hata alındı. " + e.Message);
                throw;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("sadece belirtilen ifadelerde giriş yapabilirsiniz + - * / " + e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Bir şey oldu. " + e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Değer gir. ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
            }
        }
    }
}
