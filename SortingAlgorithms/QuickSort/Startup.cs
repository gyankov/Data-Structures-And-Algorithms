using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Startup
    {
        static void Main(string[] args)
        {
            var arr = new List<int> { 4, 324, 32, 34, 2, 3, 423, 4, 23, 423, 42, 4, 34, 6456, 64536, 2563, 2, 3, 1, 6, 7 };
            var sorted = QuickSort(arr);

            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static List<int> QuickSort(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            var pivot = arr[arr.Count / 2];
            arr.RemoveAt(arr.Count / 2);

            var less = new List<int>();
            var more = new List<int>();

            foreach (var item in arr)
            {
                if (item <= pivot)
                {
                    less.Add(item);
                }
                else
                {
                    more.Add(item);
                }
            }

            var result = new List<int>();
            result.AddRange(QuickSort(less));
            result.Add(pivot);
            result.AddRange(QuickSort(more));

            return result;
        }
    }
}
