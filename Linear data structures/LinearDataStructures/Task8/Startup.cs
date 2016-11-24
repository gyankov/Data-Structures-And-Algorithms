using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
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

            Console.WriteLine(Numbers.Where(x=> x.Value >= numbers.Count/2 +1).Select(x=> x.Key).FirstOrDefault());
            
        }
    }
}
