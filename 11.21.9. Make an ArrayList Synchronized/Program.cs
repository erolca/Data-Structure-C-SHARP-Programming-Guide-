using System;
using System.Collections;

class MainClass
{
    static void Main(string[] args)
    {
        ArrayList a = new ArrayList(10);
        ArrayList.Synchronized(a);

        for (int i = 0; i < 10; i++)
            a.Add(i*3);
        
        foreach (var item in a)
        {

            Console.WriteLine("{0}" , (int)item);

        }
    }
}