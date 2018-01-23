using System;
using System.Collections;

class MyClass
{
    public IEnumerator GetEnumerator()
    {
        yield return 'A';
        yield return 'B';
        yield return 'C';
        yield return 'D';
        yield return 'E';
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
//A B C D E