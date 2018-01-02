using System;
using System.Collections;

//11.21.19.	Insert(), AddRange(), and InsertRange() methods

class MainClass
{
    public static void Main()
    {
        ArrayList myArrayList = new ArrayList();

        myArrayList.Add("is");
        myArrayList.Insert(1, "is");
        string[] myStringArray = { "a", "test" };
        myArrayList.AddRange(myStringArray);
        string[] anotherStringArray = { "Here's", "some", "more", "text" };
        myArrayList.InsertRange(myArrayList.Count, anotherStringArray);

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
//myArrayList[0] = is
//myArrayList[1] = is
//myArrayList[2] = a
//myArrayList[3] = test
//myArrayList[4] = Here's
//myArrayList[5] = some
//myArrayList[6] = more
//myArrayList[7] = text
