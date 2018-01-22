using System;
using System.Collections;


//11.33.13.	Get the index of the element with a value using the IndexOfValue() method


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
        int myIndex = mySortedList.IndexOfValue("New York");
        Console.WriteLine("The index of New York is " + myIndex);
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
//The index of New York is 3