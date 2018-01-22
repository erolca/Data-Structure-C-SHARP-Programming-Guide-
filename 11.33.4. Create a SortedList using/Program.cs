using System;
using System.Collections;
using System.Globalization;

//11.33.4.	Create a SortedList using the StringComparer.InvariantCultureIgnoreCase value

public class SamplesSortedList
{
    public static void Main()
    {
        SortedList mySL4 = new SortedList(StringComparer.InvariantCultureIgnoreCase, 3);

        Console.WriteLine("mySL4 (InvariantCultureIgnoreCase):");
        mySL4.Add("FIRST", "Hello");
        mySL4.Add("SECOND", "World");
        mySL4.Add("THIRD", "!");
        try
        {
            mySL4.Add("first", "Ola!");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }
        PrintKeysAndValues(mySL4);

    }

    public static void PrintKeysAndValues(SortedList myList)
    {
        Console.WriteLine("        -KEY-   -VALUE-");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("{0,-6}: {1}", myList.GetKey(i), myList.GetByIndex(i));
        }
    }
}