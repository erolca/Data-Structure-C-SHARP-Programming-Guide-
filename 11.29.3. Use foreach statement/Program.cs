using System;
using System.Collections;


//11.29.3.	Use foreach statement to loop through all keys in a hashtable


class MainClass
{
    public static void Main()
    {
        Hashtable hash = new Hashtable();
        hash.Add("A", "1");
        hash.Add("B", "2");
        hash.Add("C", "3");
        hash.Add("D", "4");
        hash.Add("E", "5");

        foreach (string firstName in hash.Keys)
        {
            Console.WriteLine("{0} {1}", firstName, hash[firstName]);
        }

        
    }
}
//A 1
//B 2
//C 3
//D 4
//E 5