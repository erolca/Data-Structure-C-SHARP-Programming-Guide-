using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


//11.34.3.	Converting a list from list of string to list of int


public class MainClass
{
    public static void Main()
    {
        List<string> stringList1 = new List<string>(new string[] { "99", "182", "15" });
        List<int> intList1 = stringList1.ConvertAll<int>(Convert.ToInt32);

    }
}