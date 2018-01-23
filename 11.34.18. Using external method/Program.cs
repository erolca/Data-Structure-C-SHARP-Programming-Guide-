using System;
using System.Collections.Generic;


//11.34.18.	Using external method to pass into Find method


class Program
{
    static void Main(string[] args)
    {
        List<string> myList = new List<string>();
        myList.Add("A");
        myList.Add("B");
        myList.Add("C");
        myList.Add("D");
        string vanilla = myList.Find(FindVanilla);
        Console.WriteLine(vanilla);
    }

    public static bool FindVanilla(string icecream)
    {
        return icecream.Equals("B");
    }
}