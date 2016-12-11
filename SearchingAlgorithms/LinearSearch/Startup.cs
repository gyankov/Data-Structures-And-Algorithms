using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Startup
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 234, 423, 2, 66, 573, 84, 6, 94, 9, 6, 6, 49 };
            Console.WriteLine(LinearSearch(arr,9));
        }

        private static int LinearSearch(int[] arr, int element)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==element)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
