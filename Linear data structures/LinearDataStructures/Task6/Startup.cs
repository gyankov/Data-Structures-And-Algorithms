using System;
using System.Collections.Generic;

namespace Task6
{
    class Startup
    {
        private static Dictionary<int, int> Numbers = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var number = Console.ReadLine();
            while (!string.IsNullOrEmpty(number))
            {
                numbers.Add(int.Parse(number));
                number = Console.ReadLine();
            }

            foreach (var num in numbers)
            {
                int value;
                if (Numbers.TryGetValue(num, out value))
                {
                    Numbers[num]++;
                }
                else
                {
                    Numbers[num] = 1;
                }
            }

            var oddOccurencies = new List<int>();

            foreach (var num in Numbers)
            {
                if (num.Value % 2 ==1)
                {
                    oddOccurencies.Add(num.Key);
                }
            }

            foreach (var num in oddOccurencies)
            {
                numbers.RemoveAll(x=> x == num);
            }

            Console.WriteLine(string.Join(", ",numbers));

        }
    }
}
