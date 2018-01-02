using System;

//11.1.10.	Array Inherited Members: get array type

class MainClass
{
    static void Main()
    {
        int[] arr = new int[] { 15, 20, 5, 25, 10 };

        Console.WriteLine("GetType()    = {0}", arr.GetType());
    }
}
//GetType()    = System.Int3w2[]