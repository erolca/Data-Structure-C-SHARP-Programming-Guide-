using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;

class MainClass
{
    static IEnumerable<int> CountWithTimeLimit(DateTime limit)
    {
        for (int i = 1; i <= 5; i++)
        {
            if (DateTime.Now >= limit)
            {
                yield break;
            }
            yield return i;
        }
    }

    static void Main()
    {
        DateTime stop = DateTime.Now.AddSeconds(2);
        foreach (int i in CountWithTimeLimit(stop))
        {
            Console.WriteLine("Received {0}", i);
            Thread.Sleep(100);
        }
    }
}