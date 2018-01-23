using System;
using System.Collections;

class MyClass
{
    char ch = '1';

    public IEnumerable MyItr(int begin, int end)
    {
        for (int i = begin; i < end; i++)
            yield return (char)(ch + i);
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        foreach (char ch in mc.MyItr(5, 12))
            Console.Write(ch + " ");

        Console.WriteLine();
    }
}
//6 7 8 9 : ; <