using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeshoFriends
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var numberOfVertices = int.Parse(input[0]);
            var numberOfEdges = int.Parse(input[1]);
            var numberOfHospitals = int.Parse(input[2]);
            var hospitals = Console.ReadLine().Split().Select(int.Parse).ToList();
            var graph = new int[numberOfVertices + 1, numberOfVertices + 1];
            for (int i = 0; i < numberOfEdges; i++)
            {
                var coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var x = coordinates[0];
                var y = coordinates[1];
                var dist = coordinates[2];
                graph[x, y] = dist;
                graph[y, x] = dist;
            }
              

        }        
        private static int Dijkstra(int source, int verticesCount, int[,] graph)
        {
            var dist = new int[verticesCount];
        }


    }
    //class Heap
    //{
    //    private List<int> numbers = new List<int>();

    //    public void Add(int number)
    //    {
    //        this.numbers.Add(number);
    //        this.numbers = this.numbers.OrderByDescending(x => x).ToList();
    //    }

    //    public int Take()
    //    {
    //        var number = this.numbers[0];
    //        this.numbers.RemoveAt(0);
    //        this.numbers = this.numbers.OrderByDescending(x => x).ToList();
    //        return number;
            
    //    }
    //}    
}
