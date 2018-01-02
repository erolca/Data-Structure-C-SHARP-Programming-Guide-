using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        ArrayList myArrayList = new ArrayList();

        myArrayList.Add("This");
        myArrayList.Add("is");
        myArrayList.Add("a");
        myArrayList.Add("test");

        ArrayList anotherArrayList = new ArrayList(myArrayList);

        Console.WriteLine(anotherArrayList);
        foreach (string item in anotherArrayList)
        {
            Console.WriteLine(item);
        }
       

    }

}