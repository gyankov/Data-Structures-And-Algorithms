using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSum
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var K = int.Parse(input[0]);
            var N = int.Parse(input[1]);

            Console.WriteLine(SuperSum(K,N));
        }

        private static int SuperSum(int K, int N)
        {
            var sum = 0;

            if (K == 0)
            {
                return N;
            }
            for (int i = 1; i <= N; i++)
            {
                sum += SuperSum(K - 1, i);
            }
            return sum;
        }
    }
}
