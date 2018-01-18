using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        IDictionary<string, decimal> salaryMap = new Dictionary<string, decimal>();

        salaryMap.Add("S", 60.5M);
        salaryMap.Add("W", 10.0M);
        salaryMap.Add("J", 30.99M);

        foreach (KeyValuePair<string, decimal> kvp in salaryMap)
            Console.WriteLine("{0} == {1}", kvp.Key, kvp.Value);



        
    }
}
//S == 60.5
//W == 10.0
//J == 30.99