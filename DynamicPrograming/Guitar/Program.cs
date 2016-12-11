using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class Program
    {
        private static List<string> someShit = new List<string>();
        static void Main(string[] args)
        {
            //var C = int.Parse(Console.ReadLine());
            //var powerUps = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var min = int.Parse(Console.ReadLine());
            //var max = int.Parse(Console.ReadLine());

            //for (int i = 1; i < powerUps.Length; i++)
            //{
            //    Combinate(powerUps, new int[i], 0, 0, max, min);
            //}

            //if (someShit.Count > 0)
            //{
            //    Console.WriteLine(someShit.Max());
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}

            Combinate(new string[] { "gosho", "stokata", "kiro", "bobito", "stoqn" }, new string[3], 0,0);
            var random = new Random();

            foreach (var item in someShit)
            {
                Console.WriteLine(item);
            }
        }

        private static void Combinate(string[] names, string[] result, int index, int start)
        {
            if (index == result.Length)
            {
                someShit.Add(string.Join(" ", result));               
                return;
            }

            for (int i = start; i < names.Length; i++)
            {
                result[index] = names[i];
                Combinate(names, result, index + 1, start + 1 + i);
            }
        }
    }
}
