using System;
using System.Collections;

//11.21.23.	Remove element 0, first 'text' element, and two elements starting at index 3

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


        myArrayList.RemoveAt(0);
        myArrayList.Remove("text");
        myArrayList.RemoveRange(3, 2);
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