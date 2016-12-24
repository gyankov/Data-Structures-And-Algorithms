using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PeshosFriends
{
    class Startup
    {
        class Vertex : IComparable
        {
            public Vertex(int id)
            {
                this.Id = id;
                this.Edges = new Dictionary<int, int>();
            }
            public int Id { get; set; }
            public Dictionary<int, int> Edges { get; set; }
            public int Distance { get; set; }

            public bool IsHospital { get; set; }

            public int CompareTo(object obj)
            {
                return this.Distance.CompareTo((obj as Vertex).Distance);
            }
        }
        static void Main()
        {
            var args = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var hospitals = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToArray();

            var map = new Vertex[args[0]];
            map[0] = new Vertex(0);
            for (int i = 0; i < args[1]; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (map[command[0] - 1] == null)
                {
                    map[command[0] - 1] = new Vertex(command[0] - 1);
                }
                if (map[command[1] - 1] == null)
                {
                    map[command[1] - 1] = new Vertex(command[1] - 1);
                }

                map[command[0] - 1].Edges.Add(command[1] - 1, command[2]);
                map[command[1] - 1].Edges.Add(command[0] - 1, command[2]);

            }
            for (int i = 0; i < hospitals.Length; i++)
            {
                map[hospitals[i]].IsHospital = true;
            }
            var min = int.MaxValue;
            foreach (var item in hospitals)
            {
                var curr = Dijkstra(map[item], map, args[0]);
                if (min > curr)
                {
                    min = curr;
                }
            }

            Console.WriteLine(min);
        }

        private static int Dijkstra(Vertex source, Vertex[] map, int vertecesCount)
        {
            var q = new SortedSet<Vertex>();
            var c = 0;
            foreach (var item in map)
            {
                item.Distance = int.MaxValue-c;
                q.Add(item);
                c++;
            }
            source.Distance = 0;
            

            while (q.Count > 0)
            {
                var u = q.First();
                q.Remove(u);

                foreach (var item in u.Edges)
                {

                    var alt = u.Distance + item.Value;

                    if (alt < map[item.Key].Distance)
                    {
                        map[item.Key].Distance = alt;
                    }
                }               
            }

            var result = 0;

            for (int i = 0; i < map.Length; i++)
            {
                if (!map[i].IsHospital)
                {
                    result += map[i].Distance;
                }
            }
            return result;
        }
    }     
    
}