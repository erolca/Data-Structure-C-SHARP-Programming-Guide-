using System;
using System.Collections.Generic;


//11.36.4.	Display the list backwards by manually walking from last to first


class MainClass
{
    public static void Main()
    {
        // Create an linked list. 
        LinkedList<char> ll = new LinkedList<char>();

        Console.WriteLine("Adding 5 elements.");
        // Add elements to the linked list  
        ll.AddFirst('A');
        ll.AddFirst('B');
        ll.AddFirst('C');
        ll.AddFirst('D');
        ll.AddFirst('E');

        LinkedListNode<char> node;

        Console.Write("Follow links backwards: ");
        for (node = ll.Last; node != null; node = node.Previous)
            Console.Write(node.Value + " ");

        Console.WriteLine("\n");
    }
}
//Adding 5 elements.
//Follow links backwards: A B C D E