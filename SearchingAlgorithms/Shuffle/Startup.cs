using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    class Startup
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Shuffle(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void Shuffle(int[] arr)
        {
            var random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                var r = random.Next(i, arr.Length);
                var temp = arr[i];
                arr[i] = arr[r];
                arr[r] = temp;
            }
        }
    }
}
