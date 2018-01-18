using System;
using System.Collections;

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

        Console.WriteLine("Copying keys to myKeys array");

        string[] myKeys = new string[5];
        myHashtable.Keys.CopyTo(myKeys, 0);

        for (int counter = 0; counter < myKeys.Length; counter++)
        {
            Console.WriteLine("myKeys[" + counter + "] = " + myKeys[counter]);
        }
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
//Copying keys to myKeys array
//myKeys[0] = NY
//myKeys[1] = CA
//myKeys[2] = FL
//myKeys[3] = WY
//myKeys[4] = AL