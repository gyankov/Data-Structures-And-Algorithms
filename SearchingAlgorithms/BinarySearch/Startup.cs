using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Startup
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(BinarySearch(arr, 6));
        }

        private static int BinarySearch(int[] arr, int element)
        {
            int left = 0;
            int right = arr.Length - 1;
            int index = -1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (arr[middle] < element)
                {
                    left = middle + 1;
                }
                else if (arr[middle] > element)
                {
                    right = middle - 1;
                }
                else
                {
                    index = middle;
                    break;
                }
            }

            return index;
        }
    }
}
