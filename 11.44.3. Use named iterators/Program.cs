using System;
using System.Collections;

class MyClass
{
    char ch = '1';

    public IEnumerable MyItr(int end)
    {
        for (int i = 0; i < end; i++)
            yield return (char)(ch + i);
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        foreach (char ch in mc.MyItr(7))
            Console.Write(ch + " ");

        Console.WriteLine("\n");

    }
}
//1 2 3 4 5 6 7