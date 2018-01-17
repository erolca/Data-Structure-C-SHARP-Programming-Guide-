using System;
using System.Collections;

//11.24.2.	Use ArrayList.ToArray to create a strongly typed string array from the contents of the collection

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


        // Get the array.
        string[] array3 = (string[])list.ToArray(typeof(String));

        Console.WriteLine("Array 3:");
        foreach (string s in array3)
        {
            Console.WriteLine("\t{0}", s);
        }

    }
}
//Array 3:
//        B
//        G
//        J
//        S
//        M