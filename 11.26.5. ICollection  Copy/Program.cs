using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

//11.26.5.	ICollection: Copy the contents to an array to iterate it

public class MainClass
{

    public static void Main()
    {
        ICollection<int> myCollection = new Collection<int>();
        int[] myArray;

        myCollection.Add(105);
        myCollection.Add(232);
        myCollection.Add(350);

      myArray = new int[myCollection.Count];
        myCollection.CopyTo(myArray, 0); //copy to array

        for (int i = 0; i < myArray.Length; i++)
            Console.WriteLine(myArray[i]);

    }
}
//105
//232
//350