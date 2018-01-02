using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

//11.19.2.	Array.ConvertAll: convert all string elements from lower case to upper case
/*
 
     public static TOutput[] ConvertAll<TInput, TOutput>(
	TInput[] array,
	Converter<TInput, TOutput> converter)
     
*/

public class MainClass
{

    public static void Main()
    {
        string[] strArray2 = new string[] { "Blah", "Foo", "Canonical" };
        Console.Write("Before converting to-upper: ");

        Array.ForEach<string>(strArray2, delegate (string x) { Console.Write(x + " "); });
        Console.WriteLine();



        string[] revArray = Array.ConvertAll<string, string>(strArray2, delegate (string s) { return s.ToUpper(); });
        Console.Write("Converted to upper-case: ");

        Array.ForEach<string>(revArray, delegate (string x) { Console.Write(x + " "); });
        Console.WriteLine();



        // Integer array of 3 values.
        int[] array1 = new int[3];
        array1[0] = 4;
        array1[1] = 5;
        array1[2] = 6;

        // Use ConvertAll to convert integer array to string array.
        string[] array2 = Array.ConvertAll(array1,
            element => element.ToString());

        // Write string array.
        Console.WriteLine(string.Join(",", array2));

        Console.ReadLine();

    }
}
//Before converting to-upper: Blah Foo Canonical
//Converted to upper-case: BLAH FOO CANONICAL

//4,5,6