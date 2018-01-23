using System;
using System.Collections;

class MyClass
{
    char[] chrs = { 'A', 'B', 'C', 'D' };

    public IEnumerator GetEnumerator()
    {
        foreach (char ch in chrs)
            yield return ch;
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        foreach (char ch in mc)
            Console.Write(ch + " ");

        Console.WriteLine();
    }
}
//A B C D