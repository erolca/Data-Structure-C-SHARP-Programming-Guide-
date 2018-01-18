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

        salaryMap.Remove("W");

        //??
        Dictionary<string, decimal> dd = new Dictionary<string, decimal>();
        dd.Add("S", 60.5M);
        dd.Add("W", 10.0M);
        dd.Add("J", 30.99M);
        dd.Remove("W");    


    }
}