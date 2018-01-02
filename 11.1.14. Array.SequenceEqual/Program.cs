using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


public class MainClass
{

    public static void Main(string[] args)
    {
        String[] Array1 = { "Zero", "One", "Two", "Three" };
        String[] Array2 = { "Zero", "One", "Two", "Three" };

        var ThisQuery = Array1.SequenceEqual(Array2);

        Console.WriteLine("Array1 = Array2: " + ThisQuery.ToString());

    }  
}
//Array1 = Array2: True