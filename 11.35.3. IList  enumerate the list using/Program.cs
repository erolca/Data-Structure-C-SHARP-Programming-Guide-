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


        for (int i = 0; i < myList.Count; i++)
            Console.WriteLine(myList[i]);
    }
}
//10.5
//3.999
//209.224
//48.2