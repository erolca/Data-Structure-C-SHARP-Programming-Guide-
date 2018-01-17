using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

//11.26.3.	ICollection: Search for some specific elements

public class MainClass
{

    public static void Main()
    {
        ICollection<int> myCollection = new Collection<int>();

        myCollection.Add(105);
        myCollection.Add(232);
        myCollection.Add(350);

        Console.WriteLine("Contains {0}? {1}", 105, myCollection.Contains(105));
        Console.WriteLine("Contains {0}? {1}", 232, myCollection.Contains(232));

    }
}
//Contains 105? True
//Contains 232? True