using System;
//11.14.2.	Use Array.Exists to check if a certain element exist
public class Example
{
    public static void Main()
    {
        string[] letters = { "E", "B", "A", "Z", "D", "X", "Y", "Q" };

        Console.WriteLine();
        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nArray.Exists(letters, EndsWithS): {0}", Array.Exists(letters, EndsWithS));

    }
    private static bool EndsWithS(String s)
    {
        if ((s.Length > 5) &&
            (s.Substring(s.Length - 6).ToLower() == "s"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}