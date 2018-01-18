using System;
using System.Collections.Generic;

//Important Properties and Methods of IDictionary<TKey, TValue>:


class MainClass
{
    public static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        // Add elements to the collection. 
        dict.Add("A", 7);
        dict.Add("B", 5);
        dict.Add("C", 4);
        dict.Add("D", 9);
        dict.Add("apple", 25);
        dict.Add("windows", 5);

        // Get a collection of the keys (names). 
        ICollection<string> c = dict.Keys;

        foreach (string str in c)
            Console.WriteLine("{0}, Salary: {1:C}", str, dict[str]);

        // See whether Dictionary contains this string.
        if (dict.ContainsKey("apple"))
        {
            int value = dict["apple"];
            Console.WriteLine(value);
        }

    }
}
//A, Salary: 7,00 ?
//B, Salary: 5,00 ?
//C, Salary: 4,00 ?
//D, Salary: 9,00 ?
//apple, Salary: 25,00 ?
//windows, Salary: 5,00 ?
//25
