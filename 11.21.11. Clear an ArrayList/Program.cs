using System;
using System.Collections;

class MainClass
{
    static void Main(string[] args)
    {
        ArrayList a = new ArrayList(10);
        int x = 0;

        a.Add(++x);
        a.Add(++x);
        a.Add(++x);
        a.Add(++x);

        a.Remove(x);

        a.RemoveAt(0);
        a.Clear();
    }
}