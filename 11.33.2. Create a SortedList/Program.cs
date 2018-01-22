using System;
using System.Collections;
using System.Globalization;


//	11.33.2.	Create a SortedList using the specified case-insensitive comparer


public class SamplesSortedList
{
    public static void Main()
    {
        SortedList mySL2 = new SortedList(new CaseInsensitiveComparer(), 3);
        Console.WriteLine("mySL2 (case-insensitive comparer):");
        mySL2.Add("FIRST", "Hello");
        mySL2.Add("SECOND", "World");
        mySL2.Add("THIRD", "!");
        try
        {
            mySL2.Add("first", "Ola!");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }
        PrintKeysAndValues(mySL2);

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