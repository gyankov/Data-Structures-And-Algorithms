using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

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
            public override int GetHashCode()
            {
                return this.Id;

            }
            public override bool Equals(object obj)
            {
                return Equals(obj as Vertex);
            }
            public bool Equals(Vertex obj)
            {
                return obj != null && obj.Id == this.Id;
                
            }

            public int CompareTo(Vertex other)
            {
                return this.Distance.CompareTo(other.Distance);
            }
        }

        class VertexComparer : IComparer<Vertex>
        {
            public int Compare(Vertex x, Vertex y)
            {
               return x.CompareTo(y);
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
            var q = new PriorityQueue<Vertex>();

            foreach (var item in map)
            {
                item.Distance = int.MaxValue;
            }
            source.Distance = 0;
            q.Enqueue(source);
            while (q.Count > 0)
            {
                var u = q.Dequeue();

                foreach (var item in u.Edges)
                {

                    var alt = u.Distance + item.Value;

                    if (alt < map[item.Key].Distance)
                    {
                        map[item.Key].Distance = alt;
                        q.Enqueue(map[item.Key]);
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
    public class PriorityQueue<T> where T : IComparable
    {
        private T[] heap;
        private int index;

        public PriorityQueue()
        {
            this.heap = new T[16];
            this.index = 1;
        }

        public int Count
        {
            get
            {
                return this.index - 1;
            }
        }

        public void Enqueue(T element)
        {
            if (this.index >= this.heap.Length)
            {
                this.IncreaseArray();
            }

            this.heap[this.index] = element;

            int childIndex = this.index;
            int parentIndex = childIndex / 2;
            this.index++;

            while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
            {
                T swapValue = this.heap[parentIndex];
                this.heap[parentIndex] = this.heap[childIndex];
                this.heap[childIndex] = swapValue;

                childIndex = parentIndex;
                parentIndex = childIndex / 2;
            }
        }

        public T Dequeue()
        {
            T result = this.heap[1];

            this.heap[1] = this.heap[this.Count];
            this.index--;

            int rootIndex = 1;

            while (true)
            {
                int leftChildIndex = rootIndex * 2;
                int rightChildIndex = (rootIndex * 2) + 1;

                if (leftChildIndex > this.index)
                {
                    break;
                }

                int minChild;
                if (rightChildIndex > this.index)
                {
                    minChild = leftChildIndex;
                }
                else
                {
                    if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                    {
                        minChild = leftChildIndex;
                    }
                    else
                    {
                        minChild = rightChildIndex;
                    }
                }

                if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                {
                    T swapValue = this.heap[rootIndex];
                    this.heap[rootIndex] = this.heap[minChild];
                    this.heap[minChild] = swapValue;

                    rootIndex = minChild;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public T Peek()
        {
            return this.heap[1];
        }

        private void IncreaseArray()
        {
            var copiedHeap = new T[this.heap.Length * 2];

            for (int i = 0; i < this.heap.Length; i++)
            {
                copiedHeap[i] = this.heap[i];
            }

            this.heap = copiedHeap;
        }
    }
}

