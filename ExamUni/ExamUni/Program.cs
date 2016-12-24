using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamUni
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var array = new List<int> { 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 4, 32, 234, 43, 2, 4, 32, 234, 43, 2, 4, 1 };
            var sorted=  Quicksort(array);
            Console.WriteLine(string.Join(" ", sorted));
        }

        private static List<int> Quicksort(List<int> array)
        {
            if (array.Count <= 1)
            {
                return array;
            }

            var pivot = array[array.Count / 2];
            array.Remove(pivot);
            var left = new List<int>();
            var right = new List<int>();

            foreach (var item in array)
            {
                if (item <= pivot)
                {
                    left.Add(item);
                }
                else
                {
                    right.Add(item);
                }
            }

            var result = new List<int>();
            result.AddRange(Quicksort(left));
            result.Add(pivot);
            result.AddRange(Quicksort(right));
            return result;
        }
    }
}
