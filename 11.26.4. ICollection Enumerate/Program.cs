using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

public class MainClass
{

    public static void Main()
    {
        ICollection<int> myCollection = new Collection<int>();

        myCollection.Add(105);
        myCollection.Add(232);
        myCollection.Add(350);

        foreach (int i in myCollection) //enumerate
            Console.WriteLine(i);

    }
}
//105
//232
//350