using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


//11.34.1.	Obtaining a read-only copy of a list


public class MainClass
{
    public static void Main()
    {
        List<int> intList = new List<int>(new int[] { 3, 5, 15, 1003, 25 });
        ReadOnlyCollection<int> roList = intList.AsReadOnly();
    }
}