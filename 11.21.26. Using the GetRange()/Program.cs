using System;
using System.Collections;

//11.21.26.	Using the GetRange() method to get two elements from myArrayList, starting at index 1

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

        ArrayList anotherArrayList = myArrayList.GetRange(1, 2);
        DisplayArrayList("anotherArrayList", anotherArrayList);

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

//anotherArrayList[0] = some
//anotherArrayList[1] = more