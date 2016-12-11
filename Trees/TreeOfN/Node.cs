using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOfN
{
    public class Node<T>
    {
        private T value;
        private Node<T> parent;
        private List<Node<T>> children;

        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Node<T> Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public List<Node<T>> Children
        {
            get
            {
                return children;
            }

            set
            {
                children = value;
            }
        }
    }
}
