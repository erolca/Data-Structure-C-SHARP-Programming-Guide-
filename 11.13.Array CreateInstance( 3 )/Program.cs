using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


public class MainClass
{

    public static void Main()
    {
        string[] myArray = (string[])Array.CreateInstance(typeof(string), 15);
        Console.WriteLine(myArray.GetType());
        Console.WriteLine(myArray.GetLength(0));
        Console.WriteLine(myArray.GetLowerBound(0));
        myArray.SetValue("Hello, array", 5);
        Console.WriteLine(myArray.GetValue(5));
    }
}
//System.String[]
//15
//0
//Hello, array