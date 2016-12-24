using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurencies
{
    class Startup
    {
        static void Main()
        {
            var arr = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var counter = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!counter.ContainsKey(arr[i]))
                {
                    counter[arr[i]] = 0;
                }

                counter[arr[i]]++;
            }

            Console.WriteLine(string.Join(" ", counter.Where(x=> x.Value%2 != 0).Select(x=> x.Key)));
        }
    }
}
