using System;
using System.Collections.Generic;

public class CustomQueue<T>
{
    private List<T> _items;

    public CustomQueue()
    {
        _items = new List<T>();
    }

    // Adds an item to the end of the queue
    public void Enqueue(T item)
    {
        _items.Add(item);
    }

    // Removes and returns the item at the front of the queue
    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T item = _items[0];
        _items.RemoveAt(0);
        return item;
    }

    // Returns the item at the front of the queue without removing it
    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return _items[0];
    }

    // Checks if the queue is empty
    public bool IsEmpty()
    {
        return _items.Count == 0;
    }

    // Returns the number of items in the queue
    public int Count()
    {
        return _items.Count;
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        CustomQueue<int> queue = new CustomQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Front of queue: " + queue.Peek()); // Output: 1
        Console.WriteLine("Dequeue: " + queue.Dequeue()); // Output: 1
        Console.WriteLine("Dequeue: " + queue.Dequeue()); // Output: 2
        Console.WriteLine("Is queue empty? " + queue.IsEmpty()); // Output: False
        Console.WriteLine("Count: " + queue.Count()); // Output: 1
    }
}