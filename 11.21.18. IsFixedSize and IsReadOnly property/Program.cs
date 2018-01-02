using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        ArrayList myArrayList = new ArrayList();

        Console.WriteLine("myArrayList.IsFixedSize = " + myArrayList.IsFixedSize);
        Console.WriteLine("myArrayList.IsReadOnly = " + myArrayList.IsReadOnly);

    }
}
//myArrayList.IsFixedSize = False
//myArrayList.IsReadOnly = False