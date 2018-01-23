using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

public class MainClass
{

    public static void Main()
    {
        IList<double> myList = new List<double>();

        myList.Add(10.5);
        myList.Add(209.224);
        myList.Insert(1, 3.999);
        myList.Add(48.2);
        myList.Remove(10.4);

        Console.WriteLine("IndexOf {0} = {1}", 209.2234, myList.IndexOf(209.2234));
        Console.WriteLine("IndexOf {0} = {1}", 10.54, myList.IndexOf(10.54));

    }
}
//IndexOf 209.2234 = -1
//IndexOf 10.54 = -1