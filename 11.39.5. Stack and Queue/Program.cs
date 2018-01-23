using System;
using System.Collections;


//11.39.5.	Stack and Queue are both ICollection


class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        string input = "this is a test";
        string[] names = input.Split(' ');

        PrintCollection("Input", names);

        TestStack(names);
        TestQueue(names);
    }

    static void PrintCollection(string name, ICollection coll)
    {
        Console.Write(name + ": ");
        foreach (object elem in coll)
        {
            Console.Write(elem.ToString() + ' ');
        }
    }
    static void TestStack(string[] names)
    {
        Stack nameStack = new Stack();

        foreach (string name in names)
        {
            nameStack.Push(name);
            Console.WriteLine("Pushed value: {0}", name);
            PrintCollection("New Stack", nameStack);
        }
        int pops = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= pops; i++)
        {
            Console.WriteLine("Popped value: " + nameStack.Pop());
            PrintCollection("Stack after " + i.ToString() + " pops", nameStack);
        }
    }
    static void TestQueue(string[] names)
    {
        Queue nameQueue = new Queue();
        foreach (string name in names)
        {
            nameQueue.Enqueue(name);
            Console.WriteLine("Enqueued value: {0}", name);
            PrintCollection("New Queue", nameQueue);
        }

        Console.Write("Dequeue how many items? ");
        int dequeues = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= dequeues; i++)
        {
            Console.WriteLine("Dequeued value: " + nameQueue.Dequeue());
            PrintCollection("Queue after ", nameQueue);
        }
    }
}