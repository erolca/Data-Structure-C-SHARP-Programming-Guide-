using System;
using System.Collections;


//11.21.28.	Use the Reset() method and access the first row again using MoveNext()

class MainClass
{
    public static void Main()
    {
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");


        string[] anotherStringArray = { "Here's", "some", "more", "text" };
        myArrayList.SetRange(0, anotherStringArray);

        Console.WriteLine("Using the GetEnumerator() method to get an enumerator");
        IEnumerator myEnumerator = myArrayList.GetEnumerator();
        while (myEnumerator.MoveNext())
        {
            Console.WriteLine("myEnumerator.Current = " + myEnumerator.Current);
        }
    }
}