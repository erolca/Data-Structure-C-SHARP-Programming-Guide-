using System;
using System.Collections;


//	11.29.4.	Clear all key/value pairs in a Hashtable


class MainClass
{
    static void Main(string[] args)
    {
        Hashtable a = new Hashtable(10);

        a.Add(100, "Arrays");
        a.Add(200, "Classes");

        a.Clear();
    }
}