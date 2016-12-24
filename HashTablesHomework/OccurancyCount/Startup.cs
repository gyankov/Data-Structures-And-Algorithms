using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurancyCount
{
    class Startup
    {
        static void Main()
        {
            var arr = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var counter = new Dictionary<double, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!counter.ContainsKey(arr[i]))
                {
                    counter[arr[i]] = 0;
                }

                counter[arr[i]]++;
            }

            foreach (var item in counter)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
