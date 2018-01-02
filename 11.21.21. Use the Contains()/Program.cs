using System;
using System.Collections;

//	11.21.21.	Use the Contains() method to determine if the string 'text' is in the ArrayList

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


        if (myArrayList.Contains("text"))
        {
            int index = myArrayList.IndexOf("text");
            Console.WriteLine("myArrayList does contain the word 'text'");
            Console.WriteLine("'text' first occurs at index " + index);
            index = myArrayList.LastIndexOf("text");
            Console.WriteLine("'text' last occurs at index " + index);
        }

    }
}