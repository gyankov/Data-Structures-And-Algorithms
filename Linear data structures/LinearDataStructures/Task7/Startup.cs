using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
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
                    if (num >= 0 && num <= 10000)
                    {
                        Numbers[num]++;
                    }
                }
                else
                {
                    if (num >= 0 && num <=10000)
                    {
                        Numbers[num] = 1;
                    }
                }
            }

            foreach (var num in Numbers)
            {
                Console.WriteLine($"Number {num.Key} occurs {num.Value} times");
            }
            
        }
    }
}

