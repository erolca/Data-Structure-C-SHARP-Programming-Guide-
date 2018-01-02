using System;

public class Example
{
    public static void Main()
    {
        string[] letters = { "A", "B", "C", "F", "D", "A", "E" };

        Console.WriteLine("\nArray.LastIndexOf(letters, \"A\"): {0}", Array.LastIndexOf(letters, "A"));

        Console.WriteLine("\nArray.LastIndexOf(letters, \"A\", 3): {0}", Array.LastIndexOf(letters, "A", 3));

        Console.WriteLine("\nArray.LastIndexOf(letters, \"A\", 4, 4): {0}", Array.LastIndexOf(letters, "A", 4, 4));
    }
}