using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapSack
{
    class Startup
    {
        static void Main(string[] args)
        {
            int W = 10;
            int N = 6;
            var weights = new int[] { 3, 8, 4, 1, 2, 8 };
            var values = new int[] { 2, 12, 5, 4, 3, 13 };

            Console.WriteLine(Knapsack(W, weights, values,N));
        }

        private static int Knapsack(int W, int[] weights, int[] values, int n)
        {
            int[,] K = new int[n + 1, W + 1];

            for (int i = 0; i <= n; i++)
            {
                
                for (int w = 0; w <= W; w++)
                {                    
                    if (i == 0 || w == 0)
                    {
                        K[i, w] = 0;
                    }
                    else if (weights[i - 1] <= w)
                    {
                        var previousWeight = weights[i - 1];
                        var previousValues = values[i - 1];
                        K[i, w] = Math.Max(previousValues + K[i - 1, w - previousWeight], K[i - 1, w]);
                    }
                    else
                    {
                        K[i, w] = K[i - 1, w];
                    }

                    Console.Write(K[i, w] + " ");
                }

                Console.WriteLine();
            }

            

            return K[n, W];
        }
    }
}
