using System;
using System.Collections;


//11.18.3.	Display the contents of the sorted array

class MainClass
{
    public static void Main(string[] args)
    {
        // Create a new array and populate it.
        int[] array = { 4, 2, 9, 3 };

        // Sort the array.
        Array.Sort(array);

        foreach (int i in array)
        {
            Console.WriteLine(i);
        }

    }
}
//2
//3
//4
//9