using System;
using System.Collections;
using System.Globalization;


//11.33.1.	Create a SortedList using the default comparer


public class SamplesSortedList
{
    public static void Main()
    {

        SortedList mySL1 = new SortedList(3);
        Console.WriteLine("mySL1 (default):");
        mySL1.Add("FIRST", "Hello");
        mySL1.Add("SECOND", "World");
        mySL1.Add("THIRD", "!");
        try
        {
            mySL1.Add("first", "Ola!");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }
        PrintKeysAndValues(mySL1);

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