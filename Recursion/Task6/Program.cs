using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            var elements = new string[] { "test", "rock", "fun" };
            var k = 2;
            Subsets(elements, new string[k], k, 0,0);
        }

        private static void Subsets(string[] elements, string[] result, int k, int index, int start)
        {
            if (k <= index)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                result[index] = elements[i];
                Subsets(elements, result, k, index + 1, i + 1);

            }
        }
    }
}
