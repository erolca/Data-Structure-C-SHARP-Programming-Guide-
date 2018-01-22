using System;
using System.Collections;
using System.Collections.Generic;

class MainClass
{
    public static void Main()
    {
        SortedList sl = new SortedList();

        sl.Add("a", "A");
        sl.Add("b", "B");
        sl.Add("c", "C");
        sl.Add("d", "D");

        // add by using the indexer. 
        sl["e"] = "E";

        // Get a collection of the keys. 
        ICollection c = sl.Keys;
        ICollection d = sl.Values;

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
//E