using System;
using System.Collections;


//	11.33.9.	Use the ContainsValue() method to check if mySortedList contains a value


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

        if (mySortedList.ContainsValue("Florida"))
        {
            Console.WriteLine("mySortedList contains the value Florida");
        }
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
//mySortedList contains the value Florida