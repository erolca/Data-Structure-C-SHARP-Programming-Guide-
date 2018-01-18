using System;
using System.Collections;


//	11.31.1.	Demonstrate IDictionaryEnumerator


class MainClass
{
    public static void Main()
    {
        // Create a hash table. 
        Hashtable ht = new Hashtable();

        // Add elements to the table 
        ht.Add("A", "3");
        ht.Add("B", "9");
        ht.Add("C", "3");
        ht.Add("D", "7");

        // Demonstrate enumerator 
        IDictionaryEnumerator etr = ht.GetEnumerator();
        Console.WriteLine("Display info using Entry.");
        while (etr.MoveNext())
            Console.WriteLine(etr.Entry.Key + ": " +
                              etr.Entry.Value);

        Console.WriteLine();

        Console.WriteLine("Display info using Key and Value directly.");
        etr.Reset();
        while (etr.MoveNext())
            Console.WriteLine(etr.Key + ": " +
                              etr.Value);

    }
}
//Display info using Entry.
//A: 3
//B: 9
//C: 3
//D: 7

//Display info using Key and Value directly.
//A: 3
//B: 9
//C: 3
//D: 7