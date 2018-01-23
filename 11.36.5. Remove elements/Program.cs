using System;
using System.Collections.Generic;


//11.36.5.	Remove elements from the linked list


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


        Console.WriteLine("Removing 2 elements.");
        ll.Remove('C');
        ll.Remove('A');

        Console.WriteLine("Number of elements: " +
                           ll.Count);
    }
}
//Adding 5 elements.
//Removing 2 elements.
//Number of elements: 3