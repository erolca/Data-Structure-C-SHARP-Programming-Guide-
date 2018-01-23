using System;
using System.Collections;

class MyClass
{
    char ch = 'A';

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < 26; i++)
        {
            if (i == 10)
                yield break; // stop iterator early 
            yield return (char)(ch + i);
        }
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
//A B C D E F G H I J