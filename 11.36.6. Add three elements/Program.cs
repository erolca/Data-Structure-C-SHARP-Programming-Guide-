using System;
using System.Collections.Generic;


//11.36.6.	Add three elements to the end of the list


class MainClass
{
    public static void Main()
    {
        LinkedList<char> ll = new LinkedList<char>();

        Console.WriteLine("Adding 5 elements.");
        ll.AddFirst('A');
        ll.AddFirst('B');
        ll.AddFirst('C');
        ll.AddFirst('D');
        ll.AddFirst('E');

        ll.AddLast('X');
        ll.AddLast('Y');
        ll.AddLast('Z');

        Console.Write("Contents after addition to end: ");
        foreach (char ch in ll)
            Console.Write(ch + " ");

        Console.WriteLine("\n");
    }
}
//Adding 5 elements.
//Contents after addition to end: E D C B A X Y Z