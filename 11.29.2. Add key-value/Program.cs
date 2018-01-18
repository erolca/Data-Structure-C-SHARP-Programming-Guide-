using System;
using System.Collections;


//11.29.2.	Add key-value pair to Hashtable by using the indexer


class HashtableDemo
{
    public static void Main()
    {
        Hashtable ht = new Hashtable();


        ht.Add("a", "A");
        ht.Add("b", "B");
        ht.Add("c", "C");
        ht.Add("e", "E");


        ht["f"] = "F";

        // Get a collection of the keys. 
        ICollection c = ht.Keys;

        foreach (string str in c)
            Console.WriteLine(str + ": " + ht[str]);
    }
}
//a: A
//b: B
//c: C
//e: E
//f: F