using System;
using System.Drawing;
using System.Collections.Generic;

// Array.ConvertAll<TInput, TOutput> Yöntemi 
//(TInput[], Converter<TInput, TOutput>)


//11.19.1.	Array.ConvertAll: convert all elements from one type to another type


public class MainClass
{

    public static void Main()
    {
        string[] strArray = new string[] { "75.3", "25.999", "105.25" };

        double[] doubleArray = Array.ConvertAll<string, double>(strArray, Convert.ToDouble);
        Console.Write("Converted to doubles: ");
        Array.ForEach<double>(doubleArray, delegate (double x) { Console.Write(x + " "); });
        Console.WriteLine();

       

     

    }




}
//Converted to doubles: 75.3 25.999 105.25