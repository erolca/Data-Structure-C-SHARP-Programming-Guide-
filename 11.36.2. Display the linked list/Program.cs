using System;
using System.Collections.Generic;


//11.36.2.	Display the linked list by manually walking through the list



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

        Console.WriteLine("Number of elements: " +
                           ll.Count);
        LinkedListNode<char> node;

        Console.Write("Display contents by following links: ");
        for (node = ll.First; node != null; node = node.Next)
            Console.Write(node.Value + " ");

    }
}
//Adding 5 elements.
//Number of elements: 5
//Display contents by following links: E D C B A