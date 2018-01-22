using System;
using System.Collections;
using System.Globalization;

//11.33.3.	Create a SortedList using the specified CaseInsensitiveComparer, which is based on the Turkish culture (tr-TR)

public class SamplesSortedList
{
    public static void Main()
    {
        CultureInfo myCul = new CultureInfo("tr-TR");
        SortedList mySL3 = new SortedList(new CaseInsensitiveComparer(myCul), 3);

        Console.WriteLine("mySL3 (case-insensitive comparer, Turkish culture):");

        mySL3.Add("FIRST", "Hello");
        mySL3.Add("SECOND", "World");
        mySL3.Add("THIRD", "!");
        try
        {
            mySL3.Add("first", "Ola!");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }
        PrintKeysAndValues(mySL3);

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
