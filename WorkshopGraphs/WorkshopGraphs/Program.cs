using System;
namespace WorkshopGraphs
{
    class Program
    {
        static void Main()
        {
            var n =int.Parse(Console.ReadLine());
            long current = 0;
            for (int i = 0; i < n; i++)
            {
                current^= long.Parse(Console.ReadLine());
            }
            Console.WriteLine(current);           
        }
    }
}
