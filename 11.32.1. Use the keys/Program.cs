using System;
using System.Collections.Generic;


//	11.32.1.Use the keys to obtain the values from a generic SortedDictionary class.


class MainClass
{
    public static void Main()
    {
        SortedDictionary<string, double> dict = new SortedDictionary<string, double>();

        dict.Add("A", 7);
        dict.Add("B", 5);
        dict.Add("C", 4);
        dict.Add("D", 9);

        // Get a collection of the keys (names). 
        ICollection<string> c = dict.Keys;
        ICollection<double> d = dict.Values;

        foreach (string str in c)
            Console.WriteLine("{0}, Salary: {1:C}", str, dict[str]);
    }
}
//A, Salary: $7.00
//B, Salary: $5.00
//C, Salary: $4.00
//D, Salary: $9.00