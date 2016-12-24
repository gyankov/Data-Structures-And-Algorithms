using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var a = int.Parse(input[0]);
            var b = int.Parse(input[1]);
            var p = int.Parse(input[2]);
            var q = int.Parse(input[3]);           
            var counter = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % p == q)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
