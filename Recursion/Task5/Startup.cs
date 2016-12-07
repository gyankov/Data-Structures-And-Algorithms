using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Startup
    {
        static void Main()
        {
            var elements = new string[] { "hi", "a", "b" };
            var k = 2;
            Subsets(elements, new string[elements.Length], k, 0);
        }

        private static void Subsets(string[] elements, string[] result, int k, int index)
        {
            if (k == index)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                result[index] = elements[i];
                Subsets(elements, result, k, index + 1);

            }
        }
    }
}
