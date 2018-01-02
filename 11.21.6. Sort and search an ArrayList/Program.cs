using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        // create an array list 
        ArrayList al = new ArrayList();

        // Add elements to the array list 
        al.Add(155);
        al.Add(413);
        al.Add(-41);
        al.Add(818);
        al.Add(31);
        al.Add(191);

        Console.Write("Original contents: ");
        foreach (int i in al)
            Console.Write(i + " ");
        Console.WriteLine("\n");

        // Sort 
        al.Sort();

        // Use foreach loop to display the list. 
        Console.Write("Contents after sorting: ");
        foreach (int i in al)
            Console.Write(i + " ");
        Console.WriteLine("\n");

        Console.WriteLine("Index of 413 is " + al.BinarySearch(413));
    }
}
//Original contents: 155 413 -41 818 31 191

//Contents after sorting: -41 31 155 191 413 818

//Index of 413 is 4