using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
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

            var positiveNumbers = numbers.Where(x => x >= 0).ToList();

            Console.WriteLine(string.Join(", ", positiveNumbers));
        }
    }
}
