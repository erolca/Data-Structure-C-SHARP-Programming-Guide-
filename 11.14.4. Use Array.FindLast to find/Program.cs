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

        Console.WriteLine("\nArray.FindLast(letters, EndsWithS): {0}", Array.FindLast(letters, EndsWithS));
    }



    private static bool EndsWithS(String s)
    {
        if ((s.Length > 5) &&
            (s.Substring(0 /*s.Length - 6*/,1).ToLower() == "d"))
           // (s.Substring(s.Length - 6, 1).ToLower() == "s"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}