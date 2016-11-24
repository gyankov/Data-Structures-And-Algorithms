using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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

            Console.WriteLine("Averarage: {0}, sum: {1}",numbers.Average(), numbers.Sum());
        }        
    }
}
