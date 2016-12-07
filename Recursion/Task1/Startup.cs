using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            NestedLoops(new int[n], 0);
        }

        private static void NestedLoops(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                Console.WriteLine(string.Join(", ", numbers));
                return;
            }

            for (int i = 1; i <= numbers.Length; i++)
            {
                numbers[index] = i;
                NestedLoops(numbers, index + 1);
            }
        }
    }
}
