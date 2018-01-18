using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


//	11.30.5.	IDictionary: iterate over the map and add up the values


public class MainClass
{
    public static void Main()
    {
        IDictionary<string, decimal> salaryMap = new Dictionary<string, decimal>();

        salaryMap.Add("S", 60.5M);
        salaryMap.Add("W", 10.0M);
        salaryMap.Add("J", 30.99M);
        decimal total = 0.0M;
        foreach (decimal d in salaryMap.Values)
            total += d;
        Console.WriteLine("{0:C}", total);





    }
}
//$101.49