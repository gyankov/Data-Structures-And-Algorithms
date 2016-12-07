using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
           
            Combinations(new int[k], 0, n, 1);
        }

        private static void Combinations(int[] numbers, int index, int n, int m)
        {
            if (index == numbers.Length)
            {
                Console.WriteLine(string.Join(", ", numbers));
                return;
            }

            for (int i = m; i <= n; i++)
            {
                numbers[index] = i;
                Combinations(numbers, index + 1, n, i + 1);
            }
        }
    }
}
