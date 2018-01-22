using System;
using System.Collections;


//	11.33.10.	Use the Remove() method to remove a key from SortedList


class MainClass
{

    public static void Main()
    {
        SortedList mySortedList = new SortedList();

        mySortedList.Add("NY", "New York");
        mySortedList.Add("FL", "Florida");
        mySortedList.Add("AL", "Alabama");
        mySortedList.Add("WY", "Wyoming");
        mySortedList.Add("CA", "California");

        foreach (string myKey in mySortedList.Keys)
        {
            Console.WriteLine("myKey = " + myKey);
        }

        foreach (string myValue in mySortedList.Values)
        {
            Console.WriteLine("myValue = " + myValue);
        }

        Console.WriteLine("Removing FL from mySortedList");
        mySortedList.Remove("FL");
    }
}
//myKey = AL
//myKey = CA
//myKey = FL
//myKey = NY
//myKey = WY
//myValue = Alabama
//myValue = California
//myValue = Florida
//myValue = New York
//myValue = Wyoming
//Removing FL from mySortedList