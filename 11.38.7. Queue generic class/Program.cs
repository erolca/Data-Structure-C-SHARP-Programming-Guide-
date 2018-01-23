using System;
using System.Collections.Generic;


//	11.38.7.	Queue<(Of <(T>)>) generic class, the Dequeue method.


class Example
{
    public static void Main()
    {
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
        Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
        Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

    }
}