using System;
using System.Collections;


//11.38.1.	Enqueue and dequeue

class MainClass
{

    public static void Main()
    {
        Queue q = new Queue();

        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);

        Console.Write("queue: ");
        foreach (int i in q)
            Console.Write(i + " ");

        Console.WriteLine();

        Console.Write("Dequeue -> ");
        int a = (int)q.Dequeue();
        Console.WriteLine(a);

        Console.Write("queue: ");
        foreach (int i in q)
            Console.Write(i + " ");

        Console.WriteLine();

    }
}
//queue: 1 2 3 4
//Dequeue -> 1
//queue: 2 3 4