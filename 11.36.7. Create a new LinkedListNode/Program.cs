using System;
using System.Collections.Generic;


//	11.36.7.	Create a new LinkedListNode of type String and displays its properties



public class GenericCollection
{
    public static void Main()
    {
        LinkedListNode<String> lln = new LinkedListNode<String>("XX");
        DisplayProperties(lln);

        LinkedList<String> ll = new LinkedList<String>();

        ll.AddLast(lln);
        DisplayProperties(lln);

        ll.AddFirst("A");
        ll.AddLast("B");
        DisplayProperties(lln);

    }

    public static void DisplayProperties(LinkedListNode<String> lln)
    {
        if (lln.List == null)
            Console.WriteLine("Node is not linked.");
        else
            Console.WriteLine("Node belongs to a linked list with {0} elements.", lln.List.Count);

        if (lln.Previous == null)
            Console.WriteLine("Previous node is null.");
        else
            Console.WriteLine("Value of previous node:{0}", lln.Previous.Value);

        Console.WriteLine("Value of current node:{0}", lln.Value);

        if (lln.Next == null)
            Console.WriteLine("Next node is null.");
        else
            Console.WriteLine("Value of next node:{0}", lln.Next.Value);
    }

}

