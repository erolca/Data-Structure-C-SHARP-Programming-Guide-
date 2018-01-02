using System;
using System.Collections;


//11.21.13.	Use ArrayList.ToArray to create an object array from the contents of the collection

class MainClass
{
    public static void Main(string[] args)
    {
        // Create a new ArrayList and populate it.
        ArrayList list = new ArrayList(5);
        list.Add("B");
        list.Add("G");
        list.Add("J");
        list.Add("S");
        list.Add("M");


        object[] array2 = list.ToArray();
       

        Console.WriteLine("Array 2:");
        foreach (string s in array2)
        {
            Console.WriteLine("\t{0}", s);
        }

    }
}
//Array 2:
//        B
//        G
//        J
//        S
//        M