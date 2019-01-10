using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace koleksiyonlar_stackList
{
    class Program
    {
        static void Main(string[] args)
        {
            //yığın 
            //son giren ilk çıkar lifo -last in -first out
            Stack stack = new Stack(5);

            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            stack.Push('d');

            Console.WriteLine("---");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");
            // pop çağırma değerleri sona eklenenden sırayla ilk eklenene doğru çağırır
            // pop kullan at
            Console.WriteLine(stack.Pop()+" Pop çağırma");
            Console.WriteLine(stack.Peek() + " Peek çağırma");
            Console.WriteLine(stack.Pop() + " Pop çağırma");

            Console.WriteLine("---");
            // peek çağırma alınan değeri kullanıp, bir sonraki değeri çağırır
            // peek kullan geri döndür
            Console.WriteLine(stack.Peek() + " Peek çağırma");
            //stack.Clear(); // içerdeki elemanları silme
        }
    }
}
