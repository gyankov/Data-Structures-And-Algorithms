using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var number = Console.ReadLine();
            while (!string.IsNullOrEmpty(number))
            {
                numbers.Add(int.Parse(number));
                number = Console.ReadLine();
            }

            var longest = LongestSequence(numbers);

            Console.WriteLine(string.Join(", ", longest));
        }

        private static List<int> LongestSequence(List<int> numbers)
        {
            var count = 1;
            var bestCount = 1;
            var startIndex = 0;
            var bestStartIndex = 0;
            var inSequence = false;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var current = numbers[i];
                var next = numbers[i + 1];
                if (current == next)
                {
                    if (!inSequence)
                    {
                        startIndex = i;
                        inSequence = true;
                    }
                    count++;

                    if (count > bestCount && i == numbers.Count - 2)
                    {
                        bestCount = count;
                        bestStartIndex = startIndex;
                    }
                }
                else
                {
                    if (inSequence)
                    {
                        inSequence = false;
                    }

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestStartIndex = startIndex;
                    }                    

                    count = 1;
                }
            }

            return numbers.GetRange(bestStartIndex, bestCount);
        }
    }
}
