using System;
using System.Collections.Generic;


//	11.36.1.	Add value to generic LinkList and check the element count


class MainClass
{
    public static void Main()
    {
        // Create an linked list. 
        LinkedList<char> ll = new LinkedList<char>();

        Console.WriteLine("Initial number of elements: " +
                           ll.Count);

        Console.WriteLine();

        Console.WriteLine("Adding 5 elements.");
        // Add elements to the linked list  
        ll.AddFirst('A');
        ll.AddFirst('B');
        ll.AddFirst('C');
        ll.AddFirst('D');
        ll.AddFirst('E');

        Console.WriteLine("Number of elements: " +
                           ll.Count);
    }
}
//Initial number of elements: 0

//Adding 5 elements.
//Number of elements: 5