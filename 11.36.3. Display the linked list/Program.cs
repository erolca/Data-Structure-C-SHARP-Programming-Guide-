using System;
using System.Collections.Generic;


//	11.36.3.	Display the linked list by using a foreach loop


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


        Console.Write("Display contents with foreach loop: ");
        foreach (char ch in ll)
            Console.Write(ch + " ");

        Console.WriteLine("\n");

    }
}
//Adding 5 elements.
//Number of elements: 5
//Display contents with foreach loop: E D C B A