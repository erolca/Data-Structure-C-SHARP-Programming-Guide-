using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;


//11.35.1.	IList: add, insert, and remove some items


public class MainClass
{

    public static void Main()
    {
        IList<double> myList = new List<double>();

        myList.Add(1.54);
        myList.Add(29.2234);
        myList.Insert(1, 39.99);
        myList.Add(48.2);
        myList.Remove(10.4);

    }
}