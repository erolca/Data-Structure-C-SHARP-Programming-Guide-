using System;
using System.Collections;


//11.29.7.	Use the ContainsKey() method to check if Hashtable contains a key

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

        if (myHashtable.ContainsKey("FL"))
        {
            Console.WriteLine("myHashtable contains the key FL");
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
//myHashtable contains the key FL