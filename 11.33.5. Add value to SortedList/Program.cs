using System;
using System.Collections;


//11.33.5.	Add value to SortedList and get contents by integer indexes

class MainClass
{
    public static void Main()
    {
        SortedList sl = new SortedList();

        sl.Add("a", "A");
        sl.Add("b", "B");
        sl.Add("c", "C");
        sl.Add("d", "D");

        // Get a collection of the keys. 
        ICollection c = sl.Keys;

        // Display list using integer indexes. 
        Console.WriteLine("Contents by integer indexes.");
        for (int i = 0; i < sl.Count; i++)
            Console.WriteLine(sl.GetByIndex(i));

    }
}
//Contents by integer indexes.
//A
//B
//C
//D