using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Startup
    {
        static void Main(string[] args)
        {

            var numbers = new Stack<int>();
            var number = Console.ReadLine();
            while (!string.IsNullOrEmpty(number))
            {
                numbers.Push(int.Parse(number));
                number = Console.ReadLine();
            }
            var count = numbers.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
