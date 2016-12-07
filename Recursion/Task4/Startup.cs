using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Startup
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 3).ToArray();
            Permutations(numbers, new bool[numbers.Length], new int[numbers.Length], 0);
        }

        private static void Permutations(int[] numbers, bool[] occupied, int[] result, int index)
        {
            if (index == numbers.Length)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!occupied[i])
                {
                    result[index] = numbers[i];
                    occupied[i] = true;
                    Permutations(numbers, occupied, result, index + 1);
                    occupied[i] = false;
                }
            }
        }
        
    }
}
