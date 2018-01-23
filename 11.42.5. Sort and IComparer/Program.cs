using System;
using System.Collections.Generic;


//11.42.5.	Sort and IComparer<(Of <(TKey>)>)),


public class ReverseComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        return y.CompareTo(x);
    }
}

public class Example
{
    public static void Main()
    {
        string[] letters = { "A", "B", "E", "C", "F", "G" };

        int[] letterSizes = { 40, 5, 3, 22, 1, 18 };

        Console.WriteLine();
        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine("{0}: up to {1} meters long.", letters[i], letterSizes[i]);
        }

        Console.WriteLine("\nSort(letters, letterSizes)");
        Array.Sort(letters, letterSizes);

        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine("{0}: up to {1} meters long.",
                letters[i], letterSizes[i]);
        }

        ReverseComparer rc = new ReverseComparer();
        Console.WriteLine("\nSort(letters, letterSizes, rc)");
        Array.Sort(letters, letterSizes, rc);

        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine("{0}: up to {1} meters long.",
                letters[i], letterSizes[i]);
        }

        Console.WriteLine("\nSort(letters, letterSizes, 3, 3)");
        Array.Sort(letters, letterSizes, 3, 3);
        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine("{0}: up to {1} meters long.",
                letters[i], letterSizes[i]);
        }

        Console.WriteLine("\nSort(letters, letterSizes, 3, 3, rc)");
        Array.Sort(letters, letterSizes, 3, 3, rc);
        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine("{0}: up to {1} meters long.",
                letters[i], letterSizes[i]);
        }
    }
}