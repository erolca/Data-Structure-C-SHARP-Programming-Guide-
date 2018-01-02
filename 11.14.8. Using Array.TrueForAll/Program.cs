using System;

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


        Console.WriteLine("\nArray.TrueForAll(letters, EndsWithS): {0}", Array.TrueForAll(letters, EndsWithS));
        Console.WriteLine();


        //consol-2
        //String[] values = { "Y2K", "A2000", "DC2A6", "MMXIV", "0C3","1256" };
        String[] values = { "256", "5", "25", "48", "63", "1256" };
        if (Array.TrueForAll(values, value => {
            int s;
            // return Int32.TryParse(value.Substring(value.Length - 1), out s);   }
            return Int32.TryParse(value, out s);
        }
                                     ))
            Console.WriteLine("All elements end with an integer.");
        else
            Console.WriteLine("Not all elements end with an integer.");
    }

    //All elements end with an integer.




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