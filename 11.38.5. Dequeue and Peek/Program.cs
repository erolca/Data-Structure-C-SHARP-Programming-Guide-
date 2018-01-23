using System;
using System.Collections.Generic;

public class Tester
{
    static void Main()
    {
        Queue<Int32> intQueue = new Queue<Int32>();
        for (int i = 0; i < 5; i++)
        {
            intQueue.Enqueue(i * 5);
        }
        PrintValues(intQueue);
        Console.WriteLine("\n(Dequeue)\t{0}", intQueue.Dequeue());
        Console.Write("intQueue values:\t");
        PrintValues(intQueue);
        Console.WriteLine("\n(Dequeue)\t{0}", intQueue.Dequeue());
        PrintValues(intQueue);
        Console.WriteLine("\n(Peek) \t{0}", intQueue.Peek());
        Console.Write("intQueue values:\t");
        PrintValues(intQueue);
    }

    public static void PrintValues(IEnumerable<Int32> myCollection)
    {
        IEnumerator<Int32> myEnumerator = myCollection.GetEnumerator();
        while (myEnumerator.MoveNext())
            Console.Write("{0} ", myEnumerator.Current);
    }
}