using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numberOfDigits = int.Parse(Console.ReadLine());
            //var directions = Console.ReadLine();
            //var K = int.Parse(Console.ReadLine());

            //var possibleNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //for (int i = 0; i < directions.Length; i++)
            //{

            //}


            Generate(new List<int>(), 3);

        }

        private static void Generate(List<int> numbers, int len)
        {
            if (numbers.Count == len)
            {
                Console.WriteLine(string.Join(", ", numbers));
                return;
            }

            for (int i = 1; i <= len; i++)
            {
                numbers.Add(i);
                Generate(numbers, len);
                numbers.Remove(i);
            }
        }
       
    }
}
