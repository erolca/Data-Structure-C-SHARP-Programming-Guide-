using System;
using System.Collections;


//11.29.6.	Remove key/value pairs from Hashtable


class MainClass
{
    static void Main(string[] args)
    {
        Hashtable a = new Hashtable(10);

        a.Add(100, "A");
        a.Add(200, "C");


        a.Remove(100);
        a.Remove(200);

    }
}