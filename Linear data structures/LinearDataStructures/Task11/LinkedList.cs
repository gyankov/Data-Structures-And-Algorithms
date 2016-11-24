using System;
using System.Collections;
using System.Collections.Generic;

namespace Task11
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private ListItem<T> lastElement;

        public LinkedList()
        {
            this.FirstElement = null;
            this.lastElement = null;
        }
        public ListItem<T> FirstElement { get; private set; }

        public int Count { get; private set; }

        public ListItem<T> Find(T key)
        {
            var currentElement = this.FirstElement;
            while (currentElement != null)
            {
                if (currentElement.Value.Equals(key))
                {
                    return currentElement;
                }
                currentElement = currentElement.NextItem;
            }

            return null;
        }

        public void InsertAt(int index, T key)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            var newElement = this.CreateElement(key);
            if (index == 0)
            {
                newElement.NextItem = this.FirstElement;
                this.FirstElement = newElement;
            }
            else
            {
                int i = 1;
                var currentElement = this.FirstElement;
                while (currentElement != null && i < index)
                {
                    currentElement = currentElement.NextItem;
                    i++;
                }

                newElement.NextItem = currentElement.NextItem;
                currentElement.NextItem = newElement;
            }

            this.Count++;
        }

        public void AddFirst(T key)
        {
            var newElement = this.CreateElement(key);
            if (this.IsEmpty())
            {
                this.lastElement = newElement;
            }

            newElement.NextItem = this.FirstElement;
            this.FirstElement = newElement;
            this.Count++;
        }

        public void AddLast(T key)
        {
            var newElement = this.CreateElement(key);
            if (this.IsEmpty())
            {
                this.FirstElement = newElement;
            }
            else
            {
                this.lastElement.NextItem = newElement;
            }

            this.lastElement = newElement;
            this.Count++;
        }

        public bool Contains(T key)
        {
            var element = this.Find(key);

            return key == null ? false : true;
        }

        public bool Remove(T key)
        {
            if (this.Contains(key))
            {
                return false;
            }

            if (this.Count == 1)
            {
                this.FirstElement = null;
                this.lastElement = null;
            }
            else
            {
                var currentElement = this.FirstElement;
                while (!currentElement.NextItem.Value.Equals(key))
                {
                    currentElement = currentElement.NextItem;
                }

                currentElement.NextItem = currentElement.NextItem.NextItem;
            }

            this.Count--;

            return true;
        }

        public void ForEach(Action<T> action)
        {
            foreach (var element in this)
            {
                action(element);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = this.FirstElement;
            while (currentElement != null)
            {
                yield return currentElement.Value;
                currentElement = currentElement.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private bool IsEmpty()
        {
            bool isEmpty = this.Count == 0;
            return isEmpty;
        }

        private ListItem<T> CreateElement(T value)
        {
            return new ListItem<T>(value);
        }
    }
}