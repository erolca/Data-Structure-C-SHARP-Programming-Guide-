using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;

class MainClass
{
    static IEnumerable<int> CountWithTimeLimit(DateTime limit)
    {
        try
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
        finally
        {
            Console.WriteLine("Stopping!");
        }
    }
    static void Main()
    {
        DateTime stop = DateTime.Now.AddSeconds(20);
        foreach (int i in CountWithTimeLimit(stop))
        {
            Console.WriteLine("Received {0}", i);
            Thread.Sleep(100);
        }
    }
}