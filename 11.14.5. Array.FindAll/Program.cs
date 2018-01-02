using System;

public class Example
{
    public static void Main()
    {
        string[] letters = { "Deneme", "B", "A", "Z", "D", "X", "Y", "Q" };

        Console.WriteLine();
        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nArray.FindAll(letters, EndsWithS):");
        string[] subArray = Array.FindAll(letters, EndsWithS);

        foreach (string letter in subArray)
        {
            Console.WriteLine(letter);
        }
    }
    private static bool EndsWithS(String s)
    {
        if ((s.Length > 5) &&
            (s.Substring(0,1).ToLower() == "d"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}