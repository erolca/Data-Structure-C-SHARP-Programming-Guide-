using System;
using System.Collections;

//11.21.20.	Use the SetRange() method to copy the elements 
//from anotherStringArray to myArrayList, starting at index 0

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


        DisplayArrayList("myArrayList", myArrayList);
    }
    public static void DisplayArrayList(string arrayListName, ArrayList myArrayList)
    {
        for (int i = 0; i < myArrayList.Count; i++)
        {
            Console.WriteLine(arrayListName + "[" + i + "] = " +
              myArrayList[i]);
        }
    }

}