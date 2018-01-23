using System;
using System.Collections;


//11.38.2.	Clear a Queue


class MainClass
{
    static void Main(string[] args)
    {
        Queue a = new Queue(10);
        int x = 0;

        a.Enqueue(x);
        x++;
        a.Enqueue(x);
        foreach (int y in a)
        {
            Console.WriteLine(y);
        }

        a.Dequeue();
        a.Clear();
    }
}
//0
//1