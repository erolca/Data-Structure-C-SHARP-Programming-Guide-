using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        SortedList sl = new SortedList();

        sl.Add("a", "1");
        sl.Add("b", "2");
        sl.Add("c", "3");
        sl.Add("d", "4");

        Console.WriteLine();

        // Show integer indexes of entries. 
        Console.WriteLine("Integer indexes of entries.");
        foreach (string str in sl.Keys)
            Console.WriteLine(str + ": " + sl.IndexOfKey(str));
    }
}
//Integer indexes of entries.
//a: 0
//b: 1
//c: 2
//d: 3