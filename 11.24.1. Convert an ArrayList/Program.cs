using System;
using System.Collections;

//11.24.1.	Convert an ArrayList into an array

class MainClass
{
    public static void Main()
    {
        ArrayList al = new ArrayList();

        // Add elements to the array list. 
        al.Add(1);
        al.Add(2);
        al.Add(3);
        al.Add(4);

        Console.Write("Contents: ");
        foreach (int i in al)
            Console.Write(i + " ");
        Console.WriteLine();

        // Get the array. 
        int[] ia = (int[])al.ToArray(typeof(int));
        int sum = 0;

        // sum the array 
        for (int i = 0; i < ia.Length; i++)
            sum += ia[i];

        Console.WriteLine("Sum is: " + sum);
    }
}
//Contents: 1 2 3 4
//Sum is: 10