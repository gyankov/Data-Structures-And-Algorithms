using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Diameter_Again
{
    public class Program
    {
        private static long max = -1;

        private class Node
        {
            public Node(int id)
            {
                this.Id = id;
                this.Children = new Dictionary<int, int>();
            }

            public int Id { get; set; }

            public Dictionary<int, int> Children { get; set; }
        }

        private static Node[] tree;
        private static bool[] visited;
        private static int bestSum;
        private static Node lastNode;
        private static int startNode;
        private static int endNode;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            tree = new Node[n];
            for (int i = 0; i < n - 1; i++)
            {
                string[] line = Console.ReadLine().Split();
                int aId = int.Parse(line[0]);
                int bId = int.Parse(line[1]);
                int weight = int.Parse(line[2]);

                if (tree[aId] == null)
                    tree[aId] = new Node(aId);

                if (tree[bId] == null)
                    tree[bId] = new Node(bId);

                var a = tree[aId];
                var b = tree[bId];
                a.Children.Add(bId, weight);
                b.Children.Add(aId, weight);
            }

            visited = new bool[n];
            DFS(tree[0], 0);
            startNode = lastNode.Id;

            visited = new bool[n];
            DFS(tree[lastNode.Id], 0);

            Console.WriteLine(max);
        }

        private static void DFS(Node source, int sum)
        {
            visited[source.Id] = true;

            foreach (var item in tree[source.Id].Children)
            {
                if (visited[item.Key])
                {
                    continue;
                }

                sum += item.Value;
                DFS(tree[item.Key], sum);
                if (sum > max)
                {
                    max = sum;
                    lastNode = tree[item.Key];
                }
                sum -= item.Value;
            }

            visited[source.Id] = false;
        }
    }
}