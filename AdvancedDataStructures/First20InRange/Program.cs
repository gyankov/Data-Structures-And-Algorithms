using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace First20InRange
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static List<Product> Range(OrderedBag<Product> products, decimal min, decimal max)
        {
            var inRange = products.Range(new Product { Price = min }, true, new Product { Price = max }, true);
            var result = new List<Product>();

            for (int i = 0; i < 20; i++)
            {
                result.Add(inRange[i]);
            }

            return result;
        }
    }
}
