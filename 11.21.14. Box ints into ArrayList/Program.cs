using System;
using System.Collections;

class MainClass
{
    static void Main(string[] args)
    {
        ArrayList myInts = new ArrayList();
        myInts.Add(8);
        myInts.Add(3);
        myInts.Add(9);
        myInts.Add("MERHABA");

        // Unbox first item.
        int firstItem = (int)myInts[0];
        string str = (string) myInts[3];

        // Another boxing operation!
        Console.WriteLine("First item is {0}", firstItem);
    }
}
//First item is 8