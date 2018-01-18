using System;
using System.Collections;

//11.29.5.	Mark a Hashtable to be Synchronized

class MainClass
{
    static void Main(string[] args)
    {
        Hashtable a = new Hashtable(10);
        Hashtable.Synchronized(a);

    }
}