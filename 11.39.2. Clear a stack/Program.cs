using System;
using System.Collections;

class MainClass
{
    static void Main(string[] args)
    {
        Stack a = new Stack(10);
        int x = 0;

        a.Push(x);
        x++;
        a.Push(x);
        foreach (int y in a)
        {
            Console.WriteLine(y);
        }

        a.Pop();
        a.Clear();
    }
}
//1
//0