using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devisors
{
    class Program
    {
        private static List<string> permutations = new List<string>();
        private static Dictionary<int, int> devisors = new Dictionary<int, int>();

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = (int.Parse(Console.ReadLine()));
            }

            Permutations(arr, new bool[arr.Length], new int[arr.Length], 0);

            foreach (var item in permutations)
            {
                FindDevisors(int.Parse(item));
            }

           var min =  devisors.OrderBy(x => x.Value).FirstOrDefault().Value;

            var result = devisors.Where(x => x.Value == min).OrderBy(x => x.Key).FirstOrDefault().Key;

            Console.WriteLine(result);
        }

        private static void FindDevisors(int number)
        {
            if (!devisors.ContainsKey(number))
            {
                devisors.Add(number, 0);
            }
            else
            {
                return;
            }

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    devisors[number] += 1;
                }
            }
        }
        private static void Permutations(int[] numbers, bool[] occupied, int[] result, int index)
        {
            if (index == numbers.Count())
            {
                permutations.Add(string.Join("", result));
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!occupied[i])
                {
                    occupied[i] = true;
                    result[index] = numbers[i];
                    Permutations(numbers, occupied, result, index + 1);
                    occupied[i] = false;
                }
            }

        }

    }
}
