using System;
using System.Collections.Generic;
using System.Linq;

public class HashTable<T, TU>
{
    private LinkedList<Tuple<T, TU>>[] items;
    private int fillFactor = 3;
    private int size;

    public HashTable()
    {
        items = new LinkedList<Tuple<T, TU>>[4];
    }

    public void Add(T key, TU value)
    {
        var pos = GetPosition(key, items.Length);
        if (items[pos] == null)
        {
            items[pos] = new LinkedList<Tuple<T, TU>>();
        }
        if (items[pos].Any(x => x.Item1.Equals(key)))
        {
            throw new Exception("Duplicate key, cannot insert.");
        }
        size++;
        if (NeedToGrow())
        {
            GrowAndReHash();
        }
        pos = GetPosition(key, items.Length);
        if (items[pos] == null)
        {
            items[pos] = new LinkedList<Tuple<T, TU>>();
        }
        items[pos].AddFirst(new Tuple<T, TU>(key, value));
    }

    public void Remove(T key)
    {
        var pos = GetPosition(key, items.Length);
        if (items[pos] != null)
        {
            var objToRemove = items[pos].FirstOrDefault(item => item.Item1.Equals(key));
            if (objToRemove == null) return;
            items[pos].Remove(objToRemove);
            size--;
        }
        else
        {
            throw new Exception("Value not in HashTable.");
        }
    }

    public TU Get(T key)
    {
        var pos = GetPosition(key, items.Length);
        foreach (var item in items[pos].Where(item => item.Item1.Equals(key)))
        {
            return item.Item2;
        }
        throw new Exception("Key does not exist in HashTable.");
    }

    private void GrowAndReHash()
    {
        fillFactor *= 2;
        var newItems = new LinkedList<Tuple<T, TU>>[items.Length * 2];
        foreach (var item in items.Where(x => x != null))
        {
            foreach (var value in item)
            {
                var pos = GetPosition(value.Item1, newItems.Length);
                if (newItems[pos] == null)
                {
                    newItems[pos] = new LinkedList<Tuple<T, TU>>();
                }
                newItems[pos].AddFirst(new Tuple<T, TU>(value.Item1, value.Item2));
            }
        }
        items = newItems;
    }

    private int GetPosition(T key, int length)
    {
        var hash = key.GetHashCode();
        var pos = Math.Abs(hash % length);
        return pos;
    }

    private bool NeedToGrow()
    {
        return size >= fillFactor;
    }
}