using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordsCount
{
    class Startup
    {
        static void Main()
        {
            var arr = Regex.Split("This is the TEXT.Text, text, text – THIS TEXT!Is this the text?",@"\W+");
            var counter = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!counter.ContainsKey(arr[i].ToLower()))
                {
                    counter[arr[i].ToLower()] = 0;
                }

                counter[arr[i].ToLower()]++;
            }

            foreach (var item in counter)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
