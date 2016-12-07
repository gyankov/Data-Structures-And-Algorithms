using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates
{
    class Startup
    {
        private static List<double> allExchanges = new List<double>();
        static void Main()
        {
            var c = double.Parse(Console.ReadLine());
            var n = double.Parse(Console.ReadLine());
            var currency1 = new Queue<double>();
            var currency2 = new Queue<double>();

            for (int i = 0; i < n; i++)
            {
                var rates = Console.ReadLine().Split().Select(double.Parse).ToArray();
                currency1.Enqueue(rates[0]);
                currency2.Enqueue(rates[1]);
            }
            ExchangeRates(currency1, currency2, 1, c);
            Console.WriteLine(allExchanges.Max());

        }

        public static void ExchangeRates(Queue<double> currency1, Queue<double> currency2, int currentCurrency, double ammount)
        {
            if (currency1.Count == 0 || currency2.Count == 0)
            {
                return;
            }
            if (currentCurrency == 1)
            {
                var current = currency1.Dequeue() * ammount;
                allExchanges.Add(current);
                ExchangeRates(currency1, currency2, 2, current);
            }
            else
            {
                var current = currency2.Dequeue() * ammount;
                allExchanges.Add(current);
                ExchangeRates(currency1, currency2, 1, current);
            }
        }
    }
}
