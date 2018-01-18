using System;
using System.Collections.Generic;

public class Tester
{
    static void Main()
    {
        Dictionary<string, string> Dictionary = new Dictionary<string, string>();
        Dictionary.Add("1", "J");
        Dictionary.Add("2", "S");
        Dictionary.Add("3", "D");
        Dictionary.Add("4", "A");
        Console.WriteLine(Dictionary["1"]);
    }
}