using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {

        int[] integers = { 1, 6, 2, 27 };

        IEnumerable<int> twoDigits = from numbers in integers where numbers >= 10 select numbers;
        Console.WriteLine("Integers > 10:");
        foreach (var number in twoDigits)
        {
            Console.WriteLine(number);
        }
    }
}