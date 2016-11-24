using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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

           Quicksort(numbers, 0, numbers.Count - 1);

            Console.WriteLine(string.Join(", ", numbers));           
           
        }

        public static void Quicksort(List<int> elements, int left, int right)
        {
            int i = left, j = right;
            var pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                 
                    var tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }
            
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
