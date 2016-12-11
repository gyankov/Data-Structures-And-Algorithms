using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Startup
    {
        static void Main(string[] args)
        {
            var arr = new List<int> { 4, 324, 32, 34, 2, 3, 423, 4, 23, 423, 42, 4, 34, 6456, 64536, 2563, 2, 3, 1, 6, 7 };
            var sorted = MergeSort(arr);

            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static List<int> MergeSort(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }
            var left = new List<int>();
            var right = new List<int>();
            var middle = arr.Count / 2;

            for (int i = 0; i < arr.Count; i++)
            {
                if (i < middle)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right.First());
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count> 0)
                {
                    result.AddRange(left);
                    left.Clear();
                }
                else if (right.Count> 0)
                {
                    result.AddRange(right);
                    right.Clear();
                }
            }
            return result;
        }
    }
}
