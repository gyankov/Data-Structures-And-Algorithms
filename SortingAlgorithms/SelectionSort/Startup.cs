using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 324, 32, 34, 2, 3, 423, 4, 23, 423, 42, 4, 34, 6456, 64536, 2563, 2, 3, 1, 6, 7 };
            SelectionSort(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
