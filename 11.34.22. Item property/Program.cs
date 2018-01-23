using System;
using System.Collections.Generic;


//11.34.22.	Item property (the indexer in C#) and various other properties and methods of the List<(Of <(T>)>) generic class.

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

        Console.WriteLine("Capacity: {0}", letters.Capacity);
        Console.WriteLine("Count: {0}", letters.Count);

        Console.WriteLine("Contains(\"D\"): {0}",
            letters.Contains("D"));

        Console.WriteLine("Insert(2, \"E\")");
        letters.Insert(2, "E");

        Console.WriteLine();
        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nletters[3]: {0}", letters[3]);

        Console.WriteLine("\nRemove(\"E\")");
        letters.Remove("E");

        Console.WriteLine();
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

//Capacity: 0

//A
//B
//C
//D
//E
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