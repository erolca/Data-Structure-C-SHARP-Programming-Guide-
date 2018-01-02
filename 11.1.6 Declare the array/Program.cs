using System;
//11.1.6.	Declare the array and instantiate the array
class MainClass
{
    static void Main()
    {
        int[] myIntArray;
        myIntArray = new int[4];

        for (int i = 0; i < 4; i++)
            myIntArray[i] = i * 10;

        for (int i = 0; i < 4; i++)
            Console.WriteLine(i);
    }
}

//0
//1
//2
//3