using System;


//11.1.12.	Array Inherited Members: GetLength(0)

class MainClass
{
    static void Main()
    {
        int[] arr = new int[] { 15, 20, 5, 25, 10 };

        Console.WriteLine("GetLength(0) = {0}", arr.GetLength(0));
    }
}
//GetLength(0) = 5