using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class MainClass
{

    public static void Main()
    {
        Hashtable myHashtable = new Hashtable();

        myHashtable.Add("AL", "Alabama");
        myHashtable.Add("CA", "California");
        myHashtable.Add("FL", "Florida");
        myHashtable.Add("NY", "New York");
        myHashtable.Add("WY", "Wyoming");

        foreach (string myKey in myHashtable.Keys)
        {
            Console.WriteLine("myKey = " + myKey);
        }
        foreach (string myValue in myHashtable.Values)
        {
            Console.WriteLine("myValue = " + myValue);
        }

        Console.WriteLine("Copying values to myValues array");
        string[] myValues = new string[5];
        myHashtable.Values.CopyTo(myValues, 0);
        for (int counter = 0; counter < myValues.Length; counter++)
        {
            Console.WriteLine("myValues[" + counter + "] = " + myValues[counter]);
        }





        ICollection<int> myCollection = new Collection<int>();
        int[] myArray;

        myCollection.Add(105);
        myCollection.Add(232);
        myCollection.Add(350);

        myArray = new int[myCollection.Count];
        myCollection.CopyTo(myArray, 0); //copy to array

        for (int i = 0; i < myArray.Length; i++)
            Console.WriteLine(myArray[i]);

    }
}
//myKey = NY
//myKey = CA
//myKey = FL
//myKey = WY
//myKey = AL
//myValue = New York
//myValue = California
//myValue = Florida
//myValue = Wyoming
//myValue = Alabama
//Copying values to myValues array
//myValues[0] = New York
//myValues[1] = California
//myValues[2] = Florida
//myValues[3] = Wyoming
//myValues[4] = Alabama