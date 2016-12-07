using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPasswords
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            long counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='*')
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Degree(2,counter));

            }


        }

        private static long Degree(long a, long b)
        {
            long result = 1;
            for (int i = 0; i < b; i++)
            {
                result*= a;
            }

            return result;
        }
    }
}
