using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            //hata kontrolü 
            try
            {
                int[] ii = new int[5];

                for (int i = 0; i <= ii.Length; i++)
                {
                    Console.WriteLine(ii[i]);
                }
                int b = Int32.Parse(Console.ReadLine());
                a = b / 2;
                Console.WriteLine(a);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.StackTrace);
                //throw;
            }

            catch (FormatException ex)  // 0 a bölme hatalarını ayıkla
            {
                Console.WriteLine(ex.Message);
                //throw;
            }

            catch (IndexOutOfRangeException ex) // dizi taşma hatalarını ayıkla
            {
                Console.WriteLine(ex.StackTrace);
                //throw;
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.StackTrace);
                //throw;
            }

            catch (Exception ex) //exception tüm hataları ayıklıyor
            {
                Console.WriteLine(ex.StackTrace);
                //throw;
            }

            finally //
            {
                Console.Write("Sonuc: ");
                a = 5;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
