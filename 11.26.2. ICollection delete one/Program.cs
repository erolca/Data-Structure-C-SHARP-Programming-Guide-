using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

//11.26.2.	ICollection: delete one

public class MainClass
{

    public static void Main()
    {
        ICollection<int> myCollection = new Collection<int>();

        myCollection.Add(105);
        myCollection.Add(232);
        myCollection.Add(350);

        myCollection.Remove(232);
    }
}