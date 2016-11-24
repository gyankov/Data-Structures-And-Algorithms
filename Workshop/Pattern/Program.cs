using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var firstPattern = "urd";

            var pattern = "urd";
            for (int i = 1; i < n; i++)
            {
                pattern = CreateNextPattern(pattern);
            }

            Console.WriteLine(pattern);
        }

        private static string CreateNextPattern(string previous)
        {
            var sb = new StringBuilder();

            sb.Append(RotateRight(previous));
            sb.Append("u");
            sb.Append(previous);
            sb.Append("r");
            sb.Append(previous);
            sb.Append("d");
            sb.Append(RotateLeft(previous));

            return sb.ToString();                
        }

        private static string RotateLeft(string route)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < route.Length; i++)
            {
                if (route[i] == 'u')
                {
                    sb.Append("l");
                }
                else if (route[i] == 'l')
                {
                    sb.Append("u");
                }
                else if (route[i] == 'd')
                {
                    sb.Append("r");
                }
                else if (route[i] == 'r')
                {
                    sb.Append("d");
                }
            }

            return sb.ToString();
        }

        private static string RotateRight(string route)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < route.Length; i++)
            {
                if (route[i] == 'u')
                {
                    sb.Append("r");
                }
                else if (route[i] == 'l')
                {
                    sb.Append("d");
                }
                else if (route[i] == 'd')
                {
                    sb.Append("l");
                }
                else if (route[i] == 'r')
                {
                    sb.Append("u");
                }
            }

            return sb.ToString();
        }
    }
}
