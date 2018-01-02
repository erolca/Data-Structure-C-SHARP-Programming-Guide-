using System;
using System.Collections;

//11.21.10.	Insert and remove at specific index

class MainClass
{
    static void Main(string[] args)
    {
        ArrayList a = new ArrayList(10);
        int x = 0;

        a.Add(++x);
        a.Add(++x);
        a.Add(++x);


        a.Remove(x);

        a.RemoveAt(0);
    }
}