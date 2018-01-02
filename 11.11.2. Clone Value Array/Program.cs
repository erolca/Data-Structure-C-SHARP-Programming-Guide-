using System;

class MainClass
{
    static void Main()
    {
        int[] orignalArray = { 1, 2, 3 };
        int[] cloneArray = (int[])orignalArray.Clone();

        cloneArray[0] = 10;
        cloneArray[1] = 20;
        cloneArray[2] = 30;

        foreach (int i in orignalArray)
            Console.WriteLine(i);

        foreach (int i in cloneArray)
            Console.WriteLine(i);
    }
}
//1
//2
//3
//10
//20
//30