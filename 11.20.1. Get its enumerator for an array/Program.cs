using System;
using System.Collections;

class MainClass
{
    static void Main()
    {
        int[] intArray = { 10, 11, 12, 13 };

        IEnumerator ie = intArray.GetEnumerator();
        while (ie.MoveNext() == true)
        {
            int i = (int)ie.Current;
            Console.WriteLine("{0}", i);
        }
    }
}
//10
//11
//12
//13