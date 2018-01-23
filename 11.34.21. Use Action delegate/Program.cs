using System;
using System.Collections.Generic;


//11.34.21.	Use Action<(Of <(T>)>) delegate to print the contents of a List<(Of <(T>)>) object.


class Program
{
    static void Main()
    {
        List<String> names = new List<String>();
        names.Add("A");
        names.Add("B");
        names.Add("C");
        names.Add("D");

        names.ForEach(Print);

        names.ForEach(delegate (String name)
        {
            Console.WriteLine(name);
        });
    }

    private static void Print(string s)
    {
        Console.WriteLine(s);
    }
}