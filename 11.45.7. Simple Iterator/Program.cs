using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static IEnumerable SimpleList()
    {
        yield return "string 1";
        yield return "string 2";
        yield return "string 3";
    }

    public static void Main(string[] args)
    {
        foreach (string item in SimpleList())
            Console.WriteLine(item);
    }
}