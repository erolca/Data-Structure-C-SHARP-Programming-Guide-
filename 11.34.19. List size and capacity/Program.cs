using System;
using System.Collections.Generic;


//11.34.19.	List size and capacity

public class Example
{
    public static void Main()
    {
        List<string> letters = new List<string>();

        Console.WriteLine("\nCapacity: {0}", letters.Capacity);

        letters.Add("A");
        letters.Add("B");
        letters.Add("C");
        letters.Add("D");
        letters.Add("E");

        Console.WriteLine();
        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nCapacity: {0}", letters.Capacity);
        Console.WriteLine("Count: {0}", letters.Count);

        Console.WriteLine("\nContains(\"D\"): {0}", letters.Contains("D"));

        Console.WriteLine("\nInsert(2, \"E\")");
        letters.Insert(2, "E");

        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nletters[3]: {0}", letters[3]);

        Console.WriteLine("\nRemove(\"E\")");
        letters.Remove("E");

        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        letters.TrimExcess();
        Console.WriteLine("\nTrimExcess()");
        Console.WriteLine("Capacity: {0}", letters.Capacity);
        Console.WriteLine("Count: {0}", letters.Count);

        letters.Clear();
        Console.WriteLine("\nClear()");
        Console.WriteLine("Capacity: {0}", letters.Capacity);
        Console.WriteLine("Count: {0}", letters.Count);
    }
}

//Capacity: 8
//Count: 5

//Contains("D") : True

// Insert(2, "E")
//A
//B
//E
//C
//D
//E

//letters[3]: C

//Remove("E")
//A
//B
//C
//D
//E

//TrimExcess()
//Capacity: 5
//Count: 5

//Clear()
//Capacity: 5
//Count: 0
