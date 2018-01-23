using System;
using System.Collections.Generic;


//11.34.20.	List range operation

public class Example
{
    public static void Main()
    {
        string[] input = { "F", "B", "C" };

        List<string> letters = new List<string>(input);

        Console.WriteLine("\nCapacity: {0}", letters.Capacity);


        Console.WriteLine("\nAddRange(letters)");
        letters.AddRange(letters);

        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nRemoveRange(2, 2)");
        letters.RemoveRange(2, 2);

        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        input = new string[] { "A", "D", "Z" };

        Console.WriteLine("\nInsertRange(3, input)");
        letters.InsertRange(3, input);

        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\noutput = letters.GetRange(2, 3).ToArray()");
        string[] output = letters.GetRange(2, 3).ToArray();

        Console.WriteLine();
        foreach (string letter in output)
        {
            Console.WriteLine(letter);
        }
    }
}