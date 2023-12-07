
 * using System;
using System.Collections.Generic;

class Stack<T>
{
    private List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
        Console.WriteLine($"Pushed: {item}");
    }

    public T Pop()
    {
        if (!IsEmpty())
        {
            T poppedItem = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            Console.WriteLine($"Popped: {poppedItem}");
            return poppedItem;
        }
        else
        {
            Console.WriteLine("Stack is empty. Cannot pop.");
            return default(T);
        }
    }

    public T Peek()
    {
        if (!IsEmpty())
        {
            T topItem = items[items.Count - 1];
            Console.WriteLine($"Peeked: {topItem}");
            return topItem;
        }
        else
        {
            Console.WriteLine("Stack is empty. Cannot peek.");
            return default(T);
        }
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);

        intStack.Peek();

        int poppedItem = intStack.Pop();
        Console.WriteLine($"Remaining items in the stack after pop: {string.Join(", ", intStack)}");

        intStack.Pop();
        intStack.Pop();
        intStack.Pop();

        bool isEmpty = intStack.IsEmpty();
        Console.WriteLine($"Is the stack empty? {isEmpty}");
    }
}