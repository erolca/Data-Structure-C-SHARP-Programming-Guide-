using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


//	11.30.4.	IDictionary: Retrieve some values from the map


public class MainClass
{
    public static void Main()
    {
        IDictionary<string, decimal> salaryMap = new Dictionary<string, decimal>();

        salaryMap.Add("S", 60.5M);
        salaryMap.Add("W", 10.0M);
        salaryMap.Add("J", 30.99M);

        Console.WriteLine("{0:C}", salaryMap["S"]);
        Console.WriteLine("{0:C}", salaryMap["J"]);
    }
}
//$60.50
//$30.99