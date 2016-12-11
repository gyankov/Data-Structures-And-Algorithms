using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOfN
{
    public class Tree<T>
    {
        private readonly Node<T> root;

        public Tree(Node<T> root)
        {
            this.root = root;
        }

        public Node<T> Root
        {
            get
            {
                return root;
            }
        }

        public List<Node<T>> Leafs()
        {
            var allNodes = this.BFS();

            return allNodes.Where(x => x.Children.Count == 0).ToList();
        }

        public List<Node<T>> MiddleNodes()
        {
            var allNodes = this.BFS();

            return allNodes.Where(x => x.Children.Count > 0 && x.Parent != null).ToList();
        }

        private void PathsWithGivenSum(int currentPath, int desiredLength, Node<T> root)
        {
            currentPath += 1;
            if (root.Children.Count == 0)
            {
                if (currentPath == desiredLength)
                {
                   
                }
                currentPath = 0;
            }

            foreach (var child in root.Children)
            {
                PathsWithGivenSum(currentPath, desiredLength, child);
            }

        }

        public void LongestPath(int currentPath, int longestPath, Node<T> root)
        {
            currentPath += 1;
            if (root.Children.Count == 0)
            {
                if (longestPath < currentPath)
                {
                    longestPath = currentPath;
                }
                currentPath = 0;
            }

            foreach (var child in root.Children)
            {
                LongestPath(currentPath, longestPath, child);
            }
        }

        private List<Node<T>> DFS()
        {
            var result = new List<Node<T>>();
            var stack = new Stack<Node<T>>();
            stack.Push(this.root);
            while (stack.Count > 0)
            {
                var v = stack.Pop();
                result.Add(v);
                foreach (var child in v.Children)
                {
                    stack.Push(child);
                }
            }

            return result;
        }

        private void DFSRecursive(List<Node<T>> list, Node<T> root)
        {
            list.Add(root);
            foreach (var child in root.Children)
            {
                DFSRecursive(list, child);
            }
        }

        private List<Node<T>> BFS()
        {
            var result = new List<Node<T>>();
            var queue = new Queue<Node<T>>();
            queue.Enqueue(this.root);
            while (queue.Count > 0)
            {
                var v = queue.Dequeue();
                result.Add(v);
                foreach (var child in v.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return result;
        }
    }
}
