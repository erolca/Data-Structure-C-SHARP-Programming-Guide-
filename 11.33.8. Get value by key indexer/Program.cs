using System;
using System.Collections;

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
       // mySortedList.Add("CAD", 1131);

        string myState = (string)mySortedList["CA"];
        Console.WriteLine("myState = " + myState);

        // display the keys for mySortedList using the Keys property
        foreach (string myKey in mySortedList.Keys)
        {
            Console.WriteLine("myKey = " + myKey);
        }

        // display the values for mySortedList using the Values property
        foreach (string myValue in mySortedList.Values)
        {
            Console.WriteLine("myValue = " + myValue);
        }
    }
}
//myState = California
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