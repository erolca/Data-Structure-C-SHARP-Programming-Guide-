using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


public class MainClass
{
    public static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddFirst(10);
        list.AddLast(15);
        list.AddLast(3);
        list.AddLast(99);
        list.AddBefore(list.Last, 25);

        LinkedListNode<int> node = list.First;
        while (node != null)
        {
            Console.WriteLine(node.Value);
            node = node.Next;
        }
    }
}
//10
//15
//3
//25
//99