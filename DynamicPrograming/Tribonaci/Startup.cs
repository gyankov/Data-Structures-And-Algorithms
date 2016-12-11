using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tribonaci
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var first = BigInteger.Parse(input[0].ToString());
            var second = BigInteger.Parse(input[1].ToString());
            var third = BigInteger.Parse(input[2].ToString());
            var n = int.Parse(input[3].ToString());

            Console.WriteLine(Tribonaci(first, second, third, n));
        }

        private static BigInteger Tribonaci(BigInteger first, BigInteger secont, BigInteger third, int n)
        {
            var arr = new List<BigInteger>();

            arr.Add(first);
            arr.Add(secont);
            arr.Add(third);

            for (int i = 3; i < n; i++)
            {
                arr.Add(arr[i - 1] + arr[i - 2] + arr[i - 3]);
            }
            return arr[n-1];
        }
    }
}
