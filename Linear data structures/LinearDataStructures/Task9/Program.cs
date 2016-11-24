using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 50;
            //S1 = N;
            //S2 = S1 + 1;
            //S3 = 2 * S1 + 1;
            //S4 = S1 + 2;
            //S5 = S2 + 1;
            //S6 = 2 * S2 + 1;
            //S7 = S2 + 2;

            WithoutQueue(n, count);
            Console.WriteLine();
            WithQueue(n, count);
        }

        private static void WithQueue(int n, int count)
        {
            var queue = new Queue<int>();

            queue.Enqueue(n);

            for (int i = 0; i < count; i++)
            {
                var currentNumber = queue.Dequeue();
                queue.Enqueue(currentNumber + 1);
                queue.Enqueue(2 * currentNumber + 1);
                queue.Enqueue(currentNumber + 2);

                Console.Write(currentNumber+", ");
            }
        }

        private static void WithoutQueue(int n, int count)
        {
            var counter = 1;
            var numbers = new List<int>();
            numbers.Add(n);
            var index = 0;
            var currentS = numbers[index];
            for (int i = 0; i < count; i++)
            {
                if (counter == 1)
                {
                    numbers.Add(currentS + 1);
                }

                else if (counter == 2)
                {
                    numbers.Add(2 * currentS + 1);
                }

                else if (counter == 3)
                {
                    numbers.Add(currentS + 2);

                }
                counter++;

                if (counter == 4)
                {
                    counter = 1;
                    currentS = numbers[++index];
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
